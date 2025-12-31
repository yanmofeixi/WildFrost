using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Injection;
using System;
using System.Reflection;
using UnityEngine;

namespace WildFrostPlugin
{
    /// <summary>
    /// WildFrost Mod
    /// 功能：
    /// 1. 按 + 键增加 100 金币
    /// 2. 禁用战斗中每回合的自动保存
    /// 3. 无限挂饰槽位 - 移除卡牌挂饰数量限制
    /// 4. 重抽铃永远ready - 随时可以使用重抽铃
    /// </summary>
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        internal static ManualLogSource Logger;
        
        // Harmony 实例
        private Harmony _harmony;
        


        public override void Load()
        {
            Logger = Log;
            Logger.LogInfo($"{PluginInfo.PLUGIN_NAME} is loading...");

            try
            {
                // 初始化 Harmony 并应用 patches
                _harmony = new Harmony(PluginInfo.PLUGIN_GUID);
                ApplyPatches();
                
                // 注册自定义 MonoBehaviour
                ClassInjector.RegisterTypeInIl2Cpp<GoldInputHandler>();
                
                // 创建输入处理器
                var inputHandler = new GameObject("WildFrostPlugin_InputHandler");
                inputHandler.AddComponent<GoldInputHandler>();
                UnityEngine.Object.DontDestroyOnLoad(inputHandler);
                inputHandler.hideFlags = HideFlags.HideAndDontSave;
                
                Logger.LogInfo("Plugin initialized successfully!");
                Logger.LogInfo("  - Press '+' (NumPad) or '=' to gain 100 gold.");
                Logger.LogInfo("  - In-battle turn-end saves are DISABLED.");
                Logger.LogInfo("  - UNLIMITED charm slots enabled! (无限挂饰槽位)");
                Logger.LogInfo("  - Press '1' (NumPad) to toggle Redraw Bell always ready (重抽铃永远ready)");
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to initialize plugin: {ex}");
            }
        }
        
        /// <summary>
        /// 应用 Harmony patches
        /// </summary>
        private void ApplyPatches()
        {
            try
            {
                // Patch 1: 禁用战斗中保存
                PatchBattleSaveSystem();
                
                // Patch 2: 无限挂饰槽位
                PatchUnlimitedCharmSlots();
                
                // Patch 3: 重抽铃永远ready
                PatchRedrawBellAlwaysReady();
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to apply Harmony patches: {ex}");
            }
        }
        
        /// <summary>
        /// 修补 BattleSaveSystem.BattleTurnEnd 方法，禁用战斗中保存
        /// </summary>
        private void PatchBattleSaveSystem()
        {
            try
            {
                var battleSaveSystemType = typeof(BattleSaveSystem);
                var battleTurnEndMethod = battleSaveSystemType.GetMethod("BattleTurnEnd", 
                    BindingFlags.Public | BindingFlags.Instance);
                
                if (battleTurnEndMethod != null)
                {
                    var prefixMethod = typeof(BattleSavePatches).GetMethod("BattleTurnEnd_Prefix", 
                        BindingFlags.Public | BindingFlags.Static);
                    
                    _harmony.Patch(battleTurnEndMethod, 
                        prefix: new HarmonyMethod(prefixMethod));
                    
                    Logger.LogInfo("Successfully patched BattleSaveSystem.BattleTurnEnd - In-battle saving disabled!");
                }
                else
                {
                    Logger.LogWarning("Could not find BattleSaveSystem.BattleTurnEnd method to patch.");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to patch BattleSaveSystem: {ex}");
            }
        }
        
        /// <summary>
        /// 修补 CardUpgradeData.CheckSlots 方法，实现无限挂饰槽位
        /// </summary>
        private void PatchUnlimitedCharmSlots()
        {
            try
            {
                var cardUpgradeDataType = typeof(CardUpgradeData);
                var checkSlotsMethod = cardUpgradeDataType.GetMethod("CheckSlots", 
                    BindingFlags.Public | BindingFlags.Instance);
                
                if (checkSlotsMethod != null)
                {
                    var prefixMethod = typeof(CharmSlotPatches).GetMethod("CheckSlots_Prefix", 
                        BindingFlags.Public | BindingFlags.Static);
                    
                    _harmony.Patch(checkSlotsMethod, 
                        prefix: new HarmonyMethod(prefixMethod));
                    
                    Logger.LogInfo("Successfully patched CardUpgradeData.CheckSlots - Unlimited charm slots enabled! (无限挂饰槽位)");
                }
                else
                {
                    Logger.LogWarning("Could not find CardUpgradeData.CheckSlots method to patch.");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to patch CardUpgradeData.CheckSlots: {ex}");
            }
        }
        /// <summary>
        /// 修补 RedrawBellSystem，让重抽铃永远ready
        /// </summary>
        private void PatchRedrawBellAlwaysReady()
        {
            try
            {
                var redrawBellSystemType = typeof(RedrawBellSystem);
                
                // Patch 1: Activate 方法 - 在使用后恢复铃铛状态
                var activateMethod = redrawBellSystemType.GetMethod("Activate", 
                    BindingFlags.Public | BindingFlags.Instance);
                
                if (activateMethod != null)
                {
                    var postfixMethod = typeof(RedrawBellPatches).GetMethod("Activate_Postfix", 
                        BindingFlags.Public | BindingFlags.Static);
                    
                    _harmony.Patch(activateMethod, 
                        postfix: new HarmonyMethod(postfixMethod));
                    
                    Logger.LogInfo("Successfully patched RedrawBellSystem.Activate");
                }
                else
                {
                    Logger.LogWarning("Could not find Activate method.");
                }
                
                Logger.LogInfo("Redraw Bell always ready patches applied! (重抽铃永远ready)");;
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to patch RedrawBellSystem: {ex}");
            }
        }
    }
    
    /// <summary>
    /// Harmony Patches for BattleSaveSystem
    /// 用于禁用战斗中的保存
    /// </summary>
    public static class BattleSavePatches
    {
        /// <summary>
        /// Prefix patch for BattleSaveSystem.BattleTurnEnd
        /// 返回 false 阻止原方法执行，从而禁用战斗中每回合的保存
        /// </summary>
        [HarmonyPrefix]
        public static bool BattleTurnEnd_Prefix(int turnCount)
        {
            Plugin.Logger.LogInfo($"[Patch] Blocked battle turn {turnCount} save (in-battle saving disabled)");
            return false; // 返回 false 阻止原方法执行
        }
    }
    
    /// <summary>
    /// Harmony Patches for CardUpgradeData
    /// 用于实现无限挂饰槽位
    /// </summary>
    public static class CharmSlotPatches
    {
        // CardUpgradeData.Type 枚举值
        // None = 0, Charm = 1, Token = 2, Crown = 3
        private const int TYPE_CHARM = 1;
        
        /// <summary>
        /// Prefix patch for CardUpgradeData.CheckSlots
        /// 只对挂饰类型（Charm）绕过槽位检查，皇冠和令牌保持正常限制
        /// </summary>
        [HarmonyPrefix]
        public static bool CheckSlots_Prefix(CardUpgradeData __instance, ref bool __result)
        {
            // 检查当前升级的类型
            // 如果是挂饰类型，直接返回 true 绕过检查
            if ((int)__instance.type == TYPE_CHARM)
            {
                __result = true;
                return false; // 跳过原方法
            }
            
            // 对于皇冠、令牌等其他类型，执行原方法进行正常检查
            return true;
        }
    }
    /// <summary>
    /// Harmony Patches for RedrawBellSystem
    /// 用于实现重抽铃永远ready
    /// </summary>
    public static class RedrawBellPatches
    {
        /// <summary>
        /// 开关：是否启用重抽铃永远ready功能
        /// </summary>
        public static bool Enabled = false;
        
        /// <summary>
        /// Postfix patch for RedrawBellSystem.Activate
        /// 在使用重抽铃后立即恢复其可用状态
        /// </summary>
        [HarmonyPostfix]
        public static void Activate_Postfix(RedrawBellSystem __instance)
        {
            if (!Enabled) return;
            try
            {
                __instance.interactable = true;
                __instance.BecomeInteractable();
                __instance.SetCounter(0);
            }
            catch (Exception ex)
            {
                Plugin.Logger.LogError($"[RedrawBell] Activate_Postfix error: {ex}");
            }
        }
    }
    
    public static class PluginInfo
    {
        public const string PLUGIN_GUID = "com.yanmo.WildFrostPlugin";
        public const string PLUGIN_NAME = "WildFrost Plugin";
        public const string PLUGIN_VERSION = "1.7.0";
    }

    /// <summary>
    /// 输入处理器
    /// + 键增加金币
    /// - 键切换物品伤害增强
    /// </summary>
    public class GoldInputHandler : MonoBehaviour
    {
        public GoldInputHandler(IntPtr ptr) : base(ptr) { }

        private Character _cachedPlayer;

        void Update()
        {
            // + 键增加金币
            if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
            {
                TryGainGold(100);
            }
            
            // 1 键切换重抽铃永远ready
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                RedrawBellPatches.Enabled = !RedrawBellPatches.Enabled;
                Plugin.Logger.LogInfo($"[RedrawBell] Always ready: {(RedrawBellPatches.Enabled ? "ON" : "OFF")}");
            }
        }

        private void TryGainGold(int amount)
        {
            var player = GetPlayerCharacter();
            if (player != null && player.data != null)
            {
                player.GainGold(amount);
                Plugin.Logger.LogInfo($"Added {amount} gold!");
            }
        }

        private Character GetPlayerCharacter()
        {
            if (_cachedPlayer != null) return _cachedPlayer;

            // 1. 尝试通过 References.Player 获取
            try 
            {
                var referencesType = Type.GetType("References, Assembly-CSharp");
                if (referencesType != null)
                {
                    var playerProp = referencesType.GetProperty("Player");
                    var playerObj = playerProp?.GetValue(null);
                    _cachedPlayer = playerObj as Character;
                    if (_cachedPlayer != null) return _cachedPlayer;
                }
            }
            catch { /* Ignore reflection errors */ }

            // 2. 后备方案：搜索场景
            var characters = UnityEngine.Object.FindObjectsOfType<Character>();
            foreach (var character in characters)
            {
                if (character != null && character.team == 0 && character.data != null)
                {
                    _cachedPlayer = character;
                    return _cachedPlayer;
                }
            }

            return null;
        }
    }
}

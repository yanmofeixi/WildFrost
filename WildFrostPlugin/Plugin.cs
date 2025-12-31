using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
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
    /// 4. 按 - 键切换物品伤害X10倍（战斗中生效）
    /// </summary>
    [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        internal static ManualLogSource Logger;
        
        // Harmony 实例
        private Harmony _harmony;
        
        // 物品伤害增强开关
        internal static bool ItemDamageBoostEnabled = false;

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
                Logger.LogInfo("  - Press '-' (NumPad) or '_' to toggle Item Damage x10.");
                Logger.LogInfo("  - In-battle turn-end saves are DISABLED.");
                Logger.LogInfo("  - UNLIMITED charm slots enabled! (无限挂饰槽位)");
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
                
                // Patch 3: 物品伤害增强
                PatchItemDamageBoost();
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
        /// 修补 Hit.Process 方法，实现物品伤害增强
        /// </summary>
        private void PatchItemDamageBoost()
        {
            try
            {
                var hitType = typeof(Hit);
                var processMethod = hitType.GetMethod("Process", 
                    BindingFlags.Public | BindingFlags.Instance);
                
                if (processMethod != null)
                {
                    var prefixMethod = typeof(ItemDamagePatches).GetMethod("Process_Prefix", 
                        BindingFlags.Public | BindingFlags.Static);
                    
                    _harmony.Patch(processMethod, 
                        prefix: new HarmonyMethod(prefixMethod));
                    
                    Logger.LogInfo("Successfully patched Hit.Process - Item damage boost ready! (Press '-' to toggle)");
                }
                else
                {
                    Logger.LogWarning("Could not find Hit.Process method to patch.");
                }
            }
            catch (Exception ex)
            {
                Logger.LogError($"Failed to patch Hit.Process: {ex}");
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
    /// Harmony Patches for Hit
    /// 用于实现物品伤害增强
    /// </summary>
    public static class ItemDamagePatches
    {
        private const int DAMAGE_MULTIPLIER = 10;
        
        /// <summary>
        /// Prefix patch for Hit.Process
        /// 在处理伤害前检查攻击者是否为物品，若是则将伤害乘以10
        /// </summary>
        [HarmonyPrefix]
        public static void Process_Prefix(Hit __instance)
        {
            if (!Plugin.ItemDamageBoostEnabled)
                return;
                
            try
            {
                var attacker = __instance.attacker;
                if (attacker == null || attacker.data == null)
                    return;
                
                var cardType = attacker.data.cardType;
                if (cardType == null)
                    return;
                
                // 检查是否为物品类型
                if (cardType.item)
                {
                    int originalDamage = __instance.damage;
                    if (originalDamage > 0)
                    {
                        __instance.damage = originalDamage * DAMAGE_MULTIPLIER;
                        Plugin.Logger.LogInfo($"[ItemBoost] {attacker.data.title}: {originalDamage} -> {__instance.damage} damage");
                    }
                }
            }
            catch (Exception ex)
            {
                Plugin.Logger.LogError($"Error in ItemDamagePatches.Process_Prefix: {ex.Message}");
            }
        }
    }
    
    public static class PluginInfo
    {
        public const string PLUGIN_GUID = "com.yanmo.WildFrostPlugin";
        public const string PLUGIN_NAME = "WildFrost Plugin";
        public const string PLUGIN_VERSION = "1.5.0";
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
            
            // - 键切换物品伤害增强
            if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
            {
                ToggleItemDamageBoost();
            }
        }
        
        private void ToggleItemDamageBoost()
        {
            Plugin.ItemDamageBoostEnabled = !Plugin.ItemDamageBoostEnabled;
            string status = Plugin.ItemDamageBoostEnabled ? "ENABLED" : "DISABLED";
            Plugin.Logger.LogInfo($"[ItemBoost] Item Damage x10: {status}");
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

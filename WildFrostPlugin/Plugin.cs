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
                // 获取 BattleSaveSystem.BattleTurnEnd 方法
                var battleSaveSystemType = typeof(BattleSaveSystem);
                var battleTurnEndMethod = battleSaveSystemType.GetMethod("BattleTurnEnd", 
                    BindingFlags.Public | BindingFlags.Instance);
                
                if (battleTurnEndMethod != null)
                {
                    // 创建 Prefix patch 来阻止方法执行
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
                Logger.LogError($"Failed to apply Harmony patches: {ex}");
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

    public static class PluginInfo
    {
        public const string PLUGIN_GUID = "com.yanmo.WildFrostPlugin";
        public const string PLUGIN_NAME = "WildFrost Plugin";
        public const string PLUGIN_VERSION = "1.2.0";
    }

    /// <summary>
    /// 金币输入处理器
    /// 按 + 键增加金币
    /// </summary>
    public class GoldInputHandler : MonoBehaviour
    {
        public GoldInputHandler(IntPtr ptr) : base(ptr) { }

        private Character _cachedPlayer;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.KeypadPlus) || Input.GetKeyDown(KeyCode.Equals))
            {
                TryGainGold(100);
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

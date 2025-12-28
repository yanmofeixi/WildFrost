# WildFrost Plugin

这是一个为 WildFrost (IL2CPP) 制作的 BepInEx 6 Mod。

## 功能

| 功能 | 按键/触发 | 说明 |
|------|-----------|------|
| **加金币** | `+` (数字键盘) 或 `=` | 每次增加 100 金币 |
| **禁用战斗中保存** | 自动 | 阻止游戏在战斗每回合结束时自动保存 |

### 禁用战斗中保存

- 使用 Harmony 库 Patch `BattleSaveSystem.BattleTurnEnd` 方法
- 游戏仍会在战斗开始前保存（这是游戏原有功能）
- 战斗过程中不会再保存，避免因战斗失败而丢失进度

## 安装

1. 确保安装了 [BepInEx 6 (IL2CPP)](https://builds.bepinex.dev/projects/bepinex_be)。
2. 将 `WildFrostPlugin.dll` 放入 `BepInEx/plugins/` 文件夹。

## 开发说明

- **项目文件**: `WildFrostAddGold.csproj`
- **构建**: 运行 `dotnet build`。构建成功后会自动将 DLL 复制到游戏插件目录。
- **依赖库**:
  - BepInEx 6 (IL2CPP)
  - HarmonyX (0Harmony.dll)
  - Il2CppInterop.Runtime

### 核心技术

- **Harmony Patching**: 使用 `HarmonyPrefix` 在目标方法执行前拦截并阻止执行
- **Il2Cpp MonoBehaviour 注入**: 使用 `ClassInjector.RegisterTypeInIl2Cpp` 注册自定义组件

## 故障排除

如果在控制台看到红色错误，请检查 `BepInEx/LogOutput.log`。

常见问题：
- 如果 Harmony Patch 失败，日志会显示 "Could not find BattleSaveSystem.BattleTurnEnd method to patch"
- 如果加金币无效，可能是因为玩家角色尚未加载

## 版本历史

- **v1.2.0**: 添加禁用战斗中保存功能
- **v1.1.0**: 添加战斗前保存功能（已移除，游戏本身已有）
- **v1.0.0**: 初始版本，按键加金币功能

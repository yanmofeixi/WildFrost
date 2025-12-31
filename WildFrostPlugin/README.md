# WildFrost Plugin

这是一个为 WildFrost (IL2CPP) 制作的 BepInEx 6 Mod。

## 功能

| 功能 | 按键/触发 | 说明 |
|------|-----------|------|
| **加金币** | `+` (数字键盘) 或 `=` | 每次增加 100 金币 |
| **禁用战斗中保存** | 自动 | 阻止游戏在战斗每回合结束时自动保存 |
| **无限挂饰槽位** | 自动 | 移除卡牌挂饰数量限制，可以给卡牌装备无限个挂饰 |
| **重抽铃永远ready** | `1` (数字键盘) | 切换开关，启用后重抽铃可无限使用 |

### 禁用战斗中保存

- 使用 Harmony 库 Patch `BattleSaveSystem.BattleTurnEnd` 方法
- 游戏仍会在战斗开始前保存（这是游戏原有功能）
- 战斗过程中不会再保存，避免因战斗失败而丢失进度

### 无限挂饰槽位

- 使用 Harmony 库 Patch `CardUpgradeData.CheckSlots` 方法
- **只对挂饰类型**绕过槽位检查（通过检测 `CardUpgradeData.Type == Charm`）
- 皇冠和令牌等其他类型的升级保持正常限制
- 允许给任何卡牌装备无限数量的挂饰

#### 技术方案

游戏中 `CardUpgradeData.Type` 枚举定义了四种升级类型：
- `None = 0`
- `Charm = 1` (挂饰)
- `Token = 2` (令牌)  
- `Crown = 3` (皇冠)

我们的 Patch 在 `CheckSlots` 被调用时检查升级类型，只有当类型为 `Charm` 时才绕过检查，其他类型正常执行原逻辑。

### 重抽铃永远ready

- 使用 Harmony 库 Patch `RedrawBellSystem.Activate` 方法
- 按 `1` 键（数字键盘）切换开关（默认关闭）
- 启用后，使用重抽铃后会立即恢复为可用状态
- 技术实现：在 `Activate` 执行后设置 `interactable=true`、`counter=0` 并调用 `BecomeInteractable()`

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

- **Harmony Patching**: 使用 `HarmonyPrefix` 和 `HarmonyPostfix` 拦截目标方法
- **Il2Cpp MonoBehaviour 注入**: 使用 `ClassInjector.RegisterTypeInIl2Cpp` 注册自定义组件
- **枚举类型检测**: 通过 `CardUpgradeData.Type` 精确区分升级类型
- **卡牌类型检测**: 通过 `CardType.item` 判断是否为物品

## 故障排除

如果在控制台看到红色错误，请检查 `BepInEx/LogOutput.log`。

常见问题：
- 如果 Harmony Patch 失败，日志会显示 "Could not find ... method to patch"
- 如果加金币无效，可能是因为玩家角色尚未加载

## 版本历史

- **v1.7.0**: 添加重抽铃永远ready功能，按 `1` 键切换
- **v1.5.0**: 添加物品伤害X10功能（已移除）
- **v1.4.0**: 修复无限挂饰功能影响皇冠的问题，现在只对挂饰类型生效
- **v1.3.0**: 添加无限挂饰槽位功能
- **v1.2.0**: 添加禁用战斗中保存功能
- **v1.1.0**: 添加战斗前保存功能（已移除，游戏本身已有）
- **v1.0.0**: 初始版本，按键加金币功能


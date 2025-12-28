using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

// Token: 0x0200038D RID: 909
public static class Events : Il2CppSystem.Object
{
	// Token: 0x06004445 RID: 17477 RVA: 0x00122758 File Offset: 0x00120958
	// Note: this type is marked as 'beforefieldinit'.
	static Events()
	{
		Il2CppClassPointerStore<Events>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Events");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events>.NativeClassPtr);
		Events.NativeFieldInfoPtr_OnSceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSceneLoaded");
		Events.NativeFieldInfoPtr_OnSceneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSceneChanged");
		Events.NativeFieldInfoPtr_OnSceneUnload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSceneUnload");
		Events.NativeFieldInfoPtr_OnBackToMainMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBackToMainMenu");
		Events.NativeFieldInfoPtr_OnEntityCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityCreated");
		Events.NativeFieldInfoPtr_OnEntityDataUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityDataUpdated");
		Events.NativeFieldInfoPtr_OnEntityDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityDestroyed");
		Events.NativeFieldInfoPtr_OnCardPooled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCardPooled");
		Events.NativeFieldInfoPtr_OnEntityEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityEnabled");
		Events.NativeFieldInfoPtr_OnEntityDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityDisabled");
		Events.NativeFieldInfoPtr_OnEntityKilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityKilled");
		Events.NativeFieldInfoPtr_OnEntityFlee = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityFlee");
		Events.NativeFieldInfoPtr_OnEntityHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityHover");
		Events.NativeFieldInfoPtr_OnEntityUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityUnHover");
		Events.NativeFieldInfoPtr_OnEntitySelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntitySelect");
		Events.NativeFieldInfoPtr_OnCheckEntityDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCheckEntityDrag");
		Events.NativeFieldInfoPtr_OnEntityDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityDrag");
		Events.NativeFieldInfoPtr_OnEntityRelease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityRelease");
		Events.NativeFieldInfoPtr_OnEntityOffered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityOffered");
		Events.NativeFieldInfoPtr_OnEntityChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityChosen");
		Events.NativeFieldInfoPtr_OnEntityShowUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityShowUnlocked");
		Events.NativeFieldInfoPtr_OnCheckEntityShove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCheckEntityShove");
		Events.NativeFieldInfoPtr_OnPreProcessTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnPreProcessTrigger");
		Events.NativeFieldInfoPtr_OnEntityPreTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityPreTrigger");
		Events.NativeFieldInfoPtr_OnEntityTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityTrigger");
		Events.NativeFieldInfoPtr_OnEntityTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityTriggered");
		Events.NativeFieldInfoPtr_OnEntityMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityMove");
		Events.NativeFieldInfoPtr_OnEntityPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityPlace");
		Events.NativeFieldInfoPtr_OnDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnDiscard");
		Events.NativeFieldInfoPtr_OnEntityHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityHit");
		Events.NativeFieldInfoPtr_OnEntityPostHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityPostHit");
		Events.NativeFieldInfoPtr_OnEntityDodge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityDodge");
		Events.NativeFieldInfoPtr_OnEntityFlipUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityFlipUp");
		Events.NativeFieldInfoPtr_OnEntityFlipDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityFlipDown");
		Events.NativeFieldInfoPtr_OnStatusIconCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnStatusIconCreated");
		Events.NativeFieldInfoPtr_OnStatusIconChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnStatusIconChanged");
		Events.NativeFieldInfoPtr_OnEntityDisplayUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityDisplayUpdated");
		Events.NativeFieldInfoPtr_OnEntityFocus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityFocus");
		Events.NativeFieldInfoPtr_OnEntityEnterPocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityEnterPocket");
		Events.NativeFieldInfoPtr_OnEntityEnterBackpack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityEnterBackpack");
		Events.NativeFieldInfoPtr_OnEntityChangePhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityChangePhase");
		Events.NativeFieldInfoPtr_OnNoomlinShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnNoomlinShow");
		Events.NativeFieldInfoPtr_OnNoomlinUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnNoomlinUsed");
		Events.NativeFieldInfoPtr_OnEntityFlipComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityFlipComplete");
		Events.NativeFieldInfoPtr_OnEntitySummoned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntitySummoned");
		Events.NativeFieldInfoPtr_OnEntityPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityPing");
		Events.NativeFieldInfoPtr_OnCheckRecycleAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCheckRecycleAmount");
		Events.NativeFieldInfoPtr_OnContainerHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnContainerHover");
		Events.NativeFieldInfoPtr_OnContainerUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnContainerUnHover");
		Events.NativeFieldInfoPtr_OnSlotHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSlotHover");
		Events.NativeFieldInfoPtr_OnSlotUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSlotUnHover");
		Events.NativeFieldInfoPtr_OnActionQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnActionQueued");
		Events.NativeFieldInfoPtr_OnActionPerform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnActionPerform");
		Events.NativeFieldInfoPtr_OnActionFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnActionFinished");
		Events.NativeFieldInfoPtr_OnCheckAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCheckAction");
		Events.NativeFieldInfoPtr_OnAbilityTargetAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnAbilityTargetAdd");
		Events.NativeFieldInfoPtr_OnAbilityTargetRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnAbilityTargetRemove");
		Events.NativeFieldInfoPtr_OnCardDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCardDraw");
		Events.NativeFieldInfoPtr_OnCardDrawEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCardDrawEnd");
		Events.NativeFieldInfoPtr_PreBattleSetUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "PreBattleSetUp");
		Events.NativeFieldInfoPtr_PostBattleSetUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "PostBattleSetUp");
		Events.NativeFieldInfoPtr_OnBattlePhaseStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattlePhaseStart");
		Events.NativeFieldInfoPtr_OnBattleStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleStart");
		Events.NativeFieldInfoPtr_PreBattleEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "PreBattleEnd");
		Events.NativeFieldInfoPtr_OnBattleEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleEnd");
		Events.NativeFieldInfoPtr_OnBattleWinPreRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleWinPreRewards");
		Events.NativeFieldInfoPtr_OnBattleWin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleWin");
		Events.NativeFieldInfoPtr_PostBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "PostBattle");
		Events.NativeFieldInfoPtr_OnStatusEffectCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnStatusEffectCountDown");
		Events.NativeFieldInfoPtr_OnStatusEffectApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnStatusEffectApplied");
		Events.NativeFieldInfoPtr_OnPreProcessUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnPreProcessUnits");
		Events.NativeFieldInfoPtr_OnPostProcessUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnPostProcessUnits");
		Events.NativeFieldInfoPtr_OnEntityCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEntityCountDown");
		Events.NativeFieldInfoPtr_OnBattlePreTurnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattlePreTurnStart");
		Events.NativeFieldInfoPtr_OnBattleTurnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleTurnStart");
		Events.NativeFieldInfoPtr_OnBattleTurnEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleTurnEnd");
		Events.NativeFieldInfoPtr_OnMinibossIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMinibossIntro");
		Events.NativeFieldInfoPtr_OnMinibossIntroDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMinibossIntroDone");
		Events.NativeFieldInfoPtr_OnKillCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnKillCombo");
		Events.NativeFieldInfoPtr_OnRedrawBellHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnRedrawBellHit");
		Events.NativeFieldInfoPtr_OnRedrawBellRevealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnRedrawBellRevealed");
		Events.NativeFieldInfoPtr_OnCardInjured = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCardInjured");
		Events.NativeFieldInfoPtr_OnBattleStateBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleStateBuild");
		Events.NativeFieldInfoPtr_OnBattleStateBuilt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleStateBuilt");
		Events.NativeFieldInfoPtr_OnCharacterActionPerformed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCharacterActionPerformed");
		Events.NativeFieldInfoPtr_OnWaveDeployerPreCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnWaveDeployerPreCountDown");
		Events.NativeFieldInfoPtr_OnWaveDeployerPostCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnWaveDeployerPostCountDown");
		Events.NativeFieldInfoPtr_OnWaveDeployerEarlyDeploy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnWaveDeployerEarlyDeploy");
		Events.NativeFieldInfoPtr_OnMapPathReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMapPathReveal");
		Events.NativeFieldInfoPtr_OnMapNodeReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMapNodeReveal");
		Events.NativeFieldInfoPtr_OnMapNodeSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMapNodeSelect");
		Events.NativeFieldInfoPtr_OnMapNodeHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMapNodeHover");
		Events.NativeFieldInfoPtr_OnMapNodeUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMapNodeUnHover");
		Events.NativeFieldInfoPtr_OnTownUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnTownUnlock");
		Events.NativeFieldInfoPtr_OnShopItemHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnShopItemHover");
		Events.NativeFieldInfoPtr_OnShopItemUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnShopItemUnHover");
		Events.NativeFieldInfoPtr_OnShopItemPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnShopItemPurchase");
		Events.NativeFieldInfoPtr_OnShopItemHaggled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnShopItemHaggled");
		Events.NativeFieldInfoPtr_OnPopupCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnPopupCreated");
		Events.NativeFieldInfoPtr_OnButtonHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnButtonHover");
		Events.NativeFieldInfoPtr_OnButtonPress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnButtonPress");
		Events.NativeFieldInfoPtr_OnAudioVolumeChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnAudioVolumeChange");
		Events.NativeFieldInfoPtr_OnAudioPitchChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnAudioPitchChange");
		Events.NativeFieldInfoPtr_OnBombardShoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBombardShoot");
		Events.NativeFieldInfoPtr_OnBombardRocketFall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBombardRocketFall");
		Events.NativeFieldInfoPtr_OnBombardRocketExplode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBombardRocketExplode");
		Events.NativeFieldInfoPtr_OnProgressStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnProgressStart");
		Events.NativeFieldInfoPtr_OnProgressUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnProgressUpdate");
		Events.NativeFieldInfoPtr_OnProgressStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnProgressStop");
		Events.NativeFieldInfoPtr_OnProgressDing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnProgressDing");
		Events.NativeFieldInfoPtr_OnProgressBlip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnProgressBlip");
		Events.NativeFieldInfoPtr_OnSaveSystemEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSaveSystemEnabled");
		Events.NativeFieldInfoPtr_OnSaveSystemDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSaveSystemDisabled");
		Events.NativeFieldInfoPtr_OnSaveSystemProfileChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSaveSystemProfileChanged");
		Events.NativeFieldInfoPtr_OnCampaignSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignSaved");
		Events.NativeFieldInfoPtr_OnCampaignLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignLoaded");
		Events.NativeFieldInfoPtr_OnCampaignDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignDeleted");
		Events.NativeFieldInfoPtr_OnBattleSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleSaved");
		Events.NativeFieldInfoPtr_OnBattleLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnBattleLoaded");
		Events.NativeFieldInfoPtr_OnGameStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnGameStart");
		Events.NativeFieldInfoPtr_OnGameEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnGameEnd");
		Events.NativeFieldInfoPtr_OnCampaignStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignStart");
		Events.NativeFieldInfoPtr_OnCampaignFinal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignFinal");
		Events.NativeFieldInfoPtr_OnCampaignEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignEnd");
		Events.NativeFieldInfoPtr_OnOverallStatsSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnOverallStatsSaved");
		Events.NativeFieldInfoPtr_OnCampaignDataCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignDataCreated");
		Events.NativeFieldInfoPtr_OnCampaignPreInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignPreInit");
		Events.NativeFieldInfoPtr_OnCampaignInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignInit");
		Events.NativeFieldInfoPtr_OnPreCampaignPopulate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnPreCampaignPopulate");
		Events.NativeFieldInfoPtr_OnCampaignNodesCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignNodesCreated");
		Events.NativeFieldInfoPtr_OnCampaignLoadPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignLoadPreset");
		Events.NativeFieldInfoPtr_OnCampaignGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCampaignGenerated");
		Events.NativeFieldInfoPtr_OnStatChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnStatChanged");
		Events.NativeFieldInfoPtr_OnUpgradeGained = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnUpgradeGained");
		Events.NativeFieldInfoPtr_OnUpgradeAssign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnUpgradeAssign");
		Events.NativeFieldInfoPtr_OnUpgradeHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnUpgradeHover");
		Events.NativeFieldInfoPtr_OnUpgradePickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnUpgradePickup");
		Events.NativeFieldInfoPtr_OnUpgradeDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnUpgradeDrop");
		Events.NativeFieldInfoPtr_OnUpdateInputSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnUpdateInputSystem");
		Events.NativeFieldInfoPtr_OnScreenShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnScreenShake");
		Events.NativeFieldInfoPtr_OnScreenRumble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnScreenRumble");
		Events.NativeFieldInfoPtr_OnCameraAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCameraAnimation");
		Events.NativeFieldInfoPtr_OnDropGold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnDropGold");
		Events.NativeFieldInfoPtr_OnGoldFlyToBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnGoldFlyToBag");
		Events.NativeFieldInfoPtr_OnCollectGold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCollectGold");
		Events.NativeFieldInfoPtr_OnSpendGold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSpendGold");
		Events.NativeFieldInfoPtr_OnTimeScaleChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnTimeScaleChange");
		Events.NativeFieldInfoPtr_OnInspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnInspect");
		Events.NativeFieldInfoPtr_OnInspectEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnInspectEnd");
		Events.NativeFieldInfoPtr_OnInspectNewCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnInspectNewCard");
		Events.NativeFieldInfoPtr_OnCardControllerEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCardControllerEnabled");
		Events.NativeFieldInfoPtr_OnCardControllerDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCardControllerDisabled");
		Events.NativeFieldInfoPtr_OnDeckpackOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnDeckpackOpen");
		Events.NativeFieldInfoPtr_OnDeckpackClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnDeckpackClose");
		Events.NativeFieldInfoPtr_OnTransitionStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnTransitionStart");
		Events.NativeFieldInfoPtr_OnTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnTransitionEnd");
		Events.NativeFieldInfoPtr_OnSetWeatherIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSetWeatherIntensity");
		Events.NativeFieldInfoPtr_OnGoldCounterStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnGoldCounterStart");
		Events.NativeFieldInfoPtr_OnEventStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEventStart");
		Events.NativeFieldInfoPtr_OnEventPopulated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnEventPopulated");
		Events.NativeFieldInfoPtr_OnMuncherDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMuncherDrag");
		Events.NativeFieldInfoPtr_OnMuncherDragCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMuncherDragCancel");
		Events.NativeFieldInfoPtr_OnMuncherFeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnMuncherFeed");
		Events.NativeFieldInfoPtr_OnSettingChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnSettingChanged");
		Events.NativeFieldInfoPtr_OnUINavigationReset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnUINavigationReset");
		Events.NativeFieldInfoPtr_OnUINavigation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnUINavigation");
		Events.NativeFieldInfoPtr_OnButtonStyleChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnButtonStyleChanged");
		Events.NativeFieldInfoPtr_OnControllerSwitched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnControllerSwitched");
		Events.NativeFieldInfoPtr_OnCheckRename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCheckRename");
		Events.NativeFieldInfoPtr_OnRename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnRename");
		Events.NativeFieldInfoPtr_OnPullRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnPullRewards");
		Events.NativeFieldInfoPtr_OnCardDataCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnCardDataCreated");
		Events.NativeFieldInfoPtr_OnTutorialProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnTutorialProgress");
		Events.NativeFieldInfoPtr_OnTutorialSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnTutorialSkip");
		Events.NativeFieldInfoPtr_OnChallengeCompletedSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnChallengeCompletedSaved");
		Events.NativeFieldInfoPtr_OnGetHandSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events>.NativeClassPtr, "OnGetHandSize");
		Events.NativeMethodInfoPtr_add_OnSceneLoaded_Public_Static_add_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100673993);
		Events.NativeMethodInfoPtr_remove_OnSceneLoaded_Public_Static_rem_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100673994);
		Events.NativeMethodInfoPtr_InvokeSceneLoaded_Public_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100673995);
		Events.NativeMethodInfoPtr_add_OnSceneChanged_Public_Static_add_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100673996);
		Events.NativeMethodInfoPtr_remove_OnSceneChanged_Public_Static_rem_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100673997);
		Events.NativeMethodInfoPtr_InvokeSceneChanged_Public_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100673998);
		Events.NativeMethodInfoPtr_add_OnSceneUnload_Public_Static_add_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100673999);
		Events.NativeMethodInfoPtr_remove_OnSceneUnload_Public_Static_rem_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674000);
		Events.NativeMethodInfoPtr_InvokeSceneUnload_Public_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674001);
		Events.NativeMethodInfoPtr_add_OnBackToMainMenu_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674002);
		Events.NativeMethodInfoPtr_remove_OnBackToMainMenu_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674003);
		Events.NativeMethodInfoPtr_InvokeBackToMainMenu_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674004);
		Events.NativeMethodInfoPtr_add_OnEntityCreated_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674005);
		Events.NativeMethodInfoPtr_remove_OnEntityCreated_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674006);
		Events.NativeMethodInfoPtr_InvokeEntityCreated_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674007);
		Events.NativeMethodInfoPtr_add_OnEntityDataUpdated_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674008);
		Events.NativeMethodInfoPtr_remove_OnEntityDataUpdated_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674009);
		Events.NativeMethodInfoPtr_InvokeEntityDataUpdated_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674010);
		Events.NativeMethodInfoPtr_add_OnEntityDestroyed_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674011);
		Events.NativeMethodInfoPtr_remove_OnEntityDestroyed_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674012);
		Events.NativeMethodInfoPtr_InvokeEntityDestroyed_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674013);
		Events.NativeMethodInfoPtr_add_OnCardPooled_Public_Static_add_Void_UnityAction_1_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674014);
		Events.NativeMethodInfoPtr_remove_OnCardPooled_Public_Static_rem_Void_UnityAction_1_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674015);
		Events.NativeMethodInfoPtr_InvokeCardPooled_Public_Static_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674016);
		Events.NativeMethodInfoPtr_add_OnEntityEnabled_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674017);
		Events.NativeMethodInfoPtr_remove_OnEntityEnabled_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674018);
		Events.NativeMethodInfoPtr_InvokeEntityEnabled_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674019);
		Events.NativeMethodInfoPtr_add_OnEntityDisabled_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674020);
		Events.NativeMethodInfoPtr_remove_OnEntityDisabled_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674021);
		Events.NativeMethodInfoPtr_InvokeEntityDisabled_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674022);
		Events.NativeMethodInfoPtr_add_OnEntityKilled_Public_Static_add_Void_UnityAction_2_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674023);
		Events.NativeMethodInfoPtr_remove_OnEntityKilled_Public_Static_rem_Void_UnityAction_2_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674024);
		Events.NativeMethodInfoPtr_InvokeEntityKilled_Public_Static_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674025);
		Events.NativeMethodInfoPtr_add_OnEntityFlee_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674026);
		Events.NativeMethodInfoPtr_remove_OnEntityFlee_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674027);
		Events.NativeMethodInfoPtr_InvokeEntityFlee_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674028);
		Events.NativeMethodInfoPtr_add_OnEntityHover_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674029);
		Events.NativeMethodInfoPtr_remove_OnEntityHover_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674030);
		Events.NativeMethodInfoPtr_InvokeEntityHover_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674031);
		Events.NativeMethodInfoPtr_add_OnEntityUnHover_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674032);
		Events.NativeMethodInfoPtr_remove_OnEntityUnHover_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674033);
		Events.NativeMethodInfoPtr_InvokeEntityUnHover_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674034);
		Events.NativeMethodInfoPtr_add_OnEntitySelect_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674035);
		Events.NativeMethodInfoPtr_remove_OnEntitySelect_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674036);
		Events.NativeMethodInfoPtr_InvokeEntitySelect_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674037);
		Events.NativeMethodInfoPtr_add_OnCheckEntityDrag_Public_Static_add_Void_UnityActionRef_2_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674038);
		Events.NativeMethodInfoPtr_remove_OnCheckEntityDrag_Public_Static_rem_Void_UnityActionRef_2_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674039);
		Events.NativeMethodInfoPtr_CheckEntityDrag_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674040);
		Events.NativeMethodInfoPtr_add_OnEntityDrag_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674041);
		Events.NativeMethodInfoPtr_remove_OnEntityDrag_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674042);
		Events.NativeMethodInfoPtr_InvokeEntityDrag_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674043);
		Events.NativeMethodInfoPtr_add_OnEntityRelease_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674044);
		Events.NativeMethodInfoPtr_remove_OnEntityRelease_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674045);
		Events.NativeMethodInfoPtr_InvokeEntityRelease_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674046);
		Events.NativeMethodInfoPtr_add_OnEntityOffered_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674047);
		Events.NativeMethodInfoPtr_remove_OnEntityOffered_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674048);
		Events.NativeMethodInfoPtr_InvokeEntityOffered_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674049);
		Events.NativeMethodInfoPtr_add_OnEntityChosen_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674050);
		Events.NativeMethodInfoPtr_remove_OnEntityChosen_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674051);
		Events.NativeMethodInfoPtr_InvokeEntityChosen_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674052);
		Events.NativeMethodInfoPtr_add_OnEntityShowUnlocked_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674053);
		Events.NativeMethodInfoPtr_remove_OnEntityShowUnlocked_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674054);
		Events.NativeMethodInfoPtr_InvokeEntityShowUnlocked_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674055);
		Events.NativeMethodInfoPtr_add_OnCheckEntityShove_Public_Static_add_Void_UnityActionRef_2_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674056);
		Events.NativeMethodInfoPtr_remove_OnCheckEntityShove_Public_Static_rem_Void_UnityActionRef_2_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674057);
		Events.NativeMethodInfoPtr_CheckEntityShove_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674058);
		Events.NativeMethodInfoPtr_add_OnPreProcessTrigger_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674059);
		Events.NativeMethodInfoPtr_remove_OnPreProcessTrigger_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674060);
		Events.NativeMethodInfoPtr_InvokePreProcessTrigger_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674061);
		Events.NativeMethodInfoPtr_add_OnEntityPreTrigger_Public_Static_add_Void_UnityActionRef_1_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674062);
		Events.NativeMethodInfoPtr_remove_OnEntityPreTrigger_Public_Static_rem_Void_UnityActionRef_1_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674063);
		Events.NativeMethodInfoPtr_InvokeEntityPreTrigger_Public_Static_Void_byref_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674064);
		Events.NativeMethodInfoPtr_add_OnEntityTrigger_Public_Static_add_Void_UnityActionRef_1_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674065);
		Events.NativeMethodInfoPtr_remove_OnEntityTrigger_Public_Static_rem_Void_UnityActionRef_1_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674066);
		Events.NativeMethodInfoPtr_InvokeEntityTrigger_Public_Static_Void_byref_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674067);
		Events.NativeMethodInfoPtr_add_OnEntityTriggered_Public_Static_add_Void_UnityActionRef_1_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674068);
		Events.NativeMethodInfoPtr_remove_OnEntityTriggered_Public_Static_rem_Void_UnityActionRef_1_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674069);
		Events.NativeMethodInfoPtr_InvokeEntityTriggered_Public_Static_Void_byref_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674070);
		Events.NativeMethodInfoPtr_add_OnEntityMove_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674071);
		Events.NativeMethodInfoPtr_remove_OnEntityMove_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674072);
		Events.NativeMethodInfoPtr_InvokeEntityMove_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674073);
		Events.NativeMethodInfoPtr_add_OnEntityPlace_Public_Static_add_Void_UnityAction_3_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674074);
		Events.NativeMethodInfoPtr_remove_OnEntityPlace_Public_Static_rem_Void_UnityAction_3_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674075);
		Events.NativeMethodInfoPtr_InvokeEntityPlace_Public_Static_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674076);
		Events.NativeMethodInfoPtr_add_OnDiscard_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674077);
		Events.NativeMethodInfoPtr_remove_OnDiscard_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674078);
		Events.NativeMethodInfoPtr_InvokeDiscard_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674079);
		Events.NativeMethodInfoPtr_add_OnEntityHit_Public_Static_add_Void_UnityAction_1_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674080);
		Events.NativeMethodInfoPtr_remove_OnEntityHit_Public_Static_rem_Void_UnityAction_1_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674081);
		Events.NativeMethodInfoPtr_InvokeEntityHit_Public_Static_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674082);
		Events.NativeMethodInfoPtr_add_OnEntityPostHit_Public_Static_add_Void_UnityAction_1_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674083);
		Events.NativeMethodInfoPtr_remove_OnEntityPostHit_Public_Static_rem_Void_UnityAction_1_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674084);
		Events.NativeMethodInfoPtr_InvokeEntityPostHit_Public_Static_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674085);
		Events.NativeMethodInfoPtr_add_OnEntityDodge_Public_Static_add_Void_UnityAction_1_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674086);
		Events.NativeMethodInfoPtr_remove_OnEntityDodge_Public_Static_rem_Void_UnityAction_1_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674087);
		Events.NativeMethodInfoPtr_InvokeEntityDodge_Public_Static_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674088);
		Events.NativeMethodInfoPtr_add_OnEntityFlipUp_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674089);
		Events.NativeMethodInfoPtr_remove_OnEntityFlipUp_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674090);
		Events.NativeMethodInfoPtr_InvokeEntityFlipUp_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674091);
		Events.NativeMethodInfoPtr_add_OnEntityFlipDown_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674092);
		Events.NativeMethodInfoPtr_remove_OnEntityFlipDown_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674093);
		Events.NativeMethodInfoPtr_InvokeEntityFlipDown_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674094);
		Events.NativeMethodInfoPtr_add_OnStatusIconCreated_Public_Static_add_Void_UnityAction_1_StatusIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674095);
		Events.NativeMethodInfoPtr_remove_OnStatusIconCreated_Public_Static_rem_Void_UnityAction_1_StatusIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674096);
		Events.NativeMethodInfoPtr_InvokeStatusIconCreated_Public_Static_Void_StatusIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674097);
		Events.NativeMethodInfoPtr_add_OnStatusIconChanged_Public_Static_add_Void_UnityAction_3_StatusIcon_Stat_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674098);
		Events.NativeMethodInfoPtr_remove_OnStatusIconChanged_Public_Static_rem_Void_UnityAction_3_StatusIcon_Stat_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674099);
		Events.NativeMethodInfoPtr_InvokeStatusIconChanged_Public_Static_Void_StatusIcon_Stat_Stat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674100);
		Events.NativeMethodInfoPtr_add_OnEntityDisplayUpdated_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674101);
		Events.NativeMethodInfoPtr_remove_OnEntityDisplayUpdated_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674102);
		Events.NativeMethodInfoPtr_InvokeEntityDisplayUpdated_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674103);
		Events.NativeMethodInfoPtr_add_OnEntityFocus_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674104);
		Events.NativeMethodInfoPtr_remove_OnEntityFocus_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674105);
		Events.NativeMethodInfoPtr_InvokeEntityFocus_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674106);
		Events.NativeMethodInfoPtr_add_OnEntityEnterPocket_Public_Static_add_Void_UnityAction_2_Entity_CardPocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674107);
		Events.NativeMethodInfoPtr_remove_OnEntityEnterPocket_Public_Static_rem_Void_UnityAction_2_Entity_CardPocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674108);
		Events.NativeMethodInfoPtr_InvokeEntityEnterPocket_Public_Static_Void_Entity_CardPocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674109);
		Events.NativeMethodInfoPtr_add_OnEntityEnterBackpack_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674110);
		Events.NativeMethodInfoPtr_remove_OnEntityEnterBackpack_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674111);
		Events.NativeMethodInfoPtr_InvokeEntityEnterBackpack_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674112);
		Events.NativeMethodInfoPtr_add_OnEntityChangePhase_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674113);
		Events.NativeMethodInfoPtr_remove_OnEntityChangePhase_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674114);
		Events.NativeMethodInfoPtr_InvokeEntityChangePhase_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674115);
		Events.NativeMethodInfoPtr_add_OnNoomlinShow_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674116);
		Events.NativeMethodInfoPtr_remove_OnNoomlinShow_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674117);
		Events.NativeMethodInfoPtr_InvokeNoomlinShow_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674118);
		Events.NativeMethodInfoPtr_add_OnNoomlinUsed_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674119);
		Events.NativeMethodInfoPtr_remove_OnNoomlinUsed_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674120);
		Events.NativeMethodInfoPtr_InvokeNoomlinUsed_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674121);
		Events.NativeMethodInfoPtr_add_OnEntityFlipComplete_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674122);
		Events.NativeMethodInfoPtr_remove_OnEntityFlipComplete_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674123);
		Events.NativeMethodInfoPtr_InvokeEntityFlipComplete_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674124);
		Events.NativeMethodInfoPtr_add_OnEntitySummoned_Public_Static_add_Void_UnityAction_2_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674125);
		Events.NativeMethodInfoPtr_remove_OnEntitySummoned_Public_Static_rem_Void_UnityAction_2_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674126);
		Events.NativeMethodInfoPtr_InvokeEntitySummoned_Public_Static_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674127);
		Events.NativeMethodInfoPtr_add_OnEntityPing_Public_Static_add_Void_UnityAction_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674128);
		Events.NativeMethodInfoPtr_remove_OnEntityPing_Public_Static_rem_Void_UnityAction_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674129);
		Events.NativeMethodInfoPtr_InvokeEntityPing_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674130);
		Events.NativeMethodInfoPtr_add_OnCheckRecycleAmount_Public_Static_add_Void_UnityActionRef_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674131);
		Events.NativeMethodInfoPtr_remove_OnCheckRecycleAmount_Public_Static_rem_Void_UnityActionRef_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674132);
		Events.NativeMethodInfoPtr_CheckRecycleAmount_Public_Static_Void_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674133);
		Events.NativeMethodInfoPtr_add_OnContainerHover_Public_Static_add_Void_UnityAction_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674134);
		Events.NativeMethodInfoPtr_remove_OnContainerHover_Public_Static_rem_Void_UnityAction_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674135);
		Events.NativeMethodInfoPtr_InvokeContainerHover_Public_Static_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674136);
		Events.NativeMethodInfoPtr_add_OnContainerUnHover_Public_Static_add_Void_UnityAction_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674137);
		Events.NativeMethodInfoPtr_remove_OnContainerUnHover_Public_Static_rem_Void_UnityAction_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674138);
		Events.NativeMethodInfoPtr_InvokeContainerUnHover_Public_Static_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674139);
		Events.NativeMethodInfoPtr_add_OnSlotHover_Public_Static_add_Void_UnityAction_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674140);
		Events.NativeMethodInfoPtr_remove_OnSlotHover_Public_Static_rem_Void_UnityAction_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674141);
		Events.NativeMethodInfoPtr_InvokeSlotHover_Public_Static_Void_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674142);
		Events.NativeMethodInfoPtr_add_OnSlotUnHover_Public_Static_add_Void_UnityAction_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674143);
		Events.NativeMethodInfoPtr_remove_OnSlotUnHover_Public_Static_rem_Void_UnityAction_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674144);
		Events.NativeMethodInfoPtr_InvokeSlotUnHover_Public_Static_Void_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674145);
		Events.NativeMethodInfoPtr_add_OnActionQueued_Public_Static_add_Void_UnityAction_1_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674146);
		Events.NativeMethodInfoPtr_remove_OnActionQueued_Public_Static_rem_Void_UnityAction_1_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674147);
		Events.NativeMethodInfoPtr_InvokeActionQueued_Public_Static_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674148);
		Events.NativeMethodInfoPtr_add_OnActionPerform_Public_Static_add_Void_UnityAction_1_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674149);
		Events.NativeMethodInfoPtr_remove_OnActionPerform_Public_Static_rem_Void_UnityAction_1_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674150);
		Events.NativeMethodInfoPtr_InvokeActionPerform_Public_Static_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674151);
		Events.NativeMethodInfoPtr_add_OnActionFinished_Public_Static_add_Void_UnityAction_1_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674152);
		Events.NativeMethodInfoPtr_remove_OnActionFinished_Public_Static_rem_Void_UnityAction_1_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674153);
		Events.NativeMethodInfoPtr_InvokeActionFinished_Public_Static_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674154);
		Events.NativeMethodInfoPtr_add_OnCheckAction_Public_Static_add_Void_UnityActionRef_2_PlayAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674155);
		Events.NativeMethodInfoPtr_remove_OnCheckAction_Public_Static_rem_Void_UnityActionRef_2_PlayAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674156);
		Events.NativeMethodInfoPtr_CheckAction_Public_Static_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674157);
		Events.NativeMethodInfoPtr_add_OnAbilityTargetAdd_Public_Static_add_Void_UnityAction_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674158);
		Events.NativeMethodInfoPtr_remove_OnAbilityTargetAdd_Public_Static_rem_Void_UnityAction_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674159);
		Events.NativeMethodInfoPtr_InvokeAbilityTargetAdd_Public_Static_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674160);
		Events.NativeMethodInfoPtr_add_OnAbilityTargetRemove_Public_Static_add_Void_UnityAction_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674161);
		Events.NativeMethodInfoPtr_remove_OnAbilityTargetRemove_Public_Static_rem_Void_UnityAction_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674162);
		Events.NativeMethodInfoPtr_InvokeAbilityTargetRemove_Public_Static_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674163);
		Events.NativeMethodInfoPtr_add_OnCardDraw_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674164);
		Events.NativeMethodInfoPtr_remove_OnCardDraw_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674165);
		Events.NativeMethodInfoPtr_InvokeCardDraw_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674166);
		Events.NativeMethodInfoPtr_add_OnCardDrawEnd_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674167);
		Events.NativeMethodInfoPtr_remove_OnCardDrawEnd_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674168);
		Events.NativeMethodInfoPtr_InvokeCardDrawEnd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674169);
		Events.NativeMethodInfoPtr_add_PreBattleSetUp_Public_Static_add_Void_UnityAction_1_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674170);
		Events.NativeMethodInfoPtr_remove_PreBattleSetUp_Public_Static_rem_Void_UnityAction_1_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674171);
		Events.NativeMethodInfoPtr_InvokePreBattleSetUp_Public_Static_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674172);
		Events.NativeMethodInfoPtr_add_PostBattleSetUp_Public_Static_add_Void_UnityAction_1_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674173);
		Events.NativeMethodInfoPtr_remove_PostBattleSetUp_Public_Static_rem_Void_UnityAction_1_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674174);
		Events.NativeMethodInfoPtr_InvokePostBattleSetUp_Public_Static_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674175);
		Events.NativeMethodInfoPtr_add_OnBattlePhaseStart_Public_Static_add_Void_UnityAction_1_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674176);
		Events.NativeMethodInfoPtr_remove_OnBattlePhaseStart_Public_Static_rem_Void_UnityAction_1_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674177);
		Events.NativeMethodInfoPtr_InvokeBattlePhaseStart_Public_Static_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674178);
		Events.NativeMethodInfoPtr_add_OnBattleStart_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674179);
		Events.NativeMethodInfoPtr_remove_OnBattleStart_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674180);
		Events.NativeMethodInfoPtr_InvokeBattleStart_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674181);
		Events.NativeMethodInfoPtr_add_PreBattleEnd_Public_Static_add_Void_AsyncAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674182);
		Events.NativeMethodInfoPtr_remove_PreBattleEnd_Public_Static_rem_Void_AsyncAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674183);
		Events.NativeMethodInfoPtr_InvokePreBattleEnd_Public_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674184);
		Events.NativeMethodInfoPtr_add_OnBattleEnd_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674185);
		Events.NativeMethodInfoPtr_remove_OnBattleEnd_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674186);
		Events.NativeMethodInfoPtr_InvokeBattleEnd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674187);
		Events.NativeMethodInfoPtr_add_OnBattleWinPreRewards_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674188);
		Events.NativeMethodInfoPtr_remove_OnBattleWinPreRewards_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674189);
		Events.NativeMethodInfoPtr_InvokeBattleWinPreRewards_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674190);
		Events.NativeMethodInfoPtr_add_OnBattleWin_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674191);
		Events.NativeMethodInfoPtr_remove_OnBattleWin_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674192);
		Events.NativeMethodInfoPtr_InvokeBattleWin_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674193);
		Events.NativeMethodInfoPtr_add_PostBattle_Public_Static_add_Void_UnityAction_1_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674194);
		Events.NativeMethodInfoPtr_remove_PostBattle_Public_Static_rem_Void_UnityAction_1_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674195);
		Events.NativeMethodInfoPtr_InvokePostBattle_Public_Static_Void_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674196);
		Events.NativeMethodInfoPtr_add_OnStatusEffectCountDown_Public_Static_add_Void_UnityActionCheck_2_StatusEffectData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674197);
		Events.NativeMethodInfoPtr_remove_OnStatusEffectCountDown_Public_Static_rem_Void_UnityActionCheck_2_StatusEffectData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674198);
		Events.NativeMethodInfoPtr_InvokeStatusEffectCountDown_Public_Static_Void_StatusEffectData_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674199);
		Events.NativeMethodInfoPtr_add_OnStatusEffectApplied_Public_Static_add_Void_UnityAction_1_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674200);
		Events.NativeMethodInfoPtr_remove_OnStatusEffectApplied_Public_Static_rem_Void_UnityAction_1_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674201);
		Events.NativeMethodInfoPtr_InvokeStatusEffectApplied_Public_Static_Void_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674202);
		Events.NativeMethodInfoPtr_add_OnPreProcessUnits_Public_Static_add_Void_UnityAction_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674203);
		Events.NativeMethodInfoPtr_remove_OnPreProcessUnits_Public_Static_rem_Void_UnityAction_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674204);
		Events.NativeMethodInfoPtr_InvokePreProcessUnits_Public_Static_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674205);
		Events.NativeMethodInfoPtr_add_OnPostProcessUnits_Public_Static_add_Void_UnityAction_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674206);
		Events.NativeMethodInfoPtr_remove_OnPostProcessUnits_Public_Static_rem_Void_UnityAction_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674207);
		Events.NativeMethodInfoPtr_InvokePostProcessUnits_Public_Static_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674208);
		Events.NativeMethodInfoPtr_add_OnEntityCountDown_Public_Static_add_Void_UnityActionCheck_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674209);
		Events.NativeMethodInfoPtr_remove_OnEntityCountDown_Public_Static_rem_Void_UnityActionCheck_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674210);
		Events.NativeMethodInfoPtr_InvokeEntityCountDown_Public_Static_Void_Entity_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674211);
		Events.NativeMethodInfoPtr_add_OnBattlePreTurnStart_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674212);
		Events.NativeMethodInfoPtr_remove_OnBattlePreTurnStart_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674213);
		Events.NativeMethodInfoPtr_InvokeBattlePreTurnStart_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674214);
		Events.NativeMethodInfoPtr_add_OnBattleTurnStart_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674215);
		Events.NativeMethodInfoPtr_remove_OnBattleTurnStart_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674216);
		Events.NativeMethodInfoPtr_InvokeBattleTurnStart_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674217);
		Events.NativeMethodInfoPtr_add_OnBattleTurnEnd_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674218);
		Events.NativeMethodInfoPtr_remove_OnBattleTurnEnd_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674219);
		Events.NativeMethodInfoPtr_InvokeBattleTurnEnd_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674220);
		Events.NativeMethodInfoPtr_add_OnMinibossIntro_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674221);
		Events.NativeMethodInfoPtr_remove_OnMinibossIntro_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674222);
		Events.NativeMethodInfoPtr_InvokeMinibossIntro_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674223);
		Events.NativeMethodInfoPtr_add_OnMinibossIntroDone_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674224);
		Events.NativeMethodInfoPtr_remove_OnMinibossIntroDone_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674225);
		Events.NativeMethodInfoPtr_InvokeMinibossIntroDone_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674226);
		Events.NativeMethodInfoPtr_add_OnKillCombo_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674227);
		Events.NativeMethodInfoPtr_remove_OnKillCombo_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674228);
		Events.NativeMethodInfoPtr_InvokeKillCombo_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674229);
		Events.NativeMethodInfoPtr_add_OnRedrawBellHit_Public_Static_add_Void_UnityAction_1_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674230);
		Events.NativeMethodInfoPtr_remove_OnRedrawBellHit_Public_Static_rem_Void_UnityAction_1_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674231);
		Events.NativeMethodInfoPtr_InvokeRedrawBellHit_Public_Static_Void_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674232);
		Events.NativeMethodInfoPtr_add_OnRedrawBellRevealed_Public_Static_add_Void_UnityAction_1_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674233);
		Events.NativeMethodInfoPtr_remove_OnRedrawBellRevealed_Public_Static_rem_Void_UnityAction_1_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674234);
		Events.NativeMethodInfoPtr_InvokeRedrawBellRevealed_Public_Static_Void_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674235);
		Events.NativeMethodInfoPtr_add_OnCardInjured_Public_Static_add_Void_UnityAction_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674236);
		Events.NativeMethodInfoPtr_remove_OnCardInjured_Public_Static_rem_Void_UnityAction_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674237);
		Events.NativeMethodInfoPtr_InvokeCardInjured_Public_Static_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674238);
		Events.NativeMethodInfoPtr_add_OnBattleStateBuild_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674239);
		Events.NativeMethodInfoPtr_remove_OnBattleStateBuild_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674240);
		Events.NativeMethodInfoPtr_InvokeBattleStateBuild_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674241);
		Events.NativeMethodInfoPtr_add_OnBattleStateBuilt_Public_Static_add_Void_UnityAction_1_BattleSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674242);
		Events.NativeMethodInfoPtr_remove_OnBattleStateBuilt_Public_Static_rem_Void_UnityAction_1_BattleSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674243);
		Events.NativeMethodInfoPtr_InvokeBattleStateBuilt_Public_Static_Void_BattleSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674244);
		Events.NativeMethodInfoPtr_add_OnCharacterActionPerformed_Public_Static_add_Void_UnityAction_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674245);
		Events.NativeMethodInfoPtr_remove_OnCharacterActionPerformed_Public_Static_rem_Void_UnityAction_1_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674246);
		Events.NativeMethodInfoPtr_InvokeCharacterActionPerformed_Public_Static_Void_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674247);
		Events.NativeMethodInfoPtr_add_OnWaveDeployerPreCountDown_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674248);
		Events.NativeMethodInfoPtr_remove_OnWaveDeployerPreCountDown_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674249);
		Events.NativeMethodInfoPtr_InvokeWaveDeployerPreCountDown_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674250);
		Events.NativeMethodInfoPtr_add_OnWaveDeployerPostCountDown_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674251);
		Events.NativeMethodInfoPtr_remove_OnWaveDeployerPostCountDown_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674252);
		Events.NativeMethodInfoPtr_InvokeWaveDeployerPostCountDown_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674253);
		Events.NativeMethodInfoPtr_add_OnWaveDeployerEarlyDeploy_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674254);
		Events.NativeMethodInfoPtr_remove_OnWaveDeployerEarlyDeploy_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674255);
		Events.NativeMethodInfoPtr_InvokeWaveDeployerEarlyDeploy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674256);
		Events.NativeMethodInfoPtr_add_OnMapPathReveal_Public_Static_add_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674257);
		Events.NativeMethodInfoPtr_remove_OnMapPathReveal_Public_Static_rem_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674258);
		Events.NativeMethodInfoPtr_InvokeMapPathReveal_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674259);
		Events.NativeMethodInfoPtr_add_OnMapNodeReveal_Public_Static_add_Void_UnityAction_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674260);
		Events.NativeMethodInfoPtr_remove_OnMapNodeReveal_Public_Static_rem_Void_UnityAction_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674261);
		Events.NativeMethodInfoPtr_InvokeMapNodeReveal_Public_Static_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674262);
		Events.NativeMethodInfoPtr_add_OnMapNodeSelect_Public_Static_add_Void_UnityAction_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674263);
		Events.NativeMethodInfoPtr_remove_OnMapNodeSelect_Public_Static_rem_Void_UnityAction_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674264);
		Events.NativeMethodInfoPtr_InvokeMapNodeSelect_Public_Static_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674265);
		Events.NativeMethodInfoPtr_add_OnMapNodeHover_Public_Static_add_Void_UnityAction_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674266);
		Events.NativeMethodInfoPtr_remove_OnMapNodeHover_Public_Static_rem_Void_UnityAction_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674267);
		Events.NativeMethodInfoPtr_InvokeMapNodeHover_Public_Static_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674268);
		Events.NativeMethodInfoPtr_add_OnMapNodeUnHover_Public_Static_add_Void_UnityAction_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674269);
		Events.NativeMethodInfoPtr_remove_OnMapNodeUnHover_Public_Static_rem_Void_UnityAction_1_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674270);
		Events.NativeMethodInfoPtr_InvokeMapNodeUnHover_Public_Static_Void_MapNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674271);
		Events.NativeMethodInfoPtr_add_OnTownUnlock_Public_Static_add_Void_UnityAction_1_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674272);
		Events.NativeMethodInfoPtr_remove_OnTownUnlock_Public_Static_rem_Void_UnityAction_1_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674273);
		Events.NativeMethodInfoPtr_InvokeTownUnlock_Public_Static_Void_UnlockData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674274);
		Events.NativeMethodInfoPtr_add_OnShopItemHover_Public_Static_add_Void_UnityAction_1_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674275);
		Events.NativeMethodInfoPtr_remove_OnShopItemHover_Public_Static_rem_Void_UnityAction_1_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674276);
		Events.NativeMethodInfoPtr_InvokeShopItemHover_Public_Static_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674277);
		Events.NativeMethodInfoPtr_add_OnShopItemUnHover_Public_Static_add_Void_UnityAction_1_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674278);
		Events.NativeMethodInfoPtr_remove_OnShopItemUnHover_Public_Static_rem_Void_UnityAction_1_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674279);
		Events.NativeMethodInfoPtr_InvokeShopItemUnHover_Public_Static_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674280);
		Events.NativeMethodInfoPtr_add_OnShopItemPurchase_Public_Static_add_Void_UnityAction_1_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674281);
		Events.NativeMethodInfoPtr_remove_OnShopItemPurchase_Public_Static_rem_Void_UnityAction_1_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674282);
		Events.NativeMethodInfoPtr_InvokeShopItemPurchase_Public_Static_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674283);
		Events.NativeMethodInfoPtr_add_OnShopItemHaggled_Public_Static_add_Void_UnityAction_1_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674284);
		Events.NativeMethodInfoPtr_remove_OnShopItemHaggled_Public_Static_rem_Void_UnityAction_1_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674285);
		Events.NativeMethodInfoPtr_InvokeShopItemHaggled_Public_Static_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674286);
		Events.NativeMethodInfoPtr_add_OnPopupCreated_Public_Static_add_Void_UnityAction_2_KeywordData_CardPopUpPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674287);
		Events.NativeMethodInfoPtr_remove_OnPopupCreated_Public_Static_rem_Void_UnityAction_2_KeywordData_CardPopUpPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674288);
		Events.NativeMethodInfoPtr_InvokePopupPanelCreated_Public_Static_Void_KeywordData_CardPopUpPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674289);
		Events.NativeMethodInfoPtr_add_OnButtonHover_Public_Static_add_Void_UnityAction_1_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674290);
		Events.NativeMethodInfoPtr_remove_OnButtonHover_Public_Static_rem_Void_UnityAction_1_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674291);
		Events.NativeMethodInfoPtr_InvokeButtonHover_Public_Static_Void_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674292);
		Events.NativeMethodInfoPtr_add_OnButtonPress_Public_Static_add_Void_UnityAction_1_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674293);
		Events.NativeMethodInfoPtr_remove_OnButtonPress_Public_Static_rem_Void_UnityAction_1_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674294);
		Events.NativeMethodInfoPtr_InvokeButtonPress_Public_Static_Void_ButtonType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674295);
		Events.NativeMethodInfoPtr_add_OnAudioVolumeChange_Public_Static_add_Void_UnityAction_2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674296);
		Events.NativeMethodInfoPtr_remove_OnAudioVolumeChange_Public_Static_rem_Void_UnityAction_2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674297);
		Events.NativeMethodInfoPtr_InvokeAudioVolumeChange_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674298);
		Events.NativeMethodInfoPtr_add_OnAudioPitchChange_Public_Static_add_Void_UnityAction_2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674299);
		Events.NativeMethodInfoPtr_remove_OnAudioPitchChange_Public_Static_rem_Void_UnityAction_2_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674300);
		Events.NativeMethodInfoPtr_InvokeAudioPitchChange_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674301);
		Events.NativeMethodInfoPtr_add_OnBombardShoot_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674302);
		Events.NativeMethodInfoPtr_remove_OnBombardShoot_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674303);
		Events.NativeMethodInfoPtr_InvokeBombardShoot_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674304);
		Events.NativeMethodInfoPtr_add_OnBombardRocketFall_Public_Static_add_Void_UnityAction_1_BombardRocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674305);
		Events.NativeMethodInfoPtr_remove_OnBombardRocketFall_Public_Static_rem_Void_UnityAction_1_BombardRocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674306);
		Events.NativeMethodInfoPtr_InvokeBombardRocketFall_Public_Static_Void_BombardRocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674307);
		Events.NativeMethodInfoPtr_add_OnBombardRocketExplode_Public_Static_add_Void_UnityAction_1_BombardRocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674308);
		Events.NativeMethodInfoPtr_remove_OnBombardRocketExplode_Public_Static_rem_Void_UnityAction_1_BombardRocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674309);
		Events.NativeMethodInfoPtr_InvokeBombardRocketExplode_Public_Static_Void_BombardRocket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674310);
		Events.NativeMethodInfoPtr_add_OnProgressStart_Public_Static_add_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674311);
		Events.NativeMethodInfoPtr_remove_OnProgressStart_Public_Static_rem_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674312);
		Events.NativeMethodInfoPtr_InvokeProgressStart_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674313);
		Events.NativeMethodInfoPtr_add_OnProgressUpdate_Public_Static_add_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674314);
		Events.NativeMethodInfoPtr_remove_OnProgressUpdate_Public_Static_rem_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674315);
		Events.NativeMethodInfoPtr_InvokeProgressUpdate_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674316);
		Events.NativeMethodInfoPtr_add_OnProgressStop_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674317);
		Events.NativeMethodInfoPtr_remove_OnProgressStop_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674318);
		Events.NativeMethodInfoPtr_InvokeProgressStop_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674319);
		Events.NativeMethodInfoPtr_add_OnProgressDing_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674320);
		Events.NativeMethodInfoPtr_remove_OnProgressDing_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674321);
		Events.NativeMethodInfoPtr_InvokeProgressDing_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674322);
		Events.NativeMethodInfoPtr_add_OnProgressBlip_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674323);
		Events.NativeMethodInfoPtr_remove_OnProgressBlip_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674324);
		Events.NativeMethodInfoPtr_InvokeProgressBlip_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674325);
		Events.NativeMethodInfoPtr_add_OnSaveSystemEnabled_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674326);
		Events.NativeMethodInfoPtr_remove_OnSaveSystemEnabled_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674327);
		Events.NativeMethodInfoPtr_InvokeSaveSystemEnabled_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674328);
		Events.NativeMethodInfoPtr_add_OnSaveSystemDisabled_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674329);
		Events.NativeMethodInfoPtr_remove_OnSaveSystemDisabled_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674330);
		Events.NativeMethodInfoPtr_InvokeSaveSystemDisabled_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674331);
		Events.NativeMethodInfoPtr_add_OnSaveSystemProfileChanged_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674332);
		Events.NativeMethodInfoPtr_remove_OnSaveSystemProfileChanged_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674333);
		Events.NativeMethodInfoPtr_InvokeSaveSystemProfileChanged_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674334);
		Events.NativeMethodInfoPtr_add_OnCampaignSaved_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674335);
		Events.NativeMethodInfoPtr_remove_OnCampaignSaved_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674336);
		Events.NativeMethodInfoPtr_InvokeCampaignSaved_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674337);
		Events.NativeMethodInfoPtr_add_OnCampaignLoaded_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674338);
		Events.NativeMethodInfoPtr_remove_OnCampaignLoaded_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674339);
		Events.NativeMethodInfoPtr_InvokeCampaignLoaded_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674340);
		Events.NativeMethodInfoPtr_add_OnCampaignDeleted_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674341);
		Events.NativeMethodInfoPtr_remove_OnCampaignDeleted_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674342);
		Events.NativeMethodInfoPtr_InvokeCampaignDeleted_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674343);
		Events.NativeMethodInfoPtr_add_OnBattleSaved_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674344);
		Events.NativeMethodInfoPtr_remove_OnBattleSaved_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674345);
		Events.NativeMethodInfoPtr_InvokeBattleSaved_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674346);
		Events.NativeMethodInfoPtr_add_OnBattleLoaded_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674347);
		Events.NativeMethodInfoPtr_remove_OnBattleLoaded_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674348);
		Events.NativeMethodInfoPtr_InvokeBattleLoaded_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674349);
		Events.NativeMethodInfoPtr_add_OnGameStart_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674350);
		Events.NativeMethodInfoPtr_remove_OnGameStart_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674351);
		Events.NativeMethodInfoPtr_InvokeGameStart_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674352);
		Events.NativeMethodInfoPtr_add_OnGameEnd_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674353);
		Events.NativeMethodInfoPtr_remove_OnGameEnd_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674354);
		Events.NativeMethodInfoPtr_InvokeGameEnd_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674355);
		Events.NativeMethodInfoPtr_add_OnCampaignStart_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674356);
		Events.NativeMethodInfoPtr_remove_OnCampaignStart_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674357);
		Events.NativeMethodInfoPtr_InvokeCampaignStart_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674358);
		Events.NativeMethodInfoPtr_add_OnCampaignFinal_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674359);
		Events.NativeMethodInfoPtr_remove_OnCampaignFinal_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674360);
		Events.NativeMethodInfoPtr_InvokeCampaignFinal_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674361);
		Events.NativeMethodInfoPtr_add_OnCampaignEnd_Public_Static_add_Void_UnityAction_3_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674362);
		Events.NativeMethodInfoPtr_remove_OnCampaignEnd_Public_Static_rem_Void_UnityAction_3_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674363);
		Events.NativeMethodInfoPtr_InvokeCampaignEnd_Public_Static_Void_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674364);
		Events.NativeMethodInfoPtr_add_OnOverallStatsSaved_Public_Static_add_Void_UnityAction_1_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674365);
		Events.NativeMethodInfoPtr_remove_OnOverallStatsSaved_Public_Static_rem_Void_UnityAction_1_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674366);
		Events.NativeMethodInfoPtr_InvokeOverallStatsSaved_Public_Static_Void_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674367);
		Events.NativeMethodInfoPtr_add_OnCampaignDataCreated_Public_Static_add_Void_UnityAction_1_CampaignData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674368);
		Events.NativeMethodInfoPtr_remove_OnCampaignDataCreated_Public_Static_rem_Void_UnityAction_1_CampaignData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674369);
		Events.NativeMethodInfoPtr_InvokeCampaignDataCreated_Public_Static_Void_CampaignData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674370);
		Events.NativeMethodInfoPtr_add_OnCampaignPreInit_Public_Static_add_Void_RoutineAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674371);
		Events.NativeMethodInfoPtr_remove_OnCampaignPreInit_Public_Static_rem_Void_RoutineAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674372);
		Events.NativeMethodInfoPtr_InvokeCampaignPreInit_Public_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674373);
		Events.NativeMethodInfoPtr_add_OnCampaignInit_Public_Static_add_Void_RoutineAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674374);
		Events.NativeMethodInfoPtr_remove_OnCampaignInit_Public_Static_rem_Void_RoutineAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674375);
		Events.NativeMethodInfoPtr_InvokeCampaignInit_Public_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674376);
		Events.NativeMethodInfoPtr_add_OnPreCampaignPopulate_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674377);
		Events.NativeMethodInfoPtr_remove_OnPreCampaignPopulate_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674378);
		Events.NativeMethodInfoPtr_InvokePreCampaignPopulate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674379);
		Events.NativeMethodInfoPtr_add_OnCampaignNodesCreated_Public_Static_add_Void_UnityActionRef1_2_List_1_Node_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674380);
		Events.NativeMethodInfoPtr_remove_OnCampaignNodesCreated_Public_Static_rem_Void_UnityActionRef1_2_List_1_Node_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674381);
		Events.NativeMethodInfoPtr_InvokeCampaignNodesCreated_Public_Static_Void_byref_List_1_Node_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674382);
		Events.NativeMethodInfoPtr_add_OnCampaignLoadPreset_Public_Static_add_Void_UnityActionRef_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674383);
		Events.NativeMethodInfoPtr_remove_OnCampaignLoadPreset_Public_Static_rem_Void_UnityActionRef_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674384);
		Events.NativeMethodInfoPtr_InvokeCampaignLoadPreset_Public_Static_Void_byref_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674385);
		Events.NativeMethodInfoPtr_add_OnCampaignGenerated_Public_Static_add_Void_AsyncAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674386);
		Events.NativeMethodInfoPtr_remove_OnCampaignGenerated_Public_Static_rem_Void_AsyncAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674387);
		Events.NativeMethodInfoPtr_InvokeCampaignGenerated_Public_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674388);
		Events.NativeMethodInfoPtr_add_OnStatChanged_Public_Static_add_Void_UnityAction_4_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674389);
		Events.NativeMethodInfoPtr_remove_OnStatChanged_Public_Static_rem_Void_UnityAction_4_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674390);
		Events.NativeMethodInfoPtr_InvokeStatChanged_Public_Static_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674391);
		Events.NativeMethodInfoPtr_add_OnUpgradeGained_Public_Static_add_Void_UnityAction_1_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674392);
		Events.NativeMethodInfoPtr_remove_OnUpgradeGained_Public_Static_rem_Void_UnityAction_1_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674393);
		Events.NativeMethodInfoPtr_InvokeUpgradeGained_Public_Static_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674394);
		Events.NativeMethodInfoPtr_add_OnUpgradeAssign_Public_Static_add_Void_UnityAction_2_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674395);
		Events.NativeMethodInfoPtr_remove_OnUpgradeAssign_Public_Static_rem_Void_UnityAction_2_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674396);
		Events.NativeMethodInfoPtr_InvokeUpgradeAssign_Public_Static_Void_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674397);
		Events.NativeMethodInfoPtr_add_OnUpgradeHover_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674398);
		Events.NativeMethodInfoPtr_remove_OnUpgradeHover_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674399);
		Events.NativeMethodInfoPtr_InvokeUpgradeHover_Public_Static_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674400);
		Events.NativeMethodInfoPtr_add_OnUpgradePickup_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674401);
		Events.NativeMethodInfoPtr_remove_OnUpgradePickup_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674402);
		Events.NativeMethodInfoPtr_InvokeUpgradePickup_Public_Static_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674403);
		Events.NativeMethodInfoPtr_add_OnUpgradeDrop_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674404);
		Events.NativeMethodInfoPtr_remove_OnUpgradeDrop_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674405);
		Events.NativeMethodInfoPtr_InvokeUpgradeDrop_Public_Static_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674406);
		Events.NativeMethodInfoPtr_add_OnUpdateInputSystem_Public_Static_add_Void_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674407);
		Events.NativeMethodInfoPtr_remove_OnUpdateInputSystem_Public_Static_rem_Void_UnityAction_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674408);
		Events.NativeMethodInfoPtr_InvokeUpdateInputSystem_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674409);
		Events.NativeMethodInfoPtr_add_OnScreenShake_Public_Static_add_Void_UnityAction_2_Single_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674410);
		Events.NativeMethodInfoPtr_remove_OnScreenShake_Public_Static_rem_Void_UnityAction_2_Single_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674411);
		Events.NativeMethodInfoPtr_InvokeScreenShake_Public_Static_Void_Single_Nullable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674412);
		Events.NativeMethodInfoPtr_add_OnScreenRumble_Public_Static_add_Void_UnityAction_6_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674413);
		Events.NativeMethodInfoPtr_remove_OnScreenRumble_Public_Static_rem_Void_UnityAction_6_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674414);
		Events.NativeMethodInfoPtr_InvokeScreenRumble_Public_Static_Void_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674415);
		Events.NativeMethodInfoPtr_add_OnCameraAnimation_Public_Static_add_Void_UnityAction_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674416);
		Events.NativeMethodInfoPtr_remove_OnCameraAnimation_Public_Static_rem_Void_UnityAction_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674417);
		Events.NativeMethodInfoPtr_InvokeCameraAnimation_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674418);
		Events.NativeMethodInfoPtr_add_OnDropGold_Public_Static_add_Void_UnityAction_4_Int32_String_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674419);
		Events.NativeMethodInfoPtr_remove_OnDropGold_Public_Static_rem_Void_UnityAction_4_Int32_String_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674420);
		Events.NativeMethodInfoPtr_InvokeDropGold_Public_Static_Void_Int32_String_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674421);
		Events.NativeMethodInfoPtr_add_OnGoldFlyToBag_Public_Static_add_Void_UnityAction_3_Int32_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674422);
		Events.NativeMethodInfoPtr_remove_OnGoldFlyToBag_Public_Static_rem_Void_UnityAction_3_Int32_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674423);
		Events.NativeMethodInfoPtr_InvokeGoldFlyToBag_Public_Static_Void_Int32_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674424);
		Events.NativeMethodInfoPtr_add_OnCollectGold_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674425);
		Events.NativeMethodInfoPtr_remove_OnCollectGold_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674426);
		Events.NativeMethodInfoPtr_InvokeCollectGold_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674427);
		Events.NativeMethodInfoPtr_add_OnSpendGold_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674428);
		Events.NativeMethodInfoPtr_remove_OnSpendGold_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674429);
		Events.NativeMethodInfoPtr_InvokeSpendGold_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674430);
		Events.NativeMethodInfoPtr_add_OnTimeScaleChange_Public_Static_add_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674431);
		Events.NativeMethodInfoPtr_remove_OnTimeScaleChange_Public_Static_rem_Void_UnityAction_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674432);
		Events.NativeMethodInfoPtr_InvokeTimeScaleChange_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674433);
		Events.NativeMethodInfoPtr_add_OnInspect_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674434);
		Events.NativeMethodInfoPtr_remove_OnInspect_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674435);
		Events.NativeMethodInfoPtr_InvokeInspect_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674436);
		Events.NativeMethodInfoPtr_add_OnInspectEnd_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674437);
		Events.NativeMethodInfoPtr_remove_OnInspectEnd_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674438);
		Events.NativeMethodInfoPtr_InvokeInspectEnd_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674439);
		Events.NativeMethodInfoPtr_add_OnInspectNewCard_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674440);
		Events.NativeMethodInfoPtr_remove_OnInspectNewCard_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674441);
		Events.NativeMethodInfoPtr_InvokeInspectNewCard_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674442);
		Events.NativeMethodInfoPtr_add_OnCardControllerEnabled_Public_Static_add_Void_UnityAction_1_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674443);
		Events.NativeMethodInfoPtr_remove_OnCardControllerEnabled_Public_Static_rem_Void_UnityAction_1_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674444);
		Events.NativeMethodInfoPtr_InvokeCardControllerEnabled_Public_Static_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674445);
		Events.NativeMethodInfoPtr_add_OnCardControllerDisabled_Public_Static_add_Void_UnityAction_1_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674446);
		Events.NativeMethodInfoPtr_remove_OnCardControllerDisabled_Public_Static_rem_Void_UnityAction_1_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674447);
		Events.NativeMethodInfoPtr_InvokeCardControllerDisabled_Public_Static_Void_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674448);
		Events.NativeMethodInfoPtr_add_OnDeckpackOpen_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674449);
		Events.NativeMethodInfoPtr_remove_OnDeckpackOpen_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674450);
		Events.NativeMethodInfoPtr_InvokeDeckpackOpen_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674451);
		Events.NativeMethodInfoPtr_add_OnDeckpackClose_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674452);
		Events.NativeMethodInfoPtr_remove_OnDeckpackClose_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674453);
		Events.NativeMethodInfoPtr_InvokeDeckpackClose_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674454);
		Events.NativeMethodInfoPtr_add_OnTransitionStart_Public_Static_add_Void_UnityAction_1_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674455);
		Events.NativeMethodInfoPtr_remove_OnTransitionStart_Public_Static_rem_Void_UnityAction_1_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674456);
		Events.NativeMethodInfoPtr_InvokeTransitionStart_Public_Static_Void_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674457);
		Events.NativeMethodInfoPtr_add_OnTransitionEnd_Public_Static_add_Void_UnityAction_1_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674458);
		Events.NativeMethodInfoPtr_remove_OnTransitionEnd_Public_Static_rem_Void_UnityAction_1_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674459);
		Events.NativeMethodInfoPtr_InvokeTransitionEnd_Public_Static_Void_TransitionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674460);
		Events.NativeMethodInfoPtr_add_OnSetWeatherIntensity_Public_Static_add_Void_UnityAction_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674461);
		Events.NativeMethodInfoPtr_remove_OnSetWeatherIntensity_Public_Static_rem_Void_UnityAction_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674462);
		Events.NativeMethodInfoPtr_InvokeSetWeatherIntensity_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674463);
		Events.NativeMethodInfoPtr_add_OnGoldCounterStart_Public_Static_add_Void_UnityAction_2_GoldDisplay_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674464);
		Events.NativeMethodInfoPtr_remove_OnGoldCounterStart_Public_Static_rem_Void_UnityAction_2_GoldDisplay_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674465);
		Events.NativeMethodInfoPtr_InvokeGoldCounterStart_Public_Static_Void_GoldDisplay_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674466);
		Events.NativeMethodInfoPtr_add_OnEventStart_Public_Static_add_Void_UnityAction_2_CampaignNode_EventRoutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674467);
		Events.NativeMethodInfoPtr_remove_OnEventStart_Public_Static_rem_Void_UnityAction_2_CampaignNode_EventRoutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674468);
		Events.NativeMethodInfoPtr_InvokeEventStart_Public_Static_Void_CampaignNode_EventRoutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674469);
		Events.NativeMethodInfoPtr_add_OnEventPopulated_Public_Static_add_Void_UnityAction_1_EventRoutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674470);
		Events.NativeMethodInfoPtr_remove_OnEventPopulated_Public_Static_rem_Void_UnityAction_1_EventRoutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674471);
		Events.NativeMethodInfoPtr_InvokeEventPopulated_Public_Static_Void_EventRoutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674472);
		Events.NativeMethodInfoPtr_add_OnMuncherDrag_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674473);
		Events.NativeMethodInfoPtr_remove_OnMuncherDrag_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674474);
		Events.NativeMethodInfoPtr_InvokeMuncherDrag_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674475);
		Events.NativeMethodInfoPtr_add_OnMuncherDragCancel_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674476);
		Events.NativeMethodInfoPtr_remove_OnMuncherDragCancel_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674477);
		Events.NativeMethodInfoPtr_InvokeMuncherDragCancel_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674478);
		Events.NativeMethodInfoPtr_add_OnMuncherFeed_Public_Static_add_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674479);
		Events.NativeMethodInfoPtr_remove_OnMuncherFeed_Public_Static_rem_Void_UnityAction_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674480);
		Events.NativeMethodInfoPtr_InvokeMuncherFeed_Public_Static_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674481);
		Events.NativeMethodInfoPtr_add_OnSettingChanged_Public_Static_add_Void_UnityAction_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674482);
		Events.NativeMethodInfoPtr_remove_OnSettingChanged_Public_Static_rem_Void_UnityAction_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674483);
		Events.NativeMethodInfoPtr_InvokeSettingChanged_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674484);
		Events.NativeMethodInfoPtr_add_OnUINavigationReset_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674485);
		Events.NativeMethodInfoPtr_remove_OnUINavigationReset_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674486);
		Events.NativeMethodInfoPtr_InvokeUINavigationReset_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674487);
		Events.NativeMethodInfoPtr_add_OnUINavigation_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674488);
		Events.NativeMethodInfoPtr_remove_OnUINavigation_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674489);
		Events.NativeMethodInfoPtr_InvokeUINavigation_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674490);
		Events.NativeMethodInfoPtr_add_OnButtonStyleChanged_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674491);
		Events.NativeMethodInfoPtr_remove_OnButtonStyleChanged_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674492);
		Events.NativeMethodInfoPtr_InvokeButtonStyleChanged_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674493);
		Events.NativeMethodInfoPtr_add_OnControllerSwitched_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674494);
		Events.NativeMethodInfoPtr_remove_OnControllerSwitched_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674495);
		Events.NativeMethodInfoPtr_InvokeControllerSwitched_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674496);
		Events.NativeMethodInfoPtr_add_OnCheckRename_Public_Static_add_Void_UnityActionRef_3_Entity_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674497);
		Events.NativeMethodInfoPtr_remove_OnCheckRename_Public_Static_rem_Void_UnityActionRef_3_Entity_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674498);
		Events.NativeMethodInfoPtr_CheckRename_Public_Static_Boolean_byref_Entity_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674499);
		Events.NativeMethodInfoPtr_add_OnRename_Public_Static_add_Void_UnityAction_2_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674500);
		Events.NativeMethodInfoPtr_remove_OnRename_Public_Static_rem_Void_UnityAction_2_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674501);
		Events.NativeMethodInfoPtr_InvokeRename_Public_Static_Void_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674502);
		Events.NativeMethodInfoPtr_add_OnPullRewards_Public_Static_add_Void_UnityActionRef_4_Object_String_Int32_List_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674503);
		Events.NativeMethodInfoPtr_remove_OnPullRewards_Public_Static_rem_Void_UnityActionRef_4_Object_String_Int32_List_1_DataFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674504);
		Events.NativeMethodInfoPtr_PullRewards_Public_Static_List_1_DataFile_Object_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674505);
		Events.NativeMethodInfoPtr_add_OnCardDataCreated_Public_Static_add_Void_UnityAction_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674506);
		Events.NativeMethodInfoPtr_remove_OnCardDataCreated_Public_Static_rem_Void_UnityAction_1_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674507);
		Events.NativeMethodInfoPtr_InvokeCardDataCreated_Public_Static_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674508);
		Events.NativeMethodInfoPtr_add_OnTutorialProgress_Public_Static_add_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674509);
		Events.NativeMethodInfoPtr_remove_OnTutorialProgress_Public_Static_rem_Void_UnityAction_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674510);
		Events.NativeMethodInfoPtr_InvokeTutorialProgress_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674511);
		Events.NativeMethodInfoPtr_add_OnTutorialSkip_Public_Static_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674512);
		Events.NativeMethodInfoPtr_remove_OnTutorialSkip_Public_Static_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674513);
		Events.NativeMethodInfoPtr_InvokeTutorialSkip_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674514);
		Events.NativeMethodInfoPtr_add_OnChallengeCompletedSaved_Public_Static_add_Void_UnityAction_1_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674515);
		Events.NativeMethodInfoPtr_remove_OnChallengeCompletedSaved_Public_Static_rem_Void_UnityAction_1_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674516);
		Events.NativeMethodInfoPtr_InvokeChallengeCompletedSaved_Public_Static_Void_ChallengeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674517);
		Events.NativeMethodInfoPtr_add_OnGetHandSize_Public_Static_add_Void_UnityActionRef_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674518);
		Events.NativeMethodInfoPtr_remove_OnGetHandSize_Public_Static_rem_Void_UnityActionRef_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674519);
		Events.NativeMethodInfoPtr_GetHandSize_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events>.NativeClassPtr, 100674520);
	}

	// Token: 0x06004446 RID: 17478 RVA: 0x00125E88 File Offset: 0x00124088
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114620, XrefRangeEnd = 114629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSceneLoaded(UnityAction<Scene> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSceneLoaded_Public_Static_add_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004447 RID: 17479 RVA: 0x00125EC0 File Offset: 0x001240C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114629, XrefRangeEnd = 114638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSceneLoaded(UnityAction<Scene> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSceneLoaded_Public_Static_rem_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004448 RID: 17480 RVA: 0x00125EF8 File Offset: 0x001240F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114638, XrefRangeEnd = 114640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSceneLoaded(Scene scene)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref scene;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSceneLoaded_Public_Static_Void_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004449 RID: 17481 RVA: 0x00125F2C File Offset: 0x0012412C
	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 114649, RefRangeEnd = 114675, XrefRangeStart = 114640, XrefRangeEnd = 114649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSceneChanged(UnityAction<Scene> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSceneChanged_Public_Static_add_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600444A RID: 17482 RVA: 0x00125F64 File Offset: 0x00124164
	[CallerCount(26)]
	[CachedScanResults(RefRangeStart = 114684, RefRangeEnd = 114710, XrefRangeStart = 114675, XrefRangeEnd = 114684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSceneChanged(UnityAction<Scene> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSceneChanged_Public_Static_rem_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600444B RID: 17483 RVA: 0x00125F9C File Offset: 0x0012419C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114710, XrefRangeEnd = 114712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSceneChanged(Scene scene)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref scene;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSceneChanged_Public_Static_Void_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600444C RID: 17484 RVA: 0x00125FD0 File Offset: 0x001241D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114721, RefRangeEnd = 114722, XrefRangeStart = 114712, XrefRangeEnd = 114721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSceneUnload(UnityAction<Scene> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSceneUnload_Public_Static_add_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600444D RID: 17485 RVA: 0x00126008 File Offset: 0x00124208
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114731, RefRangeEnd = 114732, XrefRangeStart = 114722, XrefRangeEnd = 114731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSceneUnload(UnityAction<Scene> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSceneUnload_Public_Static_rem_Void_UnityAction_1_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600444E RID: 17486 RVA: 0x00126040 File Offset: 0x00124240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114732, XrefRangeEnd = 114734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSceneUnload(Scene scene)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref scene;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSceneUnload_Public_Static_Void_Scene_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600444F RID: 17487 RVA: 0x00126074 File Offset: 0x00124274
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114741, RefRangeEnd = 114742, XrefRangeStart = 114734, XrefRangeEnd = 114741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBackToMainMenu(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBackToMainMenu_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004450 RID: 17488 RVA: 0x001260AC File Offset: 0x001242AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114749, RefRangeEnd = 114750, XrefRangeStart = 114742, XrefRangeEnd = 114749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBackToMainMenu(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBackToMainMenu_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004451 RID: 17489 RVA: 0x001260E4 File Offset: 0x001242E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114752, RefRangeEnd = 114753, XrefRangeStart = 114750, XrefRangeEnd = 114752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBackToMainMenu()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBackToMainMenu_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004452 RID: 17490 RVA: 0x0012610C File Offset: 0x0012430C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 114762, RefRangeEnd = 114769, XrefRangeStart = 114753, XrefRangeEnd = 114762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityCreated(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityCreated_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004453 RID: 17491 RVA: 0x00126144 File Offset: 0x00124344
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 114778, RefRangeEnd = 114785, XrefRangeStart = 114769, XrefRangeEnd = 114778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityCreated(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityCreated_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004454 RID: 17492 RVA: 0x0012617C File Offset: 0x0012437C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114787, RefRangeEnd = 114788, XrefRangeStart = 114785, XrefRangeEnd = 114787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityCreated(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityCreated_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004455 RID: 17493 RVA: 0x001261B4 File Offset: 0x001243B4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 114797, RefRangeEnd = 114799, XrefRangeStart = 114788, XrefRangeEnd = 114797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityDataUpdated(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityDataUpdated_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004456 RID: 17494 RVA: 0x001261EC File Offset: 0x001243EC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 114808, RefRangeEnd = 114810, XrefRangeStart = 114799, XrefRangeEnd = 114808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityDataUpdated(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityDataUpdated_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004457 RID: 17495 RVA: 0x00126224 File Offset: 0x00124424
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114810, XrefRangeEnd = 114812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityDataUpdated(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityDataUpdated_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004458 RID: 17496 RVA: 0x0012625C File Offset: 0x0012445C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 114821, RefRangeEnd = 114827, XrefRangeStart = 114812, XrefRangeEnd = 114821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityDestroyed(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityDestroyed_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004459 RID: 17497 RVA: 0x00126294 File Offset: 0x00124494
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 114836, RefRangeEnd = 114842, XrefRangeStart = 114827, XrefRangeEnd = 114836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityDestroyed(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityDestroyed_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600445A RID: 17498 RVA: 0x001262CC File Offset: 0x001244CC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 114844, RefRangeEnd = 114846, XrefRangeStart = 114842, XrefRangeEnd = 114844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityDestroyed(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityDestroyed_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600445B RID: 17499 RVA: 0x00126304 File Offset: 0x00124504
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114855, RefRangeEnd = 114856, XrefRangeStart = 114846, XrefRangeEnd = 114855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCardPooled(UnityAction<Card> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCardPooled_Public_Static_add_Void_UnityAction_1_Card_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600445C RID: 17500 RVA: 0x0012633C File Offset: 0x0012453C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114865, RefRangeEnd = 114866, XrefRangeStart = 114856, XrefRangeEnd = 114865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCardPooled(UnityAction<Card> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCardPooled_Public_Static_rem_Void_UnityAction_1_Card_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600445D RID: 17501 RVA: 0x00126374 File Offset: 0x00124574
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114868, RefRangeEnd = 114869, XrefRangeStart = 114866, XrefRangeEnd = 114868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCardPooled(Card card)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCardPooled_Public_Static_Void_Card_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600445E RID: 17502 RVA: 0x001263AC File Offset: 0x001245AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114878, RefRangeEnd = 114879, XrefRangeStart = 114869, XrefRangeEnd = 114878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityEnabled(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityEnabled_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600445F RID: 17503 RVA: 0x001263E4 File Offset: 0x001245E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114888, RefRangeEnd = 114889, XrefRangeStart = 114879, XrefRangeEnd = 114888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityEnabled(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityEnabled_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004460 RID: 17504 RVA: 0x0012641C File Offset: 0x0012461C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114891, RefRangeEnd = 114892, XrefRangeStart = 114889, XrefRangeEnd = 114891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityEnabled(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityEnabled_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004461 RID: 17505 RVA: 0x00126454 File Offset: 0x00124654
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114901, RefRangeEnd = 114902, XrefRangeStart = 114892, XrefRangeEnd = 114901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityDisabled(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityDisabled_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004462 RID: 17506 RVA: 0x0012648C File Offset: 0x0012468C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114911, RefRangeEnd = 114912, XrefRangeStart = 114902, XrefRangeEnd = 114911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityDisabled(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityDisabled_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004463 RID: 17507 RVA: 0x001264C4 File Offset: 0x001246C4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 114914, RefRangeEnd = 114917, XrefRangeStart = 114912, XrefRangeEnd = 114914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityDisabled(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityDisabled_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004464 RID: 17508 RVA: 0x001264FC File Offset: 0x001246FC
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 114926, RefRangeEnd = 114941, XrefRangeStart = 114917, XrefRangeEnd = 114926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityKilled(UnityAction<Entity, DeathType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityKilled_Public_Static_add_Void_UnityAction_2_Entity_DeathType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004465 RID: 17509 RVA: 0x00126534 File Offset: 0x00124734
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 114950, RefRangeEnd = 114965, XrefRangeStart = 114941, XrefRangeEnd = 114950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityKilled(UnityAction<Entity, DeathType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityKilled_Public_Static_rem_Void_UnityAction_2_Entity_DeathType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004466 RID: 17510 RVA: 0x0012656C File Offset: 0x0012476C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114965, XrefRangeEnd = 114967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityKilled(Entity entity, DeathType deathType)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deathType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityKilled_Public_Static_Void_Entity_DeathType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004467 RID: 17511 RVA: 0x001265B0 File Offset: 0x001247B0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 114976, RefRangeEnd = 114980, XrefRangeStart = 114967, XrefRangeEnd = 114976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityFlee(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityFlee_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004468 RID: 17512 RVA: 0x001265E8 File Offset: 0x001247E8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 114989, RefRangeEnd = 114993, XrefRangeStart = 114980, XrefRangeEnd = 114989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityFlee(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityFlee_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004469 RID: 17513 RVA: 0x00126620 File Offset: 0x00124820
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 114995, RefRangeEnd = 114996, XrefRangeStart = 114993, XrefRangeEnd = 114995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityFlee(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityFlee_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600446A RID: 17514 RVA: 0x00126658 File Offset: 0x00124858
	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 115005, RefRangeEnd = 115023, XrefRangeStart = 114996, XrefRangeEnd = 115005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityHover(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityHover_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600446B RID: 17515 RVA: 0x00126690 File Offset: 0x00124890
	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 115032, RefRangeEnd = 115050, XrefRangeStart = 115023, XrefRangeEnd = 115032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityHover(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityHover_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600446C RID: 17516 RVA: 0x001266C8 File Offset: 0x001248C8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 115052, RefRangeEnd = 115055, XrefRangeStart = 115050, XrefRangeEnd = 115052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityHover(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityHover_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600446D RID: 17517 RVA: 0x00126700 File Offset: 0x00124900
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 115064, RefRangeEnd = 115077, XrefRangeStart = 115055, XrefRangeEnd = 115064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityUnHover(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityUnHover_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600446E RID: 17518 RVA: 0x00126738 File Offset: 0x00124938
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 115086, RefRangeEnd = 115099, XrefRangeStart = 115077, XrefRangeEnd = 115086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityUnHover(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityUnHover_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600446F RID: 17519 RVA: 0x00126770 File Offset: 0x00124970
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115101, RefRangeEnd = 115102, XrefRangeStart = 115099, XrefRangeEnd = 115101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityUnHover(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityUnHover_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004470 RID: 17520 RVA: 0x001267A8 File Offset: 0x001249A8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115111, RefRangeEnd = 115113, XrefRangeStart = 115102, XrefRangeEnd = 115111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntitySelect(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntitySelect_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004471 RID: 17521 RVA: 0x001267E0 File Offset: 0x001249E0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115122, RefRangeEnd = 115124, XrefRangeStart = 115113, XrefRangeEnd = 115122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntitySelect(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntitySelect_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004472 RID: 17522 RVA: 0x00126818 File Offset: 0x00124A18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115126, RefRangeEnd = 115127, XrefRangeStart = 115124, XrefRangeEnd = 115126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntitySelect(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntitySelect_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004473 RID: 17523 RVA: 0x00126850 File Offset: 0x00124A50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115127, XrefRangeEnd = 115136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCheckEntityDrag(Events.UnityActionRef<Entity, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCheckEntityDrag_Public_Static_add_Void_UnityActionRef_2_Entity_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004474 RID: 17524 RVA: 0x00126888 File Offset: 0x00124A88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115136, XrefRangeEnd = 115145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCheckEntityDrag(Events.UnityActionRef<Entity, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCheckEntityDrag_Public_Static_rem_Void_UnityActionRef_2_Entity_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004475 RID: 17525 RVA: 0x001268C0 File Offset: 0x00124AC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115147, RefRangeEnd = 115148, XrefRangeStart = 115145, XrefRangeEnd = 115147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckEntityDrag(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_CheckEntityDrag_Public_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06004476 RID: 17526 RVA: 0x00126904 File Offset: 0x00124B04
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 115157, RefRangeEnd = 115164, XrefRangeStart = 115148, XrefRangeEnd = 115157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityDrag(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityDrag_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004477 RID: 17527 RVA: 0x0012693C File Offset: 0x00124B3C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 115173, RefRangeEnd = 115180, XrefRangeStart = 115164, XrefRangeEnd = 115173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityDrag(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityDrag_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004478 RID: 17528 RVA: 0x00126974 File Offset: 0x00124B74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115182, RefRangeEnd = 115183, XrefRangeStart = 115180, XrefRangeEnd = 115182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityDrag(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityDrag_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004479 RID: 17529 RVA: 0x001269AC File Offset: 0x00124BAC
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 115192, RefRangeEnd = 115199, XrefRangeStart = 115183, XrefRangeEnd = 115192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityRelease(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityRelease_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600447A RID: 17530 RVA: 0x001269E4 File Offset: 0x00124BE4
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 115208, RefRangeEnd = 115215, XrefRangeStart = 115199, XrefRangeEnd = 115208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityRelease(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityRelease_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600447B RID: 17531 RVA: 0x00126A1C File Offset: 0x00124C1C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115217, RefRangeEnd = 115219, XrefRangeStart = 115215, XrefRangeEnd = 115217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityRelease(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityRelease_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600447C RID: 17532 RVA: 0x00126A54 File Offset: 0x00124C54
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115228, RefRangeEnd = 115229, XrefRangeStart = 115219, XrefRangeEnd = 115228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityOffered(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityOffered_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600447D RID: 17533 RVA: 0x00126A8C File Offset: 0x00124C8C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115238, RefRangeEnd = 115239, XrefRangeStart = 115229, XrefRangeEnd = 115238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityOffered(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityOffered_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600447E RID: 17534 RVA: 0x00126AC4 File Offset: 0x00124CC4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 115241, RefRangeEnd = 115244, XrefRangeStart = 115239, XrefRangeEnd = 115241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityOffered(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityOffered_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600447F RID: 17535 RVA: 0x00126AFC File Offset: 0x00124CFC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115253, RefRangeEnd = 115254, XrefRangeStart = 115244, XrefRangeEnd = 115253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityChosen(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityChosen_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004480 RID: 17536 RVA: 0x00126B34 File Offset: 0x00124D34
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115263, RefRangeEnd = 115264, XrefRangeStart = 115254, XrefRangeEnd = 115263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityChosen(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityChosen_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004481 RID: 17537 RVA: 0x00126B6C File Offset: 0x00124D6C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 115266, RefRangeEnd = 115273, XrefRangeStart = 115264, XrefRangeEnd = 115266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityChosen(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityChosen_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004482 RID: 17538 RVA: 0x00126BA4 File Offset: 0x00124DA4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115282, RefRangeEnd = 115283, XrefRangeStart = 115273, XrefRangeEnd = 115282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityShowUnlocked(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityShowUnlocked_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004483 RID: 17539 RVA: 0x00126BDC File Offset: 0x00124DDC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115292, RefRangeEnd = 115293, XrefRangeStart = 115283, XrefRangeEnd = 115292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityShowUnlocked(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityShowUnlocked_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004484 RID: 17540 RVA: 0x00126C14 File Offset: 0x00124E14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115293, XrefRangeEnd = 115295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityShowUnlocked(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityShowUnlocked_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004485 RID: 17541 RVA: 0x00126C4C File Offset: 0x00124E4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115295, XrefRangeEnd = 115304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCheckEntityShove(Events.UnityActionRef<Entity, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCheckEntityShove_Public_Static_add_Void_UnityActionRef_2_Entity_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004486 RID: 17542 RVA: 0x00126C84 File Offset: 0x00124E84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115304, XrefRangeEnd = 115313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCheckEntityShove(Events.UnityActionRef<Entity, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCheckEntityShove_Public_Static_rem_Void_UnityActionRef_2_Entity_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004487 RID: 17543 RVA: 0x00126CBC File Offset: 0x00124EBC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115315, RefRangeEnd = 115316, XrefRangeStart = 115313, XrefRangeEnd = 115315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckEntityShove(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_CheckEntityShove_Public_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06004488 RID: 17544 RVA: 0x00126D00 File Offset: 0x00124F00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115325, RefRangeEnd = 115326, XrefRangeStart = 115316, XrefRangeEnd = 115325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPreProcessTrigger(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnPreProcessTrigger_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004489 RID: 17545 RVA: 0x00126D38 File Offset: 0x00124F38
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115335, RefRangeEnd = 115336, XrefRangeStart = 115326, XrefRangeEnd = 115335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPreProcessTrigger(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnPreProcessTrigger_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600448A RID: 17546 RVA: 0x00126D70 File Offset: 0x00124F70
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 115338, RefRangeEnd = 115341, XrefRangeStart = 115336, XrefRangeEnd = 115338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePreProcessTrigger(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePreProcessTrigger_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600448B RID: 17547 RVA: 0x00126DA8 File Offset: 0x00124FA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115341, XrefRangeEnd = 115350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityPreTrigger(Events.UnityActionRef<Trigger> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityPreTrigger_Public_Static_add_Void_UnityActionRef_1_Trigger_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600448C RID: 17548 RVA: 0x00126DE0 File Offset: 0x00124FE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115350, XrefRangeEnd = 115359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityPreTrigger(Events.UnityActionRef<Trigger> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityPreTrigger_Public_Static_rem_Void_UnityActionRef_1_Trigger_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600448D RID: 17549 RVA: 0x00126E18 File Offset: 0x00125018
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115361, RefRangeEnd = 115362, XrefRangeStart = 115359, XrefRangeEnd = 115361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityPreTrigger(ref Trigger trigger)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityPreTrigger_Public_Static_Void_byref_Trigger_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		trigger = ((intPtr4 == 0) ? null : new Trigger(intPtr4));
	}

	// Token: 0x0600448E RID: 17550 RVA: 0x00126E64 File Offset: 0x00125064
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 115371, RefRangeEnd = 115375, XrefRangeStart = 115362, XrefRangeEnd = 115371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityTrigger(Events.UnityActionRef<Trigger> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityTrigger_Public_Static_add_Void_UnityActionRef_1_Trigger_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600448F RID: 17551 RVA: 0x00126E9C File Offset: 0x0012509C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 115384, RefRangeEnd = 115388, XrefRangeStart = 115375, XrefRangeEnd = 115384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityTrigger(Events.UnityActionRef<Trigger> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityTrigger_Public_Static_rem_Void_UnityActionRef_1_Trigger_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004490 RID: 17552 RVA: 0x00126ED4 File Offset: 0x001250D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115390, RefRangeEnd = 115391, XrefRangeStart = 115388, XrefRangeEnd = 115390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityTrigger(ref Trigger trigger)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityTrigger_Public_Static_Void_byref_Trigger_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		trigger = ((intPtr4 == 0) ? null : new Trigger(intPtr4));
	}

	// Token: 0x06004491 RID: 17553 RVA: 0x00126F20 File Offset: 0x00125120
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115400, RefRangeEnd = 115401, XrefRangeStart = 115391, XrefRangeEnd = 115400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityTriggered(Events.UnityActionRef<Trigger> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityTriggered_Public_Static_add_Void_UnityActionRef_1_Trigger_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004492 RID: 17554 RVA: 0x00126F58 File Offset: 0x00125158
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115410, RefRangeEnd = 115411, XrefRangeStart = 115401, XrefRangeEnd = 115410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityTriggered(Events.UnityActionRef<Trigger> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityTriggered_Public_Static_rem_Void_UnityActionRef_1_Trigger_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004493 RID: 17555 RVA: 0x00126F90 File Offset: 0x00125190
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115413, RefRangeEnd = 115414, XrefRangeStart = 115411, XrefRangeEnd = 115413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityTriggered(ref Trigger trigger)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityTriggered_Public_Static_Void_byref_Trigger_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		trigger = ((intPtr4 == 0) ? null : new Trigger(intPtr4));
	}

	// Token: 0x06004494 RID: 17556 RVA: 0x00126FDC File Offset: 0x001251DC
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 115423, RefRangeEnd = 115431, XrefRangeStart = 115414, XrefRangeEnd = 115423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityMove(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityMove_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004495 RID: 17557 RVA: 0x00127014 File Offset: 0x00125214
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 115440, RefRangeEnd = 115448, XrefRangeStart = 115431, XrefRangeEnd = 115440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityMove(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityMove_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004496 RID: 17558 RVA: 0x0012704C File Offset: 0x0012524C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115450, RefRangeEnd = 115451, XrefRangeStart = 115448, XrefRangeEnd = 115450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityMove(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityMove_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004497 RID: 17559 RVA: 0x00127084 File Offset: 0x00125284
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115460, RefRangeEnd = 115462, XrefRangeStart = 115451, XrefRangeEnd = 115460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityPlace(UnityAction<Entity, Il2CppReferenceArray<CardContainer>, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityPlace_Public_Static_add_Void_UnityAction_3_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004498 RID: 17560 RVA: 0x001270BC File Offset: 0x001252BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115471, RefRangeEnd = 115473, XrefRangeStart = 115462, XrefRangeEnd = 115471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityPlace(UnityAction<Entity, Il2CppReferenceArray<CardContainer>, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityPlace_Public_Static_rem_Void_UnityAction_3_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004499 RID: 17561 RVA: 0x001270F4 File Offset: 0x001252F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115473, XrefRangeEnd = 115475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityPlace(Entity entity, Il2CppReferenceArray<CardContainer> containers, bool freeMove)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(containers);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref freeMove;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityPlace_Public_Static_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600449A RID: 17562 RVA: 0x0012714C File Offset: 0x0012534C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 115484, RefRangeEnd = 115488, XrefRangeStart = 115475, XrefRangeEnd = 115484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnDiscard(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnDiscard_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600449B RID: 17563 RVA: 0x00127184 File Offset: 0x00125384
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 115497, RefRangeEnd = 115501, XrefRangeStart = 115488, XrefRangeEnd = 115497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnDiscard(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnDiscard_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600449C RID: 17564 RVA: 0x001271BC File Offset: 0x001253BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115503, RefRangeEnd = 115504, XrefRangeStart = 115501, XrefRangeEnd = 115503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeDiscard(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeDiscard_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600449D RID: 17565 RVA: 0x001271F4 File Offset: 0x001253F4
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 115513, RefRangeEnd = 115523, XrefRangeStart = 115504, XrefRangeEnd = 115513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityHit(UnityAction<Hit> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityHit_Public_Static_add_Void_UnityAction_1_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600449E RID: 17566 RVA: 0x0012722C File Offset: 0x0012542C
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 115532, RefRangeEnd = 115542, XrefRangeStart = 115523, XrefRangeEnd = 115532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityHit(UnityAction<Hit> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityHit_Public_Static_rem_Void_UnityAction_1_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600449F RID: 17567 RVA: 0x00127264 File Offset: 0x00125464
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115544, RefRangeEnd = 115545, XrefRangeStart = 115542, XrefRangeEnd = 115544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityHit(Hit hit)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityHit_Public_Static_Void_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A0 RID: 17568 RVA: 0x0012729C File Offset: 0x0012549C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115554, RefRangeEnd = 115556, XrefRangeStart = 115545, XrefRangeEnd = 115554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityPostHit(UnityAction<Hit> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityPostHit_Public_Static_add_Void_UnityAction_1_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A1 RID: 17569 RVA: 0x001272D4 File Offset: 0x001254D4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115565, RefRangeEnd = 115567, XrefRangeStart = 115556, XrefRangeEnd = 115565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityPostHit(UnityAction<Hit> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityPostHit_Public_Static_rem_Void_UnityAction_1_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A2 RID: 17570 RVA: 0x0012730C File Offset: 0x0012550C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115569, RefRangeEnd = 115570, XrefRangeStart = 115567, XrefRangeEnd = 115569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityPostHit(Hit hit)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityPostHit_Public_Static_Void_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A3 RID: 17571 RVA: 0x00127344 File Offset: 0x00125544
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115579, RefRangeEnd = 115580, XrefRangeStart = 115570, XrefRangeEnd = 115579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityDodge(UnityAction<Hit> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityDodge_Public_Static_add_Void_UnityAction_1_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A4 RID: 17572 RVA: 0x0012737C File Offset: 0x0012557C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115589, RefRangeEnd = 115590, XrefRangeStart = 115580, XrefRangeEnd = 115589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityDodge(UnityAction<Hit> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityDodge_Public_Static_rem_Void_UnityAction_1_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A5 RID: 17573 RVA: 0x001273B4 File Offset: 0x001255B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115592, RefRangeEnd = 115593, XrefRangeStart = 115590, XrefRangeEnd = 115592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityDodge(Hit hit)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityDodge_Public_Static_Void_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A6 RID: 17574 RVA: 0x001273EC File Offset: 0x001255EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115602, RefRangeEnd = 115603, XrefRangeStart = 115593, XrefRangeEnd = 115602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityFlipUp(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityFlipUp_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A7 RID: 17575 RVA: 0x00127424 File Offset: 0x00125624
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115612, RefRangeEnd = 115613, XrefRangeStart = 115603, XrefRangeEnd = 115612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityFlipUp(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityFlipUp_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A8 RID: 17576 RVA: 0x0012745C File Offset: 0x0012565C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115615, RefRangeEnd = 115616, XrefRangeStart = 115613, XrefRangeEnd = 115615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityFlipUp(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityFlipUp_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044A9 RID: 17577 RVA: 0x00127494 File Offset: 0x00125694
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115625, RefRangeEnd = 115626, XrefRangeStart = 115616, XrefRangeEnd = 115625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityFlipDown(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityFlipDown_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044AA RID: 17578 RVA: 0x001274CC File Offset: 0x001256CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115635, RefRangeEnd = 115636, XrefRangeStart = 115626, XrefRangeEnd = 115635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityFlipDown(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityFlipDown_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044AB RID: 17579 RVA: 0x00127504 File Offset: 0x00125704
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115638, RefRangeEnd = 115639, XrefRangeStart = 115636, XrefRangeEnd = 115638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityFlipDown(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityFlipDown_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044AC RID: 17580 RVA: 0x0012753C File Offset: 0x0012573C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115639, XrefRangeEnd = 115648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnStatusIconCreated(UnityAction<StatusIcon> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnStatusIconCreated_Public_Static_add_Void_UnityAction_1_StatusIcon_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044AD RID: 17581 RVA: 0x00127574 File Offset: 0x00125774
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115648, XrefRangeEnd = 115657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnStatusIconCreated(UnityAction<StatusIcon> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnStatusIconCreated_Public_Static_rem_Void_UnityAction_1_StatusIcon_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044AE RID: 17582 RVA: 0x001275AC File Offset: 0x001257AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115659, RefRangeEnd = 115660, XrefRangeStart = 115657, XrefRangeEnd = 115659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeStatusIconCreated(StatusIcon icon)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(icon);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeStatusIconCreated_Public_Static_Void_StatusIcon_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044AF RID: 17583 RVA: 0x001275E4 File Offset: 0x001257E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115669, RefRangeEnd = 115670, XrefRangeStart = 115660, XrefRangeEnd = 115669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnStatusIconChanged(UnityAction<StatusIcon, Stat, Stat> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnStatusIconChanged_Public_Static_add_Void_UnityAction_3_StatusIcon_Stat_Stat_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B0 RID: 17584 RVA: 0x0012761C File Offset: 0x0012581C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115679, RefRangeEnd = 115680, XrefRangeStart = 115670, XrefRangeEnd = 115679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnStatusIconChanged(UnityAction<StatusIcon, Stat, Stat> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnStatusIconChanged_Public_Static_rem_Void_UnityAction_3_StatusIcon_Stat_Stat_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B1 RID: 17585 RVA: 0x00127654 File Offset: 0x00125854
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115682, RefRangeEnd = 115684, XrefRangeStart = 115680, XrefRangeEnd = 115682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeStatusIconChanged(StatusIcon icon, Stat previousValue, Stat newValue)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(icon);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousValue;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeStatusIconChanged_Public_Static_Void_StatusIcon_Stat_Stat_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B2 RID: 17586 RVA: 0x001276A8 File Offset: 0x001258A8
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 115693, RefRangeEnd = 115700, XrefRangeStart = 115684, XrefRangeEnd = 115693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityDisplayUpdated(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityDisplayUpdated_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B3 RID: 17587 RVA: 0x001276E0 File Offset: 0x001258E0
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 115709, RefRangeEnd = 115716, XrefRangeStart = 115700, XrefRangeEnd = 115709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityDisplayUpdated(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityDisplayUpdated_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B4 RID: 17588 RVA: 0x00127718 File Offset: 0x00125918
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115718, RefRangeEnd = 115719, XrefRangeStart = 115716, XrefRangeEnd = 115718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityDisplayUpdated(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityDisplayUpdated_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B5 RID: 17589 RVA: 0x00127750 File Offset: 0x00125950
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115728, RefRangeEnd = 115729, XrefRangeStart = 115719, XrefRangeEnd = 115728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityFocus(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityFocus_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B6 RID: 17590 RVA: 0x00127788 File Offset: 0x00125988
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115738, RefRangeEnd = 115739, XrefRangeStart = 115729, XrefRangeEnd = 115738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityFocus(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityFocus_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B7 RID: 17591 RVA: 0x001277C0 File Offset: 0x001259C0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115741, RefRangeEnd = 115743, XrefRangeStart = 115739, XrefRangeEnd = 115741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityFocus(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityFocus_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B8 RID: 17592 RVA: 0x001277F8 File Offset: 0x001259F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115752, RefRangeEnd = 115753, XrefRangeStart = 115743, XrefRangeEnd = 115752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityEnterPocket(UnityAction<Entity, CardPocket> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityEnterPocket_Public_Static_add_Void_UnityAction_2_Entity_CardPocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044B9 RID: 17593 RVA: 0x00127830 File Offset: 0x00125A30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115762, RefRangeEnd = 115763, XrefRangeStart = 115753, XrefRangeEnd = 115762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityEnterPocket(UnityAction<Entity, CardPocket> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityEnterPocket_Public_Static_rem_Void_UnityAction_2_Entity_CardPocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044BA RID: 17594 RVA: 0x00127868 File Offset: 0x00125A68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115763, XrefRangeEnd = 115765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityEnterPocket(Entity card, CardPocket pocket)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pocket);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityEnterPocket_Public_Static_Void_Entity_CardPocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044BB RID: 17595 RVA: 0x001278B0 File Offset: 0x00125AB0
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 115774, RefRangeEnd = 115779, XrefRangeStart = 115765, XrefRangeEnd = 115774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityEnterBackpack(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityEnterBackpack_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044BC RID: 17596 RVA: 0x001278E8 File Offset: 0x00125AE8
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 115788, RefRangeEnd = 115793, XrefRangeStart = 115779, XrefRangeEnd = 115788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityEnterBackpack(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityEnterBackpack_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044BD RID: 17597 RVA: 0x00127920 File Offset: 0x00125B20
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 115795, RefRangeEnd = 115797, XrefRangeStart = 115793, XrefRangeEnd = 115795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityEnterBackpack(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityEnterBackpack_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044BE RID: 17598 RVA: 0x00127958 File Offset: 0x00125B58
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115806, RefRangeEnd = 115807, XrefRangeStart = 115797, XrefRangeEnd = 115806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityChangePhase(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityChangePhase_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044BF RID: 17599 RVA: 0x00127990 File Offset: 0x00125B90
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115816, RefRangeEnd = 115817, XrefRangeStart = 115807, XrefRangeEnd = 115816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityChangePhase(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityChangePhase_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C0 RID: 17600 RVA: 0x001279C8 File Offset: 0x00125BC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115819, RefRangeEnd = 115820, XrefRangeStart = 115817, XrefRangeEnd = 115819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityChangePhase(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityChangePhase_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C1 RID: 17601 RVA: 0x00127A00 File Offset: 0x00125C00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115820, XrefRangeEnd = 115829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnNoomlinShow(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnNoomlinShow_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C2 RID: 17602 RVA: 0x00127A38 File Offset: 0x00125C38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115829, XrefRangeEnd = 115838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnNoomlinShow(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnNoomlinShow_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C3 RID: 17603 RVA: 0x00127A70 File Offset: 0x00125C70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115840, RefRangeEnd = 115841, XrefRangeStart = 115838, XrefRangeEnd = 115840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeNoomlinShow(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeNoomlinShow_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C4 RID: 17604 RVA: 0x00127AA8 File Offset: 0x00125CA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115841, XrefRangeEnd = 115850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnNoomlinUsed(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnNoomlinUsed_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C5 RID: 17605 RVA: 0x00127AE0 File Offset: 0x00125CE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 115850, XrefRangeEnd = 115859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnNoomlinUsed(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnNoomlinUsed_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C6 RID: 17606 RVA: 0x00127B18 File Offset: 0x00125D18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115861, RefRangeEnd = 115862, XrefRangeStart = 115859, XrefRangeEnd = 115861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeNoomlinUsed(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeNoomlinUsed_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C7 RID: 17607 RVA: 0x00127B50 File Offset: 0x00125D50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115871, RefRangeEnd = 115872, XrefRangeStart = 115862, XrefRangeEnd = 115871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityFlipComplete(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityFlipComplete_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C8 RID: 17608 RVA: 0x00127B88 File Offset: 0x00125D88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115881, RefRangeEnd = 115882, XrefRangeStart = 115872, XrefRangeEnd = 115881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityFlipComplete(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityFlipComplete_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044C9 RID: 17609 RVA: 0x00127BC0 File Offset: 0x00125DC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115884, RefRangeEnd = 115885, XrefRangeStart = 115882, XrefRangeEnd = 115884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityFlipComplete(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityFlipComplete_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044CA RID: 17610 RVA: 0x00127BF8 File Offset: 0x00125DF8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 115894, RefRangeEnd = 115898, XrefRangeStart = 115885, XrefRangeEnd = 115894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntitySummoned(UnityAction<Entity, Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntitySummoned_Public_Static_add_Void_UnityAction_2_Entity_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044CB RID: 17611 RVA: 0x00127C30 File Offset: 0x00125E30
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 115907, RefRangeEnd = 115911, XrefRangeStart = 115898, XrefRangeEnd = 115907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntitySummoned(UnityAction<Entity, Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntitySummoned_Public_Static_rem_Void_UnityAction_2_Entity_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044CC RID: 17612 RVA: 0x00127C68 File Offset: 0x00125E68
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115913, RefRangeEnd = 115914, XrefRangeStart = 115911, XrefRangeEnd = 115913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntitySummoned(Entity entity, Entity summonedBy)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(summonedBy);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntitySummoned_Public_Static_Void_Entity_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044CD RID: 17613 RVA: 0x00127CB0 File Offset: 0x00125EB0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115923, RefRangeEnd = 115924, XrefRangeStart = 115914, XrefRangeEnd = 115923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityPing(UnityAction<GameObject> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityPing_Public_Static_add_Void_UnityAction_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044CE RID: 17614 RVA: 0x00127CE8 File Offset: 0x00125EE8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115933, RefRangeEnd = 115934, XrefRangeStart = 115924, XrefRangeEnd = 115933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityPing(UnityAction<GameObject> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityPing_Public_Static_rem_Void_UnityAction_1_GameObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044CF RID: 17615 RVA: 0x00127D20 File Offset: 0x00125F20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115936, RefRangeEnd = 115937, XrefRangeStart = 115934, XrefRangeEnd = 115936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityPing(GameObject obj)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityPing_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D0 RID: 17616 RVA: 0x00127D58 File Offset: 0x00125F58
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115946, RefRangeEnd = 115947, XrefRangeStart = 115937, XrefRangeEnd = 115946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCheckRecycleAmount(Events.UnityActionRef<Entity, int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCheckRecycleAmount_Public_Static_add_Void_UnityActionRef_2_Entity_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D1 RID: 17617 RVA: 0x00127D90 File Offset: 0x00125F90
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115956, RefRangeEnd = 115957, XrefRangeStart = 115947, XrefRangeEnd = 115956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCheckRecycleAmount(Events.UnityActionRef<Entity, int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCheckRecycleAmount_Public_Static_rem_Void_UnityActionRef_2_Entity_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D2 RID: 17618 RVA: 0x00127DC8 File Offset: 0x00125FC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 115959, RefRangeEnd = 115960, XrefRangeStart = 115957, XrefRangeEnd = 115959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CheckRecycleAmount(Entity entity, ref int amount)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &amount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_CheckRecycleAmount_Public_Static_Void_Entity_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D3 RID: 17619 RVA: 0x00127E0C File Offset: 0x0012600C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 115969, RefRangeEnd = 115972, XrefRangeStart = 115960, XrefRangeEnd = 115969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnContainerHover(UnityAction<CardContainer> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnContainerHover_Public_Static_add_Void_UnityAction_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D4 RID: 17620 RVA: 0x00127E44 File Offset: 0x00126044
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 115981, RefRangeEnd = 115984, XrefRangeStart = 115972, XrefRangeEnd = 115981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnContainerHover(UnityAction<CardContainer> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnContainerHover_Public_Static_rem_Void_UnityAction_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D5 RID: 17621 RVA: 0x00127E7C File Offset: 0x0012607C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 115986, RefRangeEnd = 115989, XrefRangeStart = 115984, XrefRangeEnd = 115986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeContainerHover(CardContainer container)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeContainerHover_Public_Static_Void_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D6 RID: 17622 RVA: 0x00127EB4 File Offset: 0x001260B4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 115998, RefRangeEnd = 116001, XrefRangeStart = 115989, XrefRangeEnd = 115998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnContainerUnHover(UnityAction<CardContainer> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnContainerUnHover_Public_Static_add_Void_UnityAction_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D7 RID: 17623 RVA: 0x00127EEC File Offset: 0x001260EC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 116010, RefRangeEnd = 116013, XrefRangeStart = 116001, XrefRangeEnd = 116010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnContainerUnHover(UnityAction<CardContainer> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnContainerUnHover_Public_Static_rem_Void_UnityAction_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D8 RID: 17624 RVA: 0x00127F24 File Offset: 0x00126124
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116015, RefRangeEnd = 116016, XrefRangeStart = 116013, XrefRangeEnd = 116015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeContainerUnHover(CardContainer container)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeContainerUnHover_Public_Static_Void_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044D9 RID: 17625 RVA: 0x00127F5C File Offset: 0x0012615C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 116025, RefRangeEnd = 116028, XrefRangeStart = 116016, XrefRangeEnd = 116025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSlotHover(UnityAction<CardSlot> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSlotHover_Public_Static_add_Void_UnityAction_1_CardSlot_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044DA RID: 17626 RVA: 0x00127F94 File Offset: 0x00126194
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 116037, RefRangeEnd = 116040, XrefRangeStart = 116028, XrefRangeEnd = 116037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSlotHover(UnityAction<CardSlot> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSlotHover_Public_Static_rem_Void_UnityAction_1_CardSlot_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044DB RID: 17627 RVA: 0x00127FCC File Offset: 0x001261CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116042, RefRangeEnd = 116043, XrefRangeStart = 116040, XrefRangeEnd = 116042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSlotHover(CardSlot slot)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSlotHover_Public_Static_Void_CardSlot_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044DC RID: 17628 RVA: 0x00128004 File Offset: 0x00126204
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116052, RefRangeEnd = 116054, XrefRangeStart = 116043, XrefRangeEnd = 116052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSlotUnHover(UnityAction<CardSlot> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSlotUnHover_Public_Static_add_Void_UnityAction_1_CardSlot_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044DD RID: 17629 RVA: 0x0012803C File Offset: 0x0012623C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116063, RefRangeEnd = 116065, XrefRangeStart = 116054, XrefRangeEnd = 116063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSlotUnHover(UnityAction<CardSlot> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSlotUnHover_Public_Static_rem_Void_UnityAction_1_CardSlot_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044DE RID: 17630 RVA: 0x00128074 File Offset: 0x00126274
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116067, RefRangeEnd = 116068, XrefRangeStart = 116065, XrefRangeEnd = 116067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSlotUnHover(CardSlot slot)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSlotUnHover_Public_Static_Void_CardSlot_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044DF RID: 17631 RVA: 0x001280AC File Offset: 0x001262AC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 116077, RefRangeEnd = 116080, XrefRangeStart = 116068, XrefRangeEnd = 116077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnActionQueued(UnityAction<PlayAction> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnActionQueued_Public_Static_add_Void_UnityAction_1_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E0 RID: 17632 RVA: 0x001280E4 File Offset: 0x001262E4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116089, RefRangeEnd = 116091, XrefRangeStart = 116080, XrefRangeEnd = 116089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnActionQueued(UnityAction<PlayAction> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnActionQueued_Public_Static_rem_Void_UnityAction_1_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E1 RID: 17633 RVA: 0x0012811C File Offset: 0x0012631C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116093, RefRangeEnd = 116094, XrefRangeStart = 116091, XrefRangeEnd = 116093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeActionQueued(PlayAction action)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeActionQueued_Public_Static_Void_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E2 RID: 17634 RVA: 0x00128154 File Offset: 0x00126354
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 116103, RefRangeEnd = 116116, XrefRangeStart = 116094, XrefRangeEnd = 116103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnActionPerform(UnityAction<PlayAction> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnActionPerform_Public_Static_add_Void_UnityAction_1_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E3 RID: 17635 RVA: 0x0012818C File Offset: 0x0012638C
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 116125, RefRangeEnd = 116137, XrefRangeStart = 116116, XrefRangeEnd = 116125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnActionPerform(UnityAction<PlayAction> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnActionPerform_Public_Static_rem_Void_UnityAction_1_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E4 RID: 17636 RVA: 0x001281C4 File Offset: 0x001263C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116137, XrefRangeEnd = 116139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeActionPerform(PlayAction action)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeActionPerform_Public_Static_Void_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E5 RID: 17637 RVA: 0x001281FC File Offset: 0x001263FC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116148, RefRangeEnd = 116149, XrefRangeStart = 116139, XrefRangeEnd = 116148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnActionFinished(UnityAction<PlayAction> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnActionFinished_Public_Static_add_Void_UnityAction_1_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E6 RID: 17638 RVA: 0x00128234 File Offset: 0x00126434
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116158, RefRangeEnd = 116159, XrefRangeStart = 116149, XrefRangeEnd = 116158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnActionFinished(UnityAction<PlayAction> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnActionFinished_Public_Static_rem_Void_UnityAction_1_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E7 RID: 17639 RVA: 0x0012826C File Offset: 0x0012646C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116159, XrefRangeEnd = 116161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeActionFinished(PlayAction action)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeActionFinished_Public_Static_Void_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E8 RID: 17640 RVA: 0x001282A4 File Offset: 0x001264A4
	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 116170, RefRangeEnd = 116187, XrefRangeStart = 116161, XrefRangeEnd = 116170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCheckAction(Events.UnityActionRef<PlayAction, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCheckAction_Public_Static_add_Void_UnityActionRef_2_PlayAction_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044E9 RID: 17641 RVA: 0x001282DC File Offset: 0x001264DC
	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 116196, RefRangeEnd = 116213, XrefRangeStart = 116187, XrefRangeEnd = 116196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCheckAction(Events.UnityActionRef<PlayAction, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCheckAction_Public_Static_rem_Void_UnityActionRef_2_PlayAction_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044EA RID: 17642 RVA: 0x00128314 File Offset: 0x00126514
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 116215, RefRangeEnd = 116227, XrefRangeStart = 116213, XrefRangeEnd = 116215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckAction(PlayAction action)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_CheckAction_Public_Static_Boolean_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060044EB RID: 17643 RVA: 0x00128358 File Offset: 0x00126558
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116236, RefRangeEnd = 116238, XrefRangeStart = 116227, XrefRangeEnd = 116236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAbilityTargetAdd(UnityAction<CardContainer> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnAbilityTargetAdd_Public_Static_add_Void_UnityAction_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044EC RID: 17644 RVA: 0x00128390 File Offset: 0x00126590
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116247, RefRangeEnd = 116249, XrefRangeStart = 116238, XrefRangeEnd = 116247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAbilityTargetAdd(UnityAction<CardContainer> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnAbilityTargetAdd_Public_Static_rem_Void_UnityAction_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044ED RID: 17645 RVA: 0x001283C8 File Offset: 0x001265C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116251, RefRangeEnd = 116252, XrefRangeStart = 116249, XrefRangeEnd = 116251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeAbilityTargetAdd(CardContainer container)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeAbilityTargetAdd_Public_Static_Void_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044EE RID: 17646 RVA: 0x00128400 File Offset: 0x00126600
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116261, RefRangeEnd = 116262, XrefRangeStart = 116252, XrefRangeEnd = 116261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAbilityTargetRemove(UnityAction<CardContainer> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnAbilityTargetRemove_Public_Static_add_Void_UnityAction_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044EF RID: 17647 RVA: 0x00128438 File Offset: 0x00126638
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116271, RefRangeEnd = 116272, XrefRangeStart = 116262, XrefRangeEnd = 116271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAbilityTargetRemove(UnityAction<CardContainer> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnAbilityTargetRemove_Public_Static_rem_Void_UnityAction_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F0 RID: 17648 RVA: 0x00128470 File Offset: 0x00126670
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 116274, RefRangeEnd = 116277, XrefRangeStart = 116272, XrefRangeEnd = 116274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeAbilityTargetRemove(CardContainer container)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeAbilityTargetRemove_Public_Static_Void_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F1 RID: 17649 RVA: 0x001284A8 File Offset: 0x001266A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116286, RefRangeEnd = 116287, XrefRangeStart = 116277, XrefRangeEnd = 116286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCardDraw(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCardDraw_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F2 RID: 17650 RVA: 0x001284E0 File Offset: 0x001266E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116296, RefRangeEnd = 116297, XrefRangeStart = 116287, XrefRangeEnd = 116296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCardDraw(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCardDraw_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F3 RID: 17651 RVA: 0x00128518 File Offset: 0x00126718
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116299, RefRangeEnd = 116300, XrefRangeStart = 116297, XrefRangeEnd = 116299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCardDraw(int count)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCardDraw_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F4 RID: 17652 RVA: 0x0012854C File Offset: 0x0012674C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116307, RefRangeEnd = 116309, XrefRangeStart = 116300, XrefRangeEnd = 116307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCardDrawEnd(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCardDrawEnd_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F5 RID: 17653 RVA: 0x00128584 File Offset: 0x00126784
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116316, RefRangeEnd = 116318, XrefRangeStart = 116309, XrefRangeEnd = 116316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCardDrawEnd(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCardDrawEnd_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F6 RID: 17654 RVA: 0x001285BC File Offset: 0x001267BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116318, XrefRangeEnd = 116320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCardDrawEnd()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCardDrawEnd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F7 RID: 17655 RVA: 0x001285E4 File Offset: 0x001267E4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116329, RefRangeEnd = 116331, XrefRangeStart = 116320, XrefRangeEnd = 116329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_PreBattleSetUp(UnityAction<CampaignNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_PreBattleSetUp_Public_Static_add_Void_UnityAction_1_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F8 RID: 17656 RVA: 0x0012861C File Offset: 0x0012681C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116340, RefRangeEnd = 116342, XrefRangeStart = 116331, XrefRangeEnd = 116340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_PreBattleSetUp(UnityAction<CampaignNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_PreBattleSetUp_Public_Static_rem_Void_UnityAction_1_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044F9 RID: 17657 RVA: 0x00128654 File Offset: 0x00126854
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116344, RefRangeEnd = 116345, XrefRangeStart = 116342, XrefRangeEnd = 116344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePreBattleSetUp(CampaignNode node)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePreBattleSetUp_Public_Static_Void_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044FA RID: 17658 RVA: 0x0012868C File Offset: 0x0012688C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116354, RefRangeEnd = 116356, XrefRangeStart = 116345, XrefRangeEnd = 116354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_PostBattleSetUp(UnityAction<CampaignNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_PostBattleSetUp_Public_Static_add_Void_UnityAction_1_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044FB RID: 17659 RVA: 0x001286C4 File Offset: 0x001268C4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116365, RefRangeEnd = 116367, XrefRangeStart = 116356, XrefRangeEnd = 116365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_PostBattleSetUp(UnityAction<CampaignNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_PostBattleSetUp_Public_Static_rem_Void_UnityAction_1_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044FC RID: 17660 RVA: 0x001286FC File Offset: 0x001268FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116367, XrefRangeEnd = 116369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePostBattleSetUp(CampaignNode node)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePostBattleSetUp_Public_Static_Void_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044FD RID: 17661 RVA: 0x00128734 File Offset: 0x00126934
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 116378, RefRangeEnd = 116392, XrefRangeStart = 116369, XrefRangeEnd = 116378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattlePhaseStart(UnityAction<Battle.Phase> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattlePhaseStart_Public_Static_add_Void_UnityAction_1_Phase_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044FE RID: 17662 RVA: 0x0012876C File Offset: 0x0012696C
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 116401, RefRangeEnd = 116415, XrefRangeStart = 116392, XrefRangeEnd = 116401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattlePhaseStart(UnityAction<Battle.Phase> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattlePhaseStart_Public_Static_rem_Void_UnityAction_1_Phase_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060044FF RID: 17663 RVA: 0x001287A4 File Offset: 0x001269A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116417, RefRangeEnd = 116418, XrefRangeStart = 116415, XrefRangeEnd = 116417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattlePhaseStart(Battle.Phase phase)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref phase;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattlePhaseStart_Public_Static_Void_Phase_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004500 RID: 17664 RVA: 0x001287D8 File Offset: 0x001269D8
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 116425, RefRangeEnd = 116434, XrefRangeStart = 116418, XrefRangeEnd = 116425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleStart(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleStart_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004501 RID: 17665 RVA: 0x00128810 File Offset: 0x00126A10
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 116441, RefRangeEnd = 116450, XrefRangeStart = 116434, XrefRangeEnd = 116441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleStart(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleStart_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004502 RID: 17666 RVA: 0x00128848 File Offset: 0x00126A48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116452, RefRangeEnd = 116453, XrefRangeStart = 116450, XrefRangeEnd = 116452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleStart()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleStart_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004503 RID: 17667 RVA: 0x00128870 File Offset: 0x00126A70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116460, RefRangeEnd = 116461, XrefRangeStart = 116453, XrefRangeEnd = 116460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_PreBattleEnd(Events.AsyncAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_PreBattleEnd_Public_Static_add_Void_AsyncAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004504 RID: 17668 RVA: 0x001288A8 File Offset: 0x00126AA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116468, RefRangeEnd = 116469, XrefRangeStart = 116461, XrefRangeEnd = 116468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_PreBattleEnd(Events.AsyncAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_PreBattleEnd_Public_Static_rem_Void_AsyncAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004505 RID: 17669 RVA: 0x001288E0 File Offset: 0x00126AE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116473, RefRangeEnd = 116474, XrefRangeStart = 116469, XrefRangeEnd = 116473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator InvokePreBattleEnd()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePreBattleEnd_Public_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06004506 RID: 17670 RVA: 0x00128914 File Offset: 0x00126B14
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 116481, RefRangeEnd = 116489, XrefRangeStart = 116474, XrefRangeEnd = 116481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleEnd(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleEnd_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004507 RID: 17671 RVA: 0x0012894C File Offset: 0x00126B4C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 116496, RefRangeEnd = 116504, XrefRangeStart = 116489, XrefRangeEnd = 116496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleEnd(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleEnd_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004508 RID: 17672 RVA: 0x00128984 File Offset: 0x00126B84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116506, RefRangeEnd = 116507, XrefRangeStart = 116504, XrefRangeEnd = 116506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleEnd()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleEnd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004509 RID: 17673 RVA: 0x001289AC File Offset: 0x00126BAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116514, RefRangeEnd = 116515, XrefRangeStart = 116507, XrefRangeEnd = 116514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleWinPreRewards(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleWinPreRewards_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600450A RID: 17674 RVA: 0x001289E4 File Offset: 0x00126BE4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116522, RefRangeEnd = 116523, XrefRangeStart = 116515, XrefRangeEnd = 116522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleWinPreRewards(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleWinPreRewards_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600450B RID: 17675 RVA: 0x00128A1C File Offset: 0x00126C1C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116525, RefRangeEnd = 116526, XrefRangeStart = 116523, XrefRangeEnd = 116525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleWinPreRewards()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleWinPreRewards_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600450C RID: 17676 RVA: 0x00128A44 File Offset: 0x00126C44
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116533, RefRangeEnd = 116535, XrefRangeStart = 116526, XrefRangeEnd = 116533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleWin(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleWin_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600450D RID: 17677 RVA: 0x00128A7C File Offset: 0x00126C7C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116542, RefRangeEnd = 116544, XrefRangeStart = 116535, XrefRangeEnd = 116542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleWin(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleWin_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600450E RID: 17678 RVA: 0x00128AB4 File Offset: 0x00126CB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116546, RefRangeEnd = 116547, XrefRangeStart = 116544, XrefRangeEnd = 116546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleWin()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleWin_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600450F RID: 17679 RVA: 0x00128ADC File Offset: 0x00126CDC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116556, RefRangeEnd = 116558, XrefRangeStart = 116547, XrefRangeEnd = 116556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_PostBattle(UnityAction<CampaignNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_PostBattle_Public_Static_add_Void_UnityAction_1_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004510 RID: 17680 RVA: 0x00128B14 File Offset: 0x00126D14
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116567, RefRangeEnd = 116569, XrefRangeStart = 116558, XrefRangeEnd = 116567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_PostBattle(UnityAction<CampaignNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_PostBattle_Public_Static_rem_Void_UnityAction_1_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004511 RID: 17681 RVA: 0x00128B4C File Offset: 0x00126D4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116569, XrefRangeEnd = 116571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePostBattle(CampaignNode campaignNode)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(campaignNode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePostBattle_Public_Static_Void_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004512 RID: 17682 RVA: 0x00128B84 File Offset: 0x00126D84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116580, RefRangeEnd = 116581, XrefRangeStart = 116571, XrefRangeEnd = 116580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnStatusEffectCountDown(Events.UnityActionCheck<StatusEffectData, int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnStatusEffectCountDown_Public_Static_add_Void_UnityActionCheck_2_StatusEffectData_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004513 RID: 17683 RVA: 0x00128BBC File Offset: 0x00126DBC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116590, RefRangeEnd = 116591, XrefRangeStart = 116581, XrefRangeEnd = 116590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnStatusEffectCountDown(Events.UnityActionCheck<StatusEffectData, int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnStatusEffectCountDown_Public_Static_rem_Void_UnityActionCheck_2_StatusEffectData_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004514 RID: 17684 RVA: 0x00128BF4 File Offset: 0x00126DF4
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 116593, RefRangeEnd = 116605, XrefRangeStart = 116591, XrefRangeEnd = 116593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeStatusEffectCountDown(StatusEffectData status, ref int amount)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &amount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeStatusEffectCountDown_Public_Static_Void_StatusEffectData_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004515 RID: 17685 RVA: 0x00128C38 File Offset: 0x00126E38
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 116614, RefRangeEnd = 116619, XrefRangeStart = 116605, XrefRangeEnd = 116614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnStatusEffectApplied(UnityAction<StatusEffectApply> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnStatusEffectApplied_Public_Static_add_Void_UnityAction_1_StatusEffectApply_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004516 RID: 17686 RVA: 0x00128C70 File Offset: 0x00126E70
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 116628, RefRangeEnd = 116633, XrefRangeStart = 116619, XrefRangeEnd = 116628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnStatusEffectApplied(UnityAction<StatusEffectApply> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnStatusEffectApplied_Public_Static_rem_Void_UnityAction_1_StatusEffectApply_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004517 RID: 17687 RVA: 0x00128CA8 File Offset: 0x00126EA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116635, RefRangeEnd = 116636, XrefRangeStart = 116633, XrefRangeEnd = 116635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeStatusEffectApplied(StatusEffectApply apply)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(apply);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeStatusEffectApplied_Public_Static_Void_StatusEffectApply_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004518 RID: 17688 RVA: 0x00128CE0 File Offset: 0x00126EE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116636, XrefRangeEnd = 116645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPreProcessUnits(UnityAction<Character> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnPreProcessUnits_Public_Static_add_Void_UnityAction_1_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004519 RID: 17689 RVA: 0x00128D18 File Offset: 0x00126F18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116645, XrefRangeEnd = 116654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPreProcessUnits(UnityAction<Character> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnPreProcessUnits_Public_Static_rem_Void_UnityAction_1_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600451A RID: 17690 RVA: 0x00128D50 File Offset: 0x00126F50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116656, RefRangeEnd = 116657, XrefRangeStart = 116654, XrefRangeEnd = 116656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePreProcessUnits(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePreProcessUnits_Public_Static_Void_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600451B RID: 17691 RVA: 0x00128D88 File Offset: 0x00126F88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116666, RefRangeEnd = 116667, XrefRangeStart = 116657, XrefRangeEnd = 116666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPostProcessUnits(UnityAction<Character> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnPostProcessUnits_Public_Static_add_Void_UnityAction_1_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600451C RID: 17692 RVA: 0x00128DC0 File Offset: 0x00126FC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116676, RefRangeEnd = 116677, XrefRangeStart = 116667, XrefRangeEnd = 116676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPostProcessUnits(UnityAction<Character> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnPostProcessUnits_Public_Static_rem_Void_UnityAction_1_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600451D RID: 17693 RVA: 0x00128DF8 File Offset: 0x00126FF8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116679, RefRangeEnd = 116680, XrefRangeStart = 116677, XrefRangeEnd = 116679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePostProcessUnits(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePostProcessUnits_Public_Static_Void_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600451E RID: 17694 RVA: 0x00128E30 File Offset: 0x00127030
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116689, RefRangeEnd = 116690, XrefRangeStart = 116680, XrefRangeEnd = 116689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEntityCountDown(Events.UnityActionCheck<Entity, int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEntityCountDown_Public_Static_add_Void_UnityActionCheck_2_Entity_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600451F RID: 17695 RVA: 0x00128E68 File Offset: 0x00127068
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116699, RefRangeEnd = 116700, XrefRangeStart = 116690, XrefRangeEnd = 116699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEntityCountDown(Events.UnityActionCheck<Entity, int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEntityCountDown_Public_Static_rem_Void_UnityActionCheck_2_Entity_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004520 RID: 17696 RVA: 0x00128EA0 File Offset: 0x001270A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116700, XrefRangeEnd = 116702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEntityCountDown(Entity entity, ref int amount)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &amount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEntityCountDown_Public_Static_Void_Entity_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004521 RID: 17697 RVA: 0x00128EE4 File Offset: 0x001270E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116711, RefRangeEnd = 116712, XrefRangeStart = 116702, XrefRangeEnd = 116711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattlePreTurnStart(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattlePreTurnStart_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004522 RID: 17698 RVA: 0x00128F1C File Offset: 0x0012711C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116721, RefRangeEnd = 116722, XrefRangeStart = 116712, XrefRangeEnd = 116721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattlePreTurnStart(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattlePreTurnStart_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004523 RID: 17699 RVA: 0x00128F54 File Offset: 0x00127154
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116724, RefRangeEnd = 116725, XrefRangeStart = 116722, XrefRangeEnd = 116724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattlePreTurnStart(int turnNumber)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref turnNumber;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattlePreTurnStart_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004524 RID: 17700 RVA: 0x00128F88 File Offset: 0x00127188
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 116734, RefRangeEnd = 116748, XrefRangeStart = 116725, XrefRangeEnd = 116734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleTurnStart(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleTurnStart_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004525 RID: 17701 RVA: 0x00128FC0 File Offset: 0x001271C0
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 116757, RefRangeEnd = 116770, XrefRangeStart = 116748, XrefRangeEnd = 116757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleTurnStart(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleTurnStart_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004526 RID: 17702 RVA: 0x00128FF8 File Offset: 0x001271F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116772, RefRangeEnd = 116773, XrefRangeStart = 116770, XrefRangeEnd = 116772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleTurnStart(int turnNumber)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref turnNumber;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleTurnStart_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004527 RID: 17703 RVA: 0x0012902C File Offset: 0x0012722C
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 116782, RefRangeEnd = 116794, XrefRangeStart = 116773, XrefRangeEnd = 116782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleTurnEnd(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleTurnEnd_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004528 RID: 17704 RVA: 0x00129064 File Offset: 0x00127264
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 116803, RefRangeEnd = 116815, XrefRangeStart = 116794, XrefRangeEnd = 116803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleTurnEnd(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleTurnEnd_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004529 RID: 17705 RVA: 0x0012909C File Offset: 0x0012729C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 116817, RefRangeEnd = 116819, XrefRangeStart = 116815, XrefRangeEnd = 116817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleTurnEnd(int turnNumber)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref turnNumber;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleTurnEnd_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600452A RID: 17706 RVA: 0x001290D0 File Offset: 0x001272D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116828, RefRangeEnd = 116829, XrefRangeStart = 116819, XrefRangeEnd = 116828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMinibossIntro(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMinibossIntro_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600452B RID: 17707 RVA: 0x00129108 File Offset: 0x00127308
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116838, RefRangeEnd = 116839, XrefRangeStart = 116829, XrefRangeEnd = 116838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMinibossIntro(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMinibossIntro_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600452C RID: 17708 RVA: 0x00129140 File Offset: 0x00127340
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116841, RefRangeEnd = 116842, XrefRangeStart = 116839, XrefRangeEnd = 116841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMinibossIntro(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMinibossIntro_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600452D RID: 17709 RVA: 0x00129178 File Offset: 0x00127378
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116842, XrefRangeEnd = 116851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMinibossIntroDone(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMinibossIntroDone_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600452E RID: 17710 RVA: 0x001291B0 File Offset: 0x001273B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116851, XrefRangeEnd = 116860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMinibossIntroDone(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMinibossIntroDone_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600452F RID: 17711 RVA: 0x001291E8 File Offset: 0x001273E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116862, RefRangeEnd = 116863, XrefRangeStart = 116860, XrefRangeEnd = 116862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMinibossIntroDone(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMinibossIntroDone_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004530 RID: 17712 RVA: 0x00129220 File Offset: 0x00127420
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116872, RefRangeEnd = 116873, XrefRangeStart = 116863, XrefRangeEnd = 116872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnKillCombo(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnKillCombo_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004531 RID: 17713 RVA: 0x00129258 File Offset: 0x00127458
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116882, RefRangeEnd = 116883, XrefRangeStart = 116873, XrefRangeEnd = 116882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnKillCombo(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnKillCombo_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004532 RID: 17714 RVA: 0x00129290 File Offset: 0x00127490
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116885, RefRangeEnd = 116886, XrefRangeStart = 116883, XrefRangeEnd = 116885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeKillCombo(int combo)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref combo;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeKillCombo_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004533 RID: 17715 RVA: 0x001292C4 File Offset: 0x001274C4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 116895, RefRangeEnd = 116899, XrefRangeStart = 116886, XrefRangeEnd = 116895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnRedrawBellHit(UnityAction<RedrawBellSystem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnRedrawBellHit_Public_Static_add_Void_UnityAction_1_RedrawBellSystem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004534 RID: 17716 RVA: 0x001292FC File Offset: 0x001274FC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 116908, RefRangeEnd = 116912, XrefRangeStart = 116899, XrefRangeEnd = 116908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnRedrawBellHit(UnityAction<RedrawBellSystem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnRedrawBellHit_Public_Static_rem_Void_UnityAction_1_RedrawBellSystem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004535 RID: 17717 RVA: 0x00129334 File Offset: 0x00127534
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116914, RefRangeEnd = 116915, XrefRangeStart = 116912, XrefRangeEnd = 116914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeRedrawBellHit(RedrawBellSystem redrawBellSystem)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(redrawBellSystem);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeRedrawBellHit_Public_Static_Void_RedrawBellSystem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004536 RID: 17718 RVA: 0x0012936C File Offset: 0x0012756C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116924, RefRangeEnd = 116925, XrefRangeStart = 116915, XrefRangeEnd = 116924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnRedrawBellRevealed(UnityAction<RedrawBellSystem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnRedrawBellRevealed_Public_Static_add_Void_UnityAction_1_RedrawBellSystem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004537 RID: 17719 RVA: 0x001293A4 File Offset: 0x001275A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116934, RefRangeEnd = 116935, XrefRangeStart = 116925, XrefRangeEnd = 116934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnRedrawBellRevealed(UnityAction<RedrawBellSystem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnRedrawBellRevealed_Public_Static_rem_Void_UnityAction_1_RedrawBellSystem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004538 RID: 17720 RVA: 0x001293DC File Offset: 0x001275DC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 116937, RefRangeEnd = 116940, XrefRangeStart = 116935, XrefRangeEnd = 116937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeRedrawBellRevealed(RedrawBellSystem redrawBellSystem)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(redrawBellSystem);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeRedrawBellRevealed_Public_Static_Void_RedrawBellSystem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004539 RID: 17721 RVA: 0x00129414 File Offset: 0x00127614
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116949, RefRangeEnd = 116950, XrefRangeStart = 116940, XrefRangeEnd = 116949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCardInjured(UnityAction<CardData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCardInjured_Public_Static_add_Void_UnityAction_1_CardData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600453A RID: 17722 RVA: 0x0012944C File Offset: 0x0012764C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116959, RefRangeEnd = 116960, XrefRangeStart = 116950, XrefRangeEnd = 116959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCardInjured(UnityAction<CardData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCardInjured_Public_Static_rem_Void_UnityAction_1_CardData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600453B RID: 17723 RVA: 0x00129484 File Offset: 0x00127684
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116962, RefRangeEnd = 116963, XrefRangeStart = 116960, XrefRangeEnd = 116962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCardInjured(CardData cardData)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCardInjured_Public_Static_Void_CardData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600453C RID: 17724 RVA: 0x001294BC File Offset: 0x001276BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116963, XrefRangeEnd = 116970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleStateBuild(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleStateBuild_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600453D RID: 17725 RVA: 0x001294F4 File Offset: 0x001276F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116970, XrefRangeEnd = 116977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleStateBuild(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleStateBuild_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600453E RID: 17726 RVA: 0x0012952C File Offset: 0x0012772C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 116979, RefRangeEnd = 116980, XrefRangeStart = 116977, XrefRangeEnd = 116979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleStateBuild()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleStateBuild_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600453F RID: 17727 RVA: 0x00129554 File Offset: 0x00127754
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116980, XrefRangeEnd = 116989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleStateBuilt(UnityAction<BattleSaveData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleStateBuilt_Public_Static_add_Void_UnityAction_1_BattleSaveData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004540 RID: 17728 RVA: 0x0012958C File Offset: 0x0012778C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116989, XrefRangeEnd = 116998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleStateBuilt(UnityAction<BattleSaveData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleStateBuilt_Public_Static_rem_Void_UnityAction_1_BattleSaveData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004541 RID: 17729 RVA: 0x001295C4 File Offset: 0x001277C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117000, RefRangeEnd = 117001, XrefRangeStart = 116998, XrefRangeEnd = 117000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleStateBuilt(BattleSaveData battleState)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(battleState);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleStateBuilt_Public_Static_Void_BattleSaveData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004542 RID: 17730 RVA: 0x001295FC File Offset: 0x001277FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117001, XrefRangeEnd = 117010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCharacterActionPerformed(UnityAction<Character> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCharacterActionPerformed_Public_Static_add_Void_UnityAction_1_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004543 RID: 17731 RVA: 0x00129634 File Offset: 0x00127834
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117010, XrefRangeEnd = 117019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCharacterActionPerformed(UnityAction<Character> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCharacterActionPerformed_Public_Static_rem_Void_UnityAction_1_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004544 RID: 17732 RVA: 0x0012966C File Offset: 0x0012786C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117019, XrefRangeEnd = 117021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCharacterActionPerformed(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCharacterActionPerformed_Public_Static_Void_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004545 RID: 17733 RVA: 0x001296A4 File Offset: 0x001278A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117021, XrefRangeEnd = 117030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnWaveDeployerPreCountDown(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnWaveDeployerPreCountDown_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004546 RID: 17734 RVA: 0x001296DC File Offset: 0x001278DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117030, XrefRangeEnd = 117039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnWaveDeployerPreCountDown(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnWaveDeployerPreCountDown_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004547 RID: 17735 RVA: 0x00129714 File Offset: 0x00127914
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117041, RefRangeEnd = 117042, XrefRangeStart = 117039, XrefRangeEnd = 117041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeWaveDeployerPreCountDown(int counter)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref counter;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeWaveDeployerPreCountDown_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004548 RID: 17736 RVA: 0x00129748 File Offset: 0x00127948
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117051, RefRangeEnd = 117052, XrefRangeStart = 117042, XrefRangeEnd = 117051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnWaveDeployerPostCountDown(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnWaveDeployerPostCountDown_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004549 RID: 17737 RVA: 0x00129780 File Offset: 0x00127980
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117061, RefRangeEnd = 117062, XrefRangeStart = 117052, XrefRangeEnd = 117061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnWaveDeployerPostCountDown(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnWaveDeployerPostCountDown_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x001297B8 File Offset: 0x001279B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117062, XrefRangeEnd = 117064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeWaveDeployerPostCountDown(int counter)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref counter;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeWaveDeployerPostCountDown_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600454B RID: 17739 RVA: 0x001297EC File Offset: 0x001279EC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117071, RefRangeEnd = 117072, XrefRangeStart = 117064, XrefRangeEnd = 117071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnWaveDeployerEarlyDeploy(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnWaveDeployerEarlyDeploy_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600454C RID: 17740 RVA: 0x00129824 File Offset: 0x00127A24
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117079, RefRangeEnd = 117080, XrefRangeStart = 117072, XrefRangeEnd = 117079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnWaveDeployerEarlyDeploy(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnWaveDeployerEarlyDeploy_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600454D RID: 17741 RVA: 0x0012985C File Offset: 0x00127A5C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117082, RefRangeEnd = 117083, XrefRangeStart = 117080, XrefRangeEnd = 117082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeWaveDeployerEarlyDeploy()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeWaveDeployerEarlyDeploy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600454E RID: 17742 RVA: 0x00129884 File Offset: 0x00127A84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117092, RefRangeEnd = 117093, XrefRangeStart = 117083, XrefRangeEnd = 117092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMapPathReveal(UnityAction<float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMapPathReveal_Public_Static_add_Void_UnityAction_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600454F RID: 17743 RVA: 0x001298BC File Offset: 0x00127ABC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117102, RefRangeEnd = 117103, XrefRangeStart = 117093, XrefRangeEnd = 117102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMapPathReveal(UnityAction<float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMapPathReveal_Public_Static_rem_Void_UnityAction_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004550 RID: 17744 RVA: 0x001298F4 File Offset: 0x00127AF4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117105, RefRangeEnd = 117106, XrefRangeStart = 117103, XrefRangeEnd = 117105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMapPathReveal(float totalTime)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref totalTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMapPathReveal_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004551 RID: 17745 RVA: 0x00129928 File Offset: 0x00127B28
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117115, RefRangeEnd = 117117, XrefRangeStart = 117106, XrefRangeEnd = 117115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMapNodeReveal(UnityAction<MapNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMapNodeReveal_Public_Static_add_Void_UnityAction_1_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004552 RID: 17746 RVA: 0x00129960 File Offset: 0x00127B60
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117126, RefRangeEnd = 117128, XrefRangeStart = 117117, XrefRangeEnd = 117126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMapNodeReveal(UnityAction<MapNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMapNodeReveal_Public_Static_rem_Void_UnityAction_1_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004553 RID: 17747 RVA: 0x00129998 File Offset: 0x00127B98
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117130, RefRangeEnd = 117131, XrefRangeStart = 117128, XrefRangeEnd = 117130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMapNodeReveal(MapNode node)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMapNodeReveal_Public_Static_Void_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004554 RID: 17748 RVA: 0x001299D0 File Offset: 0x00127BD0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117140, RefRangeEnd = 117141, XrefRangeStart = 117131, XrefRangeEnd = 117140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMapNodeSelect(UnityAction<MapNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMapNodeSelect_Public_Static_add_Void_UnityAction_1_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004555 RID: 17749 RVA: 0x00129A08 File Offset: 0x00127C08
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117150, RefRangeEnd = 117151, XrefRangeStart = 117141, XrefRangeEnd = 117150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMapNodeSelect(UnityAction<MapNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMapNodeSelect_Public_Static_rem_Void_UnityAction_1_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004556 RID: 17750 RVA: 0x00129A40 File Offset: 0x00127C40
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117153, RefRangeEnd = 117156, XrefRangeStart = 117151, XrefRangeEnd = 117153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMapNodeSelect(MapNode node)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMapNodeSelect_Public_Static_Void_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004557 RID: 17751 RVA: 0x00129A78 File Offset: 0x00127C78
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117165, RefRangeEnd = 117167, XrefRangeStart = 117156, XrefRangeEnd = 117165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMapNodeHover(UnityAction<MapNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMapNodeHover_Public_Static_add_Void_UnityAction_1_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004558 RID: 17752 RVA: 0x00129AB0 File Offset: 0x00127CB0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117176, RefRangeEnd = 117178, XrefRangeStart = 117167, XrefRangeEnd = 117176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMapNodeHover(UnityAction<MapNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMapNodeHover_Public_Static_rem_Void_UnityAction_1_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004559 RID: 17753 RVA: 0x00129AE8 File Offset: 0x00127CE8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117180, RefRangeEnd = 117182, XrefRangeStart = 117178, XrefRangeEnd = 117180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMapNodeHover(MapNode node)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMapNodeHover_Public_Static_Void_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600455A RID: 17754 RVA: 0x00129B20 File Offset: 0x00127D20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117191, RefRangeEnd = 117192, XrefRangeStart = 117182, XrefRangeEnd = 117191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMapNodeUnHover(UnityAction<MapNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMapNodeUnHover_Public_Static_add_Void_UnityAction_1_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600455B RID: 17755 RVA: 0x00129B58 File Offset: 0x00127D58
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117201, RefRangeEnd = 117202, XrefRangeStart = 117192, XrefRangeEnd = 117201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMapNodeUnHover(UnityAction<MapNode> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMapNodeUnHover_Public_Static_rem_Void_UnityAction_1_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600455C RID: 17756 RVA: 0x00129B90 File Offset: 0x00127D90
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117204, RefRangeEnd = 117206, XrefRangeStart = 117202, XrefRangeEnd = 117204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMapNodeUnHover(MapNode node)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMapNodeUnHover_Public_Static_Void_MapNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600455D RID: 17757 RVA: 0x00129BC8 File Offset: 0x00127DC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117215, RefRangeEnd = 117216, XrefRangeStart = 117206, XrefRangeEnd = 117215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnTownUnlock(UnityAction<UnlockData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnTownUnlock_Public_Static_add_Void_UnityAction_1_UnlockData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600455E RID: 17758 RVA: 0x00129C00 File Offset: 0x00127E00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117225, RefRangeEnd = 117226, XrefRangeStart = 117216, XrefRangeEnd = 117225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnTownUnlock(UnityAction<UnlockData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnTownUnlock_Public_Static_rem_Void_UnityAction_1_UnlockData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600455F RID: 17759 RVA: 0x00129C38 File Offset: 0x00127E38
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117228, RefRangeEnd = 117229, XrefRangeStart = 117226, XrefRangeEnd = 117228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTownUnlock(UnlockData unlockData)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(unlockData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeTownUnlock_Public_Static_Void_UnlockData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004560 RID: 17760 RVA: 0x00129C70 File Offset: 0x00127E70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117238, RefRangeEnd = 117239, XrefRangeStart = 117229, XrefRangeEnd = 117238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnShopItemHover(UnityAction<ShopItem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnShopItemHover_Public_Static_add_Void_UnityAction_1_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004561 RID: 17761 RVA: 0x00129CA8 File Offset: 0x00127EA8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117248, RefRangeEnd = 117249, XrefRangeStart = 117239, XrefRangeEnd = 117248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnShopItemHover(UnityAction<ShopItem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnShopItemHover_Public_Static_rem_Void_UnityAction_1_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004562 RID: 17762 RVA: 0x00129CE0 File Offset: 0x00127EE0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117251, RefRangeEnd = 117254, XrefRangeStart = 117249, XrefRangeEnd = 117251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeShopItemHover(ShopItem item)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeShopItemHover_Public_Static_Void_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004563 RID: 17763 RVA: 0x00129D18 File Offset: 0x00127F18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117254, XrefRangeEnd = 117263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnShopItemUnHover(UnityAction<ShopItem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnShopItemUnHover_Public_Static_add_Void_UnityAction_1_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004564 RID: 17764 RVA: 0x00129D50 File Offset: 0x00127F50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117263, XrefRangeEnd = 117272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnShopItemUnHover(UnityAction<ShopItem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnShopItemUnHover_Public_Static_rem_Void_UnityAction_1_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004565 RID: 17765 RVA: 0x00129D88 File Offset: 0x00127F88
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117274, RefRangeEnd = 117277, XrefRangeStart = 117272, XrefRangeEnd = 117274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeShopItemUnHover(ShopItem item)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeShopItemUnHover_Public_Static_Void_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004566 RID: 17766 RVA: 0x00129DC0 File Offset: 0x00127FC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117286, RefRangeEnd = 117287, XrefRangeStart = 117277, XrefRangeEnd = 117286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnShopItemPurchase(UnityAction<ShopItem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnShopItemPurchase_Public_Static_add_Void_UnityAction_1_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004567 RID: 17767 RVA: 0x00129DF8 File Offset: 0x00127FF8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117296, RefRangeEnd = 117297, XrefRangeStart = 117287, XrefRangeEnd = 117296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnShopItemPurchase(UnityAction<ShopItem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnShopItemPurchase_Public_Static_rem_Void_UnityAction_1_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004568 RID: 17768 RVA: 0x00129E30 File Offset: 0x00128030
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117299, RefRangeEnd = 117302, XrefRangeStart = 117297, XrefRangeEnd = 117299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeShopItemPurchase(ShopItem item)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeShopItemPurchase_Public_Static_Void_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004569 RID: 17769 RVA: 0x00129E68 File Offset: 0x00128068
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117311, RefRangeEnd = 117312, XrefRangeStart = 117302, XrefRangeEnd = 117311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnShopItemHaggled(UnityAction<ShopItem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnShopItemHaggled_Public_Static_add_Void_UnityAction_1_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600456A RID: 17770 RVA: 0x00129EA0 File Offset: 0x001280A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117321, RefRangeEnd = 117322, XrefRangeStart = 117312, XrefRangeEnd = 117321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnShopItemHaggled(UnityAction<ShopItem> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnShopItemHaggled_Public_Static_rem_Void_UnityAction_1_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600456B RID: 17771 RVA: 0x00129ED8 File Offset: 0x001280D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117322, XrefRangeEnd = 117324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeShopItemHaggled(ShopItem item)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeShopItemHaggled_Public_Static_Void_ShopItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600456C RID: 17772 RVA: 0x00129F10 File Offset: 0x00128110
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117333, RefRangeEnd = 117334, XrefRangeStart = 117324, XrefRangeEnd = 117333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPopupCreated(UnityAction<KeywordData, CardPopUpPanel> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnPopupCreated_Public_Static_add_Void_UnityAction_2_KeywordData_CardPopUpPanel_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600456D RID: 17773 RVA: 0x00129F48 File Offset: 0x00128148
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117343, RefRangeEnd = 117344, XrefRangeStart = 117334, XrefRangeEnd = 117343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPopupCreated(UnityAction<KeywordData, CardPopUpPanel> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnPopupCreated_Public_Static_rem_Void_UnityAction_2_KeywordData_CardPopUpPanel_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600456E RID: 17774 RVA: 0x00129F80 File Offset: 0x00128180
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117346, RefRangeEnd = 117347, XrefRangeStart = 117344, XrefRangeEnd = 117346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePopupPanelCreated(KeywordData keyword, CardPopUpPanel panel)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyword);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(panel);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePopupPanelCreated_Public_Static_Void_KeywordData_CardPopUpPanel_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600456F RID: 17775 RVA: 0x00129FC8 File Offset: 0x001281C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117356, RefRangeEnd = 117357, XrefRangeStart = 117347, XrefRangeEnd = 117356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnButtonHover(UnityAction<ButtonType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnButtonHover_Public_Static_add_Void_UnityAction_1_ButtonType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x0012A000 File Offset: 0x00128200
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117366, RefRangeEnd = 117367, XrefRangeStart = 117357, XrefRangeEnd = 117366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnButtonHover(UnityAction<ButtonType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnButtonHover_Public_Static_rem_Void_UnityAction_1_ButtonType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004571 RID: 17777 RVA: 0x0012A038 File Offset: 0x00128238
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117369, RefRangeEnd = 117372, XrefRangeStart = 117367, XrefRangeEnd = 117369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeButtonHover(ButtonType buttonType)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref buttonType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeButtonHover_Public_Static_Void_ButtonType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x0012A06C File Offset: 0x0012826C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117381, RefRangeEnd = 117382, XrefRangeStart = 117372, XrefRangeEnd = 117381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnButtonPress(UnityAction<ButtonType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnButtonPress_Public_Static_add_Void_UnityAction_1_ButtonType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004573 RID: 17779 RVA: 0x0012A0A4 File Offset: 0x001282A4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117391, RefRangeEnd = 117392, XrefRangeStart = 117382, XrefRangeEnd = 117391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnButtonPress(UnityAction<ButtonType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnButtonPress_Public_Static_rem_Void_UnityAction_1_ButtonType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004574 RID: 17780 RVA: 0x0012A0DC File Offset: 0x001282DC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117394, RefRangeEnd = 117397, XrefRangeStart = 117392, XrefRangeEnd = 117394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeButtonPress(ButtonType buttonType)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref buttonType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeButtonPress_Public_Static_Void_ButtonType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004575 RID: 17781 RVA: 0x0012A110 File Offset: 0x00128310
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117406, RefRangeEnd = 117407, XrefRangeStart = 117397, XrefRangeEnd = 117406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAudioVolumeChange(UnityAction<string, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnAudioVolumeChange_Public_Static_add_Void_UnityAction_2_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004576 RID: 17782 RVA: 0x0012A148 File Offset: 0x00128348
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117416, RefRangeEnd = 117417, XrefRangeStart = 117407, XrefRangeEnd = 117416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAudioVolumeChange(UnityAction<string, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnAudioVolumeChange_Public_Static_rem_Void_UnityAction_2_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004577 RID: 17783 RVA: 0x0012A180 File Offset: 0x00128380
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117417, XrefRangeEnd = 117419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeAudioVolumeChange(string busName, float value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(busName);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeAudioVolumeChange_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004578 RID: 17784 RVA: 0x0012A1C4 File Offset: 0x001283C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117428, RefRangeEnd = 117429, XrefRangeStart = 117419, XrefRangeEnd = 117428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnAudioPitchChange(UnityAction<string, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnAudioPitchChange_Public_Static_add_Void_UnityAction_2_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004579 RID: 17785 RVA: 0x0012A1FC File Offset: 0x001283FC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117438, RefRangeEnd = 117439, XrefRangeStart = 117429, XrefRangeEnd = 117438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnAudioPitchChange(UnityAction<string, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnAudioPitchChange_Public_Static_rem_Void_UnityAction_2_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600457A RID: 17786 RVA: 0x0012A234 File Offset: 0x00128434
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117439, XrefRangeEnd = 117441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeAudioPitchChange(string busName, float value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(busName);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeAudioPitchChange_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600457B RID: 17787 RVA: 0x0012A278 File Offset: 0x00128478
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117450, RefRangeEnd = 117451, XrefRangeStart = 117441, XrefRangeEnd = 117450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBombardShoot(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBombardShoot_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600457C RID: 17788 RVA: 0x0012A2B0 File Offset: 0x001284B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117460, RefRangeEnd = 117461, XrefRangeStart = 117451, XrefRangeEnd = 117460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBombardShoot(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBombardShoot_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600457D RID: 17789 RVA: 0x0012A2E8 File Offset: 0x001284E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117463, RefRangeEnd = 117464, XrefRangeStart = 117461, XrefRangeEnd = 117463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBombardShoot(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBombardShoot_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600457E RID: 17790 RVA: 0x0012A320 File Offset: 0x00128520
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117473, RefRangeEnd = 117474, XrefRangeStart = 117464, XrefRangeEnd = 117473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBombardRocketFall(UnityAction<BombardRocket> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBombardRocketFall_Public_Static_add_Void_UnityAction_1_BombardRocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600457F RID: 17791 RVA: 0x0012A358 File Offset: 0x00128558
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117483, RefRangeEnd = 117484, XrefRangeStart = 117474, XrefRangeEnd = 117483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBombardRocketFall(UnityAction<BombardRocket> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBombardRocketFall_Public_Static_rem_Void_UnityAction_1_BombardRocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004580 RID: 17792 RVA: 0x0012A390 File Offset: 0x00128590
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117486, RefRangeEnd = 117487, XrefRangeStart = 117484, XrefRangeEnd = 117486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBombardRocketFall(BombardRocket rocket)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rocket);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBombardRocketFall_Public_Static_Void_BombardRocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004581 RID: 17793 RVA: 0x0012A3C8 File Offset: 0x001285C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117496, RefRangeEnd = 117497, XrefRangeStart = 117487, XrefRangeEnd = 117496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBombardRocketExplode(UnityAction<BombardRocket> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBombardRocketExplode_Public_Static_add_Void_UnityAction_1_BombardRocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004582 RID: 17794 RVA: 0x0012A400 File Offset: 0x00128600
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117506, RefRangeEnd = 117507, XrefRangeStart = 117497, XrefRangeEnd = 117506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBombardRocketExplode(UnityAction<BombardRocket> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBombardRocketExplode_Public_Static_rem_Void_UnityAction_1_BombardRocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004583 RID: 17795 RVA: 0x0012A438 File Offset: 0x00128638
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117509, RefRangeEnd = 117510, XrefRangeStart = 117507, XrefRangeEnd = 117509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBombardRocketExplode(BombardRocket rocket)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rocket);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBombardRocketExplode_Public_Static_Void_BombardRocket_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004584 RID: 17796 RVA: 0x0012A470 File Offset: 0x00128670
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117519, RefRangeEnd = 117520, XrefRangeStart = 117510, XrefRangeEnd = 117519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnProgressStart(UnityAction<float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnProgressStart_Public_Static_add_Void_UnityAction_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004585 RID: 17797 RVA: 0x0012A4A8 File Offset: 0x001286A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117529, RefRangeEnd = 117530, XrefRangeStart = 117520, XrefRangeEnd = 117529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnProgressStart(UnityAction<float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnProgressStart_Public_Static_rem_Void_UnityAction_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004586 RID: 17798 RVA: 0x0012A4E0 File Offset: 0x001286E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117532, RefRangeEnd = 117533, XrefRangeStart = 117530, XrefRangeEnd = 117532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeProgressStart(float fill)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref fill;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeProgressStart_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004587 RID: 17799 RVA: 0x0012A514 File Offset: 0x00128714
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117542, RefRangeEnd = 117543, XrefRangeStart = 117533, XrefRangeEnd = 117542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnProgressUpdate(UnityAction<float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnProgressUpdate_Public_Static_add_Void_UnityAction_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004588 RID: 17800 RVA: 0x0012A54C File Offset: 0x0012874C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117552, RefRangeEnd = 117553, XrefRangeStart = 117543, XrefRangeEnd = 117552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnProgressUpdate(UnityAction<float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnProgressUpdate_Public_Static_rem_Void_UnityAction_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004589 RID: 17801 RVA: 0x0012A584 File Offset: 0x00128784
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117555, RefRangeEnd = 117558, XrefRangeStart = 117553, XrefRangeEnd = 117555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeProgressUpdate(float fill)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref fill;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeProgressUpdate_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600458A RID: 17802 RVA: 0x0012A5B8 File Offset: 0x001287B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117565, RefRangeEnd = 117566, XrefRangeStart = 117558, XrefRangeEnd = 117565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnProgressStop(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnProgressStop_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600458B RID: 17803 RVA: 0x0012A5F0 File Offset: 0x001287F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117573, RefRangeEnd = 117574, XrefRangeStart = 117566, XrefRangeEnd = 117573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnProgressStop(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnProgressStop_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600458C RID: 17804 RVA: 0x0012A628 File Offset: 0x00128828
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117576, RefRangeEnd = 117578, XrefRangeStart = 117574, XrefRangeEnd = 117576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeProgressStop()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeProgressStop_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600458D RID: 17805 RVA: 0x0012A650 File Offset: 0x00128850
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117585, RefRangeEnd = 117586, XrefRangeStart = 117578, XrefRangeEnd = 117585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnProgressDing(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnProgressDing_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600458E RID: 17806 RVA: 0x0012A688 File Offset: 0x00128888
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117593, RefRangeEnd = 117594, XrefRangeStart = 117586, XrefRangeEnd = 117593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnProgressDing(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnProgressDing_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600458F RID: 17807 RVA: 0x0012A6C0 File Offset: 0x001288C0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117596, RefRangeEnd = 117598, XrefRangeStart = 117594, XrefRangeEnd = 117596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeProgressDing()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeProgressDing_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004590 RID: 17808 RVA: 0x0012A6E8 File Offset: 0x001288E8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117605, RefRangeEnd = 117606, XrefRangeStart = 117598, XrefRangeEnd = 117605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnProgressBlip(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnProgressBlip_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004591 RID: 17809 RVA: 0x0012A720 File Offset: 0x00128920
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117613, RefRangeEnd = 117614, XrefRangeStart = 117606, XrefRangeEnd = 117613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnProgressBlip(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnProgressBlip_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004592 RID: 17810 RVA: 0x0012A758 File Offset: 0x00128958
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117616, RefRangeEnd = 117617, XrefRangeStart = 117614, XrefRangeEnd = 117616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeProgressBlip()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeProgressBlip_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004593 RID: 17811 RVA: 0x0012A780 File Offset: 0x00128980
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117617, XrefRangeEnd = 117624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSaveSystemEnabled(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSaveSystemEnabled_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004594 RID: 17812 RVA: 0x0012A7B8 File Offset: 0x001289B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117624, XrefRangeEnd = 117631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSaveSystemEnabled(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSaveSystemEnabled_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004595 RID: 17813 RVA: 0x0012A7F0 File Offset: 0x001289F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117633, RefRangeEnd = 117634, XrefRangeStart = 117631, XrefRangeEnd = 117633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSaveSystemEnabled()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSaveSystemEnabled_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004596 RID: 17814 RVA: 0x0012A818 File Offset: 0x00128A18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117634, XrefRangeEnd = 117641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSaveSystemDisabled(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSaveSystemDisabled_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004597 RID: 17815 RVA: 0x0012A850 File Offset: 0x00128A50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117641, XrefRangeEnd = 117648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSaveSystemDisabled(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSaveSystemDisabled_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004598 RID: 17816 RVA: 0x0012A888 File Offset: 0x00128A88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117650, RefRangeEnd = 117651, XrefRangeStart = 117648, XrefRangeEnd = 117650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSaveSystemDisabled()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSaveSystemDisabled_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004599 RID: 17817 RVA: 0x0012A8B0 File Offset: 0x00128AB0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117658, RefRangeEnd = 117660, XrefRangeStart = 117651, XrefRangeEnd = 117658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSaveSystemProfileChanged(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSaveSystemProfileChanged_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600459A RID: 17818 RVA: 0x0012A8E8 File Offset: 0x00128AE8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117667, RefRangeEnd = 117669, XrefRangeStart = 117660, XrefRangeEnd = 117667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSaveSystemProfileChanged(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSaveSystemProfileChanged_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600459B RID: 17819 RVA: 0x0012A920 File Offset: 0x00128B20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117671, RefRangeEnd = 117672, XrefRangeStart = 117669, XrefRangeEnd = 117671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSaveSystemProfileChanged()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSaveSystemProfileChanged_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600459C RID: 17820 RVA: 0x0012A948 File Offset: 0x00128B48
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 117679, RefRangeEnd = 117686, XrefRangeStart = 117672, XrefRangeEnd = 117679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignSaved(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignSaved_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600459D RID: 17821 RVA: 0x0012A980 File Offset: 0x00128B80
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 117693, RefRangeEnd = 117700, XrefRangeStart = 117686, XrefRangeEnd = 117693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignSaved(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignSaved_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600459E RID: 17822 RVA: 0x0012A9B8 File Offset: 0x00128BB8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117702, RefRangeEnd = 117704, XrefRangeStart = 117700, XrefRangeEnd = 117702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignSaved()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignSaved_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600459F RID: 17823 RVA: 0x0012A9E0 File Offset: 0x00128BE0
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 117711, RefRangeEnd = 117716, XrefRangeStart = 117704, XrefRangeEnd = 117711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignLoaded(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignLoaded_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A0 RID: 17824 RVA: 0x0012AA18 File Offset: 0x00128C18
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 117723, RefRangeEnd = 117728, XrefRangeStart = 117716, XrefRangeEnd = 117723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignLoaded(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignLoaded_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A1 RID: 17825 RVA: 0x0012AA50 File Offset: 0x00128C50
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117730, RefRangeEnd = 117732, XrefRangeStart = 117728, XrefRangeEnd = 117730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignLoaded()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignLoaded_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A2 RID: 17826 RVA: 0x0012AA78 File Offset: 0x00128C78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117732, XrefRangeEnd = 117739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignDeleted(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignDeleted_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A3 RID: 17827 RVA: 0x0012AAB0 File Offset: 0x00128CB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117739, XrefRangeEnd = 117746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignDeleted(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignDeleted_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A4 RID: 17828 RVA: 0x0012AAE8 File Offset: 0x00128CE8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117748, RefRangeEnd = 117751, XrefRangeStart = 117746, XrefRangeEnd = 117748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignDeleted()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignDeleted_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A5 RID: 17829 RVA: 0x0012AB10 File Offset: 0x00128D10
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117758, RefRangeEnd = 117760, XrefRangeStart = 117751, XrefRangeEnd = 117758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleSaved(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleSaved_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A6 RID: 17830 RVA: 0x0012AB48 File Offset: 0x00128D48
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117767, RefRangeEnd = 117769, XrefRangeStart = 117760, XrefRangeEnd = 117767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleSaved(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleSaved_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A7 RID: 17831 RVA: 0x0012AB80 File Offset: 0x00128D80
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117771, RefRangeEnd = 117772, XrefRangeStart = 117769, XrefRangeEnd = 117771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleSaved()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleSaved_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A8 RID: 17832 RVA: 0x0012ABA8 File Offset: 0x00128DA8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117779, RefRangeEnd = 117782, XrefRangeStart = 117772, XrefRangeEnd = 117779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnBattleLoaded(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnBattleLoaded_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045A9 RID: 17833 RVA: 0x0012ABE0 File Offset: 0x00128DE0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117789, RefRangeEnd = 117792, XrefRangeStart = 117782, XrefRangeEnd = 117789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnBattleLoaded(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnBattleLoaded_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045AA RID: 17834 RVA: 0x0012AC18 File Offset: 0x00128E18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117794, RefRangeEnd = 117795, XrefRangeStart = 117792, XrefRangeEnd = 117794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeBattleLoaded()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeBattleLoaded_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045AB RID: 17835 RVA: 0x0012AC40 File Offset: 0x00128E40
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117802, RefRangeEnd = 117804, XrefRangeStart = 117795, XrefRangeEnd = 117802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnGameStart(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnGameStart_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045AC RID: 17836 RVA: 0x0012AC78 File Offset: 0x00128E78
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117811, RefRangeEnd = 117813, XrefRangeStart = 117804, XrefRangeEnd = 117811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnGameStart(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnGameStart_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045AD RID: 17837 RVA: 0x0012ACB0 File Offset: 0x00128EB0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117815, RefRangeEnd = 117816, XrefRangeStart = 117813, XrefRangeEnd = 117815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeGameStart()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeGameStart_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045AE RID: 17838 RVA: 0x0012ACD8 File Offset: 0x00128ED8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117816, XrefRangeEnd = 117823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnGameEnd(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnGameEnd_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045AF RID: 17839 RVA: 0x0012AD10 File Offset: 0x00128F10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117823, XrefRangeEnd = 117830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnGameEnd(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnGameEnd_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B0 RID: 17840 RVA: 0x0012AD48 File Offset: 0x00128F48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117832, RefRangeEnd = 117833, XrefRangeStart = 117830, XrefRangeEnd = 117832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeGameEnd()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeGameEnd_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B1 RID: 17841 RVA: 0x0012AD70 File Offset: 0x00128F70
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117840, RefRangeEnd = 117842, XrefRangeStart = 117833, XrefRangeEnd = 117840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignStart(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignStart_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B2 RID: 17842 RVA: 0x0012ADA8 File Offset: 0x00128FA8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117849, RefRangeEnd = 117851, XrefRangeStart = 117842, XrefRangeEnd = 117849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignStart(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignStart_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B3 RID: 17843 RVA: 0x0012ADE0 File Offset: 0x00128FE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117853, RefRangeEnd = 117854, XrefRangeStart = 117851, XrefRangeEnd = 117853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignStart()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignStart_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B4 RID: 17844 RVA: 0x0012AE08 File Offset: 0x00129008
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117861, RefRangeEnd = 117864, XrefRangeStart = 117854, XrefRangeEnd = 117861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignFinal(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignFinal_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B5 RID: 17845 RVA: 0x0012AE40 File Offset: 0x00129040
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 117871, RefRangeEnd = 117874, XrefRangeStart = 117864, XrefRangeEnd = 117871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignFinal(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignFinal_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B6 RID: 17846 RVA: 0x0012AE78 File Offset: 0x00129078
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117876, RefRangeEnd = 117877, XrefRangeStart = 117874, XrefRangeEnd = 117876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignFinal()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignFinal_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B7 RID: 17847 RVA: 0x0012AEA0 File Offset: 0x001290A0
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 117886, RefRangeEnd = 117895, XrefRangeStart = 117877, XrefRangeEnd = 117886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignEnd(UnityAction<Campaign.Result, CampaignStats, PlayerData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignEnd_Public_Static_add_Void_UnityAction_3_Result_CampaignStats_PlayerData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B8 RID: 17848 RVA: 0x0012AED8 File Offset: 0x001290D8
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 117904, RefRangeEnd = 117913, XrefRangeStart = 117895, XrefRangeEnd = 117904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignEnd(UnityAction<Campaign.Result, CampaignStats, PlayerData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignEnd_Public_Static_rem_Void_UnityAction_3_Result_CampaignStats_PlayerData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045B9 RID: 17849 RVA: 0x0012AF10 File Offset: 0x00129110
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117915, RefRangeEnd = 117917, XrefRangeStart = 117913, XrefRangeEnd = 117915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref result;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stats);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignEnd_Public_Static_Void_Result_CampaignStats_PlayerData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045BA RID: 17850 RVA: 0x0012AF68 File Offset: 0x00129168
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117926, RefRangeEnd = 117927, XrefRangeStart = 117917, XrefRangeEnd = 117926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnOverallStatsSaved(UnityAction<CampaignStats> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnOverallStatsSaved_Public_Static_add_Void_UnityAction_1_CampaignStats_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045BB RID: 17851 RVA: 0x0012AFA0 File Offset: 0x001291A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117936, RefRangeEnd = 117937, XrefRangeStart = 117927, XrefRangeEnd = 117936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnOverallStatsSaved(UnityAction<CampaignStats> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnOverallStatsSaved_Public_Static_rem_Void_UnityAction_1_CampaignStats_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045BC RID: 17852 RVA: 0x0012AFD8 File Offset: 0x001291D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 117939, RefRangeEnd = 117941, XrefRangeStart = 117937, XrefRangeEnd = 117939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeOverallStatsSaved(CampaignStats stats)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stats);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeOverallStatsSaved_Public_Static_Void_CampaignStats_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045BD RID: 17853 RVA: 0x0012B010 File Offset: 0x00129210
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117941, XrefRangeEnd = 117950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignDataCreated(UnityAction<CampaignData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignDataCreated_Public_Static_add_Void_UnityAction_1_CampaignData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045BE RID: 17854 RVA: 0x0012B048 File Offset: 0x00129248
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117950, XrefRangeEnd = 117959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignDataCreated(UnityAction<CampaignData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignDataCreated_Public_Static_rem_Void_UnityAction_1_CampaignData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045BF RID: 17855 RVA: 0x0012B080 File Offset: 0x00129280
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117961, RefRangeEnd = 117962, XrefRangeStart = 117959, XrefRangeEnd = 117961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignDataCreated(CampaignData data)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignDataCreated_Public_Static_Void_CampaignData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045C0 RID: 17856 RVA: 0x0012B0B8 File Offset: 0x001292B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117962, XrefRangeEnd = 117969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignPreInit(Events.RoutineAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignPreInit_Public_Static_add_Void_RoutineAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045C1 RID: 17857 RVA: 0x0012B0F0 File Offset: 0x001292F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117969, XrefRangeEnd = 117976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignPreInit(Events.RoutineAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignPreInit_Public_Static_rem_Void_RoutineAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045C2 RID: 17858 RVA: 0x0012B128 File Offset: 0x00129328
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117976, XrefRangeEnd = 117980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator InvokeCampaignPreInit()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignPreInit_Public_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060045C3 RID: 17859 RVA: 0x0012B15C File Offset: 0x0012935C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117987, RefRangeEnd = 117988, XrefRangeStart = 117980, XrefRangeEnd = 117987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignInit(Events.RoutineAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignInit_Public_Static_add_Void_RoutineAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045C4 RID: 17860 RVA: 0x0012B194 File Offset: 0x00129394
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 117995, RefRangeEnd = 117996, XrefRangeStart = 117988, XrefRangeEnd = 117995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignInit(Events.RoutineAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignInit_Public_Static_rem_Void_RoutineAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045C5 RID: 17861 RVA: 0x0012B1CC File Offset: 0x001293CC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118000, RefRangeEnd = 118002, XrefRangeStart = 117996, XrefRangeEnd = 118000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator InvokeCampaignInit()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignInit_Public_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060045C6 RID: 17862 RVA: 0x0012B200 File Offset: 0x00129400
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118009, RefRangeEnd = 118011, XrefRangeStart = 118002, XrefRangeEnd = 118009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPreCampaignPopulate(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnPreCampaignPopulate_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045C7 RID: 17863 RVA: 0x0012B238 File Offset: 0x00129438
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118018, RefRangeEnd = 118020, XrefRangeStart = 118011, XrefRangeEnd = 118018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPreCampaignPopulate(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnPreCampaignPopulate_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045C8 RID: 17864 RVA: 0x0012B270 File Offset: 0x00129470
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118022, RefRangeEnd = 118023, XrefRangeStart = 118020, XrefRangeEnd = 118022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokePreCampaignPopulate()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokePreCampaignPopulate_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045C9 RID: 17865 RVA: 0x0012B298 File Offset: 0x00129498
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118023, XrefRangeEnd = 118032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignNodesCreated(Events.UnityActionRef1<List<CampaignGenerator.Node>, Vector2> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignNodesCreated_Public_Static_add_Void_UnityActionRef1_2_List_1_Node_Vector2_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045CA RID: 17866 RVA: 0x0012B2D0 File Offset: 0x001294D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118032, XrefRangeEnd = 118041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignNodesCreated(Events.UnityActionRef1<List<CampaignGenerator.Node>, Vector2> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignNodesCreated_Public_Static_rem_Void_UnityActionRef1_2_List_1_Node_Vector2_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045CB RID: 17867 RVA: 0x0012B308 File Offset: 0x00129508
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118043, RefRangeEnd = 118044, XrefRangeStart = 118041, XrefRangeEnd = 118043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignNodesCreated(ref List<CampaignGenerator.Node> nodes, Vector2 nodeSpacing)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
		ptr2 = &intPtr;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeSpacing;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignNodesCreated_Public_Static_Void_byref_List_1_Node_Vector2_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		nodes = ((intPtr4 == 0) ? null : new List<CampaignGenerator.Node>(intPtr4));
	}

	// Token: 0x060045CC RID: 17868 RVA: 0x0012B364 File Offset: 0x00129564
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118053, RefRangeEnd = 118055, XrefRangeStart = 118044, XrefRangeEnd = 118053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignLoadPreset(Events.UnityActionRef<Il2CppStringArray> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignLoadPreset_Public_Static_add_Void_UnityActionRef_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045CD RID: 17869 RVA: 0x0012B39C File Offset: 0x0012959C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118064, RefRangeEnd = 118066, XrefRangeStart = 118055, XrefRangeEnd = 118064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignLoadPreset(Events.UnityActionRef<Il2CppStringArray> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignLoadPreset_Public_Static_rem_Void_UnityActionRef_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045CE RID: 17870 RVA: 0x0012B3D4 File Offset: 0x001295D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118068, RefRangeEnd = 118069, XrefRangeStart = 118066, XrefRangeEnd = 118068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCampaignLoadPreset(ref Il2CppStringArray lines)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lines);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignLoadPreset_Public_Static_Void_byref_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		lines = ((intPtr4 == 0) ? null : new Il2CppStringArray(intPtr4));
	}

	// Token: 0x060045CF RID: 17871 RVA: 0x0012B420 File Offset: 0x00129620
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118076, RefRangeEnd = 118079, XrefRangeStart = 118069, XrefRangeEnd = 118076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCampaignGenerated(Events.AsyncAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCampaignGenerated_Public_Static_add_Void_AsyncAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D0 RID: 17872 RVA: 0x0012B458 File Offset: 0x00129658
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118086, RefRangeEnd = 118089, XrefRangeStart = 118079, XrefRangeEnd = 118086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCampaignGenerated(Events.AsyncAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCampaignGenerated_Public_Static_rem_Void_AsyncAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D1 RID: 17873 RVA: 0x0012B490 File Offset: 0x00129690
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118093, RefRangeEnd = 118094, XrefRangeStart = 118089, XrefRangeEnd = 118093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator InvokeCampaignGenerated()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCampaignGenerated_Public_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060045D2 RID: 17874 RVA: 0x0012B4C4 File Offset: 0x001296C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118103, RefRangeEnd = 118104, XrefRangeStart = 118094, XrefRangeEnd = 118103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnStatChanged(UnityAction<string, string, int, int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnStatChanged_Public_Static_add_Void_UnityAction_4_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D3 RID: 17875 RVA: 0x0012B4FC File Offset: 0x001296FC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118113, RefRangeEnd = 118114, XrefRangeStart = 118104, XrefRangeEnd = 118113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnStatChanged(UnityAction<string, string, int, int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnStatChanged_Public_Static_rem_Void_UnityAction_4_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D4 RID: 17876 RVA: 0x0012B534 File Offset: 0x00129734
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118116, RefRangeEnd = 118117, XrefRangeStart = 118114, XrefRangeEnd = 118116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeStatChanged(string stat, string key, int oldValue, int newValue)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(stat);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldValue;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeStatChanged_Public_Static_Void_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D5 RID: 17877 RVA: 0x0012B598 File Offset: 0x00129798
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118126, RefRangeEnd = 118128, XrefRangeStart = 118117, XrefRangeEnd = 118126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUpgradeGained(UnityAction<CardUpgradeData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnUpgradeGained_Public_Static_add_Void_UnityAction_1_CardUpgradeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D6 RID: 17878 RVA: 0x0012B5D0 File Offset: 0x001297D0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118137, RefRangeEnd = 118139, XrefRangeStart = 118128, XrefRangeEnd = 118137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUpgradeGained(UnityAction<CardUpgradeData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnUpgradeGained_Public_Static_rem_Void_UnityAction_1_CardUpgradeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D7 RID: 17879 RVA: 0x0012B608 File Offset: 0x00129808
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118141, RefRangeEnd = 118143, XrefRangeStart = 118139, XrefRangeEnd = 118141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUpgradeGained(CardUpgradeData upgradeData)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeUpgradeGained_Public_Static_Void_CardUpgradeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D8 RID: 17880 RVA: 0x0012B640 File Offset: 0x00129840
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 118152, RefRangeEnd = 118156, XrefRangeStart = 118143, XrefRangeEnd = 118152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUpgradeAssign(UnityAction<Entity, CardUpgradeData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnUpgradeAssign_Public_Static_add_Void_UnityAction_2_Entity_CardUpgradeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045D9 RID: 17881 RVA: 0x0012B678 File Offset: 0x00129878
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 118165, RefRangeEnd = 118169, XrefRangeStart = 118156, XrefRangeEnd = 118165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUpgradeAssign(UnityAction<Entity, CardUpgradeData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnUpgradeAssign_Public_Static_rem_Void_UnityAction_2_Entity_CardUpgradeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045DA RID: 17882 RVA: 0x0012B6B0 File Offset: 0x001298B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118169, XrefRangeEnd = 118171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUpgradeAssign(Entity entity, CardUpgradeData upgradeData)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(upgradeData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeUpgradeAssign_Public_Static_Void_Entity_CardUpgradeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045DB RID: 17883 RVA: 0x0012B6F8 File Offset: 0x001298F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118180, RefRangeEnd = 118181, XrefRangeStart = 118171, XrefRangeEnd = 118180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUpgradeHover(UnityAction<UpgradeDisplay> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnUpgradeHover_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045DC RID: 17884 RVA: 0x0012B730 File Offset: 0x00129930
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118190, RefRangeEnd = 118191, XrefRangeStart = 118181, XrefRangeEnd = 118190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUpgradeHover(UnityAction<UpgradeDisplay> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnUpgradeHover_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045DD RID: 17885 RVA: 0x0012B768 File Offset: 0x00129968
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118193, RefRangeEnd = 118194, XrefRangeStart = 118191, XrefRangeEnd = 118193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUpgradeHover(UpgradeDisplay upgradeDisplay)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeDisplay);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeUpgradeHover_Public_Static_Void_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045DE RID: 17886 RVA: 0x0012B7A0 File Offset: 0x001299A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118203, RefRangeEnd = 118204, XrefRangeStart = 118194, XrefRangeEnd = 118203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUpgradePickup(UnityAction<UpgradeDisplay> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnUpgradePickup_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045DF RID: 17887 RVA: 0x0012B7D8 File Offset: 0x001299D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118213, RefRangeEnd = 118214, XrefRangeStart = 118204, XrefRangeEnd = 118213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUpgradePickup(UnityAction<UpgradeDisplay> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnUpgradePickup_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E0 RID: 17888 RVA: 0x0012B810 File Offset: 0x00129A10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118214, XrefRangeEnd = 118216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUpgradePickup(UpgradeDisplay upgradeDisplay)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeDisplay);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeUpgradePickup_Public_Static_Void_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E1 RID: 17889 RVA: 0x0012B848 File Offset: 0x00129A48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118225, RefRangeEnd = 118226, XrefRangeStart = 118216, XrefRangeEnd = 118225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUpgradeDrop(UnityAction<UpgradeDisplay> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnUpgradeDrop_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E2 RID: 17890 RVA: 0x0012B880 File Offset: 0x00129A80
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118235, RefRangeEnd = 118236, XrefRangeStart = 118226, XrefRangeEnd = 118235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUpgradeDrop(UnityAction<UpgradeDisplay> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnUpgradeDrop_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E3 RID: 17891 RVA: 0x0012B8B8 File Offset: 0x00129AB8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118238, RefRangeEnd = 118239, XrefRangeStart = 118236, XrefRangeEnd = 118238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUpgradeDrop(UpgradeDisplay upgradeDisplay)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeDisplay);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeUpgradeDrop_Public_Static_Void_UpgradeDisplay_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E4 RID: 17892 RVA: 0x0012B8F0 File Offset: 0x00129AF0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118248, RefRangeEnd = 118250, XrefRangeStart = 118239, XrefRangeEnd = 118248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUpdateInputSystem(UnityAction<bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnUpdateInputSystem_Public_Static_add_Void_UnityAction_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E5 RID: 17893 RVA: 0x0012B928 File Offset: 0x00129B28
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118259, RefRangeEnd = 118261, XrefRangeStart = 118250, XrefRangeEnd = 118259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUpdateInputSystem(UnityAction<bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnUpdateInputSystem_Public_Static_rem_Void_UnityAction_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E6 RID: 17894 RVA: 0x0012B960 File Offset: 0x00129B60
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 118263, RefRangeEnd = 118270, XrefRangeStart = 118261, XrefRangeEnd = 118263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUpdateInputSystem(bool forceTouch)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref forceTouch;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeUpdateInputSystem_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E7 RID: 17895 RVA: 0x0012B994 File Offset: 0x00129B94
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118279, RefRangeEnd = 118280, XrefRangeStart = 118270, XrefRangeEnd = 118279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnScreenShake(UnityAction<float, Nullable<float>> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnScreenShake_Public_Static_add_Void_UnityAction_2_Single_Nullable_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E8 RID: 17896 RVA: 0x0012B9CC File Offset: 0x00129BCC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118289, RefRangeEnd = 118290, XrefRangeStart = 118280, XrefRangeEnd = 118289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnScreenShake(UnityAction<float, Nullable<float>> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnScreenShake_Public_Static_rem_Void_UnityAction_2_Single_Nullable_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045E9 RID: 17897 RVA: 0x0012BA04 File Offset: 0x00129C04
	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 118292, RefRangeEnd = 118308, XrefRangeStart = 118290, XrefRangeEnd = 118292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeScreenShake(float magnitude = 1f, [Optional] Nullable<float> direction)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref magnitude;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(direction));
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeScreenShake_Public_Static_Void_Single_Nullable_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045EA RID: 17898 RVA: 0x0012BA50 File Offset: 0x00129C50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118317, RefRangeEnd = 118318, XrefRangeStart = 118308, XrefRangeEnd = 118317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnScreenRumble(Events.UnityAction<float, float, float, float, float, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnScreenRumble_Public_Static_add_Void_UnityAction_6_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045EB RID: 17899 RVA: 0x0012BA88 File Offset: 0x00129C88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118327, RefRangeEnd = 118328, XrefRangeStart = 118318, XrefRangeEnd = 118327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnScreenRumble(Events.UnityAction<float, float, float, float, float, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnScreenRumble_Public_Static_rem_Void_UnityAction_6_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045EC RID: 17900 RVA: 0x0012BAC0 File Offset: 0x00129CC0
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 118330, RefRangeEnd = 118337, XrefRangeStart = 118328, XrefRangeEnd = 118330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeScreenRumble(float startStrength, float endStrength, float delay, float fadeInTime, float holdTime, float fadeOutTime)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref startStrength;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endStrength;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeInTime;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref holdTime;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOutTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeScreenRumble_Public_Static_Void_Single_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045ED RID: 17901 RVA: 0x0012BB38 File Offset: 0x00129D38
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118346, RefRangeEnd = 118347, XrefRangeStart = 118337, XrefRangeEnd = 118346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCameraAnimation(UnityAction<string> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCameraAnimation_Public_Static_add_Void_UnityAction_1_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045EE RID: 17902 RVA: 0x0012BB70 File Offset: 0x00129D70
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118356, RefRangeEnd = 118357, XrefRangeStart = 118347, XrefRangeEnd = 118356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCameraAnimation(UnityAction<string> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCameraAnimation_Public_Static_rem_Void_UnityAction_1_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045EF RID: 17903 RVA: 0x0012BBA8 File Offset: 0x00129DA8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 118359, RefRangeEnd = 118363, XrefRangeStart = 118357, XrefRangeEnd = 118359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCameraAnimation(string name)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCameraAnimation_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F0 RID: 17904 RVA: 0x0012BBE0 File Offset: 0x00129DE0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118372, RefRangeEnd = 118375, XrefRangeStart = 118363, XrefRangeEnd = 118372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnDropGold(UnityAction<int, string, Character, Vector3> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnDropGold_Public_Static_add_Void_UnityAction_4_Int32_String_Character_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F1 RID: 17905 RVA: 0x0012BC18 File Offset: 0x00129E18
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118384, RefRangeEnd = 118387, XrefRangeStart = 118375, XrefRangeEnd = 118384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnDropGold(UnityAction<int, string, Character, Vector3> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnDropGold_Public_Static_rem_Void_UnityAction_4_Int32_String_Character_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F2 RID: 17906 RVA: 0x0012BC50 File Offset: 0x00129E50
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 118389, RefRangeEnd = 118396, XrefRangeStart = 118387, XrefRangeEnd = 118389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeDropGold(int amount, string source, Character owner, Vector3 position)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeDropGold_Public_Static_Void_Int32_String_Character_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F3 RID: 17907 RVA: 0x0012BCB4 File Offset: 0x00129EB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118405, RefRangeEnd = 118406, XrefRangeStart = 118396, XrefRangeEnd = 118405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnGoldFlyToBag(UnityAction<int, Character, Vector3> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnGoldFlyToBag_Public_Static_add_Void_UnityAction_3_Int32_Character_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F4 RID: 17908 RVA: 0x0012BCEC File Offset: 0x00129EEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118415, RefRangeEnd = 118416, XrefRangeStart = 118406, XrefRangeEnd = 118415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnGoldFlyToBag(UnityAction<int, Character, Vector3> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnGoldFlyToBag_Public_Static_rem_Void_UnityAction_3_Int32_Character_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F5 RID: 17909 RVA: 0x0012BD24 File Offset: 0x00129F24
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118418, RefRangeEnd = 118420, XrefRangeStart = 118416, XrefRangeEnd = 118418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeGoldFlyToBag(int amount, Character owner, Vector3 position)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeGoldFlyToBag_Public_Static_Void_Int32_Character_Vector3_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F6 RID: 17910 RVA: 0x0012BD78 File Offset: 0x00129F78
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118429, RefRangeEnd = 118430, XrefRangeStart = 118420, XrefRangeEnd = 118429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCollectGold(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCollectGold_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F7 RID: 17911 RVA: 0x0012BDB0 File Offset: 0x00129FB0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118439, RefRangeEnd = 118440, XrefRangeStart = 118430, XrefRangeEnd = 118439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCollectGold(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCollectGold_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F8 RID: 17912 RVA: 0x0012BDE8 File Offset: 0x00129FE8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118442, RefRangeEnd = 118444, XrefRangeStart = 118440, XrefRangeEnd = 118442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCollectGold(int amount)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCollectGold_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045F9 RID: 17913 RVA: 0x0012BE1C File Offset: 0x0012A01C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118453, RefRangeEnd = 118454, XrefRangeStart = 118444, XrefRangeEnd = 118453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSpendGold(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSpendGold_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045FA RID: 17914 RVA: 0x0012BE54 File Offset: 0x0012A054
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118463, RefRangeEnd = 118464, XrefRangeStart = 118454, XrefRangeEnd = 118463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSpendGold(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSpendGold_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045FB RID: 17915 RVA: 0x0012BE8C File Offset: 0x0012A08C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118466, RefRangeEnd = 118467, XrefRangeStart = 118464, XrefRangeEnd = 118466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSpendGold(int amount)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSpendGold_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045FC RID: 17916 RVA: 0x0012BEC0 File Offset: 0x0012A0C0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118476, RefRangeEnd = 118478, XrefRangeStart = 118467, XrefRangeEnd = 118476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnTimeScaleChange(UnityAction<float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnTimeScaleChange_Public_Static_add_Void_UnityAction_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045FD RID: 17917 RVA: 0x0012BEF8 File Offset: 0x0012A0F8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118487, RefRangeEnd = 118489, XrefRangeStart = 118478, XrefRangeEnd = 118487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnTimeScaleChange(UnityAction<float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnTimeScaleChange_Public_Static_rem_Void_UnityAction_1_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045FE RID: 17918 RVA: 0x0012BF30 File Offset: 0x0012A130
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118491, RefRangeEnd = 118492, XrefRangeStart = 118489, XrefRangeEnd = 118491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTimeScaleChange(float value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeTimeScaleChange_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060045FF RID: 17919 RVA: 0x0012BF64 File Offset: 0x0012A164
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 118501, RefRangeEnd = 118507, XrefRangeStart = 118492, XrefRangeEnd = 118501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnInspect(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnInspect_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004600 RID: 17920 RVA: 0x0012BF9C File Offset: 0x0012A19C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 118516, RefRangeEnd = 118522, XrefRangeStart = 118507, XrefRangeEnd = 118516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnInspect(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnInspect_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004601 RID: 17921 RVA: 0x0012BFD4 File Offset: 0x0012A1D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118524, RefRangeEnd = 118525, XrefRangeStart = 118522, XrefRangeEnd = 118524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeInspect(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeInspect_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004602 RID: 17922 RVA: 0x0012C00C File Offset: 0x0012A20C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 118534, RefRangeEnd = 118538, XrefRangeStart = 118525, XrefRangeEnd = 118534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnInspectEnd(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnInspectEnd_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004603 RID: 17923 RVA: 0x0012C044 File Offset: 0x0012A244
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 118547, RefRangeEnd = 118551, XrefRangeStart = 118538, XrefRangeEnd = 118547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnInspectEnd(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnInspectEnd_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004604 RID: 17924 RVA: 0x0012C07C File Offset: 0x0012A27C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118553, RefRangeEnd = 118554, XrefRangeStart = 118551, XrefRangeEnd = 118553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeInspectEnd(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeInspectEnd_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004605 RID: 17925 RVA: 0x0012C0B4 File Offset: 0x0012A2B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118554, XrefRangeEnd = 118563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnInspectNewCard(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnInspectNewCard_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004606 RID: 17926 RVA: 0x0012C0EC File Offset: 0x0012A2EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118563, XrefRangeEnd = 118572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnInspectNewCard(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnInspectNewCard_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004607 RID: 17927 RVA: 0x0012C124 File Offset: 0x0012A324
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118572, XrefRangeEnd = 118574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeInspectNewCard(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeInspectNewCard_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004608 RID: 17928 RVA: 0x0012C15C File Offset: 0x0012A35C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 118583, RefRangeEnd = 118588, XrefRangeStart = 118574, XrefRangeEnd = 118583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCardControllerEnabled(UnityAction<CardController> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCardControllerEnabled_Public_Static_add_Void_UnityAction_1_CardController_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004609 RID: 17929 RVA: 0x0012C194 File Offset: 0x0012A394
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 118597, RefRangeEnd = 118602, XrefRangeStart = 118588, XrefRangeEnd = 118597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCardControllerEnabled(UnityAction<CardController> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCardControllerEnabled_Public_Static_rem_Void_UnityAction_1_CardController_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600460A RID: 17930 RVA: 0x0012C1CC File Offset: 0x0012A3CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118604, RefRangeEnd = 118605, XrefRangeStart = 118602, XrefRangeEnd = 118604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCardControllerEnabled(CardController controller)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCardControllerEnabled_Public_Static_Void_CardController_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600460B RID: 17931 RVA: 0x0012C204 File Offset: 0x0012A404
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118614, RefRangeEnd = 118616, XrefRangeStart = 118605, XrefRangeEnd = 118614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCardControllerDisabled(UnityAction<CardController> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCardControllerDisabled_Public_Static_add_Void_UnityAction_1_CardController_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600460C RID: 17932 RVA: 0x0012C23C File Offset: 0x0012A43C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118625, RefRangeEnd = 118627, XrefRangeStart = 118616, XrefRangeEnd = 118625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCardControllerDisabled(UnityAction<CardController> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCardControllerDisabled_Public_Static_rem_Void_UnityAction_1_CardController_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600460D RID: 17933 RVA: 0x0012C274 File Offset: 0x0012A474
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118629, RefRangeEnd = 118630, XrefRangeStart = 118627, XrefRangeEnd = 118629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCardControllerDisabled(CardController controller)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCardControllerDisabled_Public_Static_Void_CardController_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600460E RID: 17934 RVA: 0x0012C2AC File Offset: 0x0012A4AC
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 118637, RefRangeEnd = 118642, XrefRangeStart = 118630, XrefRangeEnd = 118637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnDeckpackOpen(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnDeckpackOpen_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600460F RID: 17935 RVA: 0x0012C2E4 File Offset: 0x0012A4E4
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 118649, RefRangeEnd = 118654, XrefRangeStart = 118642, XrefRangeEnd = 118649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnDeckpackOpen(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnDeckpackOpen_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004610 RID: 17936 RVA: 0x0012C31C File Offset: 0x0012A51C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118656, RefRangeEnd = 118657, XrefRangeStart = 118654, XrefRangeEnd = 118656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeDeckpackOpen()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeDeckpackOpen_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004611 RID: 17937 RVA: 0x0012C344 File Offset: 0x0012A544
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 118664, RefRangeEnd = 118669, XrefRangeStart = 118657, XrefRangeEnd = 118664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnDeckpackClose(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnDeckpackClose_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004612 RID: 17938 RVA: 0x0012C37C File Offset: 0x0012A57C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 118676, RefRangeEnd = 118681, XrefRangeStart = 118669, XrefRangeEnd = 118676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnDeckpackClose(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnDeckpackClose_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004613 RID: 17939 RVA: 0x0012C3B4 File Offset: 0x0012A5B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118683, RefRangeEnd = 118684, XrefRangeStart = 118681, XrefRangeEnd = 118683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeDeckpackClose()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeDeckpackClose_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004614 RID: 17940 RVA: 0x0012C3DC File Offset: 0x0012A5DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118693, RefRangeEnd = 118694, XrefRangeStart = 118684, XrefRangeEnd = 118693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnTransitionStart(UnityAction<global::TransitionType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnTransitionStart_Public_Static_add_Void_UnityAction_1_TransitionType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004615 RID: 17941 RVA: 0x0012C414 File Offset: 0x0012A614
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118703, RefRangeEnd = 118704, XrefRangeStart = 118694, XrefRangeEnd = 118703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnTransitionStart(UnityAction<global::TransitionType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnTransitionStart_Public_Static_rem_Void_UnityAction_1_TransitionType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004616 RID: 17942 RVA: 0x0012C44C File Offset: 0x0012A64C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118706, RefRangeEnd = 118707, XrefRangeStart = 118704, XrefRangeEnd = 118706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTransitionStart(global::TransitionType transition)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transition);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeTransitionStart_Public_Static_Void_TransitionType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004617 RID: 17943 RVA: 0x0012C484 File Offset: 0x0012A684
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118716, RefRangeEnd = 118718, XrefRangeStart = 118707, XrefRangeEnd = 118716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnTransitionEnd(UnityAction<global::TransitionType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnTransitionEnd_Public_Static_add_Void_UnityAction_1_TransitionType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004618 RID: 17944 RVA: 0x0012C4BC File Offset: 0x0012A6BC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118727, RefRangeEnd = 118729, XrefRangeStart = 118718, XrefRangeEnd = 118727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnTransitionEnd(UnityAction<global::TransitionType> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnTransitionEnd_Public_Static_rem_Void_UnityAction_1_TransitionType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004619 RID: 17945 RVA: 0x0012C4F4 File Offset: 0x0012A6F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118731, RefRangeEnd = 118732, XrefRangeStart = 118729, XrefRangeEnd = 118731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTransitionEnd(global::TransitionType transition)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(transition);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeTransitionEnd_Public_Static_Void_TransitionType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600461A RID: 17946 RVA: 0x0012C52C File Offset: 0x0012A72C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118741, RefRangeEnd = 118742, XrefRangeStart = 118732, XrefRangeEnd = 118741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSetWeatherIntensity(UnityAction<float, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSetWeatherIntensity_Public_Static_add_Void_UnityAction_2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600461B RID: 17947 RVA: 0x0012C564 File Offset: 0x0012A764
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118751, RefRangeEnd = 118752, XrefRangeStart = 118742, XrefRangeEnd = 118751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSetWeatherIntensity(UnityAction<float, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSetWeatherIntensity_Public_Static_rem_Void_UnityAction_2_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600461C RID: 17948 RVA: 0x0012C59C File Offset: 0x0012A79C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118754, RefRangeEnd = 118756, XrefRangeStart = 118752, XrefRangeEnd = 118754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSetWeatherIntensity(float amount, float updateDuration)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref updateDuration;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSetWeatherIntensity_Public_Static_Void_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600461D RID: 17949 RVA: 0x0012C5DC File Offset: 0x0012A7DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118765, RefRangeEnd = 118766, XrefRangeStart = 118756, XrefRangeEnd = 118765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnGoldCounterStart(UnityAction<GoldDisplay, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnGoldCounterStart_Public_Static_add_Void_UnityAction_2_GoldDisplay_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600461E RID: 17950 RVA: 0x0012C614 File Offset: 0x0012A814
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118775, RefRangeEnd = 118776, XrefRangeStart = 118766, XrefRangeEnd = 118775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnGoldCounterStart(UnityAction<GoldDisplay, float> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnGoldCounterStart_Public_Static_rem_Void_UnityAction_2_GoldDisplay_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600461F RID: 17951 RVA: 0x0012C64C File Offset: 0x0012A84C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118776, XrefRangeEnd = 118778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeGoldCounterStart(GoldDisplay goldDisplay, float addAmount)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(goldDisplay);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addAmount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeGoldCounterStart_Public_Static_Void_GoldDisplay_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004620 RID: 17952 RVA: 0x0012C690 File Offset: 0x0012A890
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118787, RefRangeEnd = 118790, XrefRangeStart = 118778, XrefRangeEnd = 118787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEventStart(UnityAction<CampaignNode, EventRoutine> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEventStart_Public_Static_add_Void_UnityAction_2_CampaignNode_EventRoutine_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004621 RID: 17953 RVA: 0x0012C6C8 File Offset: 0x0012A8C8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118799, RefRangeEnd = 118802, XrefRangeStart = 118790, XrefRangeEnd = 118799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEventStart(UnityAction<CampaignNode, EventRoutine> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEventStart_Public_Static_rem_Void_UnityAction_2_CampaignNode_EventRoutine_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004622 RID: 17954 RVA: 0x0012C700 File Offset: 0x0012A900
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118804, RefRangeEnd = 118805, XrefRangeStart = 118802, XrefRangeEnd = 118804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEventStart(CampaignNode node, EventRoutine @event)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@event);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEventStart_Public_Static_Void_CampaignNode_EventRoutine_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004623 RID: 17955 RVA: 0x0012C748 File Offset: 0x0012A948
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118805, XrefRangeEnd = 118814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnEventPopulated(UnityAction<EventRoutine> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnEventPopulated_Public_Static_add_Void_UnityAction_1_EventRoutine_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004624 RID: 17956 RVA: 0x0012C780 File Offset: 0x0012A980
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118814, XrefRangeEnd = 118823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnEventPopulated(UnityAction<EventRoutine> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnEventPopulated_Public_Static_rem_Void_UnityAction_1_EventRoutine_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004625 RID: 17957 RVA: 0x0012C7B8 File Offset: 0x0012A9B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118825, RefRangeEnd = 118826, XrefRangeStart = 118823, XrefRangeEnd = 118825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeEventPopulated(EventRoutine @event)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(@event);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeEventPopulated_Public_Static_Void_EventRoutine_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004626 RID: 17958 RVA: 0x0012C7F0 File Offset: 0x0012A9F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118833, RefRangeEnd = 118834, XrefRangeStart = 118826, XrefRangeEnd = 118833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMuncherDrag(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMuncherDrag_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004627 RID: 17959 RVA: 0x0012C828 File Offset: 0x0012AA28
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118841, RefRangeEnd = 118842, XrefRangeStart = 118834, XrefRangeEnd = 118841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMuncherDrag(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMuncherDrag_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004628 RID: 17960 RVA: 0x0012C860 File Offset: 0x0012AA60
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118844, RefRangeEnd = 118845, XrefRangeStart = 118842, XrefRangeEnd = 118844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMuncherDrag()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMuncherDrag_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004629 RID: 17961 RVA: 0x0012C888 File Offset: 0x0012AA88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118852, RefRangeEnd = 118853, XrefRangeStart = 118845, XrefRangeEnd = 118852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMuncherDragCancel(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMuncherDragCancel_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600462A RID: 17962 RVA: 0x0012C8C0 File Offset: 0x0012AAC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118860, RefRangeEnd = 118861, XrefRangeStart = 118853, XrefRangeEnd = 118860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMuncherDragCancel(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMuncherDragCancel_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600462B RID: 17963 RVA: 0x0012C8F8 File Offset: 0x0012AAF8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118863, RefRangeEnd = 118864, XrefRangeStart = 118861, XrefRangeEnd = 118863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMuncherDragCancel()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMuncherDragCancel_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600462C RID: 17964 RVA: 0x0012C920 File Offset: 0x0012AB20
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118873, RefRangeEnd = 118875, XrefRangeStart = 118864, XrefRangeEnd = 118873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnMuncherFeed(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnMuncherFeed_Public_Static_add_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600462D RID: 17965 RVA: 0x0012C958 File Offset: 0x0012AB58
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 118884, RefRangeEnd = 118886, XrefRangeStart = 118875, XrefRangeEnd = 118884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnMuncherFeed(UnityAction<Entity> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnMuncherFeed_Public_Static_rem_Void_UnityAction_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600462E RID: 17966 RVA: 0x0012C990 File Offset: 0x0012AB90
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118888, RefRangeEnd = 118889, XrefRangeStart = 118886, XrefRangeEnd = 118888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeMuncherFeed(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeMuncherFeed_Public_Static_Void_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600462F RID: 17967 RVA: 0x0012C9C8 File Offset: 0x0012ABC8
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 118898, RefRangeEnd = 118909, XrefRangeStart = 118889, XrefRangeEnd = 118898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnSettingChanged(UnityAction<string, Il2CppSystem.Object> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnSettingChanged_Public_Static_add_Void_UnityAction_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004630 RID: 17968 RVA: 0x0012CA00 File Offset: 0x0012AC00
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 118918, RefRangeEnd = 118929, XrefRangeStart = 118909, XrefRangeEnd = 118918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnSettingChanged(UnityAction<string, Il2CppSystem.Object> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnSettingChanged_Public_Static_rem_Void_UnityAction_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004631 RID: 17969 RVA: 0x0012CA38 File Offset: 0x0012AC38
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118931, RefRangeEnd = 118932, XrefRangeStart = 118929, XrefRangeEnd = 118931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeSettingChanged(string key, Il2CppSystem.Object value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeSettingChanged_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004632 RID: 17970 RVA: 0x0012CA80 File Offset: 0x0012AC80
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118939, RefRangeEnd = 118940, XrefRangeStart = 118932, XrefRangeEnd = 118939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUINavigationReset(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnUINavigationReset_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004633 RID: 17971 RVA: 0x0012CAB8 File Offset: 0x0012ACB8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118947, RefRangeEnd = 118948, XrefRangeStart = 118940, XrefRangeEnd = 118947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUINavigationReset(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnUINavigationReset_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004634 RID: 17972 RVA: 0x0012CAF0 File Offset: 0x0012ACF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118950, RefRangeEnd = 118951, XrefRangeStart = 118948, XrefRangeEnd = 118950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUINavigationReset()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeUINavigationReset_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004635 RID: 17973 RVA: 0x0012CB18 File Offset: 0x0012AD18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118958, RefRangeEnd = 118959, XrefRangeStart = 118951, XrefRangeEnd = 118958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnUINavigation(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnUINavigation_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004636 RID: 17974 RVA: 0x0012CB50 File Offset: 0x0012AD50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118966, RefRangeEnd = 118967, XrefRangeStart = 118959, XrefRangeEnd = 118966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnUINavigation(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnUINavigation_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004637 RID: 17975 RVA: 0x0012CB88 File Offset: 0x0012AD88
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 118969, RefRangeEnd = 118970, XrefRangeStart = 118967, XrefRangeEnd = 118969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeUINavigation()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeUINavigation_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004638 RID: 17976 RVA: 0x0012CBB0 File Offset: 0x0012ADB0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118977, RefRangeEnd = 118980, XrefRangeStart = 118970, XrefRangeEnd = 118977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnButtonStyleChanged(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnButtonStyleChanged_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004639 RID: 17977 RVA: 0x0012CBE8 File Offset: 0x0012ADE8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118987, RefRangeEnd = 118990, XrefRangeStart = 118980, XrefRangeEnd = 118987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnButtonStyleChanged(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnButtonStyleChanged_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600463A RID: 17978 RVA: 0x0012CC20 File Offset: 0x0012AE20
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 118992, RefRangeEnd = 118995, XrefRangeStart = 118990, XrefRangeEnd = 118992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeButtonStyleChanged()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeButtonStyleChanged_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600463B RID: 17979 RVA: 0x0012CC48 File Offset: 0x0012AE48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119002, RefRangeEnd = 119003, XrefRangeStart = 118995, XrefRangeEnd = 119002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnControllerSwitched(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnControllerSwitched_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600463C RID: 17980 RVA: 0x0012CC80 File Offset: 0x0012AE80
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119010, RefRangeEnd = 119011, XrefRangeStart = 119003, XrefRangeEnd = 119010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnControllerSwitched(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnControllerSwitched_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600463D RID: 17981 RVA: 0x0012CCB8 File Offset: 0x0012AEB8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119013, RefRangeEnd = 119015, XrefRangeStart = 119011, XrefRangeEnd = 119013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeControllerSwitched()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeControllerSwitched_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600463E RID: 17982 RVA: 0x0012CCE0 File Offset: 0x0012AEE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119015, XrefRangeEnd = 119024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCheckRename(Events.UnityActionRef<Entity, string, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCheckRename_Public_Static_add_Void_UnityActionRef_3_Entity_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600463F RID: 17983 RVA: 0x0012CD18 File Offset: 0x0012AF18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119024, XrefRangeEnd = 119033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCheckRename(Events.UnityActionRef<Entity, string, bool> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCheckRename_Public_Static_rem_Void_UnityActionRef_3_Entity_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004640 RID: 17984 RVA: 0x0012CD50 File Offset: 0x0012AF50
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119035, RefRangeEnd = 119037, XrefRangeStart = 119033, XrefRangeEnd = 119035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckRename(ref Entity entity, ref string newName)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr2 = &intPtr;
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2 = IL2CPP.ManagedStringToIl2Cpp(newName);
		ptr3 = &intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_CheckRename_Public_Static_Boolean_byref_Entity_byref_String_0, 0, (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		IntPtr intPtr5 = intPtr;
		entity = ((intPtr5 == 0) ? null : new Entity(intPtr5));
		newName = IL2CPP.Il2CppStringToManaged(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr3);
	}

	// Token: 0x06004641 RID: 17985 RVA: 0x0012CDCC File Offset: 0x0012AFCC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119046, RefRangeEnd = 119048, XrefRangeStart = 119037, XrefRangeEnd = 119046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnRename(UnityAction<Entity, string> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnRename_Public_Static_add_Void_UnityAction_2_Entity_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004642 RID: 17986 RVA: 0x0012CE04 File Offset: 0x0012B004
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119057, RefRangeEnd = 119059, XrefRangeStart = 119048, XrefRangeEnd = 119057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnRename(UnityAction<Entity, string> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnRename_Public_Static_rem_Void_UnityAction_2_Entity_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004643 RID: 17987 RVA: 0x0012CE3C File Offset: 0x0012B03C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119061, RefRangeEnd = 119063, XrefRangeStart = 119059, XrefRangeEnd = 119061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeRename(Entity entity, string newName)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeRename_Public_Static_Void_Entity_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004644 RID: 17988 RVA: 0x0012CE84 File Offset: 0x0012B084
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119072, RefRangeEnd = 119073, XrefRangeStart = 119063, XrefRangeEnd = 119072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnPullRewards(Events.UnityActionRef<Il2CppSystem.Object, string, int, List<DataFile>> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnPullRewards_Public_Static_add_Void_UnityActionRef_4_Object_String_Int32_List_1_DataFile_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004645 RID: 17989 RVA: 0x0012CEBC File Offset: 0x0012B0BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119082, RefRangeEnd = 119083, XrefRangeStart = 119073, XrefRangeEnd = 119082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnPullRewards(Events.UnityActionRef<Il2CppSystem.Object, string, int, List<DataFile>> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnPullRewards_Public_Static_rem_Void_UnityActionRef_4_Object_String_Int32_List_1_DataFile_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004646 RID: 17990 RVA: 0x0012CEF4 File Offset: 0x0012B0F4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 119091, RefRangeEnd = 119095, XrefRangeStart = 119083, XrefRangeEnd = 119091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<DataFile> PullRewards(Il2CppSystem.Object pulledBy, string poolName, ref int count)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(pulledBy);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(poolName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_PullRewards_Public_Static_List_1_DataFile_Object_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataFile>>(intPtr3) : null;
	}

	// Token: 0x06004647 RID: 17991 RVA: 0x0012CF58 File Offset: 0x0012B158
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 119104, RefRangeEnd = 119115, XrefRangeStart = 119095, XrefRangeEnd = 119104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnCardDataCreated(UnityAction<CardData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnCardDataCreated_Public_Static_add_Void_UnityAction_1_CardData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004648 RID: 17992 RVA: 0x0012CF90 File Offset: 0x0012B190
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 119124, RefRangeEnd = 119135, XrefRangeStart = 119115, XrefRangeEnd = 119124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnCardDataCreated(UnityAction<CardData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnCardDataCreated_Public_Static_rem_Void_UnityAction_1_CardData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004649 RID: 17993 RVA: 0x0012CFC8 File Offset: 0x0012B1C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119137, RefRangeEnd = 119138, XrefRangeStart = 119135, XrefRangeEnd = 119137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeCardDataCreated(CardData cardData)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeCardDataCreated_Public_Static_Void_CardData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600464A RID: 17994 RVA: 0x0012D000 File Offset: 0x0012B200
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119138, XrefRangeEnd = 119147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnTutorialProgress(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnTutorialProgress_Public_Static_add_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600464B RID: 17995 RVA: 0x0012D038 File Offset: 0x0012B238
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119147, XrefRangeEnd = 119156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnTutorialProgress(UnityAction<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnTutorialProgress_Public_Static_rem_Void_UnityAction_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600464C RID: 17996 RVA: 0x0012D070 File Offset: 0x0012B270
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119158, RefRangeEnd = 119159, XrefRangeStart = 119156, XrefRangeEnd = 119158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTutorialProgress(int value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeTutorialProgress_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600464D RID: 17997 RVA: 0x0012D0A4 File Offset: 0x0012B2A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119159, XrefRangeEnd = 119166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnTutorialSkip(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnTutorialSkip_Public_Static_add_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600464E RID: 17998 RVA: 0x0012D0DC File Offset: 0x0012B2DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119166, XrefRangeEnd = 119173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnTutorialSkip(UnityAction value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnTutorialSkip_Public_Static_rem_Void_UnityAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600464F RID: 17999 RVA: 0x0012D114 File Offset: 0x0012B314
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119175, RefRangeEnd = 119176, XrefRangeStart = 119173, XrefRangeEnd = 119175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeTutorialSkip()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeTutorialSkip_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004650 RID: 18000 RVA: 0x0012D13C File Offset: 0x0012B33C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119185, RefRangeEnd = 119186, XrefRangeStart = 119176, XrefRangeEnd = 119185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnChallengeCompletedSaved(UnityAction<ChallengeData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnChallengeCompletedSaved_Public_Static_add_Void_UnityAction_1_ChallengeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004651 RID: 18001 RVA: 0x0012D174 File Offset: 0x0012B374
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119195, RefRangeEnd = 119196, XrefRangeStart = 119186, XrefRangeEnd = 119195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnChallengeCompletedSaved(UnityAction<ChallengeData> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnChallengeCompletedSaved_Public_Static_rem_Void_UnityAction_1_ChallengeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004652 RID: 18002 RVA: 0x0012D1AC File Offset: 0x0012B3AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119198, RefRangeEnd = 119199, XrefRangeStart = 119196, XrefRangeEnd = 119198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InvokeChallengeCompletedSaved(ChallengeData challengeData)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(challengeData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_InvokeChallengeCompletedSaved_Public_Static_Void_ChallengeData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004653 RID: 18003 RVA: 0x0012D1E4 File Offset: 0x0012B3E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119208, RefRangeEnd = 119209, XrefRangeStart = 119199, XrefRangeEnd = 119208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnGetHandSize(Events.UnityActionRef<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_add_OnGetHandSize_Public_Static_add_Void_UnityActionRef_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004654 RID: 18004 RVA: 0x0012D21C File Offset: 0x0012B41C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 119218, RefRangeEnd = 119219, XrefRangeStart = 119209, XrefRangeEnd = 119218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnGetHandSize(Events.UnityActionRef<int> value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_remove_OnGetHandSize_Public_Static_rem_Void_UnityActionRef_1_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004655 RID: 18005 RVA: 0x0012D254 File Offset: 0x0012B454
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 119221, RefRangeEnd = 119223, XrefRangeStart = 119219, XrefRangeEnd = 119221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetHandSize(int baseHandSize)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref baseHandSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.NativeMethodInfoPtr_GetHandSize_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06004656 RID: 18006 RVA: 0x000269A5 File Offset: 0x00024BA5
	public Events(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17001490 RID: 5264
	// (get) Token: 0x06004657 RID: 18007 RVA: 0x0012D294 File Offset: 0x0012B494
	// (set) Token: 0x06004658 RID: 18008 RVA: 0x000269AE File Offset: 0x00024BAE
	public unsafe static UnityAction<Scene> OnSceneLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSceneLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Scene>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSceneLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001491 RID: 5265
	// (get) Token: 0x06004659 RID: 18009 RVA: 0x0012D2BC File Offset: 0x0012B4BC
	// (set) Token: 0x0600465A RID: 18010 RVA: 0x000269C0 File Offset: 0x00024BC0
	public unsafe static UnityAction<Scene> OnSceneChanged
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSceneChanged, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Scene>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSceneChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001492 RID: 5266
	// (get) Token: 0x0600465B RID: 18011 RVA: 0x0012D2E4 File Offset: 0x0012B4E4
	// (set) Token: 0x0600465C RID: 18012 RVA: 0x000269D2 File Offset: 0x00024BD2
	public unsafe static UnityAction<Scene> OnSceneUnload
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSceneUnload, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Scene>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSceneUnload, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001493 RID: 5267
	// (get) Token: 0x0600465D RID: 18013 RVA: 0x0012D30C File Offset: 0x0012B50C
	// (set) Token: 0x0600465E RID: 18014 RVA: 0x000269E4 File Offset: 0x00024BE4
	public unsafe static UnityAction OnBackToMainMenu
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBackToMainMenu, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBackToMainMenu, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001494 RID: 5268
	// (get) Token: 0x0600465F RID: 18015 RVA: 0x0012D334 File Offset: 0x0012B534
	// (set) Token: 0x06004660 RID: 18016 RVA: 0x000269F6 File Offset: 0x00024BF6
	public unsafe static UnityAction<Entity> OnEntityCreated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityCreated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001495 RID: 5269
	// (get) Token: 0x06004661 RID: 18017 RVA: 0x0012D35C File Offset: 0x0012B55C
	// (set) Token: 0x06004662 RID: 18018 RVA: 0x00026A08 File Offset: 0x00024C08
	public unsafe static UnityAction<Entity> OnEntityDataUpdated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityDataUpdated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityDataUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001496 RID: 5270
	// (get) Token: 0x06004663 RID: 18019 RVA: 0x0012D384 File Offset: 0x0012B584
	// (set) Token: 0x06004664 RID: 18020 RVA: 0x00026A1A File Offset: 0x00024C1A
	public unsafe static UnityAction<Entity> OnEntityDestroyed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityDestroyed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityDestroyed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001497 RID: 5271
	// (get) Token: 0x06004665 RID: 18021 RVA: 0x0012D3AC File Offset: 0x0012B5AC
	// (set) Token: 0x06004666 RID: 18022 RVA: 0x00026A2C File Offset: 0x00024C2C
	public unsafe static UnityAction<Card> OnCardPooled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCardPooled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Card>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCardPooled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001498 RID: 5272
	// (get) Token: 0x06004667 RID: 18023 RVA: 0x0012D3D4 File Offset: 0x0012B5D4
	// (set) Token: 0x06004668 RID: 18024 RVA: 0x00026A3E File Offset: 0x00024C3E
	public unsafe static UnityAction<Entity> OnEntityEnabled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityEnabled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001499 RID: 5273
	// (get) Token: 0x06004669 RID: 18025 RVA: 0x0012D3FC File Offset: 0x0012B5FC
	// (set) Token: 0x0600466A RID: 18026 RVA: 0x00026A50 File Offset: 0x00024C50
	public unsafe static UnityAction<Entity> OnEntityDisabled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityDisabled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityDisabled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700149A RID: 5274
	// (get) Token: 0x0600466B RID: 18027 RVA: 0x0012D424 File Offset: 0x0012B624
	// (set) Token: 0x0600466C RID: 18028 RVA: 0x00026A62 File Offset: 0x00024C62
	public unsafe static UnityAction<Entity, DeathType> OnEntityKilled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityKilled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity, DeathType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityKilled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700149B RID: 5275
	// (get) Token: 0x0600466D RID: 18029 RVA: 0x0012D44C File Offset: 0x0012B64C
	// (set) Token: 0x0600466E RID: 18030 RVA: 0x00026A74 File Offset: 0x00024C74
	public unsafe static UnityAction<Entity> OnEntityFlee
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityFlee, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityFlee, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700149C RID: 5276
	// (get) Token: 0x0600466F RID: 18031 RVA: 0x0012D474 File Offset: 0x0012B674
	// (set) Token: 0x06004670 RID: 18032 RVA: 0x00026A86 File Offset: 0x00024C86
	public unsafe static UnityAction<Entity> OnEntityHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700149D RID: 5277
	// (get) Token: 0x06004671 RID: 18033 RVA: 0x0012D49C File Offset: 0x0012B69C
	// (set) Token: 0x06004672 RID: 18034 RVA: 0x00026A98 File Offset: 0x00024C98
	public unsafe static UnityAction<Entity> OnEntityUnHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityUnHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityUnHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700149E RID: 5278
	// (get) Token: 0x06004673 RID: 18035 RVA: 0x0012D4C4 File Offset: 0x0012B6C4
	// (set) Token: 0x06004674 RID: 18036 RVA: 0x00026AAA File Offset: 0x00024CAA
	public unsafe static UnityAction<Entity> OnEntitySelect
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntitySelect, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntitySelect, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700149F RID: 5279
	// (get) Token: 0x06004675 RID: 18037 RVA: 0x0012D4EC File Offset: 0x0012B6EC
	// (set) Token: 0x06004676 RID: 18038 RVA: 0x00026ABC File Offset: 0x00024CBC
	public unsafe static Events.UnityActionRef<Entity, bool> OnCheckEntityDrag
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCheckEntityDrag, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Entity, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCheckEntityDrag, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A0 RID: 5280
	// (get) Token: 0x06004677 RID: 18039 RVA: 0x0012D514 File Offset: 0x0012B714
	// (set) Token: 0x06004678 RID: 18040 RVA: 0x00026ACE File Offset: 0x00024CCE
	public unsafe static UnityAction<Entity> OnEntityDrag
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityDrag, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityDrag, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A1 RID: 5281
	// (get) Token: 0x06004679 RID: 18041 RVA: 0x0012D53C File Offset: 0x0012B73C
	// (set) Token: 0x0600467A RID: 18042 RVA: 0x00026AE0 File Offset: 0x00024CE0
	public unsafe static UnityAction<Entity> OnEntityRelease
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityRelease, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityRelease, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A2 RID: 5282
	// (get) Token: 0x0600467B RID: 18043 RVA: 0x0012D564 File Offset: 0x0012B764
	// (set) Token: 0x0600467C RID: 18044 RVA: 0x00026AF2 File Offset: 0x00024CF2
	public unsafe static UnityAction<Entity> OnEntityOffered
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityOffered, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityOffered, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A3 RID: 5283
	// (get) Token: 0x0600467D RID: 18045 RVA: 0x0012D58C File Offset: 0x0012B78C
	// (set) Token: 0x0600467E RID: 18046 RVA: 0x00026B04 File Offset: 0x00024D04
	public unsafe static UnityAction<Entity> OnEntityChosen
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityChosen, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityChosen, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A4 RID: 5284
	// (get) Token: 0x0600467F RID: 18047 RVA: 0x0012D5B4 File Offset: 0x0012B7B4
	// (set) Token: 0x06004680 RID: 18048 RVA: 0x00026B16 File Offset: 0x00024D16
	public unsafe static UnityAction<Entity> OnEntityShowUnlocked
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityShowUnlocked, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityShowUnlocked, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A5 RID: 5285
	// (get) Token: 0x06004681 RID: 18049 RVA: 0x0012D5DC File Offset: 0x0012B7DC
	// (set) Token: 0x06004682 RID: 18050 RVA: 0x00026B28 File Offset: 0x00024D28
	public unsafe static Events.UnityActionRef<Entity, bool> OnCheckEntityShove
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCheckEntityShove, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Entity, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCheckEntityShove, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A6 RID: 5286
	// (get) Token: 0x06004683 RID: 18051 RVA: 0x0012D604 File Offset: 0x0012B804
	// (set) Token: 0x06004684 RID: 18052 RVA: 0x00026B3A File Offset: 0x00024D3A
	public unsafe static UnityAction<Entity> OnPreProcessTrigger
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnPreProcessTrigger, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnPreProcessTrigger, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A7 RID: 5287
	// (get) Token: 0x06004685 RID: 18053 RVA: 0x0012D62C File Offset: 0x0012B82C
	// (set) Token: 0x06004686 RID: 18054 RVA: 0x00026B4C File Offset: 0x00024D4C
	public unsafe static Events.UnityActionRef<Trigger> OnEntityPreTrigger
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityPreTrigger, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Trigger>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityPreTrigger, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A8 RID: 5288
	// (get) Token: 0x06004687 RID: 18055 RVA: 0x0012D654 File Offset: 0x0012B854
	// (set) Token: 0x06004688 RID: 18056 RVA: 0x00026B5E File Offset: 0x00024D5E
	public unsafe static Events.UnityActionRef<Trigger> OnEntityTrigger
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityTrigger, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Trigger>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityTrigger, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014A9 RID: 5289
	// (get) Token: 0x06004689 RID: 18057 RVA: 0x0012D67C File Offset: 0x0012B87C
	// (set) Token: 0x0600468A RID: 18058 RVA: 0x00026B70 File Offset: 0x00024D70
	public unsafe static Events.UnityActionRef<Trigger> OnEntityTriggered
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityTriggered, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Trigger>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityTriggered, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014AA RID: 5290
	// (get) Token: 0x0600468B RID: 18059 RVA: 0x0012D6A4 File Offset: 0x0012B8A4
	// (set) Token: 0x0600468C RID: 18060 RVA: 0x00026B82 File Offset: 0x00024D82
	public unsafe static UnityAction<Entity> OnEntityMove
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityMove, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityMove, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014AB RID: 5291
	// (get) Token: 0x0600468D RID: 18061 RVA: 0x0012D6CC File Offset: 0x0012B8CC
	// (set) Token: 0x0600468E RID: 18062 RVA: 0x00026B94 File Offset: 0x00024D94
	public unsafe static UnityAction<Entity, Il2CppReferenceArray<CardContainer>, bool> OnEntityPlace
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityPlace, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity, Il2CppReferenceArray<CardContainer>, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityPlace, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014AC RID: 5292
	// (get) Token: 0x0600468F RID: 18063 RVA: 0x0012D6F4 File Offset: 0x0012B8F4
	// (set) Token: 0x06004690 RID: 18064 RVA: 0x00026BA6 File Offset: 0x00024DA6
	public unsafe static UnityAction<Entity> OnDiscard
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnDiscard, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnDiscard, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014AD RID: 5293
	// (get) Token: 0x06004691 RID: 18065 RVA: 0x0012D71C File Offset: 0x0012B91C
	// (set) Token: 0x06004692 RID: 18066 RVA: 0x00026BB8 File Offset: 0x00024DB8
	public unsafe static UnityAction<Hit> OnEntityHit
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityHit, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Hit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityHit, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014AE RID: 5294
	// (get) Token: 0x06004693 RID: 18067 RVA: 0x0012D744 File Offset: 0x0012B944
	// (set) Token: 0x06004694 RID: 18068 RVA: 0x00026BCA File Offset: 0x00024DCA
	public unsafe static UnityAction<Hit> OnEntityPostHit
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityPostHit, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Hit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityPostHit, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014AF RID: 5295
	// (get) Token: 0x06004695 RID: 18069 RVA: 0x0012D76C File Offset: 0x0012B96C
	// (set) Token: 0x06004696 RID: 18070 RVA: 0x00026BDC File Offset: 0x00024DDC
	public unsafe static UnityAction<Hit> OnEntityDodge
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityDodge, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Hit>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityDodge, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B0 RID: 5296
	// (get) Token: 0x06004697 RID: 18071 RVA: 0x0012D794 File Offset: 0x0012B994
	// (set) Token: 0x06004698 RID: 18072 RVA: 0x00026BEE File Offset: 0x00024DEE
	public unsafe static UnityAction<Entity> OnEntityFlipUp
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityFlipUp, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityFlipUp, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B1 RID: 5297
	// (get) Token: 0x06004699 RID: 18073 RVA: 0x0012D7BC File Offset: 0x0012B9BC
	// (set) Token: 0x0600469A RID: 18074 RVA: 0x00026C00 File Offset: 0x00024E00
	public unsafe static UnityAction<Entity> OnEntityFlipDown
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityFlipDown, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityFlipDown, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B2 RID: 5298
	// (get) Token: 0x0600469B RID: 18075 RVA: 0x0012D7E4 File Offset: 0x0012B9E4
	// (set) Token: 0x0600469C RID: 18076 RVA: 0x00026C12 File Offset: 0x00024E12
	public unsafe static UnityAction<StatusIcon> OnStatusIconCreated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnStatusIconCreated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<StatusIcon>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnStatusIconCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B3 RID: 5299
	// (get) Token: 0x0600469D RID: 18077 RVA: 0x0012D80C File Offset: 0x0012BA0C
	// (set) Token: 0x0600469E RID: 18078 RVA: 0x00026C24 File Offset: 0x00024E24
	public unsafe static UnityAction<StatusIcon, Stat, Stat> OnStatusIconChanged
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnStatusIconChanged, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<StatusIcon, Stat, Stat>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnStatusIconChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B4 RID: 5300
	// (get) Token: 0x0600469F RID: 18079 RVA: 0x0012D834 File Offset: 0x0012BA34
	// (set) Token: 0x060046A0 RID: 18080 RVA: 0x00026C36 File Offset: 0x00024E36
	public unsafe static UnityAction<Entity> OnEntityDisplayUpdated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityDisplayUpdated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityDisplayUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B5 RID: 5301
	// (get) Token: 0x060046A1 RID: 18081 RVA: 0x0012D85C File Offset: 0x0012BA5C
	// (set) Token: 0x060046A2 RID: 18082 RVA: 0x00026C48 File Offset: 0x00024E48
	public unsafe static UnityAction<Entity> OnEntityFocus
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityFocus, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityFocus, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B6 RID: 5302
	// (get) Token: 0x060046A3 RID: 18083 RVA: 0x0012D884 File Offset: 0x0012BA84
	// (set) Token: 0x060046A4 RID: 18084 RVA: 0x00026C5A File Offset: 0x00024E5A
	public unsafe static UnityAction<Entity, CardPocket> OnEntityEnterPocket
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityEnterPocket, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity, CardPocket>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityEnterPocket, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B7 RID: 5303
	// (get) Token: 0x060046A5 RID: 18085 RVA: 0x0012D8AC File Offset: 0x0012BAAC
	// (set) Token: 0x060046A6 RID: 18086 RVA: 0x00026C6C File Offset: 0x00024E6C
	public unsafe static UnityAction<Entity> OnEntityEnterBackpack
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityEnterBackpack, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityEnterBackpack, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B8 RID: 5304
	// (get) Token: 0x060046A7 RID: 18087 RVA: 0x0012D8D4 File Offset: 0x0012BAD4
	// (set) Token: 0x060046A8 RID: 18088 RVA: 0x00026C7E File Offset: 0x00024E7E
	public unsafe static UnityAction<Entity> OnEntityChangePhase
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityChangePhase, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityChangePhase, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014B9 RID: 5305
	// (get) Token: 0x060046A9 RID: 18089 RVA: 0x0012D8FC File Offset: 0x0012BAFC
	// (set) Token: 0x060046AA RID: 18090 RVA: 0x00026C90 File Offset: 0x00024E90
	public unsafe static UnityAction<Entity> OnNoomlinShow
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnNoomlinShow, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnNoomlinShow, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014BA RID: 5306
	// (get) Token: 0x060046AB RID: 18091 RVA: 0x0012D924 File Offset: 0x0012BB24
	// (set) Token: 0x060046AC RID: 18092 RVA: 0x00026CA2 File Offset: 0x00024EA2
	public unsafe static UnityAction<Entity> OnNoomlinUsed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnNoomlinUsed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnNoomlinUsed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014BB RID: 5307
	// (get) Token: 0x060046AD RID: 18093 RVA: 0x0012D94C File Offset: 0x0012BB4C
	// (set) Token: 0x060046AE RID: 18094 RVA: 0x00026CB4 File Offset: 0x00024EB4
	public unsafe static UnityAction<Entity> OnEntityFlipComplete
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityFlipComplete, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityFlipComplete, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014BC RID: 5308
	// (get) Token: 0x060046AF RID: 18095 RVA: 0x0012D974 File Offset: 0x0012BB74
	// (set) Token: 0x060046B0 RID: 18096 RVA: 0x00026CC6 File Offset: 0x00024EC6
	public unsafe static UnityAction<Entity, Entity> OnEntitySummoned
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntitySummoned, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity, Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntitySummoned, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014BD RID: 5309
	// (get) Token: 0x060046B1 RID: 18097 RVA: 0x0012D99C File Offset: 0x0012BB9C
	// (set) Token: 0x060046B2 RID: 18098 RVA: 0x00026CD8 File Offset: 0x00024ED8
	public unsafe static UnityAction<GameObject> OnEntityPing
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityPing, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<GameObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityPing, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014BE RID: 5310
	// (get) Token: 0x060046B3 RID: 18099 RVA: 0x0012D9C4 File Offset: 0x0012BBC4
	// (set) Token: 0x060046B4 RID: 18100 RVA: 0x00026CEA File Offset: 0x00024EEA
	public unsafe static Events.UnityActionRef<Entity, int> OnCheckRecycleAmount
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCheckRecycleAmount, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Entity, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCheckRecycleAmount, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014BF RID: 5311
	// (get) Token: 0x060046B5 RID: 18101 RVA: 0x0012D9EC File Offset: 0x0012BBEC
	// (set) Token: 0x060046B6 RID: 18102 RVA: 0x00026CFC File Offset: 0x00024EFC
	public unsafe static UnityAction<CardContainer> OnContainerHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnContainerHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardContainer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnContainerHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C0 RID: 5312
	// (get) Token: 0x060046B7 RID: 18103 RVA: 0x0012DA14 File Offset: 0x0012BC14
	// (set) Token: 0x060046B8 RID: 18104 RVA: 0x00026D0E File Offset: 0x00024F0E
	public unsafe static UnityAction<CardContainer> OnContainerUnHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnContainerUnHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardContainer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnContainerUnHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C1 RID: 5313
	// (get) Token: 0x060046B9 RID: 18105 RVA: 0x0012DA3C File Offset: 0x0012BC3C
	// (set) Token: 0x060046BA RID: 18106 RVA: 0x00026D20 File Offset: 0x00024F20
	public unsafe static UnityAction<CardSlot> OnSlotHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSlotHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardSlot>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSlotHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C2 RID: 5314
	// (get) Token: 0x060046BB RID: 18107 RVA: 0x0012DA64 File Offset: 0x0012BC64
	// (set) Token: 0x060046BC RID: 18108 RVA: 0x00026D32 File Offset: 0x00024F32
	public unsafe static UnityAction<CardSlot> OnSlotUnHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSlotUnHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardSlot>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSlotUnHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C3 RID: 5315
	// (get) Token: 0x060046BD RID: 18109 RVA: 0x0012DA8C File Offset: 0x0012BC8C
	// (set) Token: 0x060046BE RID: 18110 RVA: 0x00026D44 File Offset: 0x00024F44
	public unsafe static UnityAction<PlayAction> OnActionQueued
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnActionQueued, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<PlayAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnActionQueued, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C4 RID: 5316
	// (get) Token: 0x060046BF RID: 18111 RVA: 0x0012DAB4 File Offset: 0x0012BCB4
	// (set) Token: 0x060046C0 RID: 18112 RVA: 0x00026D56 File Offset: 0x00024F56
	public unsafe static UnityAction<PlayAction> OnActionPerform
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnActionPerform, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<PlayAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnActionPerform, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C5 RID: 5317
	// (get) Token: 0x060046C1 RID: 18113 RVA: 0x0012DADC File Offset: 0x0012BCDC
	// (set) Token: 0x060046C2 RID: 18114 RVA: 0x00026D68 File Offset: 0x00024F68
	public unsafe static UnityAction<PlayAction> OnActionFinished
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnActionFinished, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<PlayAction>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnActionFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C6 RID: 5318
	// (get) Token: 0x060046C3 RID: 18115 RVA: 0x0012DB04 File Offset: 0x0012BD04
	// (set) Token: 0x060046C4 RID: 18116 RVA: 0x00026D7A File Offset: 0x00024F7A
	public unsafe static Events.UnityActionRef<PlayAction, bool> OnCheckAction
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCheckAction, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<PlayAction, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCheckAction, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C7 RID: 5319
	// (get) Token: 0x060046C5 RID: 18117 RVA: 0x0012DB2C File Offset: 0x0012BD2C
	// (set) Token: 0x060046C6 RID: 18118 RVA: 0x00026D8C File Offset: 0x00024F8C
	public unsafe static UnityAction<CardContainer> OnAbilityTargetAdd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnAbilityTargetAdd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardContainer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnAbilityTargetAdd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C8 RID: 5320
	// (get) Token: 0x060046C7 RID: 18119 RVA: 0x0012DB54 File Offset: 0x0012BD54
	// (set) Token: 0x060046C8 RID: 18120 RVA: 0x00026D9E File Offset: 0x00024F9E
	public unsafe static UnityAction<CardContainer> OnAbilityTargetRemove
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnAbilityTargetRemove, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardContainer>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnAbilityTargetRemove, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014C9 RID: 5321
	// (get) Token: 0x060046C9 RID: 18121 RVA: 0x0012DB7C File Offset: 0x0012BD7C
	// (set) Token: 0x060046CA RID: 18122 RVA: 0x00026DB0 File Offset: 0x00024FB0
	public unsafe static UnityAction<int> OnCardDraw
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCardDraw, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCardDraw, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014CA RID: 5322
	// (get) Token: 0x060046CB RID: 18123 RVA: 0x0012DBA4 File Offset: 0x0012BDA4
	// (set) Token: 0x060046CC RID: 18124 RVA: 0x00026DC2 File Offset: 0x00024FC2
	public unsafe static UnityAction OnCardDrawEnd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCardDrawEnd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCardDrawEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014CB RID: 5323
	// (get) Token: 0x060046CD RID: 18125 RVA: 0x0012DBCC File Offset: 0x0012BDCC
	// (set) Token: 0x060046CE RID: 18126 RVA: 0x00026DD4 File Offset: 0x00024FD4
	public unsafe static UnityAction<CampaignNode> PreBattleSetUp
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_PreBattleSetUp, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CampaignNode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_PreBattleSetUp, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014CC RID: 5324
	// (get) Token: 0x060046CF RID: 18127 RVA: 0x0012DBF4 File Offset: 0x0012BDF4
	// (set) Token: 0x060046D0 RID: 18128 RVA: 0x00026DE6 File Offset: 0x00024FE6
	public unsafe static UnityAction<CampaignNode> PostBattleSetUp
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_PostBattleSetUp, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CampaignNode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_PostBattleSetUp, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014CD RID: 5325
	// (get) Token: 0x060046D1 RID: 18129 RVA: 0x0012DC1C File Offset: 0x0012BE1C
	// (set) Token: 0x060046D2 RID: 18130 RVA: 0x00026DF8 File Offset: 0x00024FF8
	public unsafe static UnityAction<Battle.Phase> OnBattlePhaseStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattlePhaseStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Battle.Phase>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattlePhaseStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014CE RID: 5326
	// (get) Token: 0x060046D3 RID: 18131 RVA: 0x0012DC44 File Offset: 0x0012BE44
	// (set) Token: 0x060046D4 RID: 18132 RVA: 0x00026E0A File Offset: 0x0002500A
	public unsafe static UnityAction OnBattleStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014CF RID: 5327
	// (get) Token: 0x060046D5 RID: 18133 RVA: 0x0012DC6C File Offset: 0x0012BE6C
	// (set) Token: 0x060046D6 RID: 18134 RVA: 0x00026E1C File Offset: 0x0002501C
	public unsafe static Events.AsyncAction PreBattleEnd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_PreBattleEnd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.AsyncAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_PreBattleEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D0 RID: 5328
	// (get) Token: 0x060046D7 RID: 18135 RVA: 0x0012DC94 File Offset: 0x0012BE94
	// (set) Token: 0x060046D8 RID: 18136 RVA: 0x00026E2E File Offset: 0x0002502E
	public unsafe static UnityAction OnBattleEnd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleEnd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D1 RID: 5329
	// (get) Token: 0x060046D9 RID: 18137 RVA: 0x0012DCBC File Offset: 0x0012BEBC
	// (set) Token: 0x060046DA RID: 18138 RVA: 0x00026E40 File Offset: 0x00025040
	public unsafe static UnityAction OnBattleWinPreRewards
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleWinPreRewards, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleWinPreRewards, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D2 RID: 5330
	// (get) Token: 0x060046DB RID: 18139 RVA: 0x0012DCE4 File Offset: 0x0012BEE4
	// (set) Token: 0x060046DC RID: 18140 RVA: 0x00026E52 File Offset: 0x00025052
	public unsafe static UnityAction OnBattleWin
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleWin, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleWin, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D3 RID: 5331
	// (get) Token: 0x060046DD RID: 18141 RVA: 0x0012DD0C File Offset: 0x0012BF0C
	// (set) Token: 0x060046DE RID: 18142 RVA: 0x00026E64 File Offset: 0x00025064
	public unsafe static UnityAction<CampaignNode> PostBattle
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_PostBattle, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CampaignNode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_PostBattle, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D4 RID: 5332
	// (get) Token: 0x060046DF RID: 18143 RVA: 0x0012DD34 File Offset: 0x0012BF34
	// (set) Token: 0x060046E0 RID: 18144 RVA: 0x00026E76 File Offset: 0x00025076
	public unsafe static Events.UnityActionCheck<StatusEffectData, int> OnStatusEffectCountDown
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnStatusEffectCountDown, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionCheck<StatusEffectData, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnStatusEffectCountDown, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D5 RID: 5333
	// (get) Token: 0x060046E1 RID: 18145 RVA: 0x0012DD5C File Offset: 0x0012BF5C
	// (set) Token: 0x060046E2 RID: 18146 RVA: 0x00026E88 File Offset: 0x00025088
	public unsafe static UnityAction<StatusEffectApply> OnStatusEffectApplied
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnStatusEffectApplied, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<StatusEffectApply>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnStatusEffectApplied, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D6 RID: 5334
	// (get) Token: 0x060046E3 RID: 18147 RVA: 0x0012DD84 File Offset: 0x0012BF84
	// (set) Token: 0x060046E4 RID: 18148 RVA: 0x00026E9A File Offset: 0x0002509A
	public unsafe static UnityAction<Character> OnPreProcessUnits
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnPreProcessUnits, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Character>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnPreProcessUnits, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D7 RID: 5335
	// (get) Token: 0x060046E5 RID: 18149 RVA: 0x0012DDAC File Offset: 0x0012BFAC
	// (set) Token: 0x060046E6 RID: 18150 RVA: 0x00026EAC File Offset: 0x000250AC
	public unsafe static UnityAction<Character> OnPostProcessUnits
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnPostProcessUnits, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Character>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnPostProcessUnits, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D8 RID: 5336
	// (get) Token: 0x060046E7 RID: 18151 RVA: 0x0012DDD4 File Offset: 0x0012BFD4
	// (set) Token: 0x060046E8 RID: 18152 RVA: 0x00026EBE File Offset: 0x000250BE
	public unsafe static Events.UnityActionCheck<Entity, int> OnEntityCountDown
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEntityCountDown, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionCheck<Entity, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEntityCountDown, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014D9 RID: 5337
	// (get) Token: 0x060046E9 RID: 18153 RVA: 0x0012DDFC File Offset: 0x0012BFFC
	// (set) Token: 0x060046EA RID: 18154 RVA: 0x00026ED0 File Offset: 0x000250D0
	public unsafe static UnityAction<int> OnBattlePreTurnStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattlePreTurnStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattlePreTurnStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014DA RID: 5338
	// (get) Token: 0x060046EB RID: 18155 RVA: 0x0012DE24 File Offset: 0x0012C024
	// (set) Token: 0x060046EC RID: 18156 RVA: 0x00026EE2 File Offset: 0x000250E2
	public unsafe static UnityAction<int> OnBattleTurnStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleTurnStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleTurnStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014DB RID: 5339
	// (get) Token: 0x060046ED RID: 18157 RVA: 0x0012DE4C File Offset: 0x0012C04C
	// (set) Token: 0x060046EE RID: 18158 RVA: 0x00026EF4 File Offset: 0x000250F4
	public unsafe static UnityAction<int> OnBattleTurnEnd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleTurnEnd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleTurnEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014DC RID: 5340
	// (get) Token: 0x060046EF RID: 18159 RVA: 0x0012DE74 File Offset: 0x0012C074
	// (set) Token: 0x060046F0 RID: 18160 RVA: 0x00026F06 File Offset: 0x00025106
	public unsafe static UnityAction<Entity> OnMinibossIntro
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMinibossIntro, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMinibossIntro, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014DD RID: 5341
	// (get) Token: 0x060046F1 RID: 18161 RVA: 0x0012DE9C File Offset: 0x0012C09C
	// (set) Token: 0x060046F2 RID: 18162 RVA: 0x00026F18 File Offset: 0x00025118
	public unsafe static UnityAction<Entity> OnMinibossIntroDone
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMinibossIntroDone, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMinibossIntroDone, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014DE RID: 5342
	// (get) Token: 0x060046F3 RID: 18163 RVA: 0x0012DEC4 File Offset: 0x0012C0C4
	// (set) Token: 0x060046F4 RID: 18164 RVA: 0x00026F2A File Offset: 0x0002512A
	public unsafe static UnityAction<int> OnKillCombo
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnKillCombo, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnKillCombo, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014DF RID: 5343
	// (get) Token: 0x060046F5 RID: 18165 RVA: 0x0012DEEC File Offset: 0x0012C0EC
	// (set) Token: 0x060046F6 RID: 18166 RVA: 0x00026F3C File Offset: 0x0002513C
	public unsafe static UnityAction<RedrawBellSystem> OnRedrawBellHit
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnRedrawBellHit, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<RedrawBellSystem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnRedrawBellHit, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E0 RID: 5344
	// (get) Token: 0x060046F7 RID: 18167 RVA: 0x0012DF14 File Offset: 0x0012C114
	// (set) Token: 0x060046F8 RID: 18168 RVA: 0x00026F4E File Offset: 0x0002514E
	public unsafe static UnityAction<RedrawBellSystem> OnRedrawBellRevealed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnRedrawBellRevealed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<RedrawBellSystem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnRedrawBellRevealed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E1 RID: 5345
	// (get) Token: 0x060046F9 RID: 18169 RVA: 0x0012DF3C File Offset: 0x0012C13C
	// (set) Token: 0x060046FA RID: 18170 RVA: 0x00026F60 File Offset: 0x00025160
	public unsafe static UnityAction<CardData> OnCardInjured
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCardInjured, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCardInjured, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E2 RID: 5346
	// (get) Token: 0x060046FB RID: 18171 RVA: 0x0012DF64 File Offset: 0x0012C164
	// (set) Token: 0x060046FC RID: 18172 RVA: 0x00026F72 File Offset: 0x00025172
	public unsafe static UnityAction OnBattleStateBuild
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleStateBuild, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleStateBuild, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E3 RID: 5347
	// (get) Token: 0x060046FD RID: 18173 RVA: 0x0012DF8C File Offset: 0x0012C18C
	// (set) Token: 0x060046FE RID: 18174 RVA: 0x00026F84 File Offset: 0x00025184
	public unsafe static UnityAction<BattleSaveData> OnBattleStateBuilt
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleStateBuilt, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<BattleSaveData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleStateBuilt, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E4 RID: 5348
	// (get) Token: 0x060046FF RID: 18175 RVA: 0x0012DFB4 File Offset: 0x0012C1B4
	// (set) Token: 0x06004700 RID: 18176 RVA: 0x00026F96 File Offset: 0x00025196
	public unsafe static UnityAction<Character> OnCharacterActionPerformed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCharacterActionPerformed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Character>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCharacterActionPerformed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E5 RID: 5349
	// (get) Token: 0x06004701 RID: 18177 RVA: 0x0012DFDC File Offset: 0x0012C1DC
	// (set) Token: 0x06004702 RID: 18178 RVA: 0x00026FA8 File Offset: 0x000251A8
	public unsafe static UnityAction<int> OnWaveDeployerPreCountDown
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnWaveDeployerPreCountDown, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnWaveDeployerPreCountDown, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E6 RID: 5350
	// (get) Token: 0x06004703 RID: 18179 RVA: 0x0012E004 File Offset: 0x0012C204
	// (set) Token: 0x06004704 RID: 18180 RVA: 0x00026FBA File Offset: 0x000251BA
	public unsafe static UnityAction<int> OnWaveDeployerPostCountDown
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnWaveDeployerPostCountDown, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnWaveDeployerPostCountDown, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E7 RID: 5351
	// (get) Token: 0x06004705 RID: 18181 RVA: 0x0012E02C File Offset: 0x0012C22C
	// (set) Token: 0x06004706 RID: 18182 RVA: 0x00026FCC File Offset: 0x000251CC
	public unsafe static UnityAction OnWaveDeployerEarlyDeploy
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnWaveDeployerEarlyDeploy, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnWaveDeployerEarlyDeploy, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E8 RID: 5352
	// (get) Token: 0x06004707 RID: 18183 RVA: 0x0012E054 File Offset: 0x0012C254
	// (set) Token: 0x06004708 RID: 18184 RVA: 0x00026FDE File Offset: 0x000251DE
	public unsafe static UnityAction<float> OnMapPathReveal
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMapPathReveal, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMapPathReveal, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014E9 RID: 5353
	// (get) Token: 0x06004709 RID: 18185 RVA: 0x0012E07C File Offset: 0x0012C27C
	// (set) Token: 0x0600470A RID: 18186 RVA: 0x00026FF0 File Offset: 0x000251F0
	public unsafe static UnityAction<MapNode> OnMapNodeReveal
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMapNodeReveal, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<MapNode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMapNodeReveal, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014EA RID: 5354
	// (get) Token: 0x0600470B RID: 18187 RVA: 0x0012E0A4 File Offset: 0x0012C2A4
	// (set) Token: 0x0600470C RID: 18188 RVA: 0x00027002 File Offset: 0x00025202
	public unsafe static UnityAction<MapNode> OnMapNodeSelect
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMapNodeSelect, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<MapNode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMapNodeSelect, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014EB RID: 5355
	// (get) Token: 0x0600470D RID: 18189 RVA: 0x0012E0CC File Offset: 0x0012C2CC
	// (set) Token: 0x0600470E RID: 18190 RVA: 0x00027014 File Offset: 0x00025214
	public unsafe static UnityAction<MapNode> OnMapNodeHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMapNodeHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<MapNode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMapNodeHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014EC RID: 5356
	// (get) Token: 0x0600470F RID: 18191 RVA: 0x0012E0F4 File Offset: 0x0012C2F4
	// (set) Token: 0x06004710 RID: 18192 RVA: 0x00027026 File Offset: 0x00025226
	public unsafe static UnityAction<MapNode> OnMapNodeUnHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMapNodeUnHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<MapNode>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMapNodeUnHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014ED RID: 5357
	// (get) Token: 0x06004711 RID: 18193 RVA: 0x0012E11C File Offset: 0x0012C31C
	// (set) Token: 0x06004712 RID: 18194 RVA: 0x00027038 File Offset: 0x00025238
	public unsafe static UnityAction<UnlockData> OnTownUnlock
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnTownUnlock, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<UnlockData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnTownUnlock, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014EE RID: 5358
	// (get) Token: 0x06004713 RID: 18195 RVA: 0x0012E144 File Offset: 0x0012C344
	// (set) Token: 0x06004714 RID: 18196 RVA: 0x0002704A File Offset: 0x0002524A
	public unsafe static UnityAction<ShopItem> OnShopItemHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnShopItemHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ShopItem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnShopItemHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014EF RID: 5359
	// (get) Token: 0x06004715 RID: 18197 RVA: 0x0012E16C File Offset: 0x0012C36C
	// (set) Token: 0x06004716 RID: 18198 RVA: 0x0002705C File Offset: 0x0002525C
	public unsafe static UnityAction<ShopItem> OnShopItemUnHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnShopItemUnHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ShopItem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnShopItemUnHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F0 RID: 5360
	// (get) Token: 0x06004717 RID: 18199 RVA: 0x0012E194 File Offset: 0x0012C394
	// (set) Token: 0x06004718 RID: 18200 RVA: 0x0002706E File Offset: 0x0002526E
	public unsafe static UnityAction<ShopItem> OnShopItemPurchase
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnShopItemPurchase, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ShopItem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnShopItemPurchase, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F1 RID: 5361
	// (get) Token: 0x06004719 RID: 18201 RVA: 0x0012E1BC File Offset: 0x0012C3BC
	// (set) Token: 0x0600471A RID: 18202 RVA: 0x00027080 File Offset: 0x00025280
	public unsafe static UnityAction<ShopItem> OnShopItemHaggled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnShopItemHaggled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ShopItem>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnShopItemHaggled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F2 RID: 5362
	// (get) Token: 0x0600471B RID: 18203 RVA: 0x0012E1E4 File Offset: 0x0012C3E4
	// (set) Token: 0x0600471C RID: 18204 RVA: 0x00027092 File Offset: 0x00025292
	public unsafe static UnityAction<KeywordData, CardPopUpPanel> OnPopupCreated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnPopupCreated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<KeywordData, CardPopUpPanel>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnPopupCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F3 RID: 5363
	// (get) Token: 0x0600471D RID: 18205 RVA: 0x0012E20C File Offset: 0x0012C40C
	// (set) Token: 0x0600471E RID: 18206 RVA: 0x000270A4 File Offset: 0x000252A4
	public unsafe static UnityAction<ButtonType> OnButtonHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnButtonHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ButtonType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnButtonHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F4 RID: 5364
	// (get) Token: 0x0600471F RID: 18207 RVA: 0x0012E234 File Offset: 0x0012C434
	// (set) Token: 0x06004720 RID: 18208 RVA: 0x000270B6 File Offset: 0x000252B6
	public unsafe static UnityAction<ButtonType> OnButtonPress
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnButtonPress, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ButtonType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnButtonPress, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F5 RID: 5365
	// (get) Token: 0x06004721 RID: 18209 RVA: 0x0012E25C File Offset: 0x0012C45C
	// (set) Token: 0x06004722 RID: 18210 RVA: 0x000270C8 File Offset: 0x000252C8
	public unsafe static UnityAction<string, float> OnAudioVolumeChange
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnAudioVolumeChange, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<string, float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnAudioVolumeChange, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F6 RID: 5366
	// (get) Token: 0x06004723 RID: 18211 RVA: 0x0012E284 File Offset: 0x0012C484
	// (set) Token: 0x06004724 RID: 18212 RVA: 0x000270DA File Offset: 0x000252DA
	public unsafe static UnityAction<string, float> OnAudioPitchChange
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnAudioPitchChange, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<string, float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnAudioPitchChange, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F7 RID: 5367
	// (get) Token: 0x06004725 RID: 18213 RVA: 0x0012E2AC File Offset: 0x0012C4AC
	// (set) Token: 0x06004726 RID: 18214 RVA: 0x000270EC File Offset: 0x000252EC
	public unsafe static UnityAction<Entity> OnBombardShoot
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBombardShoot, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBombardShoot, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F8 RID: 5368
	// (get) Token: 0x06004727 RID: 18215 RVA: 0x0012E2D4 File Offset: 0x0012C4D4
	// (set) Token: 0x06004728 RID: 18216 RVA: 0x000270FE File Offset: 0x000252FE
	public unsafe static UnityAction<BombardRocket> OnBombardRocketFall
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBombardRocketFall, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<BombardRocket>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBombardRocketFall, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014F9 RID: 5369
	// (get) Token: 0x06004729 RID: 18217 RVA: 0x0012E2FC File Offset: 0x0012C4FC
	// (set) Token: 0x0600472A RID: 18218 RVA: 0x00027110 File Offset: 0x00025310
	public unsafe static UnityAction<BombardRocket> OnBombardRocketExplode
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBombardRocketExplode, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<BombardRocket>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBombardRocketExplode, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014FA RID: 5370
	// (get) Token: 0x0600472B RID: 18219 RVA: 0x0012E324 File Offset: 0x0012C524
	// (set) Token: 0x0600472C RID: 18220 RVA: 0x00027122 File Offset: 0x00025322
	public unsafe static UnityAction<float> OnProgressStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnProgressStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnProgressStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014FB RID: 5371
	// (get) Token: 0x0600472D RID: 18221 RVA: 0x0012E34C File Offset: 0x0012C54C
	// (set) Token: 0x0600472E RID: 18222 RVA: 0x00027134 File Offset: 0x00025334
	public unsafe static UnityAction<float> OnProgressUpdate
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnProgressUpdate, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnProgressUpdate, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014FC RID: 5372
	// (get) Token: 0x0600472F RID: 18223 RVA: 0x0012E374 File Offset: 0x0012C574
	// (set) Token: 0x06004730 RID: 18224 RVA: 0x00027146 File Offset: 0x00025346
	public unsafe static UnityAction OnProgressStop
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnProgressStop, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnProgressStop, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014FD RID: 5373
	// (get) Token: 0x06004731 RID: 18225 RVA: 0x0012E39C File Offset: 0x0012C59C
	// (set) Token: 0x06004732 RID: 18226 RVA: 0x00027158 File Offset: 0x00025358
	public unsafe static UnityAction OnProgressDing
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnProgressDing, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnProgressDing, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014FE RID: 5374
	// (get) Token: 0x06004733 RID: 18227 RVA: 0x0012E3C4 File Offset: 0x0012C5C4
	// (set) Token: 0x06004734 RID: 18228 RVA: 0x0002716A File Offset: 0x0002536A
	public unsafe static UnityAction OnProgressBlip
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnProgressBlip, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnProgressBlip, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170014FF RID: 5375
	// (get) Token: 0x06004735 RID: 18229 RVA: 0x0012E3EC File Offset: 0x0012C5EC
	// (set) Token: 0x06004736 RID: 18230 RVA: 0x0002717C File Offset: 0x0002537C
	public unsafe static UnityAction OnSaveSystemEnabled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSaveSystemEnabled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSaveSystemEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001500 RID: 5376
	// (get) Token: 0x06004737 RID: 18231 RVA: 0x0012E414 File Offset: 0x0012C614
	// (set) Token: 0x06004738 RID: 18232 RVA: 0x0002718E File Offset: 0x0002538E
	public unsafe static UnityAction OnSaveSystemDisabled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSaveSystemDisabled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSaveSystemDisabled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001501 RID: 5377
	// (get) Token: 0x06004739 RID: 18233 RVA: 0x0012E43C File Offset: 0x0012C63C
	// (set) Token: 0x0600473A RID: 18234 RVA: 0x000271A0 File Offset: 0x000253A0
	public unsafe static UnityAction OnSaveSystemProfileChanged
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSaveSystemProfileChanged, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSaveSystemProfileChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001502 RID: 5378
	// (get) Token: 0x0600473B RID: 18235 RVA: 0x0012E464 File Offset: 0x0012C664
	// (set) Token: 0x0600473C RID: 18236 RVA: 0x000271B2 File Offset: 0x000253B2
	public unsafe static UnityAction OnCampaignSaved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignSaved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignSaved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001503 RID: 5379
	// (get) Token: 0x0600473D RID: 18237 RVA: 0x0012E48C File Offset: 0x0012C68C
	// (set) Token: 0x0600473E RID: 18238 RVA: 0x000271C4 File Offset: 0x000253C4
	public unsafe static UnityAction OnCampaignLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001504 RID: 5380
	// (get) Token: 0x0600473F RID: 18239 RVA: 0x0012E4B4 File Offset: 0x0012C6B4
	// (set) Token: 0x06004740 RID: 18240 RVA: 0x000271D6 File Offset: 0x000253D6
	public unsafe static UnityAction OnCampaignDeleted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignDeleted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignDeleted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001505 RID: 5381
	// (get) Token: 0x06004741 RID: 18241 RVA: 0x0012E4DC File Offset: 0x0012C6DC
	// (set) Token: 0x06004742 RID: 18242 RVA: 0x000271E8 File Offset: 0x000253E8
	public unsafe static UnityAction OnBattleSaved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleSaved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleSaved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001506 RID: 5382
	// (get) Token: 0x06004743 RID: 18243 RVA: 0x0012E504 File Offset: 0x0012C704
	// (set) Token: 0x06004744 RID: 18244 RVA: 0x000271FA File Offset: 0x000253FA
	public unsafe static UnityAction OnBattleLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnBattleLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnBattleLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001507 RID: 5383
	// (get) Token: 0x06004745 RID: 18245 RVA: 0x0012E52C File Offset: 0x0012C72C
	// (set) Token: 0x06004746 RID: 18246 RVA: 0x0002720C File Offset: 0x0002540C
	public unsafe static UnityAction OnGameStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnGameStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnGameStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001508 RID: 5384
	// (get) Token: 0x06004747 RID: 18247 RVA: 0x0012E554 File Offset: 0x0012C754
	// (set) Token: 0x06004748 RID: 18248 RVA: 0x0002721E File Offset: 0x0002541E
	public unsafe static UnityAction OnGameEnd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnGameEnd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnGameEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001509 RID: 5385
	// (get) Token: 0x06004749 RID: 18249 RVA: 0x0012E57C File Offset: 0x0012C77C
	// (set) Token: 0x0600474A RID: 18250 RVA: 0x00027230 File Offset: 0x00025430
	public unsafe static UnityAction OnCampaignStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700150A RID: 5386
	// (get) Token: 0x0600474B RID: 18251 RVA: 0x0012E5A4 File Offset: 0x0012C7A4
	// (set) Token: 0x0600474C RID: 18252 RVA: 0x00027242 File Offset: 0x00025442
	public unsafe static UnityAction OnCampaignFinal
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignFinal, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignFinal, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700150B RID: 5387
	// (get) Token: 0x0600474D RID: 18253 RVA: 0x0012E5CC File Offset: 0x0012C7CC
	// (set) Token: 0x0600474E RID: 18254 RVA: 0x00027254 File Offset: 0x00025454
	public unsafe static UnityAction<Campaign.Result, CampaignStats, PlayerData> OnCampaignEnd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignEnd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Campaign.Result, CampaignStats, PlayerData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700150C RID: 5388
	// (get) Token: 0x0600474F RID: 18255 RVA: 0x0012E5F4 File Offset: 0x0012C7F4
	// (set) Token: 0x06004750 RID: 18256 RVA: 0x00027266 File Offset: 0x00025466
	public unsafe static UnityAction<CampaignStats> OnOverallStatsSaved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnOverallStatsSaved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CampaignStats>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnOverallStatsSaved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700150D RID: 5389
	// (get) Token: 0x06004751 RID: 18257 RVA: 0x0012E61C File Offset: 0x0012C81C
	// (set) Token: 0x06004752 RID: 18258 RVA: 0x00027278 File Offset: 0x00025478
	public unsafe static UnityAction<CampaignData> OnCampaignDataCreated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignDataCreated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CampaignData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignDataCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700150E RID: 5390
	// (get) Token: 0x06004753 RID: 18259 RVA: 0x0012E644 File Offset: 0x0012C844
	// (set) Token: 0x06004754 RID: 18260 RVA: 0x0002728A File Offset: 0x0002548A
	public unsafe static Events.RoutineAction OnCampaignPreInit
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignPreInit, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.RoutineAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignPreInit, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700150F RID: 5391
	// (get) Token: 0x06004755 RID: 18261 RVA: 0x0012E66C File Offset: 0x0012C86C
	// (set) Token: 0x06004756 RID: 18262 RVA: 0x0002729C File Offset: 0x0002549C
	public unsafe static Events.RoutineAction OnCampaignInit
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignInit, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.RoutineAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignInit, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001510 RID: 5392
	// (get) Token: 0x06004757 RID: 18263 RVA: 0x0012E694 File Offset: 0x0012C894
	// (set) Token: 0x06004758 RID: 18264 RVA: 0x000272AE File Offset: 0x000254AE
	public unsafe static UnityAction OnPreCampaignPopulate
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnPreCampaignPopulate, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnPreCampaignPopulate, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001511 RID: 5393
	// (get) Token: 0x06004759 RID: 18265 RVA: 0x0012E6BC File Offset: 0x0012C8BC
	// (set) Token: 0x0600475A RID: 18266 RVA: 0x000272C0 File Offset: 0x000254C0
	public unsafe static Events.UnityActionRef1<List<CampaignGenerator.Node>, Vector2> OnCampaignNodesCreated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignNodesCreated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef1<List<CampaignGenerator.Node>, Vector2>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignNodesCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001512 RID: 5394
	// (get) Token: 0x0600475B RID: 18267 RVA: 0x0012E6E4 File Offset: 0x0012C8E4
	// (set) Token: 0x0600475C RID: 18268 RVA: 0x000272D2 File Offset: 0x000254D2
	public unsafe static Events.UnityActionRef<Il2CppStringArray> OnCampaignLoadPreset
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignLoadPreset, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignLoadPreset, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001513 RID: 5395
	// (get) Token: 0x0600475D RID: 18269 RVA: 0x0012E70C File Offset: 0x0012C90C
	// (set) Token: 0x0600475E RID: 18270 RVA: 0x000272E4 File Offset: 0x000254E4
	public unsafe static Events.AsyncAction OnCampaignGenerated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCampaignGenerated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.AsyncAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCampaignGenerated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001514 RID: 5396
	// (get) Token: 0x0600475F RID: 18271 RVA: 0x0012E734 File Offset: 0x0012C934
	// (set) Token: 0x06004760 RID: 18272 RVA: 0x000272F6 File Offset: 0x000254F6
	public unsafe static UnityAction<string, string, int, int> OnStatChanged
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnStatChanged, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<string, string, int, int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnStatChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001515 RID: 5397
	// (get) Token: 0x06004761 RID: 18273 RVA: 0x0012E75C File Offset: 0x0012C95C
	// (set) Token: 0x06004762 RID: 18274 RVA: 0x00027308 File Offset: 0x00025508
	public unsafe static UnityAction<CardUpgradeData> OnUpgradeGained
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnUpgradeGained, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardUpgradeData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnUpgradeGained, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001516 RID: 5398
	// (get) Token: 0x06004763 RID: 18275 RVA: 0x0012E784 File Offset: 0x0012C984
	// (set) Token: 0x06004764 RID: 18276 RVA: 0x0002731A File Offset: 0x0002551A
	public unsafe static UnityAction<Entity, CardUpgradeData> OnUpgradeAssign
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnUpgradeAssign, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity, CardUpgradeData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnUpgradeAssign, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001517 RID: 5399
	// (get) Token: 0x06004765 RID: 18277 RVA: 0x0012E7AC File Offset: 0x0012C9AC
	// (set) Token: 0x06004766 RID: 18278 RVA: 0x0002732C File Offset: 0x0002552C
	public unsafe static UnityAction<UpgradeDisplay> OnUpgradeHover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnUpgradeHover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<UpgradeDisplay>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnUpgradeHover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001518 RID: 5400
	// (get) Token: 0x06004767 RID: 18279 RVA: 0x0012E7D4 File Offset: 0x0012C9D4
	// (set) Token: 0x06004768 RID: 18280 RVA: 0x0002733E File Offset: 0x0002553E
	public unsafe static UnityAction<UpgradeDisplay> OnUpgradePickup
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnUpgradePickup, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<UpgradeDisplay>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnUpgradePickup, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001519 RID: 5401
	// (get) Token: 0x06004769 RID: 18281 RVA: 0x0012E7FC File Offset: 0x0012C9FC
	// (set) Token: 0x0600476A RID: 18282 RVA: 0x00027350 File Offset: 0x00025550
	public unsafe static UnityAction<UpgradeDisplay> OnUpgradeDrop
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnUpgradeDrop, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<UpgradeDisplay>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnUpgradeDrop, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700151A RID: 5402
	// (get) Token: 0x0600476B RID: 18283 RVA: 0x0012E824 File Offset: 0x0012CA24
	// (set) Token: 0x0600476C RID: 18284 RVA: 0x00027362 File Offset: 0x00025562
	public unsafe static UnityAction<bool> OnUpdateInputSystem
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnUpdateInputSystem, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnUpdateInputSystem, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700151B RID: 5403
	// (get) Token: 0x0600476D RID: 18285 RVA: 0x0012E84C File Offset: 0x0012CA4C
	// (set) Token: 0x0600476E RID: 18286 RVA: 0x00027374 File Offset: 0x00025574
	public unsafe static UnityAction<float, Nullable<float>> OnScreenShake
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnScreenShake, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<float, Nullable<float>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnScreenShake, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700151C RID: 5404
	// (get) Token: 0x0600476F RID: 18287 RVA: 0x0012E874 File Offset: 0x0012CA74
	// (set) Token: 0x06004770 RID: 18288 RVA: 0x00027386 File Offset: 0x00025586
	public unsafe static Events.UnityAction<float, float, float, float, float, float> OnScreenRumble
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnScreenRumble, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityAction<float, float, float, float, float, float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnScreenRumble, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700151D RID: 5405
	// (get) Token: 0x06004771 RID: 18289 RVA: 0x0012E89C File Offset: 0x0012CA9C
	// (set) Token: 0x06004772 RID: 18290 RVA: 0x00027398 File Offset: 0x00025598
	public unsafe static UnityAction<string> OnCameraAnimation
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCameraAnimation, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCameraAnimation, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700151E RID: 5406
	// (get) Token: 0x06004773 RID: 18291 RVA: 0x0012E8C4 File Offset: 0x0012CAC4
	// (set) Token: 0x06004774 RID: 18292 RVA: 0x000273AA File Offset: 0x000255AA
	public unsafe static UnityAction<int, string, Character, Vector3> OnDropGold
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnDropGold, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int, string, Character, Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnDropGold, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700151F RID: 5407
	// (get) Token: 0x06004775 RID: 18293 RVA: 0x0012E8EC File Offset: 0x0012CAEC
	// (set) Token: 0x06004776 RID: 18294 RVA: 0x000273BC File Offset: 0x000255BC
	public unsafe static UnityAction<int, Character, Vector3> OnGoldFlyToBag
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnGoldFlyToBag, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int, Character, Vector3>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnGoldFlyToBag, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001520 RID: 5408
	// (get) Token: 0x06004777 RID: 18295 RVA: 0x0012E914 File Offset: 0x0012CB14
	// (set) Token: 0x06004778 RID: 18296 RVA: 0x000273CE File Offset: 0x000255CE
	public unsafe static UnityAction<int> OnCollectGold
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCollectGold, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCollectGold, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001521 RID: 5409
	// (get) Token: 0x06004779 RID: 18297 RVA: 0x0012E93C File Offset: 0x0012CB3C
	// (set) Token: 0x0600477A RID: 18298 RVA: 0x000273E0 File Offset: 0x000255E0
	public unsafe static UnityAction<int> OnSpendGold
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSpendGold, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSpendGold, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001522 RID: 5410
	// (get) Token: 0x0600477B RID: 18299 RVA: 0x0012E964 File Offset: 0x0012CB64
	// (set) Token: 0x0600477C RID: 18300 RVA: 0x000273F2 File Offset: 0x000255F2
	public unsafe static UnityAction<float> OnTimeScaleChange
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnTimeScaleChange, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnTimeScaleChange, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001523 RID: 5411
	// (get) Token: 0x0600477D RID: 18301 RVA: 0x0012E98C File Offset: 0x0012CB8C
	// (set) Token: 0x0600477E RID: 18302 RVA: 0x00027404 File Offset: 0x00025604
	public unsafe static UnityAction<Entity> OnInspect
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnInspect, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnInspect, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001524 RID: 5412
	// (get) Token: 0x0600477F RID: 18303 RVA: 0x0012E9B4 File Offset: 0x0012CBB4
	// (set) Token: 0x06004780 RID: 18304 RVA: 0x00027416 File Offset: 0x00025616
	public unsafe static UnityAction<Entity> OnInspectEnd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnInspectEnd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnInspectEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001525 RID: 5413
	// (get) Token: 0x06004781 RID: 18305 RVA: 0x0012E9DC File Offset: 0x0012CBDC
	// (set) Token: 0x06004782 RID: 18306 RVA: 0x00027428 File Offset: 0x00025628
	public unsafe static UnityAction<Entity> OnInspectNewCard
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnInspectNewCard, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnInspectNewCard, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001526 RID: 5414
	// (get) Token: 0x06004783 RID: 18307 RVA: 0x0012EA04 File Offset: 0x0012CC04
	// (set) Token: 0x06004784 RID: 18308 RVA: 0x0002743A File Offset: 0x0002563A
	public unsafe static UnityAction<CardController> OnCardControllerEnabled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCardControllerEnabled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardController>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCardControllerEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001527 RID: 5415
	// (get) Token: 0x06004785 RID: 18309 RVA: 0x0012EA2C File Offset: 0x0012CC2C
	// (set) Token: 0x06004786 RID: 18310 RVA: 0x0002744C File Offset: 0x0002564C
	public unsafe static UnityAction<CardController> OnCardControllerDisabled
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCardControllerDisabled, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardController>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCardControllerDisabled, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001528 RID: 5416
	// (get) Token: 0x06004787 RID: 18311 RVA: 0x0012EA54 File Offset: 0x0012CC54
	// (set) Token: 0x06004788 RID: 18312 RVA: 0x0002745E File Offset: 0x0002565E
	public unsafe static UnityAction OnDeckpackOpen
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnDeckpackOpen, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnDeckpackOpen, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001529 RID: 5417
	// (get) Token: 0x06004789 RID: 18313 RVA: 0x0012EA7C File Offset: 0x0012CC7C
	// (set) Token: 0x0600478A RID: 18314 RVA: 0x00027470 File Offset: 0x00025670
	public unsafe static UnityAction OnDeckpackClose
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnDeckpackClose, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnDeckpackClose, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700152A RID: 5418
	// (get) Token: 0x0600478B RID: 18315 RVA: 0x0012EAA4 File Offset: 0x0012CCA4
	// (set) Token: 0x0600478C RID: 18316 RVA: 0x00027482 File Offset: 0x00025682
	public unsafe static UnityAction<global::TransitionType> OnTransitionStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnTransitionStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<global::TransitionType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnTransitionStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700152B RID: 5419
	// (get) Token: 0x0600478D RID: 18317 RVA: 0x0012EACC File Offset: 0x0012CCCC
	// (set) Token: 0x0600478E RID: 18318 RVA: 0x00027494 File Offset: 0x00025694
	public unsafe static UnityAction<global::TransitionType> OnTransitionEnd
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnTransitionEnd, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<global::TransitionType>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnTransitionEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700152C RID: 5420
	// (get) Token: 0x0600478F RID: 18319 RVA: 0x0012EAF4 File Offset: 0x0012CCF4
	// (set) Token: 0x06004790 RID: 18320 RVA: 0x000274A6 File Offset: 0x000256A6
	public unsafe static UnityAction<float, float> OnSetWeatherIntensity
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSetWeatherIntensity, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<float, float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSetWeatherIntensity, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700152D RID: 5421
	// (get) Token: 0x06004791 RID: 18321 RVA: 0x0012EB1C File Offset: 0x0012CD1C
	// (set) Token: 0x06004792 RID: 18322 RVA: 0x000274B8 File Offset: 0x000256B8
	public unsafe static UnityAction<GoldDisplay, float> OnGoldCounterStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnGoldCounterStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<GoldDisplay, float>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnGoldCounterStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700152E RID: 5422
	// (get) Token: 0x06004793 RID: 18323 RVA: 0x0012EB44 File Offset: 0x0012CD44
	// (set) Token: 0x06004794 RID: 18324 RVA: 0x000274CA File Offset: 0x000256CA
	public unsafe static UnityAction<CampaignNode, EventRoutine> OnEventStart
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEventStart, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CampaignNode, EventRoutine>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEventStart, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700152F RID: 5423
	// (get) Token: 0x06004795 RID: 18325 RVA: 0x0012EB6C File Offset: 0x0012CD6C
	// (set) Token: 0x06004796 RID: 18326 RVA: 0x000274DC File Offset: 0x000256DC
	public unsafe static UnityAction<EventRoutine> OnEventPopulated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnEventPopulated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<EventRoutine>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnEventPopulated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001530 RID: 5424
	// (get) Token: 0x06004797 RID: 18327 RVA: 0x0012EB94 File Offset: 0x0012CD94
	// (set) Token: 0x06004798 RID: 18328 RVA: 0x000274EE File Offset: 0x000256EE
	public unsafe static UnityAction OnMuncherDrag
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMuncherDrag, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMuncherDrag, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001531 RID: 5425
	// (get) Token: 0x06004799 RID: 18329 RVA: 0x0012EBBC File Offset: 0x0012CDBC
	// (set) Token: 0x0600479A RID: 18330 RVA: 0x00027500 File Offset: 0x00025700
	public unsafe static UnityAction OnMuncherDragCancel
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMuncherDragCancel, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMuncherDragCancel, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001532 RID: 5426
	// (get) Token: 0x0600479B RID: 18331 RVA: 0x0012EBE4 File Offset: 0x0012CDE4
	// (set) Token: 0x0600479C RID: 18332 RVA: 0x00027512 File Offset: 0x00025712
	public unsafe static UnityAction<Entity> OnMuncherFeed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnMuncherFeed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnMuncherFeed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001533 RID: 5427
	// (get) Token: 0x0600479D RID: 18333 RVA: 0x0012EC0C File Offset: 0x0012CE0C
	// (set) Token: 0x0600479E RID: 18334 RVA: 0x00027524 File Offset: 0x00025724
	public unsafe static UnityAction<string, Il2CppSystem.Object> OnSettingChanged
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnSettingChanged, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<string, Il2CppSystem.Object>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnSettingChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001534 RID: 5428
	// (get) Token: 0x0600479F RID: 18335 RVA: 0x0012EC34 File Offset: 0x0012CE34
	// (set) Token: 0x060047A0 RID: 18336 RVA: 0x00027536 File Offset: 0x00025736
	public unsafe static UnityAction OnUINavigationReset
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnUINavigationReset, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnUINavigationReset, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001535 RID: 5429
	// (get) Token: 0x060047A1 RID: 18337 RVA: 0x0012EC5C File Offset: 0x0012CE5C
	// (set) Token: 0x060047A2 RID: 18338 RVA: 0x00027548 File Offset: 0x00025748
	public unsafe static UnityAction OnUINavigation
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnUINavigation, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnUINavigation, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001536 RID: 5430
	// (get) Token: 0x060047A3 RID: 18339 RVA: 0x0012EC84 File Offset: 0x0012CE84
	// (set) Token: 0x060047A4 RID: 18340 RVA: 0x0002755A File Offset: 0x0002575A
	public unsafe static UnityAction OnButtonStyleChanged
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnButtonStyleChanged, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnButtonStyleChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001537 RID: 5431
	// (get) Token: 0x060047A5 RID: 18341 RVA: 0x0012ECAC File Offset: 0x0012CEAC
	// (set) Token: 0x060047A6 RID: 18342 RVA: 0x0002756C File Offset: 0x0002576C
	public unsafe static UnityAction OnControllerSwitched
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnControllerSwitched, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnControllerSwitched, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001538 RID: 5432
	// (get) Token: 0x060047A7 RID: 18343 RVA: 0x0012ECD4 File Offset: 0x0012CED4
	// (set) Token: 0x060047A8 RID: 18344 RVA: 0x0002757E File Offset: 0x0002577E
	public unsafe static Events.UnityActionRef<Entity, string, bool> OnCheckRename
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCheckRename, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Entity, string, bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCheckRename, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001539 RID: 5433
	// (get) Token: 0x060047A9 RID: 18345 RVA: 0x0012ECFC File Offset: 0x0012CEFC
	// (set) Token: 0x060047AA RID: 18346 RVA: 0x00027590 File Offset: 0x00025790
	public unsafe static UnityAction<Entity, string> OnRename
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnRename, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Entity, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnRename, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700153A RID: 5434
	// (get) Token: 0x060047AB RID: 18347 RVA: 0x0012ED24 File Offset: 0x0012CF24
	// (set) Token: 0x060047AC RID: 18348 RVA: 0x000275A2 File Offset: 0x000257A2
	public unsafe static Events.UnityActionRef<Il2CppSystem.Object, string, int, List<DataFile>> OnPullRewards
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnPullRewards, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<Il2CppSystem.Object, string, int, List<DataFile>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnPullRewards, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700153B RID: 5435
	// (get) Token: 0x060047AD RID: 18349 RVA: 0x0012ED4C File Offset: 0x0012CF4C
	// (set) Token: 0x060047AE RID: 18350 RVA: 0x000275B4 File Offset: 0x000257B4
	public unsafe static UnityAction<CardData> OnCardDataCreated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnCardDataCreated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<CardData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnCardDataCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700153C RID: 5436
	// (get) Token: 0x060047AF RID: 18351 RVA: 0x0012ED74 File Offset: 0x0012CF74
	// (set) Token: 0x060047B0 RID: 18352 RVA: 0x000275C6 File Offset: 0x000257C6
	public unsafe static UnityAction<int> OnTutorialProgress
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnTutorialProgress, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnTutorialProgress, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700153D RID: 5437
	// (get) Token: 0x060047B1 RID: 18353 RVA: 0x0012ED9C File Offset: 0x0012CF9C
	// (set) Token: 0x060047B2 RID: 18354 RVA: 0x000275D8 File Offset: 0x000257D8
	public unsafe static UnityAction OnTutorialSkip
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnTutorialSkip, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnTutorialSkip, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700153E RID: 5438
	// (get) Token: 0x060047B3 RID: 18355 RVA: 0x0012EDC4 File Offset: 0x0012CFC4
	// (set) Token: 0x060047B4 RID: 18356 RVA: 0x000275EA File Offset: 0x000257EA
	public unsafe static UnityAction<ChallengeData> OnChallengeCompletedSaved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnChallengeCompletedSaved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<ChallengeData>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnChallengeCompletedSaved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700153F RID: 5439
	// (get) Token: 0x060047B5 RID: 18357 RVA: 0x0012EDEC File Offset: 0x0012CFEC
	// (set) Token: 0x060047B6 RID: 18358 RVA: 0x000275FC File Offset: 0x000257FC
	public unsafe static Events.UnityActionRef<int> OnGetHandSize
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Events.NativeFieldInfoPtr_OnGetHandSize, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Events.UnityActionRef<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Events.NativeFieldInfoPtr_OnGetHandSize, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04002A3C RID: 10812
	private static readonly IntPtr NativeFieldInfoPtr_OnSceneLoaded;

	// Token: 0x04002A3D RID: 10813
	private static readonly IntPtr NativeFieldInfoPtr_OnSceneChanged;

	// Token: 0x04002A3E RID: 10814
	private static readonly IntPtr NativeFieldInfoPtr_OnSceneUnload;

	// Token: 0x04002A3F RID: 10815
	private static readonly IntPtr NativeFieldInfoPtr_OnBackToMainMenu;

	// Token: 0x04002A40 RID: 10816
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityCreated;

	// Token: 0x04002A41 RID: 10817
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityDataUpdated;

	// Token: 0x04002A42 RID: 10818
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityDestroyed;

	// Token: 0x04002A43 RID: 10819
	private static readonly IntPtr NativeFieldInfoPtr_OnCardPooled;

	// Token: 0x04002A44 RID: 10820
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityEnabled;

	// Token: 0x04002A45 RID: 10821
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityDisabled;

	// Token: 0x04002A46 RID: 10822
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityKilled;

	// Token: 0x04002A47 RID: 10823
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityFlee;

	// Token: 0x04002A48 RID: 10824
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityHover;

	// Token: 0x04002A49 RID: 10825
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityUnHover;

	// Token: 0x04002A4A RID: 10826
	private static readonly IntPtr NativeFieldInfoPtr_OnEntitySelect;

	// Token: 0x04002A4B RID: 10827
	private static readonly IntPtr NativeFieldInfoPtr_OnCheckEntityDrag;

	// Token: 0x04002A4C RID: 10828
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityDrag;

	// Token: 0x04002A4D RID: 10829
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityRelease;

	// Token: 0x04002A4E RID: 10830
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityOffered;

	// Token: 0x04002A4F RID: 10831
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityChosen;

	// Token: 0x04002A50 RID: 10832
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityShowUnlocked;

	// Token: 0x04002A51 RID: 10833
	private static readonly IntPtr NativeFieldInfoPtr_OnCheckEntityShove;

	// Token: 0x04002A52 RID: 10834
	private static readonly IntPtr NativeFieldInfoPtr_OnPreProcessTrigger;

	// Token: 0x04002A53 RID: 10835
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityPreTrigger;

	// Token: 0x04002A54 RID: 10836
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityTrigger;

	// Token: 0x04002A55 RID: 10837
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityTriggered;

	// Token: 0x04002A56 RID: 10838
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityMove;

	// Token: 0x04002A57 RID: 10839
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityPlace;

	// Token: 0x04002A58 RID: 10840
	private static readonly IntPtr NativeFieldInfoPtr_OnDiscard;

	// Token: 0x04002A59 RID: 10841
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityHit;

	// Token: 0x04002A5A RID: 10842
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityPostHit;

	// Token: 0x04002A5B RID: 10843
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityDodge;

	// Token: 0x04002A5C RID: 10844
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityFlipUp;

	// Token: 0x04002A5D RID: 10845
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityFlipDown;

	// Token: 0x04002A5E RID: 10846
	private static readonly IntPtr NativeFieldInfoPtr_OnStatusIconCreated;

	// Token: 0x04002A5F RID: 10847
	private static readonly IntPtr NativeFieldInfoPtr_OnStatusIconChanged;

	// Token: 0x04002A60 RID: 10848
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityDisplayUpdated;

	// Token: 0x04002A61 RID: 10849
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityFocus;

	// Token: 0x04002A62 RID: 10850
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityEnterPocket;

	// Token: 0x04002A63 RID: 10851
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityEnterBackpack;

	// Token: 0x04002A64 RID: 10852
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityChangePhase;

	// Token: 0x04002A65 RID: 10853
	private static readonly IntPtr NativeFieldInfoPtr_OnNoomlinShow;

	// Token: 0x04002A66 RID: 10854
	private static readonly IntPtr NativeFieldInfoPtr_OnNoomlinUsed;

	// Token: 0x04002A67 RID: 10855
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityFlipComplete;

	// Token: 0x04002A68 RID: 10856
	private static readonly IntPtr NativeFieldInfoPtr_OnEntitySummoned;

	// Token: 0x04002A69 RID: 10857
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityPing;

	// Token: 0x04002A6A RID: 10858
	private static readonly IntPtr NativeFieldInfoPtr_OnCheckRecycleAmount;

	// Token: 0x04002A6B RID: 10859
	private static readonly IntPtr NativeFieldInfoPtr_OnContainerHover;

	// Token: 0x04002A6C RID: 10860
	private static readonly IntPtr NativeFieldInfoPtr_OnContainerUnHover;

	// Token: 0x04002A6D RID: 10861
	private static readonly IntPtr NativeFieldInfoPtr_OnSlotHover;

	// Token: 0x04002A6E RID: 10862
	private static readonly IntPtr NativeFieldInfoPtr_OnSlotUnHover;

	// Token: 0x04002A6F RID: 10863
	private static readonly IntPtr NativeFieldInfoPtr_OnActionQueued;

	// Token: 0x04002A70 RID: 10864
	private static readonly IntPtr NativeFieldInfoPtr_OnActionPerform;

	// Token: 0x04002A71 RID: 10865
	private static readonly IntPtr NativeFieldInfoPtr_OnActionFinished;

	// Token: 0x04002A72 RID: 10866
	private static readonly IntPtr NativeFieldInfoPtr_OnCheckAction;

	// Token: 0x04002A73 RID: 10867
	private static readonly IntPtr NativeFieldInfoPtr_OnAbilityTargetAdd;

	// Token: 0x04002A74 RID: 10868
	private static readonly IntPtr NativeFieldInfoPtr_OnAbilityTargetRemove;

	// Token: 0x04002A75 RID: 10869
	private static readonly IntPtr NativeFieldInfoPtr_OnCardDraw;

	// Token: 0x04002A76 RID: 10870
	private static readonly IntPtr NativeFieldInfoPtr_OnCardDrawEnd;

	// Token: 0x04002A77 RID: 10871
	private static readonly IntPtr NativeFieldInfoPtr_PreBattleSetUp;

	// Token: 0x04002A78 RID: 10872
	private static readonly IntPtr NativeFieldInfoPtr_PostBattleSetUp;

	// Token: 0x04002A79 RID: 10873
	private static readonly IntPtr NativeFieldInfoPtr_OnBattlePhaseStart;

	// Token: 0x04002A7A RID: 10874
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleStart;

	// Token: 0x04002A7B RID: 10875
	private static readonly IntPtr NativeFieldInfoPtr_PreBattleEnd;

	// Token: 0x04002A7C RID: 10876
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleEnd;

	// Token: 0x04002A7D RID: 10877
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleWinPreRewards;

	// Token: 0x04002A7E RID: 10878
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleWin;

	// Token: 0x04002A7F RID: 10879
	private static readonly IntPtr NativeFieldInfoPtr_PostBattle;

	// Token: 0x04002A80 RID: 10880
	private static readonly IntPtr NativeFieldInfoPtr_OnStatusEffectCountDown;

	// Token: 0x04002A81 RID: 10881
	private static readonly IntPtr NativeFieldInfoPtr_OnStatusEffectApplied;

	// Token: 0x04002A82 RID: 10882
	private static readonly IntPtr NativeFieldInfoPtr_OnPreProcessUnits;

	// Token: 0x04002A83 RID: 10883
	private static readonly IntPtr NativeFieldInfoPtr_OnPostProcessUnits;

	// Token: 0x04002A84 RID: 10884
	private static readonly IntPtr NativeFieldInfoPtr_OnEntityCountDown;

	// Token: 0x04002A85 RID: 10885
	private static readonly IntPtr NativeFieldInfoPtr_OnBattlePreTurnStart;

	// Token: 0x04002A86 RID: 10886
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleTurnStart;

	// Token: 0x04002A87 RID: 10887
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleTurnEnd;

	// Token: 0x04002A88 RID: 10888
	private static readonly IntPtr NativeFieldInfoPtr_OnMinibossIntro;

	// Token: 0x04002A89 RID: 10889
	private static readonly IntPtr NativeFieldInfoPtr_OnMinibossIntroDone;

	// Token: 0x04002A8A RID: 10890
	private static readonly IntPtr NativeFieldInfoPtr_OnKillCombo;

	// Token: 0x04002A8B RID: 10891
	private static readonly IntPtr NativeFieldInfoPtr_OnRedrawBellHit;

	// Token: 0x04002A8C RID: 10892
	private static readonly IntPtr NativeFieldInfoPtr_OnRedrawBellRevealed;

	// Token: 0x04002A8D RID: 10893
	private static readonly IntPtr NativeFieldInfoPtr_OnCardInjured;

	// Token: 0x04002A8E RID: 10894
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleStateBuild;

	// Token: 0x04002A8F RID: 10895
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleStateBuilt;

	// Token: 0x04002A90 RID: 10896
	private static readonly IntPtr NativeFieldInfoPtr_OnCharacterActionPerformed;

	// Token: 0x04002A91 RID: 10897
	private static readonly IntPtr NativeFieldInfoPtr_OnWaveDeployerPreCountDown;

	// Token: 0x04002A92 RID: 10898
	private static readonly IntPtr NativeFieldInfoPtr_OnWaveDeployerPostCountDown;

	// Token: 0x04002A93 RID: 10899
	private static readonly IntPtr NativeFieldInfoPtr_OnWaveDeployerEarlyDeploy;

	// Token: 0x04002A94 RID: 10900
	private static readonly IntPtr NativeFieldInfoPtr_OnMapPathReveal;

	// Token: 0x04002A95 RID: 10901
	private static readonly IntPtr NativeFieldInfoPtr_OnMapNodeReveal;

	// Token: 0x04002A96 RID: 10902
	private static readonly IntPtr NativeFieldInfoPtr_OnMapNodeSelect;

	// Token: 0x04002A97 RID: 10903
	private static readonly IntPtr NativeFieldInfoPtr_OnMapNodeHover;

	// Token: 0x04002A98 RID: 10904
	private static readonly IntPtr NativeFieldInfoPtr_OnMapNodeUnHover;

	// Token: 0x04002A99 RID: 10905
	private static readonly IntPtr NativeFieldInfoPtr_OnTownUnlock;

	// Token: 0x04002A9A RID: 10906
	private static readonly IntPtr NativeFieldInfoPtr_OnShopItemHover;

	// Token: 0x04002A9B RID: 10907
	private static readonly IntPtr NativeFieldInfoPtr_OnShopItemUnHover;

	// Token: 0x04002A9C RID: 10908
	private static readonly IntPtr NativeFieldInfoPtr_OnShopItemPurchase;

	// Token: 0x04002A9D RID: 10909
	private static readonly IntPtr NativeFieldInfoPtr_OnShopItemHaggled;

	// Token: 0x04002A9E RID: 10910
	private static readonly IntPtr NativeFieldInfoPtr_OnPopupCreated;

	// Token: 0x04002A9F RID: 10911
	private static readonly IntPtr NativeFieldInfoPtr_OnButtonHover;

	// Token: 0x04002AA0 RID: 10912
	private static readonly IntPtr NativeFieldInfoPtr_OnButtonPress;

	// Token: 0x04002AA1 RID: 10913
	private static readonly IntPtr NativeFieldInfoPtr_OnAudioVolumeChange;

	// Token: 0x04002AA2 RID: 10914
	private static readonly IntPtr NativeFieldInfoPtr_OnAudioPitchChange;

	// Token: 0x04002AA3 RID: 10915
	private static readonly IntPtr NativeFieldInfoPtr_OnBombardShoot;

	// Token: 0x04002AA4 RID: 10916
	private static readonly IntPtr NativeFieldInfoPtr_OnBombardRocketFall;

	// Token: 0x04002AA5 RID: 10917
	private static readonly IntPtr NativeFieldInfoPtr_OnBombardRocketExplode;

	// Token: 0x04002AA6 RID: 10918
	private static readonly IntPtr NativeFieldInfoPtr_OnProgressStart;

	// Token: 0x04002AA7 RID: 10919
	private static readonly IntPtr NativeFieldInfoPtr_OnProgressUpdate;

	// Token: 0x04002AA8 RID: 10920
	private static readonly IntPtr NativeFieldInfoPtr_OnProgressStop;

	// Token: 0x04002AA9 RID: 10921
	private static readonly IntPtr NativeFieldInfoPtr_OnProgressDing;

	// Token: 0x04002AAA RID: 10922
	private static readonly IntPtr NativeFieldInfoPtr_OnProgressBlip;

	// Token: 0x04002AAB RID: 10923
	private static readonly IntPtr NativeFieldInfoPtr_OnSaveSystemEnabled;

	// Token: 0x04002AAC RID: 10924
	private static readonly IntPtr NativeFieldInfoPtr_OnSaveSystemDisabled;

	// Token: 0x04002AAD RID: 10925
	private static readonly IntPtr NativeFieldInfoPtr_OnSaveSystemProfileChanged;

	// Token: 0x04002AAE RID: 10926
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignSaved;

	// Token: 0x04002AAF RID: 10927
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignLoaded;

	// Token: 0x04002AB0 RID: 10928
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignDeleted;

	// Token: 0x04002AB1 RID: 10929
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleSaved;

	// Token: 0x04002AB2 RID: 10930
	private static readonly IntPtr NativeFieldInfoPtr_OnBattleLoaded;

	// Token: 0x04002AB3 RID: 10931
	private static readonly IntPtr NativeFieldInfoPtr_OnGameStart;

	// Token: 0x04002AB4 RID: 10932
	private static readonly IntPtr NativeFieldInfoPtr_OnGameEnd;

	// Token: 0x04002AB5 RID: 10933
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignStart;

	// Token: 0x04002AB6 RID: 10934
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignFinal;

	// Token: 0x04002AB7 RID: 10935
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignEnd;

	// Token: 0x04002AB8 RID: 10936
	private static readonly IntPtr NativeFieldInfoPtr_OnOverallStatsSaved;

	// Token: 0x04002AB9 RID: 10937
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignDataCreated;

	// Token: 0x04002ABA RID: 10938
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignPreInit;

	// Token: 0x04002ABB RID: 10939
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignInit;

	// Token: 0x04002ABC RID: 10940
	private static readonly IntPtr NativeFieldInfoPtr_OnPreCampaignPopulate;

	// Token: 0x04002ABD RID: 10941
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignNodesCreated;

	// Token: 0x04002ABE RID: 10942
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignLoadPreset;

	// Token: 0x04002ABF RID: 10943
	private static readonly IntPtr NativeFieldInfoPtr_OnCampaignGenerated;

	// Token: 0x04002AC0 RID: 10944
	private static readonly IntPtr NativeFieldInfoPtr_OnStatChanged;

	// Token: 0x04002AC1 RID: 10945
	private static readonly IntPtr NativeFieldInfoPtr_OnUpgradeGained;

	// Token: 0x04002AC2 RID: 10946
	private static readonly IntPtr NativeFieldInfoPtr_OnUpgradeAssign;

	// Token: 0x04002AC3 RID: 10947
	private static readonly IntPtr NativeFieldInfoPtr_OnUpgradeHover;

	// Token: 0x04002AC4 RID: 10948
	private static readonly IntPtr NativeFieldInfoPtr_OnUpgradePickup;

	// Token: 0x04002AC5 RID: 10949
	private static readonly IntPtr NativeFieldInfoPtr_OnUpgradeDrop;

	// Token: 0x04002AC6 RID: 10950
	private static readonly IntPtr NativeFieldInfoPtr_OnUpdateInputSystem;

	// Token: 0x04002AC7 RID: 10951
	private static readonly IntPtr NativeFieldInfoPtr_OnScreenShake;

	// Token: 0x04002AC8 RID: 10952
	private static readonly IntPtr NativeFieldInfoPtr_OnScreenRumble;

	// Token: 0x04002AC9 RID: 10953
	private static readonly IntPtr NativeFieldInfoPtr_OnCameraAnimation;

	// Token: 0x04002ACA RID: 10954
	private static readonly IntPtr NativeFieldInfoPtr_OnDropGold;

	// Token: 0x04002ACB RID: 10955
	private static readonly IntPtr NativeFieldInfoPtr_OnGoldFlyToBag;

	// Token: 0x04002ACC RID: 10956
	private static readonly IntPtr NativeFieldInfoPtr_OnCollectGold;

	// Token: 0x04002ACD RID: 10957
	private static readonly IntPtr NativeFieldInfoPtr_OnSpendGold;

	// Token: 0x04002ACE RID: 10958
	private static readonly IntPtr NativeFieldInfoPtr_OnTimeScaleChange;

	// Token: 0x04002ACF RID: 10959
	private static readonly IntPtr NativeFieldInfoPtr_OnInspect;

	// Token: 0x04002AD0 RID: 10960
	private static readonly IntPtr NativeFieldInfoPtr_OnInspectEnd;

	// Token: 0x04002AD1 RID: 10961
	private static readonly IntPtr NativeFieldInfoPtr_OnInspectNewCard;

	// Token: 0x04002AD2 RID: 10962
	private static readonly IntPtr NativeFieldInfoPtr_OnCardControllerEnabled;

	// Token: 0x04002AD3 RID: 10963
	private static readonly IntPtr NativeFieldInfoPtr_OnCardControllerDisabled;

	// Token: 0x04002AD4 RID: 10964
	private static readonly IntPtr NativeFieldInfoPtr_OnDeckpackOpen;

	// Token: 0x04002AD5 RID: 10965
	private static readonly IntPtr NativeFieldInfoPtr_OnDeckpackClose;

	// Token: 0x04002AD6 RID: 10966
	private static readonly IntPtr NativeFieldInfoPtr_OnTransitionStart;

	// Token: 0x04002AD7 RID: 10967
	private static readonly IntPtr NativeFieldInfoPtr_OnTransitionEnd;

	// Token: 0x04002AD8 RID: 10968
	private static readonly IntPtr NativeFieldInfoPtr_OnSetWeatherIntensity;

	// Token: 0x04002AD9 RID: 10969
	private static readonly IntPtr NativeFieldInfoPtr_OnGoldCounterStart;

	// Token: 0x04002ADA RID: 10970
	private static readonly IntPtr NativeFieldInfoPtr_OnEventStart;

	// Token: 0x04002ADB RID: 10971
	private static readonly IntPtr NativeFieldInfoPtr_OnEventPopulated;

	// Token: 0x04002ADC RID: 10972
	private static readonly IntPtr NativeFieldInfoPtr_OnMuncherDrag;

	// Token: 0x04002ADD RID: 10973
	private static readonly IntPtr NativeFieldInfoPtr_OnMuncherDragCancel;

	// Token: 0x04002ADE RID: 10974
	private static readonly IntPtr NativeFieldInfoPtr_OnMuncherFeed;

	// Token: 0x04002ADF RID: 10975
	private static readonly IntPtr NativeFieldInfoPtr_OnSettingChanged;

	// Token: 0x04002AE0 RID: 10976
	private static readonly IntPtr NativeFieldInfoPtr_OnUINavigationReset;

	// Token: 0x04002AE1 RID: 10977
	private static readonly IntPtr NativeFieldInfoPtr_OnUINavigation;

	// Token: 0x04002AE2 RID: 10978
	private static readonly IntPtr NativeFieldInfoPtr_OnButtonStyleChanged;

	// Token: 0x04002AE3 RID: 10979
	private static readonly IntPtr NativeFieldInfoPtr_OnControllerSwitched;

	// Token: 0x04002AE4 RID: 10980
	private static readonly IntPtr NativeFieldInfoPtr_OnCheckRename;

	// Token: 0x04002AE5 RID: 10981
	private static readonly IntPtr NativeFieldInfoPtr_OnRename;

	// Token: 0x04002AE6 RID: 10982
	private static readonly IntPtr NativeFieldInfoPtr_OnPullRewards;

	// Token: 0x04002AE7 RID: 10983
	private static readonly IntPtr NativeFieldInfoPtr_OnCardDataCreated;

	// Token: 0x04002AE8 RID: 10984
	private static readonly IntPtr NativeFieldInfoPtr_OnTutorialProgress;

	// Token: 0x04002AE9 RID: 10985
	private static readonly IntPtr NativeFieldInfoPtr_OnTutorialSkip;

	// Token: 0x04002AEA RID: 10986
	private static readonly IntPtr NativeFieldInfoPtr_OnChallengeCompletedSaved;

	// Token: 0x04002AEB RID: 10987
	private static readonly IntPtr NativeFieldInfoPtr_OnGetHandSize;

	// Token: 0x04002AEC RID: 10988
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSceneLoaded_Public_Static_add_Void_UnityAction_1_Scene_0;

	// Token: 0x04002AED RID: 10989
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSceneLoaded_Public_Static_rem_Void_UnityAction_1_Scene_0;

	// Token: 0x04002AEE RID: 10990
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSceneLoaded_Public_Static_Void_Scene_0;

	// Token: 0x04002AEF RID: 10991
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSceneChanged_Public_Static_add_Void_UnityAction_1_Scene_0;

	// Token: 0x04002AF0 RID: 10992
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSceneChanged_Public_Static_rem_Void_UnityAction_1_Scene_0;

	// Token: 0x04002AF1 RID: 10993
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSceneChanged_Public_Static_Void_Scene_0;

	// Token: 0x04002AF2 RID: 10994
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSceneUnload_Public_Static_add_Void_UnityAction_1_Scene_0;

	// Token: 0x04002AF3 RID: 10995
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSceneUnload_Public_Static_rem_Void_UnityAction_1_Scene_0;

	// Token: 0x04002AF4 RID: 10996
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSceneUnload_Public_Static_Void_Scene_0;

	// Token: 0x04002AF5 RID: 10997
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBackToMainMenu_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002AF6 RID: 10998
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBackToMainMenu_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002AF7 RID: 10999
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBackToMainMenu_Public_Static_Void_0;

	// Token: 0x04002AF8 RID: 11000
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityCreated_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002AF9 RID: 11001
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityCreated_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002AFA RID: 11002
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityCreated_Public_Static_Void_Entity_0;

	// Token: 0x04002AFB RID: 11003
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityDataUpdated_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002AFC RID: 11004
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityDataUpdated_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002AFD RID: 11005
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityDataUpdated_Public_Static_Void_Entity_0;

	// Token: 0x04002AFE RID: 11006
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityDestroyed_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002AFF RID: 11007
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityDestroyed_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B00 RID: 11008
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityDestroyed_Public_Static_Void_Entity_0;

	// Token: 0x04002B01 RID: 11009
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCardPooled_Public_Static_add_Void_UnityAction_1_Card_0;

	// Token: 0x04002B02 RID: 11010
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCardPooled_Public_Static_rem_Void_UnityAction_1_Card_0;

	// Token: 0x04002B03 RID: 11011
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCardPooled_Public_Static_Void_Card_0;

	// Token: 0x04002B04 RID: 11012
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityEnabled_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B05 RID: 11013
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityEnabled_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B06 RID: 11014
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityEnabled_Public_Static_Void_Entity_0;

	// Token: 0x04002B07 RID: 11015
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityDisabled_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B08 RID: 11016
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityDisabled_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B09 RID: 11017
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityDisabled_Public_Static_Void_Entity_0;

	// Token: 0x04002B0A RID: 11018
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityKilled_Public_Static_add_Void_UnityAction_2_Entity_DeathType_0;

	// Token: 0x04002B0B RID: 11019
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityKilled_Public_Static_rem_Void_UnityAction_2_Entity_DeathType_0;

	// Token: 0x04002B0C RID: 11020
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityKilled_Public_Static_Void_Entity_DeathType_0;

	// Token: 0x04002B0D RID: 11021
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityFlee_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B0E RID: 11022
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityFlee_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B0F RID: 11023
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityFlee_Public_Static_Void_Entity_0;

	// Token: 0x04002B10 RID: 11024
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityHover_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B11 RID: 11025
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityHover_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B12 RID: 11026
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityHover_Public_Static_Void_Entity_0;

	// Token: 0x04002B13 RID: 11027
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityUnHover_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B14 RID: 11028
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityUnHover_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B15 RID: 11029
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityUnHover_Public_Static_Void_Entity_0;

	// Token: 0x04002B16 RID: 11030
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntitySelect_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B17 RID: 11031
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntitySelect_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B18 RID: 11032
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntitySelect_Public_Static_Void_Entity_0;

	// Token: 0x04002B19 RID: 11033
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCheckEntityDrag_Public_Static_add_Void_UnityActionRef_2_Entity_Boolean_0;

	// Token: 0x04002B1A RID: 11034
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCheckEntityDrag_Public_Static_rem_Void_UnityActionRef_2_Entity_Boolean_0;

	// Token: 0x04002B1B RID: 11035
	private static readonly IntPtr NativeMethodInfoPtr_CheckEntityDrag_Public_Static_Boolean_Entity_0;

	// Token: 0x04002B1C RID: 11036
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityDrag_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B1D RID: 11037
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityDrag_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B1E RID: 11038
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityDrag_Public_Static_Void_Entity_0;

	// Token: 0x04002B1F RID: 11039
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityRelease_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B20 RID: 11040
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityRelease_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B21 RID: 11041
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityRelease_Public_Static_Void_Entity_0;

	// Token: 0x04002B22 RID: 11042
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityOffered_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B23 RID: 11043
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityOffered_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B24 RID: 11044
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityOffered_Public_Static_Void_Entity_0;

	// Token: 0x04002B25 RID: 11045
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityChosen_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B26 RID: 11046
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityChosen_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B27 RID: 11047
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityChosen_Public_Static_Void_Entity_0;

	// Token: 0x04002B28 RID: 11048
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityShowUnlocked_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B29 RID: 11049
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityShowUnlocked_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B2A RID: 11050
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityShowUnlocked_Public_Static_Void_Entity_0;

	// Token: 0x04002B2B RID: 11051
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCheckEntityShove_Public_Static_add_Void_UnityActionRef_2_Entity_Boolean_0;

	// Token: 0x04002B2C RID: 11052
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCheckEntityShove_Public_Static_rem_Void_UnityActionRef_2_Entity_Boolean_0;

	// Token: 0x04002B2D RID: 11053
	private static readonly IntPtr NativeMethodInfoPtr_CheckEntityShove_Public_Static_Boolean_Entity_0;

	// Token: 0x04002B2E RID: 11054
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPreProcessTrigger_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B2F RID: 11055
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPreProcessTrigger_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B30 RID: 11056
	private static readonly IntPtr NativeMethodInfoPtr_InvokePreProcessTrigger_Public_Static_Void_Entity_0;

	// Token: 0x04002B31 RID: 11057
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityPreTrigger_Public_Static_add_Void_UnityActionRef_1_Trigger_0;

	// Token: 0x04002B32 RID: 11058
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityPreTrigger_Public_Static_rem_Void_UnityActionRef_1_Trigger_0;

	// Token: 0x04002B33 RID: 11059
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityPreTrigger_Public_Static_Void_byref_Trigger_0;

	// Token: 0x04002B34 RID: 11060
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityTrigger_Public_Static_add_Void_UnityActionRef_1_Trigger_0;

	// Token: 0x04002B35 RID: 11061
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityTrigger_Public_Static_rem_Void_UnityActionRef_1_Trigger_0;

	// Token: 0x04002B36 RID: 11062
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityTrigger_Public_Static_Void_byref_Trigger_0;

	// Token: 0x04002B37 RID: 11063
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityTriggered_Public_Static_add_Void_UnityActionRef_1_Trigger_0;

	// Token: 0x04002B38 RID: 11064
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityTriggered_Public_Static_rem_Void_UnityActionRef_1_Trigger_0;

	// Token: 0x04002B39 RID: 11065
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityTriggered_Public_Static_Void_byref_Trigger_0;

	// Token: 0x04002B3A RID: 11066
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityMove_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B3B RID: 11067
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityMove_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B3C RID: 11068
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityMove_Public_Static_Void_Entity_0;

	// Token: 0x04002B3D RID: 11069
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityPlace_Public_Static_add_Void_UnityAction_3_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0;

	// Token: 0x04002B3E RID: 11070
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityPlace_Public_Static_rem_Void_UnityAction_3_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0;

	// Token: 0x04002B3F RID: 11071
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityPlace_Public_Static_Void_Entity_Il2CppReferenceArray_1_CardContainer_Boolean_0;

	// Token: 0x04002B40 RID: 11072
	private static readonly IntPtr NativeMethodInfoPtr_add_OnDiscard_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B41 RID: 11073
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnDiscard_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B42 RID: 11074
	private static readonly IntPtr NativeMethodInfoPtr_InvokeDiscard_Public_Static_Void_Entity_0;

	// Token: 0x04002B43 RID: 11075
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityHit_Public_Static_add_Void_UnityAction_1_Hit_0;

	// Token: 0x04002B44 RID: 11076
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityHit_Public_Static_rem_Void_UnityAction_1_Hit_0;

	// Token: 0x04002B45 RID: 11077
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityHit_Public_Static_Void_Hit_0;

	// Token: 0x04002B46 RID: 11078
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityPostHit_Public_Static_add_Void_UnityAction_1_Hit_0;

	// Token: 0x04002B47 RID: 11079
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityPostHit_Public_Static_rem_Void_UnityAction_1_Hit_0;

	// Token: 0x04002B48 RID: 11080
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityPostHit_Public_Static_Void_Hit_0;

	// Token: 0x04002B49 RID: 11081
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityDodge_Public_Static_add_Void_UnityAction_1_Hit_0;

	// Token: 0x04002B4A RID: 11082
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityDodge_Public_Static_rem_Void_UnityAction_1_Hit_0;

	// Token: 0x04002B4B RID: 11083
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityDodge_Public_Static_Void_Hit_0;

	// Token: 0x04002B4C RID: 11084
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityFlipUp_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B4D RID: 11085
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityFlipUp_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B4E RID: 11086
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityFlipUp_Public_Static_Void_Entity_0;

	// Token: 0x04002B4F RID: 11087
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityFlipDown_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B50 RID: 11088
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityFlipDown_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B51 RID: 11089
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityFlipDown_Public_Static_Void_Entity_0;

	// Token: 0x04002B52 RID: 11090
	private static readonly IntPtr NativeMethodInfoPtr_add_OnStatusIconCreated_Public_Static_add_Void_UnityAction_1_StatusIcon_0;

	// Token: 0x04002B53 RID: 11091
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnStatusIconCreated_Public_Static_rem_Void_UnityAction_1_StatusIcon_0;

	// Token: 0x04002B54 RID: 11092
	private static readonly IntPtr NativeMethodInfoPtr_InvokeStatusIconCreated_Public_Static_Void_StatusIcon_0;

	// Token: 0x04002B55 RID: 11093
	private static readonly IntPtr NativeMethodInfoPtr_add_OnStatusIconChanged_Public_Static_add_Void_UnityAction_3_StatusIcon_Stat_Stat_0;

	// Token: 0x04002B56 RID: 11094
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnStatusIconChanged_Public_Static_rem_Void_UnityAction_3_StatusIcon_Stat_Stat_0;

	// Token: 0x04002B57 RID: 11095
	private static readonly IntPtr NativeMethodInfoPtr_InvokeStatusIconChanged_Public_Static_Void_StatusIcon_Stat_Stat_0;

	// Token: 0x04002B58 RID: 11096
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityDisplayUpdated_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B59 RID: 11097
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityDisplayUpdated_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B5A RID: 11098
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityDisplayUpdated_Public_Static_Void_Entity_0;

	// Token: 0x04002B5B RID: 11099
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityFocus_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B5C RID: 11100
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityFocus_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B5D RID: 11101
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityFocus_Public_Static_Void_Entity_0;

	// Token: 0x04002B5E RID: 11102
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityEnterPocket_Public_Static_add_Void_UnityAction_2_Entity_CardPocket_0;

	// Token: 0x04002B5F RID: 11103
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityEnterPocket_Public_Static_rem_Void_UnityAction_2_Entity_CardPocket_0;

	// Token: 0x04002B60 RID: 11104
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityEnterPocket_Public_Static_Void_Entity_CardPocket_0;

	// Token: 0x04002B61 RID: 11105
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityEnterBackpack_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B62 RID: 11106
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityEnterBackpack_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B63 RID: 11107
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityEnterBackpack_Public_Static_Void_Entity_0;

	// Token: 0x04002B64 RID: 11108
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityChangePhase_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B65 RID: 11109
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityChangePhase_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B66 RID: 11110
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityChangePhase_Public_Static_Void_Entity_0;

	// Token: 0x04002B67 RID: 11111
	private static readonly IntPtr NativeMethodInfoPtr_add_OnNoomlinShow_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B68 RID: 11112
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnNoomlinShow_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B69 RID: 11113
	private static readonly IntPtr NativeMethodInfoPtr_InvokeNoomlinShow_Public_Static_Void_Entity_0;

	// Token: 0x04002B6A RID: 11114
	private static readonly IntPtr NativeMethodInfoPtr_add_OnNoomlinUsed_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B6B RID: 11115
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnNoomlinUsed_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B6C RID: 11116
	private static readonly IntPtr NativeMethodInfoPtr_InvokeNoomlinUsed_Public_Static_Void_Entity_0;

	// Token: 0x04002B6D RID: 11117
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityFlipComplete_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B6E RID: 11118
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityFlipComplete_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002B6F RID: 11119
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityFlipComplete_Public_Static_Void_Entity_0;

	// Token: 0x04002B70 RID: 11120
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntitySummoned_Public_Static_add_Void_UnityAction_2_Entity_Entity_0;

	// Token: 0x04002B71 RID: 11121
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntitySummoned_Public_Static_rem_Void_UnityAction_2_Entity_Entity_0;

	// Token: 0x04002B72 RID: 11122
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntitySummoned_Public_Static_Void_Entity_Entity_0;

	// Token: 0x04002B73 RID: 11123
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityPing_Public_Static_add_Void_UnityAction_1_GameObject_0;

	// Token: 0x04002B74 RID: 11124
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityPing_Public_Static_rem_Void_UnityAction_1_GameObject_0;

	// Token: 0x04002B75 RID: 11125
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityPing_Public_Static_Void_GameObject_0;

	// Token: 0x04002B76 RID: 11126
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCheckRecycleAmount_Public_Static_add_Void_UnityActionRef_2_Entity_Int32_0;

	// Token: 0x04002B77 RID: 11127
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCheckRecycleAmount_Public_Static_rem_Void_UnityActionRef_2_Entity_Int32_0;

	// Token: 0x04002B78 RID: 11128
	private static readonly IntPtr NativeMethodInfoPtr_CheckRecycleAmount_Public_Static_Void_Entity_byref_Int32_0;

	// Token: 0x04002B79 RID: 11129
	private static readonly IntPtr NativeMethodInfoPtr_add_OnContainerHover_Public_Static_add_Void_UnityAction_1_CardContainer_0;

	// Token: 0x04002B7A RID: 11130
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnContainerHover_Public_Static_rem_Void_UnityAction_1_CardContainer_0;

	// Token: 0x04002B7B RID: 11131
	private static readonly IntPtr NativeMethodInfoPtr_InvokeContainerHover_Public_Static_Void_CardContainer_0;

	// Token: 0x04002B7C RID: 11132
	private static readonly IntPtr NativeMethodInfoPtr_add_OnContainerUnHover_Public_Static_add_Void_UnityAction_1_CardContainer_0;

	// Token: 0x04002B7D RID: 11133
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnContainerUnHover_Public_Static_rem_Void_UnityAction_1_CardContainer_0;

	// Token: 0x04002B7E RID: 11134
	private static readonly IntPtr NativeMethodInfoPtr_InvokeContainerUnHover_Public_Static_Void_CardContainer_0;

	// Token: 0x04002B7F RID: 11135
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSlotHover_Public_Static_add_Void_UnityAction_1_CardSlot_0;

	// Token: 0x04002B80 RID: 11136
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSlotHover_Public_Static_rem_Void_UnityAction_1_CardSlot_0;

	// Token: 0x04002B81 RID: 11137
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSlotHover_Public_Static_Void_CardSlot_0;

	// Token: 0x04002B82 RID: 11138
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSlotUnHover_Public_Static_add_Void_UnityAction_1_CardSlot_0;

	// Token: 0x04002B83 RID: 11139
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSlotUnHover_Public_Static_rem_Void_UnityAction_1_CardSlot_0;

	// Token: 0x04002B84 RID: 11140
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSlotUnHover_Public_Static_Void_CardSlot_0;

	// Token: 0x04002B85 RID: 11141
	private static readonly IntPtr NativeMethodInfoPtr_add_OnActionQueued_Public_Static_add_Void_UnityAction_1_PlayAction_0;

	// Token: 0x04002B86 RID: 11142
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnActionQueued_Public_Static_rem_Void_UnityAction_1_PlayAction_0;

	// Token: 0x04002B87 RID: 11143
	private static readonly IntPtr NativeMethodInfoPtr_InvokeActionQueued_Public_Static_Void_PlayAction_0;

	// Token: 0x04002B88 RID: 11144
	private static readonly IntPtr NativeMethodInfoPtr_add_OnActionPerform_Public_Static_add_Void_UnityAction_1_PlayAction_0;

	// Token: 0x04002B89 RID: 11145
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnActionPerform_Public_Static_rem_Void_UnityAction_1_PlayAction_0;

	// Token: 0x04002B8A RID: 11146
	private static readonly IntPtr NativeMethodInfoPtr_InvokeActionPerform_Public_Static_Void_PlayAction_0;

	// Token: 0x04002B8B RID: 11147
	private static readonly IntPtr NativeMethodInfoPtr_add_OnActionFinished_Public_Static_add_Void_UnityAction_1_PlayAction_0;

	// Token: 0x04002B8C RID: 11148
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnActionFinished_Public_Static_rem_Void_UnityAction_1_PlayAction_0;

	// Token: 0x04002B8D RID: 11149
	private static readonly IntPtr NativeMethodInfoPtr_InvokeActionFinished_Public_Static_Void_PlayAction_0;

	// Token: 0x04002B8E RID: 11150
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCheckAction_Public_Static_add_Void_UnityActionRef_2_PlayAction_Boolean_0;

	// Token: 0x04002B8F RID: 11151
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCheckAction_Public_Static_rem_Void_UnityActionRef_2_PlayAction_Boolean_0;

	// Token: 0x04002B90 RID: 11152
	private static readonly IntPtr NativeMethodInfoPtr_CheckAction_Public_Static_Boolean_PlayAction_0;

	// Token: 0x04002B91 RID: 11153
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAbilityTargetAdd_Public_Static_add_Void_UnityAction_1_CardContainer_0;

	// Token: 0x04002B92 RID: 11154
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAbilityTargetAdd_Public_Static_rem_Void_UnityAction_1_CardContainer_0;

	// Token: 0x04002B93 RID: 11155
	private static readonly IntPtr NativeMethodInfoPtr_InvokeAbilityTargetAdd_Public_Static_Void_CardContainer_0;

	// Token: 0x04002B94 RID: 11156
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAbilityTargetRemove_Public_Static_add_Void_UnityAction_1_CardContainer_0;

	// Token: 0x04002B95 RID: 11157
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAbilityTargetRemove_Public_Static_rem_Void_UnityAction_1_CardContainer_0;

	// Token: 0x04002B96 RID: 11158
	private static readonly IntPtr NativeMethodInfoPtr_InvokeAbilityTargetRemove_Public_Static_Void_CardContainer_0;

	// Token: 0x04002B97 RID: 11159
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCardDraw_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002B98 RID: 11160
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCardDraw_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002B99 RID: 11161
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCardDraw_Public_Static_Void_Int32_0;

	// Token: 0x04002B9A RID: 11162
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCardDrawEnd_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002B9B RID: 11163
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCardDrawEnd_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002B9C RID: 11164
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCardDrawEnd_Public_Static_Void_0;

	// Token: 0x04002B9D RID: 11165
	private static readonly IntPtr NativeMethodInfoPtr_add_PreBattleSetUp_Public_Static_add_Void_UnityAction_1_CampaignNode_0;

	// Token: 0x04002B9E RID: 11166
	private static readonly IntPtr NativeMethodInfoPtr_remove_PreBattleSetUp_Public_Static_rem_Void_UnityAction_1_CampaignNode_0;

	// Token: 0x04002B9F RID: 11167
	private static readonly IntPtr NativeMethodInfoPtr_InvokePreBattleSetUp_Public_Static_Void_CampaignNode_0;

	// Token: 0x04002BA0 RID: 11168
	private static readonly IntPtr NativeMethodInfoPtr_add_PostBattleSetUp_Public_Static_add_Void_UnityAction_1_CampaignNode_0;

	// Token: 0x04002BA1 RID: 11169
	private static readonly IntPtr NativeMethodInfoPtr_remove_PostBattleSetUp_Public_Static_rem_Void_UnityAction_1_CampaignNode_0;

	// Token: 0x04002BA2 RID: 11170
	private static readonly IntPtr NativeMethodInfoPtr_InvokePostBattleSetUp_Public_Static_Void_CampaignNode_0;

	// Token: 0x04002BA3 RID: 11171
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattlePhaseStart_Public_Static_add_Void_UnityAction_1_Phase_0;

	// Token: 0x04002BA4 RID: 11172
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattlePhaseStart_Public_Static_rem_Void_UnityAction_1_Phase_0;

	// Token: 0x04002BA5 RID: 11173
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattlePhaseStart_Public_Static_Void_Phase_0;

	// Token: 0x04002BA6 RID: 11174
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleStart_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002BA7 RID: 11175
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleStart_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002BA8 RID: 11176
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleStart_Public_Static_Void_0;

	// Token: 0x04002BA9 RID: 11177
	private static readonly IntPtr NativeMethodInfoPtr_add_PreBattleEnd_Public_Static_add_Void_AsyncAction_0;

	// Token: 0x04002BAA RID: 11178
	private static readonly IntPtr NativeMethodInfoPtr_remove_PreBattleEnd_Public_Static_rem_Void_AsyncAction_0;

	// Token: 0x04002BAB RID: 11179
	private static readonly IntPtr NativeMethodInfoPtr_InvokePreBattleEnd_Public_Static_IEnumerator_0;

	// Token: 0x04002BAC RID: 11180
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleEnd_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002BAD RID: 11181
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleEnd_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002BAE RID: 11182
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleEnd_Public_Static_Void_0;

	// Token: 0x04002BAF RID: 11183
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleWinPreRewards_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002BB0 RID: 11184
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleWinPreRewards_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002BB1 RID: 11185
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleWinPreRewards_Public_Static_Void_0;

	// Token: 0x04002BB2 RID: 11186
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleWin_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002BB3 RID: 11187
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleWin_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002BB4 RID: 11188
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleWin_Public_Static_Void_0;

	// Token: 0x04002BB5 RID: 11189
	private static readonly IntPtr NativeMethodInfoPtr_add_PostBattle_Public_Static_add_Void_UnityAction_1_CampaignNode_0;

	// Token: 0x04002BB6 RID: 11190
	private static readonly IntPtr NativeMethodInfoPtr_remove_PostBattle_Public_Static_rem_Void_UnityAction_1_CampaignNode_0;

	// Token: 0x04002BB7 RID: 11191
	private static readonly IntPtr NativeMethodInfoPtr_InvokePostBattle_Public_Static_Void_CampaignNode_0;

	// Token: 0x04002BB8 RID: 11192
	private static readonly IntPtr NativeMethodInfoPtr_add_OnStatusEffectCountDown_Public_Static_add_Void_UnityActionCheck_2_StatusEffectData_Int32_0;

	// Token: 0x04002BB9 RID: 11193
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnStatusEffectCountDown_Public_Static_rem_Void_UnityActionCheck_2_StatusEffectData_Int32_0;

	// Token: 0x04002BBA RID: 11194
	private static readonly IntPtr NativeMethodInfoPtr_InvokeStatusEffectCountDown_Public_Static_Void_StatusEffectData_byref_Int32_0;

	// Token: 0x04002BBB RID: 11195
	private static readonly IntPtr NativeMethodInfoPtr_add_OnStatusEffectApplied_Public_Static_add_Void_UnityAction_1_StatusEffectApply_0;

	// Token: 0x04002BBC RID: 11196
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnStatusEffectApplied_Public_Static_rem_Void_UnityAction_1_StatusEffectApply_0;

	// Token: 0x04002BBD RID: 11197
	private static readonly IntPtr NativeMethodInfoPtr_InvokeStatusEffectApplied_Public_Static_Void_StatusEffectApply_0;

	// Token: 0x04002BBE RID: 11198
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPreProcessUnits_Public_Static_add_Void_UnityAction_1_Character_0;

	// Token: 0x04002BBF RID: 11199
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPreProcessUnits_Public_Static_rem_Void_UnityAction_1_Character_0;

	// Token: 0x04002BC0 RID: 11200
	private static readonly IntPtr NativeMethodInfoPtr_InvokePreProcessUnits_Public_Static_Void_Character_0;

	// Token: 0x04002BC1 RID: 11201
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPostProcessUnits_Public_Static_add_Void_UnityAction_1_Character_0;

	// Token: 0x04002BC2 RID: 11202
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPostProcessUnits_Public_Static_rem_Void_UnityAction_1_Character_0;

	// Token: 0x04002BC3 RID: 11203
	private static readonly IntPtr NativeMethodInfoPtr_InvokePostProcessUnits_Public_Static_Void_Character_0;

	// Token: 0x04002BC4 RID: 11204
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEntityCountDown_Public_Static_add_Void_UnityActionCheck_2_Entity_Int32_0;

	// Token: 0x04002BC5 RID: 11205
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEntityCountDown_Public_Static_rem_Void_UnityActionCheck_2_Entity_Int32_0;

	// Token: 0x04002BC6 RID: 11206
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEntityCountDown_Public_Static_Void_Entity_byref_Int32_0;

	// Token: 0x04002BC7 RID: 11207
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattlePreTurnStart_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BC8 RID: 11208
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattlePreTurnStart_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BC9 RID: 11209
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattlePreTurnStart_Public_Static_Void_Int32_0;

	// Token: 0x04002BCA RID: 11210
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleTurnStart_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BCB RID: 11211
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleTurnStart_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BCC RID: 11212
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleTurnStart_Public_Static_Void_Int32_0;

	// Token: 0x04002BCD RID: 11213
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleTurnEnd_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BCE RID: 11214
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleTurnEnd_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BCF RID: 11215
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleTurnEnd_Public_Static_Void_Int32_0;

	// Token: 0x04002BD0 RID: 11216
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMinibossIntro_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002BD1 RID: 11217
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMinibossIntro_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002BD2 RID: 11218
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMinibossIntro_Public_Static_Void_Entity_0;

	// Token: 0x04002BD3 RID: 11219
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMinibossIntroDone_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002BD4 RID: 11220
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMinibossIntroDone_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002BD5 RID: 11221
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMinibossIntroDone_Public_Static_Void_Entity_0;

	// Token: 0x04002BD6 RID: 11222
	private static readonly IntPtr NativeMethodInfoPtr_add_OnKillCombo_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BD7 RID: 11223
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnKillCombo_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BD8 RID: 11224
	private static readonly IntPtr NativeMethodInfoPtr_InvokeKillCombo_Public_Static_Void_Int32_0;

	// Token: 0x04002BD9 RID: 11225
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRedrawBellHit_Public_Static_add_Void_UnityAction_1_RedrawBellSystem_0;

	// Token: 0x04002BDA RID: 11226
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRedrawBellHit_Public_Static_rem_Void_UnityAction_1_RedrawBellSystem_0;

	// Token: 0x04002BDB RID: 11227
	private static readonly IntPtr NativeMethodInfoPtr_InvokeRedrawBellHit_Public_Static_Void_RedrawBellSystem_0;

	// Token: 0x04002BDC RID: 11228
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRedrawBellRevealed_Public_Static_add_Void_UnityAction_1_RedrawBellSystem_0;

	// Token: 0x04002BDD RID: 11229
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRedrawBellRevealed_Public_Static_rem_Void_UnityAction_1_RedrawBellSystem_0;

	// Token: 0x04002BDE RID: 11230
	private static readonly IntPtr NativeMethodInfoPtr_InvokeRedrawBellRevealed_Public_Static_Void_RedrawBellSystem_0;

	// Token: 0x04002BDF RID: 11231
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCardInjured_Public_Static_add_Void_UnityAction_1_CardData_0;

	// Token: 0x04002BE0 RID: 11232
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCardInjured_Public_Static_rem_Void_UnityAction_1_CardData_0;

	// Token: 0x04002BE1 RID: 11233
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCardInjured_Public_Static_Void_CardData_0;

	// Token: 0x04002BE2 RID: 11234
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleStateBuild_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002BE3 RID: 11235
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleStateBuild_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002BE4 RID: 11236
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleStateBuild_Public_Static_Void_0;

	// Token: 0x04002BE5 RID: 11237
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleStateBuilt_Public_Static_add_Void_UnityAction_1_BattleSaveData_0;

	// Token: 0x04002BE6 RID: 11238
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleStateBuilt_Public_Static_rem_Void_UnityAction_1_BattleSaveData_0;

	// Token: 0x04002BE7 RID: 11239
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleStateBuilt_Public_Static_Void_BattleSaveData_0;

	// Token: 0x04002BE8 RID: 11240
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCharacterActionPerformed_Public_Static_add_Void_UnityAction_1_Character_0;

	// Token: 0x04002BE9 RID: 11241
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCharacterActionPerformed_Public_Static_rem_Void_UnityAction_1_Character_0;

	// Token: 0x04002BEA RID: 11242
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCharacterActionPerformed_Public_Static_Void_Character_0;

	// Token: 0x04002BEB RID: 11243
	private static readonly IntPtr NativeMethodInfoPtr_add_OnWaveDeployerPreCountDown_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BEC RID: 11244
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnWaveDeployerPreCountDown_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BED RID: 11245
	private static readonly IntPtr NativeMethodInfoPtr_InvokeWaveDeployerPreCountDown_Public_Static_Void_Int32_0;

	// Token: 0x04002BEE RID: 11246
	private static readonly IntPtr NativeMethodInfoPtr_add_OnWaveDeployerPostCountDown_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BEF RID: 11247
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnWaveDeployerPostCountDown_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002BF0 RID: 11248
	private static readonly IntPtr NativeMethodInfoPtr_InvokeWaveDeployerPostCountDown_Public_Static_Void_Int32_0;

	// Token: 0x04002BF1 RID: 11249
	private static readonly IntPtr NativeMethodInfoPtr_add_OnWaveDeployerEarlyDeploy_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002BF2 RID: 11250
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnWaveDeployerEarlyDeploy_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002BF3 RID: 11251
	private static readonly IntPtr NativeMethodInfoPtr_InvokeWaveDeployerEarlyDeploy_Public_Static_Void_0;

	// Token: 0x04002BF4 RID: 11252
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMapPathReveal_Public_Static_add_Void_UnityAction_1_Single_0;

	// Token: 0x04002BF5 RID: 11253
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMapPathReveal_Public_Static_rem_Void_UnityAction_1_Single_0;

	// Token: 0x04002BF6 RID: 11254
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMapPathReveal_Public_Static_Void_Single_0;

	// Token: 0x04002BF7 RID: 11255
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMapNodeReveal_Public_Static_add_Void_UnityAction_1_MapNode_0;

	// Token: 0x04002BF8 RID: 11256
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMapNodeReveal_Public_Static_rem_Void_UnityAction_1_MapNode_0;

	// Token: 0x04002BF9 RID: 11257
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMapNodeReveal_Public_Static_Void_MapNode_0;

	// Token: 0x04002BFA RID: 11258
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMapNodeSelect_Public_Static_add_Void_UnityAction_1_MapNode_0;

	// Token: 0x04002BFB RID: 11259
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMapNodeSelect_Public_Static_rem_Void_UnityAction_1_MapNode_0;

	// Token: 0x04002BFC RID: 11260
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMapNodeSelect_Public_Static_Void_MapNode_0;

	// Token: 0x04002BFD RID: 11261
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMapNodeHover_Public_Static_add_Void_UnityAction_1_MapNode_0;

	// Token: 0x04002BFE RID: 11262
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMapNodeHover_Public_Static_rem_Void_UnityAction_1_MapNode_0;

	// Token: 0x04002BFF RID: 11263
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMapNodeHover_Public_Static_Void_MapNode_0;

	// Token: 0x04002C00 RID: 11264
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMapNodeUnHover_Public_Static_add_Void_UnityAction_1_MapNode_0;

	// Token: 0x04002C01 RID: 11265
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMapNodeUnHover_Public_Static_rem_Void_UnityAction_1_MapNode_0;

	// Token: 0x04002C02 RID: 11266
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMapNodeUnHover_Public_Static_Void_MapNode_0;

	// Token: 0x04002C03 RID: 11267
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTownUnlock_Public_Static_add_Void_UnityAction_1_UnlockData_0;

	// Token: 0x04002C04 RID: 11268
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTownUnlock_Public_Static_rem_Void_UnityAction_1_UnlockData_0;

	// Token: 0x04002C05 RID: 11269
	private static readonly IntPtr NativeMethodInfoPtr_InvokeTownUnlock_Public_Static_Void_UnlockData_0;

	// Token: 0x04002C06 RID: 11270
	private static readonly IntPtr NativeMethodInfoPtr_add_OnShopItemHover_Public_Static_add_Void_UnityAction_1_ShopItem_0;

	// Token: 0x04002C07 RID: 11271
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnShopItemHover_Public_Static_rem_Void_UnityAction_1_ShopItem_0;

	// Token: 0x04002C08 RID: 11272
	private static readonly IntPtr NativeMethodInfoPtr_InvokeShopItemHover_Public_Static_Void_ShopItem_0;

	// Token: 0x04002C09 RID: 11273
	private static readonly IntPtr NativeMethodInfoPtr_add_OnShopItemUnHover_Public_Static_add_Void_UnityAction_1_ShopItem_0;

	// Token: 0x04002C0A RID: 11274
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnShopItemUnHover_Public_Static_rem_Void_UnityAction_1_ShopItem_0;

	// Token: 0x04002C0B RID: 11275
	private static readonly IntPtr NativeMethodInfoPtr_InvokeShopItemUnHover_Public_Static_Void_ShopItem_0;

	// Token: 0x04002C0C RID: 11276
	private static readonly IntPtr NativeMethodInfoPtr_add_OnShopItemPurchase_Public_Static_add_Void_UnityAction_1_ShopItem_0;

	// Token: 0x04002C0D RID: 11277
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnShopItemPurchase_Public_Static_rem_Void_UnityAction_1_ShopItem_0;

	// Token: 0x04002C0E RID: 11278
	private static readonly IntPtr NativeMethodInfoPtr_InvokeShopItemPurchase_Public_Static_Void_ShopItem_0;

	// Token: 0x04002C0F RID: 11279
	private static readonly IntPtr NativeMethodInfoPtr_add_OnShopItemHaggled_Public_Static_add_Void_UnityAction_1_ShopItem_0;

	// Token: 0x04002C10 RID: 11280
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnShopItemHaggled_Public_Static_rem_Void_UnityAction_1_ShopItem_0;

	// Token: 0x04002C11 RID: 11281
	private static readonly IntPtr NativeMethodInfoPtr_InvokeShopItemHaggled_Public_Static_Void_ShopItem_0;

	// Token: 0x04002C12 RID: 11282
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPopupCreated_Public_Static_add_Void_UnityAction_2_KeywordData_CardPopUpPanel_0;

	// Token: 0x04002C13 RID: 11283
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPopupCreated_Public_Static_rem_Void_UnityAction_2_KeywordData_CardPopUpPanel_0;

	// Token: 0x04002C14 RID: 11284
	private static readonly IntPtr NativeMethodInfoPtr_InvokePopupPanelCreated_Public_Static_Void_KeywordData_CardPopUpPanel_0;

	// Token: 0x04002C15 RID: 11285
	private static readonly IntPtr NativeMethodInfoPtr_add_OnButtonHover_Public_Static_add_Void_UnityAction_1_ButtonType_0;

	// Token: 0x04002C16 RID: 11286
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnButtonHover_Public_Static_rem_Void_UnityAction_1_ButtonType_0;

	// Token: 0x04002C17 RID: 11287
	private static readonly IntPtr NativeMethodInfoPtr_InvokeButtonHover_Public_Static_Void_ButtonType_0;

	// Token: 0x04002C18 RID: 11288
	private static readonly IntPtr NativeMethodInfoPtr_add_OnButtonPress_Public_Static_add_Void_UnityAction_1_ButtonType_0;

	// Token: 0x04002C19 RID: 11289
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnButtonPress_Public_Static_rem_Void_UnityAction_1_ButtonType_0;

	// Token: 0x04002C1A RID: 11290
	private static readonly IntPtr NativeMethodInfoPtr_InvokeButtonPress_Public_Static_Void_ButtonType_0;

	// Token: 0x04002C1B RID: 11291
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAudioVolumeChange_Public_Static_add_Void_UnityAction_2_String_Single_0;

	// Token: 0x04002C1C RID: 11292
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAudioVolumeChange_Public_Static_rem_Void_UnityAction_2_String_Single_0;

	// Token: 0x04002C1D RID: 11293
	private static readonly IntPtr NativeMethodInfoPtr_InvokeAudioVolumeChange_Public_Static_Void_String_Single_0;

	// Token: 0x04002C1E RID: 11294
	private static readonly IntPtr NativeMethodInfoPtr_add_OnAudioPitchChange_Public_Static_add_Void_UnityAction_2_String_Single_0;

	// Token: 0x04002C1F RID: 11295
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnAudioPitchChange_Public_Static_rem_Void_UnityAction_2_String_Single_0;

	// Token: 0x04002C20 RID: 11296
	private static readonly IntPtr NativeMethodInfoPtr_InvokeAudioPitchChange_Public_Static_Void_String_Single_0;

	// Token: 0x04002C21 RID: 11297
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBombardShoot_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002C22 RID: 11298
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBombardShoot_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002C23 RID: 11299
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBombardShoot_Public_Static_Void_Entity_0;

	// Token: 0x04002C24 RID: 11300
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBombardRocketFall_Public_Static_add_Void_UnityAction_1_BombardRocket_0;

	// Token: 0x04002C25 RID: 11301
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBombardRocketFall_Public_Static_rem_Void_UnityAction_1_BombardRocket_0;

	// Token: 0x04002C26 RID: 11302
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBombardRocketFall_Public_Static_Void_BombardRocket_0;

	// Token: 0x04002C27 RID: 11303
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBombardRocketExplode_Public_Static_add_Void_UnityAction_1_BombardRocket_0;

	// Token: 0x04002C28 RID: 11304
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBombardRocketExplode_Public_Static_rem_Void_UnityAction_1_BombardRocket_0;

	// Token: 0x04002C29 RID: 11305
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBombardRocketExplode_Public_Static_Void_BombardRocket_0;

	// Token: 0x04002C2A RID: 11306
	private static readonly IntPtr NativeMethodInfoPtr_add_OnProgressStart_Public_Static_add_Void_UnityAction_1_Single_0;

	// Token: 0x04002C2B RID: 11307
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnProgressStart_Public_Static_rem_Void_UnityAction_1_Single_0;

	// Token: 0x04002C2C RID: 11308
	private static readonly IntPtr NativeMethodInfoPtr_InvokeProgressStart_Public_Static_Void_Single_0;

	// Token: 0x04002C2D RID: 11309
	private static readonly IntPtr NativeMethodInfoPtr_add_OnProgressUpdate_Public_Static_add_Void_UnityAction_1_Single_0;

	// Token: 0x04002C2E RID: 11310
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnProgressUpdate_Public_Static_rem_Void_UnityAction_1_Single_0;

	// Token: 0x04002C2F RID: 11311
	private static readonly IntPtr NativeMethodInfoPtr_InvokeProgressUpdate_Public_Static_Void_Single_0;

	// Token: 0x04002C30 RID: 11312
	private static readonly IntPtr NativeMethodInfoPtr_add_OnProgressStop_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C31 RID: 11313
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnProgressStop_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C32 RID: 11314
	private static readonly IntPtr NativeMethodInfoPtr_InvokeProgressStop_Public_Static_Void_0;

	// Token: 0x04002C33 RID: 11315
	private static readonly IntPtr NativeMethodInfoPtr_add_OnProgressDing_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C34 RID: 11316
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnProgressDing_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C35 RID: 11317
	private static readonly IntPtr NativeMethodInfoPtr_InvokeProgressDing_Public_Static_Void_0;

	// Token: 0x04002C36 RID: 11318
	private static readonly IntPtr NativeMethodInfoPtr_add_OnProgressBlip_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C37 RID: 11319
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnProgressBlip_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C38 RID: 11320
	private static readonly IntPtr NativeMethodInfoPtr_InvokeProgressBlip_Public_Static_Void_0;

	// Token: 0x04002C39 RID: 11321
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSaveSystemEnabled_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C3A RID: 11322
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSaveSystemEnabled_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C3B RID: 11323
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSaveSystemEnabled_Public_Static_Void_0;

	// Token: 0x04002C3C RID: 11324
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSaveSystemDisabled_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C3D RID: 11325
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSaveSystemDisabled_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C3E RID: 11326
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSaveSystemDisabled_Public_Static_Void_0;

	// Token: 0x04002C3F RID: 11327
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSaveSystemProfileChanged_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C40 RID: 11328
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSaveSystemProfileChanged_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C41 RID: 11329
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSaveSystemProfileChanged_Public_Static_Void_0;

	// Token: 0x04002C42 RID: 11330
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignSaved_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C43 RID: 11331
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignSaved_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C44 RID: 11332
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignSaved_Public_Static_Void_0;

	// Token: 0x04002C45 RID: 11333
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignLoaded_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C46 RID: 11334
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignLoaded_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C47 RID: 11335
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignLoaded_Public_Static_Void_0;

	// Token: 0x04002C48 RID: 11336
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignDeleted_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C49 RID: 11337
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignDeleted_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C4A RID: 11338
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignDeleted_Public_Static_Void_0;

	// Token: 0x04002C4B RID: 11339
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleSaved_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C4C RID: 11340
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleSaved_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C4D RID: 11341
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleSaved_Public_Static_Void_0;

	// Token: 0x04002C4E RID: 11342
	private static readonly IntPtr NativeMethodInfoPtr_add_OnBattleLoaded_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C4F RID: 11343
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnBattleLoaded_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C50 RID: 11344
	private static readonly IntPtr NativeMethodInfoPtr_InvokeBattleLoaded_Public_Static_Void_0;

	// Token: 0x04002C51 RID: 11345
	private static readonly IntPtr NativeMethodInfoPtr_add_OnGameStart_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C52 RID: 11346
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameStart_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C53 RID: 11347
	private static readonly IntPtr NativeMethodInfoPtr_InvokeGameStart_Public_Static_Void_0;

	// Token: 0x04002C54 RID: 11348
	private static readonly IntPtr NativeMethodInfoPtr_add_OnGameEnd_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C55 RID: 11349
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnGameEnd_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C56 RID: 11350
	private static readonly IntPtr NativeMethodInfoPtr_InvokeGameEnd_Public_Static_Void_0;

	// Token: 0x04002C57 RID: 11351
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignStart_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C58 RID: 11352
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignStart_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C59 RID: 11353
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignStart_Public_Static_Void_0;

	// Token: 0x04002C5A RID: 11354
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignFinal_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C5B RID: 11355
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignFinal_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C5C RID: 11356
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignFinal_Public_Static_Void_0;

	// Token: 0x04002C5D RID: 11357
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignEnd_Public_Static_add_Void_UnityAction_3_Result_CampaignStats_PlayerData_0;

	// Token: 0x04002C5E RID: 11358
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignEnd_Public_Static_rem_Void_UnityAction_3_Result_CampaignStats_PlayerData_0;

	// Token: 0x04002C5F RID: 11359
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignEnd_Public_Static_Void_Result_CampaignStats_PlayerData_0;

	// Token: 0x04002C60 RID: 11360
	private static readonly IntPtr NativeMethodInfoPtr_add_OnOverallStatsSaved_Public_Static_add_Void_UnityAction_1_CampaignStats_0;

	// Token: 0x04002C61 RID: 11361
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnOverallStatsSaved_Public_Static_rem_Void_UnityAction_1_CampaignStats_0;

	// Token: 0x04002C62 RID: 11362
	private static readonly IntPtr NativeMethodInfoPtr_InvokeOverallStatsSaved_Public_Static_Void_CampaignStats_0;

	// Token: 0x04002C63 RID: 11363
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignDataCreated_Public_Static_add_Void_UnityAction_1_CampaignData_0;

	// Token: 0x04002C64 RID: 11364
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignDataCreated_Public_Static_rem_Void_UnityAction_1_CampaignData_0;

	// Token: 0x04002C65 RID: 11365
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignDataCreated_Public_Static_Void_CampaignData_0;

	// Token: 0x04002C66 RID: 11366
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignPreInit_Public_Static_add_Void_RoutineAction_0;

	// Token: 0x04002C67 RID: 11367
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignPreInit_Public_Static_rem_Void_RoutineAction_0;

	// Token: 0x04002C68 RID: 11368
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignPreInit_Public_Static_IEnumerator_0;

	// Token: 0x04002C69 RID: 11369
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignInit_Public_Static_add_Void_RoutineAction_0;

	// Token: 0x04002C6A RID: 11370
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignInit_Public_Static_rem_Void_RoutineAction_0;

	// Token: 0x04002C6B RID: 11371
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignInit_Public_Static_IEnumerator_0;

	// Token: 0x04002C6C RID: 11372
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPreCampaignPopulate_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002C6D RID: 11373
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPreCampaignPopulate_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002C6E RID: 11374
	private static readonly IntPtr NativeMethodInfoPtr_InvokePreCampaignPopulate_Public_Static_Void_0;

	// Token: 0x04002C6F RID: 11375
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignNodesCreated_Public_Static_add_Void_UnityActionRef1_2_List_1_Node_Vector2_0;

	// Token: 0x04002C70 RID: 11376
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignNodesCreated_Public_Static_rem_Void_UnityActionRef1_2_List_1_Node_Vector2_0;

	// Token: 0x04002C71 RID: 11377
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignNodesCreated_Public_Static_Void_byref_List_1_Node_Vector2_0;

	// Token: 0x04002C72 RID: 11378
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignLoadPreset_Public_Static_add_Void_UnityActionRef_1_Il2CppStringArray_0;

	// Token: 0x04002C73 RID: 11379
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignLoadPreset_Public_Static_rem_Void_UnityActionRef_1_Il2CppStringArray_0;

	// Token: 0x04002C74 RID: 11380
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignLoadPreset_Public_Static_Void_byref_Il2CppStringArray_0;

	// Token: 0x04002C75 RID: 11381
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCampaignGenerated_Public_Static_add_Void_AsyncAction_0;

	// Token: 0x04002C76 RID: 11382
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCampaignGenerated_Public_Static_rem_Void_AsyncAction_0;

	// Token: 0x04002C77 RID: 11383
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCampaignGenerated_Public_Static_IEnumerator_0;

	// Token: 0x04002C78 RID: 11384
	private static readonly IntPtr NativeMethodInfoPtr_add_OnStatChanged_Public_Static_add_Void_UnityAction_4_String_String_Int32_Int32_0;

	// Token: 0x04002C79 RID: 11385
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnStatChanged_Public_Static_rem_Void_UnityAction_4_String_String_Int32_Int32_0;

	// Token: 0x04002C7A RID: 11386
	private static readonly IntPtr NativeMethodInfoPtr_InvokeStatChanged_Public_Static_Void_String_String_Int32_Int32_0;

	// Token: 0x04002C7B RID: 11387
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUpgradeGained_Public_Static_add_Void_UnityAction_1_CardUpgradeData_0;

	// Token: 0x04002C7C RID: 11388
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpgradeGained_Public_Static_rem_Void_UnityAction_1_CardUpgradeData_0;

	// Token: 0x04002C7D RID: 11389
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUpgradeGained_Public_Static_Void_CardUpgradeData_0;

	// Token: 0x04002C7E RID: 11390
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUpgradeAssign_Public_Static_add_Void_UnityAction_2_Entity_CardUpgradeData_0;

	// Token: 0x04002C7F RID: 11391
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpgradeAssign_Public_Static_rem_Void_UnityAction_2_Entity_CardUpgradeData_0;

	// Token: 0x04002C80 RID: 11392
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUpgradeAssign_Public_Static_Void_Entity_CardUpgradeData_0;

	// Token: 0x04002C81 RID: 11393
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUpgradeHover_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0;

	// Token: 0x04002C82 RID: 11394
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpgradeHover_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0;

	// Token: 0x04002C83 RID: 11395
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUpgradeHover_Public_Static_Void_UpgradeDisplay_0;

	// Token: 0x04002C84 RID: 11396
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUpgradePickup_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0;

	// Token: 0x04002C85 RID: 11397
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpgradePickup_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0;

	// Token: 0x04002C86 RID: 11398
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUpgradePickup_Public_Static_Void_UpgradeDisplay_0;

	// Token: 0x04002C87 RID: 11399
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUpgradeDrop_Public_Static_add_Void_UnityAction_1_UpgradeDisplay_0;

	// Token: 0x04002C88 RID: 11400
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpgradeDrop_Public_Static_rem_Void_UnityAction_1_UpgradeDisplay_0;

	// Token: 0x04002C89 RID: 11401
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUpgradeDrop_Public_Static_Void_UpgradeDisplay_0;

	// Token: 0x04002C8A RID: 11402
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUpdateInputSystem_Public_Static_add_Void_UnityAction_1_Boolean_0;

	// Token: 0x04002C8B RID: 11403
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUpdateInputSystem_Public_Static_rem_Void_UnityAction_1_Boolean_0;

	// Token: 0x04002C8C RID: 11404
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUpdateInputSystem_Public_Static_Void_Boolean_0;

	// Token: 0x04002C8D RID: 11405
	private static readonly IntPtr NativeMethodInfoPtr_add_OnScreenShake_Public_Static_add_Void_UnityAction_2_Single_Nullable_1_Single_0;

	// Token: 0x04002C8E RID: 11406
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnScreenShake_Public_Static_rem_Void_UnityAction_2_Single_Nullable_1_Single_0;

	// Token: 0x04002C8F RID: 11407
	private static readonly IntPtr NativeMethodInfoPtr_InvokeScreenShake_Public_Static_Void_Single_Nullable_1_Single_0;

	// Token: 0x04002C90 RID: 11408
	private static readonly IntPtr NativeMethodInfoPtr_add_OnScreenRumble_Public_Static_add_Void_UnityAction_6_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04002C91 RID: 11409
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnScreenRumble_Public_Static_rem_Void_UnityAction_6_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04002C92 RID: 11410
	private static readonly IntPtr NativeMethodInfoPtr_InvokeScreenRumble_Public_Static_Void_Single_Single_Single_Single_Single_Single_0;

	// Token: 0x04002C93 RID: 11411
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCameraAnimation_Public_Static_add_Void_UnityAction_1_String_0;

	// Token: 0x04002C94 RID: 11412
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCameraAnimation_Public_Static_rem_Void_UnityAction_1_String_0;

	// Token: 0x04002C95 RID: 11413
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCameraAnimation_Public_Static_Void_String_0;

	// Token: 0x04002C96 RID: 11414
	private static readonly IntPtr NativeMethodInfoPtr_add_OnDropGold_Public_Static_add_Void_UnityAction_4_Int32_String_Character_Vector3_0;

	// Token: 0x04002C97 RID: 11415
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnDropGold_Public_Static_rem_Void_UnityAction_4_Int32_String_Character_Vector3_0;

	// Token: 0x04002C98 RID: 11416
	private static readonly IntPtr NativeMethodInfoPtr_InvokeDropGold_Public_Static_Void_Int32_String_Character_Vector3_0;

	// Token: 0x04002C99 RID: 11417
	private static readonly IntPtr NativeMethodInfoPtr_add_OnGoldFlyToBag_Public_Static_add_Void_UnityAction_3_Int32_Character_Vector3_0;

	// Token: 0x04002C9A RID: 11418
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnGoldFlyToBag_Public_Static_rem_Void_UnityAction_3_Int32_Character_Vector3_0;

	// Token: 0x04002C9B RID: 11419
	private static readonly IntPtr NativeMethodInfoPtr_InvokeGoldFlyToBag_Public_Static_Void_Int32_Character_Vector3_0;

	// Token: 0x04002C9C RID: 11420
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCollectGold_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002C9D RID: 11421
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCollectGold_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002C9E RID: 11422
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCollectGold_Public_Static_Void_Int32_0;

	// Token: 0x04002C9F RID: 11423
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSpendGold_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002CA0 RID: 11424
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSpendGold_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002CA1 RID: 11425
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSpendGold_Public_Static_Void_Int32_0;

	// Token: 0x04002CA2 RID: 11426
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTimeScaleChange_Public_Static_add_Void_UnityAction_1_Single_0;

	// Token: 0x04002CA3 RID: 11427
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTimeScaleChange_Public_Static_rem_Void_UnityAction_1_Single_0;

	// Token: 0x04002CA4 RID: 11428
	private static readonly IntPtr NativeMethodInfoPtr_InvokeTimeScaleChange_Public_Static_Void_Single_0;

	// Token: 0x04002CA5 RID: 11429
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInspect_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002CA6 RID: 11430
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInspect_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002CA7 RID: 11431
	private static readonly IntPtr NativeMethodInfoPtr_InvokeInspect_Public_Static_Void_Entity_0;

	// Token: 0x04002CA8 RID: 11432
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInspectEnd_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002CA9 RID: 11433
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInspectEnd_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002CAA RID: 11434
	private static readonly IntPtr NativeMethodInfoPtr_InvokeInspectEnd_Public_Static_Void_Entity_0;

	// Token: 0x04002CAB RID: 11435
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInspectNewCard_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002CAC RID: 11436
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInspectNewCard_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002CAD RID: 11437
	private static readonly IntPtr NativeMethodInfoPtr_InvokeInspectNewCard_Public_Static_Void_Entity_0;

	// Token: 0x04002CAE RID: 11438
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCardControllerEnabled_Public_Static_add_Void_UnityAction_1_CardController_0;

	// Token: 0x04002CAF RID: 11439
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCardControllerEnabled_Public_Static_rem_Void_UnityAction_1_CardController_0;

	// Token: 0x04002CB0 RID: 11440
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCardControllerEnabled_Public_Static_Void_CardController_0;

	// Token: 0x04002CB1 RID: 11441
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCardControllerDisabled_Public_Static_add_Void_UnityAction_1_CardController_0;

	// Token: 0x04002CB2 RID: 11442
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCardControllerDisabled_Public_Static_rem_Void_UnityAction_1_CardController_0;

	// Token: 0x04002CB3 RID: 11443
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCardControllerDisabled_Public_Static_Void_CardController_0;

	// Token: 0x04002CB4 RID: 11444
	private static readonly IntPtr NativeMethodInfoPtr_add_OnDeckpackOpen_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CB5 RID: 11445
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnDeckpackOpen_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CB6 RID: 11446
	private static readonly IntPtr NativeMethodInfoPtr_InvokeDeckpackOpen_Public_Static_Void_0;

	// Token: 0x04002CB7 RID: 11447
	private static readonly IntPtr NativeMethodInfoPtr_add_OnDeckpackClose_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CB8 RID: 11448
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnDeckpackClose_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CB9 RID: 11449
	private static readonly IntPtr NativeMethodInfoPtr_InvokeDeckpackClose_Public_Static_Void_0;

	// Token: 0x04002CBA RID: 11450
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTransitionStart_Public_Static_add_Void_UnityAction_1_TransitionType_0;

	// Token: 0x04002CBB RID: 11451
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTransitionStart_Public_Static_rem_Void_UnityAction_1_TransitionType_0;

	// Token: 0x04002CBC RID: 11452
	private static readonly IntPtr NativeMethodInfoPtr_InvokeTransitionStart_Public_Static_Void_TransitionType_0;

	// Token: 0x04002CBD RID: 11453
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTransitionEnd_Public_Static_add_Void_UnityAction_1_TransitionType_0;

	// Token: 0x04002CBE RID: 11454
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTransitionEnd_Public_Static_rem_Void_UnityAction_1_TransitionType_0;

	// Token: 0x04002CBF RID: 11455
	private static readonly IntPtr NativeMethodInfoPtr_InvokeTransitionEnd_Public_Static_Void_TransitionType_0;

	// Token: 0x04002CC0 RID: 11456
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSetWeatherIntensity_Public_Static_add_Void_UnityAction_2_Single_Single_0;

	// Token: 0x04002CC1 RID: 11457
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSetWeatherIntensity_Public_Static_rem_Void_UnityAction_2_Single_Single_0;

	// Token: 0x04002CC2 RID: 11458
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSetWeatherIntensity_Public_Static_Void_Single_Single_0;

	// Token: 0x04002CC3 RID: 11459
	private static readonly IntPtr NativeMethodInfoPtr_add_OnGoldCounterStart_Public_Static_add_Void_UnityAction_2_GoldDisplay_Single_0;

	// Token: 0x04002CC4 RID: 11460
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnGoldCounterStart_Public_Static_rem_Void_UnityAction_2_GoldDisplay_Single_0;

	// Token: 0x04002CC5 RID: 11461
	private static readonly IntPtr NativeMethodInfoPtr_InvokeGoldCounterStart_Public_Static_Void_GoldDisplay_Single_0;

	// Token: 0x04002CC6 RID: 11462
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEventStart_Public_Static_add_Void_UnityAction_2_CampaignNode_EventRoutine_0;

	// Token: 0x04002CC7 RID: 11463
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEventStart_Public_Static_rem_Void_UnityAction_2_CampaignNode_EventRoutine_0;

	// Token: 0x04002CC8 RID: 11464
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEventStart_Public_Static_Void_CampaignNode_EventRoutine_0;

	// Token: 0x04002CC9 RID: 11465
	private static readonly IntPtr NativeMethodInfoPtr_add_OnEventPopulated_Public_Static_add_Void_UnityAction_1_EventRoutine_0;

	// Token: 0x04002CCA RID: 11466
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnEventPopulated_Public_Static_rem_Void_UnityAction_1_EventRoutine_0;

	// Token: 0x04002CCB RID: 11467
	private static readonly IntPtr NativeMethodInfoPtr_InvokeEventPopulated_Public_Static_Void_EventRoutine_0;

	// Token: 0x04002CCC RID: 11468
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMuncherDrag_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CCD RID: 11469
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMuncherDrag_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CCE RID: 11470
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMuncherDrag_Public_Static_Void_0;

	// Token: 0x04002CCF RID: 11471
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMuncherDragCancel_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CD0 RID: 11472
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMuncherDragCancel_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CD1 RID: 11473
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMuncherDragCancel_Public_Static_Void_0;

	// Token: 0x04002CD2 RID: 11474
	private static readonly IntPtr NativeMethodInfoPtr_add_OnMuncherFeed_Public_Static_add_Void_UnityAction_1_Entity_0;

	// Token: 0x04002CD3 RID: 11475
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnMuncherFeed_Public_Static_rem_Void_UnityAction_1_Entity_0;

	// Token: 0x04002CD4 RID: 11476
	private static readonly IntPtr NativeMethodInfoPtr_InvokeMuncherFeed_Public_Static_Void_Entity_0;

	// Token: 0x04002CD5 RID: 11477
	private static readonly IntPtr NativeMethodInfoPtr_add_OnSettingChanged_Public_Static_add_Void_UnityAction_2_String_Object_0;

	// Token: 0x04002CD6 RID: 11478
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnSettingChanged_Public_Static_rem_Void_UnityAction_2_String_Object_0;

	// Token: 0x04002CD7 RID: 11479
	private static readonly IntPtr NativeMethodInfoPtr_InvokeSettingChanged_Public_Static_Void_String_Object_0;

	// Token: 0x04002CD8 RID: 11480
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUINavigationReset_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CD9 RID: 11481
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUINavigationReset_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CDA RID: 11482
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUINavigationReset_Public_Static_Void_0;

	// Token: 0x04002CDB RID: 11483
	private static readonly IntPtr NativeMethodInfoPtr_add_OnUINavigation_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CDC RID: 11484
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnUINavigation_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CDD RID: 11485
	private static readonly IntPtr NativeMethodInfoPtr_InvokeUINavigation_Public_Static_Void_0;

	// Token: 0x04002CDE RID: 11486
	private static readonly IntPtr NativeMethodInfoPtr_add_OnButtonStyleChanged_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CDF RID: 11487
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnButtonStyleChanged_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CE0 RID: 11488
	private static readonly IntPtr NativeMethodInfoPtr_InvokeButtonStyleChanged_Public_Static_Void_0;

	// Token: 0x04002CE1 RID: 11489
	private static readonly IntPtr NativeMethodInfoPtr_add_OnControllerSwitched_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CE2 RID: 11490
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnControllerSwitched_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CE3 RID: 11491
	private static readonly IntPtr NativeMethodInfoPtr_InvokeControllerSwitched_Public_Static_Void_0;

	// Token: 0x04002CE4 RID: 11492
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCheckRename_Public_Static_add_Void_UnityActionRef_3_Entity_String_Boolean_0;

	// Token: 0x04002CE5 RID: 11493
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCheckRename_Public_Static_rem_Void_UnityActionRef_3_Entity_String_Boolean_0;

	// Token: 0x04002CE6 RID: 11494
	private static readonly IntPtr NativeMethodInfoPtr_CheckRename_Public_Static_Boolean_byref_Entity_byref_String_0;

	// Token: 0x04002CE7 RID: 11495
	private static readonly IntPtr NativeMethodInfoPtr_add_OnRename_Public_Static_add_Void_UnityAction_2_Entity_String_0;

	// Token: 0x04002CE8 RID: 11496
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnRename_Public_Static_rem_Void_UnityAction_2_Entity_String_0;

	// Token: 0x04002CE9 RID: 11497
	private static readonly IntPtr NativeMethodInfoPtr_InvokeRename_Public_Static_Void_Entity_String_0;

	// Token: 0x04002CEA RID: 11498
	private static readonly IntPtr NativeMethodInfoPtr_add_OnPullRewards_Public_Static_add_Void_UnityActionRef_4_Object_String_Int32_List_1_DataFile_0;

	// Token: 0x04002CEB RID: 11499
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnPullRewards_Public_Static_rem_Void_UnityActionRef_4_Object_String_Int32_List_1_DataFile_0;

	// Token: 0x04002CEC RID: 11500
	private static readonly IntPtr NativeMethodInfoPtr_PullRewards_Public_Static_List_1_DataFile_Object_String_byref_Int32_0;

	// Token: 0x04002CED RID: 11501
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCardDataCreated_Public_Static_add_Void_UnityAction_1_CardData_0;

	// Token: 0x04002CEE RID: 11502
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCardDataCreated_Public_Static_rem_Void_UnityAction_1_CardData_0;

	// Token: 0x04002CEF RID: 11503
	private static readonly IntPtr NativeMethodInfoPtr_InvokeCardDataCreated_Public_Static_Void_CardData_0;

	// Token: 0x04002CF0 RID: 11504
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTutorialProgress_Public_Static_add_Void_UnityAction_1_Int32_0;

	// Token: 0x04002CF1 RID: 11505
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTutorialProgress_Public_Static_rem_Void_UnityAction_1_Int32_0;

	// Token: 0x04002CF2 RID: 11506
	private static readonly IntPtr NativeMethodInfoPtr_InvokeTutorialProgress_Public_Static_Void_Int32_0;

	// Token: 0x04002CF3 RID: 11507
	private static readonly IntPtr NativeMethodInfoPtr_add_OnTutorialSkip_Public_Static_add_Void_UnityAction_0;

	// Token: 0x04002CF4 RID: 11508
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnTutorialSkip_Public_Static_rem_Void_UnityAction_0;

	// Token: 0x04002CF5 RID: 11509
	private static readonly IntPtr NativeMethodInfoPtr_InvokeTutorialSkip_Public_Static_Void_0;

	// Token: 0x04002CF6 RID: 11510
	private static readonly IntPtr NativeMethodInfoPtr_add_OnChallengeCompletedSaved_Public_Static_add_Void_UnityAction_1_ChallengeData_0;

	// Token: 0x04002CF7 RID: 11511
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnChallengeCompletedSaved_Public_Static_rem_Void_UnityAction_1_ChallengeData_0;

	// Token: 0x04002CF8 RID: 11512
	private static readonly IntPtr NativeMethodInfoPtr_InvokeChallengeCompletedSaved_Public_Static_Void_ChallengeData_0;

	// Token: 0x04002CF9 RID: 11513
	private static readonly IntPtr NativeMethodInfoPtr_add_OnGetHandSize_Public_Static_add_Void_UnityActionRef_1_Int32_0;

	// Token: 0x04002CFA RID: 11514
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnGetHandSize_Public_Static_rem_Void_UnityActionRef_1_Int32_0;

	// Token: 0x04002CFB RID: 11515
	private static readonly IntPtr NativeMethodInfoPtr_GetHandSize_Public_Static_Int32_Int32_0;

	// Token: 0x020008E6 RID: 2278
	public sealed class UnityActionRef<T> : MulticastDelegate
	{
		// Token: 0x06008F8A RID: 36746 RVA: 0x00216898 File Offset: 0x00214A98
		// Note: this type is marked as 'beforefieldinit'.
		static UnityActionRef()
		{
			Il2CppClassPointerStore<Events.UnityActionRef<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityActionRef`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityActionRef<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T>>.NativeClassPtr, 100674521);
			Events.UnityActionRef<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T>>.NativeClassPtr, 100674522);
			Events.UnityActionRef<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T>>.NativeClassPtr, 100674523);
			Events.UnityActionRef<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T>>.NativeClassPtr, 100674524);
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x00216944 File Offset: 0x00214B44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114260, RefRangeEnd = 114262, XrefRangeStart = 114253, XrefRangeEnd = 114260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityActionRef(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityActionRef<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x002169A0 File Offset: 0x00214BA0
		[CallerCount(0)]
		public unsafe void Invoke(ref T arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			arg0 = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x002169FC File Offset: 0x00214BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114262, XrefRangeEnd = 114266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref T arg0, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			arg0 = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr5) : null;
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x00216A8C File Offset: 0x00214C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114266, XrefRangeEnd = 114267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref T arg0, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			arg0 = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x00046A8E File Offset: 0x00044C8E
		public UnityActionRef(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005B8E RID: 23438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005B8F RID: 23439
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_0;

		// Token: 0x04005B90 RID: 23440
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T_AsyncCallback_Object_0;

		// Token: 0x04005B91 RID: 23441
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T_IAsyncResult_0;
	}

	// Token: 0x020008E7 RID: 2279
	public sealed class UnityActionRef<T0, T1> : MulticastDelegate
	{
		// Token: 0x06008F90 RID: 36752 RVA: 0x00216AF8 File Offset: 0x00214CF8
		// Note: this type is marked as 'beforefieldinit'.
		static UnityActionRef()
		{
			Il2CppClassPointerStore<Events.UnityActionRef<T0, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityActionRef`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityActionRef<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1>>.NativeClassPtr, 100674525);
			Events.UnityActionRef<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_byref_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1>>.NativeClassPtr, 100674526);
			Events.UnityActionRef<T0, T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_byref_T1_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1>>.NativeClassPtr, 100674527);
			Events.UnityActionRef<T0, T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_byref_T1_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1>>.NativeClassPtr, 100674528);
		}

		// Token: 0x06008F91 RID: 36753 RVA: 0x00216BB8 File Offset: 0x00214DB8
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 114274, RefRangeEnd = 114318, XrefRangeStart = 114267, XrefRangeEnd = 114274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityActionRef(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x00216C14 File Offset: 0x00214E14
		[CallerCount(0)]
		public unsafe void Invoke(ref T0 arg0, ref T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_byref_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arg0 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			arg1 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr6, false, false));
		}

		// Token: 0x06008F93 RID: 36755 RVA: 0x00216C98 File Offset: 0x00214E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114318, XrefRangeEnd = 114322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref T0 arg0, ref T1 arg1, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_byref_T1_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arg0 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			arg1 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr6, false, false));
			IntPtr intPtr7 = intPtr3;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr7) : null;
		}

		// Token: 0x06008F94 RID: 36756 RVA: 0x00216D54 File Offset: 0x00214F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114322, XrefRangeEnd = 114323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref T0 arg0, ref T1 arg1, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_byref_T1_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arg0 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			arg1 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr6, false, false));
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x00046A97 File Offset: 0x00044C97
		public UnityActionRef(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005B92 RID: 23442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005B93 RID: 23443
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_byref_T1_0;

		// Token: 0x04005B94 RID: 23444
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_byref_T1_AsyncCallback_Object_0;

		// Token: 0x04005B95 RID: 23445
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_byref_T1_IAsyncResult_0;
	}

	// Token: 0x020008E8 RID: 2280
	public sealed class UnityActionRef1<T0, T1> : MulticastDelegate
	{
		// Token: 0x06008F96 RID: 36758 RVA: 0x00216DEC File Offset: 0x00214FEC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityActionRef1()
		{
			Il2CppClassPointerStore<Events.UnityActionRef1<T0, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityActionRef1`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityActionRef1<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef1<T0, T1>>.NativeClassPtr, 100674529);
			Events.UnityActionRef1<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef1<T0, T1>>.NativeClassPtr, 100674530);
			Events.UnityActionRef1<T0, T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_T1_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef1<T0, T1>>.NativeClassPtr, 100674531);
			Events.UnityActionRef1<T0, T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef1<T0, T1>>.NativeClassPtr, 100674532);
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x00216EAC File Offset: 0x002150AC
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 114274, RefRangeEnd = 114318, XrefRangeStart = 114274, XrefRangeEnd = 114318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityActionRef1(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityActionRef1<T0, T1>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef1<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x00216F08 File Offset: 0x00215108
		[CallerCount(0)]
		public unsafe void Invoke(ref T0 arg0, T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t = arg1;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef1<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arg0 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr5, false, false));
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x00216FAC File Offset: 0x002151AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114323, XrefRangeEnd = 114324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref T0 arg0, T1 arg1, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t = arg1;
				intPtr2 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef1<T0, T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_T1_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			arg0 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr3;
			return (intPtr6 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr6) : null;
		}

		// Token: 0x06008F9A RID: 36762 RVA: 0x00217084 File Offset: 0x00215284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref T0 arg0, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef1<T0, T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			arg0 = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr4, false, false));
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x00046AA0 File Offset: 0x00044CA0
		public UnityActionRef1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005B96 RID: 23446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005B97 RID: 23447
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_T1_0;

		// Token: 0x04005B98 RID: 23448
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_T1_AsyncCallback_Object_0;

		// Token: 0x04005B99 RID: 23449
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_IAsyncResult_0;
	}

	// Token: 0x020008E9 RID: 2281
	public sealed class UnityActionRef<T0, T1, T2> : MulticastDelegate
	{
		// Token: 0x06008F9C RID: 36764 RVA: 0x002170F0 File Offset: 0x002152F0
		// Note: this type is marked as 'beforefieldinit'.
		static UnityActionRef()
		{
			Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityActionRef`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityActionRef<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2>>.NativeClassPtr, 100674533);
			Events.UnityActionRef<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_byref_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2>>.NativeClassPtr, 100674534);
			Events.UnityActionRef<T0, T1, T2>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_byref_T1_byref_T2_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2>>.NativeClassPtr, 100674535);
			Events.UnityActionRef<T0, T1, T2>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_byref_T1_byref_T2_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2>>.NativeClassPtr, 100674536);
		}

		// Token: 0x06008F9D RID: 36765 RVA: 0x002171C0 File Offset: 0x002153C0
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 114331, RefRangeEnd = 114365, XrefRangeStart = 114324, XrefRangeEnd = 114331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityActionRef(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x0021721C File Offset: 0x0021541C
		[CallerCount(0)]
		public unsafe void Invoke(ref T0 arg0, ref T1 arg1, ref T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_byref_T1_byref_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			arg0 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr6, false, false));
			IntPtr intPtr7 = intPtr2;
			arg1 = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr7, false, false));
			IntPtr intPtr8 = intPtr3;
			arg2 = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr8, false, false));
		}

		// Token: 0x06008F9F RID: 36767 RVA: 0x002172CC File Offset: 0x002154CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114365, XrefRangeEnd = 114369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ref T0 arg0, ref T1 arg1, ref T2 arg2, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1, T2>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_byref_T1_byref_T2_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			arg0 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr6, false, false));
			IntPtr intPtr7 = intPtr2;
			arg1 = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr7, false, false));
			IntPtr intPtr8 = intPtr3;
			arg2 = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr8, false, false));
			IntPtr intPtr9 = intPtr4;
			return (intPtr9 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr9) : null;
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x002173B4 File Offset: 0x002155B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114369, XrefRangeEnd = 114370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref T0 arg0, ref T1 arg1, ref T2 arg2, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1, T2>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_byref_T1_byref_T2_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			arg0 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T0>(intPtr6, false, false));
			IntPtr intPtr7 = intPtr2;
			arg1 = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr7, false, false));
			IntPtr intPtr8 = intPtr3;
			arg2 = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr8, false, false));
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x00046AA9 File Offset: 0x00044CA9
		public UnityActionRef(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005B9A RID: 23450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005B9B RID: 23451
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T0_byref_T1_byref_T2_0;

		// Token: 0x04005B9C RID: 23452
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_T0_byref_T1_byref_T2_AsyncCallback_Object_0;

		// Token: 0x04005B9D RID: 23453
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T0_byref_T1_byref_T2_IAsyncResult_0;
	}

	// Token: 0x020008EA RID: 2282
	public sealed class UnityActionRef<T0, T1, T2, T3> : MulticastDelegate
	{
		// Token: 0x06008FA2 RID: 36770 RVA: 0x00217478 File Offset: 0x00215678
		// Note: this type is marked as 'beforefieldinit'.
		static UnityActionRef()
		{
			Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2, T3>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityActionRef`4"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityActionRef<T0, T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2, T3>>.NativeClassPtr, 100674537);
			Events.UnityActionRef<T0, T1, T2, T3>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_byref_T1_byref_T2_byref_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2, T3>>.NativeClassPtr, 100674538);
			Events.UnityActionRef<T0, T1, T2, T3>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_byref_T1_byref_T2_byref_T3_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2, T3>>.NativeClassPtr, 100674539);
			Events.UnityActionRef<T0, T1, T2, T3>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T1_byref_T2_byref_T3_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2, T3>>.NativeClassPtr, 100674540);
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x0021755C File Offset: 0x0021575C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114382, RefRangeEnd = 114384, XrefRangeStart = 114370, XrefRangeEnd = 114382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityActionRef(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityActionRef<T0, T1, T2, T3>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1, T2, T3>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x002175B8 File Offset: 0x002157B8
		[CallerCount(0)]
		public unsafe void Invoke(T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(arg3);
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1, T2, T3>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_byref_T1_byref_T2_byref_T3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr2;
			arg1 = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr7, false, false));
			IntPtr intPtr8 = intPtr3;
			arg2 = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr8, false, false));
			IntPtr intPtr9 = intPtr4;
			arg3 = ((intPtr9 == 0) ? null : IL2CPP.PointerToValueGeneric<T3>(intPtr9, false, false));
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x002176B4 File Offset: 0x002158B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114384, XrefRangeEnd = 114388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T0 arg0, ref T1 arg1, ref T2 arg2, ref T3 arg3, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(arg3);
			ptr5 = &intPtr4;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1, T2, T3>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_byref_T1_byref_T2_byref_T3_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr2;
			arg1 = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr7, false, false));
			IntPtr intPtr8 = intPtr3;
			arg2 = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr8, false, false));
			IntPtr intPtr9 = intPtr4;
			arg3 = ((intPtr9 == 0) ? null : IL2CPP.PointerToValueGeneric<T3>(intPtr9, false, false));
			IntPtr intPtr10 = intPtr5;
			return (intPtr10 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr10) : null;
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x002177E4 File Offset: 0x002159E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref T1 arg1, ref T2 arg2, ref T3 arg3, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(arg3);
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionRef<T0, T1, T2, T3>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T1_byref_T2_byref_T3_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			arg1 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr6, false, false));
			IntPtr intPtr7 = intPtr2;
			arg2 = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr7, false, false));
			IntPtr intPtr8 = intPtr3;
			arg3 = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T3>(intPtr8, false, false));
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x00046AB2 File Offset: 0x00044CB2
		public UnityActionRef(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005B9E RID: 23454
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005B9F RID: 23455
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_byref_T1_byref_T2_byref_T3_0;

		// Token: 0x04005BA0 RID: 23456
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_byref_T1_byref_T2_byref_T3_AsyncCallback_Object_0;

		// Token: 0x04005BA1 RID: 23457
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T1_byref_T2_byref_T3_IAsyncResult_0;
	}

	// Token: 0x020008EB RID: 2283
	public sealed class UnityActionCheck<T0, T1> : MulticastDelegate
	{
		// Token: 0x06008FA8 RID: 36776 RVA: 0x002178A8 File Offset: 0x00215AA8
		// Note: this type is marked as 'beforefieldinit'.
		static UnityActionCheck()
		{
			Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityActionCheck`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityActionCheck<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1>>.NativeClassPtr, 100674541);
			Events.UnityActionCheck<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_byref_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1>>.NativeClassPtr, 100674542);
			Events.UnityActionCheck<T0, T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_byref_T1_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1>>.NativeClassPtr, 100674543);
			Events.UnityActionCheck<T0, T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T1_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1>>.NativeClassPtr, 100674544);
		}

		// Token: 0x06008FA9 RID: 36777 RVA: 0x00217968 File Offset: 0x00215B68
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 114400, RefRangeEnd = 114490, XrefRangeStart = 114388, XrefRangeEnd = 114400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityActionCheck(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionCheck<T0, T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FAA RID: 36778 RVA: 0x002179C4 File Offset: 0x00215BC4
		[CallerCount(0)]
		public unsafe void Invoke(T0 arg0, ref T1 arg1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionCheck<T0, T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_byref_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr2;
			arg1 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr5, false, false));
		}

		// Token: 0x06008FAB RID: 36779 RVA: 0x00217A68 File Offset: 0x00215C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114490, XrefRangeEnd = 114494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T0 arg0, ref T1 arg1, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionCheck<T0, T1>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_byref_T1_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr2;
			arg1 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr3;
			return (intPtr6 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr6) : null;
		}

		// Token: 0x06008FAC RID: 36780 RVA: 0x00217B40 File Offset: 0x00215D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref T1 arg1, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionCheck<T0, T1>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T1_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			arg1 = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr4, false, false));
		}

		// Token: 0x06008FAD RID: 36781 RVA: 0x00046ABB File Offset: 0x00044CBB
		public UnityActionCheck(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005BA2 RID: 23458
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005BA3 RID: 23459
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_byref_T1_0;

		// Token: 0x04005BA4 RID: 23460
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_byref_T1_AsyncCallback_Object_0;

		// Token: 0x04005BA5 RID: 23461
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T1_IAsyncResult_0;
	}

	// Token: 0x020008EC RID: 2284
	public sealed class UnityActionCheck<T0, T1, T2> : MulticastDelegate
	{
		// Token: 0x06008FAE RID: 36782 RVA: 0x00217BAC File Offset: 0x00215DAC
		// Note: this type is marked as 'beforefieldinit'.
		static UnityActionCheck()
		{
			Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityActionCheck`3"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityActionCheck<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1, T2>>.NativeClassPtr, 100674545);
			Events.UnityActionCheck<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1, T2>>.NativeClassPtr, 100674546);
			Events.UnityActionCheck<T0, T1, T2>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_byref_T2_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1, T2>>.NativeClassPtr, 100674547);
			Events.UnityActionCheck<T0, T1, T2>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T2_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1, T2>>.NativeClassPtr, 100674548);
		}

		// Token: 0x06008FAF RID: 36783 RVA: 0x00217C7C File Offset: 0x00215E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114494, XrefRangeEnd = 114506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityActionCheck(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityActionCheck<T0, T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionCheck<T0, T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FB0 RID: 36784 RVA: 0x00217CD8 File Offset: 0x00215ED8
		[CallerCount(0)]
		public unsafe void Invoke(T0 arg0, T1 arg1, ref T2 arg2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionCheck<T0, T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_byref_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr3;
			arg2 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr6, false, false));
		}

		// Token: 0x06008FB1 RID: 36785 RVA: 0x00217DC4 File Offset: 0x00215FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114506, XrefRangeEnd = 114507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T0 arg0, T1 arg1, ref T2 arg2, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr4 = &intPtr3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionCheck<T0, T1, T2>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_byref_T2_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr3;
			arg2 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr6, false, false));
			IntPtr intPtr7 = intPtr4;
			return (intPtr7 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr7) : null;
		}

		// Token: 0x06008FB2 RID: 36786 RVA: 0x00217EE4 File Offset: 0x002160E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(ref T2 arg2, IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.UnityActionCheck<T0, T1, T2>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T2_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			arg2 = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr4, false, false));
		}

		// Token: 0x06008FB3 RID: 36787 RVA: 0x00046AC4 File Offset: 0x00044CC4
		public UnityActionCheck(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005BA6 RID: 23462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005BA7 RID: 23463
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_byref_T2_0;

		// Token: 0x04005BA8 RID: 23464
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_byref_T2_AsyncCallback_Object_0;

		// Token: 0x04005BA9 RID: 23465
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_byref_T2_IAsyncResult_0;
	}

	// Token: 0x020008ED RID: 2285
	public sealed class UnityAction<T0, T1, T2, T3, T4> : MulticastDelegate
	{
		// Token: 0x06008FB4 RID: 36788 RVA: 0x00217F50 File Offset: 0x00216150
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityAction`5"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityAction<T0, T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4>>.NativeClassPtr, 100674549);
			Events.UnityAction<T0, T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4>>.NativeClassPtr, 100674550);
			Events.UnityAction<T0, T1, T2, T3, T4>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_T2_T3_T4_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4>>.NativeClassPtr, 100674551);
			Events.UnityAction<T0, T1, T2, T3, T4>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4>>.NativeClassPtr, 100674552);
		}

		// Token: 0x06008FB5 RID: 36789 RVA: 0x00218044 File Offset: 0x00216244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114507, XrefRangeEnd = 114519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityAction<T0, T1, T2, T3, T4>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FB6 RID: 36790 RVA: 0x002180A0 File Offset: 0x002162A0
		[CallerCount(0)]
		public unsafe void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(Events.UnityAction<T0, T1, T2, T3, T4>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_T4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
		}

		// Token: 0x06008FB7 RID: 36791 RVA: 0x0021823C File Offset: 0x0021643C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114519, XrefRangeEnd = 114520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(Events.UnityAction<T0, T1, T2, T3, T4>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_T2_T3_T4_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			IntPtr intPtr8 = intPtr6;
			return (intPtr8 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr8) : null;
		}

		// Token: 0x06008FB8 RID: 36792 RVA: 0x0021840C File Offset: 0x0021660C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68907, RefRangeEnd = 68908, XrefRangeStart = 68907, XrefRangeEnd = 68908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityAction<T0, T1, T2, T3, T4>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FB9 RID: 36793 RVA: 0x00046ACD File Offset: 0x00044CCD
		public UnityAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06008FBA RID: 36794 RVA: 0x00046AD6 File Offset: 0x00044CD6
		public static implicit operator Events.UnityAction<T0, T1, T2, T3, T4>(Action<T0, T1, T2, T3, T4> A_0)
		{
			return DelegateSupport.ConvertDelegate<Events.UnityAction<T0, T1, T2, T3, T4>>(A_0);
		}

		// Token: 0x06008FBB RID: 36795 RVA: 0x00046ADE File Offset: 0x00044CDE
		public static Events.UnityAction<T0, T1, T2, T3, T4>operator +(Events.UnityAction<T0, T1, T2, T3, T4> A_0, Events.UnityAction<T0, T1, T2, T3, T4> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Events.UnityAction<T0, T1, T2, T3, T4>>();
		}

		// Token: 0x06008FBC RID: 36796 RVA: 0x00046AEC File Offset: 0x00044CEC
		public static Events.UnityAction<T0, T1, T2, T3, T4>operator -(Events.UnityAction<T0, T1, T2, T3, T4> A_0, Events.UnityAction<T0, T1, T2, T3, T4> A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<Events.UnityAction<T0, T1, T2, T3, T4>>();
			}
			return result;
		}

		// Token: 0x04005BAA RID: 23466
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005BAB RID: 23467
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_T4_0;

		// Token: 0x04005BAC RID: 23468
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_T2_T3_T4_AsyncCallback_Object_0;

		// Token: 0x04005BAD RID: 23469
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020008EE RID: 2286
	public sealed class UnityAction<T0, T1, T2, T3, T4, T5> : MulticastDelegate
	{
		// Token: 0x06008FBD RID: 36797 RVA: 0x00218450 File Offset: 0x00216650
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4, T5>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "UnityAction`6"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T0>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr))
			})).TypeHandle.value);
			Events.UnityAction<T0, T1, T2, T3, T4, T5>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4, T5>>.NativeClassPtr, 100674553);
			Events.UnityAction<T0, T1, T2, T3, T4, T5>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_T4_T5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4, T5>>.NativeClassPtr, 100674554);
			Events.UnityAction<T0, T1, T2, T3, T4, T5>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_T2_T3_T4_T5_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4, T5>>.NativeClassPtr, 100674555);
			Events.UnityAction<T0, T1, T2, T3, T4, T5>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4, T5>>.NativeClassPtr, 100674556);
		}

		// Token: 0x06008FBE RID: 36798 RVA: 0x00218558 File Offset: 0x00216758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114520, XrefRangeEnd = 114532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.UnityAction<T0, T1, T2, T3, T4, T5>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityAction<T0, T1, T2, T3, T4, T5>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FBF RID: 36799 RVA: 0x002185B4 File Offset: 0x002167B4
		[CallerCount(0)]
		public unsafe void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			IntPtr intPtr8;
			IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(Events.UnityAction<T0, T1, T2, T3, T4, T5>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_T4_T5_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr8);
			Il2CppException.RaiseExceptionIfNecessary(intPtr8);
		}

		// Token: 0x06008FC0 RID: 36800 RVA: 0x00218798 File Offset: 0x00216998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114532, XrefRangeEnd = 114533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T0).IsValueType)
			{
				T0 t = arg0;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg0;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = arg1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref arg1;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T2).IsValueType)
			{
				T2 t3 = arg2;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref arg2;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T3).IsValueType)
			{
				T3 t4 = arg3;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref arg3;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T4).IsValueType)
			{
				T4 t5 = arg4;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref arg4;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T5).IsValueType)
			{
				T5 t6 = arg5;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref arg5;
			}
			ptr7 = intPtr6;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr8;
			IntPtr intPtr7 = IL2CPP.il2cpp_runtime_invoke(Events.UnityAction<T0, T1, T2, T3, T4, T5>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_T2_T3_T4_T5_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr8);
			Il2CppException.RaiseExceptionIfNecessary(intPtr8);
			IntPtr intPtr9 = intPtr7;
			return (intPtr9 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr9) : null;
		}

		// Token: 0x06008FC1 RID: 36801 RVA: 0x002189B0 File Offset: 0x00216BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68907, RefRangeEnd = 68908, XrefRangeStart = 68907, XrefRangeEnd = 68908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.UnityAction<T0, T1, T2, T3, T4, T5>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FC2 RID: 36802 RVA: 0x00046AFD File Offset: 0x00044CFD
		public UnityAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06008FC3 RID: 36803 RVA: 0x00046B06 File Offset: 0x00044D06
		public static implicit operator Events.UnityAction<T0, T1, T2, T3, T4, T5>(Action<T0, T1, T2, T3, T4, T5> A_0)
		{
			return DelegateSupport.ConvertDelegate<Events.UnityAction<T0, T1, T2, T3, T4, T5>>(A_0);
		}

		// Token: 0x06008FC4 RID: 36804 RVA: 0x00046B0E File Offset: 0x00044D0E
		public static Events.UnityAction<T0, T1, T2, T3, T4, T5>operator +(Events.UnityAction<T0, T1, T2, T3, T4, T5> A_0, Events.UnityAction<T0, T1, T2, T3, T4, T5> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Events.UnityAction<T0, T1, T2, T3, T4, T5>>();
		}

		// Token: 0x06008FC5 RID: 36805 RVA: 0x00046B1C File Offset: 0x00044D1C
		public static Events.UnityAction<T0, T1, T2, T3, T4, T5>operator -(Events.UnityAction<T0, T1, T2, T3, T4, T5> A_0, Events.UnityAction<T0, T1, T2, T3, T4, T5> A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<Events.UnityAction<T0, T1, T2, T3, T4, T5>>();
			}
			return result;
		}

		// Token: 0x04005BAE RID: 23470
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005BAF RID: 23471
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T0_T1_T2_T3_T4_T5_0;

		// Token: 0x04005BB0 RID: 23472
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T0_T1_T2_T3_T4_T5_AsyncCallback_Object_0;

		// Token: 0x04005BB1 RID: 23473
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020008EF RID: 2287
	public sealed class RoutineAction : MulticastDelegate
	{
		// Token: 0x06008FC6 RID: 36806 RVA: 0x002189F4 File Offset: 0x00216BF4
		// Note: this type is marked as 'beforefieldinit'.
		static RoutineAction()
		{
			Il2CppClassPointerStore<Events.RoutineAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "RoutineAction");
			Events.RoutineAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.RoutineAction>.NativeClassPtr, 100674557);
			Events.RoutineAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.RoutineAction>.NativeClassPtr, 100674558);
			Events.RoutineAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.RoutineAction>.NativeClassPtr, 100674559);
			Events.RoutineAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.RoutineAction>.NativeClassPtr, 100674560);
		}

		// Token: 0x06008FC7 RID: 36807 RVA: 0x00218A68 File Offset: 0x00216C68
		[CallerCount(136)]
		[CachedScanResults(RefRangeStart = 68768, RefRangeEnd = 68904, XrefRangeStart = 68768, XrefRangeEnd = 68904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoutineAction(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.RoutineAction>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.RoutineAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FC8 RID: 36808 RVA: 0x00218AC4 File Offset: 0x00216CC4
		[CallerCount(0)]
		public unsafe IEnumerator Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.RoutineAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008FC9 RID: 36809 RVA: 0x00218B04 File Offset: 0x00216D04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68905, RefRangeEnd = 68906, XrefRangeStart = 68905, XrefRangeEnd = 68906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.RoutineAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06008FCA RID: 36810 RVA: 0x00218B68 File Offset: 0x00216D68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68907, RefRangeEnd = 68908, XrefRangeStart = 68907, XrefRangeEnd = 68908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.RoutineAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008FCB RID: 36811 RVA: 0x00046B2D File Offset: 0x00044D2D
		public RoutineAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06008FCC RID: 36812 RVA: 0x00046B36 File Offset: 0x00044D36
		public static implicit operator Events.RoutineAction(Func<IEnumerator> A_0)
		{
			return DelegateSupport.ConvertDelegate<Events.RoutineAction>(A_0);
		}

		// Token: 0x06008FCD RID: 36813 RVA: 0x00046B3E File Offset: 0x00044D3E
		public static Events.RoutineAction operator +(Events.RoutineAction A_0, Events.RoutineAction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Events.RoutineAction>();
		}

		// Token: 0x06008FCE RID: 36814 RVA: 0x00046B4C File Offset: 0x00044D4C
		public static Events.RoutineAction operator -(Events.RoutineAction A_0, Events.RoutineAction A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<Events.RoutineAction>();
			}
			return result;
		}

		// Token: 0x04005BB2 RID: 23474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005BB3 RID: 23475
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_0;

		// Token: 0x04005BB4 RID: 23476
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04005BB5 RID: 23477
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;
	}

	// Token: 0x020008F0 RID: 2288
	public sealed class AsyncAction : MulticastDelegate
	{
		// Token: 0x06008FCF RID: 36815 RVA: 0x00218BB8 File Offset: 0x00216DB8
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncAction()
		{
			Il2CppClassPointerStore<Events.AsyncAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "AsyncAction");
			Events.AsyncAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.AsyncAction>.NativeClassPtr, 100674561);
			Events.AsyncAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.AsyncAction>.NativeClassPtr, 100674562);
			Events.AsyncAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.AsyncAction>.NativeClassPtr, 100674563);
			Events.AsyncAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Task_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.AsyncAction>.NativeClassPtr, 100674564);
		}

		// Token: 0x06008FD0 RID: 36816 RVA: 0x00218C2C File Offset: 0x00216E2C
		[CallerCount(136)]
		[CachedScanResults(RefRangeStart = 68768, RefRangeEnd = 68904, XrefRangeStart = 68768, XrefRangeEnd = 68904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncAction(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.AsyncAction>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.AsyncAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FD1 RID: 36817 RVA: 0x00218C88 File Offset: 0x00216E88
		[CallerCount(0)]
		public unsafe Task Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.AsyncAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06008FD2 RID: 36818 RVA: 0x00218CC8 File Offset: 0x00216EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68905, RefRangeEnd = 68906, XrefRangeStart = 68905, XrefRangeEnd = 68906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.AsyncAction.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06008FD3 RID: 36819 RVA: 0x00218D2C File Offset: 0x00216F2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68907, RefRangeEnd = 68908, XrefRangeStart = 68907, XrefRangeEnd = 68908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.AsyncAction.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Task_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06008FD4 RID: 36820 RVA: 0x00046B5D File Offset: 0x00044D5D
		public AsyncAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06008FD5 RID: 36821 RVA: 0x00046B66 File Offset: 0x00044D66
		public static implicit operator Events.AsyncAction(Func<Task> A_0)
		{
			return DelegateSupport.ConvertDelegate<Events.AsyncAction>(A_0);
		}

		// Token: 0x06008FD6 RID: 36822 RVA: 0x00046B6E File Offset: 0x00044D6E
		public static Events.AsyncAction operator +(Events.AsyncAction A_0, Events.AsyncAction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Events.AsyncAction>();
		}

		// Token: 0x06008FD7 RID: 36823 RVA: 0x00046B7C File Offset: 0x00044D7C
		public static Events.AsyncAction operator -(Events.AsyncAction A_0, Events.AsyncAction A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<Events.AsyncAction>();
			}
			return result;
		}

		// Token: 0x04005BB6 RID: 23478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005BB7 RID: 23479
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Task_0;

		// Token: 0x04005BB8 RID: 23480
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

		// Token: 0x04005BB9 RID: 23481
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Task_IAsyncResult_0;
	}

	// Token: 0x020008F1 RID: 2289
	public sealed class RoutineAction<T> : MulticastDelegate
	{
		// Token: 0x06008FD8 RID: 36824 RVA: 0x00218D7C File Offset: 0x00216F7C
		// Note: this type is marked as 'beforefieldinit'.
		static RoutineAction()
		{
			Il2CppClassPointerStore<Events.RoutineAction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "RoutineAction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			Events.RoutineAction<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.RoutineAction<T>>.NativeClassPtr, 100674565);
			Events.RoutineAction<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.RoutineAction<T>>.NativeClassPtr, 100674566);
			Events.RoutineAction<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.RoutineAction<T>>.NativeClassPtr, 100674567);
			Events.RoutineAction<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.RoutineAction<T>>.NativeClassPtr, 100674568);
		}

		// Token: 0x06008FD9 RID: 36825 RVA: 0x00218E28 File Offset: 0x00217028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 114545, RefRangeEnd = 114547, XrefRangeStart = 114533, XrefRangeEnd = 114545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoutineAction(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.RoutineAction<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.RoutineAction<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x00218E84 File Offset: 0x00217084
		[CallerCount(0)]
		public unsafe IEnumerator Invoke(T arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = arg;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.RoutineAction<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr4) : null;
		}

		// Token: 0x06008FDB RID: 36827 RVA: 0x00218F0C File Offset: 0x0021710C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 76539, RefRangeEnd = 76542, XrefRangeStart = 76539, XrefRangeEnd = 76542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(T arg, AsyncCallback callback, Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = arg;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Events.RoutineAction<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x00218FB8 File Offset: 0x002171B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 68907, RefRangeEnd = 68908, XrefRangeStart = 68907, XrefRangeEnd = 68908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.RoutineAction<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x00046B8D File Offset: 0x00044D8D
		public RoutineAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x00046B96 File Offset: 0x00044D96
		public static implicit operator Events.RoutineAction<T>(Func<T, IEnumerator> A_0)
		{
			return DelegateSupport.ConvertDelegate<Events.RoutineAction<T>>(A_0);
		}

		// Token: 0x06008FDF RID: 36831 RVA: 0x00046B9E File Offset: 0x00044D9E
		public static Events.RoutineAction<T>operator +(Events.RoutineAction<T> A_0, Events.RoutineAction<T> A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Events.RoutineAction<T>>();
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x00046BAC File Offset: 0x00044DAC
		public static Events.RoutineAction<T>operator -(Events.RoutineAction<T> A_0, Events.RoutineAction<T> A_1)
		{
			Delegate result;
			Delegate @delegate = result = Delegate.Remove(A_0, A_1);
			if (@delegate != null)
			{
				result = @delegate.Cast<Events.RoutineAction<T>>();
			}
			return result;
		}

		// Token: 0x04005BBA RID: 23482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04005BBB RID: 23483
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IEnumerator_T_0;

		// Token: 0x04005BBC RID: 23484
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

		// Token: 0x04005BBD RID: 23485
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IEnumerator_IAsyncResult_0;
	}

	// Token: 0x020008F2 RID: 2290
	[ObfuscatedName("Events+<>c__DisplayClass267_0")]
	public sealed class __c__DisplayClass267_0 : Il2CppSystem.Object
	{
		// Token: 0x06008FE1 RID: 36833 RVA: 0x00219008 File Offset: 0x00217208
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass267_0()
		{
			Il2CppClassPointerStore<Events.__c__DisplayClass267_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "<>c__DisplayClass267_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events.__c__DisplayClass267_0>.NativeClassPtr);
			Events.__c__DisplayClass267_0.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events.__c__DisplayClass267_0>.NativeClassPtr, "task");
			Events.__c__DisplayClass267_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.__c__DisplayClass267_0>.NativeClassPtr, 100674569);
			Events.__c__DisplayClass267_0.NativeMethodInfoPtr__InvokePreBattleEnd_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.__c__DisplayClass267_0>.NativeClassPtr, 100674570);
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x00219070 File Offset: 0x00217270
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass267_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.__c__DisplayClass267_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.__c__DisplayClass267_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x002190AC File Offset: 0x002172AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _InvokePreBattleEnd_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.__c__DisplayClass267_0.NativeMethodInfoPtr__InvokePreBattleEnd_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x00046BBD File Offset: 0x00044DBD
		public __c__DisplayClass267_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CBD RID: 11453
		// (get) Token: 0x06008FE5 RID: 36837 RVA: 0x002190E8 File Offset: 0x002172E8
		// (set) Token: 0x06008FE6 RID: 36838 RVA: 0x00046BC6 File Offset: 0x00044DC6
		public unsafe Task task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events.__c__DisplayClass267_0.NativeFieldInfoPtr_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events.__c__DisplayClass267_0.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BBE RID: 23486
		private static readonly IntPtr NativeFieldInfoPtr_task;

		// Token: 0x04005BBF RID: 23487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005BC0 RID: 23488
		private static readonly IntPtr NativeMethodInfoPtr__InvokePreBattleEnd_b__0_Internal_Boolean_0;
	}

	// Token: 0x020008F3 RID: 2291
	[ObfuscatedName("Events+<InvokePreBattleEnd>d__267")]
	public sealed class _InvokePreBattleEnd_d__267 : Il2CppSystem.Object
	{
		// Token: 0x06008FE7 RID: 36839 RVA: 0x00219118 File Offset: 0x00217318
		// Note: this type is marked as 'beforefieldinit'.
		static _InvokePreBattleEnd_d__267()
		{
			Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "<InvokePreBattleEnd>d__267");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr);
			Events._InvokePreBattleEnd_d__267.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr, "<>1__state");
			Events._InvokePreBattleEnd_d__267.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr, "<>2__current");
			Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr, 100674571);
			Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr, 100674572);
			Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr, 100674573);
			Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr, 100674574);
			Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr, 100674575);
			Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr, 100674576);
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x002191E4 File Offset: 0x002173E4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _InvokePreBattleEnd_d__267(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events._InvokePreBattleEnd_d__267>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0021922C File Offset: 0x0021742C
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x00219260 File Offset: 0x00217460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114547, XrefRangeEnd = 114566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x06008FEB RID: 36843 RVA: 0x0021929C File Offset: 0x0021749C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008FEC RID: 36844 RVA: 0x002192DC File Offset: 0x002174DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114566, XrefRangeEnd = 114572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x06008FED RID: 36845 RVA: 0x00219310 File Offset: 0x00217510
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokePreBattleEnd_d__267.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x00046BE5 File Offset: 0x00044DE5
		public _InvokePreBattleEnd_d__267(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x06008FEF RID: 36847 RVA: 0x00219350 File Offset: 0x00217550
		// (set) Token: 0x06008FF0 RID: 36848 RVA: 0x00046BEE File Offset: 0x00044DEE
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokePreBattleEnd_d__267.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokePreBattleEnd_d__267.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x06008FF1 RID: 36849 RVA: 0x00219378 File Offset: 0x00217578
		// (set) Token: 0x06008FF2 RID: 36850 RVA: 0x00046C09 File Offset: 0x00044E09
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokePreBattleEnd_d__267.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokePreBattleEnd_d__267.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BC1 RID: 23489
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04005BC2 RID: 23490
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04005BC3 RID: 23491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04005BC4 RID: 23492
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005BC5 RID: 23493
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04005BC6 RID: 23494
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04005BC7 RID: 23495
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005BC8 RID: 23496
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020008F4 RID: 2292
	[ObfuscatedName("Events+<InvokeCampaignPreInit>d__519")]
	public sealed class _InvokeCampaignPreInit_d__519 : Il2CppSystem.Object
	{
		// Token: 0x06008FF3 RID: 36851 RVA: 0x002193A8 File Offset: 0x002175A8
		// Note: this type is marked as 'beforefieldinit'.
		static _InvokeCampaignPreInit_d__519()
		{
			Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "<InvokeCampaignPreInit>d__519");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr);
			Events._InvokeCampaignPreInit_d__519.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr, "<>1__state");
			Events._InvokeCampaignPreInit_d__519.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr, "<>2__current");
			Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr, 100674577);
			Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr, 100674578);
			Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr, 100674579);
			Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr, 100674580);
			Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr, 100674581);
			Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr, 100674582);
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x00219474 File Offset: 0x00217674
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _InvokeCampaignPreInit_d__519(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events._InvokeCampaignPreInit_d__519>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x002194BC File Offset: 0x002176BC
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008FF6 RID: 36854 RVA: 0x002194F0 File Offset: 0x002176F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114572, XrefRangeEnd = 114575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002CC4 RID: 11460
		// (get) Token: 0x06008FF7 RID: 36855 RVA: 0x0021952C File Offset: 0x0021772C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008FF8 RID: 36856 RVA: 0x0021956C File Offset: 0x0021776C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114575, XrefRangeEnd = 114581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002CC5 RID: 11461
		// (get) Token: 0x06008FF9 RID: 36857 RVA: 0x002195A0 File Offset: 0x002177A0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignPreInit_d__519.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008FFA RID: 36858 RVA: 0x00046C28 File Offset: 0x00044E28
		public _InvokeCampaignPreInit_d__519(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CC2 RID: 11458
		// (get) Token: 0x06008FFB RID: 36859 RVA: 0x002195E0 File Offset: 0x002177E0
		// (set) Token: 0x06008FFC RID: 36860 RVA: 0x00046C31 File Offset: 0x00044E31
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignPreInit_d__519.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignPreInit_d__519.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002CC3 RID: 11459
		// (get) Token: 0x06008FFD RID: 36861 RVA: 0x00219608 File Offset: 0x00217808
		// (set) Token: 0x06008FFE RID: 36862 RVA: 0x00046C4C File Offset: 0x00044E4C
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignPreInit_d__519.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignPreInit_d__519.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BC9 RID: 23497
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04005BCA RID: 23498
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04005BCB RID: 23499
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04005BCC RID: 23500
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005BCD RID: 23501
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04005BCE RID: 23502
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04005BCF RID: 23503
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005BD0 RID: 23504
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020008F5 RID: 2293
	[ObfuscatedName("Events+<InvokeCampaignInit>d__523")]
	public sealed class _InvokeCampaignInit_d__523 : Il2CppSystem.Object
	{
		// Token: 0x06008FFF RID: 36863 RVA: 0x00219638 File Offset: 0x00217838
		// Note: this type is marked as 'beforefieldinit'.
		static _InvokeCampaignInit_d__523()
		{
			Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "<InvokeCampaignInit>d__523");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr);
			Events._InvokeCampaignInit_d__523.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr, "<>1__state");
			Events._InvokeCampaignInit_d__523.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr, "<>2__current");
			Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr, 100674583);
			Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr, 100674584);
			Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr, 100674585);
			Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr, 100674586);
			Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr, 100674587);
			Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr, 100674588);
		}

		// Token: 0x06009000 RID: 36864 RVA: 0x00219704 File Offset: 0x00217904
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _InvokeCampaignInit_d__523(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events._InvokeCampaignInit_d__523>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009001 RID: 36865 RVA: 0x0021974C File Offset: 0x0021794C
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009002 RID: 36866 RVA: 0x00219780 File Offset: 0x00217980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114581, XrefRangeEnd = 114584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002CC8 RID: 11464
		// (get) Token: 0x06009003 RID: 36867 RVA: 0x002197BC File Offset: 0x002179BC
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06009004 RID: 36868 RVA: 0x002197FC File Offset: 0x002179FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114584, XrefRangeEnd = 114590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002CC9 RID: 11465
		// (get) Token: 0x06009005 RID: 36869 RVA: 0x00219830 File Offset: 0x00217A30
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignInit_d__523.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06009006 RID: 36870 RVA: 0x00046C6B File Offset: 0x00044E6B
		public _InvokeCampaignInit_d__523(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CC6 RID: 11462
		// (get) Token: 0x06009007 RID: 36871 RVA: 0x00219870 File Offset: 0x00217A70
		// (set) Token: 0x06009008 RID: 36872 RVA: 0x00046C74 File Offset: 0x00044E74
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignInit_d__523.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignInit_d__523.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002CC7 RID: 11463
		// (get) Token: 0x06009009 RID: 36873 RVA: 0x00219898 File Offset: 0x00217A98
		// (set) Token: 0x0600900A RID: 36874 RVA: 0x00046C8F File Offset: 0x00044E8F
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignInit_d__523.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignInit_d__523.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BD1 RID: 23505
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04005BD2 RID: 23506
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04005BD3 RID: 23507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04005BD4 RID: 23508
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005BD5 RID: 23509
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04005BD6 RID: 23510
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04005BD7 RID: 23511
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005BD8 RID: 23512
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020008F6 RID: 2294
	[ObfuscatedName("Events+<>c__DisplayClass539_0")]
	public sealed class __c__DisplayClass539_0 : Il2CppSystem.Object
	{
		// Token: 0x0600900B RID: 36875 RVA: 0x002198C8 File Offset: 0x00217AC8
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass539_0()
		{
			Il2CppClassPointerStore<Events.__c__DisplayClass539_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "<>c__DisplayClass539_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events.__c__DisplayClass539_0>.NativeClassPtr);
			Events.__c__DisplayClass539_0.NativeFieldInfoPtr_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events.__c__DisplayClass539_0>.NativeClassPtr, "task");
			Events.__c__DisplayClass539_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.__c__DisplayClass539_0>.NativeClassPtr, 100674589);
			Events.__c__DisplayClass539_0.NativeMethodInfoPtr__InvokeCampaignGenerated_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events.__c__DisplayClass539_0>.NativeClassPtr, 100674590);
		}

		// Token: 0x0600900C RID: 36876 RVA: 0x00219930 File Offset: 0x00217B30
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass539_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events.__c__DisplayClass539_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.__c__DisplayClass539_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600900D RID: 36877 RVA: 0x0021996C File Offset: 0x00217B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _InvokeCampaignGenerated_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events.__c__DisplayClass539_0.NativeMethodInfoPtr__InvokeCampaignGenerated_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x00046CAE File Offset: 0x00044EAE
		public __c__DisplayClass539_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CCA RID: 11466
		// (get) Token: 0x0600900F RID: 36879 RVA: 0x002199A8 File Offset: 0x00217BA8
		// (set) Token: 0x06009010 RID: 36880 RVA: 0x00046CB7 File Offset: 0x00044EB7
		public unsafe Task task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events.__c__DisplayClass539_0.NativeFieldInfoPtr_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events.__c__DisplayClass539_0.NativeFieldInfoPtr_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BD9 RID: 23513
		private static readonly IntPtr NativeFieldInfoPtr_task;

		// Token: 0x04005BDA RID: 23514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005BDB RID: 23515
		private static readonly IntPtr NativeMethodInfoPtr__InvokeCampaignGenerated_b__0_Internal_Boolean_0;
	}

	// Token: 0x020008F7 RID: 2295
	[ObfuscatedName("Events+<InvokeCampaignGenerated>d__539")]
	public sealed class _InvokeCampaignGenerated_d__539 : Il2CppSystem.Object
	{
		// Token: 0x06009011 RID: 36881 RVA: 0x002199D8 File Offset: 0x00217BD8
		// Note: this type is marked as 'beforefieldinit'.
		static _InvokeCampaignGenerated_d__539()
		{
			Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Events>.NativeClassPtr, "<InvokeCampaignGenerated>d__539");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr);
			Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, "<>1__state");
			Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, "<>2__current");
			Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, "<>7__wrap1");
			Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, "<>7__wrap2");
			Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, 100674591);
			Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, 100674592);
			Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, 100674593);
			Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, 100674594);
			Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, 100674595);
			Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr, 100674596);
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x00219ACC File Offset: 0x00217CCC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _InvokeCampaignGenerated_d__539(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Events._InvokeCampaignGenerated_d__539>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x00219B14 File Offset: 0x00217D14
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x00219B48 File Offset: 0x00217D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114590, XrefRangeEnd = 114614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002CCF RID: 11471
		// (get) Token: 0x06009015 RID: 36885 RVA: 0x00219B84 File Offset: 0x00217D84
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x00219BC4 File Offset: 0x00217DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114614, XrefRangeEnd = 114620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002CD0 RID: 11472
		// (get) Token: 0x06009017 RID: 36887 RVA: 0x00219BF8 File Offset: 0x00217DF8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Events._InvokeCampaignGenerated_d__539.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x00046CD6 File Offset: 0x00044ED6
		public _InvokeCampaignGenerated_d__539(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CCB RID: 11467
		// (get) Token: 0x06009019 RID: 36889 RVA: 0x00219C38 File Offset: 0x00217E38
		// (set) Token: 0x0600901A RID: 36890 RVA: 0x00046CDF File Offset: 0x00044EDF
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002CCC RID: 11468
		// (get) Token: 0x0600901B RID: 36891 RVA: 0x00219C60 File Offset: 0x00217E60
		// (set) Token: 0x0600901C RID: 36892 RVA: 0x00046CFA File Offset: 0x00044EFA
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCD RID: 11469
		// (get) Token: 0x0600901D RID: 36893 RVA: 0x00219C90 File Offset: 0x00217E90
		// (set) Token: 0x0600901E RID: 36894 RVA: 0x00046D19 File Offset: 0x00044F19
		public unsafe Il2CppReferenceArray<Delegate> __7__wrap1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___7__wrap1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CCE RID: 11470
		// (get) Token: 0x0600901F RID: 36895 RVA: 0x00219CC0 File Offset: 0x00217EC0
		// (set) Token: 0x06009020 RID: 36896 RVA: 0x00046D38 File Offset: 0x00044F38
		public unsafe int __7__wrap2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___7__wrap2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Events._InvokeCampaignGenerated_d__539.NativeFieldInfoPtr___7__wrap2)) = value;
			}
		}

		// Token: 0x04005BDC RID: 23516
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04005BDD RID: 23517
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04005BDE RID: 23518
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

		// Token: 0x04005BDF RID: 23519
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

		// Token: 0x04005BE0 RID: 23520
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04005BE1 RID: 23521
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005BE2 RID: 23522
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04005BE3 RID: 23523
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04005BE4 RID: 23524
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005BE5 RID: 23525
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020001F8 RID: 504
public class StatsSystem : GameSystem
{
	// Token: 0x06002557 RID: 9559 RVA: 0x000C724C File Offset: 0x000C544C
	// Note: this type is marked as 'beforefieldinit'.
	static StatsSystem()
	{
		Il2CppClassPointerStore<StatsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "StatsSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr);
		StatsSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, "instance");
		StatsSystem.NativeFieldInfoPtr_stats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, "stats");
		StatsSystem.NativeFieldInfoPtr_goldThisBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, "goldThisBattle");
		StatsSystem.NativeFieldInfoPtr_sacrificedThisBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, "sacrificedThisBattle");
		StatsSystem.NativeFieldInfoPtr_kingMokoExists = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, "kingMokoExists");
		StatsSystem.NativeFieldInfoPtr_campaignEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, "campaignEnded");
		StatsSystem.NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669557);
		StatsSystem.NativeMethodInfoPtr_Set_Public_Static_Void_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669558);
		StatsSystem.NativeMethodInfoPtr_get_Stats_Private_get_CampaignStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669559);
		StatsSystem.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669560);
		StatsSystem.NativeMethodInfoPtr_OnDisable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669561);
		StatsSystem.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669562);
		StatsSystem.NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669563);
		StatsSystem.NativeMethodInfoPtr_CampaignSaved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669564);
		StatsSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669565);
		StatsSystem.NativeMethodInfoPtr_PostEntityHit_Private_Void_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669566);
		StatsSystem.NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669567);
		StatsSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669568);
		StatsSystem.NativeMethodInfoPtr_EntityOffered_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669569);
		StatsSystem.NativeMethodInfoPtr_EntityChosen_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669570);
		StatsSystem.NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669571);
		StatsSystem.NativeMethodInfoPtr_EntityDiscarded_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669572);
		StatsSystem.NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669573);
		StatsSystem.NativeMethodInfoPtr_EntityTriggered_Private_Void_byref_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669574);
		StatsSystem.NativeMethodInfoPtr_CardInjured_Private_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669575);
		StatsSystem.NativeMethodInfoPtr_BattleStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669576);
		StatsSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669577);
		StatsSystem.NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669578);
		StatsSystem.NativeMethodInfoPtr_SpendGold_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669579);
		StatsSystem.NativeMethodInfoPtr_ShopItemPurchase_Private_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669580);
		StatsSystem.NativeMethodInfoPtr_ShopItemHaggled_Private_Void_ShopItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669581);
		StatsSystem.NativeMethodInfoPtr_KillCombo_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669582);
		StatsSystem.NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669583);
		StatsSystem.NativeMethodInfoPtr_WaveDeployerEarlyDeploy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669584);
		StatsSystem.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669585);
		StatsSystem.NativeMethodInfoPtr_Rename_Private_Void_Entity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669586);
		StatsSystem.NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669587);
		StatsSystem.NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669588);
		StatsSystem.NativeMethodInfoPtr_UpgradeAssigned_Private_Void_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669589);
		StatsSystem.NativeMethodInfoPtr_GetBattleName_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669590);
		StatsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, 100669591);
	}

	// Token: 0x06002558 RID: 9560 RVA: 0x000C75B0 File Offset: 0x000C57B0
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 77318, RefRangeEnd = 77326, XrefRangeStart = 77316, XrefRangeEnd = 77318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CampaignStats Get()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CampaignStats>(intPtr3) : null;
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x000C75E4 File Offset: 0x000C57E4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 77334, RefRangeEnd = 77336, XrefRangeStart = 77326, XrefRangeEnd = 77334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Set(CampaignStats stats)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stats);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_Set_Public_Static_Void_CampaignStats_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000AAF RID: 2735
	// (get) Token: 0x0600255A RID: 9562 RVA: 0x000C761C File Offset: 0x000C581C
	public unsafe CampaignStats Stats
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_get_Stats_Private_get_CampaignStats_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CampaignStats>(intPtr3) : null;
		}
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x000C765C File Offset: 0x000C585C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77336, XrefRangeEnd = 77519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x000C7690 File Offset: 0x000C5890
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77519, XrefRangeEnd = 77698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_OnDisable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x000C76C4 File Offset: 0x000C58C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77698, XrefRangeEnd = 77699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x000C76F8 File Offset: 0x000C58F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 77699, RefRangeEnd = 77700, XrefRangeStart = 77699, XrefRangeEnd = 77699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CampaignEnd(Campaign.Result result, CampaignStats stats, PlayerData playerData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref result;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stats);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x000C775C File Offset: 0x000C595C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77700, XrefRangeEnd = 77710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CampaignSaved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_CampaignSaved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x000C7790 File Offset: 0x000C5990
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77710, XrefRangeEnd = 77744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityHit(Hit hit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x000C77D4 File Offset: 0x000C59D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77744, XrefRangeEnd = 77772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PostEntityHit(Hit hit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_PostEntityHit_Private_Void_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x000C7818 File Offset: 0x000C5A18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77772, XrefRangeEnd = 77806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StatusApplied(StatusEffectApply apply)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(apply);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x000C785C File Offset: 0x000C5A5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77806, XrefRangeEnd = 77883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityKilled(Entity entity, DeathType deathType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deathType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x000C78AC File Offset: 0x000C5AAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77883, XrefRangeEnd = 77887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityOffered(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityOffered_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x000C78F0 File Offset: 0x000C5AF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77887, XrefRangeEnd = 77895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityChosen(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityChosen_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000C7934 File Offset: 0x000C5B34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77895, XrefRangeEnd = 77905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityFlee(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x000C7978 File Offset: 0x000C5B78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77905, XrefRangeEnd = 77915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityDiscarded(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityDiscarded_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x000C79BC File Offset: 0x000C5BBC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77915, XrefRangeEnd = 77919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntitySummoned(Entity entity, Entity summonedBy)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(summonedBy);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x000C7A10 File Offset: 0x000C5C10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77919, XrefRangeEnd = 77933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityTriggered(ref Trigger trigger)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(trigger);
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_EntityTriggered_Private_Void_byref_Trigger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		trigger = ((intPtr4 == 0) ? null : new Trigger(intPtr4));
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x000C7A68 File Offset: 0x000C5C68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77933, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CardInjured(CardData cardData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_CardInjured_Private_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x000C7AAC File Offset: 0x000C5CAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77937, XrefRangeEnd = 77962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattleStart()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_BattleStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x000C7AE0 File Offset: 0x000C5CE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77962, XrefRangeEnd = 78008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattleEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_BattleEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x000C7B14 File Offset: 0x000C5D14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78008, XrefRangeEnd = 78011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DropGold(int amount, string source, Character owner, Vector3 position)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(source);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x000C7B84 File Offset: 0x000C5D84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78011, XrefRangeEnd = 78015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpendGold(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_SpendGold_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x000C7BC4 File Offset: 0x000C5DC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78015, XrefRangeEnd = 78057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShopItemPurchase(ShopItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_ShopItemPurchase_Private_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x000C7C08 File Offset: 0x000C5E08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78057, XrefRangeEnd = 78061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShopItemHaggled(ShopItem item)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_ShopItemHaggled_Private_Void_ShopItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x000C7C4C File Offset: 0x000C5E4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78061, XrefRangeEnd = 78065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void KillCombo(int combo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref combo;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_KillCombo_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x000C7C8C File Offset: 0x000C5E8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78065, XrefRangeEnd = 78069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RedrawBellHit(RedrawBellSystem redrawBellSystem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(redrawBellSystem);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x000C7CD0 File Offset: 0x000C5ED0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78069, XrefRangeEnd = 78073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WaveDeployerEarlyDeploy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_WaveDeployerEarlyDeploy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x000C7D04 File Offset: 0x000C5F04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78073, XrefRangeEnd = 78077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattleTurnStart(int turnCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref turnCount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x000C7D44 File Offset: 0x000C5F44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78077, XrefRangeEnd = 78084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rename(Entity entity, string newName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_Rename_Private_Void_Entity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x000C7D98 File Offset: 0x000C5F98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78084, XrefRangeEnd = 78109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MuncherFeed(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x000C7DDC File Offset: 0x000C5FDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78109, XrefRangeEnd = 78114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeGained(CardUpgradeData upgradeData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x000C7E20 File Offset: 0x000C6020
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78114, XrefRangeEnd = 78122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeAssigned(Entity entity, CardUpgradeData upgradeData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(upgradeData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_UpgradeAssigned_Private_Void_Entity_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x000C7E74 File Offset: 0x000C6074
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78122, XrefRangeEnd = 78132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetBattleName()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr_GetBattleName_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x000C7EA0 File Offset: 0x000C60A0
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 21506, RefRangeEnd = 21513, XrefRangeStart = 21506, XrefRangeEnd = 21513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StatsSystem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x00014A8A File Offset: 0x00012C8A
	public StatsSystem(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000AA9 RID: 2729
	// (get) Token: 0x0600257C RID: 9596 RVA: 0x000C7EDC File Offset: 0x000C60DC
	// (set) Token: 0x0600257D RID: 9597 RVA: 0x00014A93 File Offset: 0x00012C93
	public unsafe static StatsSystem instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(StatsSystem.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatsSystem>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(StatsSystem.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000AAA RID: 2730
	// (get) Token: 0x0600257E RID: 9598 RVA: 0x000C7F04 File Offset: 0x000C6104
	// (set) Token: 0x0600257F RID: 9599 RVA: 0x00014AA5 File Offset: 0x00012CA5
	public unsafe CampaignStats stats
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_stats);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CampaignStats>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_stats), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000AAB RID: 2731
	// (get) Token: 0x06002580 RID: 9600 RVA: 0x000C7F34 File Offset: 0x000C6134
	// (set) Token: 0x06002581 RID: 9601 RVA: 0x00014AC4 File Offset: 0x00012CC4
	public unsafe int goldThisBattle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_goldThisBattle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_goldThisBattle)) = value;
		}
	}

	// Token: 0x17000AAC RID: 2732
	// (get) Token: 0x06002582 RID: 9602 RVA: 0x000C7F5C File Offset: 0x000C615C
	// (set) Token: 0x06002583 RID: 9603 RVA: 0x00014ADF File Offset: 0x00012CDF
	public unsafe int sacrificedThisBattle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_sacrificedThisBattle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_sacrificedThisBattle)) = value;
		}
	}

	// Token: 0x17000AAD RID: 2733
	// (get) Token: 0x06002584 RID: 9604 RVA: 0x000C7F84 File Offset: 0x000C6184
	// (set) Token: 0x06002585 RID: 9605 RVA: 0x00014AFA File Offset: 0x00012CFA
	public unsafe bool kingMokoExists
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_kingMokoExists);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_kingMokoExists)) = value;
		}
	}

	// Token: 0x17000AAE RID: 2734
	// (get) Token: 0x06002586 RID: 9606 RVA: 0x000C7FAC File Offset: 0x000C61AC
	// (set) Token: 0x06002587 RID: 9607 RVA: 0x00014B15 File Offset: 0x00012D15
	public unsafe bool campaignEnded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_campaignEnded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StatsSystem.NativeFieldInfoPtr_campaignEnded)) = value;
		}
	}

	// Token: 0x040017A0 RID: 6048
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x040017A1 RID: 6049
	private static readonly IntPtr NativeFieldInfoPtr_stats;

	// Token: 0x040017A2 RID: 6050
	private static readonly IntPtr NativeFieldInfoPtr_goldThisBattle;

	// Token: 0x040017A3 RID: 6051
	private static readonly IntPtr NativeFieldInfoPtr_sacrificedThisBattle;

	// Token: 0x040017A4 RID: 6052
	private static readonly IntPtr NativeFieldInfoPtr_kingMokoExists;

	// Token: 0x040017A5 RID: 6053
	private static readonly IntPtr NativeFieldInfoPtr_campaignEnded;

	// Token: 0x040017A6 RID: 6054
	private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_CampaignStats_0;

	// Token: 0x040017A7 RID: 6055
	private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Static_Void_CampaignStats_0;

	// Token: 0x040017A8 RID: 6056
	private static readonly IntPtr NativeMethodInfoPtr_get_Stats_Private_get_CampaignStats_0;

	// Token: 0x040017A9 RID: 6057
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

	// Token: 0x040017AA RID: 6058
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Void_0;

	// Token: 0x040017AB RID: 6059
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040017AC RID: 6060
	private static readonly IntPtr NativeMethodInfoPtr_CampaignEnd_Private_Void_Result_CampaignStats_PlayerData_0;

	// Token: 0x040017AD RID: 6061
	private static readonly IntPtr NativeMethodInfoPtr_CampaignSaved_Private_Void_0;

	// Token: 0x040017AE RID: 6062
	private static readonly IntPtr NativeMethodInfoPtr_EntityHit_Private_Void_Hit_0;

	// Token: 0x040017AF RID: 6063
	private static readonly IntPtr NativeMethodInfoPtr_PostEntityHit_Private_Void_Hit_0;

	// Token: 0x040017B0 RID: 6064
	private static readonly IntPtr NativeMethodInfoPtr_StatusApplied_Private_Void_StatusEffectApply_0;

	// Token: 0x040017B1 RID: 6065
	private static readonly IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;

	// Token: 0x040017B2 RID: 6066
	private static readonly IntPtr NativeMethodInfoPtr_EntityOffered_Private_Void_Entity_0;

	// Token: 0x040017B3 RID: 6067
	private static readonly IntPtr NativeMethodInfoPtr_EntityChosen_Private_Void_Entity_0;

	// Token: 0x040017B4 RID: 6068
	private static readonly IntPtr NativeMethodInfoPtr_EntityFlee_Private_Void_Entity_0;

	// Token: 0x040017B5 RID: 6069
	private static readonly IntPtr NativeMethodInfoPtr_EntityDiscarded_Private_Void_Entity_0;

	// Token: 0x040017B6 RID: 6070
	private static readonly IntPtr NativeMethodInfoPtr_EntitySummoned_Private_Void_Entity_Entity_0;

	// Token: 0x040017B7 RID: 6071
	private static readonly IntPtr NativeMethodInfoPtr_EntityTriggered_Private_Void_byref_Trigger_0;

	// Token: 0x040017B8 RID: 6072
	private static readonly IntPtr NativeMethodInfoPtr_CardInjured_Private_Void_CardData_0;

	// Token: 0x040017B9 RID: 6073
	private static readonly IntPtr NativeMethodInfoPtr_BattleStart_Private_Void_0;

	// Token: 0x040017BA RID: 6074
	private static readonly IntPtr NativeMethodInfoPtr_BattleEnd_Private_Void_0;

	// Token: 0x040017BB RID: 6075
	private static readonly IntPtr NativeMethodInfoPtr_DropGold_Private_Void_Int32_String_Character_Vector3_0;

	// Token: 0x040017BC RID: 6076
	private static readonly IntPtr NativeMethodInfoPtr_SpendGold_Private_Void_Int32_0;

	// Token: 0x040017BD RID: 6077
	private static readonly IntPtr NativeMethodInfoPtr_ShopItemPurchase_Private_Void_ShopItem_0;

	// Token: 0x040017BE RID: 6078
	private static readonly IntPtr NativeMethodInfoPtr_ShopItemHaggled_Private_Void_ShopItem_0;

	// Token: 0x040017BF RID: 6079
	private static readonly IntPtr NativeMethodInfoPtr_KillCombo_Private_Void_Int32_0;

	// Token: 0x040017C0 RID: 6080
	private static readonly IntPtr NativeMethodInfoPtr_RedrawBellHit_Private_Void_RedrawBellSystem_0;

	// Token: 0x040017C1 RID: 6081
	private static readonly IntPtr NativeMethodInfoPtr_WaveDeployerEarlyDeploy_Private_Void_0;

	// Token: 0x040017C2 RID: 6082
	private static readonly IntPtr NativeMethodInfoPtr_BattleTurnStart_Private_Void_Int32_0;

	// Token: 0x040017C3 RID: 6083
	private static readonly IntPtr NativeMethodInfoPtr_Rename_Private_Void_Entity_String_0;

	// Token: 0x040017C4 RID: 6084
	private static readonly IntPtr NativeMethodInfoPtr_MuncherFeed_Private_Void_Entity_0;

	// Token: 0x040017C5 RID: 6085
	private static readonly IntPtr NativeMethodInfoPtr_UpgradeGained_Private_Void_CardUpgradeData_0;

	// Token: 0x040017C6 RID: 6086
	private static readonly IntPtr NativeMethodInfoPtr_UpgradeAssigned_Private_Void_Entity_CardUpgradeData_0;

	// Token: 0x040017C7 RID: 6087
	private static readonly IntPtr NativeMethodInfoPtr_GetBattleName_Private_Static_String_0;

	// Token: 0x040017C8 RID: 6088
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200071B RID: 1819
	[ObfuscatedName("StatsSystem+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x0600793D RID: 31037 RVA: 0x001D3FD4 File Offset: 0x001D21D4
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StatsSystem>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr);
			StatsSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, "<>9");
			StatsSystem.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, "<>9__18_0");
			StatsSystem.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, "<>9__26_0");
			StatsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, 100669593);
			StatsSystem.__c.NativeMethodInfoPtr__EntityKilled_b__18_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, 100669594);
			StatsSystem.__c.NativeMethodInfoPtr__BattleStart_b__26_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr, 100669595);
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x001D4078 File Offset: 0x001D2278
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatsSystem.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x001D40B4 File Offset: 0x001D22B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77311, XrefRangeEnd = 77315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _EntityKilled_b__18_0(StatusEffectData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.__c.NativeMethodInfoPtr__EntityKilled_b__18_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x001D4104 File Offset: 0x001D2304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77315, XrefRangeEnd = 77316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BattleStart_b__26_0(Entity a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StatsSystem.__c.NativeMethodInfoPtr__BattleStart_b__26_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x0003B75E File Offset: 0x0003995E
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x06007942 RID: 31042 RVA: 0x001D4154 File Offset: 0x001D2354
		// (set) Token: 0x06007943 RID: 31043 RVA: 0x0003B767 File Offset: 0x00039967
		public unsafe static StatsSystem.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StatsSystem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatsSystem.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StatsSystem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x06007944 RID: 31044 RVA: 0x001D417C File Offset: 0x001D237C
		// (set) Token: 0x06007945 RID: 31045 RVA: 0x0003B779 File Offset: 0x00039979
		public unsafe static Predicate<StatusEffectData> __9__18_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StatsSystem.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<StatusEffectData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StatsSystem.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x06007946 RID: 31046 RVA: 0x001D41A4 File Offset: 0x001D23A4
		// (set) Token: 0x06007947 RID: 31047 RVA: 0x0003B78B File Offset: 0x0003998B
		public unsafe static Func<Entity, bool> __9__26_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StatsSystem.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StatsSystem.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004E2D RID: 20013
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04004E2E RID: 20014
		private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

		// Token: 0x04004E2F RID: 20015
		private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

		// Token: 0x04004E30 RID: 20016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004E31 RID: 20017
		private static readonly IntPtr NativeMethodInfoPtr__EntityKilled_b__18_0_Internal_Boolean_StatusEffectData_0;

		// Token: 0x04004E32 RID: 20018
		private static readonly IntPtr NativeMethodInfoPtr__BattleStart_b__26_0_Internal_Boolean_Entity_0;
	}
}

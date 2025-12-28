using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

// Token: 0x020001DF RID: 479
public class BattleSaveSystem : GameSystem
{
	// Token: 0x06002235 RID: 8757 RVA: 0x000BCA54 File Offset: 0x000BAC54
	// Note: this type is marked as 'beforefieldinit'.
	static BattleSaveSystem()
	{
		Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BattleSaveSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr);
		BattleSaveSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "instance");
		BattleSaveSystem.NativeFieldInfoPtr_loading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "loading");
		BattleSaveSystem.NativeFieldInfoPtr_justLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "justLoaded");
		BattleSaveSystem.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "state");
		BattleSaveSystem.NativeFieldInfoPtr_saveRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "saveRequired");
		BattleSaveSystem.NativeFieldInfoPtr_campaignNodeIdSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "campaignNodeIdSet");
		BattleSaveSystem.NativeFieldInfoPtr_campaignNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "campaignNodeId");
		BattleSaveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669047);
		BattleSaveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669048);
		BattleSaveSystem.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669049);
		BattleSaveSystem.NativeMethodInfoPtr_GetBattleState_Public_Static_BattleSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669050);
		BattleSaveSystem.NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669051);
		BattleSaveSystem.NativeMethodInfoPtr_CampaignFinal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669052);
		BattleSaveSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669053);
		BattleSaveSystem.NativeMethodInfoPtr_Save_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669054);
		BattleSaveSystem.NativeMethodInfoPtr_BuildBattleState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669055);
		BattleSaveSystem.NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669056);
		BattleSaveSystem.NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_BattleSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669057);
		BattleSaveSystem.NativeMethodInfoPtr_LoadRoutine_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669058);
		BattleSaveSystem.NativeMethodInfoPtr_CreateCardsInRows_Private_Static_IEnumerator_IReadOnlyList_1_CardSlotLane_IReadOnlyList_1_Container_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669059);
		BattleSaveSystem.NativeMethodInfoPtr_CreateCards_Private_Static_IEnumerator_CardContainer_IReadOnlyList_1_BattleEntityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669060);
		BattleSaveSystem.NativeMethodInfoPtr_CreateCard_Private_Static_IEnumerator_BattleEntityData_CardController_Character_UnityAction_1_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669061);
		BattleSaveSystem.NativeMethodInfoPtr_UpdateCard_Private_Static_IEnumerator_Entity_IReadOnlyDictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669062);
		BattleSaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, 100669063);
	}

	// Token: 0x06002236 RID: 8758 RVA: 0x000BCC64 File Offset: 0x000BAE64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70316, XrefRangeEnd = 70335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002237 RID: 8759 RVA: 0x000BCC98 File Offset: 0x000BAE98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70335, XrefRangeEnd = 70350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002238 RID: 8760 RVA: 0x000BCCCC File Offset: 0x000BAECC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70350, XrefRangeEnd = 70351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnApplicationQuit()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002239 RID: 8761 RVA: 0x000BCD00 File Offset: 0x000BAF00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70351, XrefRangeEnd = 70353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BattleSaveData GetBattleState()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_GetBattleState_Public_Static_BattleSaveData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<BattleSaveData>(intPtr3) : null;
	}

	// Token: 0x0600223A RID: 8762 RVA: 0x000BCD34 File Offset: 0x000BAF34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70353, XrefRangeEnd = 70354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattleTurnEnd(int turnCount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref turnCount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600223B RID: 8763 RVA: 0x000BCD74 File Offset: 0x000BAF74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CampaignFinal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CampaignFinal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600223C RID: 8764 RVA: 0x000BCDA8 File Offset: 0x000BAFA8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 70379, RefRangeEnd = 70381, XrefRangeStart = 70354, XrefRangeEnd = 70379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckSave()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CheckSave_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600223D RID: 8765 RVA: 0x000BCDDC File Offset: 0x000BAFDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70381, XrefRangeEnd = 70402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_Save_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600223E RID: 8766 RVA: 0x000BCE10 File Offset: 0x000BB010
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 70561, RefRangeEnd = 70562, XrefRangeStart = 70402, XrefRangeEnd = 70561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildBattleState()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_BuildBattleState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600223F RID: 8767 RVA: 0x000BCE44 File Offset: 0x000BB044
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70562, XrefRangeEnd = 70573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryLoadBattleState(CampaignNode campaignNode)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(campaignNode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002240 RID: 8768 RVA: 0x000BCE94 File Offset: 0x000BB094
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70573, XrefRangeEnd = 70574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryLoadBattleState(BattleSaveData state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_BattleSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002241 RID: 8769 RVA: 0x000BCEE4 File Offset: 0x000BB0E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70574, XrefRangeEnd = 70579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator LoadRoutine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_LoadRoutine_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06002242 RID: 8770 RVA: 0x000BCF24 File Offset: 0x000BB124
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 70585, RefRangeEnd = 70587, XrefRangeStart = 70579, XrefRangeEnd = 70585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator CreateCardsInRows(IReadOnlyList<CardSlotLane> rows, IReadOnlyList<BattleSaveData.Container> rowSaveDatas)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rows);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rowSaveDatas);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CreateCardsInRows_Private_Static_IEnumerator_IReadOnlyList_1_CardSlotLane_IReadOnlyList_1_Container_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06002243 RID: 8771 RVA: 0x000BCF7C File Offset: 0x000BB17C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 70593, RefRangeEnd = 70598, XrefRangeStart = 70587, XrefRangeEnd = 70593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator CreateCards(CardContainer container, IReadOnlyList<BattleEntityData> entitySaveData)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entitySaveData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CreateCards_Private_Static_IEnumerator_CardContainer_IReadOnlyList_1_BattleEntityData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06002244 RID: 8772 RVA: 0x000BCFD4 File Offset: 0x000BB1D4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 70606, RefRangeEnd = 70608, XrefRangeStart = 70598, XrefRangeEnd = 70606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator CreateCard(BattleEntityData entityData, CardController cardController, Character owner, UnityAction<Card> onComplete)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityData);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardController);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onComplete);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_CreateCard_Private_Static_IEnumerator_BattleEntityData_CardController_Character_UnityAction_1_Card_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06002245 RID: 8773 RVA: 0x000BD050 File Offset: 0x000BB250
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 70614, RefRangeEnd = 70615, XrefRangeStart = 70608, XrefRangeEnd = 70614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator UpdateCard(Entity card, IReadOnlyDictionary<string, Object> customDatas)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(customDatas);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr_UpdateCard_Private_Static_IEnumerator_Entity_IReadOnlyDictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06002246 RID: 8774 RVA: 0x000BD0A8 File Offset: 0x000BB2A8
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 21506, RefRangeEnd = 21513, XrefRangeStart = 21506, XrefRangeEnd = 21513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleSaveSystem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002247 RID: 8775 RVA: 0x00013691 File Offset: 0x00011891
	public BattleSaveSystem(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170009D1 RID: 2513
	// (get) Token: 0x06002248 RID: 8776 RVA: 0x000BD0E4 File Offset: 0x000BB2E4
	// (set) Token: 0x06002249 RID: 8777 RVA: 0x0001369A File Offset: 0x0001189A
	public unsafe static BattleSaveSystem instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveSystem>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009D2 RID: 2514
	// (get) Token: 0x0600224A RID: 8778 RVA: 0x000BD10C File Offset: 0x000BB30C
	// (set) Token: 0x0600224B RID: 8779 RVA: 0x000136AC File Offset: 0x000118AC
	public unsafe bool loading
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_loading);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_loading)) = value;
		}
	}

	// Token: 0x170009D3 RID: 2515
	// (get) Token: 0x0600224C RID: 8780 RVA: 0x000BD134 File Offset: 0x000BB334
	// (set) Token: 0x0600224D RID: 8781 RVA: 0x000136C7 File Offset: 0x000118C7
	public unsafe bool justLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_justLoaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_justLoaded)) = value;
		}
	}

	// Token: 0x170009D4 RID: 2516
	// (get) Token: 0x0600224E RID: 8782 RVA: 0x000BD15C File Offset: 0x000BB35C
	// (set) Token: 0x0600224F RID: 8783 RVA: 0x000136E2 File Offset: 0x000118E2
	public unsafe BattleSaveData state
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_state);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009D5 RID: 2517
	// (get) Token: 0x06002250 RID: 8784 RVA: 0x000BD18C File Offset: 0x000BB38C
	// (set) Token: 0x06002251 RID: 8785 RVA: 0x00013701 File Offset: 0x00011901
	public unsafe bool saveRequired
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_saveRequired);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_saveRequired)) = value;
		}
	}

	// Token: 0x170009D6 RID: 2518
	// (get) Token: 0x06002252 RID: 8786 RVA: 0x000BD1B4 File Offset: 0x000BB3B4
	// (set) Token: 0x06002253 RID: 8787 RVA: 0x0001371C File Offset: 0x0001191C
	public unsafe bool campaignNodeIdSet
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_campaignNodeIdSet);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_campaignNodeIdSet)) = value;
		}
	}

	// Token: 0x170009D7 RID: 2519
	// (get) Token: 0x06002254 RID: 8788 RVA: 0x000BD1DC File Offset: 0x000BB3DC
	// (set) Token: 0x06002255 RID: 8789 RVA: 0x00013737 File Offset: 0x00011937
	public unsafe int campaignNodeId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_campaignNodeId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.NativeFieldInfoPtr_campaignNodeId)) = value;
		}
	}

	// Token: 0x04001574 RID: 5492
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x04001575 RID: 5493
	private static readonly IntPtr NativeFieldInfoPtr_loading;

	// Token: 0x04001576 RID: 5494
	private static readonly IntPtr NativeFieldInfoPtr_justLoaded;

	// Token: 0x04001577 RID: 5495
	private static readonly IntPtr NativeFieldInfoPtr_state;

	// Token: 0x04001578 RID: 5496
	private static readonly IntPtr NativeFieldInfoPtr_saveRequired;

	// Token: 0x04001579 RID: 5497
	private static readonly IntPtr NativeFieldInfoPtr_campaignNodeIdSet;

	// Token: 0x0400157A RID: 5498
	private static readonly IntPtr NativeFieldInfoPtr_campaignNodeId;

	// Token: 0x0400157B RID: 5499
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x0400157C RID: 5500
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x0400157D RID: 5501
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Private_Void_0;

	// Token: 0x0400157E RID: 5502
	private static readonly IntPtr NativeMethodInfoPtr_GetBattleState_Public_Static_BattleSaveData_0;

	// Token: 0x0400157F RID: 5503
	private static readonly IntPtr NativeMethodInfoPtr_BattleTurnEnd_Private_Void_Int32_0;

	// Token: 0x04001580 RID: 5504
	private static readonly IntPtr NativeMethodInfoPtr_CampaignFinal_Private_Void_0;

	// Token: 0x04001581 RID: 5505
	private static readonly IntPtr NativeMethodInfoPtr_CheckSave_Private_Void_0;

	// Token: 0x04001582 RID: 5506
	private static readonly IntPtr NativeMethodInfoPtr_Save_Private_Void_0;

	// Token: 0x04001583 RID: 5507
	private static readonly IntPtr NativeMethodInfoPtr_BuildBattleState_Private_Void_0;

	// Token: 0x04001584 RID: 5508
	private static readonly IntPtr NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_CampaignNode_0;

	// Token: 0x04001585 RID: 5509
	private static readonly IntPtr NativeMethodInfoPtr_TryLoadBattleState_Public_Boolean_BattleSaveData_0;

	// Token: 0x04001586 RID: 5510
	private static readonly IntPtr NativeMethodInfoPtr_LoadRoutine_Public_IEnumerator_0;

	// Token: 0x04001587 RID: 5511
	private static readonly IntPtr NativeMethodInfoPtr_CreateCardsInRows_Private_Static_IEnumerator_IReadOnlyList_1_CardSlotLane_IReadOnlyList_1_Container_0;

	// Token: 0x04001588 RID: 5512
	private static readonly IntPtr NativeMethodInfoPtr_CreateCards_Private_Static_IEnumerator_CardContainer_IReadOnlyList_1_BattleEntityData_0;

	// Token: 0x04001589 RID: 5513
	private static readonly IntPtr NativeMethodInfoPtr_CreateCard_Private_Static_IEnumerator_BattleEntityData_CardController_Character_UnityAction_1_Card_0;

	// Token: 0x0400158A RID: 5514
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCard_Private_Static_IEnumerator_Entity_IReadOnlyDictionary_2_String_Object_0;

	// Token: 0x0400158B RID: 5515
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020006E3 RID: 1763
	[ObfuscatedName("BattleSaveSystem+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06007746 RID: 30534 RVA: 0x001CE558 File Offset: 0x001CC758
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr);
			BattleSaveSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9");
			BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9__15_0");
			BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9__15_1");
			BattleSaveSystem.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9__18_0");
			BattleSaveSystem.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, "<>9__21_0");
			BattleSaveSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100669065);
			BattleSaveSystem.__c.NativeMethodInfoPtr__BuildBattleState_b__15_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100669066);
			BattleSaveSystem.__c.NativeMethodInfoPtr__BuildBattleState_b__15_1_Internal_Status_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100669067);
			BattleSaveSystem.__c.NativeMethodInfoPtr__LoadRoutine_b__18_0_Internal_CardData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100669068);
			BattleSaveSystem.__c.NativeMethodInfoPtr__CreateCard_b__21_0_Internal_StatusEffectStacks_StatusEffectSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr, 100669069);
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x001CE64C File Offset: 0x001CC84C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x001CE688 File Offset: 0x001CC888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69858, XrefRangeEnd = 69865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _BuildBattleState_b__15_0(StatusEffectData e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__BuildBattleState_b__15_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x001CE6D8 File Offset: 0x001CC8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69865, XrefRangeEnd = 69869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BattleSaveData.Status _BuildBattleState_b__15_1(StatusEffectData e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__BuildBattleState_b__15_1_Internal_Status_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Status>(intPtr3) : null;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x001CE728 File Offset: 0x001CC928
		[CallerCount(0)]
		public unsafe CardData _LoadRoutine_b__18_0(Entity a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__LoadRoutine_b__18_0_Internal_CardData_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr3) : null;
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x001CE778 File Offset: 0x001CC978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69869, XrefRangeEnd = 69871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardData.StatusEffectStacks _CreateCard_b__21_0(StatusEffectSaveData e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c.NativeMethodInfoPtr__CreateCard_b__21_0_Internal_StatusEffectStacks_StatusEffectSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData.StatusEffectStacks>(intPtr3) : null;
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x0003A6EA File Offset: 0x000388EA
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024E1 RID: 9441
		// (get) Token: 0x0600774D RID: 30541 RVA: 0x001CE7C8 File Offset: 0x001CC9C8
		// (set) Token: 0x0600774E RID: 30542 RVA: 0x0003A6F3 File Offset: 0x000388F3
		public unsafe static BattleSaveSystem.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveSystem.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E2 RID: 9442
		// (get) Token: 0x0600774F RID: 30543 RVA: 0x001CE7F0 File Offset: 0x001CC9F0
		// (set) Token: 0x06007750 RID: 30544 RVA: 0x0003A705 File Offset: 0x00038905
		public unsafe static Func<StatusEffectData, bool> __9__15_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StatusEffectData, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E3 RID: 9443
		// (get) Token: 0x06007751 RID: 30545 RVA: 0x001CE818 File Offset: 0x001CCA18
		// (set) Token: 0x06007752 RID: 30546 RVA: 0x0003A717 File Offset: 0x00038917
		public unsafe static Func<StatusEffectData, BattleSaveData.Status> __9__15_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StatusEffectData, BattleSaveData.Status>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E4 RID: 9444
		// (get) Token: 0x06007753 RID: 30547 RVA: 0x001CE840 File Offset: 0x001CCA40
		// (set) Token: 0x06007754 RID: 30548 RVA: 0x0003A729 File Offset: 0x00038929
		public unsafe static Func<Entity, CardData> __9__18_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, CardData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E5 RID: 9445
		// (get) Token: 0x06007755 RID: 30549 RVA: 0x001CE868 File Offset: 0x001CCA68
		// (set) Token: 0x06007756 RID: 30550 RVA: 0x0003A73B File Offset: 0x0003893B
		public unsafe static Func<StatusEffectSaveData, CardData.StatusEffectStacks> __9__21_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StatusEffectSaveData, CardData.StatusEffectStacks>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BattleSaveSystem.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D12 RID: 19730
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04004D13 RID: 19731
		private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

		// Token: 0x04004D14 RID: 19732
		private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

		// Token: 0x04004D15 RID: 19733
		private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

		// Token: 0x04004D16 RID: 19734
		private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

		// Token: 0x04004D17 RID: 19735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D18 RID: 19736
		private static readonly IntPtr NativeMethodInfoPtr__BuildBattleState_b__15_0_Internal_Boolean_StatusEffectData_0;

		// Token: 0x04004D19 RID: 19737
		private static readonly IntPtr NativeMethodInfoPtr__BuildBattleState_b__15_1_Internal_Status_StatusEffectData_0;

		// Token: 0x04004D1A RID: 19738
		private static readonly IntPtr NativeMethodInfoPtr__LoadRoutine_b__18_0_Internal_CardData_Entity_0;

		// Token: 0x04004D1B RID: 19739
		private static readonly IntPtr NativeMethodInfoPtr__CreateCard_b__21_0_Internal_StatusEffectStacks_StatusEffectSaveData_0;
	}

	// Token: 0x020006E4 RID: 1764
	[ObfuscatedName("BattleSaveSystem+<>c__DisplayClass18_0")]
	public sealed class __c__DisplayClass18_0 : Object
	{
		// Token: 0x06007757 RID: 30551 RVA: 0x001CE890 File Offset: 0x001CCA90
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass18_0()
		{
			Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass18_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr);
			BattleSaveSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr, "status");
			BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr, 100669070);
			BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadRoutine_b__1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr, 100669071);
			BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadRoutine_b__2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr, 100669072);
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x001CE90C File Offset: 0x001CCB0C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass18_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x001CE948 File Offset: 0x001CCB48
		[CallerCount(0)]
		public unsafe bool _LoadRoutine_b__1(Entity a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadRoutine_b__1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x001CE998 File Offset: 0x001CCB98
		[CallerCount(0)]
		public unsafe bool _LoadRoutine_b__2(Entity a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass18_0.NativeMethodInfoPtr__LoadRoutine_b__2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x0003A74D File Offset: 0x0003894D
		public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024E6 RID: 9446
		// (get) Token: 0x0600775C RID: 30556 RVA: 0x001CE9E8 File Offset: 0x001CCBE8
		// (set) Token: 0x0600775D RID: 30557 RVA: 0x0003A756 File Offset: 0x00038956
		public unsafe BattleSaveData.Status status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_status);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Status>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass18_0.NativeFieldInfoPtr_status), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D1C RID: 19740
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04004D1D RID: 19741
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D1E RID: 19742
		private static readonly IntPtr NativeMethodInfoPtr__LoadRoutine_b__1_Internal_Boolean_Entity_0;

		// Token: 0x04004D1F RID: 19743
		private static readonly IntPtr NativeMethodInfoPtr__LoadRoutine_b__2_Internal_Boolean_Entity_0;
	}

	// Token: 0x020006E5 RID: 1765
	[ObfuscatedName("BattleSaveSystem+<LoadRoutine>d__18")]
	public sealed class _LoadRoutine_d__18 : Object
	{
		// Token: 0x0600775E RID: 30558 RVA: 0x001CEA18 File Offset: 0x001CCC18
		// Note: this type is marked as 'beforefieldinit'.
		static _LoadRoutine_d__18()
		{
			Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<LoadRoutine>d__18");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr);
			BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>1__state");
			BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>2__current");
			BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>4__this");
			BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>7__wrap1");
			BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>7__wrap2");
			BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, "<>7__wrap3");
			BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100669073);
			BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100669074);
			BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100669075);
			BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100669076);
			BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100669077);
			BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100669078);
			BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr, 100669079);
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x001CEB48 File Offset: 0x001CCD48
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _LoadRoutine_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._LoadRoutine_d__18>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x001CEB90 File Offset: 0x001CCD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69876, RefRangeEnd = 69877, XrefRangeStart = 69871, XrefRangeEnd = 69876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x001CEBC4 File Offset: 0x001CCDC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69877, XrefRangeEnd = 70055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x001CEC00 File Offset: 0x001CCE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70055, XrefRangeEnd = 70058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170024ED RID: 9453
		// (get) Token: 0x06007763 RID: 30563 RVA: 0x001CEC34 File Offset: 0x001CCE34
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x001CEC74 File Offset: 0x001CCE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70058, XrefRangeEnd = 70064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170024EE RID: 9454
		// (get) Token: 0x06007765 RID: 30565 RVA: 0x001CECA8 File Offset: 0x001CCEA8
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._LoadRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x0003A775 File Offset: 0x00038975
		public _LoadRoutine_d__18(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024E7 RID: 9447
		// (get) Token: 0x06007767 RID: 30567 RVA: 0x001CECE8 File Offset: 0x001CCEE8
		// (set) Token: 0x06007768 RID: 30568 RVA: 0x0003A77E File Offset: 0x0003897E
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170024E8 RID: 9448
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x001CED10 File Offset: 0x001CCF10
		// (set) Token: 0x0600776A RID: 30570 RVA: 0x0003A799 File Offset: 0x00038999
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x0600776B RID: 30571 RVA: 0x001CED40 File Offset: 0x001CCF40
		// (set) Token: 0x0600776C RID: 30572 RVA: 0x0003A7B8 File Offset: 0x000389B8
		public unsafe BattleSaveSystem __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EA RID: 9450
		// (get) Token: 0x0600776D RID: 30573 RVA: 0x001CED70 File Offset: 0x001CCF70
		// (set) Token: 0x0600776E RID: 30574 RVA: 0x0003A7D7 File Offset: 0x000389D7
		public unsafe Il2CppReferenceArray<BattleSaveData.Status> __7__wrap1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BattleSaveData.Status>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024EB RID: 9451
		// (get) Token: 0x0600776F RID: 30575 RVA: 0x001CEDA0 File Offset: 0x001CCFA0
		// (set) Token: 0x06007770 RID: 30576 RVA: 0x0003A7F6 File Offset: 0x000389F6
		public unsafe int __7__wrap2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap2)) = value;
			}
		}

		// Token: 0x170024EC RID: 9452
		// (get) Token: 0x06007771 RID: 30577 RVA: 0x001CEDC8 File Offset: 0x001CCFC8
		// (set) Token: 0x06007772 RID: 30578 RVA: 0x0003A811 File Offset: 0x00038A11
		public List<Entity>.Enumerator __7__wrap3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap3);
				return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._LoadRoutine_d__18.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04004D20 RID: 19744
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004D21 RID: 19745
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004D22 RID: 19746
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004D23 RID: 19747
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

		// Token: 0x04004D24 RID: 19748
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

		// Token: 0x04004D25 RID: 19749
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

		// Token: 0x04004D26 RID: 19750
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004D27 RID: 19751
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D28 RID: 19752
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004D29 RID: 19753
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x04004D2A RID: 19754
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004D2B RID: 19755
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D2C RID: 19756
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020006E6 RID: 1766
	[ObfuscatedName("BattleSaveSystem+<>c__DisplayClass19_0")]
	public sealed class __c__DisplayClass19_0 : Object
	{
		// Token: 0x06007773 RID: 30579 RVA: 0x001CEDF8 File Offset: 0x001CCFF8
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass19_0()
		{
			Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass19_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr);
			BattleSaveSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr, "entities");
			BattleSaveSystem.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr, 100669080);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x001CEE4C File Offset: 0x001CD04C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x0003A83F File Offset: 0x00038A3F
		public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024EF RID: 9455
		// (get) Token: 0x06007776 RID: 30582 RVA: 0x001CEE88 File Offset: 0x001CD088
		// (set) Token: 0x06007777 RID: 30583 RVA: 0x0003A848 File Offset: 0x00038A48
		public unsafe Dictionary<ulong, Entity> entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ulong, Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_0.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D2D RID: 19757
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04004D2E RID: 19758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020006E7 RID: 1767
	[ObfuscatedName("BattleSaveSystem+<>c__DisplayClass19_1")]
	public sealed class __c__DisplayClass19_1 : Object
	{
		// Token: 0x06007778 RID: 30584 RVA: 0x001CEEB8 File Offset: 0x001CD0B8
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass19_1()
		{
			Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass19_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr);
			BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_row = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr, "row");
			BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr, "CS$<>8__locals1");
			BattleSaveSystem.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr, 100669081);
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x001CEF20 File Offset: 0x001CD120
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass19_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass19_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x0003A867 File Offset: 0x00038A67
		public __c__DisplayClass19_1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F0 RID: 9456
		// (get) Token: 0x0600777B RID: 30587 RVA: 0x001CEF5C File Offset: 0x001CD15C
		// (set) Token: 0x0600777C RID: 30588 RVA: 0x0003A870 File Offset: 0x00038A70
		public unsafe CardSlotLane row
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_row);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardSlotLane>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_row), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x0600777D RID: 30589 RVA: 0x001CEF8C File Offset: 0x001CD18C
		// (set) Token: 0x0600777E RID: 30590 RVA: 0x0003A88F File Offset: 0x00038A8F
		public unsafe BattleSaveSystem.__c__DisplayClass19_0 field_Public___c__DisplayClass19_0_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveSystem.__c__DisplayClass19_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_1.NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D2F RID: 19759
		private static readonly IntPtr NativeFieldInfoPtr_row;

		// Token: 0x04004D30 RID: 19760
		private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_0_0;

		// Token: 0x04004D31 RID: 19761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020006E8 RID: 1768
	[ObfuscatedName("BattleSaveSystem+<>c__DisplayClass19_2")]
	public sealed class __c__DisplayClass19_2 : Object
	{
		// Token: 0x0600777F RID: 30591 RVA: 0x001CEFBC File Offset: 0x001CD1BC
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass19_2()
		{
			Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass19_2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr);
			BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_d = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, "d");
			BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_entityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, "entityIndex");
			BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, "CS$<>8__locals2");
			BattleSaveSystem.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, 100669082);
			BattleSaveSystem.__c__DisplayClass19_2.NativeMethodInfoPtr__CreateCardsInRows_b__0_Internal_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr, 100669083);
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x001CF04C File Offset: 0x001CD24C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass19_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass19_2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass19_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007781 RID: 30593 RVA: 0x001CF088 File Offset: 0x001CD288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70064, XrefRangeEnd = 70071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateCardsInRows_b__0(Card a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass19_2.NativeMethodInfoPtr__CreateCardsInRows_b__0_Internal_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007782 RID: 30594 RVA: 0x0003A8AE File Offset: 0x00038AAE
		public __c__DisplayClass19_2(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x06007783 RID: 30595 RVA: 0x001CF0CC File Offset: 0x001CD2CC
		// (set) Token: 0x06007784 RID: 30596 RVA: 0x0003A8B7 File Offset: 0x00038AB7
		public unsafe BattleEntityData d
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_d);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleEntityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_d), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F3 RID: 9459
		// (get) Token: 0x06007785 RID: 30597 RVA: 0x001CF0FC File Offset: 0x001CD2FC
		// (set) Token: 0x06007786 RID: 30598 RVA: 0x0003A8D6 File Offset: 0x00038AD6
		public unsafe int entityIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_entityIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_entityIndex)) = value;
			}
		}

		// Token: 0x170024F4 RID: 9460
		// (get) Token: 0x06007787 RID: 30599 RVA: 0x001CF124 File Offset: 0x001CD324
		// (set) Token: 0x06007788 RID: 30600 RVA: 0x0003A8F1 File Offset: 0x00038AF1
		public unsafe BattleSaveSystem.__c__DisplayClass19_1 field_Public___c__DisplayClass19_1_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveSystem.__c__DisplayClass19_1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass19_2.NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D32 RID: 19762
		private static readonly IntPtr NativeFieldInfoPtr_d;

		// Token: 0x04004D33 RID: 19763
		private static readonly IntPtr NativeFieldInfoPtr_entityIndex;

		// Token: 0x04004D34 RID: 19764
		private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass19_1_0;

		// Token: 0x04004D35 RID: 19765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D36 RID: 19766
		private static readonly IntPtr NativeMethodInfoPtr__CreateCardsInRows_b__0_Internal_Void_Card_0;
	}

	// Token: 0x020006E9 RID: 1769
	[ObfuscatedName("BattleSaveSystem+<CreateCardsInRows>d__19")]
	public sealed class _CreateCardsInRows_d__19 : Object
	{
		// Token: 0x06007789 RID: 30601 RVA: 0x001CF154 File Offset: 0x001CD354
		// Note: this type is marked as 'beforefieldinit'.
		static _CreateCardsInRows_d__19()
		{
			Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<CreateCardsInRows>d__19");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr);
			BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<>1__state");
			BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<>2__current");
			BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<>8__1");
			BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "rows");
			BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rowSaveDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "rowSaveDatas");
			BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__cardController_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<cardController>5__2");
			BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__clump_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<clump>5__3");
			BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__rowI_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, "<rowI>5__4");
			BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100669084);
			BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100669085);
			BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100669086);
			BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100669087);
			BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100669088);
			BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr, 100669089);
		}

		// Token: 0x0600778A RID: 30602 RVA: 0x001CF298 File Offset: 0x001CD498
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CreateCardsInRows_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._CreateCardsInRows_d__19>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600778B RID: 30603 RVA: 0x001CF2E0 File Offset: 0x001CD4E0
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600778C RID: 30604 RVA: 0x001CF314 File Offset: 0x001CD514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70071, XrefRangeEnd = 70144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170024FD RID: 9469
		// (get) Token: 0x0600778D RID: 30605 RVA: 0x001CF350 File Offset: 0x001CD550
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600778E RID: 30606 RVA: 0x001CF390 File Offset: 0x001CD590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70144, XrefRangeEnd = 70150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170024FE RID: 9470
		// (get) Token: 0x0600778F RID: 30607 RVA: 0x001CF3C4 File Offset: 0x001CD5C4
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCardsInRows_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x0003A910 File Offset: 0x00038B10
		public _CreateCardsInRows_d__19(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F5 RID: 9461
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x001CF404 File Offset: 0x001CD604
		// (set) Token: 0x06007792 RID: 30610 RVA: 0x0003A919 File Offset: 0x00038B19
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170024F6 RID: 9462
		// (get) Token: 0x06007793 RID: 30611 RVA: 0x001CF42C File Offset: 0x001CD62C
		// (set) Token: 0x06007794 RID: 30612 RVA: 0x0003A934 File Offset: 0x00038B34
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F7 RID: 9463
		// (get) Token: 0x06007795 RID: 30613 RVA: 0x001CF45C File Offset: 0x001CD65C
		// (set) Token: 0x06007796 RID: 30614 RVA: 0x0003A953 File Offset: 0x00038B53
		public unsafe BattleSaveSystem.__c__DisplayClass19_0 __8__1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___8__1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveSystem.__c__DisplayClass19_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F8 RID: 9464
		// (get) Token: 0x06007797 RID: 30615 RVA: 0x001CF48C File Offset: 0x001CD68C
		// (set) Token: 0x06007798 RID: 30616 RVA: 0x0003A972 File Offset: 0x00038B72
		public unsafe IReadOnlyList<CardSlotLane> rows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rows);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<CardSlotLane>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024F9 RID: 9465
		// (get) Token: 0x06007799 RID: 30617 RVA: 0x001CF4BC File Offset: 0x001CD6BC
		// (set) Token: 0x0600779A RID: 30618 RVA: 0x0003A991 File Offset: 0x00038B91
		public unsafe IReadOnlyList<BattleSaveData.Container> rowSaveDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rowSaveDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<BattleSaveData.Container>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr_rowSaveDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FA RID: 9466
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x001CF4EC File Offset: 0x001CD6EC
		// (set) Token: 0x0600779C RID: 30620 RVA: 0x0003A9B0 File Offset: 0x00038BB0
		public unsafe CardController _cardController_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__cardController_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__cardController_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FB RID: 9467
		// (get) Token: 0x0600779D RID: 30621 RVA: 0x001CF51C File Offset: 0x001CD71C
		// (set) Token: 0x0600779E RID: 30622 RVA: 0x0003A9CF File Offset: 0x00038BCF
		public unsafe Routine.Clump _clump_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__clump_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Routine.Clump>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__clump_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024FC RID: 9468
		// (get) Token: 0x0600779F RID: 30623 RVA: 0x001CF54C File Offset: 0x001CD74C
		// (set) Token: 0x060077A0 RID: 30624 RVA: 0x0003A9EE File Offset: 0x00038BEE
		public unsafe int _rowI_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__rowI_5__4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCardsInRows_d__19.NativeFieldInfoPtr__rowI_5__4)) = value;
			}
		}

		// Token: 0x04004D37 RID: 19767
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004D38 RID: 19768
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004D39 RID: 19769
		private static readonly IntPtr NativeFieldInfoPtr___8__1;

		// Token: 0x04004D3A RID: 19770
		private static readonly IntPtr NativeFieldInfoPtr_rows;

		// Token: 0x04004D3B RID: 19771
		private static readonly IntPtr NativeFieldInfoPtr_rowSaveDatas;

		// Token: 0x04004D3C RID: 19772
		private static readonly IntPtr NativeFieldInfoPtr__cardController_5__2;

		// Token: 0x04004D3D RID: 19773
		private static readonly IntPtr NativeFieldInfoPtr__clump_5__3;

		// Token: 0x04004D3E RID: 19774
		private static readonly IntPtr NativeFieldInfoPtr__rowI_5__4;

		// Token: 0x04004D3F RID: 19775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004D40 RID: 19776
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D41 RID: 19777
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004D42 RID: 19778
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004D43 RID: 19779
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D44 RID: 19780
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020006EA RID: 1770
	[ObfuscatedName("BattleSaveSystem+<>c__DisplayClass20_0")]
	public sealed class __c__DisplayClass20_0 : Object
	{
		// Token: 0x060077A1 RID: 30625 RVA: 0x001CF574 File Offset: 0x001CD774
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass20_0()
		{
			Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass20_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr);
			BattleSaveSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr, "entities");
			BattleSaveSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr, 100669090);
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x001CF5C8 File Offset: 0x001CD7C8
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x0003AA09 File Offset: 0x00038C09
		public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024FF RID: 9471
		// (get) Token: 0x060077A4 RID: 30628 RVA: 0x001CF604 File Offset: 0x001CD804
		// (set) Token: 0x060077A5 RID: 30629 RVA: 0x0003AA12 File Offset: 0x00038C12
		public unsafe Il2CppReferenceArray<Entity> entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_0.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D45 RID: 19781
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04004D46 RID: 19782
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020006EB RID: 1771
	[ObfuscatedName("BattleSaveSystem+<>c__DisplayClass20_1")]
	public sealed class __c__DisplayClass20_1 : Object
	{
		// Token: 0x060077A6 RID: 30630 RVA: 0x001CF634 File Offset: 0x001CD834
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass20_1()
		{
			Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<>c__DisplayClass20_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr);
			BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_arrayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr, "arrayIndex");
			BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr, "CS$<>8__locals1");
			BattleSaveSystem.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr, 100669091);
			BattleSaveSystem.__c__DisplayClass20_1.NativeMethodInfoPtr__CreateCards_b__0_Internal_Void_Card_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr, 100669092);
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x001CF6B0 File Offset: 0x001CD8B0
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass20_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem.__c__DisplayClass20_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass20_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x001CF6EC File Offset: 0x001CD8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70150, XrefRangeEnd = 70156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateCards_b__0(Card a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem.__c__DisplayClass20_1.NativeMethodInfoPtr__CreateCards_b__0_Internal_Void_Card_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x0003AA31 File Offset: 0x00038C31
		public __c__DisplayClass20_1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002500 RID: 9472
		// (get) Token: 0x060077AA RID: 30634 RVA: 0x001CF730 File Offset: 0x001CD930
		// (set) Token: 0x060077AB RID: 30635 RVA: 0x0003AA3A File Offset: 0x00038C3A
		public unsafe int arrayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_arrayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_arrayIndex)) = value;
			}
		}

		// Token: 0x17002501 RID: 9473
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x001CF758 File Offset: 0x001CD958
		// (set) Token: 0x060077AD RID: 30637 RVA: 0x0003AA55 File Offset: 0x00038C55
		public unsafe BattleSaveSystem.__c__DisplayClass20_0 field_Public___c__DisplayClass20_0_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveSystem.__c__DisplayClass20_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem.__c__DisplayClass20_1.NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D47 RID: 19783
		private static readonly IntPtr NativeFieldInfoPtr_arrayIndex;

		// Token: 0x04004D48 RID: 19784
		private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass20_0_0;

		// Token: 0x04004D49 RID: 19785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004D4A RID: 19786
		private static readonly IntPtr NativeMethodInfoPtr__CreateCards_b__0_Internal_Void_Card_0;
	}

	// Token: 0x020006EC RID: 1772
	[ObfuscatedName("BattleSaveSystem+<CreateCards>d__20")]
	public sealed class _CreateCards_d__20 : Object
	{
		// Token: 0x060077AE RID: 30638 RVA: 0x001CF788 File Offset: 0x001CD988
		// Note: this type is marked as 'beforefieldinit'.
		static _CreateCards_d__20()
		{
			Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<CreateCards>d__20");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr);
			BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, "<>1__state");
			BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, "<>2__current");
			BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, "container");
			BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_entitySaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, "entitySaveData");
			BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, "<>8__1");
			BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100669093);
			BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100669094);
			BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100669095);
			BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100669096);
			BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100669097);
			BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr, 100669098);
		}

		// Token: 0x060077AF RID: 30639 RVA: 0x001CF890 File Offset: 0x001CDA90
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CreateCards_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._CreateCards_d__20>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B0 RID: 30640 RVA: 0x001CF8D8 File Offset: 0x001CDAD8
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077B1 RID: 30641 RVA: 0x001CF90C File Offset: 0x001CDB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70156, XrefRangeEnd = 70199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002507 RID: 9479
		// (get) Token: 0x060077B2 RID: 30642 RVA: 0x001CF948 File Offset: 0x001CDB48
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060077B3 RID: 30643 RVA: 0x001CF988 File Offset: 0x001CDB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70199, XrefRangeEnd = 70205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x060077B4 RID: 30644 RVA: 0x001CF9BC File Offset: 0x001CDBBC
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCards_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060077B5 RID: 30645 RVA: 0x0003AA74 File Offset: 0x00038C74
		public _CreateCards_d__20(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002502 RID: 9474
		// (get) Token: 0x060077B6 RID: 30646 RVA: 0x001CF9FC File Offset: 0x001CDBFC
		// (set) Token: 0x060077B7 RID: 30647 RVA: 0x0003AA7D File Offset: 0x00038C7D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002503 RID: 9475
		// (get) Token: 0x060077B8 RID: 30648 RVA: 0x001CFA24 File Offset: 0x001CDC24
		// (set) Token: 0x060077B9 RID: 30649 RVA: 0x0003AA98 File Offset: 0x00038C98
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002504 RID: 9476
		// (get) Token: 0x060077BA RID: 30650 RVA: 0x001CFA54 File Offset: 0x001CDC54
		// (set) Token: 0x060077BB RID: 30651 RVA: 0x0003AAB7 File Offset: 0x00038CB7
		public unsafe CardContainer container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002505 RID: 9477
		// (get) Token: 0x060077BC RID: 30652 RVA: 0x001CFA84 File Offset: 0x001CDC84
		// (set) Token: 0x060077BD RID: 30653 RVA: 0x0003AAD6 File Offset: 0x00038CD6
		public unsafe IReadOnlyList<BattleEntityData> entitySaveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_entitySaveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<BattleEntityData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr_entitySaveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002506 RID: 9478
		// (get) Token: 0x060077BE RID: 30654 RVA: 0x001CFAB4 File Offset: 0x001CDCB4
		// (set) Token: 0x060077BF RID: 30655 RVA: 0x0003AAF5 File Offset: 0x00038CF5
		public unsafe BattleSaveSystem.__c__DisplayClass20_0 __8__1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___8__1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveSystem.__c__DisplayClass20_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCards_d__20.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D4B RID: 19787
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004D4C RID: 19788
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004D4D RID: 19789
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04004D4E RID: 19790
		private static readonly IntPtr NativeFieldInfoPtr_entitySaveData;

		// Token: 0x04004D4F RID: 19791
		private static readonly IntPtr NativeFieldInfoPtr___8__1;

		// Token: 0x04004D50 RID: 19792
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004D51 RID: 19793
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D52 RID: 19794
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004D53 RID: 19795
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004D54 RID: 19796
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D55 RID: 19797
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020006ED RID: 1773
	[ObfuscatedName("BattleSaveSystem+<CreateCard>d__21")]
	public sealed class _CreateCard_d__21 : Object
	{
		// Token: 0x060077C0 RID: 30656 RVA: 0x001CFAE4 File Offset: 0x001CDCE4
		// Note: this type is marked as 'beforefieldinit'.
		static _CreateCard_d__21()
		{
			Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<CreateCard>d__21");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr);
			BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "<>1__state");
			BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "<>2__current");
			BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_entityData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "entityData");
			BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "cardController");
			BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "owner");
			BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_onComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "onComplete");
			BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr__entity_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, "<entity>5__2");
			BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100669099);
			BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100669100);
			BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100669101);
			BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100669102);
			BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100669103);
			BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr, 100669104);
		}

		// Token: 0x060077C1 RID: 30657 RVA: 0x001CFC14 File Offset: 0x001CDE14
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CreateCard_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._CreateCard_d__21>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C2 RID: 30658 RVA: 0x001CFC5C File Offset: 0x001CDE5C
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x001CFC90 File Offset: 0x001CDE90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70205, XrefRangeEnd = 70274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002510 RID: 9488
		// (get) Token: 0x060077C4 RID: 30660 RVA: 0x001CFCCC File Offset: 0x001CDECC
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x001CFD0C File Offset: 0x001CDF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70274, XrefRangeEnd = 70280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002511 RID: 9489
		// (get) Token: 0x060077C6 RID: 30662 RVA: 0x001CFD40 File Offset: 0x001CDF40
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._CreateCard_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x0003AB14 File Offset: 0x00038D14
		public _CreateCard_d__21(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x060077C8 RID: 30664 RVA: 0x001CFD80 File Offset: 0x001CDF80
		// (set) Token: 0x060077C9 RID: 30665 RVA: 0x0003AB1D File Offset: 0x00038D1D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x060077CA RID: 30666 RVA: 0x001CFDA8 File Offset: 0x001CDFA8
		// (set) Token: 0x060077CB RID: 30667 RVA: 0x0003AB38 File Offset: 0x00038D38
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x060077CC RID: 30668 RVA: 0x001CFDD8 File Offset: 0x001CDFD8
		// (set) Token: 0x060077CD RID: 30669 RVA: 0x0003AB57 File Offset: 0x00038D57
		public unsafe BattleEntityData entityData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_entityData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleEntityData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_entityData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x060077CE RID: 30670 RVA: 0x001CFE08 File Offset: 0x001CE008
		// (set) Token: 0x060077CF RID: 30671 RVA: 0x0003AB76 File Offset: 0x00038D76
		public unsafe CardController cardController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_cardController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x060077D0 RID: 30672 RVA: 0x001CFE38 File Offset: 0x001CE038
		// (set) Token: 0x060077D1 RID: 30673 RVA: 0x0003AB95 File Offset: 0x00038D95
		public unsafe Character owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_owner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250E RID: 9486
		// (get) Token: 0x060077D2 RID: 30674 RVA: 0x001CFE68 File Offset: 0x001CE068
		// (set) Token: 0x060077D3 RID: 30675 RVA: 0x0003ABB4 File Offset: 0x00038DB4
		public unsafe UnityAction<Card> onComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_onComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<Card>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr_onComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700250F RID: 9487
		// (get) Token: 0x060077D4 RID: 30676 RVA: 0x001CFE98 File Offset: 0x001CE098
		// (set) Token: 0x060077D5 RID: 30677 RVA: 0x0003ABD3 File Offset: 0x00038DD3
		public unsafe Entity _entity_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr__entity_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._CreateCard_d__21.NativeFieldInfoPtr__entity_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D56 RID: 19798
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004D57 RID: 19799
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004D58 RID: 19800
		private static readonly IntPtr NativeFieldInfoPtr_entityData;

		// Token: 0x04004D59 RID: 19801
		private static readonly IntPtr NativeFieldInfoPtr_cardController;

		// Token: 0x04004D5A RID: 19802
		private static readonly IntPtr NativeFieldInfoPtr_owner;

		// Token: 0x04004D5B RID: 19803
		private static readonly IntPtr NativeFieldInfoPtr_onComplete;

		// Token: 0x04004D5C RID: 19804
		private static readonly IntPtr NativeFieldInfoPtr__entity_5__2;

		// Token: 0x04004D5D RID: 19805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004D5E RID: 19806
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D5F RID: 19807
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004D60 RID: 19808
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004D61 RID: 19809
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D62 RID: 19810
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020006EE RID: 1774
	[ObfuscatedName("BattleSaveSystem+<UpdateCard>d__22")]
	public sealed class _UpdateCard_d__22 : Object
	{
		// Token: 0x060077D6 RID: 30678 RVA: 0x001CFEC8 File Offset: 0x001CE0C8
		// Note: this type is marked as 'beforefieldinit'.
		static _UpdateCard_d__22()
		{
			Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveSystem>.NativeClassPtr, "<UpdateCard>d__22");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr);
			BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, "<>1__state");
			BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, "<>2__current");
			BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, "card");
			BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_customDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, "customDatas");
			BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100669105);
			BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100669106);
			BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100669107);
			BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100669108);
			BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100669109);
			BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr, 100669110);
		}

		// Token: 0x060077D7 RID: 30679 RVA: 0x001CFFBC File Offset: 0x001CE1BC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _UpdateCard_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveSystem._UpdateCard_d__22>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077D8 RID: 30680 RVA: 0x001D0004 File Offset: 0x001CE204
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077D9 RID: 30681 RVA: 0x001D0038 File Offset: 0x001CE238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70280, XrefRangeEnd = 70310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x060077DA RID: 30682 RVA: 0x001D0074 File Offset: 0x001CE274
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060077DB RID: 30683 RVA: 0x001D00B4 File Offset: 0x001CE2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70310, XrefRangeEnd = 70316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002517 RID: 9495
		// (get) Token: 0x060077DC RID: 30684 RVA: 0x001D00E8 File Offset: 0x001CE2E8
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveSystem._UpdateCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060077DD RID: 30685 RVA: 0x0003ABF2 File Offset: 0x00038DF2
		public _UpdateCard_d__22(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002512 RID: 9490
		// (get) Token: 0x060077DE RID: 30686 RVA: 0x001D0128 File Offset: 0x001CE328
		// (set) Token: 0x060077DF RID: 30687 RVA: 0x0003ABFB File Offset: 0x00038DFB
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002513 RID: 9491
		// (get) Token: 0x060077E0 RID: 30688 RVA: 0x001D0150 File Offset: 0x001CE350
		// (set) Token: 0x060077E1 RID: 30689 RVA: 0x0003AC16 File Offset: 0x00038E16
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002514 RID: 9492
		// (get) Token: 0x060077E2 RID: 30690 RVA: 0x001D0180 File Offset: 0x001CE380
		// (set) Token: 0x060077E3 RID: 30691 RVA: 0x0003AC35 File Offset: 0x00038E35
		public unsafe Entity card
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_card);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x060077E4 RID: 30692 RVA: 0x001D01B0 File Offset: 0x001CE3B0
		// (set) Token: 0x060077E5 RID: 30693 RVA: 0x0003AC54 File Offset: 0x00038E54
		public unsafe IReadOnlyDictionary<string, Object> customDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_customDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveSystem._UpdateCard_d__22.NativeFieldInfoPtr_customDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D63 RID: 19811
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004D64 RID: 19812
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004D65 RID: 19813
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x04004D66 RID: 19814
		private static readonly IntPtr NativeFieldInfoPtr_customDatas;

		// Token: 0x04004D67 RID: 19815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004D68 RID: 19816
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D69 RID: 19817
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004D6A RID: 19818
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004D6B RID: 19819
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004D6C RID: 19820
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

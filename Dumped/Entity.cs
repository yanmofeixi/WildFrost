using System;
using Dead;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000124 RID: 292
public class Entity : MonoBehaviourCacheTransform
{
	// Token: 0x060011F4 RID: 4596 RVA: 0x0008BE58 File Offset: 0x0008A058
	// Note: this type is marked as 'beforefieldinit'.
	static Entity()
	{
		Il2CppClassPointerStore<Entity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Entity");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity>.NativeClassPtr);
		Entity.NativeFieldInfoPtr_inPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "inPlay");
		Entity.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "_data");
		Entity.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "display");
		Entity.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "height");
		Entity.NativeFieldInfoPtr_paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "paused");
		Entity.NativeFieldInfoPtr_wobbler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "wobbler");
		Entity.NativeFieldInfoPtr_flipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "flipper");
		Entity.NativeFieldInfoPtr_uINavigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "uINavigationItem");
		Entity.NativeFieldInfoPtr_curveAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "curveAnimator");
		Entity.NativeFieldInfoPtr_imminentAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "imminentAnimation");
		Entity.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "offset");
		Entity.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "dragging");
		Entity.NativeFieldInfoPtr_blockRecall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "blockRecall");
		Entity.NativeFieldInfoPtr__containers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "_containers");
		Entity.NativeFieldInfoPtr__preContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "_preContainers");
		Entity.NativeFieldInfoPtr_alive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "alive");
		Entity.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "owner");
		Entity.NativeFieldInfoPtr_splatterSurface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "splatterSurface");
		Entity.NativeFieldInfoPtr_inCardPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "inCardPool");
		Entity.NativeFieldInfoPtr_returnToPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "returnToPool");
		Entity.NativeFieldInfoPtr_attackEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "attackEffects");
		Entity.NativeFieldInfoPtr_statusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "statusEffects");
		Entity.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "damage");
		Entity.NativeFieldInfoPtr_tempDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "tempDamage");
		Entity.NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "hp");
		Entity.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "counter");
		Entity.NativeFieldInfoPtr_uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "uses");
		Entity.NativeFieldInfoPtr_effectBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "effectBonus");
		Entity.NativeFieldInfoPtr_effectFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "effectFactor");
		Entity.NativeFieldInfoPtr_lastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "lastHit");
		Entity.NativeFieldInfoPtr_promptUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "promptUpdate");
		Entity.NativeFieldInfoPtr_random3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "random3");
		Entity.NativeFieldInfoPtr_forceKill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "forceKill");
		Entity.NativeFieldInfoPtr_targetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "targetMode");
		Entity.NativeFieldInfoPtr_positionPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "positionPriority");
		Entity.NativeFieldInfoPtr_startingEffectsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "startingEffectsApplied");
		Entity.NativeFieldInfoPtr_triggeredBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "triggeredBy");
		Entity.NativeFieldInfoPtr_cannotBeHitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "cannotBeHitCount");
		Entity.NativeFieldInfoPtr_silenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "silenceCount");
		Entity.NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "traits");
		Entity.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "canvas");
		Entity.NativeFieldInfoPtr_traitUpdateRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity>.NativeClassPtr, "traitUpdateRunning");
		Entity.NativeMethodInfoPtr_get_data_Public_get_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666714);
		Entity.NativeMethodInfoPtr_set_data_Public_set_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666715);
		Entity.NativeMethodInfoPtr_get_containers_Public_get_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666716);
		Entity.NativeMethodInfoPtr_get_actualContainers_Public_get_List_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666717);
		Entity.NativeMethodInfoPtr_get_preContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666718);
		Entity.NativeMethodInfoPtr_get_preActualContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666719);
		Entity.NativeMethodInfoPtr_AddTo_Public_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666720);
		Entity.NativeMethodInfoPtr_RemoveFrom_Public_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666721);
		Entity.NativeMethodInfoPtr_get_NeedsTarget_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666722);
		Entity.NativeMethodInfoPtr_get_canBeHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666723);
		Entity.NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666724);
		Entity.NativeMethodInfoPtr_get_DrawOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666725);
		Entity.NativeMethodInfoPtr_set_DrawOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666726);
		Entity.NativeMethodInfoPtr_GetAllAllies_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666727);
		Entity.NativeMethodInfoPtr_GetAllies_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666728);
		Entity.NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666729);
		Entity.NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666730);
		Entity.NativeMethodInfoPtr_GetAllEnemies_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666731);
		Entity.NativeMethodInfoPtr_GetEnemies_Public_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666732);
		Entity.NativeMethodInfoPtr_GetEnemiesInRow_Public_List_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666733);
		Entity.NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666734);
		Entity.NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666735);
		Entity.NativeMethodInfoPtr_ClearStatuses_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666736);
		Entity.NativeMethodInfoPtr_SnowAmount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666737);
		Entity.NativeMethodInfoPtr_get_IsSnowed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666738);
		Entity.NativeMethodInfoPtr_GetScaleFromContainers_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666739);
		Entity.NativeMethodInfoPtr_GetPositionFromContainers_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666740);
		Entity.NativeMethodInfoPtr_RemoveFromContainers_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666741);
		Entity.NativeMethodInfoPtr_ResetDrawOrder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666742);
		Entity.NativeMethodInfoPtr_InHand_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666743);
		Entity.NativeMethodInfoPtr_InContainer_Public_Boolean_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666744);
		Entity.NativeMethodInfoPtr_InContainerGroup_Public_Boolean_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666745);
		Entity.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666746);
		Entity.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666747);
		Entity.NativeMethodInfoPtr_ReadyToDie_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666748);
		Entity.NativeMethodInfoPtr_Reset_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666749);
		Entity.NativeMethodInfoPtr_PromptUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666750);
		Entity.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666751);
		Entity.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_CardContainer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666752);
		Entity.NativeMethodInfoPtr_Kill_Public_IEnumerator_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666753);
		Entity.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666754);
		Entity.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666755);
		Entity.NativeMethodInfoPtr_GainTrait_Public_TraitStacks_TraitData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666756);
		Entity.NativeMethodInfoPtr_UpdateTraits_Public_IEnumerator_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666757);
		Entity.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666758);
		Entity.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666759);
		Entity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666760);
		Entity.NativeMethodInfoPtr__UpdateTraits_b__95_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity>.NativeClassPtr, 100666761);
	}

	// Token: 0x17000501 RID: 1281
	// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0008C590 File Offset: 0x0008A790
	// (set) Token: 0x060011F6 RID: 4598 RVA: 0x0008C5D0 File Offset: 0x0008A7D0
	public unsafe CardData data
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36337, RefRangeEnd = 36340, XrefRangeStart = 36337, XrefRangeEnd = 36340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_data_Public_get_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr3) : null;
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 45738, RefRangeEnd = 45744, XrefRangeStart = 45732, XrefRangeEnd = 45738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_set_data_Public_set_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0008C614 File Offset: 0x0008A814
	public unsafe Il2CppReferenceArray<CardContainer> containers
	{
		[CallerCount(95)]
		[CachedScanResults(RefRangeStart = 45765, RefRangeEnd = 45860, XrefRangeStart = 45744, XrefRangeEnd = 45765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_containers_Public_get_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardContainer>>(intPtr3) : null;
		}
	}

	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0008C654 File Offset: 0x0008A854
	public unsafe List<CardContainer> actualContainers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_actualContainers_Public_get_List_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CardContainer>>(intPtr3) : null;
		}
	}

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0008C694 File Offset: 0x0008A894
	public unsafe Il2CppReferenceArray<CardContainer> preContainers
	{
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 45881, RefRangeEnd = 45907, XrefRangeStart = 45860, XrefRangeEnd = 45881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_preContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardContainer>>(intPtr3) : null;
		}
	}

	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x060011FA RID: 4602 RVA: 0x0008C6D4 File Offset: 0x0008A8D4
	public unsafe Il2CppReferenceArray<CardContainer> preActualContainers
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_preActualContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardContainer>>(intPtr3) : null;
		}
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x0008C714 File Offset: 0x0008A914
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 45911, RefRangeEnd = 45914, XrefRangeStart = 45907, XrefRangeEnd = 45911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddTo(CardContainer container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_AddTo_Public_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x0008C758 File Offset: 0x0008A958
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 45918, RefRangeEnd = 45919, XrefRangeStart = 45914, XrefRangeEnd = 45918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFrom(CardContainer container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_RemoveFrom_Public_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x060011FD RID: 4605 RVA: 0x0008C79C File Offset: 0x0008A99C
	public unsafe bool NeedsTarget
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 45919, RefRangeEnd = 45929, XrefRangeStart = 45919, XrefRangeEnd = 45919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_NeedsTarget_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000507 RID: 1287
	// (get) Token: 0x060011FE RID: 4606 RVA: 0x0008C7D8 File Offset: 0x0008A9D8
	public unsafe bool canBeHit
	{
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 45929, RefRangeEnd = 45950, XrefRangeStart = 45929, XrefRangeEnd = 45929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_canBeHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000508 RID: 1288
	// (get) Token: 0x060011FF RID: 4607 RVA: 0x0008C814 File Offset: 0x0008AA14
	public unsafe bool silenced
	{
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 45950, RefRangeEnd = 45987, XrefRangeStart = 45950, XrefRangeEnd = 45950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000509 RID: 1289
	// (get) Token: 0x06001200 RID: 4608 RVA: 0x0008C850 File Offset: 0x0008AA50
	// (set) Token: 0x06001201 RID: 4609 RVA: 0x0008C88C File Offset: 0x0008AA8C
	public unsafe int DrawOrder
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45987, XrefRangeEnd = 45999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_DrawOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 46022, RefRangeEnd = 46028, XrefRangeStart = 45999, XrefRangeEnd = 46022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_set_DrawOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x0008C8CC File Offset: 0x0008AACC
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 46032, RefRangeEnd = 46037, XrefRangeStart = 46028, XrefRangeEnd = 46032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Entity> GetAllAllies()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAllAllies_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06001203 RID: 4611 RVA: 0x0008C90C File Offset: 0x0008AB0C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 46067, RefRangeEnd = 46069, XrefRangeStart = 46037, XrefRangeEnd = 46067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Entity> GetAllies()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAllies_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06001204 RID: 4612 RVA: 0x0008C94C File Offset: 0x0008AB4C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 46085, RefRangeEnd = 46089, XrefRangeStart = 46069, XrefRangeEnd = 46085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Entity> GetAlliesInRow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06001205 RID: 4613 RVA: 0x0008C98C File Offset: 0x0008AB8C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46119, RefRangeEnd = 46120, XrefRangeStart = 46089, XrefRangeEnd = 46119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Entity> GetAlliesInRow(int rowIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref rowIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06001206 RID: 4614 RVA: 0x0008C9D8 File Offset: 0x0008ABD8
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 46122, RefRangeEnd = 46128, XrefRangeStart = 46120, XrefRangeEnd = 46122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Entity> GetAllEnemies()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetAllEnemies_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06001207 RID: 4615 RVA: 0x0008CA18 File Offset: 0x0008AC18
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 46202, RefRangeEnd = 46204, XrefRangeStart = 46128, XrefRangeEnd = 46202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Entity> GetEnemies()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetEnemies_Public_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06001208 RID: 4616 RVA: 0x0008CA58 File Offset: 0x0008AC58
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 46273, RefRangeEnd = 46288, XrefRangeStart = 46204, XrefRangeEnd = 46273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<Entity> GetEnemiesInRow(int rowIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref rowIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetEnemiesInRow_Public_List_1_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06001209 RID: 4617 RVA: 0x0008CAA4 File Offset: 0x0008ACA4
	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 46303, RefRangeEnd = 46328, XrefRangeStart = 46288, XrefRangeEnd = 46303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StatusEffectData FindStatus(string type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<StatusEffectData>(intPtr3) : null;
	}

	// Token: 0x0600120A RID: 4618 RVA: 0x0008CAF4 File Offset: 0x0008ACF4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46343, RefRangeEnd = 46344, XrefRangeStart = 46328, XrefRangeEnd = 46343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StatusEffectData FindStatus(StatusEffectData dataType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataType);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<StatusEffectData>(intPtr3) : null;
	}

	// Token: 0x0600120B RID: 4619 RVA: 0x0008CB44 File Offset: 0x0008AD44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46344, XrefRangeEnd = 46349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ClearStatuses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ClearStatuses_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600120C RID: 4620 RVA: 0x0008CB84 File Offset: 0x0008AD84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46369, RefRangeEnd = 46370, XrefRangeStart = 46349, XrefRangeEnd = 46369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int SnowAmount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_SnowAmount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x1700050A RID: 1290
	// (get) Token: 0x0600120D RID: 4621 RVA: 0x0008CBC0 File Offset: 0x0008ADC0
	public unsafe bool IsSnowed
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 46391, RefRangeEnd = 46402, XrefRangeStart = 46370, XrefRangeEnd = 46391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_get_IsSnowed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x0008CBFC File Offset: 0x0008ADFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46402, XrefRangeEnd = 46412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetScaleFromContainers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetScaleFromContainers_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x0008CC38 File Offset: 0x0008AE38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46412, XrefRangeEnd = 46419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 GetPositionFromContainers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GetPositionFromContainers_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x0008CC74 File Offset: 0x0008AE74
	[CallerCount(34)]
	[CachedScanResults(RefRangeStart = 46434, RefRangeEnd = 46468, XrefRangeStart = 46419, XrefRangeEnd = 46434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFromContainers()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_RemoveFromContainers_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x0008CCA8 File Offset: 0x0008AEA8
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 46473, RefRangeEnd = 46478, XrefRangeStart = 46468, XrefRangeEnd = 46473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetDrawOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ResetDrawOrder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x0008CCDC File Offset: 0x0008AEDC
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 46490, RefRangeEnd = 46496, XrefRangeStart = 46478, XrefRangeEnd = 46490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InHand()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_InHand_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x0008CD18 File Offset: 0x0008AF18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46496, XrefRangeEnd = 46510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InContainer(CardContainer container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_InContainer_Public_Boolean_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x0008CD68 File Offset: 0x0008AF68
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 46516, RefRangeEnd = 46524, XrefRangeStart = 46510, XrefRangeEnd = 46516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool InContainerGroup(CardContainer container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_InContainerGroup_Public_Boolean_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x0008CDB8 File Offset: 0x0008AFB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46524, XrefRangeEnd = 46525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x0008CDEC File Offset: 0x0008AFEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46525, XrefRangeEnd = 46539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x0008CE20 File Offset: 0x0008B020
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 46565, RefRangeEnd = 46567, XrefRangeStart = 46539, XrefRangeEnd = 46565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool ReadyToDie()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_ReadyToDie_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x0008CE5C File Offset: 0x0008B05C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46572, RefRangeEnd = 46573, XrefRangeStart = 46567, XrefRangeEnd = 46572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Reset()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Reset_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x0008CE9C File Offset: 0x0008B09C
	[CallerCount(56)]
	[CachedScanResults(RefRangeStart = 46573, RefRangeEnd = 46629, XrefRangeStart = 46573, XrefRangeEnd = 46573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PromptUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_PromptUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600121A RID: 4634 RVA: 0x0008CED0 File Offset: 0x0008B0D0
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 46665, RefRangeEnd = 46671, XrefRangeStart = 46629, XrefRangeEnd = 46665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanPlayOn(Entity target, bool ignoreRowCheck = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreRowCheck;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x0008CF2C File Offset: 0x0008B12C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 46723, RefRangeEnd = 46728, XrefRangeStart = 46671, XrefRangeEnd = 46723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanPlayOn(CardContainer container, bool ignoreRowCheck = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreRowCheck;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_CanPlayOn_Public_Boolean_CardContainer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x0008CF88 File Offset: 0x0008B188
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 46733, RefRangeEnd = 46735, XrefRangeStart = 46728, XrefRangeEnd = 46733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Kill(DeathType deathType = DeathType.Normal)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref deathType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_Kill_Public_IEnumerator_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600121D RID: 4637 RVA: 0x0008CFD4 File Offset: 0x0008B1D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46735, XrefRangeEnd = 46736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600121E RID: 4638 RVA: 0x0008D008 File Offset: 0x0008B208
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46736, XrefRangeEnd = 46787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600121F RID: 4639 RVA: 0x0008D03C File Offset: 0x0008B23C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 46820, RefRangeEnd = 46826, XrefRangeStart = 46787, XrefRangeEnd = 46820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Entity.TraitStacks GainTrait(TraitData traitData, int count, bool temporary = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(traitData);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref temporary;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_GainTrait_Public_TraitStacks_TraitData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity.TraitStacks>(intPtr3) : null;
	}

	// Token: 0x06001220 RID: 4640 RVA: 0x0008D0A8 File Offset: 0x0008B2A8
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 46832, RefRangeEnd = 46842, XrefRangeStart = 46826, XrefRangeEnd = 46832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator UpdateTraits(Entity.TraitStacks moveToFront = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(moveToFront);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_UpdateTraits_Public_IEnumerator_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x0008D0F8 File Offset: 0x0008B2F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46856, RefRangeEnd = 46857, XrefRangeStart = 46842, XrefRangeEnd = 46856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnGetFromPool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x0008D12C File Offset: 0x0008B32C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 46922, RefRangeEnd = 46923, XrefRangeStart = 46857, XrefRangeEnd = 46922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnReturnToPool()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x0008D160 File Offset: 0x0008B360
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46923, XrefRangeEnd = 46932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Entity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x0008D19C File Offset: 0x0008B39C
	[CallerCount(0)]
	public unsafe bool _UpdateTraits_b__95_0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.NativeMethodInfoPtr__UpdateTraits_b__95_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x0000A906 File Offset: 0x00008B06
	public Entity(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170004D7 RID: 1239
	// (get) Token: 0x06001226 RID: 4646 RVA: 0x0008D1D8 File Offset: 0x0008B3D8
	// (set) Token: 0x06001227 RID: 4647 RVA: 0x0000A90F File Offset: 0x00008B0F
	public unsafe bool inPlay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_inPlay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_inPlay)) = value;
		}
	}

	// Token: 0x170004D8 RID: 1240
	// (get) Token: 0x06001228 RID: 4648 RVA: 0x0008D200 File Offset: 0x0008B400
	// (set) Token: 0x06001229 RID: 4649 RVA: 0x0000A92A File Offset: 0x00008B2A
	public unsafe CardData _data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004D9 RID: 1241
	// (get) Token: 0x0600122A RID: 4650 RVA: 0x0008D230 File Offset: 0x0008B430
	// (set) Token: 0x0600122B RID: 4651 RVA: 0x0000A949 File Offset: 0x00008B49
	public unsafe EntityDisplay display
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_display);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityDisplay>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004DA RID: 1242
	// (get) Token: 0x0600122C RID: 4652 RVA: 0x0008D260 File Offset: 0x0008B460
	// (set) Token: 0x0600122D RID: 4653 RVA: 0x0000A968 File Offset: 0x00008B68
	public unsafe int height
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_height);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_height)) = value;
		}
	}

	// Token: 0x170004DB RID: 1243
	// (get) Token: 0x0600122E RID: 4654 RVA: 0x0008D288 File Offset: 0x0008B488
	// (set) Token: 0x0600122F RID: 4655 RVA: 0x0000A983 File Offset: 0x00008B83
	public unsafe bool paused
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_paused);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_paused)) = value;
		}
	}

	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06001230 RID: 4656 RVA: 0x0008D2B0 File Offset: 0x0008B4B0
	// (set) Token: 0x06001231 RID: 4657 RVA: 0x0000A99E File Offset: 0x00008B9E
	public unsafe Wobbler wobbler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_wobbler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Wobbler>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_wobbler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x06001232 RID: 4658 RVA: 0x0008D2E0 File Offset: 0x0008B4E0
	// (set) Token: 0x06001233 RID: 4659 RVA: 0x0000A9BD File Offset: 0x00008BBD
	public unsafe Flipper flipper
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_flipper);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Flipper>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_flipper), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004DE RID: 1246
	// (get) Token: 0x06001234 RID: 4660 RVA: 0x0008D310 File Offset: 0x0008B510
	// (set) Token: 0x06001235 RID: 4661 RVA: 0x0000A9DC File Offset: 0x00008BDC
	public unsafe UINavigationItem uINavigationItem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_uINavigationItem);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UINavigationItem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_uINavigationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004DF RID: 1247
	// (get) Token: 0x06001236 RID: 4662 RVA: 0x0008D340 File Offset: 0x0008B540
	// (set) Token: 0x06001237 RID: 4663 RVA: 0x0000A9FB File Offset: 0x00008BFB
	public unsafe CurveAnimator curveAnimator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_curveAnimator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurveAnimator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_curveAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E0 RID: 1248
	// (get) Token: 0x06001238 RID: 4664 RVA: 0x0008D370 File Offset: 0x0008B570
	// (set) Token: 0x06001239 RID: 4665 RVA: 0x0000AA1A File Offset: 0x00008C1A
	public unsafe CardIdleAnimation imminentAnimation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_imminentAnimation);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardIdleAnimation>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_imminentAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E1 RID: 1249
	// (get) Token: 0x0600123A RID: 4666 RVA: 0x0008D3A0 File Offset: 0x0008B5A0
	// (set) Token: 0x0600123B RID: 4667 RVA: 0x0000AA39 File Offset: 0x00008C39
	public unsafe Transform offset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_offset);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_offset), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E2 RID: 1250
	// (get) Token: 0x0600123C RID: 4668 RVA: 0x0008D3D0 File Offset: 0x0008B5D0
	// (set) Token: 0x0600123D RID: 4669 RVA: 0x0000AA58 File Offset: 0x00008C58
	public unsafe bool dragging
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_dragging);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_dragging)) = value;
		}
	}

	// Token: 0x170004E3 RID: 1251
	// (get) Token: 0x0600123E RID: 4670 RVA: 0x0008D3F8 File Offset: 0x0008B5F8
	// (set) Token: 0x0600123F RID: 4671 RVA: 0x0000AA73 File Offset: 0x00008C73
	public unsafe int blockRecall
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_blockRecall);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_blockRecall)) = value;
		}
	}

	// Token: 0x170004E4 RID: 1252
	// (get) Token: 0x06001240 RID: 4672 RVA: 0x0008D420 File Offset: 0x0008B620
	// (set) Token: 0x06001241 RID: 4673 RVA: 0x0000AA8E File Offset: 0x00008C8E
	public unsafe List<CardContainer> _containers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__containers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardContainer>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__containers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E5 RID: 1253
	// (get) Token: 0x06001242 RID: 4674 RVA: 0x0008D450 File Offset: 0x0008B650
	// (set) Token: 0x06001243 RID: 4675 RVA: 0x0000AAAD File Offset: 0x00008CAD
	public unsafe Il2CppReferenceArray<CardContainer> _preContainers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__preContainers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardContainer>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr__preContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E6 RID: 1254
	// (get) Token: 0x06001244 RID: 4676 RVA: 0x0008D480 File Offset: 0x0008B680
	// (set) Token: 0x06001245 RID: 4677 RVA: 0x0000AACC File Offset: 0x00008CCC
	public unsafe bool alive
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_alive);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_alive)) = value;
		}
	}

	// Token: 0x170004E7 RID: 1255
	// (get) Token: 0x06001246 RID: 4678 RVA: 0x0008D4A8 File Offset: 0x0008B6A8
	// (set) Token: 0x06001247 RID: 4679 RVA: 0x0000AAE7 File Offset: 0x00008CE7
	public unsafe Character owner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_owner);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E8 RID: 1256
	// (get) Token: 0x06001248 RID: 4680 RVA: 0x0008D4D8 File Offset: 0x0008B6D8
	// (set) Token: 0x06001249 RID: 4681 RVA: 0x0000AB06 File Offset: 0x00008D06
	public unsafe SplatterSurface splatterSurface
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_splatterSurface);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SplatterSurface>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_splatterSurface), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004E9 RID: 1257
	// (get) Token: 0x0600124A RID: 4682 RVA: 0x0008D508 File Offset: 0x0008B708
	// (set) Token: 0x0600124B RID: 4683 RVA: 0x0000AB25 File Offset: 0x00008D25
	public unsafe bool inCardPool
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_inCardPool);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_inCardPool)) = value;
		}
	}

	// Token: 0x170004EA RID: 1258
	// (get) Token: 0x0600124C RID: 4684 RVA: 0x0008D530 File Offset: 0x0008B730
	// (set) Token: 0x0600124D RID: 4685 RVA: 0x0000AB40 File Offset: 0x00008D40
	public unsafe bool returnToPool
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_returnToPool);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_returnToPool)) = value;
		}
	}

	// Token: 0x170004EB RID: 1259
	// (get) Token: 0x0600124E RID: 4686 RVA: 0x0008D558 File Offset: 0x0008B758
	// (set) Token: 0x0600124F RID: 4687 RVA: 0x0000AB5B File Offset: 0x00008D5B
	public unsafe List<CardData.StatusEffectStacks> attackEffects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_attackEffects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_attackEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004EC RID: 1260
	// (get) Token: 0x06001250 RID: 4688 RVA: 0x0008D588 File Offset: 0x0008B788
	// (set) Token: 0x06001251 RID: 4689 RVA: 0x0000AB7A File Offset: 0x00008D7A
	public unsafe List<StatusEffectData> statusEffects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_statusEffects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StatusEffectData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_statusEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004ED RID: 1261
	// (get) Token: 0x06001252 RID: 4690 RVA: 0x0008D5B8 File Offset: 0x0008B7B8
	// (set) Token: 0x06001253 RID: 4691 RVA: 0x0000AB99 File Offset: 0x00008D99
	public unsafe Stat damage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_damage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_damage)) = value;
		}
	}

	// Token: 0x170004EE RID: 1262
	// (get) Token: 0x06001254 RID: 4692 RVA: 0x0008D5E0 File Offset: 0x0008B7E0
	// (set) Token: 0x06001255 RID: 4693 RVA: 0x0000ABB4 File Offset: 0x00008DB4
	public unsafe SafeInt tempDamage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_tempDamage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_tempDamage)) = value;
		}
	}

	// Token: 0x170004EF RID: 1263
	// (get) Token: 0x06001256 RID: 4694 RVA: 0x0008D608 File Offset: 0x0008B808
	// (set) Token: 0x06001257 RID: 4695 RVA: 0x0000ABCF File Offset: 0x00008DCF
	public unsafe Stat hp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_hp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_hp)) = value;
		}
	}

	// Token: 0x170004F0 RID: 1264
	// (get) Token: 0x06001258 RID: 4696 RVA: 0x0008D630 File Offset: 0x0008B830
	// (set) Token: 0x06001259 RID: 4697 RVA: 0x0000ABEA File Offset: 0x00008DEA
	public unsafe Stat counter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_counter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_counter)) = value;
		}
	}

	// Token: 0x170004F1 RID: 1265
	// (get) Token: 0x0600125A RID: 4698 RVA: 0x0008D658 File Offset: 0x0008B858
	// (set) Token: 0x0600125B RID: 4699 RVA: 0x0000AC05 File Offset: 0x00008E05
	public unsafe Stat uses
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_uses);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_uses)) = value;
		}
	}

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x0600125C RID: 4700 RVA: 0x0008D680 File Offset: 0x0008B880
	// (set) Token: 0x0600125D RID: 4701 RVA: 0x0000AC20 File Offset: 0x00008E20
	public unsafe int effectBonus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_effectBonus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_effectBonus)) = value;
		}
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x0600125E RID: 4702 RVA: 0x0008D6A8 File Offset: 0x0008B8A8
	// (set) Token: 0x0600125F RID: 4703 RVA: 0x0000AC3B File Offset: 0x00008E3B
	public unsafe float effectFactor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_effectFactor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_effectFactor)) = value;
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06001260 RID: 4704 RVA: 0x0008D6D0 File Offset: 0x0008B8D0
	// (set) Token: 0x06001261 RID: 4705 RVA: 0x0000AC56 File Offset: 0x00008E56
	public unsafe Hit lastHit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_lastHit);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hit>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_lastHit), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06001262 RID: 4706 RVA: 0x0008D700 File Offset: 0x0008B900
	// (set) Token: 0x06001263 RID: 4707 RVA: 0x0000AC75 File Offset: 0x00008E75
	public unsafe bool promptUpdate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_promptUpdate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_promptUpdate)) = value;
		}
	}

	// Token: 0x170004F6 RID: 1270
	// (get) Token: 0x06001264 RID: 4708 RVA: 0x0008D728 File Offset: 0x0008B928
	// (set) Token: 0x06001265 RID: 4709 RVA: 0x0000AC90 File Offset: 0x00008E90
	public unsafe Vector3 random3
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_random3);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_random3)) = value;
		}
	}

	// Token: 0x170004F7 RID: 1271
	// (get) Token: 0x06001266 RID: 4710 RVA: 0x0008D750 File Offset: 0x0008B950
	// (set) Token: 0x06001267 RID: 4711 RVA: 0x0000ACAB File Offset: 0x00008EAB
	public unsafe DeathType forceKill
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_forceKill);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_forceKill)) = value;
		}
	}

	// Token: 0x170004F8 RID: 1272
	// (get) Token: 0x06001268 RID: 4712 RVA: 0x0008D778 File Offset: 0x0008B978
	// (set) Token: 0x06001269 RID: 4713 RVA: 0x0000ACC6 File Offset: 0x00008EC6
	public unsafe TargetMode targetMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_targetMode);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetMode>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_targetMode), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004F9 RID: 1273
	// (get) Token: 0x0600126A RID: 4714 RVA: 0x0008D7A8 File Offset: 0x0008B9A8
	// (set) Token: 0x0600126B RID: 4715 RVA: 0x0000ACE5 File Offset: 0x00008EE5
	public unsafe int positionPriority
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_positionPriority);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_positionPriority)) = value;
		}
	}

	// Token: 0x170004FA RID: 1274
	// (get) Token: 0x0600126C RID: 4716 RVA: 0x0008D7D0 File Offset: 0x0008B9D0
	// (set) Token: 0x0600126D RID: 4717 RVA: 0x0000AD00 File Offset: 0x00008F00
	public unsafe bool startingEffectsApplied
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_startingEffectsApplied);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_startingEffectsApplied)) = value;
		}
	}

	// Token: 0x170004FB RID: 1275
	// (get) Token: 0x0600126E RID: 4718 RVA: 0x0008D7F8 File Offset: 0x0008B9F8
	// (set) Token: 0x0600126F RID: 4719 RVA: 0x0000AD1B File Offset: 0x00008F1B
	public unsafe Entity triggeredBy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_triggeredBy);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_triggeredBy), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004FC RID: 1276
	// (get) Token: 0x06001270 RID: 4720 RVA: 0x0008D828 File Offset: 0x0008BA28
	// (set) Token: 0x06001271 RID: 4721 RVA: 0x0000AD3A File Offset: 0x00008F3A
	public unsafe int cannotBeHitCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_cannotBeHitCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_cannotBeHitCount)) = value;
		}
	}

	// Token: 0x170004FD RID: 1277
	// (get) Token: 0x06001272 RID: 4722 RVA: 0x0008D850 File Offset: 0x0008BA50
	// (set) Token: 0x06001273 RID: 4723 RVA: 0x0000AD55 File Offset: 0x00008F55
	public unsafe int silenceCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_silenceCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_silenceCount)) = value;
		}
	}

	// Token: 0x170004FE RID: 1278
	// (get) Token: 0x06001274 RID: 4724 RVA: 0x0008D878 File Offset: 0x0008BA78
	// (set) Token: 0x06001275 RID: 4725 RVA: 0x0000AD70 File Offset: 0x00008F70
	public unsafe List<Entity.TraitStacks> traits
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_traits);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity.TraitStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_traits), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004FF RID: 1279
	// (get) Token: 0x06001276 RID: 4726 RVA: 0x0008D8A8 File Offset: 0x0008BAA8
	// (set) Token: 0x06001277 RID: 4727 RVA: 0x0000AD8F File Offset: 0x00008F8F
	public unsafe Canvas canvas
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_canvas);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000500 RID: 1280
	// (get) Token: 0x06001278 RID: 4728 RVA: 0x0008D8D8 File Offset: 0x0008BAD8
	// (set) Token: 0x06001279 RID: 4729 RVA: 0x0000ADAE File Offset: 0x00008FAE
	public unsafe int traitUpdateRunning
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_traitUpdateRunning);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.NativeFieldInfoPtr_traitUpdateRunning)) = value;
		}
	}

	// Token: 0x04000B40 RID: 2880
	private static readonly IntPtr NativeFieldInfoPtr_inPlay;

	// Token: 0x04000B41 RID: 2881
	private static readonly IntPtr NativeFieldInfoPtr__data;

	// Token: 0x04000B42 RID: 2882
	private static readonly IntPtr NativeFieldInfoPtr_display;

	// Token: 0x04000B43 RID: 2883
	private static readonly IntPtr NativeFieldInfoPtr_height;

	// Token: 0x04000B44 RID: 2884
	private static readonly IntPtr NativeFieldInfoPtr_paused;

	// Token: 0x04000B45 RID: 2885
	private static readonly IntPtr NativeFieldInfoPtr_wobbler;

	// Token: 0x04000B46 RID: 2886
	private static readonly IntPtr NativeFieldInfoPtr_flipper;

	// Token: 0x04000B47 RID: 2887
	private static readonly IntPtr NativeFieldInfoPtr_uINavigationItem;

	// Token: 0x04000B48 RID: 2888
	private static readonly IntPtr NativeFieldInfoPtr_curveAnimator;

	// Token: 0x04000B49 RID: 2889
	private static readonly IntPtr NativeFieldInfoPtr_imminentAnimation;

	// Token: 0x04000B4A RID: 2890
	private static readonly IntPtr NativeFieldInfoPtr_offset;

	// Token: 0x04000B4B RID: 2891
	private static readonly IntPtr NativeFieldInfoPtr_dragging;

	// Token: 0x04000B4C RID: 2892
	private static readonly IntPtr NativeFieldInfoPtr_blockRecall;

	// Token: 0x04000B4D RID: 2893
	private static readonly IntPtr NativeFieldInfoPtr__containers;

	// Token: 0x04000B4E RID: 2894
	private static readonly IntPtr NativeFieldInfoPtr__preContainers;

	// Token: 0x04000B4F RID: 2895
	private static readonly IntPtr NativeFieldInfoPtr_alive;

	// Token: 0x04000B50 RID: 2896
	private static readonly IntPtr NativeFieldInfoPtr_owner;

	// Token: 0x04000B51 RID: 2897
	private static readonly IntPtr NativeFieldInfoPtr_splatterSurface;

	// Token: 0x04000B52 RID: 2898
	private static readonly IntPtr NativeFieldInfoPtr_inCardPool;

	// Token: 0x04000B53 RID: 2899
	private static readonly IntPtr NativeFieldInfoPtr_returnToPool;

	// Token: 0x04000B54 RID: 2900
	private static readonly IntPtr NativeFieldInfoPtr_attackEffects;

	// Token: 0x04000B55 RID: 2901
	private static readonly IntPtr NativeFieldInfoPtr_statusEffects;

	// Token: 0x04000B56 RID: 2902
	private static readonly IntPtr NativeFieldInfoPtr_damage;

	// Token: 0x04000B57 RID: 2903
	private static readonly IntPtr NativeFieldInfoPtr_tempDamage;

	// Token: 0x04000B58 RID: 2904
	private static readonly IntPtr NativeFieldInfoPtr_hp;

	// Token: 0x04000B59 RID: 2905
	private static readonly IntPtr NativeFieldInfoPtr_counter;

	// Token: 0x04000B5A RID: 2906
	private static readonly IntPtr NativeFieldInfoPtr_uses;

	// Token: 0x04000B5B RID: 2907
	private static readonly IntPtr NativeFieldInfoPtr_effectBonus;

	// Token: 0x04000B5C RID: 2908
	private static readonly IntPtr NativeFieldInfoPtr_effectFactor;

	// Token: 0x04000B5D RID: 2909
	private static readonly IntPtr NativeFieldInfoPtr_lastHit;

	// Token: 0x04000B5E RID: 2910
	private static readonly IntPtr NativeFieldInfoPtr_promptUpdate;

	// Token: 0x04000B5F RID: 2911
	private static readonly IntPtr NativeFieldInfoPtr_random3;

	// Token: 0x04000B60 RID: 2912
	private static readonly IntPtr NativeFieldInfoPtr_forceKill;

	// Token: 0x04000B61 RID: 2913
	private static readonly IntPtr NativeFieldInfoPtr_targetMode;

	// Token: 0x04000B62 RID: 2914
	private static readonly IntPtr NativeFieldInfoPtr_positionPriority;

	// Token: 0x04000B63 RID: 2915
	private static readonly IntPtr NativeFieldInfoPtr_startingEffectsApplied;

	// Token: 0x04000B64 RID: 2916
	private static readonly IntPtr NativeFieldInfoPtr_triggeredBy;

	// Token: 0x04000B65 RID: 2917
	private static readonly IntPtr NativeFieldInfoPtr_cannotBeHitCount;

	// Token: 0x04000B66 RID: 2918
	private static readonly IntPtr NativeFieldInfoPtr_silenceCount;

	// Token: 0x04000B67 RID: 2919
	private static readonly IntPtr NativeFieldInfoPtr_traits;

	// Token: 0x04000B68 RID: 2920
	private static readonly IntPtr NativeFieldInfoPtr_canvas;

	// Token: 0x04000B69 RID: 2921
	private static readonly IntPtr NativeFieldInfoPtr_traitUpdateRunning;

	// Token: 0x04000B6A RID: 2922
	private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_CardData_0;

	// Token: 0x04000B6B RID: 2923
	private static readonly IntPtr NativeMethodInfoPtr_set_data_Public_set_Void_CardData_0;

	// Token: 0x04000B6C RID: 2924
	private static readonly IntPtr NativeMethodInfoPtr_get_containers_Public_get_Il2CppReferenceArray_1_CardContainer_0;

	// Token: 0x04000B6D RID: 2925
	private static readonly IntPtr NativeMethodInfoPtr_get_actualContainers_Public_get_List_1_CardContainer_0;

	// Token: 0x04000B6E RID: 2926
	private static readonly IntPtr NativeMethodInfoPtr_get_preContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0;

	// Token: 0x04000B6F RID: 2927
	private static readonly IntPtr NativeMethodInfoPtr_get_preActualContainers_Public_get_Il2CppReferenceArray_1_CardContainer_0;

	// Token: 0x04000B70 RID: 2928
	private static readonly IntPtr NativeMethodInfoPtr_AddTo_Public_Void_CardContainer_0;

	// Token: 0x04000B71 RID: 2929
	private static readonly IntPtr NativeMethodInfoPtr_RemoveFrom_Public_Void_CardContainer_0;

	// Token: 0x04000B72 RID: 2930
	private static readonly IntPtr NativeMethodInfoPtr_get_NeedsTarget_Public_get_Boolean_0;

	// Token: 0x04000B73 RID: 2931
	private static readonly IntPtr NativeMethodInfoPtr_get_canBeHit_Public_get_Boolean_0;

	// Token: 0x04000B74 RID: 2932
	private static readonly IntPtr NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0;

	// Token: 0x04000B75 RID: 2933
	private static readonly IntPtr NativeMethodInfoPtr_get_DrawOrder_Public_get_Int32_0;

	// Token: 0x04000B76 RID: 2934
	private static readonly IntPtr NativeMethodInfoPtr_set_DrawOrder_Public_set_Void_Int32_0;

	// Token: 0x04000B77 RID: 2935
	private static readonly IntPtr NativeMethodInfoPtr_GetAllAllies_Public_List_1_Entity_0;

	// Token: 0x04000B78 RID: 2936
	private static readonly IntPtr NativeMethodInfoPtr_GetAllies_Public_List_1_Entity_0;

	// Token: 0x04000B79 RID: 2937
	private static readonly IntPtr NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_0;

	// Token: 0x04000B7A RID: 2938
	private static readonly IntPtr NativeMethodInfoPtr_GetAlliesInRow_Public_List_1_Entity_Int32_0;

	// Token: 0x04000B7B RID: 2939
	private static readonly IntPtr NativeMethodInfoPtr_GetAllEnemies_Public_List_1_Entity_0;

	// Token: 0x04000B7C RID: 2940
	private static readonly IntPtr NativeMethodInfoPtr_GetEnemies_Public_List_1_Entity_0;

	// Token: 0x04000B7D RID: 2941
	private static readonly IntPtr NativeMethodInfoPtr_GetEnemiesInRow_Public_List_1_Entity_Int32_0;

	// Token: 0x04000B7E RID: 2942
	private static readonly IntPtr NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_String_0;

	// Token: 0x04000B7F RID: 2943
	private static readonly IntPtr NativeMethodInfoPtr_FindStatus_Public_StatusEffectData_StatusEffectData_0;

	// Token: 0x04000B80 RID: 2944
	private static readonly IntPtr NativeMethodInfoPtr_ClearStatuses_Public_IEnumerator_0;

	// Token: 0x04000B81 RID: 2945
	private static readonly IntPtr NativeMethodInfoPtr_SnowAmount_Public_Int32_0;

	// Token: 0x04000B82 RID: 2946
	private static readonly IntPtr NativeMethodInfoPtr_get_IsSnowed_Public_get_Boolean_0;

	// Token: 0x04000B83 RID: 2947
	private static readonly IntPtr NativeMethodInfoPtr_GetScaleFromContainers_Public_Vector3_0;

	// Token: 0x04000B84 RID: 2948
	private static readonly IntPtr NativeMethodInfoPtr_GetPositionFromContainers_Public_Vector3_0;

	// Token: 0x04000B85 RID: 2949
	private static readonly IntPtr NativeMethodInfoPtr_RemoveFromContainers_Public_Void_0;

	// Token: 0x04000B86 RID: 2950
	private static readonly IntPtr NativeMethodInfoPtr_ResetDrawOrder_Public_Void_0;

	// Token: 0x04000B87 RID: 2951
	private static readonly IntPtr NativeMethodInfoPtr_InHand_Public_Boolean_0;

	// Token: 0x04000B88 RID: 2952
	private static readonly IntPtr NativeMethodInfoPtr_InContainer_Public_Boolean_CardContainer_0;

	// Token: 0x04000B89 RID: 2953
	private static readonly IntPtr NativeMethodInfoPtr_InContainerGroup_Public_Boolean_CardContainer_0;

	// Token: 0x04000B8A RID: 2954
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000B8B RID: 2955
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000B8C RID: 2956
	private static readonly IntPtr NativeMethodInfoPtr_ReadyToDie_Public_Boolean_0;

	// Token: 0x04000B8D RID: 2957
	private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_IEnumerator_0;

	// Token: 0x04000B8E RID: 2958
	private static readonly IntPtr NativeMethodInfoPtr_PromptUpdate_Public_Void_0;

	// Token: 0x04000B8F RID: 2959
	private static readonly IntPtr NativeMethodInfoPtr_CanPlayOn_Public_Boolean_Entity_Boolean_0;

	// Token: 0x04000B90 RID: 2960
	private static readonly IntPtr NativeMethodInfoPtr_CanPlayOn_Public_Boolean_CardContainer_Boolean_0;

	// Token: 0x04000B91 RID: 2961
	private static readonly IntPtr NativeMethodInfoPtr_Kill_Public_IEnumerator_DeathType_0;

	// Token: 0x04000B92 RID: 2962
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04000B93 RID: 2963
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000B94 RID: 2964
	private static readonly IntPtr NativeMethodInfoPtr_GainTrait_Public_TraitStacks_TraitData_Int32_Boolean_0;

	// Token: 0x04000B95 RID: 2965
	private static readonly IntPtr NativeMethodInfoPtr_UpdateTraits_Public_IEnumerator_TraitStacks_0;

	// Token: 0x04000B96 RID: 2966
	private static readonly IntPtr NativeMethodInfoPtr_OnGetFromPool_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000B97 RID: 2967
	private static readonly IntPtr NativeMethodInfoPtr_OnReturnToPool_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000B98 RID: 2968
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000B99 RID: 2969
	private static readonly IntPtr NativeMethodInfoPtr__UpdateTraits_b__95_0_Private_Boolean_0;

	// Token: 0x020005FB RID: 1531
	[Serializable]
	public class TraitStacks : Il2CppSystem.Object
	{
		// Token: 0x06006C86 RID: 27782 RVA: 0x001AEE88 File Offset: 0x001AD088
		// Note: this type is marked as 'beforefieldinit'.
		static TraitStacks()
		{
			Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "TraitStacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr);
			Entity.TraitStacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "data");
			Entity.TraitStacks.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "count");
			Entity.TraitStacks.NativeFieldInfoPtr_silenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "silenceCount");
			Entity.TraitStacks.NativeFieldInfoPtr_tempCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "tempCount");
			Entity.TraitStacks.NativeFieldInfoPtr_init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "init");
			Entity.TraitStacks.NativeFieldInfoPtr_effectsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "effectsDisabled");
			Entity.TraitStacks.NativeFieldInfoPtr_passiveEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "passiveEffects");
			Entity.TraitStacks.NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666762);
			Entity.TraitStacks.NativeMethodInfoPtr_get_ReadyToInit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666763);
			Entity.TraitStacks.NativeMethodInfoPtr_get_MustDisable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666764);
			Entity.TraitStacks.NativeMethodInfoPtr_get_MustEnable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666765);
			Entity.TraitStacks.NativeMethodInfoPtr_get_StacksRemoved_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666766);
			Entity.TraitStacks.NativeMethodInfoPtr__ctor_Public_Void_TraitData_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666767);
			Entity.TraitStacks.NativeMethodInfoPtr_DisableEffects_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666768);
			Entity.TraitStacks.NativeMethodInfoPtr_EnableEffects_Public_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666769);
			Entity.TraitStacks.NativeMethodInfoPtr_AddEffectStacks_Public_IEnumerator_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666770);
			Entity.TraitStacks.NativeMethodInfoPtr_RemoveEffectStacks_Public_IEnumerator_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666771);
			Entity.TraitStacks.NativeMethodInfoPtr__AddEffectStacks_b__20_0_Private_Void_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, 100666772);
		}

		// Token: 0x17002160 RID: 8544
		// (get) Token: 0x06006C87 RID: 27783 RVA: 0x001AF01C File Offset: 0x001AD21C
		public unsafe bool silenced
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45317, RefRangeEnd = 45318, XrefRangeStart = 45317, XrefRangeEnd = 45317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x001AF058 File Offset: 0x001AD258
		public unsafe bool ReadyToInit
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_ReadyToInit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x06006C89 RID: 27785 RVA: 0x001AF094 File Offset: 0x001AD294
		public unsafe bool MustDisable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_MustDisable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x06006C8A RID: 27786 RVA: 0x001AF0D0 File Offset: 0x001AD2D0
		public unsafe bool MustEnable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_MustEnable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06006C8B RID: 27787 RVA: 0x001AF10C File Offset: 0x001AD30C
		public unsafe bool StacksRemoved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_get_StacksRemoved_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006C8C RID: 27788 RVA: 0x001AF148 File Offset: 0x001AD348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45327, RefRangeEnd = 45329, XrefRangeStart = 45318, XrefRangeEnd = 45327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraitStacks(TraitData data, int count, bool temporary = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref temporary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr__ctor_Public_Void_TraitData_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C8D RID: 27789 RVA: 0x001AF1B0 File Offset: 0x001AD3B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 45334, RefRangeEnd = 45336, XrefRangeStart = 45329, XrefRangeEnd = 45334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DisableEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_DisableEffects_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006C8E RID: 27790 RVA: 0x001AF1F0 File Offset: 0x001AD3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45336, XrefRangeEnd = 45342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator EnableEffects(Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_EnableEffects_Public_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006C8F RID: 27791 RVA: 0x001AF240 File Offset: 0x001AD440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45342, XrefRangeEnd = 45348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator AddEffectStacks(Entity entity, int stacks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_AddEffectStacks_Public_IEnumerator_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006C90 RID: 27792 RVA: 0x001AF2A0 File Offset: 0x001AD4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45348, XrefRangeEnd = 45354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RemoveEffectStacks(Entity entity, int removeStacks)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref removeStacks;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr_RemoveEffectStacks_Public_IEnumerator_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06006C91 RID: 27793 RVA: 0x001AF300 File Offset: 0x001AD500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45354, XrefRangeEnd = 45358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AddEffectStacks_b__20_0(StatusEffectData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks.NativeMethodInfoPtr__AddEffectStacks_b__20_0_Private_Void_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C92 RID: 27794 RVA: 0x00034E50 File Offset: 0x00033050
		public TraitStacks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002159 RID: 8537
		// (get) Token: 0x06006C93 RID: 27795 RVA: 0x001AF344 File Offset: 0x001AD544
		// (set) Token: 0x06006C94 RID: 27796 RVA: 0x00034E59 File Offset: 0x00033059
		public unsafe TraitData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700215A RID: 8538
		// (get) Token: 0x06006C95 RID: 27797 RVA: 0x001AF374 File Offset: 0x001AD574
		// (set) Token: 0x06006C96 RID: 27798 RVA: 0x00034E78 File Offset: 0x00033078
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x1700215B RID: 8539
		// (get) Token: 0x06006C97 RID: 27799 RVA: 0x001AF39C File Offset: 0x001AD59C
		// (set) Token: 0x06006C98 RID: 27800 RVA: 0x00034E93 File Offset: 0x00033093
		public unsafe int silenceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_silenceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_silenceCount)) = value;
			}
		}

		// Token: 0x1700215C RID: 8540
		// (get) Token: 0x06006C99 RID: 27801 RVA: 0x001AF3C4 File Offset: 0x001AD5C4
		// (set) Token: 0x06006C9A RID: 27802 RVA: 0x00034EAE File Offset: 0x000330AE
		public unsafe int tempCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_tempCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_tempCount)) = value;
			}
		}

		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06006C9B RID: 27803 RVA: 0x001AF3EC File Offset: 0x001AD5EC
		// (set) Token: 0x06006C9C RID: 27804 RVA: 0x00034EC9 File Offset: 0x000330C9
		public unsafe int init
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_init);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_init)) = value;
			}
		}

		// Token: 0x1700215E RID: 8542
		// (get) Token: 0x06006C9D RID: 27805 RVA: 0x001AF414 File Offset: 0x001AD614
		// (set) Token: 0x06006C9E RID: 27806 RVA: 0x00034EE4 File Offset: 0x000330E4
		public unsafe bool effectsDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_effectsDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_effectsDisabled)) = value;
			}
		}

		// Token: 0x1700215F RID: 8543
		// (get) Token: 0x06006C9F RID: 27807 RVA: 0x001AF43C File Offset: 0x001AD63C
		// (set) Token: 0x06006CA0 RID: 27808 RVA: 0x00034EFF File Offset: 0x000330FF
		public unsafe List<StatusEffectData> passiveEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_passiveEffects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StatusEffectData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks.NativeFieldInfoPtr_passiveEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046C1 RID: 18113
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040046C2 RID: 18114
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040046C3 RID: 18115
		private static readonly IntPtr NativeFieldInfoPtr_silenceCount;

		// Token: 0x040046C4 RID: 18116
		private static readonly IntPtr NativeFieldInfoPtr_tempCount;

		// Token: 0x040046C5 RID: 18117
		private static readonly IntPtr NativeFieldInfoPtr_init;

		// Token: 0x040046C6 RID: 18118
		private static readonly IntPtr NativeFieldInfoPtr_effectsDisabled;

		// Token: 0x040046C7 RID: 18119
		private static readonly IntPtr NativeFieldInfoPtr_passiveEffects;

		// Token: 0x040046C8 RID: 18120
		private static readonly IntPtr NativeMethodInfoPtr_get_silenced_Public_get_Boolean_0;

		// Token: 0x040046C9 RID: 18121
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadyToInit_Public_get_Boolean_0;

		// Token: 0x040046CA RID: 18122
		private static readonly IntPtr NativeMethodInfoPtr_get_MustDisable_Public_get_Boolean_0;

		// Token: 0x040046CB RID: 18123
		private static readonly IntPtr NativeMethodInfoPtr_get_MustEnable_Public_get_Boolean_0;

		// Token: 0x040046CC RID: 18124
		private static readonly IntPtr NativeMethodInfoPtr_get_StacksRemoved_Public_get_Boolean_0;

		// Token: 0x040046CD RID: 18125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TraitData_Int32_Boolean_0;

		// Token: 0x040046CE RID: 18126
		private static readonly IntPtr NativeMethodInfoPtr_DisableEffects_Public_IEnumerator_0;

		// Token: 0x040046CF RID: 18127
		private static readonly IntPtr NativeMethodInfoPtr_EnableEffects_Public_IEnumerator_Entity_0;

		// Token: 0x040046D0 RID: 18128
		private static readonly IntPtr NativeMethodInfoPtr_AddEffectStacks_Public_IEnumerator_Entity_Int32_0;

		// Token: 0x040046D1 RID: 18129
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEffectStacks_Public_IEnumerator_Entity_Int32_0;

		// Token: 0x040046D2 RID: 18130
		private static readonly IntPtr NativeMethodInfoPtr__AddEffectStacks_b__20_0_Private_Void_StatusEffectData_0;

		// Token: 0x02000A8C RID: 2700
		[ObfuscatedName("Entity+TraitStacks+<DisableEffects>d__18")]
		public sealed class _DisableEffects_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600A322 RID: 41762 RVA: 0x0025407C File Offset: 0x0025227C
			// Note: this type is marked as 'beforefieldinit'.
			static _DisableEffects_d__18()
			{
				Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "<DisableEffects>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr);
				Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, "<>1__state");
				Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, "<>2__current");
				Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, "<>4__this");
				Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, "<>7__wrap1");
				Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666773);
				Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666774);
				Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666775);
				Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666776);
				Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666777);
				Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666778);
				Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr, 100666779);
			}

			// Token: 0x0600A323 RID: 41763 RVA: 0x00254184 File Offset: 0x00252384
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DisableEffects_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks._DisableEffects_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A324 RID: 41764 RVA: 0x002541CC File Offset: 0x002523CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 45225, RefRangeEnd = 45226, XrefRangeStart = 45220, XrefRangeEnd = 45225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A325 RID: 41765 RVA: 0x00254200 File Offset: 0x00252400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45226, XrefRangeEnd = 45245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A326 RID: 41766 RVA: 0x0025423C File Offset: 0x0025243C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45245, XrefRangeEnd = 45248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700337F RID: 13183
			// (get) Token: 0x0600A327 RID: 41767 RVA: 0x00254270 File Offset: 0x00252470
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A328 RID: 41768 RVA: 0x002542B0 File Offset: 0x002524B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45248, XrefRangeEnd = 45254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003380 RID: 13184
			// (get) Token: 0x0600A329 RID: 41769 RVA: 0x002542E4 File Offset: 0x002524E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._DisableEffects_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A32A RID: 41770 RVA: 0x00050361 File Offset: 0x0004E561
			public _DisableEffects_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700337B RID: 13179
			// (get) Token: 0x0600A32B RID: 41771 RVA: 0x00254324 File Offset: 0x00252524
			// (set) Token: 0x0600A32C RID: 41772 RVA: 0x0005036A File Offset: 0x0004E56A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700337C RID: 13180
			// (get) Token: 0x0600A32D RID: 41773 RVA: 0x0025434C File Offset: 0x0025254C
			// (set) Token: 0x0600A32E RID: 41774 RVA: 0x00050385 File Offset: 0x0004E585
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700337D RID: 13181
			// (get) Token: 0x0600A32F RID: 41775 RVA: 0x0025437C File Offset: 0x0025257C
			// (set) Token: 0x0600A330 RID: 41776 RVA: 0x000503A4 File Offset: 0x0004E5A4
			public unsafe Entity.TraitStacks __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity.TraitStacks>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700337E RID: 13182
			// (get) Token: 0x0600A331 RID: 41777 RVA: 0x002543AC File Offset: 0x002525AC
			// (set) Token: 0x0600A332 RID: 41778 RVA: 0x000503C3 File Offset: 0x0004E5C3
			public List<StatusEffectData>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___7__wrap1);
					return new List<StatusEffectData>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<StatusEffectData>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._DisableEffects_d__18.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<StatusEffectData>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400691C RID: 26908
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400691D RID: 26909
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400691E RID: 26910
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400691F RID: 26911
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04006920 RID: 26912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006921 RID: 26913
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006922 RID: 26914
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006923 RID: 26915
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04006924 RID: 26916
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006925 RID: 26917
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006926 RID: 26918
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A8D RID: 2701
		[ObfuscatedName("Entity+TraitStacks+<EnableEffects>d__19")]
		public sealed class _EnableEffects_d__19 : Il2CppSystem.Object
		{
			// Token: 0x0600A333 RID: 41779 RVA: 0x002543DC File Offset: 0x002525DC
			// Note: this type is marked as 'beforefieldinit'.
			static _EnableEffects_d__19()
			{
				Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "<EnableEffects>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr);
				Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, "<>1__state");
				Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, "<>2__current");
				Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, "<>4__this");
				Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, "entity");
				Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666780);
				Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666781);
				Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666782);
				Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666783);
				Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666784);
				Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr, 100666785);
			}

			// Token: 0x0600A334 RID: 41780 RVA: 0x002544D0 File Offset: 0x002526D0
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EnableEffects_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks._EnableEffects_d__19>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A335 RID: 41781 RVA: 0x00254518 File Offset: 0x00252718
			[CallerCount(12683)]
			[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A336 RID: 41782 RVA: 0x0025454C File Offset: 0x0025274C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45254, XrefRangeEnd = 45261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003385 RID: 13189
			// (get) Token: 0x0600A337 RID: 41783 RVA: 0x00254588 File Offset: 0x00252788
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A338 RID: 41784 RVA: 0x002545C8 File Offset: 0x002527C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45261, XrefRangeEnd = 45267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003386 RID: 13190
			// (get) Token: 0x0600A339 RID: 41785 RVA: 0x002545FC File Offset: 0x002527FC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._EnableEffects_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A33A RID: 41786 RVA: 0x000503F1 File Offset: 0x0004E5F1
			public _EnableEffects_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003381 RID: 13185
			// (get) Token: 0x0600A33B RID: 41787 RVA: 0x0025463C File Offset: 0x0025283C
			// (set) Token: 0x0600A33C RID: 41788 RVA: 0x000503FA File Offset: 0x0004E5FA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003382 RID: 13186
			// (get) Token: 0x0600A33D RID: 41789 RVA: 0x00254664 File Offset: 0x00252864
			// (set) Token: 0x0600A33E RID: 41790 RVA: 0x00050415 File Offset: 0x0004E615
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003383 RID: 13187
			// (get) Token: 0x0600A33F RID: 41791 RVA: 0x00254694 File Offset: 0x00252894
			// (set) Token: 0x0600A340 RID: 41792 RVA: 0x00050434 File Offset: 0x0004E634
			public unsafe Entity.TraitStacks __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity.TraitStacks>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003384 RID: 13188
			// (get) Token: 0x0600A341 RID: 41793 RVA: 0x002546C4 File Offset: 0x002528C4
			// (set) Token: 0x0600A342 RID: 41794 RVA: 0x00050453 File Offset: 0x0004E653
			public unsafe Entity entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._EnableEffects_d__19.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006927 RID: 26919
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006928 RID: 26920
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006929 RID: 26921
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400692A RID: 26922
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x0400692B RID: 26923
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400692C RID: 26924
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400692D RID: 26925
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400692E RID: 26926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400692F RID: 26927
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006930 RID: 26928
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A8E RID: 2702
		[ObfuscatedName("Entity+TraitStacks+<AddEffectStacks>d__20")]
		public sealed class _AddEffectStacks_d__20 : Il2CppSystem.Object
		{
			// Token: 0x0600A343 RID: 41795 RVA: 0x002546F4 File Offset: 0x002528F4
			// Note: this type is marked as 'beforefieldinit'.
			static _AddEffectStacks_d__20()
			{
				Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "<AddEffectStacks>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr);
				Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>1__state");
				Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>2__current");
				Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>4__this");
				Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "entity");
				Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "stacks");
				Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>7__wrap1");
				Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, "<>7__wrap2");
				Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666786);
				Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666787);
				Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666788);
				Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666789);
				Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666790);
				Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr, 100666791);
			}

			// Token: 0x0600A344 RID: 41796 RVA: 0x00254824 File Offset: 0x00252A24
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddEffectStacks_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks._AddEffectStacks_d__20>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A345 RID: 41797 RVA: 0x0025486C File Offset: 0x00252A6C
			[CallerCount(12683)]
			[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A346 RID: 41798 RVA: 0x002548A0 File Offset: 0x00252AA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45267, XrefRangeEnd = 45282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700338E RID: 13198
			// (get) Token: 0x0600A347 RID: 41799 RVA: 0x002548DC File Offset: 0x00252ADC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A348 RID: 41800 RVA: 0x0025491C File Offset: 0x00252B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45282, XrefRangeEnd = 45288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700338F RID: 13199
			// (get) Token: 0x0600A349 RID: 41801 RVA: 0x00254950 File Offset: 0x00252B50
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._AddEffectStacks_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A34A RID: 41802 RVA: 0x00050472 File Offset: 0x0004E672
			public _AddEffectStacks_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003387 RID: 13191
			// (get) Token: 0x0600A34B RID: 41803 RVA: 0x00254990 File Offset: 0x00252B90
			// (set) Token: 0x0600A34C RID: 41804 RVA: 0x0005047B File Offset: 0x0004E67B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003388 RID: 13192
			// (get) Token: 0x0600A34D RID: 41805 RVA: 0x002549B8 File Offset: 0x00252BB8
			// (set) Token: 0x0600A34E RID: 41806 RVA: 0x00050496 File Offset: 0x0004E696
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003389 RID: 13193
			// (get) Token: 0x0600A34F RID: 41807 RVA: 0x002549E8 File Offset: 0x00252BE8
			// (set) Token: 0x0600A350 RID: 41808 RVA: 0x000504B5 File Offset: 0x0004E6B5
			public unsafe Entity.TraitStacks __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity.TraitStacks>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700338A RID: 13194
			// (get) Token: 0x0600A351 RID: 41809 RVA: 0x00254A18 File Offset: 0x00252C18
			// (set) Token: 0x0600A352 RID: 41810 RVA: 0x000504D4 File Offset: 0x0004E6D4
			public unsafe Entity entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700338B RID: 13195
			// (get) Token: 0x0600A353 RID: 41811 RVA: 0x00254A48 File Offset: 0x00252C48
			// (set) Token: 0x0600A354 RID: 41812 RVA: 0x000504F3 File Offset: 0x0004E6F3
			public unsafe int stacks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_stacks);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr_stacks)) = value;
				}
			}

			// Token: 0x1700338C RID: 13196
			// (get) Token: 0x0600A355 RID: 41813 RVA: 0x00254A70 File Offset: 0x00252C70
			// (set) Token: 0x0600A356 RID: 41814 RVA: 0x0005050E File Offset: 0x0004E70E
			public unsafe Il2CppReferenceArray<StatusEffectData> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StatusEffectData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700338D RID: 13197
			// (get) Token: 0x0600A357 RID: 41815 RVA: 0x00254AA0 File Offset: 0x00252CA0
			// (set) Token: 0x0600A358 RID: 41816 RVA: 0x0005052D File Offset: 0x0004E72D
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._AddEffectStacks_d__20.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x04006931 RID: 26929
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006932 RID: 26930
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006933 RID: 26931
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006934 RID: 26932
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x04006935 RID: 26933
			private static readonly IntPtr NativeFieldInfoPtr_stacks;

			// Token: 0x04006936 RID: 26934
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04006937 RID: 26935
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04006938 RID: 26936
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006939 RID: 26937
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400693A RID: 26938
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400693B RID: 26939
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400693C RID: 26940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400693D RID: 26941
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000A8F RID: 2703
		[ObfuscatedName("Entity+TraitStacks+<RemoveEffectStacks>d__21")]
		public sealed class _RemoveEffectStacks_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600A359 RID: 41817 RVA: 0x00254AC8 File Offset: 0x00252CC8
			// Note: this type is marked as 'beforefieldinit'.
			static _RemoveEffectStacks_d__21()
			{
				Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity.TraitStacks>.NativeClassPtr, "<RemoveEffectStacks>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr);
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>1__state");
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>2__current");
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>4__this");
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "entity");
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_removeStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "removeStacks");
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>7__wrap1");
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, "<>7__wrap2");
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666792);
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666793);
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666794);
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666795);
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666796);
				Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr, 100666797);
			}

			// Token: 0x0600A35A RID: 41818 RVA: 0x00254BF8 File Offset: 0x00252DF8
			[CallerCount(53)]
			[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RemoveEffectStacks_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.TraitStacks._RemoveEffectStacks_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A35B RID: 41819 RVA: 0x00254C40 File Offset: 0x00252E40
			[CallerCount(12683)]
			[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A35C RID: 41820 RVA: 0x00254C74 File Offset: 0x00252E74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45288, XrefRangeEnd = 45311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003397 RID: 13207
			// (get) Token: 0x0600A35D RID: 41821 RVA: 0x00254CB0 File Offset: 0x00252EB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A35E RID: 41822 RVA: 0x00254CF0 File Offset: 0x00252EF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45311, XrefRangeEnd = 45317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003398 RID: 13208
			// (get) Token: 0x0600A35F RID: 41823 RVA: 0x00254D24 File Offset: 0x00252F24
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(12)]
				[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A360 RID: 41824 RVA: 0x00050548 File Offset: 0x0004E748
			public _RemoveEffectStacks_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003390 RID: 13200
			// (get) Token: 0x0600A361 RID: 41825 RVA: 0x00254D64 File Offset: 0x00252F64
			// (set) Token: 0x0600A362 RID: 41826 RVA: 0x00050551 File Offset: 0x0004E751
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003391 RID: 13201
			// (get) Token: 0x0600A363 RID: 41827 RVA: 0x00254D8C File Offset: 0x00252F8C
			// (set) Token: 0x0600A364 RID: 41828 RVA: 0x0005056C File Offset: 0x0004E76C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003392 RID: 13202
			// (get) Token: 0x0600A365 RID: 41829 RVA: 0x00254DBC File Offset: 0x00252FBC
			// (set) Token: 0x0600A366 RID: 41830 RVA: 0x0005058B File Offset: 0x0004E78B
			public unsafe Entity.TraitStacks __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity.TraitStacks>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003393 RID: 13203
			// (get) Token: 0x0600A367 RID: 41831 RVA: 0x00254DEC File Offset: 0x00252FEC
			// (set) Token: 0x0600A368 RID: 41832 RVA: 0x000505AA File Offset: 0x0004E7AA
			public unsafe Entity entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003394 RID: 13204
			// (get) Token: 0x0600A369 RID: 41833 RVA: 0x00254E1C File Offset: 0x0025301C
			// (set) Token: 0x0600A36A RID: 41834 RVA: 0x000505C9 File Offset: 0x0004E7C9
			public unsafe int removeStacks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_removeStacks);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr_removeStacks)) = value;
				}
			}

			// Token: 0x17003395 RID: 13205
			// (get) Token: 0x0600A36B RID: 41835 RVA: 0x00254E44 File Offset: 0x00253044
			// (set) Token: 0x0600A36C RID: 41836 RVA: 0x000505E4 File Offset: 0x0004E7E4
			public unsafe Il2CppReferenceArray<StatusEffectData> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StatusEffectData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003396 RID: 13206
			// (get) Token: 0x0600A36D RID: 41837 RVA: 0x00254E74 File Offset: 0x00253074
			// (set) Token: 0x0600A36E RID: 41838 RVA: 0x00050603 File Offset: 0x0004E803
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.TraitStacks._RemoveEffectStacks_d__21.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x0400693E RID: 26942
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400693F RID: 26943
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006940 RID: 26944
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006941 RID: 26945
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x04006942 RID: 26946
			private static readonly IntPtr NativeFieldInfoPtr_removeStacks;

			// Token: 0x04006943 RID: 26947
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04006944 RID: 26948
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04006945 RID: 26949
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006946 RID: 26950
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006947 RID: 26951
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006948 RID: 26952
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006949 RID: 26953
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400694A RID: 26954
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}

	// Token: 0x020005FC RID: 1532
	[ObfuscatedName("Entity+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06006CA1 RID: 27809 RVA: 0x001AF46C File Offset: 0x001AD66C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<Entity.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr);
			Entity.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9");
			Entity.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__18_0");
			Entity.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__23_0");
			Entity.__c.NativeFieldInfoPtr___9__85_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__85_0");
			Entity.__c.NativeFieldInfoPtr___9__92_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__92_0");
			Entity.__c.NativeFieldInfoPtr___9__95_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__95_1");
			Entity.__c.NativeFieldInfoPtr___9__95_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__95_2");
			Entity.__c.NativeFieldInfoPtr___9__95_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, "<>9__95_3");
			Entity.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666799);
			Entity.__c.NativeMethodInfoPtr__get_containers_b__18_0_Internal_CardContainer_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666800);
			Entity.__c.NativeMethodInfoPtr__get_preContainers_b__23_0_Internal_CardContainer_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666801);
			Entity.__c.NativeMethodInfoPtr__ReadyToDie_b__85_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666802);
			Entity.__c.NativeMethodInfoPtr__OnDestroy_b__92_0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666803);
			Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_1_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666804);
			Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_2_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666805);
			Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_3_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr, 100666806);
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x001AF5D8 File Offset: 0x001AD7D8
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x001AF614 File Offset: 0x001AD814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45358, XrefRangeEnd = 45359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardContainer _get_containers_b__18_0(CardContainer c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__get_containers_b__18_0_Internal_CardContainer_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr3) : null;
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x001AF664 File Offset: 0x001AD864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardContainer _get_preContainers_b__23_0(CardContainer c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__get_preContainers_b__23_0_Internal_CardContainer_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr3) : null;
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x001AF6B4 File Offset: 0x001AD8B4
		[CallerCount(0)]
		public unsafe bool _ReadyToDie_b__85_0(StatusEffectData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__ReadyToDie_b__85_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x001AF704 File Offset: 0x001AD904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45359, XrefRangeEnd = 45363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnDestroy_b__92_0(StatusEffectData status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(status);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__OnDestroy_b__92_0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x001AF754 File Offset: 0x001AD954
		[CallerCount(0)]
		public unsafe bool _UpdateTraits_b__95_1(Entity.TraitStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_1_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x001AF7A4 File Offset: 0x001AD9A4
		[CallerCount(0)]
		public unsafe bool _UpdateTraits_b__95_2(Entity.TraitStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_2_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA9 RID: 27817 RVA: 0x001AF7F4 File Offset: 0x001AD9F4
		[CallerCount(0)]
		public unsafe bool _UpdateTraits_b__95_3(Entity.TraitStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c.NativeMethodInfoPtr__UpdateTraits_b__95_3_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CAA RID: 27818 RVA: 0x00034F1E File Offset: 0x0003311E
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x001AF844 File Offset: 0x001ADA44
		// (set) Token: 0x06006CAC RID: 27820 RVA: 0x00034F27 File Offset: 0x00033127
		public unsafe static Entity.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x06006CAD RID: 27821 RVA: 0x001AF86C File Offset: 0x001ADA6C
		// (set) Token: 0x06006CAE RID: 27822 RVA: 0x00034F39 File Offset: 0x00033139
		public unsafe static Func<CardContainer, CardContainer> __9__18_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardContainer, CardContainer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x06006CAF RID: 27823 RVA: 0x001AF894 File Offset: 0x001ADA94
		// (set) Token: 0x06006CB0 RID: 27824 RVA: 0x00034F4B File Offset: 0x0003314B
		public unsafe static Func<CardContainer, CardContainer> __9__23_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardContainer, CardContainer>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x06006CB1 RID: 27825 RVA: 0x001AF8BC File Offset: 0x001ADABC
		// (set) Token: 0x06006CB2 RID: 27826 RVA: 0x00034F5D File Offset: 0x0003315D
		public unsafe static Predicate<StatusEffectData> __9__85_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__85_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<StatusEffectData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__85_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x06006CB3 RID: 27827 RVA: 0x001AF8E4 File Offset: 0x001ADAE4
		// (set) Token: 0x06006CB4 RID: 27828 RVA: 0x00034F6F File Offset: 0x0003316F
		public unsafe static Func<StatusEffectData, bool> __9__92_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__92_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StatusEffectData, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__92_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x06006CB5 RID: 27829 RVA: 0x001AF90C File Offset: 0x001ADB0C
		// (set) Token: 0x06006CB6 RID: 27830 RVA: 0x00034F81 File Offset: 0x00033181
		public unsafe static Func<Entity.TraitStacks, bool> __9__95_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__95_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity.TraitStacks, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__95_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x06006CB7 RID: 27831 RVA: 0x001AF934 File Offset: 0x001ADB34
		// (set) Token: 0x06006CB8 RID: 27832 RVA: 0x00034F93 File Offset: 0x00033193
		public unsafe static Func<Entity.TraitStacks, bool> __9__95_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__95_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity.TraitStacks, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__95_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06006CB9 RID: 27833 RVA: 0x001AF95C File Offset: 0x001ADB5C
		// (set) Token: 0x06006CBA RID: 27834 RVA: 0x00034FA5 File Offset: 0x000331A5
		public unsafe static Func<Entity.TraitStacks, bool> __9__95_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Entity.__c.NativeFieldInfoPtr___9__95_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity.TraitStacks, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Entity.__c.NativeFieldInfoPtr___9__95_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046D3 RID: 18131
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040046D4 RID: 18132
		private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

		// Token: 0x040046D5 RID: 18133
		private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

		// Token: 0x040046D6 RID: 18134
		private static readonly IntPtr NativeFieldInfoPtr___9__85_0;

		// Token: 0x040046D7 RID: 18135
		private static readonly IntPtr NativeFieldInfoPtr___9__92_0;

		// Token: 0x040046D8 RID: 18136
		private static readonly IntPtr NativeFieldInfoPtr___9__95_1;

		// Token: 0x040046D9 RID: 18137
		private static readonly IntPtr NativeFieldInfoPtr___9__95_2;

		// Token: 0x040046DA RID: 18138
		private static readonly IntPtr NativeFieldInfoPtr___9__95_3;

		// Token: 0x040046DB RID: 18139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046DC RID: 18140
		private static readonly IntPtr NativeMethodInfoPtr__get_containers_b__18_0_Internal_CardContainer_CardContainer_0;

		// Token: 0x040046DD RID: 18141
		private static readonly IntPtr NativeMethodInfoPtr__get_preContainers_b__23_0_Internal_CardContainer_CardContainer_0;

		// Token: 0x040046DE RID: 18142
		private static readonly IntPtr NativeMethodInfoPtr__ReadyToDie_b__85_0_Internal_Boolean_StatusEffectData_0;

		// Token: 0x040046DF RID: 18143
		private static readonly IntPtr NativeMethodInfoPtr__OnDestroy_b__92_0_Internal_Boolean_StatusEffectData_0;

		// Token: 0x040046E0 RID: 18144
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTraits_b__95_1_Internal_Boolean_TraitStacks_0;

		// Token: 0x040046E1 RID: 18145
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTraits_b__95_2_Internal_Boolean_TraitStacks_0;

		// Token: 0x040046E2 RID: 18146
		private static readonly IntPtr NativeMethodInfoPtr__UpdateTraits_b__95_3_Internal_Boolean_TraitStacks_0;
	}

	// Token: 0x020005FD RID: 1533
	[ObfuscatedName("Entity+<>c__DisplayClass70_0")]
	public sealed class __c__DisplayClass70_0 : Il2CppSystem.Object
	{
		// Token: 0x06006CBB RID: 27835 RVA: 0x001AF984 File Offset: 0x001ADB84
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass70_0()
		{
			Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c__DisplayClass70_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr);
			Entity.__c__DisplayClass70_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr, "type");
			Entity.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr, 100666807);
			Entity.__c__DisplayClass70_0.NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr, 100666808);
		}

		// Token: 0x06006CBC RID: 27836 RVA: 0x001AF9EC File Offset: 0x001ADBEC
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass70_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c__DisplayClass70_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CBD RID: 27837 RVA: 0x001AFA28 File Offset: 0x001ADC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45363, XrefRangeEnd = 45365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _FindStatus_b__0(StatusEffectData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass70_0.NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CBE RID: 27838 RVA: 0x00034FB7 File Offset: 0x000331B7
		public __c__DisplayClass70_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x001AFA78 File Offset: 0x001ADC78
		// (set) Token: 0x06006CC0 RID: 27840 RVA: 0x00034FC0 File Offset: 0x000331C0
		public unsafe string type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass70_0.NativeFieldInfoPtr_type);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass70_0.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040046E3 RID: 18147
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040046E4 RID: 18148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046E5 RID: 18149
		private static readonly IntPtr NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0;
	}

	// Token: 0x020005FE RID: 1534
	[ObfuscatedName("Entity+<>c__DisplayClass71_0")]
	public sealed class __c__DisplayClass71_0 : Il2CppSystem.Object
	{
		// Token: 0x06006CC1 RID: 27841 RVA: 0x001AFAA0 File Offset: 0x001ADCA0
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass71_0()
		{
			Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c__DisplayClass71_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr);
			Entity.__c__DisplayClass71_0.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr, "dataType");
			Entity.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr, 100666809);
			Entity.__c__DisplayClass71_0.NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr, 100666810);
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x001AFB08 File Offset: 0x001ADD08
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass71_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c__DisplayClass71_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x001AFB44 File Offset: 0x001ADD44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _FindStatus_b__0(StatusEffectData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass71_0.NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CC4 RID: 27844 RVA: 0x00034FDF File Offset: 0x000331DF
		public __c__DisplayClass71_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06006CC5 RID: 27845 RVA: 0x001AFB94 File Offset: 0x001ADD94
		// (set) Token: 0x06006CC6 RID: 27846 RVA: 0x00034FE8 File Offset: 0x000331E8
		public unsafe StatusEffectData dataType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass71_0.NativeFieldInfoPtr_dataType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusEffectData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass71_0.NativeFieldInfoPtr_dataType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046E6 RID: 18150
		private static readonly IntPtr NativeFieldInfoPtr_dataType;

		// Token: 0x040046E7 RID: 18151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046E8 RID: 18152
		private static readonly IntPtr NativeMethodInfoPtr__FindStatus_b__0_Internal_Boolean_StatusEffectData_0;
	}

	// Token: 0x020005FF RID: 1535
	[ObfuscatedName("Entity+<ClearStatuses>d__72")]
	public sealed class _ClearStatuses_d__72 : Il2CppSystem.Object
	{
		// Token: 0x06006CC7 RID: 27847 RVA: 0x001AFBC4 File Offset: 0x001ADDC4
		// Note: this type is marked as 'beforefieldinit'.
		static _ClearStatuses_d__72()
		{
			Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<ClearStatuses>d__72");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr);
			Entity._ClearStatuses_d__72.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, "<>1__state");
			Entity._ClearStatuses_d__72.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, "<>2__current");
			Entity._ClearStatuses_d__72.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, "<>4__this");
			Entity._ClearStatuses_d__72.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, "<i>5__2");
			Entity._ClearStatuses_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666811);
			Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666812);
			Entity._ClearStatuses_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666813);
			Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666814);
			Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666815);
			Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr, 100666816);
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x001AFCB8 File Offset: 0x001ADEB8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ClearStatuses_d__72(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._ClearStatuses_d__72>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x001AFD00 File Offset: 0x001ADF00
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x001AFD34 File Offset: 0x001ADF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45365, XrefRangeEnd = 45373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x06006CCB RID: 27851 RVA: 0x001AFD70 File Offset: 0x001ADF70
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x001AFDB0 File Offset: 0x001ADFB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45373, XrefRangeEnd = 45379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x06006CCD RID: 27853 RVA: 0x001AFDE4 File Offset: 0x001ADFE4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._ClearStatuses_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x00035007 File Offset: 0x00033207
		public _ClearStatuses_d__72(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06006CCF RID: 27855 RVA: 0x001AFE24 File Offset: 0x001AE024
		// (set) Token: 0x06006CD0 RID: 27856 RVA: 0x00035010 File Offset: 0x00033210
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06006CD1 RID: 27857 RVA: 0x001AFE4C File Offset: 0x001AE04C
		// (set) Token: 0x06006CD2 RID: 27858 RVA: 0x0003502B File Offset: 0x0003322B
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06006CD3 RID: 27859 RVA: 0x001AFE7C File Offset: 0x001AE07C
		// (set) Token: 0x06006CD4 RID: 27860 RVA: 0x0003504A File Offset: 0x0003324A
		public unsafe Entity __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x06006CD5 RID: 27861 RVA: 0x001AFEAC File Offset: 0x001AE0AC
		// (set) Token: 0x06006CD6 RID: 27862 RVA: 0x00035069 File Offset: 0x00033269
		public unsafe int _i_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr__i_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._ClearStatuses_d__72.NativeFieldInfoPtr__i_5__2)) = value;
			}
		}

		// Token: 0x040046E9 RID: 18153
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040046EA RID: 18154
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040046EB RID: 18155
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040046EC RID: 18156
		private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

		// Token: 0x040046ED RID: 18157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040046EE RID: 18158
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040046EF RID: 18159
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040046F0 RID: 18160
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040046F1 RID: 18161
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040046F2 RID: 18162
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000600 RID: 1536
	[ObfuscatedName("Entity+<Reset>d__86")]
	public sealed class _Reset_d__86 : Il2CppSystem.Object
	{
		// Token: 0x06006CD7 RID: 27863 RVA: 0x001AFED4 File Offset: 0x001AE0D4
		// Note: this type is marked as 'beforefieldinit'.
		static _Reset_d__86()
		{
			Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<Reset>d__86");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr);
			Entity._Reset_d__86.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, "<>1__state");
			Entity._Reset_d__86.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, "<>2__current");
			Entity._Reset_d__86.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, "<>4__this");
			Entity._Reset_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666817);
			Entity._Reset_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666818);
			Entity._Reset_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666819);
			Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666820);
			Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666821);
			Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr, 100666822);
		}

		// Token: 0x06006CD8 RID: 27864 RVA: 0x001AFFB4 File Offset: 0x001AE1B4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Reset_d__86(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._Reset_d__86>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CD9 RID: 27865 RVA: 0x001AFFFC File Offset: 0x001AE1FC
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CDA RID: 27866 RVA: 0x001B0030 File Offset: 0x001AE230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45379, XrefRangeEnd = 45380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06006CDB RID: 27867 RVA: 0x001B006C File Offset: 0x001AE26C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006CDC RID: 27868 RVA: 0x001B00AC File Offset: 0x001AE2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45380, XrefRangeEnd = 45386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002179 RID: 8569
		// (get) Token: 0x06006CDD RID: 27869 RVA: 0x001B00E0 File Offset: 0x001AE2E0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Reset_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006CDE RID: 27870 RVA: 0x00035084 File Offset: 0x00033284
		public _Reset_d__86(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002175 RID: 8565
		// (get) Token: 0x06006CDF RID: 27871 RVA: 0x001B0120 File Offset: 0x001AE320
		// (set) Token: 0x06006CE0 RID: 27872 RVA: 0x0003508D File Offset: 0x0003328D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002176 RID: 8566
		// (get) Token: 0x06006CE1 RID: 27873 RVA: 0x001B0148 File Offset: 0x001AE348
		// (set) Token: 0x06006CE2 RID: 27874 RVA: 0x000350A8 File Offset: 0x000332A8
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002177 RID: 8567
		// (get) Token: 0x06006CE3 RID: 27875 RVA: 0x001B0178 File Offset: 0x001AE378
		// (set) Token: 0x06006CE4 RID: 27876 RVA: 0x000350C7 File Offset: 0x000332C7
		public unsafe Entity __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Reset_d__86.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046F3 RID: 18163
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040046F4 RID: 18164
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040046F5 RID: 18165
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040046F6 RID: 18166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040046F7 RID: 18167
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040046F8 RID: 18168
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040046F9 RID: 18169
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040046FA RID: 18170
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040046FB RID: 18171
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000601 RID: 1537
	[ObfuscatedName("Entity+<>c__DisplayClass88_0")]
	public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
	{
		// Token: 0x06006CE5 RID: 27877 RVA: 0x001B01A8 File Offset: 0x001AE3A8
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass88_0()
		{
			Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c__DisplayClass88_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr);
			Entity.__c__DisplayClass88_0.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr, "target");
			Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr, 100666823);
			Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__CanPlayOn_b__0_Internal_Boolean_TargetConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr, 100666824);
			Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__CanPlayOn_b__1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr, 100666825);
		}

		// Token: 0x06006CE6 RID: 27878 RVA: 0x001B0224 File Offset: 0x001AE424
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c__DisplayClass88_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x001B0260 File Offset: 0x001AE460
		[CallerCount(0)]
		public unsafe bool _CanPlayOn_b__0(TargetConstraint c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__CanPlayOn_b__0_Internal_Boolean_TargetConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CE8 RID: 27880 RVA: 0x001B02B0 File Offset: 0x001AE4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45386, XrefRangeEnd = 45387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CanPlayOn_b__1(CardData.StatusEffectStacks s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass88_0.NativeMethodInfoPtr__CanPlayOn_b__1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CE9 RID: 27881 RVA: 0x000350E6 File Offset: 0x000332E6
		public __c__DisplayClass88_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06006CEA RID: 27882 RVA: 0x001B0300 File Offset: 0x001AE500
		// (set) Token: 0x06006CEB RID: 27883 RVA: 0x000350EF File Offset: 0x000332EF
		public unsafe Entity target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass88_0.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass88_0.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046FC RID: 18172
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x040046FD RID: 18173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046FE RID: 18174
		private static readonly IntPtr NativeMethodInfoPtr__CanPlayOn_b__0_Internal_Boolean_TargetConstraint_0;

		// Token: 0x040046FF RID: 18175
		private static readonly IntPtr NativeMethodInfoPtr__CanPlayOn_b__1_Internal_Boolean_StatusEffectStacks_0;
	}

	// Token: 0x02000602 RID: 1538
	[ObfuscatedName("Entity+<Kill>d__90")]
	public sealed class _Kill_d__90 : Il2CppSystem.Object
	{
		// Token: 0x06006CEC RID: 27884 RVA: 0x001B0330 File Offset: 0x001AE530
		// Note: this type is marked as 'beforefieldinit'.
		static _Kill_d__90()
		{
			Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<Kill>d__90");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr);
			Entity._Kill_d__90.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "<>1__state");
			Entity._Kill_d__90.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "<>2__current");
			Entity._Kill_d__90.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "<>4__this");
			Entity._Kill_d__90.NativeFieldInfoPtr_deathType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "deathType");
			Entity._Kill_d__90.NativeFieldInfoPtr__clump_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, "<clump>5__2");
			Entity._Kill_d__90.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666826);
			Entity._Kill_d__90.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666827);
			Entity._Kill_d__90.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666828);
			Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666829);
			Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666830);
			Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr, 100666831);
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x001B0438 File Offset: 0x001AE638
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Kill_d__90(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._Kill_d__90>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CEE RID: 27886 RVA: 0x001B0480 File Offset: 0x001AE680
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CEF RID: 27887 RVA: 0x001B04B4 File Offset: 0x001AE6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45387, XrefRangeEnd = 45391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06006CF0 RID: 27888 RVA: 0x001B04F0 File Offset: 0x001AE6F0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x001B0530 File Offset: 0x001AE730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45391, XrefRangeEnd = 45397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06006CF2 RID: 27890 RVA: 0x001B0564 File Offset: 0x001AE764
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._Kill_d__90.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x0003510E File Offset: 0x0003330E
		public _Kill_d__90(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06006CF4 RID: 27892 RVA: 0x001B05A4 File Offset: 0x001AE7A4
		// (set) Token: 0x06006CF5 RID: 27893 RVA: 0x00035117 File Offset: 0x00033317
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06006CF6 RID: 27894 RVA: 0x001B05CC File Offset: 0x001AE7CC
		// (set) Token: 0x06006CF7 RID: 27895 RVA: 0x00035132 File Offset: 0x00033332
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06006CF8 RID: 27896 RVA: 0x001B05FC File Offset: 0x001AE7FC
		// (set) Token: 0x06006CF9 RID: 27897 RVA: 0x00035151 File Offset: 0x00033351
		public unsafe Entity __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06006CFA RID: 27898 RVA: 0x001B062C File Offset: 0x001AE82C
		// (set) Token: 0x06006CFB RID: 27899 RVA: 0x00035170 File Offset: 0x00033370
		public unsafe DeathType deathType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr_deathType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr_deathType)) = value;
			}
		}

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06006CFC RID: 27900 RVA: 0x001B0654 File Offset: 0x001AE854
		// (set) Token: 0x06006CFD RID: 27901 RVA: 0x0003518B File Offset: 0x0003338B
		public unsafe Routine.Clump _clump_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr__clump_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Routine.Clump>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._Kill_d__90.NativeFieldInfoPtr__clump_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004700 RID: 18176
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004701 RID: 18177
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004702 RID: 18178
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004703 RID: 18179
		private static readonly IntPtr NativeFieldInfoPtr_deathType;

		// Token: 0x04004704 RID: 18180
		private static readonly IntPtr NativeFieldInfoPtr__clump_5__2;

		// Token: 0x04004705 RID: 18181
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004706 RID: 18182
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004707 RID: 18183
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004708 RID: 18184
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004709 RID: 18185
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400470A RID: 18186
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000603 RID: 1539
	[ObfuscatedName("Entity+<>c__DisplayClass93_0")]
	public sealed class __c__DisplayClass93_0 : Il2CppSystem.Object
	{
		// Token: 0x06006CFE RID: 27902 RVA: 0x001B0684 File Offset: 0x001AE884
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass93_0()
		{
			Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<>c__DisplayClass93_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr);
			Entity.__c__DisplayClass93_0.NativeFieldInfoPtr_traitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr, "traitData");
			Entity.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr, 100666832);
			Entity.__c__DisplayClass93_0.NativeMethodInfoPtr__GainTrait_b__0_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr, 100666833);
		}

		// Token: 0x06006CFF RID: 27903 RVA: 0x001B06EC File Offset: 0x001AE8EC
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass93_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity.__c__DisplayClass93_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass93_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D00 RID: 27904 RVA: 0x001B0728 File Offset: 0x001AE928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45397, XrefRangeEnd = 45402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GainTrait_b__0(Entity.TraitStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity.__c__DisplayClass93_0.NativeMethodInfoPtr__GainTrait_b__0_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D01 RID: 27905 RVA: 0x000351AA File Offset: 0x000333AA
		public __c__DisplayClass93_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06006D02 RID: 27906 RVA: 0x001B0778 File Offset: 0x001AE978
		// (set) Token: 0x06006D03 RID: 27907 RVA: 0x000351B3 File Offset: 0x000333B3
		public unsafe TraitData traitData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass93_0.NativeFieldInfoPtr_traitData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity.__c__DisplayClass93_0.NativeFieldInfoPtr_traitData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400470B RID: 18187
		private static readonly IntPtr NativeFieldInfoPtr_traitData;

		// Token: 0x0400470C RID: 18188
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400470D RID: 18189
		private static readonly IntPtr NativeMethodInfoPtr__GainTrait_b__0_Internal_Boolean_TraitStacks_0;
	}

	// Token: 0x02000604 RID: 1540
	[ObfuscatedName("Entity+<UpdateTraits>d__95")]
	public sealed class _UpdateTraits_d__95 : Il2CppSystem.Object
	{
		// Token: 0x06006D04 RID: 27908 RVA: 0x001B07A8 File Offset: 0x001AE9A8
		// Note: this type is marked as 'beforefieldinit'.
		static _UpdateTraits_d__95()
		{
			Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Entity>.NativeClassPtr, "<UpdateTraits>d__95");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr);
			Entity._UpdateTraits_d__95.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<>1__state");
			Entity._UpdateTraits_d__95.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<>2__current");
			Entity._UpdateTraits_d__95.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<>4__this");
			Entity._UpdateTraits_d__95.NativeFieldInfoPtr_moveToFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "moveToFront");
			Entity._UpdateTraits_d__95.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<i>5__2");
			Entity._UpdateTraits_d__95.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<>7__wrap2");
			Entity._UpdateTraits_d__95.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, "<t>5__4");
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666834);
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666835);
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666836);
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666837);
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666838);
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666839);
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666840);
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666841);
			Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr, 100666842);
		}

		// Token: 0x06006D05 RID: 27909 RVA: 0x001B0914 File Offset: 0x001AEB14
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _UpdateTraits_d__95(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Entity._UpdateTraits_d__95>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D06 RID: 27910 RVA: 0x001B095C File Offset: 0x001AEB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45402, XrefRangeEnd = 45417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D07 RID: 27911 RVA: 0x001B0990 File Offset: 0x001AEB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45417, XrefRangeEnd = 45717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006D08 RID: 27912 RVA: 0x001B09CC File Offset: 0x001AEBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45717, XrefRangeEnd = 45720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D09 RID: 27913 RVA: 0x001B0A00 File Offset: 0x001AEC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45720, XrefRangeEnd = 45723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006D0A RID: 27914 RVA: 0x001B0A34 File Offset: 0x001AEC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45723, XrefRangeEnd = 45726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700218A RID: 8586
		// (get) Token: 0x06006D0B RID: 27915 RVA: 0x001B0A68 File Offset: 0x001AEC68
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006D0C RID: 27916 RVA: 0x001B0AA8 File Offset: 0x001AECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45726, XrefRangeEnd = 45732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700218B RID: 8587
		// (get) Token: 0x06006D0D RID: 27917 RVA: 0x001B0ADC File Offset: 0x001AECDC
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Entity._UpdateTraits_d__95.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006D0E RID: 27918 RVA: 0x000351D2 File Offset: 0x000333D2
		public _UpdateTraits_d__95(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06006D0F RID: 27919 RVA: 0x001B0B1C File Offset: 0x001AED1C
		// (set) Token: 0x06006D10 RID: 27920 RVA: 0x000351DB File Offset: 0x000333DB
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06006D11 RID: 27921 RVA: 0x001B0B44 File Offset: 0x001AED44
		// (set) Token: 0x06006D12 RID: 27922 RVA: 0x000351F6 File Offset: 0x000333F6
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x06006D13 RID: 27923 RVA: 0x001B0B74 File Offset: 0x001AED74
		// (set) Token: 0x06006D14 RID: 27924 RVA: 0x00035215 File Offset: 0x00033415
		public unsafe Entity __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x06006D15 RID: 27925 RVA: 0x001B0BA4 File Offset: 0x001AEDA4
		// (set) Token: 0x06006D16 RID: 27926 RVA: 0x00035234 File Offset: 0x00033434
		public unsafe Entity.TraitStacks moveToFront
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr_moveToFront);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity.TraitStacks>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr_moveToFront), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002187 RID: 8583
		// (get) Token: 0x06006D17 RID: 27927 RVA: 0x001B0BD4 File Offset: 0x001AEDD4
		// (set) Token: 0x06006D18 RID: 27928 RVA: 0x00035253 File Offset: 0x00033453
		public unsafe int _i_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr__i_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr__i_5__2)) = value;
			}
		}

		// Token: 0x17002188 RID: 8584
		// (get) Token: 0x06006D19 RID: 27929 RVA: 0x001B0BFC File Offset: 0x001AEDFC
		// (set) Token: 0x06006D1A RID: 27930 RVA: 0x0003526E File Offset: 0x0003346E
		public unsafe IEnumerator<Entity.TraitStacks> __7__wrap2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___7__wrap2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity.TraitStacks>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002189 RID: 8585
		// (get) Token: 0x06006D1B RID: 27931 RVA: 0x001B0C2C File Offset: 0x001AEE2C
		// (set) Token: 0x06006D1C RID: 27932 RVA: 0x0003528D File Offset: 0x0003348D
		public unsafe Entity.TraitStacks _t_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr__t_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity.TraitStacks>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Entity._UpdateTraits_d__95.NativeFieldInfoPtr__t_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400470E RID: 18190
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400470F RID: 18191
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004710 RID: 18192
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004711 RID: 18193
		private static readonly IntPtr NativeFieldInfoPtr_moveToFront;

		// Token: 0x04004712 RID: 18194
		private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

		// Token: 0x04004713 RID: 18195
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

		// Token: 0x04004714 RID: 18196
		private static readonly IntPtr NativeFieldInfoPtr__t_5__4;

		// Token: 0x04004715 RID: 18197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004716 RID: 18198
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004717 RID: 18199
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004718 RID: 18200
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x04004719 RID: 18201
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

		// Token: 0x0400471A RID: 18202
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

		// Token: 0x0400471B RID: 18203
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400471C RID: 18204
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400471D RID: 18205
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000CA RID: 202
public class Battle : SceneRoutine
{
	// Token: 0x06000913 RID: 2323 RVA: 0x00070170 File Offset: 0x0006E370
	// Note: this type is marked as 'beforefieldinit'.
	static Battle()
	{
		Il2CppClassPointerStore<Battle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Battle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle>.NativeClassPtr);
		Battle.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "instance");
		Battle.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "player");
		Battle.NativeFieldInfoPtr_enemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "enemy");
		Battle.NativeFieldInfoPtr_winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "winner");
		Battle.NativeFieldInfoPtr_minibosses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "minibosses");
		Battle.NativeFieldInfoPtr__phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "_phase");
		Battle.NativeFieldInfoPtr_outOfUseCardsGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "outOfUseCardsGroup");
		Battle.NativeFieldInfoPtr_playerCardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "playerCardController");
		Battle.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "rows");
		Battle.NativeFieldInfoPtr_rowIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "rowIndices");
		Battle.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "cards");
		Battle.NativeFieldInfoPtr_startDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "startDelay");
		Battle.NativeFieldInfoPtr_canEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "canEnd");
		Battle.NativeFieldInfoPtr_rowCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "rowCount");
		Battle.NativeFieldInfoPtr_turnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "turnCount");
		Battle.NativeFieldInfoPtr_cancelTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "cancelTurn");
		Battle.NativeFieldInfoPtr_auto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "auto");
		Battle.NativeFieldInfoPtr_loadMidBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle>.NativeClassPtr, "loadMidBattle");
		Battle.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664938);
		Battle.NativeMethodInfoPtr_get_playerMinibossCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664939);
		Battle.NativeMethodInfoPtr_get_enemyMinibossCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664940);
		Battle.NativeMethodInfoPtr_get_phase_Public_get_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664941);
		Battle.NativeMethodInfoPtr_set_phase_Public_set_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664942);
		Battle.NativeMethodInfoPtr_get_allRows_Public_get_IEnumerable_1_CardSlotLane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664943);
		Battle.NativeMethodInfoPtr_get_allSlots_Public_get_IEnumerable_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664944);
		Battle.NativeMethodInfoPtr_get_ended_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664945);
		Battle.NativeMethodInfoPtr_PlayerWin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664946);
		Battle.NativeMethodInfoPtr_EnemyWin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664947);
		Battle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664948);
		Battle.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664949);
		Battle.NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664950);
		Battle.NativeMethodInfoPtr_CancelTurn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664951);
		Battle.NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664952);
		Battle.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664953);
		Battle.NativeMethodInfoPtr_CheckEnd_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664954);
		Battle.NativeMethodInfoPtr_GetOpponent_Public_Static_Character_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664955);
		Battle.NativeMethodInfoPtr_GetRowIndex_Public_Int32_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664956);
		Battle.NativeMethodInfoPtr_GetRowIndices_Public_Il2CppStructArray_1_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664957);
		Battle.NativeMethodInfoPtr_GetRowIndices_Public_Il2CppStructArray_1_Int32_IEnumerable_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664958);
		Battle.NativeMethodInfoPtr_GetRow_Public_CardContainer_Character_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664959);
		Battle.NativeMethodInfoPtr_GetRows_Public_List_1_CardContainer_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664960);
		Battle.NativeMethodInfoPtr_GetOppositeRow_Public_CardSlotLane_CardSlotLane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664961);
		Battle.NativeMethodInfoPtr_GetOppositeRows_Public_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664962);
		Battle.NativeMethodInfoPtr_GetSlots_Public_List_1_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664963);
		Battle.NativeMethodInfoPtr_GetSlots_Public_List_1_CardSlot_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664964);
		Battle.NativeMethodInfoPtr_GetCards_Public_Static_List_1_Entity_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664965);
		Battle.NativeMethodInfoPtr_GetAllCards_Public_Static_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664966);
		Battle.NativeMethodInfoPtr_GetCardsOnBoard_Public_Static_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664967);
		Battle.NativeMethodInfoPtr_GetCardsOnBoard_Public_Static_List_1_Entity_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664968);
		Battle.NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664969);
		Battle.NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_Il2CppReferenceArray_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664970);
		Battle.NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664971);
		Battle.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664972);
		Battle.NativeMethodInfoPtr_BattleLoop_Private_IEnumerator_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664973);
		Battle.NativeMethodInfoPtr_SetSeed_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664974);
		Battle.NativeMethodInfoPtr_WaitForDeckpack_Private_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664975);
		Battle.NativeMethodInfoPtr_WaitForTurnEnd_Private_IEnumerator_Character_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664976);
		Battle.NativeMethodInfoPtr_DrawChampions_Private_IEnumerator_Character_CardContainer_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664977);
		Battle.NativeMethodInfoPtr_WaitForChampionsToDeploy_Private_IEnumerator_Character_CardController_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664978);
		Battle.NativeMethodInfoPtr_CrownCardsInContainer_Private_Static_Int32_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664979);
		Battle.NativeMethodInfoPtr_UpdateBoard_Private_IEnumerator_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664980);
		Battle.NativeMethodInfoPtr_CanDeploy_Public_Boolean_Entity_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664981);
		Battle.NativeMethodInfoPtr_CanPushBack_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664982);
		Battle.NativeMethodInfoPtr_CanPushForwards_Private_Static_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664983);
		Battle.NativeMethodInfoPtr_UpdateContainer_Private_IEnumerator_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664984);
		Battle.NativeMethodInfoPtr_CheckUnitsTakeTurns_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664985);
		Battle.NativeMethodInfoPtr_CheckUnitsTakeTurns_Private_IEnumerator_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664986);
		Battle.NativeMethodInfoPtr_ProcessUnits_Private_IEnumerator_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664987);
		Battle.NativeMethodInfoPtr_GetAllUnits_Public_Static_HashSet_1_Entity_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664988);
		Battle.NativeMethodInfoPtr_GetAllUnits_Public_Static_HashSet_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664989);
		Battle.NativeMethodInfoPtr_ProcessUnit_Private_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664990);
		Battle.NativeMethodInfoPtr_ProcessHandStart_Private_IEnumerator_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664991);
		Battle.NativeMethodInfoPtr_ProcessHandEnd_Private_IEnumerator_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664992);
		Battle.NativeMethodInfoPtr_ProcessUnitTurnEnd_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664993);
		Battle.NativeMethodInfoPtr_CardCountDown_Private_Static_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664994);
		Battle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664995);
		Battle.NativeMethodInfoPtr__get_playerMinibossCount_b__8_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664996);
		Battle.NativeMethodInfoPtr__get_enemyMinibossCount_b__10_0_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle>.NativeClassPtr, 100664997);
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x000707B8 File Offset: 0x0006E9B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29911, XrefRangeEnd = 29919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000228 RID: 552
	// (get) Token: 0x06000915 RID: 2325 RVA: 0x000707EC File Offset: 0x0006E9EC
	public unsafe int playerMinibossCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29919, XrefRangeEnd = 29929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_get_playerMinibossCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000229 RID: 553
	// (get) Token: 0x06000916 RID: 2326 RVA: 0x00070828 File Offset: 0x0006EA28
	public unsafe int enemyMinibossCount
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29929, XrefRangeEnd = 29939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_get_enemyMinibossCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700022A RID: 554
	// (get) Token: 0x06000917 RID: 2327 RVA: 0x00070864 File Offset: 0x0006EA64
	// (set) Token: 0x06000918 RID: 2328 RVA: 0x000708A0 File Offset: 0x0006EAA0
	public unsafe Battle.Phase phase
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_get_phase_Public_get_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 29950, RefRangeEnd = 29959, XrefRangeStart = 29939, XrefRangeEnd = 29950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_set_phase_Public_set_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700022B RID: 555
	// (get) Token: 0x06000919 RID: 2329 RVA: 0x000708E0 File Offset: 0x0006EAE0
	public unsafe IEnumerable<CardSlotLane> allRows
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29984, RefRangeEnd = 29985, XrefRangeStart = 29959, XrefRangeEnd = 29984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_get_allRows_Public_get_IEnumerable_1_CardSlotLane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CardSlotLane>>(intPtr3) : null;
		}
	}

	// Token: 0x1700022C RID: 556
	// (get) Token: 0x0600091A RID: 2330 RVA: 0x00070920 File Offset: 0x0006EB20
	public unsafe IEnumerable<CardSlot> allSlots
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29985, XrefRangeEnd = 30028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_get_allSlots_Public_get_IEnumerable_1_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CardSlot>>(intPtr3) : null;
		}
	}

	// Token: 0x1700022D RID: 557
	// (get) Token: 0x0600091B RID: 2331 RVA: 0x00070960 File Offset: 0x0006EB60
	public unsafe bool ended
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 30028, RefRangeEnd = 30034, XrefRangeStart = 30028, XrefRangeEnd = 30028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_get_ended_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600091C RID: 2332 RVA: 0x0007099C File Offset: 0x0006EB9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30036, RefRangeEnd = 30037, XrefRangeStart = 30034, XrefRangeEnd = 30036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayerWin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_PlayerWin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600091D RID: 2333 RVA: 0x000709D0 File Offset: 0x0006EBD0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30039, RefRangeEnd = 30040, XrefRangeStart = 30037, XrefRangeEnd = 30039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnemyWin()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_EnemyWin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600091E RID: 2334 RVA: 0x00070A04 File Offset: 0x0006EC04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30040, XrefRangeEnd = 30061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600091F RID: 2335 RVA: 0x00070A38 File Offset: 0x0006EC38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30061, XrefRangeEnd = 30082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000920 RID: 2336 RVA: 0x00070A6C File Offset: 0x0006EC6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30082, XrefRangeEnd = 30088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityCreated(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000921 RID: 2337 RVA: 0x00070AB0 File Offset: 0x0006ECB0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30088, RefRangeEnd = 30089, XrefRangeStart = 30088, XrefRangeEnd = 30088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelTurn()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CancelTurn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000922 RID: 2338 RVA: 0x00070AE4 File Offset: 0x0006ECE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30089, XrefRangeEnd = 30090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityDestroyed(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000923 RID: 2339 RVA: 0x00070B28 File Offset: 0x0006ED28
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30117, RefRangeEnd = 30118, XrefRangeStart = 30090, XrefRangeEnd = 30117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityKilled(Entity entity, DeathType deathType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deathType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000924 RID: 2340 RVA: 0x00070B78 File Offset: 0x0006ED78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30118, XrefRangeEnd = 30136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CheckEnd_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000925 RID: 2341 RVA: 0x00070BB4 File Offset: 0x0006EDB4
	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 30143, RefRangeEnd = 30159, XrefRangeStart = 30136, XrefRangeEnd = 30143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Character GetOpponent(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetOpponent_Public_Static_Character_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Character>(intPtr3) : null;
	}

	// Token: 0x06000926 RID: 2342 RVA: 0x00070BF8 File Offset: 0x0006EDF8
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 30172, RefRangeEnd = 30182, XrefRangeStart = 30159, XrefRangeEnd = 30172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetRowIndex(CardContainer rowContainer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rowContainer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetRowIndex_Public_Int32_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000927 RID: 2343 RVA: 0x00070C48 File Offset: 0x0006EE48
	[CallerCount(21)]
	[CachedScanResults(RefRangeStart = 30210, RefRangeEnd = 30231, XrefRangeStart = 30182, XrefRangeEnd = 30210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> GetRowIndices(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetRowIndices_Public_Il2CppStructArray_1_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
	}

	// Token: 0x06000928 RID: 2344 RVA: 0x00070C98 File Offset: 0x0006EE98
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 30271, RefRangeEnd = 30274, XrefRangeStart = 30231, XrefRangeEnd = 30271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<int> GetRowIndices(IEnumerable<CardContainer> containers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(containers);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetRowIndices_Public_Il2CppStructArray_1_Int32_IEnumerable_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
	}

	// Token: 0x06000929 RID: 2345 RVA: 0x00070CE8 File Offset: 0x0006EEE8
	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 30281, RefRangeEnd = 30299, XrefRangeStart = 30274, XrefRangeEnd = 30281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardContainer GetRow(Character owner, int rowIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rowIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetRow_Public_CardContainer_Character_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr3) : null;
	}

	// Token: 0x0600092A RID: 2346 RVA: 0x00070D48 File Offset: 0x0006EF48
	[CallerCount(27)]
	[CachedScanResults(RefRangeStart = 30325, RefRangeEnd = 30352, XrefRangeStart = 30299, XrefRangeEnd = 30325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CardContainer> GetRows(Character owner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetRows_Public_List_1_CardContainer_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CardContainer>>(intPtr3) : null;
	}

	// Token: 0x0600092B RID: 2347 RVA: 0x00070D98 File Offset: 0x0006EF98
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30361, RefRangeEnd = 30362, XrefRangeStart = 30352, XrefRangeEnd = 30361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardSlotLane GetOppositeRow(CardSlotLane row)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetOppositeRow_Public_CardSlotLane_CardSlotLane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardSlotLane>(intPtr3) : null;
	}

	// Token: 0x0600092C RID: 2348 RVA: 0x00070DE8 File Offset: 0x0006EFE8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30375, RefRangeEnd = 30376, XrefRangeStart = 30362, XrefRangeEnd = 30375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppReferenceArray<CardContainer> GetOppositeRows(Il2CppReferenceArray<CardContainer> rows)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(rows);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetOppositeRows_Public_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardContainer>>(intPtr3) : null;
	}

	// Token: 0x0600092D RID: 2349 RVA: 0x00070E38 File Offset: 0x0006F038
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30426, RefRangeEnd = 30428, XrefRangeStart = 30376, XrefRangeEnd = 30426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CardSlot> GetSlots()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetSlots_Public_List_1_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CardSlot>>(intPtr3) : null;
	}

	// Token: 0x0600092E RID: 2350 RVA: 0x00070E78 File Offset: 0x0006F078
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30457, RefRangeEnd = 30459, XrefRangeStart = 30428, XrefRangeEnd = 30457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe List<CardSlot> GetSlots(Character owner)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetSlots_Public_List_1_CardSlot_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<CardSlot>>(intPtr3) : null;
	}

	// Token: 0x0600092F RID: 2351 RVA: 0x00070EC8 File Offset: 0x0006F0C8
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 30505, RefRangeEnd = 30513, XrefRangeStart = 30459, XrefRangeEnd = 30505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Entity> GetCards(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetCards_Public_Static_List_1_Entity_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00070F0C File Offset: 0x0006F10C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30529, RefRangeEnd = 30530, XrefRangeStart = 30513, XrefRangeEnd = 30529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Entity> GetAllCards()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetAllCards_Public_Static_List_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06000931 RID: 2353 RVA: 0x00070F40 File Offset: 0x0006F140
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 30546, RefRangeEnd = 30549, XrefRangeStart = 30530, XrefRangeEnd = 30546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Entity> GetCardsOnBoard()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetCardsOnBoard_Public_Static_List_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x00070F74 File Offset: 0x0006F174
	[CallerCount(42)]
	[CachedScanResults(RefRangeStart = 30570, RefRangeEnd = 30612, XrefRangeStart = 30549, XrefRangeEnd = 30570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<Entity> GetCardsOnBoard(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetCardsOnBoard_Public_Static_List_1_Entity_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr3) : null;
	}

	// Token: 0x06000933 RID: 2355 RVA: 0x00070FB8 File Offset: 0x0006F1B8
	[CallerCount(76)]
	[CachedScanResults(RefRangeStart = 30616, RefRangeEnd = 30692, XrefRangeStart = 30612, XrefRangeEnd = 30616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOnBoard(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000934 RID: 2356 RVA: 0x00070FFC File Offset: 0x0006F1FC
	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 30696, RefRangeEnd = 30714, XrefRangeStart = 30692, XrefRangeEnd = 30696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOnBoard(Il2CppReferenceArray<CardContainer> containers)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(containers);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_Il2CppReferenceArray_1_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00071040 File Offset: 0x0006F240
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 30717, RefRangeEnd = 30724, XrefRangeStart = 30714, XrefRangeEnd = 30717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsOnBoard(CardContainer container)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x00071084 File Offset: 0x0006F284
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30724, XrefRangeEnd = 30729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator Run()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Battle.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x000710D0 File Offset: 0x0006F2D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30729, XrefRangeEnd = 30735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator BattleLoop(CampaignNode node)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_BattleLoop_Private_IEnumerator_CampaignNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x00071120 File Offset: 0x0006F320
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30749, RefRangeEnd = 30751, XrefRangeStart = 30735, XrefRangeEnd = 30749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetSeed(int baseSeed, int offset)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref baseSeed;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_SetSeed_Private_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x00071160 File Offset: 0x0006F360
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 30755, RefRangeEnd = 30765, XrefRangeStart = 30751, XrefRangeEnd = 30755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator WaitForDeckpack()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_WaitForDeckpack_Private_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600093A RID: 2362 RVA: 0x00071194 File Offset: 0x0006F394
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30765, XrefRangeEnd = 30772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator WaitForTurnEnd(Character character, CardController cardController)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardController);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_WaitForTurnEnd_Private_IEnumerator_Character_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600093B RID: 2363 RVA: 0x000711F8 File Offset: 0x0006F3F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30772, XrefRangeEnd = 30779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator DrawChampions(Character character, CardContainer fromContainer, CardContainer toContainer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fromContainer);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toContainer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_DrawChampions_Private_IEnumerator_Character_CardContainer_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600093C RID: 2364 RVA: 0x0007126C File Offset: 0x0006F46C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30779, XrefRangeEnd = 30787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator WaitForChampionsToDeploy(Character character, CardController cardController, CardContainer handContainer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cardController);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handContainer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_WaitForChampionsToDeploy_Private_IEnumerator_Character_CardController_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600093D RID: 2365 RVA: 0x000712E0 File Offset: 0x0006F4E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30806, RefRangeEnd = 30807, XrefRangeStart = 30787, XrefRangeEnd = 30806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CrownCardsInContainer(CardContainer container)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CrownCardsInContainer_Private_Static_Int32_CardContainer_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600093E RID: 2366 RVA: 0x00071324 File Offset: 0x0006F524
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 30813, RefRangeEnd = 30817, XrefRangeStart = 30807, XrefRangeEnd = 30813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator UpdateBoard(Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_UpdateBoard_Private_IEnumerator_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600093F RID: 2367 RVA: 0x00071374 File Offset: 0x0006F574
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 30848, RefRangeEnd = 30851, XrefRangeStart = 30817, XrefRangeEnd = 30848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanDeploy(Entity entity, int targetRow, out int targetColumn)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetRow;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &targetColumn;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CanDeploy_Public_Boolean_Entity_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000940 RID: 2368 RVA: 0x000713E0 File Offset: 0x0006F5E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30869, RefRangeEnd = 30870, XrefRangeStart = 30851, XrefRangeEnd = 30869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanPushBack(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CanPushBack_Private_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000941 RID: 2369 RVA: 0x00071424 File Offset: 0x0006F624
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30885, RefRangeEnd = 30886, XrefRangeStart = 30870, XrefRangeEnd = 30885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CanPushForwards(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CanPushForwards_Private_Static_Boolean_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000942 RID: 2370 RVA: 0x00071468 File Offset: 0x0006F668
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30891, RefRangeEnd = 30893, XrefRangeStart = 30886, XrefRangeEnd = 30891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator UpdateContainer(CardContainer container)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_UpdateContainer_Private_IEnumerator_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000943 RID: 2371 RVA: 0x000714B8 File Offset: 0x0006F6B8
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 30898, RefRangeEnd = 30904, XrefRangeStart = 30893, XrefRangeEnd = 30898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CheckUnitsTakeTurns()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CheckUnitsTakeTurns_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000944 RID: 2372 RVA: 0x000714F8 File Offset: 0x0006F6F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30910, RefRangeEnd = 30911, XrefRangeStart = 30904, XrefRangeEnd = 30910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CheckUnitsTakeTurns(Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CheckUnitsTakeTurns_Private_IEnumerator_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000945 RID: 2373 RVA: 0x00071548 File Offset: 0x0006F748
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 30917, RefRangeEnd = 30919, XrefRangeStart = 30911, XrefRangeEnd = 30917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessUnits(Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_ProcessUnits_Private_IEnumerator_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00071598 File Offset: 0x0006F798
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30937, RefRangeEnd = 30938, XrefRangeStart = 30919, XrefRangeEnd = 30937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<Entity> GetAllUnits(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetAllUnits_Public_Static_HashSet_1_Entity_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr3) : null;
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x000715DC File Offset: 0x0006F7DC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 30976, RefRangeEnd = 30979, XrefRangeStart = 30938, XrefRangeEnd = 30976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static HashSet<Entity> GetAllUnits()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_GetAllUnits_Public_Static_HashSet_1_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<Entity>>(intPtr3) : null;
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00071610 File Offset: 0x0006F810
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 30985, RefRangeEnd = 30986, XrefRangeStart = 30979, XrefRangeEnd = 30985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessUnit(Entity unit)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_ProcessUnit_Private_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00071660 File Offset: 0x0006F860
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30986, XrefRangeEnd = 30992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessHandStart(Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_ProcessHandStart_Private_IEnumerator_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x000716B0 File Offset: 0x0006F8B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30992, XrefRangeEnd = 30998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessHandEnd(Character character)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_ProcessHandEnd_Private_IEnumerator_Character_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00071700 File Offset: 0x0006F900
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30998, XrefRangeEnd = 31003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessUnitTurnEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_ProcessUnitTurnEnd_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00071740 File Offset: 0x0006F940
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31008, RefRangeEnd = 31009, XrefRangeStart = 31003, XrefRangeEnd = 31008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator CardCountDown(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr_CardCountDown_Private_Static_IEnumerator_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00071784 File Offset: 0x0006F984
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31009, XrefRangeEnd = 31037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Battle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x000717C0 File Offset: 0x0006F9C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31037, XrefRangeEnd = 31041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _get_playerMinibossCount_b__8_0(Entity a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr__get_playerMinibossCount_b__8_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00071810 File Offset: 0x0006FA10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31041, XrefRangeEnd = 31045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _get_enemyMinibossCount_b__10_0(Entity a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.NativeMethodInfoPtr__get_enemyMinibossCount_b__10_0_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000950 RID: 2384 RVA: 0x00005DCF File Offset: 0x00003FCF
	public Battle(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x06000951 RID: 2385 RVA: 0x00071860 File Offset: 0x0006FA60
	// (set) Token: 0x06000952 RID: 2386 RVA: 0x00005DD8 File Offset: 0x00003FD8
	public unsafe static Battle instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Battle.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Battle.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x06000953 RID: 2387 RVA: 0x00071888 File Offset: 0x0006FA88
	// (set) Token: 0x06000954 RID: 2388 RVA: 0x00005DEA File Offset: 0x00003FEA
	public unsafe Character player
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_player);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000218 RID: 536
	// (get) Token: 0x06000955 RID: 2389 RVA: 0x000718B8 File Offset: 0x0006FAB8
	// (set) Token: 0x06000956 RID: 2390 RVA: 0x00005E09 File Offset: 0x00004009
	public unsafe Character enemy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_enemy);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_enemy), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000219 RID: 537
	// (get) Token: 0x06000957 RID: 2391 RVA: 0x000718E8 File Offset: 0x0006FAE8
	// (set) Token: 0x06000958 RID: 2392 RVA: 0x00005E28 File Offset: 0x00004028
	public unsafe Character winner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_winner);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_winner), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021A RID: 538
	// (get) Token: 0x06000959 RID: 2393 RVA: 0x00071918 File Offset: 0x0006FB18
	// (set) Token: 0x0600095A RID: 2394 RVA: 0x00005E47 File Offset: 0x00004047
	public unsafe List<Entity> minibosses
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_minibosses);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_minibosses), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021B RID: 539
	// (get) Token: 0x0600095B RID: 2395 RVA: 0x00071948 File Offset: 0x0006FB48
	// (set) Token: 0x0600095C RID: 2396 RVA: 0x00005E66 File Offset: 0x00004066
	public unsafe Battle.Phase _phase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr__phase);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr__phase)) = value;
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x0600095D RID: 2397 RVA: 0x00071970 File Offset: 0x0006FB70
	// (set) Token: 0x0600095E RID: 2398 RVA: 0x00005E81 File Offset: 0x00004081
	public unsafe Transform outOfUseCardsGroup
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_outOfUseCardsGroup);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_outOfUseCardsGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021D RID: 541
	// (get) Token: 0x0600095F RID: 2399 RVA: 0x000719A0 File Offset: 0x0006FBA0
	// (set) Token: 0x06000960 RID: 2400 RVA: 0x00005EA0 File Offset: 0x000040A0
	public unsafe CardController playerCardController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_playerCardController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_playerCardController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x06000961 RID: 2401 RVA: 0x000719D0 File Offset: 0x0006FBD0
	// (set) Token: 0x06000962 RID: 2402 RVA: 0x00005EBF File Offset: 0x000040BF
	public unsafe Dictionary<Character, List<CardContainer>> rows
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_rows);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Character, List<CardContainer>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x06000963 RID: 2403 RVA: 0x00071A00 File Offset: 0x0006FC00
	// (set) Token: 0x06000964 RID: 2404 RVA: 0x00005EDE File Offset: 0x000040DE
	public unsafe Dictionary<CardContainer, int> rowIndices
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_rowIndices);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<CardContainer, int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_rowIndices), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x06000965 RID: 2405 RVA: 0x00071A30 File Offset: 0x0006FC30
	// (set) Token: 0x06000966 RID: 2406 RVA: 0x00005EFD File Offset: 0x000040FD
	public unsafe List<Entity> cards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_cards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000221 RID: 545
	// (get) Token: 0x06000967 RID: 2407 RVA: 0x00071A60 File Offset: 0x0006FC60
	// (set) Token: 0x06000968 RID: 2408 RVA: 0x00005F1C File Offset: 0x0000411C
	public unsafe float startDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_startDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_startDelay)) = value;
		}
	}

	// Token: 0x17000222 RID: 546
	// (get) Token: 0x06000969 RID: 2409 RVA: 0x00071A88 File Offset: 0x0006FC88
	// (set) Token: 0x0600096A RID: 2410 RVA: 0x00005F37 File Offset: 0x00004137
	public unsafe bool canEnd
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_canEnd);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_canEnd)) = value;
		}
	}

	// Token: 0x17000223 RID: 547
	// (get) Token: 0x0600096B RID: 2411 RVA: 0x00071AB0 File Offset: 0x0006FCB0
	// (set) Token: 0x0600096C RID: 2412 RVA: 0x00005F52 File Offset: 0x00004152
	public unsafe int rowCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_rowCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_rowCount)) = value;
		}
	}

	// Token: 0x17000224 RID: 548
	// (get) Token: 0x0600096D RID: 2413 RVA: 0x00071AD8 File Offset: 0x0006FCD8
	// (set) Token: 0x0600096E RID: 2414 RVA: 0x00005F6D File Offset: 0x0000416D
	public unsafe int turnCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_turnCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_turnCount)) = value;
		}
	}

	// Token: 0x17000225 RID: 549
	// (get) Token: 0x0600096F RID: 2415 RVA: 0x00071B00 File Offset: 0x0006FD00
	// (set) Token: 0x06000970 RID: 2416 RVA: 0x00005F88 File Offset: 0x00004188
	public unsafe bool cancelTurn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_cancelTurn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_cancelTurn)) = value;
		}
	}

	// Token: 0x17000226 RID: 550
	// (get) Token: 0x06000971 RID: 2417 RVA: 0x00071B28 File Offset: 0x0006FD28
	// (set) Token: 0x06000972 RID: 2418 RVA: 0x00005FA3 File Offset: 0x000041A3
	public unsafe bool auto
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_auto);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_auto)) = value;
		}
	}

	// Token: 0x17000227 RID: 551
	// (get) Token: 0x06000973 RID: 2419 RVA: 0x00071B50 File Offset: 0x0006FD50
	// (set) Token: 0x06000974 RID: 2420 RVA: 0x00005FBE File Offset: 0x000041BE
	public unsafe bool loadMidBattle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_loadMidBattle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.NativeFieldInfoPtr_loadMidBattle)) = value;
		}
	}

	// Token: 0x0400059A RID: 1434
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x0400059B RID: 1435
	private static readonly IntPtr NativeFieldInfoPtr_player;

	// Token: 0x0400059C RID: 1436
	private static readonly IntPtr NativeFieldInfoPtr_enemy;

	// Token: 0x0400059D RID: 1437
	private static readonly IntPtr NativeFieldInfoPtr_winner;

	// Token: 0x0400059E RID: 1438
	private static readonly IntPtr NativeFieldInfoPtr_minibosses;

	// Token: 0x0400059F RID: 1439
	private static readonly IntPtr NativeFieldInfoPtr__phase;

	// Token: 0x040005A0 RID: 1440
	private static readonly IntPtr NativeFieldInfoPtr_outOfUseCardsGroup;

	// Token: 0x040005A1 RID: 1441
	private static readonly IntPtr NativeFieldInfoPtr_playerCardController;

	// Token: 0x040005A2 RID: 1442
	private static readonly IntPtr NativeFieldInfoPtr_rows;

	// Token: 0x040005A3 RID: 1443
	private static readonly IntPtr NativeFieldInfoPtr_rowIndices;

	// Token: 0x040005A4 RID: 1444
	private static readonly IntPtr NativeFieldInfoPtr_cards;

	// Token: 0x040005A5 RID: 1445
	private static readonly IntPtr NativeFieldInfoPtr_startDelay;

	// Token: 0x040005A6 RID: 1446
	private static readonly IntPtr NativeFieldInfoPtr_canEnd;

	// Token: 0x040005A7 RID: 1447
	private static readonly IntPtr NativeFieldInfoPtr_rowCount;

	// Token: 0x040005A8 RID: 1448
	private static readonly IntPtr NativeFieldInfoPtr_turnCount;

	// Token: 0x040005A9 RID: 1449
	private static readonly IntPtr NativeFieldInfoPtr_cancelTurn;

	// Token: 0x040005AA RID: 1450
	private static readonly IntPtr NativeFieldInfoPtr_auto;

	// Token: 0x040005AB RID: 1451
	private static readonly IntPtr NativeFieldInfoPtr_loadMidBattle;

	// Token: 0x040005AC RID: 1452
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040005AD RID: 1453
	private static readonly IntPtr NativeMethodInfoPtr_get_playerMinibossCount_Private_get_Int32_0;

	// Token: 0x040005AE RID: 1454
	private static readonly IntPtr NativeMethodInfoPtr_get_enemyMinibossCount_Private_get_Int32_0;

	// Token: 0x040005AF RID: 1455
	private static readonly IntPtr NativeMethodInfoPtr_get_phase_Public_get_Phase_0;

	// Token: 0x040005B0 RID: 1456
	private static readonly IntPtr NativeMethodInfoPtr_set_phase_Public_set_Void_Phase_0;

	// Token: 0x040005B1 RID: 1457
	private static readonly IntPtr NativeMethodInfoPtr_get_allRows_Public_get_IEnumerable_1_CardSlotLane_0;

	// Token: 0x040005B2 RID: 1458
	private static readonly IntPtr NativeMethodInfoPtr_get_allSlots_Public_get_IEnumerable_1_CardSlot_0;

	// Token: 0x040005B3 RID: 1459
	private static readonly IntPtr NativeMethodInfoPtr_get_ended_Public_get_Boolean_0;

	// Token: 0x040005B4 RID: 1460
	private static readonly IntPtr NativeMethodInfoPtr_PlayerWin_Public_Void_0;

	// Token: 0x040005B5 RID: 1461
	private static readonly IntPtr NativeMethodInfoPtr_EnemyWin_Public_Void_0;

	// Token: 0x040005B6 RID: 1462
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040005B7 RID: 1463
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040005B8 RID: 1464
	private static readonly IntPtr NativeMethodInfoPtr_EntityCreated_Private_Void_Entity_0;

	// Token: 0x040005B9 RID: 1465
	private static readonly IntPtr NativeMethodInfoPtr_CancelTurn_Public_Void_0;

	// Token: 0x040005BA RID: 1466
	private static readonly IntPtr NativeMethodInfoPtr_EntityDestroyed_Private_Void_Entity_0;

	// Token: 0x040005BB RID: 1467
	private static readonly IntPtr NativeMethodInfoPtr_EntityKilled_Private_Void_Entity_DeathType_0;

	// Token: 0x040005BC RID: 1468
	private static readonly IntPtr NativeMethodInfoPtr_CheckEnd_Public_Boolean_0;

	// Token: 0x040005BD RID: 1469
	private static readonly IntPtr NativeMethodInfoPtr_GetOpponent_Public_Static_Character_Character_0;

	// Token: 0x040005BE RID: 1470
	private static readonly IntPtr NativeMethodInfoPtr_GetRowIndex_Public_Int32_CardContainer_0;

	// Token: 0x040005BF RID: 1471
	private static readonly IntPtr NativeMethodInfoPtr_GetRowIndices_Public_Il2CppStructArray_1_Int32_Entity_0;

	// Token: 0x040005C0 RID: 1472
	private static readonly IntPtr NativeMethodInfoPtr_GetRowIndices_Public_Il2CppStructArray_1_Int32_IEnumerable_1_CardContainer_0;

	// Token: 0x040005C1 RID: 1473
	private static readonly IntPtr NativeMethodInfoPtr_GetRow_Public_CardContainer_Character_Int32_0;

	// Token: 0x040005C2 RID: 1474
	private static readonly IntPtr NativeMethodInfoPtr_GetRows_Public_List_1_CardContainer_Character_0;

	// Token: 0x040005C3 RID: 1475
	private static readonly IntPtr NativeMethodInfoPtr_GetOppositeRow_Public_CardSlotLane_CardSlotLane_0;

	// Token: 0x040005C4 RID: 1476
	private static readonly IntPtr NativeMethodInfoPtr_GetOppositeRows_Public_Il2CppReferenceArray_1_CardContainer_Il2CppReferenceArray_1_CardContainer_0;

	// Token: 0x040005C5 RID: 1477
	private static readonly IntPtr NativeMethodInfoPtr_GetSlots_Public_List_1_CardSlot_0;

	// Token: 0x040005C6 RID: 1478
	private static readonly IntPtr NativeMethodInfoPtr_GetSlots_Public_List_1_CardSlot_Character_0;

	// Token: 0x040005C7 RID: 1479
	private static readonly IntPtr NativeMethodInfoPtr_GetCards_Public_Static_List_1_Entity_Character_0;

	// Token: 0x040005C8 RID: 1480
	private static readonly IntPtr NativeMethodInfoPtr_GetAllCards_Public_Static_List_1_Entity_0;

	// Token: 0x040005C9 RID: 1481
	private static readonly IntPtr NativeMethodInfoPtr_GetCardsOnBoard_Public_Static_List_1_Entity_0;

	// Token: 0x040005CA RID: 1482
	private static readonly IntPtr NativeMethodInfoPtr_GetCardsOnBoard_Public_Static_List_1_Entity_Character_0;

	// Token: 0x040005CB RID: 1483
	private static readonly IntPtr NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_Entity_0;

	// Token: 0x040005CC RID: 1484
	private static readonly IntPtr NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_Il2CppReferenceArray_1_CardContainer_0;

	// Token: 0x040005CD RID: 1485
	private static readonly IntPtr NativeMethodInfoPtr_IsOnBoard_Public_Static_Boolean_CardContainer_0;

	// Token: 0x040005CE RID: 1486
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;

	// Token: 0x040005CF RID: 1487
	private static readonly IntPtr NativeMethodInfoPtr_BattleLoop_Private_IEnumerator_CampaignNode_0;

	// Token: 0x040005D0 RID: 1488
	private static readonly IntPtr NativeMethodInfoPtr_SetSeed_Private_Static_Void_Int32_Int32_0;

	// Token: 0x040005D1 RID: 1489
	private static readonly IntPtr NativeMethodInfoPtr_WaitForDeckpack_Private_Static_IEnumerator_0;

	// Token: 0x040005D2 RID: 1490
	private static readonly IntPtr NativeMethodInfoPtr_WaitForTurnEnd_Private_IEnumerator_Character_CardController_0;

	// Token: 0x040005D3 RID: 1491
	private static readonly IntPtr NativeMethodInfoPtr_DrawChampions_Private_IEnumerator_Character_CardContainer_CardContainer_0;

	// Token: 0x040005D4 RID: 1492
	private static readonly IntPtr NativeMethodInfoPtr_WaitForChampionsToDeploy_Private_IEnumerator_Character_CardController_CardContainer_0;

	// Token: 0x040005D5 RID: 1493
	private static readonly IntPtr NativeMethodInfoPtr_CrownCardsInContainer_Private_Static_Int32_CardContainer_0;

	// Token: 0x040005D6 RID: 1494
	private static readonly IntPtr NativeMethodInfoPtr_UpdateBoard_Private_IEnumerator_Character_0;

	// Token: 0x040005D7 RID: 1495
	private static readonly IntPtr NativeMethodInfoPtr_CanDeploy_Public_Boolean_Entity_Int32_byref_Int32_0;

	// Token: 0x040005D8 RID: 1496
	private static readonly IntPtr NativeMethodInfoPtr_CanPushBack_Private_Static_Boolean_Entity_0;

	// Token: 0x040005D9 RID: 1497
	private static readonly IntPtr NativeMethodInfoPtr_CanPushForwards_Private_Static_Boolean_Entity_0;

	// Token: 0x040005DA RID: 1498
	private static readonly IntPtr NativeMethodInfoPtr_UpdateContainer_Private_IEnumerator_CardContainer_0;

	// Token: 0x040005DB RID: 1499
	private static readonly IntPtr NativeMethodInfoPtr_CheckUnitsTakeTurns_Private_IEnumerator_0;

	// Token: 0x040005DC RID: 1500
	private static readonly IntPtr NativeMethodInfoPtr_CheckUnitsTakeTurns_Private_IEnumerator_Character_0;

	// Token: 0x040005DD RID: 1501
	private static readonly IntPtr NativeMethodInfoPtr_ProcessUnits_Private_IEnumerator_Character_0;

	// Token: 0x040005DE RID: 1502
	private static readonly IntPtr NativeMethodInfoPtr_GetAllUnits_Public_Static_HashSet_1_Entity_Character_0;

	// Token: 0x040005DF RID: 1503
	private static readonly IntPtr NativeMethodInfoPtr_GetAllUnits_Public_Static_HashSet_1_Entity_0;

	// Token: 0x040005E0 RID: 1504
	private static readonly IntPtr NativeMethodInfoPtr_ProcessUnit_Private_IEnumerator_Entity_0;

	// Token: 0x040005E1 RID: 1505
	private static readonly IntPtr NativeMethodInfoPtr_ProcessHandStart_Private_IEnumerator_Character_0;

	// Token: 0x040005E2 RID: 1506
	private static readonly IntPtr NativeMethodInfoPtr_ProcessHandEnd_Private_IEnumerator_Character_0;

	// Token: 0x040005E3 RID: 1507
	private static readonly IntPtr NativeMethodInfoPtr_ProcessUnitTurnEnd_Private_IEnumerator_0;

	// Token: 0x040005E4 RID: 1508
	private static readonly IntPtr NativeMethodInfoPtr_CardCountDown_Private_Static_IEnumerator_Entity_0;

	// Token: 0x040005E5 RID: 1509
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040005E6 RID: 1510
	private static readonly IntPtr NativeMethodInfoPtr__get_playerMinibossCount_b__8_0_Private_Boolean_Entity_0;

	// Token: 0x040005E7 RID: 1511
	private static readonly IntPtr NativeMethodInfoPtr__get_enemyMinibossCount_b__10_0_Private_Boolean_Entity_0;

	// Token: 0x02000550 RID: 1360
	public enum Phase
	{
		// Token: 0x04004211 RID: 16913
		None,
		// Token: 0x04004212 RID: 16914
		Init,
		// Token: 0x04004213 RID: 16915
		Play,
		// Token: 0x04004214 RID: 16916
		Battle,
		// Token: 0x04004215 RID: 16917
		End,
		// Token: 0x04004216 RID: 16918
		LastStand
	}

	// Token: 0x02000551 RID: 1361
	[ObfuscatedName("Battle+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x0600651D RID: 25885 RVA: 0x00196A78 File Offset: 0x00194C78
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<Battle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr);
			Battle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, "<>9");
			Battle.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, "<>9__20_0");
			Battle.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, "<>9__22_0");
			Battle.__c.NativeFieldInfoPtr___9__50_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, "<>9__50_0");
			Battle.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, "<>9__62_0");
			Battle.__c.NativeFieldInfoPtr___9__66_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, "<>9__66_0");
			Battle.__c.NativeFieldInfoPtr___9__74_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, "<>9__74_0");
			Battle.__c.NativeFieldInfoPtr___9__74_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, "<>9__74_1");
			Battle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, 100664999);
			Battle.__c.NativeMethodInfoPtr__get_allRows_b__20_0_Internal_IEnumerable_1_CardContainer_List_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, 100665000);
			Battle.__c.NativeMethodInfoPtr__get_allSlots_b__22_0_Internal_IEnumerable_1_CardSlot_CardSlotLane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, 100665001);
			Battle.__c.NativeMethodInfoPtr__GetSlots_b__50_0_Internal_IEnumerable_1_CardContainer_List_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, 100665002);
			Battle.__c.NativeMethodInfoPtr__WaitForDeckpack_b__62_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, 100665003);
			Battle.__c.NativeMethodInfoPtr__CrownCardsInContainer_b__66_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, 100665004);
			Battle.__c.NativeMethodInfoPtr__ProcessUnits_b__74_0_Internal_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, 100665005);
			Battle.__c.NativeMethodInfoPtr__ProcessUnits_b__74_1_Internal_Il2CppReferenceArray_1_CardContainer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr, 100665006);
		}

		// Token: 0x0600651E RID: 25886 RVA: 0x00196BE4 File Offset: 0x00194DE4
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600651F RID: 25887 RVA: 0x00196C20 File Offset: 0x00194E20
		[CallerCount(0)]
		public unsafe IEnumerable<CardContainer> _get_allRows_b__20_0(List<CardContainer> a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c.NativeMethodInfoPtr__get_allRows_b__20_0_Internal_IEnumerable_1_CardContainer_List_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CardContainer>>(intPtr3) : null;
		}

		// Token: 0x06006520 RID: 25888 RVA: 0x00196C70 File Offset: 0x00194E70
		[CallerCount(0)]
		public unsafe IEnumerable<CardSlot> _get_allSlots_b__22_0(CardSlotLane a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c.NativeMethodInfoPtr__get_allSlots_b__22_0_Internal_IEnumerable_1_CardSlot_CardSlotLane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CardSlot>>(intPtr3) : null;
		}

		// Token: 0x06006521 RID: 25889 RVA: 0x00196CC0 File Offset: 0x00194EC0
		[CallerCount(0)]
		public unsafe IEnumerable<CardContainer> _GetSlots_b__50_0(List<CardContainer> a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c.NativeMethodInfoPtr__GetSlots_b__50_0_Internal_IEnumerable_1_CardContainer_List_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<CardContainer>>(intPtr3) : null;
		}

		// Token: 0x06006522 RID: 25890 RVA: 0x00196D10 File Offset: 0x00194F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28967, XrefRangeEnd = 28968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WaitForDeckpack_b__62_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c.NativeMethodInfoPtr__WaitForDeckpack_b__62_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006523 RID: 25891 RVA: 0x00196D4C File Offset: 0x00194F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28968, XrefRangeEnd = 28970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CrownCardsInContainer_b__66_0(Entity a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c.NativeMethodInfoPtr__CrownCardsInContainer_b__66_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006524 RID: 25892 RVA: 0x00196D9C File Offset: 0x00194F9C
		[CallerCount(0)]
		public unsafe Entity _ProcessUnits_b__74_0(Entity e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c.NativeMethodInfoPtr__ProcessUnits_b__74_0_Internal_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06006525 RID: 25893 RVA: 0x00196DEC File Offset: 0x00194FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28970, XrefRangeEnd = 28974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<CardContainer> _ProcessUnits_b__74_1(Entity e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c.NativeMethodInfoPtr__ProcessUnits_b__74_1_Internal_Il2CppReferenceArray_1_CardContainer_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardContainer>>(intPtr3) : null;
		}

		// Token: 0x06006526 RID: 25894 RVA: 0x00031B85 File Offset: 0x0002FD85
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x06006527 RID: 25895 RVA: 0x00196E3C File Offset: 0x0019503C
		// (set) Token: 0x06006528 RID: 25896 RVA: 0x00031B8E File Offset: 0x0002FD8E
		public unsafe static Battle.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Battle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Battle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x06006529 RID: 25897 RVA: 0x00196E64 File Offset: 0x00195064
		// (set) Token: 0x0600652A RID: 25898 RVA: 0x00031BA0 File Offset: 0x0002FDA0
		public unsafe static Func<List<CardContainer>, IEnumerable<CardContainer>> __9__20_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Battle.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<CardContainer>, IEnumerable<CardContainer>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Battle.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x0600652B RID: 25899 RVA: 0x00196E8C File Offset: 0x0019508C
		// (set) Token: 0x0600652C RID: 25900 RVA: 0x00031BB2 File Offset: 0x0002FDB2
		public unsafe static Func<CardSlotLane, IEnumerable<CardSlot>> __9__22_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Battle.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardSlotLane, IEnumerable<CardSlot>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Battle.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x0600652D RID: 25901 RVA: 0x00196EB4 File Offset: 0x001950B4
		// (set) Token: 0x0600652E RID: 25902 RVA: 0x00031BC4 File Offset: 0x0002FDC4
		public unsafe static Func<List<CardContainer>, IEnumerable<CardContainer>> __9__50_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Battle.__c.NativeFieldInfoPtr___9__50_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<CardContainer>, IEnumerable<CardContainer>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Battle.__c.NativeFieldInfoPtr___9__50_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x0600652F RID: 25903 RVA: 0x00196EDC File Offset: 0x001950DC
		// (set) Token: 0x06006530 RID: 25904 RVA: 0x00031BD6 File Offset: 0x0002FDD6
		public unsafe static Func<bool> __9__62_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Battle.__c.NativeFieldInfoPtr___9__62_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Battle.__c.NativeFieldInfoPtr___9__62_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06006531 RID: 25905 RVA: 0x00196F04 File Offset: 0x00195104
		// (set) Token: 0x06006532 RID: 25906 RVA: 0x00031BE8 File Offset: 0x0002FDE8
		public unsafe static Func<Entity, bool> __9__66_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Battle.__c.NativeFieldInfoPtr___9__66_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Battle.__c.NativeFieldInfoPtr___9__66_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06006533 RID: 25907 RVA: 0x00196F2C File Offset: 0x0019512C
		// (set) Token: 0x06006534 RID: 25908 RVA: 0x00031BFA File Offset: 0x0002FDFA
		public unsafe static Func<Entity, Entity> __9__74_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Battle.__c.NativeFieldInfoPtr___9__74_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, Entity>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Battle.__c.NativeFieldInfoPtr___9__74_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06006535 RID: 25909 RVA: 0x00196F54 File Offset: 0x00195154
		// (set) Token: 0x06006536 RID: 25910 RVA: 0x00031C0C File Offset: 0x0002FE0C
		public unsafe static Func<Entity, Il2CppReferenceArray<CardContainer>> __9__74_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Battle.__c.NativeFieldInfoPtr___9__74_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, Il2CppReferenceArray<CardContainer>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Battle.__c.NativeFieldInfoPtr___9__74_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004217 RID: 16919
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04004218 RID: 16920
		private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

		// Token: 0x04004219 RID: 16921
		private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

		// Token: 0x0400421A RID: 16922
		private static readonly IntPtr NativeFieldInfoPtr___9__50_0;

		// Token: 0x0400421B RID: 16923
		private static readonly IntPtr NativeFieldInfoPtr___9__62_0;

		// Token: 0x0400421C RID: 16924
		private static readonly IntPtr NativeFieldInfoPtr___9__66_0;

		// Token: 0x0400421D RID: 16925
		private static readonly IntPtr NativeFieldInfoPtr___9__74_0;

		// Token: 0x0400421E RID: 16926
		private static readonly IntPtr NativeFieldInfoPtr___9__74_1;

		// Token: 0x0400421F RID: 16927
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004220 RID: 16928
		private static readonly IntPtr NativeMethodInfoPtr__get_allRows_b__20_0_Internal_IEnumerable_1_CardContainer_List_1_CardContainer_0;

		// Token: 0x04004221 RID: 16929
		private static readonly IntPtr NativeMethodInfoPtr__get_allSlots_b__22_0_Internal_IEnumerable_1_CardSlot_CardSlotLane_0;

		// Token: 0x04004222 RID: 16930
		private static readonly IntPtr NativeMethodInfoPtr__GetSlots_b__50_0_Internal_IEnumerable_1_CardContainer_List_1_CardContainer_0;

		// Token: 0x04004223 RID: 16931
		private static readonly IntPtr NativeMethodInfoPtr__WaitForDeckpack_b__62_0_Internal_Boolean_0;

		// Token: 0x04004224 RID: 16932
		private static readonly IntPtr NativeMethodInfoPtr__CrownCardsInContainer_b__66_0_Internal_Boolean_Entity_0;

		// Token: 0x04004225 RID: 16933
		private static readonly IntPtr NativeMethodInfoPtr__ProcessUnits_b__74_0_Internal_Entity_Entity_0;

		// Token: 0x04004226 RID: 16934
		private static readonly IntPtr NativeMethodInfoPtr__ProcessUnits_b__74_1_Internal_Il2CppReferenceArray_1_CardContainer_Entity_0;
	}

	// Token: 0x02000552 RID: 1362
	[ObfuscatedName("Battle+<Run>d__59")]
	public sealed class _Run_d__59 : Il2CppSystem.Object
	{
		// Token: 0x06006537 RID: 25911 RVA: 0x00196F7C File Offset: 0x0019517C
		// Note: this type is marked as 'beforefieldinit'.
		static _Run_d__59()
		{
			Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<Run>d__59");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr);
			Battle._Run_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, "<>1__state");
			Battle._Run_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, "<>2__current");
			Battle._Run_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, "<>4__this");
			Battle._Run_d__59.NativeFieldInfoPtr__node_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, "<node>5__2");
			Battle._Run_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, 100665007);
			Battle._Run_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, 100665008);
			Battle._Run_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, 100665009);
			Battle._Run_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, 100665010);
			Battle._Run_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, 100665011);
			Battle._Run_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr, 100665012);
		}

		// Token: 0x06006538 RID: 25912 RVA: 0x00197070 File Offset: 0x00195270
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Run_d__59(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._Run_d__59>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._Run_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006539 RID: 25913 RVA: 0x001970B8 File Offset: 0x001952B8
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._Run_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x001970EC File Offset: 0x001952EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28974, XrefRangeEnd = 29198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._Run_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x0600653B RID: 25915 RVA: 0x00197128 File Offset: 0x00195328
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._Run_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x00197168 File Offset: 0x00195368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29198, XrefRangeEnd = 29204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._Run_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x0600653D RID: 25917 RVA: 0x0019719C File Offset: 0x0019539C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._Run_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x00031C1E File Offset: 0x0002FE1E
		public _Run_d__59(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x0600653F RID: 25919 RVA: 0x001971DC File Offset: 0x001953DC
		// (set) Token: 0x06006540 RID: 25920 RVA: 0x00031C27 File Offset: 0x0002FE27
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._Run_d__59.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._Run_d__59.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06006541 RID: 25921 RVA: 0x00197204 File Offset: 0x00195404
		// (set) Token: 0x06006542 RID: 25922 RVA: 0x00031C42 File Offset: 0x0002FE42
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._Run_d__59.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._Run_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06006543 RID: 25923 RVA: 0x00197234 File Offset: 0x00195434
		// (set) Token: 0x06006544 RID: 25924 RVA: 0x00031C61 File Offset: 0x0002FE61
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._Run_d__59.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._Run_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06006545 RID: 25925 RVA: 0x00197264 File Offset: 0x00195464
		// (set) Token: 0x06006546 RID: 25926 RVA: 0x00031C80 File Offset: 0x0002FE80
		public unsafe CampaignNode _node_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._Run_d__59.NativeFieldInfoPtr__node_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CampaignNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._Run_d__59.NativeFieldInfoPtr__node_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004227 RID: 16935
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004228 RID: 16936
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004229 RID: 16937
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400422A RID: 16938
		private static readonly IntPtr NativeFieldInfoPtr__node_5__2;

		// Token: 0x0400422B RID: 16939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400422C RID: 16940
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400422D RID: 16941
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400422E RID: 16942
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400422F RID: 16943
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004230 RID: 16944
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000553 RID: 1363
	[ObfuscatedName("Battle+<BattleLoop>d__60")]
	public sealed class _BattleLoop_d__60 : Il2CppSystem.Object
	{
		// Token: 0x06006547 RID: 25927 RVA: 0x00197294 File Offset: 0x00195494
		// Note: this type is marked as 'beforefieldinit'.
		static _BattleLoop_d__60()
		{
			Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<BattleLoop>d__60");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr);
			Battle._BattleLoop_d__60.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, "<>1__state");
			Battle._BattleLoop_d__60.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, "<>2__current");
			Battle._BattleLoop_d__60.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, "<>4__this");
			Battle._BattleLoop_d__60.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, "node");
			Battle._BattleLoop_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, 100665013);
			Battle._BattleLoop_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, 100665014);
			Battle._BattleLoop_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, 100665015);
			Battle._BattleLoop_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, 100665016);
			Battle._BattleLoop_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, 100665017);
			Battle._BattleLoop_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr, 100665018);
		}

		// Token: 0x06006548 RID: 25928 RVA: 0x00197388 File Offset: 0x00195588
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _BattleLoop_d__60(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._BattleLoop_d__60>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._BattleLoop_d__60.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006549 RID: 25929 RVA: 0x001973D0 File Offset: 0x001955D0
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._BattleLoop_d__60.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600654A RID: 25930 RVA: 0x00197404 File Offset: 0x00195604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29204, XrefRangeEnd = 29319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._BattleLoop_d__60.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x0600654B RID: 25931 RVA: 0x00197440 File Offset: 0x00195640
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._BattleLoop_d__60.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600654C RID: 25932 RVA: 0x00197480 File Offset: 0x00195680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29319, XrefRangeEnd = 29325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._BattleLoop_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x0600654D RID: 25933 RVA: 0x001974B4 File Offset: 0x001956B4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._BattleLoop_d__60.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600654E RID: 25934 RVA: 0x00031C9F File Offset: 0x0002FE9F
		public _BattleLoop_d__60(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x0600654F RID: 25935 RVA: 0x001974F4 File Offset: 0x001956F4
		// (set) Token: 0x06006550 RID: 25936 RVA: 0x00031CA8 File Offset: 0x0002FEA8
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._BattleLoop_d__60.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._BattleLoop_d__60.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x06006551 RID: 25937 RVA: 0x0019751C File Offset: 0x0019571C
		// (set) Token: 0x06006552 RID: 25938 RVA: 0x00031CC3 File Offset: 0x0002FEC3
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._BattleLoop_d__60.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._BattleLoop_d__60.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x06006553 RID: 25939 RVA: 0x0019754C File Offset: 0x0019574C
		// (set) Token: 0x06006554 RID: 25940 RVA: 0x00031CE2 File Offset: 0x0002FEE2
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._BattleLoop_d__60.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._BattleLoop_d__60.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x06006555 RID: 25941 RVA: 0x0019757C File Offset: 0x0019577C
		// (set) Token: 0x06006556 RID: 25942 RVA: 0x00031D01 File Offset: 0x0002FF01
		public unsafe CampaignNode node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._BattleLoop_d__60.NativeFieldInfoPtr_node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CampaignNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._BattleLoop_d__60.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004231 RID: 16945
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004232 RID: 16946
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004233 RID: 16947
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004234 RID: 16948
		private static readonly IntPtr NativeFieldInfoPtr_node;

		// Token: 0x04004235 RID: 16949
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004236 RID: 16950
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004237 RID: 16951
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004238 RID: 16952
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004239 RID: 16953
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400423A RID: 16954
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000554 RID: 1364
	[ObfuscatedName("Battle+<WaitForDeckpack>d__62")]
	public sealed class _WaitForDeckpack_d__62 : Il2CppSystem.Object
	{
		// Token: 0x06006557 RID: 25943 RVA: 0x001975AC File Offset: 0x001957AC
		// Note: this type is marked as 'beforefieldinit'.
		static _WaitForDeckpack_d__62()
		{
			Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<WaitForDeckpack>d__62");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr);
			Battle._WaitForDeckpack_d__62.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr, "<>1__state");
			Battle._WaitForDeckpack_d__62.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr, "<>2__current");
			Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr, 100665019);
			Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr, 100665020);
			Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr, 100665021);
			Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr, 100665022);
			Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr, 100665023);
			Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr, 100665024);
		}

		// Token: 0x06006558 RID: 25944 RVA: 0x00197678 File Offset: 0x00195878
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _WaitForDeckpack_d__62(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._WaitForDeckpack_d__62>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006559 RID: 25945 RVA: 0x001976C0 File Offset: 0x001958C0
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600655A RID: 25946 RVA: 0x001976F4 File Offset: 0x001958F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29325, XrefRangeEnd = 29330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x0600655B RID: 25947 RVA: 0x00197730 File Offset: 0x00195930
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600655C RID: 25948 RVA: 0x00197770 File Offset: 0x00195970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29330, XrefRangeEnd = 29336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x0600655D RID: 25949 RVA: 0x001977A4 File Offset: 0x001959A4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForDeckpack_d__62.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600655E RID: 25950 RVA: 0x00031D20 File Offset: 0x0002FF20
		public _WaitForDeckpack_d__62(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x0600655F RID: 25951 RVA: 0x001977E4 File Offset: 0x001959E4
		// (set) Token: 0x06006560 RID: 25952 RVA: 0x00031D29 File Offset: 0x0002FF29
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForDeckpack_d__62.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForDeckpack_d__62.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x06006561 RID: 25953 RVA: 0x0019780C File Offset: 0x00195A0C
		// (set) Token: 0x06006562 RID: 25954 RVA: 0x00031D44 File Offset: 0x0002FF44
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForDeckpack_d__62.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForDeckpack_d__62.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400423B RID: 16955
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400423C RID: 16956
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400423D RID: 16957
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400423E RID: 16958
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400423F RID: 16959
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004240 RID: 16960
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004241 RID: 16961
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004242 RID: 16962
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000555 RID: 1365
	[ObfuscatedName("Battle+<WaitForTurnEnd>d__63")]
	public sealed class _WaitForTurnEnd_d__63 : Il2CppSystem.Object
	{
		// Token: 0x06006563 RID: 25955 RVA: 0x0019783C File Offset: 0x00195A3C
		// Note: this type is marked as 'beforefieldinit'.
		static _WaitForTurnEnd_d__63()
		{
			Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<WaitForTurnEnd>d__63");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr);
			Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, "<>1__state");
			Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, "<>2__current");
			Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, "character");
			Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, "<>4__this");
			Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, "cardController");
			Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, 100665025);
			Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, 100665026);
			Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, 100665027);
			Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, 100665028);
			Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, 100665029);
			Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr, 100665030);
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x00197944 File Offset: 0x00195B44
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _WaitForTurnEnd_d__63(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._WaitForTurnEnd_d__63>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x0019798C File Offset: 0x00195B8C
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x001979C0 File Offset: 0x00195BC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29336, XrefRangeEnd = 29340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x06006567 RID: 25959 RVA: 0x001979FC File Offset: 0x00195BFC
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x00197A3C File Offset: 0x00195C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29340, XrefRangeEnd = 29346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x06006569 RID: 25961 RVA: 0x00197A70 File Offset: 0x00195C70
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForTurnEnd_d__63.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00031D63 File Offset: 0x0002FF63
		public _WaitForTurnEnd_d__63(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x0600656B RID: 25963 RVA: 0x00197AB0 File Offset: 0x00195CB0
		// (set) Token: 0x0600656C RID: 25964 RVA: 0x00031D6C File Offset: 0x0002FF6C
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x0600656D RID: 25965 RVA: 0x00197AD8 File Offset: 0x00195CD8
		// (set) Token: 0x0600656E RID: 25966 RVA: 0x00031D87 File Offset: 0x0002FF87
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x0600656F RID: 25967 RVA: 0x00197B08 File Offset: 0x00195D08
		// (set) Token: 0x06006570 RID: 25968 RVA: 0x00031DA6 File Offset: 0x0002FFA6
		public unsafe Character character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr_character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x06006571 RID: 25969 RVA: 0x00197B38 File Offset: 0x00195D38
		// (set) Token: 0x06006572 RID: 25970 RVA: 0x00031DC5 File Offset: 0x0002FFC5
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x00197B68 File Offset: 0x00195D68
		// (set) Token: 0x06006574 RID: 25972 RVA: 0x00031DE4 File Offset: 0x0002FFE4
		public unsafe CardController cardController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr_cardController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForTurnEnd_d__63.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004243 RID: 16963
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004244 RID: 16964
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004245 RID: 16965
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x04004246 RID: 16966
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004247 RID: 16967
		private static readonly IntPtr NativeFieldInfoPtr_cardController;

		// Token: 0x04004248 RID: 16968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004249 RID: 16969
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400424A RID: 16970
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400424B RID: 16971
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400424C RID: 16972
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400424D RID: 16973
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000556 RID: 1366
	[ObfuscatedName("Battle+<DrawChampions>d__64")]
	public sealed class _DrawChampions_d__64 : Il2CppSystem.Object
	{
		// Token: 0x06006575 RID: 25973 RVA: 0x00197B98 File Offset: 0x00195D98
		// Note: this type is marked as 'beforefieldinit'.
		static _DrawChampions_d__64()
		{
			Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<DrawChampions>d__64");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr);
			Battle._DrawChampions_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, "<>1__state");
			Battle._DrawChampions_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, "<>2__current");
			Battle._DrawChampions_d__64.NativeFieldInfoPtr_fromContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, "fromContainer");
			Battle._DrawChampions_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, "<>4__this");
			Battle._DrawChampions_d__64.NativeFieldInfoPtr_toContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, "toContainer");
			Battle._DrawChampions_d__64.NativeFieldInfoPtr__pauseBetween_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, "<pauseBetween>5__2");
			Battle._DrawChampions_d__64.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, "<i>5__3");
			Battle._DrawChampions_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, 100665031);
			Battle._DrawChampions_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, 100665032);
			Battle._DrawChampions_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, 100665033);
			Battle._DrawChampions_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, 100665034);
			Battle._DrawChampions_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, 100665035);
			Battle._DrawChampions_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr, 100665036);
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x00197CC8 File Offset: 0x00195EC8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _DrawChampions_d__64(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._DrawChampions_d__64>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._DrawChampions_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x00197D10 File Offset: 0x00195F10
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._DrawChampions_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x00197D44 File Offset: 0x00195F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29346, XrefRangeEnd = 29365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._DrawChampions_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x00197D80 File Offset: 0x00195F80
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._DrawChampions_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x00197DC0 File Offset: 0x00195FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29365, XrefRangeEnd = 29371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._DrawChampions_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x0600657B RID: 25979 RVA: 0x00197DF4 File Offset: 0x00195FF4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._DrawChampions_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x00031E03 File Offset: 0x00030003
		public _DrawChampions_d__64(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x0600657D RID: 25981 RVA: 0x00197E34 File Offset: 0x00196034
		// (set) Token: 0x0600657E RID: 25982 RVA: 0x00031E0C File Offset: 0x0003000C
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x00197E5C File Offset: 0x0019605C
		// (set) Token: 0x06006580 RID: 25984 RVA: 0x00031E27 File Offset: 0x00030027
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x06006581 RID: 25985 RVA: 0x00197E8C File Offset: 0x0019608C
		// (set) Token: 0x06006582 RID: 25986 RVA: 0x00031E46 File Offset: 0x00030046
		public unsafe CardContainer fromContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr_fromContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr_fromContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x06006583 RID: 25987 RVA: 0x00197EBC File Offset: 0x001960BC
		// (set) Token: 0x06006584 RID: 25988 RVA: 0x00031E65 File Offset: 0x00030065
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x06006585 RID: 25989 RVA: 0x00197EEC File Offset: 0x001960EC
		// (set) Token: 0x06006586 RID: 25990 RVA: 0x00031E84 File Offset: 0x00030084
		public unsafe CardContainer toContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr_toContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr_toContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x06006587 RID: 25991 RVA: 0x00197F1C File Offset: 0x0019611C
		// (set) Token: 0x06006588 RID: 25992 RVA: 0x00031EA3 File Offset: 0x000300A3
		public unsafe float _pauseBetween_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr__pauseBetween_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr__pauseBetween_5__2)) = value;
			}
		}

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x00197F44 File Offset: 0x00196144
		// (set) Token: 0x0600658A RID: 25994 RVA: 0x00031EBE File Offset: 0x000300BE
		public unsafe int _i_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr__i_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._DrawChampions_d__64.NativeFieldInfoPtr__i_5__3)) = value;
			}
		}

		// Token: 0x0400424E RID: 16974
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400424F RID: 16975
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004250 RID: 16976
		private static readonly IntPtr NativeFieldInfoPtr_fromContainer;

		// Token: 0x04004251 RID: 16977
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004252 RID: 16978
		private static readonly IntPtr NativeFieldInfoPtr_toContainer;

		// Token: 0x04004253 RID: 16979
		private static readonly IntPtr NativeFieldInfoPtr__pauseBetween_5__2;

		// Token: 0x04004254 RID: 16980
		private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

		// Token: 0x04004255 RID: 16981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004256 RID: 16982
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004257 RID: 16983
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004258 RID: 16984
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004259 RID: 16985
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400425A RID: 16986
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000557 RID: 1367
	[ObfuscatedName("Battle+<WaitForChampionsToDeploy>d__65")]
	public sealed class _WaitForChampionsToDeploy_d__65 : Il2CppSystem.Object
	{
		// Token: 0x0600658B RID: 25995 RVA: 0x00197F6C File Offset: 0x0019616C
		// Note: this type is marked as 'beforefieldinit'.
		static _WaitForChampionsToDeploy_d__65()
		{
			Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<WaitForChampionsToDeploy>d__65");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr);
			Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, "<>1__state");
			Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, "<>2__current");
			Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_handContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, "handContainer");
			Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, "cardController");
			Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, "character");
			Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, "<>4__this");
			Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, 100665037);
			Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, 100665038);
			Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, 100665039);
			Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, 100665040);
			Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, 100665041);
			Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr, 100665042);
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x00198088 File Offset: 0x00196288
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _WaitForChampionsToDeploy_d__65(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._WaitForChampionsToDeploy_d__65>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x001980D0 File Offset: 0x001962D0
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x00198104 File Offset: 0x00196304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29371, XrefRangeEnd = 29387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x0600658F RID: 25999 RVA: 0x00198140 File Offset: 0x00196340
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006590 RID: 26000 RVA: 0x00198180 File Offset: 0x00196380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29387, XrefRangeEnd = 29393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06006591 RID: 26001 RVA: 0x001981B4 File Offset: 0x001963B4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._WaitForChampionsToDeploy_d__65.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006592 RID: 26002 RVA: 0x00031ED9 File Offset: 0x000300D9
		public _WaitForChampionsToDeploy_d__65(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x06006593 RID: 26003 RVA: 0x001981F4 File Offset: 0x001963F4
		// (set) Token: 0x06006594 RID: 26004 RVA: 0x00031EE2 File Offset: 0x000300E2
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x06006595 RID: 26005 RVA: 0x0019821C File Offset: 0x0019641C
		// (set) Token: 0x06006596 RID: 26006 RVA: 0x00031EFD File Offset: 0x000300FD
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x06006597 RID: 26007 RVA: 0x0019824C File Offset: 0x0019644C
		// (set) Token: 0x06006598 RID: 26008 RVA: 0x00031F1C File Offset: 0x0003011C
		public unsafe CardContainer handContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_handContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_handContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x06006599 RID: 26009 RVA: 0x0019827C File Offset: 0x0019647C
		// (set) Token: 0x0600659A RID: 26010 RVA: 0x00031F3B File Offset: 0x0003013B
		public unsafe CardController cardController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_cardController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x0600659B RID: 26011 RVA: 0x001982AC File Offset: 0x001964AC
		// (set) Token: 0x0600659C RID: 26012 RVA: 0x00031F5A File Offset: 0x0003015A
		public unsafe Character character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x0600659D RID: 26013 RVA: 0x001982DC File Offset: 0x001964DC
		// (set) Token: 0x0600659E RID: 26014 RVA: 0x00031F79 File Offset: 0x00030179
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._WaitForChampionsToDeploy_d__65.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400425B RID: 16987
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400425C RID: 16988
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400425D RID: 16989
		private static readonly IntPtr NativeFieldInfoPtr_handContainer;

		// Token: 0x0400425E RID: 16990
		private static readonly IntPtr NativeFieldInfoPtr_cardController;

		// Token: 0x0400425F RID: 16991
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x04004260 RID: 16992
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004261 RID: 16993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004262 RID: 16994
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004263 RID: 16995
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004264 RID: 16996
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004265 RID: 16997
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004266 RID: 16998
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000558 RID: 1368
	[ObfuscatedName("Battle+<UpdateBoard>d__67")]
	public sealed class _UpdateBoard_d__67 : Il2CppSystem.Object
	{
		// Token: 0x0600659F RID: 26015 RVA: 0x0019830C File Offset: 0x0019650C
		// Note: this type is marked as 'beforefieldinit'.
		static _UpdateBoard_d__67()
		{
			Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<UpdateBoard>d__67");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr);
			Battle._UpdateBoard_d__67.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, "<>1__state");
			Battle._UpdateBoard_d__67.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, "<>2__current");
			Battle._UpdateBoard_d__67.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, "<>4__this");
			Battle._UpdateBoard_d__67.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, "character");
			Battle._UpdateBoard_d__67.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, 100665043);
			Battle._UpdateBoard_d__67.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, 100665044);
			Battle._UpdateBoard_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, 100665045);
			Battle._UpdateBoard_d__67.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, 100665046);
			Battle._UpdateBoard_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, 100665047);
			Battle._UpdateBoard_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr, 100665048);
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x00198400 File Offset: 0x00196600
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _UpdateBoard_d__67(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._UpdateBoard_d__67>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateBoard_d__67.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x00198448 File Offset: 0x00196648
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateBoard_d__67.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065A2 RID: 26018 RVA: 0x0019847C File Offset: 0x0019667C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29393, XrefRangeEnd = 29411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateBoard_d__67.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x060065A3 RID: 26019 RVA: 0x001984B8 File Offset: 0x001966B8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateBoard_d__67.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065A4 RID: 26020 RVA: 0x001984F8 File Offset: 0x001966F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29411, XrefRangeEnd = 29417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateBoard_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x060065A5 RID: 26021 RVA: 0x0019852C File Offset: 0x0019672C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateBoard_d__67.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065A6 RID: 26022 RVA: 0x00031F98 File Offset: 0x00030198
		public _UpdateBoard_d__67(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x060065A7 RID: 26023 RVA: 0x0019856C File Offset: 0x0019676C
		// (set) Token: 0x060065A8 RID: 26024 RVA: 0x00031FA1 File Offset: 0x000301A1
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateBoard_d__67.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateBoard_d__67.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x060065A9 RID: 26025 RVA: 0x00198594 File Offset: 0x00196794
		// (set) Token: 0x060065AA RID: 26026 RVA: 0x00031FBC File Offset: 0x000301BC
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateBoard_d__67.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateBoard_d__67.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x060065AB RID: 26027 RVA: 0x001985C4 File Offset: 0x001967C4
		// (set) Token: 0x060065AC RID: 26028 RVA: 0x00031FDB File Offset: 0x000301DB
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateBoard_d__67.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateBoard_d__67.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x060065AD RID: 26029 RVA: 0x001985F4 File Offset: 0x001967F4
		// (set) Token: 0x060065AE RID: 26030 RVA: 0x00031FFA File Offset: 0x000301FA
		public unsafe Character character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateBoard_d__67.NativeFieldInfoPtr_character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateBoard_d__67.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004267 RID: 16999
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004268 RID: 17000
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004269 RID: 17001
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400426A RID: 17002
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x0400426B RID: 17003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400426C RID: 17004
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400426D RID: 17005
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400426E RID: 17006
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400426F RID: 17007
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004270 RID: 17008
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000559 RID: 1369
	[ObfuscatedName("Battle+<UpdateContainer>d__71")]
	public sealed class _UpdateContainer_d__71 : Il2CppSystem.Object
	{
		// Token: 0x060065AF RID: 26031 RVA: 0x00198624 File Offset: 0x00196824
		// Note: this type is marked as 'beforefieldinit'.
		static _UpdateContainer_d__71()
		{
			Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<UpdateContainer>d__71");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr);
			Battle._UpdateContainer_d__71.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, "<>1__state");
			Battle._UpdateContainer_d__71.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, "<>2__current");
			Battle._UpdateContainer_d__71.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, "container");
			Battle._UpdateContainer_d__71.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, 100665049);
			Battle._UpdateContainer_d__71.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, 100665050);
			Battle._UpdateContainer_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, 100665051);
			Battle._UpdateContainer_d__71.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, 100665052);
			Battle._UpdateContainer_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, 100665053);
			Battle._UpdateContainer_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr, 100665054);
		}

		// Token: 0x060065B0 RID: 26032 RVA: 0x00198704 File Offset: 0x00196904
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _UpdateContainer_d__71(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._UpdateContainer_d__71>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateContainer_d__71.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B1 RID: 26033 RVA: 0x0019874C File Offset: 0x0019694C
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateContainer_d__71.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065B2 RID: 26034 RVA: 0x00198780 File Offset: 0x00196980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29417, XrefRangeEnd = 29419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateContainer_d__71.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x060065B3 RID: 26035 RVA: 0x001987BC File Offset: 0x001969BC
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateContainer_d__71.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065B4 RID: 26036 RVA: 0x001987FC File Offset: 0x001969FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29419, XrefRangeEnd = 29425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateContainer_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x060065B5 RID: 26037 RVA: 0x00198830 File Offset: 0x00196A30
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._UpdateContainer_d__71.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065B6 RID: 26038 RVA: 0x00032019 File Offset: 0x00030219
		public _UpdateContainer_d__71(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x060065B7 RID: 26039 RVA: 0x00198870 File Offset: 0x00196A70
		// (set) Token: 0x060065B8 RID: 26040 RVA: 0x00032022 File Offset: 0x00030222
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateContainer_d__71.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateContainer_d__71.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x060065B9 RID: 26041 RVA: 0x00198898 File Offset: 0x00196A98
		// (set) Token: 0x060065BA RID: 26042 RVA: 0x0003203D File Offset: 0x0003023D
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateContainer_d__71.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateContainer_d__71.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x060065BB RID: 26043 RVA: 0x001988C8 File Offset: 0x00196AC8
		// (set) Token: 0x060065BC RID: 26044 RVA: 0x0003205C File Offset: 0x0003025C
		public unsafe CardContainer container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateContainer_d__71.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._UpdateContainer_d__71.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004271 RID: 17009
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004272 RID: 17010
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004273 RID: 17011
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04004274 RID: 17012
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004275 RID: 17013
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004276 RID: 17014
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004277 RID: 17015
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004278 RID: 17016
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004279 RID: 17017
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200055A RID: 1370
	[ObfuscatedName("Battle+<CheckUnitsTakeTurns>d__72")]
	public sealed class _CheckUnitsTakeTurns_d__72 : Il2CppSystem.Object
	{
		// Token: 0x060065BD RID: 26045 RVA: 0x001988F8 File Offset: 0x00196AF8
		// Note: this type is marked as 'beforefieldinit'.
		static _CheckUnitsTakeTurns_d__72()
		{
			Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<CheckUnitsTakeTurns>d__72");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr);
			Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, "<>1__state");
			Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, "<>2__current");
			Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, "<>4__this");
			Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, 100665055);
			Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, 100665056);
			Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, 100665057);
			Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, 100665058);
			Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, 100665059);
			Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr, 100665060);
		}

		// Token: 0x060065BE RID: 26046 RVA: 0x001989D8 File Offset: 0x00196BD8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CheckUnitsTakeTurns_d__72(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__72>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x00198A20 File Offset: 0x00196C20
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x00198A54 File Offset: 0x00196C54
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x060065C1 RID: 26049 RVA: 0x00198A90 File Offset: 0x00196C90
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065C2 RID: 26050 RVA: 0x00198AD0 File Offset: 0x00196CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29425, XrefRangeEnd = 29431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x060065C3 RID: 26051 RVA: 0x00198B04 File Offset: 0x00196D04
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__72.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x0003207B File Offset: 0x0003027B
		public _CheckUnitsTakeTurns_d__72(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x060065C5 RID: 26053 RVA: 0x00198B44 File Offset: 0x00196D44
		// (set) Token: 0x060065C6 RID: 26054 RVA: 0x00032084 File Offset: 0x00030284
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x060065C7 RID: 26055 RVA: 0x00198B6C File Offset: 0x00196D6C
		// (set) Token: 0x060065C8 RID: 26056 RVA: 0x0003209F File Offset: 0x0003029F
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x060065C9 RID: 26057 RVA: 0x00198B9C File Offset: 0x00196D9C
		// (set) Token: 0x060065CA RID: 26058 RVA: 0x000320BE File Offset: 0x000302BE
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__72.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400427A RID: 17018
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400427B RID: 17019
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400427C RID: 17020
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400427D RID: 17021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400427E RID: 17022
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400427F RID: 17023
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004280 RID: 17024
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004281 RID: 17025
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004282 RID: 17026
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200055B RID: 1371
	[ObfuscatedName("Battle+<CheckUnitsTakeTurns>d__73")]
	public sealed class _CheckUnitsTakeTurns_d__73 : Il2CppSystem.Object
	{
		// Token: 0x060065CB RID: 26059 RVA: 0x00198BCC File Offset: 0x00196DCC
		// Note: this type is marked as 'beforefieldinit'.
		static _CheckUnitsTakeTurns_d__73()
		{
			Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<CheckUnitsTakeTurns>d__73");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr);
			Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, "<>1__state");
			Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, "<>2__current");
			Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, "<>4__this");
			Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, "character");
			Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__pauseAfter_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, "<pauseAfter>5__2");
			Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, "<>7__wrap2");
			Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__unit_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, "<unit>5__4");
			Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__triggerAction_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, "<triggerAction>5__5");
			Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, 100665061);
			Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, 100665062);
			Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, 100665063);
			Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, 100665064);
			Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, 100665065);
			Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, 100665066);
			Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr, 100665067);
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x00198D24 File Offset: 0x00196F24
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CheckUnitsTakeTurns_d__73(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._CheckUnitsTakeTurns_d__73>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CD RID: 26061 RVA: 0x00198D6C File Offset: 0x00196F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29431, XrefRangeEnd = 29436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065CE RID: 26062 RVA: 0x00198DA0 File Offset: 0x00196FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29436, XrefRangeEnd = 29505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065CF RID: 26063 RVA: 0x00198DDC File Offset: 0x00196FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29505, XrefRangeEnd = 29508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x060065D0 RID: 26064 RVA: 0x00198E10 File Offset: 0x00197010
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065D1 RID: 26065 RVA: 0x00198E50 File Offset: 0x00197050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29508, XrefRangeEnd = 29514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x060065D2 RID: 26066 RVA: 0x00198E84 File Offset: 0x00197084
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CheckUnitsTakeTurns_d__73.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x000320DD File Offset: 0x000302DD
		public _CheckUnitsTakeTurns_d__73(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x060065D4 RID: 26068 RVA: 0x00198EC4 File Offset: 0x001970C4
		// (set) Token: 0x060065D5 RID: 26069 RVA: 0x000320E6 File Offset: 0x000302E6
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x060065D6 RID: 26070 RVA: 0x00198EEC File Offset: 0x001970EC
		// (set) Token: 0x060065D7 RID: 26071 RVA: 0x00032101 File Offset: 0x00030301
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x060065D8 RID: 26072 RVA: 0x00198F1C File Offset: 0x0019711C
		// (set) Token: 0x060065D9 RID: 26073 RVA: 0x00032120 File Offset: 0x00030320
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x060065DA RID: 26074 RVA: 0x00198F4C File Offset: 0x0019714C
		// (set) Token: 0x060065DB RID: 26075 RVA: 0x0003213F File Offset: 0x0003033F
		public unsafe Character character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr_character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x060065DC RID: 26076 RVA: 0x00198F7C File Offset: 0x0019717C
		// (set) Token: 0x060065DD RID: 26077 RVA: 0x0003215E File Offset: 0x0003035E
		public unsafe float _pauseAfter_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__pauseAfter_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__pauseAfter_5__2)) = value;
			}
		}

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x060065DE RID: 26078 RVA: 0x00198FA4 File Offset: 0x001971A4
		// (set) Token: 0x060065DF RID: 26079 RVA: 0x00032179 File Offset: 0x00030379
		public List<Entity>.Enumerator __7__wrap2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___7__wrap2);
				return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x060065E0 RID: 26080 RVA: 0x00198FD4 File Offset: 0x001971D4
		// (set) Token: 0x060065E1 RID: 26081 RVA: 0x000321A7 File Offset: 0x000303A7
		public unsafe Entity _unit_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__unit_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__unit_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x060065E2 RID: 26082 RVA: 0x00199004 File Offset: 0x00197204
		// (set) Token: 0x060065E3 RID: 26083 RVA: 0x000321C6 File Offset: 0x000303C6
		public unsafe ActionTriggerByCounter _triggerAction_5__5
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__triggerAction_5__5);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionTriggerByCounter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CheckUnitsTakeTurns_d__73.NativeFieldInfoPtr__triggerAction_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004283 RID: 17027
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004284 RID: 17028
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004285 RID: 17029
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004286 RID: 17030
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x04004287 RID: 17031
		private static readonly IntPtr NativeFieldInfoPtr__pauseAfter_5__2;

		// Token: 0x04004288 RID: 17032
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

		// Token: 0x04004289 RID: 17033
		private static readonly IntPtr NativeFieldInfoPtr__unit_5__4;

		// Token: 0x0400428A RID: 17034
		private static readonly IntPtr NativeFieldInfoPtr__triggerAction_5__5;

		// Token: 0x0400428B RID: 17035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400428C RID: 17036
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400428D RID: 17037
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400428E RID: 17038
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x0400428F RID: 17039
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004290 RID: 17040
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004291 RID: 17041
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200055C RID: 1372
	[ObfuscatedName("Battle+<>c__DisplayClass74_0")]
	public sealed class __c__DisplayClass74_0 : Il2CppSystem.Object
	{
		// Token: 0x060065E4 RID: 26084 RVA: 0x00199034 File Offset: 0x00197234
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass74_0()
		{
			Il2CppClassPointerStore<Battle.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<>c__DisplayClass74_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle.__c__DisplayClass74_0>.NativeClassPtr);
			Battle.__c__DisplayClass74_0.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle.__c__DisplayClass74_0>.NativeClassPtr, "entity");
			Battle.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c__DisplayClass74_0>.NativeClassPtr, 100665068);
			Battle.__c__DisplayClass74_0.NativeMethodInfoPtr__ProcessUnits_b__2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle.__c__DisplayClass74_0>.NativeClassPtr, 100665069);
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x0019909C File Offset: 0x0019729C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass74_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle.__c__DisplayClass74_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x001990D8 File Offset: 0x001972D8
		[CallerCount(0)]
		public unsafe bool _ProcessUnits_b__2(Entity a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle.__c__DisplayClass74_0.NativeMethodInfoPtr__ProcessUnits_b__2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065E7 RID: 26087 RVA: 0x000321E5 File Offset: 0x000303E5
		public __c__DisplayClass74_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x060065E8 RID: 26088 RVA: 0x00199128 File Offset: 0x00197328
		// (set) Token: 0x060065E9 RID: 26089 RVA: 0x000321EE File Offset: 0x000303EE
		public unsafe Entity entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.__c__DisplayClass74_0.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle.__c__DisplayClass74_0.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004292 RID: 17042
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x04004293 RID: 17043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004294 RID: 17044
		private static readonly IntPtr NativeMethodInfoPtr__ProcessUnits_b__2_Internal_Boolean_Entity_0;
	}

	// Token: 0x0200055D RID: 1373
	[ObfuscatedName("Battle+<ProcessUnits>d__74")]
	public sealed class _ProcessUnits_d__74 : Il2CppSystem.Object
	{
		// Token: 0x060065EA RID: 26090 RVA: 0x00199158 File Offset: 0x00197358
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessUnits_d__74()
		{
			Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<ProcessUnits>d__74");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr);
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "<>1__state");
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "<>2__current");
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "character");
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "<>4__this");
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "<>8__1");
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr__processed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "<processed>5__2");
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr__dirty_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "<dirty>5__3");
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr__positions_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "<positions>5__4");
			Battle._ProcessUnits_d__74.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, "<>7__wrap4");
			Battle._ProcessUnits_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, 100665070);
			Battle._ProcessUnits_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, 100665071);
			Battle._ProcessUnits_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, 100665072);
			Battle._ProcessUnits_d__74.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, 100665073);
			Battle._ProcessUnits_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, 100665074);
			Battle._ProcessUnits_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, 100665075);
			Battle._ProcessUnits_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr, 100665076);
		}

		// Token: 0x060065EB RID: 26091 RVA: 0x001992C4 File Offset: 0x001974C4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessUnits_d__74(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._ProcessUnits_d__74>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnits_d__74.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065EC RID: 26092 RVA: 0x0019930C File Offset: 0x0019750C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29514, XrefRangeEnd = 29519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnits_d__74.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060065ED RID: 26093 RVA: 0x00199340 File Offset: 0x00197540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29519, XrefRangeEnd = 29643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnits_d__74.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060065EE RID: 26094 RVA: 0x0019937C File Offset: 0x0019757C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29643, XrefRangeEnd = 29646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnits_d__74.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x060065EF RID: 26095 RVA: 0x001993B0 File Offset: 0x001975B0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnits_d__74.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065F0 RID: 26096 RVA: 0x001993F0 File Offset: 0x001975F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29646, XrefRangeEnd = 29652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnits_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x060065F1 RID: 26097 RVA: 0x00199424 File Offset: 0x00197624
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnits_d__74.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060065F2 RID: 26098 RVA: 0x0003220D File Offset: 0x0003040D
		public _ProcessUnits_d__74(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x060065F3 RID: 26099 RVA: 0x00199464 File Offset: 0x00197664
		// (set) Token: 0x060065F4 RID: 26100 RVA: 0x00032216 File Offset: 0x00030416
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x060065F5 RID: 26101 RVA: 0x0019948C File Offset: 0x0019768C
		// (set) Token: 0x060065F6 RID: 26102 RVA: 0x00032231 File Offset: 0x00030431
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x060065F7 RID: 26103 RVA: 0x001994BC File Offset: 0x001976BC
		// (set) Token: 0x060065F8 RID: 26104 RVA: 0x00032250 File Offset: 0x00030450
		public unsafe Character character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr_character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x060065F9 RID: 26105 RVA: 0x001994EC File Offset: 0x001976EC
		// (set) Token: 0x060065FA RID: 26106 RVA: 0x0003226F File Offset: 0x0003046F
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x060065FB RID: 26107 RVA: 0x0019951C File Offset: 0x0019771C
		// (set) Token: 0x060065FC RID: 26108 RVA: 0x0003228E File Offset: 0x0003048E
		public unsafe Battle.__c__DisplayClass74_0 __8__1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___8__1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle.__c__DisplayClass74_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x060065FD RID: 26109 RVA: 0x0019954C File Offset: 0x0019774C
		// (set) Token: 0x060065FE RID: 26110 RVA: 0x000322AD File Offset: 0x000304AD
		public unsafe List<Entity> _processed_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr__processed_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr__processed_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x060065FF RID: 26111 RVA: 0x0019957C File Offset: 0x0019777C
		// (set) Token: 0x06006600 RID: 26112 RVA: 0x000322CC File Offset: 0x000304CC
		public unsafe bool _dirty_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr__dirty_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr__dirty_5__3)) = value;
			}
		}

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06006601 RID: 26113 RVA: 0x001995A4 File Offset: 0x001977A4
		// (set) Token: 0x06006602 RID: 26114 RVA: 0x000322E7 File Offset: 0x000304E7
		public unsafe Dictionary<Entity, Il2CppReferenceArray<CardContainer>> _positions_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr__positions_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Entity, Il2CppReferenceArray<CardContainer>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr__positions_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x06006603 RID: 26115 RVA: 0x001995D4 File Offset: 0x001977D4
		// (set) Token: 0x06006604 RID: 26116 RVA: 0x00032306 File Offset: 0x00030506
		public List<Entity>.Enumerator __7__wrap4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___7__wrap4);
				return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnits_d__74.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04004295 RID: 17045
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004296 RID: 17046
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004297 RID: 17047
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x04004298 RID: 17048
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004299 RID: 17049
		private static readonly IntPtr NativeFieldInfoPtr___8__1;

		// Token: 0x0400429A RID: 17050
		private static readonly IntPtr NativeFieldInfoPtr__processed_5__2;

		// Token: 0x0400429B RID: 17051
		private static readonly IntPtr NativeFieldInfoPtr__dirty_5__3;

		// Token: 0x0400429C RID: 17052
		private static readonly IntPtr NativeFieldInfoPtr__positions_5__4;

		// Token: 0x0400429D RID: 17053
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

		// Token: 0x0400429E RID: 17054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400429F RID: 17055
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042A0 RID: 17056
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040042A1 RID: 17057
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x040042A2 RID: 17058
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040042A3 RID: 17059
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042A4 RID: 17060
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200055E RID: 1374
	[ObfuscatedName("Battle+<ProcessUnit>d__77")]
	public sealed class _ProcessUnit_d__77 : Il2CppSystem.Object
	{
		// Token: 0x06006605 RID: 26117 RVA: 0x00199604 File Offset: 0x00197804
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessUnit_d__77()
		{
			Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<ProcessUnit>d__77");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr);
			Battle._ProcessUnit_d__77.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, "<>1__state");
			Battle._ProcessUnit_d__77.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, "<>2__current");
			Battle._ProcessUnit_d__77.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, "unit");
			Battle._ProcessUnit_d__77.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, "<>4__this");
			Battle._ProcessUnit_d__77.NativeFieldInfoPtr__pauseAfter_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, "<pauseAfter>5__2");
			Battle._ProcessUnit_d__77.NativeFieldInfoPtr__snowed_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, "<snowed>5__3");
			Battle._ProcessUnit_d__77.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, 100665077);
			Battle._ProcessUnit_d__77.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, 100665078);
			Battle._ProcessUnit_d__77.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, 100665079);
			Battle._ProcessUnit_d__77.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, 100665080);
			Battle._ProcessUnit_d__77.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, 100665081);
			Battle._ProcessUnit_d__77.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr, 100665082);
		}

		// Token: 0x06006606 RID: 26118 RVA: 0x00199720 File Offset: 0x00197920
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessUnit_d__77(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._ProcessUnit_d__77>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnit_d__77.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006607 RID: 26119 RVA: 0x00199768 File Offset: 0x00197968
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnit_d__77.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006608 RID: 26120 RVA: 0x0019979C File Offset: 0x0019799C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29652, XrefRangeEnd = 29708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnit_d__77.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06006609 RID: 26121 RVA: 0x001997D8 File Offset: 0x001979D8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnit_d__77.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600660A RID: 26122 RVA: 0x00199818 File Offset: 0x00197A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29708, XrefRangeEnd = 29714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnit_d__77.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x0600660B RID: 26123 RVA: 0x0019984C File Offset: 0x00197A4C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnit_d__77.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600660C RID: 26124 RVA: 0x00032334 File Offset: 0x00030534
		public _ProcessUnit_d__77(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x0600660D RID: 26125 RVA: 0x0019988C File Offset: 0x00197A8C
		// (set) Token: 0x0600660E RID: 26126 RVA: 0x0003233D File Offset: 0x0003053D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x0600660F RID: 26127 RVA: 0x001998B4 File Offset: 0x00197AB4
		// (set) Token: 0x06006610 RID: 26128 RVA: 0x00032358 File Offset: 0x00030558
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06006611 RID: 26129 RVA: 0x001998E4 File Offset: 0x00197AE4
		// (set) Token: 0x06006612 RID: 26130 RVA: 0x00032377 File Offset: 0x00030577
		public unsafe Entity unit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr_unit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr_unit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06006613 RID: 26131 RVA: 0x00199914 File Offset: 0x00197B14
		// (set) Token: 0x06006614 RID: 26132 RVA: 0x00032396 File Offset: 0x00030596
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06006615 RID: 26133 RVA: 0x00199944 File Offset: 0x00197B44
		// (set) Token: 0x06006616 RID: 26134 RVA: 0x000323B5 File Offset: 0x000305B5
		public unsafe float _pauseAfter_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr__pauseAfter_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr__pauseAfter_5__2)) = value;
			}
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06006617 RID: 26135 RVA: 0x0019996C File Offset: 0x00197B6C
		// (set) Token: 0x06006618 RID: 26136 RVA: 0x000323D0 File Offset: 0x000305D0
		public unsafe bool _snowed_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr__snowed_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnit_d__77.NativeFieldInfoPtr__snowed_5__3)) = value;
			}
		}

		// Token: 0x040042A5 RID: 17061
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040042A6 RID: 17062
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040042A7 RID: 17063
		private static readonly IntPtr NativeFieldInfoPtr_unit;

		// Token: 0x040042A8 RID: 17064
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040042A9 RID: 17065
		private static readonly IntPtr NativeFieldInfoPtr__pauseAfter_5__2;

		// Token: 0x040042AA RID: 17066
		private static readonly IntPtr NativeFieldInfoPtr__snowed_5__3;

		// Token: 0x040042AB RID: 17067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040042AC RID: 17068
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042AD RID: 17069
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040042AE RID: 17070
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040042AF RID: 17071
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042B0 RID: 17072
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200055F RID: 1375
	[ObfuscatedName("Battle+<ProcessHandStart>d__78")]
	public sealed class _ProcessHandStart_d__78 : Il2CppSystem.Object
	{
		// Token: 0x06006619 RID: 26137 RVA: 0x00199994 File Offset: 0x00197B94
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessHandStart_d__78()
		{
			Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<ProcessHandStart>d__78");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr);
			Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, "<>1__state");
			Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, "<>2__current");
			Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, "<>4__this");
			Battle._ProcessHandStart_d__78.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, "character");
			Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, "<>7__wrap1");
			Battle._ProcessHandStart_d__78.NativeFieldInfoPtr__entity_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, "<entity>5__3");
			Battle._ProcessHandStart_d__78.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, 100665083);
			Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, 100665084);
			Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, 100665085);
			Battle._ProcessHandStart_d__78.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, 100665086);
			Battle._ProcessHandStart_d__78.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, 100665087);
			Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, 100665088);
			Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, 100665089);
			Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr, 100665090);
		}

		// Token: 0x0600661A RID: 26138 RVA: 0x00199AD8 File Offset: 0x00197CD8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessHandStart_d__78(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._ProcessHandStart_d__78>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandStart_d__78.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600661B RID: 26139 RVA: 0x00199B20 File Offset: 0x00197D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29714, XrefRangeEnd = 29724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600661C RID: 26140 RVA: 0x00199B54 File Offset: 0x00197D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29724, XrefRangeEnd = 29774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600661D RID: 26141 RVA: 0x00199B90 File Offset: 0x00197D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29774, XrefRangeEnd = 29777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandStart_d__78.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600661E RID: 26142 RVA: 0x00199BC4 File Offset: 0x00197DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29777, XrefRangeEnd = 29780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandStart_d__78.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600661F RID: 26143 RVA: 0x00199BF8 File Offset: 0x00197DF8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006620 RID: 26144 RVA: 0x00199C38 File Offset: 0x00197E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29780, XrefRangeEnd = 29786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06006621 RID: 26145 RVA: 0x00199C6C File Offset: 0x00197E6C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandStart_d__78.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x000323EB File Offset: 0x000305EB
		public _ProcessHandStart_d__78(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06006623 RID: 26147 RVA: 0x00199CAC File Offset: 0x00197EAC
		// (set) Token: 0x06006624 RID: 26148 RVA: 0x000323F4 File Offset: 0x000305F4
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06006625 RID: 26149 RVA: 0x00199CD4 File Offset: 0x00197ED4
		// (set) Token: 0x06006626 RID: 26150 RVA: 0x0003240F File Offset: 0x0003060F
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06006627 RID: 26151 RVA: 0x00199D04 File Offset: 0x00197F04
		// (set) Token: 0x06006628 RID: 26152 RVA: 0x0003242E File Offset: 0x0003062E
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06006629 RID: 26153 RVA: 0x00199D34 File Offset: 0x00197F34
		// (set) Token: 0x0600662A RID: 26154 RVA: 0x0003244D File Offset: 0x0003064D
		public unsafe Character character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr_character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x0600662B RID: 26155 RVA: 0x00199D64 File Offset: 0x00197F64
		// (set) Token: 0x0600662C RID: 26156 RVA: 0x0003246C File Offset: 0x0003066C
		public unsafe IEnumerator<Entity> __7__wrap1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___7__wrap1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x0600662D RID: 26157 RVA: 0x00199D94 File Offset: 0x00197F94
		// (set) Token: 0x0600662E RID: 26158 RVA: 0x0003248B File Offset: 0x0003068B
		public unsafe Entity _entity_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr__entity_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandStart_d__78.NativeFieldInfoPtr__entity_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042B1 RID: 17073
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040042B2 RID: 17074
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040042B3 RID: 17075
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040042B4 RID: 17076
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x040042B5 RID: 17077
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

		// Token: 0x040042B6 RID: 17078
		private static readonly IntPtr NativeFieldInfoPtr__entity_5__3;

		// Token: 0x040042B7 RID: 17079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040042B8 RID: 17080
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042B9 RID: 17081
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040042BA RID: 17082
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x040042BB RID: 17083
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

		// Token: 0x040042BC RID: 17084
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040042BD RID: 17085
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042BE RID: 17086
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000560 RID: 1376
	[ObfuscatedName("Battle+<ProcessHandEnd>d__79")]
	public sealed class _ProcessHandEnd_d__79 : Il2CppSystem.Object
	{
		// Token: 0x0600662F RID: 26159 RVA: 0x00199DC4 File Offset: 0x00197FC4
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessHandEnd_d__79()
		{
			Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<ProcessHandEnd>d__79");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr);
			Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, "<>1__state");
			Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, "<>2__current");
			Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, "<>4__this");
			Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, "character");
			Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, "<>7__wrap1");
			Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr__entity_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, "<entity>5__3");
			Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, 100665091);
			Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, 100665092);
			Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, 100665093);
			Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, 100665094);
			Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, 100665095);
			Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, 100665096);
			Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr, 100665097);
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x00199EF4 File Offset: 0x001980F4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessHandEnd_d__79(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._ProcessHandEnd_d__79>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x00199F3C File Offset: 0x0019813C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29786, XrefRangeEnd = 29791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x00199F70 File Offset: 0x00198170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29791, XrefRangeEnd = 29819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x00199FAC File Offset: 0x001981AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29819, XrefRangeEnd = 29822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x06006634 RID: 26164 RVA: 0x00199FE0 File Offset: 0x001981E0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x0019A020 File Offset: 0x00198220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29822, XrefRangeEnd = 29828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x06006636 RID: 26166 RVA: 0x0019A054 File Offset: 0x00198254
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessHandEnd_d__79.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x000324AA File Offset: 0x000306AA
		public _ProcessHandEnd_d__79(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06006638 RID: 26168 RVA: 0x0019A094 File Offset: 0x00198294
		// (set) Token: 0x06006639 RID: 26169 RVA: 0x000324B3 File Offset: 0x000306B3
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x0600663A RID: 26170 RVA: 0x0019A0BC File Offset: 0x001982BC
		// (set) Token: 0x0600663B RID: 26171 RVA: 0x000324CE File Offset: 0x000306CE
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x0600663C RID: 26172 RVA: 0x0019A0EC File Offset: 0x001982EC
		// (set) Token: 0x0600663D RID: 26173 RVA: 0x000324ED File Offset: 0x000306ED
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x0600663E RID: 26174 RVA: 0x0019A11C File Offset: 0x0019831C
		// (set) Token: 0x0600663F RID: 26175 RVA: 0x0003250C File Offset: 0x0003070C
		public unsafe Character character
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr_character);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06006640 RID: 26176 RVA: 0x0019A14C File Offset: 0x0019834C
		// (set) Token: 0x06006641 RID: 26177 RVA: 0x0003252B File Offset: 0x0003072B
		public unsafe IEnumerator<Entity> __7__wrap1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___7__wrap1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x06006642 RID: 26178 RVA: 0x0019A17C File Offset: 0x0019837C
		// (set) Token: 0x06006643 RID: 26179 RVA: 0x0003254A File Offset: 0x0003074A
		public unsafe Entity _entity_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr__entity_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessHandEnd_d__79.NativeFieldInfoPtr__entity_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042BF RID: 17087
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040042C0 RID: 17088
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040042C1 RID: 17089
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040042C2 RID: 17090
		private static readonly IntPtr NativeFieldInfoPtr_character;

		// Token: 0x040042C3 RID: 17091
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

		// Token: 0x040042C4 RID: 17092
		private static readonly IntPtr NativeFieldInfoPtr__entity_5__3;

		// Token: 0x040042C5 RID: 17093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040042C6 RID: 17094
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042C7 RID: 17095
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040042C8 RID: 17096
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x040042C9 RID: 17097
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040042CA RID: 17098
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042CB RID: 17099
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000561 RID: 1377
	[ObfuscatedName("Battle+<ProcessUnitTurnEnd>d__80")]
	public sealed class _ProcessUnitTurnEnd_d__80 : Il2CppSystem.Object
	{
		// Token: 0x06006644 RID: 26180 RVA: 0x0019A1AC File Offset: 0x001983AC
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessUnitTurnEnd_d__80()
		{
			Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<ProcessUnitTurnEnd>d__80");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr);
			Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, "<>1__state");
			Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, "<>2__current");
			Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, "<>4__this");
			Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, "<>7__wrap1");
			Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr__unit_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, "<unit>5__3");
			Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, 100665098);
			Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, 100665099);
			Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, 100665100);
			Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, 100665101);
			Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, 100665102);
			Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, 100665103);
			Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr, 100665104);
		}

		// Token: 0x06006645 RID: 26181 RVA: 0x0019A2C8 File Offset: 0x001984C8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessUnitTurnEnd_d__80(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._ProcessUnitTurnEnd_d__80>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x0019A310 File Offset: 0x00198510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29828, XrefRangeEnd = 29833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x0019A344 File Offset: 0x00198544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29833, XrefRangeEnd = 29895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x0019A380 File Offset: 0x00198580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29895, XrefRangeEnd = 29898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __m__Finally1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06006649 RID: 26185 RVA: 0x0019A3B4 File Offset: 0x001985B4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x0019A3F4 File Offset: 0x001985F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29898, XrefRangeEnd = 29904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600664B RID: 26187 RVA: 0x0019A428 File Offset: 0x00198628
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._ProcessUnitTurnEnd_d__80.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x00032569 File Offset: 0x00030769
		public _ProcessUnitTurnEnd_d__80(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x0600664D RID: 26189 RVA: 0x0019A468 File Offset: 0x00198668
		// (set) Token: 0x0600664E RID: 26190 RVA: 0x00032572 File Offset: 0x00030772
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x0600664F RID: 26191 RVA: 0x0019A490 File Offset: 0x00198690
		// (set) Token: 0x06006650 RID: 26192 RVA: 0x0003258D File Offset: 0x0003078D
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06006651 RID: 26193 RVA: 0x0019A4C0 File Offset: 0x001986C0
		// (set) Token: 0x06006652 RID: 26194 RVA: 0x000325AC File Offset: 0x000307AC
		public unsafe Battle __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06006653 RID: 26195 RVA: 0x0019A4F0 File Offset: 0x001986F0
		// (set) Token: 0x06006654 RID: 26196 RVA: 0x000325CB File Offset: 0x000307CB
		public HashSet<Entity>.Enumerator __7__wrap1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___7__wrap1);
				return new HashSet<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HashSet<Entity>.Enumerator>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HashSet<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06006655 RID: 26197 RVA: 0x0019A520 File Offset: 0x00198720
		// (set) Token: 0x06006656 RID: 26198 RVA: 0x000325F9 File Offset: 0x000307F9
		public unsafe Entity _unit_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr__unit_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._ProcessUnitTurnEnd_d__80.NativeFieldInfoPtr__unit_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042CC RID: 17100
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040042CD RID: 17101
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040042CE RID: 17102
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040042CF RID: 17103
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

		// Token: 0x040042D0 RID: 17104
		private static readonly IntPtr NativeFieldInfoPtr__unit_5__3;

		// Token: 0x040042D1 RID: 17105
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040042D2 RID: 17106
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042D3 RID: 17107
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040042D4 RID: 17108
		private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

		// Token: 0x040042D5 RID: 17109
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040042D6 RID: 17110
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042D7 RID: 17111
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000562 RID: 1378
	[ObfuscatedName("Battle+<CardCountDown>d__81")]
	public sealed class _CardCountDown_d__81 : Il2CppSystem.Object
	{
		// Token: 0x06006657 RID: 26199 RVA: 0x0019A550 File Offset: 0x00198750
		// Note: this type is marked as 'beforefieldinit'.
		static _CardCountDown_d__81()
		{
			Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Battle>.NativeClassPtr, "<CardCountDown>d__81");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr);
			Battle._CardCountDown_d__81.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, "<>1__state");
			Battle._CardCountDown_d__81.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, "<>2__current");
			Battle._CardCountDown_d__81.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, "entity");
			Battle._CardCountDown_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, 100665105);
			Battle._CardCountDown_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, 100665106);
			Battle._CardCountDown_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, 100665107);
			Battle._CardCountDown_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, 100665108);
			Battle._CardCountDown_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, 100665109);
			Battle._CardCountDown_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr, 100665110);
		}

		// Token: 0x06006658 RID: 26200 RVA: 0x0019A630 File Offset: 0x00198830
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CardCountDown_d__81(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Battle._CardCountDown_d__81>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CardCountDown_d__81.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006659 RID: 26201 RVA: 0x0019A678 File Offset: 0x00198878
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CardCountDown_d__81.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600665A RID: 26202 RVA: 0x0019A6AC File Offset: 0x001988AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29904, XrefRangeEnd = 29905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CardCountDown_d__81.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x0600665B RID: 26203 RVA: 0x0019A6E8 File Offset: 0x001988E8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CardCountDown_d__81.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600665C RID: 26204 RVA: 0x0019A728 File Offset: 0x00198928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29905, XrefRangeEnd = 29911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CardCountDown_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x0600665D RID: 26205 RVA: 0x0019A75C File Offset: 0x0019895C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Battle._CardCountDown_d__81.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600665E RID: 26206 RVA: 0x00032618 File Offset: 0x00030818
		public _CardCountDown_d__81(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x0600665F RID: 26207 RVA: 0x0019A79C File Offset: 0x0019899C
		// (set) Token: 0x06006660 RID: 26208 RVA: 0x00032621 File Offset: 0x00030821
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CardCountDown_d__81.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CardCountDown_d__81.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06006661 RID: 26209 RVA: 0x0019A7C4 File Offset: 0x001989C4
		// (set) Token: 0x06006662 RID: 26210 RVA: 0x0003263C File Offset: 0x0003083C
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CardCountDown_d__81.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CardCountDown_d__81.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06006663 RID: 26211 RVA: 0x0019A7F4 File Offset: 0x001989F4
		// (set) Token: 0x06006664 RID: 26212 RVA: 0x0003265B File Offset: 0x0003085B
		public unsafe Entity entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CardCountDown_d__81.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Battle._CardCountDown_d__81.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042D8 RID: 17112
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040042D9 RID: 17113
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040042DA RID: 17114
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x040042DB RID: 17115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040042DC RID: 17116
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042DD RID: 17117
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040042DE RID: 17118
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040042DF RID: 17119
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040042E0 RID: 17120
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

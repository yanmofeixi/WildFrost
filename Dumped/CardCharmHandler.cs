using System;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020000EA RID: 234
public class CardCharmDragHandler : MonoBehaviour
{
	// Token: 0x06000C8F RID: 3215 RVA: 0x0007BE24 File Offset: 0x0007A024
	// Note: this type is marked as 'beforefieldinit'.
	static CardCharmDragHandler()
	{
		Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardCharmDragHandler");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr);
		CardCharmDragHandler.NativeFieldInfoPtr_canDragMidBattle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "canDragMidBattle");
		CardCharmDragHandler.NativeFieldInfoPtr_denySfxEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "denySfxEvent");
		CardCharmDragHandler.NativeFieldInfoPtr_assignmentContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "assignmentContainers");
		CardCharmDragHandler.NativeFieldInfoPtr_cardController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "cardController");
		CardCharmDragHandler.NativeFieldInfoPtr_dragHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "dragHolder");
		CardCharmDragHandler.NativeFieldInfoPtr_onAssign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "onAssign");
		CardCharmDragHandler.NativeFieldInfoPtr_assignSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "assignSequence");
		CardCharmDragHandler.NativeFieldInfoPtr_instantAssign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "instantAssign");
		CardCharmDragHandler.NativeFieldInfoPtr_dragging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "dragging");
		CardCharmDragHandler.NativeFieldInfoPtr_preHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "preHolder");
		CardCharmDragHandler.NativeFieldInfoPtr_preIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "preIndex");
		CardCharmDragHandler.NativeFieldInfoPtr__IsDragging_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "<IsDragging>k__BackingField");
		CardCharmDragHandler.NativeFieldInfoPtr_hoverEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "hoverEntity");
		CardCharmDragHandler.NativeFieldInfoPtr_eligibleCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "eligibleCards");
		CardCharmDragHandler.NativeFieldInfoPtr_ineligibleCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "ineligibleCards");
		CardCharmDragHandler.NativeFieldInfoPtr_flipClump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "flipClump");
		CardCharmDragHandler.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665595);
		CardCharmDragHandler.NativeMethodInfoPtr_set_IsDragging_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665596);
		CardCharmDragHandler.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665597);
		CardCharmDragHandler.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665598);
		CardCharmDragHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665599);
		CardCharmDragHandler.NativeMethodInfoPtr_UpdatePosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665600);
		CardCharmDragHandler.NativeMethodInfoPtr_Drag_Public_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665601);
		CardCharmDragHandler.NativeMethodInfoPtr_Release_Public_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665602);
		CardCharmDragHandler.NativeMethodInfoPtr_DragEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665603);
		CardCharmDragHandler.NativeMethodInfoPtr_ReturnToHolder_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665604);
		CardCharmDragHandler.NativeMethodInfoPtr_CancelDrag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665605);
		CardCharmDragHandler.NativeMethodInfoPtr_FlipCardsDown_Private_IEnumerator_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665606);
		CardCharmDragHandler.NativeMethodInfoPtr_FlipDown_Private_Static_IEnumerator_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665607);
		CardCharmDragHandler.NativeMethodInfoPtr_FlipCardsUp_Private_IEnumerator_IEnumerable_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665608);
		CardCharmDragHandler.NativeMethodInfoPtr_FlipUp_Private_Static_IEnumerator_Entity_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665609);
		CardCharmDragHandler.NativeMethodInfoPtr_Assign_Private_IEnumerator_UpgradeDisplay_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665610);
		CardCharmDragHandler.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665611);
		CardCharmDragHandler.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665612);
		CardCharmDragHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, 100665613);
	}

	// Token: 0x1700032B RID: 811
	// (get) Token: 0x06000C90 RID: 3216 RVA: 0x0007C110 File Offset: 0x0007A310
	// (set) Token: 0x06000C91 RID: 3217 RVA: 0x0007C14C File Offset: 0x0007A34C
	public unsafe bool IsDragging
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35425, RefRangeEnd = 35427, XrefRangeStart = 35425, XrefRangeEnd = 35425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_set_IsDragging_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000C92 RID: 3218 RVA: 0x0007C18C File Offset: 0x0007A38C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35427, XrefRangeEnd = 35441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C93 RID: 3219 RVA: 0x0007C1C0 File Offset: 0x0007A3C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35441, XrefRangeEnd = 35456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C94 RID: 3220 RVA: 0x0007C1F4 File Offset: 0x0007A3F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35456, XrefRangeEnd = 35483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C95 RID: 3221 RVA: 0x0007C228 File Offset: 0x0007A428
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35502, RefRangeEnd = 35503, XrefRangeStart = 35483, XrefRangeEnd = 35502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdatePosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_UpdatePosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C96 RID: 3222 RVA: 0x0007C25C File Offset: 0x0007A45C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35525, RefRangeEnd = 35526, XrefRangeStart = 35503, XrefRangeEnd = 35525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Drag(UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_Drag_Public_Void_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C97 RID: 3223 RVA: 0x0007C2A0 File Offset: 0x0007A4A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35526, XrefRangeEnd = 35547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release(UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_Release_Public_Void_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C98 RID: 3224 RVA: 0x0007C2E4 File Offset: 0x0007A4E4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 35569, RefRangeEnd = 35572, XrefRangeStart = 35547, XrefRangeEnd = 35569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DragEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_DragEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C99 RID: 3225 RVA: 0x0007C318 File Offset: 0x0007A518
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 35579, RefRangeEnd = 35581, XrefRangeStart = 35572, XrefRangeEnd = 35579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ReturnToHolder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_ReturnToHolder_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C9A RID: 3226 RVA: 0x0007C34C File Offset: 0x0007A54C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35601, RefRangeEnd = 35602, XrefRangeStart = 35581, XrefRangeEnd = 35601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelDrag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_CancelDrag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000C9B RID: 3227 RVA: 0x0007C380 File Offset: 0x0007A580
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35602, XrefRangeEnd = 35608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator FlipCardsDown(IEnumerable<Entity> cards)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_FlipCardsDown_Private_IEnumerator_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000C9C RID: 3228 RVA: 0x0007C3D0 File Offset: 0x0007A5D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35608, XrefRangeEnd = 35613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator FlipDown(Entity card, float delay)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_FlipDown_Private_Static_IEnumerator_Entity_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x0007C424 File Offset: 0x0007A624
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35613, XrefRangeEnd = 35619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator FlipCardsUp(IEnumerable<Entity> cards)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cards);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_FlipCardsUp_Private_IEnumerator_IEnumerable_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000C9E RID: 3230 RVA: 0x0007C474 File Offset: 0x0007A674
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35619, XrefRangeEnd = 35624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator FlipUp(Entity card, float delay)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_FlipUp_Private_Static_IEnumerator_Entity_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000C9F RID: 3231 RVA: 0x0007C4C8 File Offset: 0x0007A6C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35624, XrefRangeEnd = 35631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Assign(UpgradeDisplay upgrade, Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_Assign_Private_IEnumerator_UpgradeDisplay_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000CA0 RID: 3232 RVA: 0x0007C52C File Offset: 0x0007A72C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35631, XrefRangeEnd = 35635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityHover(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0007C570 File Offset: 0x0007A770
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35635, XrefRangeEnd = 35640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EntityUnHover(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CA2 RID: 3234 RVA: 0x0007C5B4 File Offset: 0x0007A7B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35640, XrefRangeEnd = 35647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardCharmDragHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CA3 RID: 3235 RVA: 0x0000790B File Offset: 0x00005B0B
	public CardCharmDragHandler(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700031B RID: 795
	// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x0007C5F0 File Offset: 0x0007A7F0
	// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00007914 File Offset: 0x00005B14
	public unsafe bool canDragMidBattle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_canDragMidBattle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_canDragMidBattle)) = value;
		}
	}

	// Token: 0x1700031C RID: 796
	// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x0007C618 File Offset: 0x0007A818
	// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x0000792F File Offset: 0x00005B2F
	public unsafe EventReference denySfxEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_denySfxEvent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_denySfxEvent)) = value;
		}
	}

	// Token: 0x1700031D RID: 797
	// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0007C640 File Offset: 0x0007A840
	// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x0000794A File Offset: 0x00005B4A
	public unsafe Il2CppReferenceArray<CardContainer> assignmentContainers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_assignmentContainers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardContainer>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_assignmentContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031E RID: 798
	// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0007C670 File Offset: 0x0007A870
	// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00007969 File Offset: 0x00005B69
	public unsafe CardController cardController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_cardController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_cardController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700031F RID: 799
	// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0007C6A0 File Offset: 0x0007A8A0
	// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00007988 File Offset: 0x00005B88
	public unsafe UpgradeHolder dragHolder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_dragHolder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpgradeHolder>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_dragHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000320 RID: 800
	// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0007C6D0 File Offset: 0x0007A8D0
	// (set) Token: 0x06000CAF RID: 3247 RVA: 0x000079A7 File Offset: 0x00005BA7
	public unsafe UnityEvent onAssign
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_onAssign);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_onAssign), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000321 RID: 801
	// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0007C700 File Offset: 0x0007A900
	// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x000079C6 File Offset: 0x00005BC6
	public unsafe AssignCharmSequence assignSequence
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_assignSequence);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignCharmSequence>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_assignSequence), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000322 RID: 802
	// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0007C730 File Offset: 0x0007A930
	// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x000079E5 File Offset: 0x00005BE5
	public unsafe bool instantAssign
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_instantAssign);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_instantAssign)) = value;
		}
	}

	// Token: 0x17000323 RID: 803
	// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0007C758 File Offset: 0x0007A958
	// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00007A00 File Offset: 0x00005C00
	public unsafe UpgradeDisplay dragging
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_dragging);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpgradeDisplay>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_dragging), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000324 RID: 804
	// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0007C788 File Offset: 0x0007A988
	// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00007A1F File Offset: 0x00005C1F
	public unsafe UpgradeHolder preHolder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_preHolder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpgradeHolder>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_preHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000325 RID: 805
	// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0007C7B8 File Offset: 0x0007A9B8
	// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00007A3E File Offset: 0x00005C3E
	public unsafe int preIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_preIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_preIndex)) = value;
		}
	}

	// Token: 0x17000326 RID: 806
	// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0007C7E0 File Offset: 0x0007A9E0
	// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00007A59 File Offset: 0x00005C59
	public unsafe bool _IsDragging_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr__IsDragging_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr__IsDragging_k__BackingField)) = value;
		}
	}

	// Token: 0x17000327 RID: 807
	// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0007C808 File Offset: 0x0007AA08
	// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00007A74 File Offset: 0x00005C74
	public unsafe Entity hoverEntity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_hoverEntity);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_hoverEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000328 RID: 808
	// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0007C838 File Offset: 0x0007AA38
	// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00007A93 File Offset: 0x00005C93
	public unsafe List<Entity> eligibleCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_eligibleCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_eligibleCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000329 RID: 809
	// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0007C868 File Offset: 0x0007AA68
	// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00007AB2 File Offset: 0x00005CB2
	public unsafe List<Entity> ineligibleCards
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_ineligibleCards);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Entity>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_ineligibleCards), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700032A RID: 810
	// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0007C898 File Offset: 0x0007AA98
	// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00007AD1 File Offset: 0x00005CD1
	public unsafe Routine.Clump flipClump
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_flipClump);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Routine.Clump>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler.NativeFieldInfoPtr_flipClump), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040007EC RID: 2028
	private static readonly IntPtr NativeFieldInfoPtr_canDragMidBattle;

	// Token: 0x040007ED RID: 2029
	private static readonly IntPtr NativeFieldInfoPtr_denySfxEvent;

	// Token: 0x040007EE RID: 2030
	private static readonly IntPtr NativeFieldInfoPtr_assignmentContainers;

	// Token: 0x040007EF RID: 2031
	private static readonly IntPtr NativeFieldInfoPtr_cardController;

	// Token: 0x040007F0 RID: 2032
	private static readonly IntPtr NativeFieldInfoPtr_dragHolder;

	// Token: 0x040007F1 RID: 2033
	private static readonly IntPtr NativeFieldInfoPtr_onAssign;

	// Token: 0x040007F2 RID: 2034
	private static readonly IntPtr NativeFieldInfoPtr_assignSequence;

	// Token: 0x040007F3 RID: 2035
	private static readonly IntPtr NativeFieldInfoPtr_instantAssign;

	// Token: 0x040007F4 RID: 2036
	private static readonly IntPtr NativeFieldInfoPtr_dragging;

	// Token: 0x040007F5 RID: 2037
	private static readonly IntPtr NativeFieldInfoPtr_preHolder;

	// Token: 0x040007F6 RID: 2038
	private static readonly IntPtr NativeFieldInfoPtr_preIndex;

	// Token: 0x040007F7 RID: 2039
	private static readonly IntPtr NativeFieldInfoPtr__IsDragging_k__BackingField;

	// Token: 0x040007F8 RID: 2040
	private static readonly IntPtr NativeFieldInfoPtr_hoverEntity;

	// Token: 0x040007F9 RID: 2041
	private static readonly IntPtr NativeFieldInfoPtr_eligibleCards;

	// Token: 0x040007FA RID: 2042
	private static readonly IntPtr NativeFieldInfoPtr_ineligibleCards;

	// Token: 0x040007FB RID: 2043
	private static readonly IntPtr NativeFieldInfoPtr_flipClump;

	// Token: 0x040007FC RID: 2044
	private static readonly IntPtr NativeMethodInfoPtr_get_IsDragging_Public_get_Boolean_0;

	// Token: 0x040007FD RID: 2045
	private static readonly IntPtr NativeMethodInfoPtr_set_IsDragging_Private_set_Void_Boolean_0;

	// Token: 0x040007FE RID: 2046
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040007FF RID: 2047
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04000800 RID: 2048
	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

	// Token: 0x04000801 RID: 2049
	private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Private_Void_0;

	// Token: 0x04000802 RID: 2050
	private static readonly IntPtr NativeMethodInfoPtr_Drag_Public_Void_UpgradeDisplay_0;

	// Token: 0x04000803 RID: 2051
	private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_UpgradeDisplay_0;

	// Token: 0x04000804 RID: 2052
	private static readonly IntPtr NativeMethodInfoPtr_DragEnd_Private_Void_0;

	// Token: 0x04000805 RID: 2053
	private static readonly IntPtr NativeMethodInfoPtr_ReturnToHolder_Private_Void_0;

	// Token: 0x04000806 RID: 2054
	private static readonly IntPtr NativeMethodInfoPtr_CancelDrag_Public_Void_0;

	// Token: 0x04000807 RID: 2055
	private static readonly IntPtr NativeMethodInfoPtr_FlipCardsDown_Private_IEnumerator_IEnumerable_1_Entity_0;

	// Token: 0x04000808 RID: 2056
	private static readonly IntPtr NativeMethodInfoPtr_FlipDown_Private_Static_IEnumerator_Entity_Single_0;

	// Token: 0x04000809 RID: 2057
	private static readonly IntPtr NativeMethodInfoPtr_FlipCardsUp_Private_IEnumerator_IEnumerable_1_Entity_0;

	// Token: 0x0400080A RID: 2058
	private static readonly IntPtr NativeMethodInfoPtr_FlipUp_Private_Static_IEnumerator_Entity_Single_0;

	// Token: 0x0400080B RID: 2059
	private static readonly IntPtr NativeMethodInfoPtr_Assign_Private_IEnumerator_UpgradeDisplay_Entity_0;

	// Token: 0x0400080C RID: 2060
	private static readonly IntPtr NativeMethodInfoPtr_EntityHover_Private_Void_Entity_0;

	// Token: 0x0400080D RID: 2061
	private static readonly IntPtr NativeMethodInfoPtr_EntityUnHover_Private_Void_Entity_0;

	// Token: 0x0400080E RID: 2062
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200058D RID: 1421
	[ObfuscatedName("CardCharmDragHandler+<FlipCardsDown>d__28")]
	public sealed class _FlipCardsDown_d__28 : Il2CppSystem.Object
	{
		// Token: 0x06006867 RID: 26727 RVA: 0x001A0A48 File Offset: 0x0019EC48
		// Note: this type is marked as 'beforefieldinit'.
		static _FlipCardsDown_d__28()
		{
			Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "<FlipCardsDown>d__28");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr);
			CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, "<>1__state");
			CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, "<>2__current");
			CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, "<>4__this");
			CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, "cards");
			CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, 100665614);
			CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, 100665615);
			CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, 100665616);
			CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, 100665617);
			CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, 100665618);
			CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr, 100665619);
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x001A0B3C File Offset: 0x0019ED3C
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _FlipCardsDown_d__28(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsDown_d__28>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x001A0B84 File Offset: 0x0019ED84
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x001A0BB8 File Offset: 0x0019EDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35314, XrefRangeEnd = 35342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x0600686B RID: 26731 RVA: 0x001A0BF4 File Offset: 0x0019EDF4
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x001A0C34 File Offset: 0x0019EE34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35342, XrefRangeEnd = 35348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001FF9 RID: 8185
		// (get) Token: 0x0600686D RID: 26733 RVA: 0x001A0C68 File Offset: 0x0019EE68
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsDown_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x0003363F File Offset: 0x0003183F
		public _FlipCardsDown_d__28(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x0600686F RID: 26735 RVA: 0x001A0CA8 File Offset: 0x0019EEA8
		// (set) Token: 0x06006870 RID: 26736 RVA: 0x00033648 File Offset: 0x00031848
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06006871 RID: 26737 RVA: 0x001A0CD0 File Offset: 0x0019EED0
		// (set) Token: 0x06006872 RID: 26738 RVA: 0x00033663 File Offset: 0x00031863
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06006873 RID: 26739 RVA: 0x001A0D00 File Offset: 0x0019EF00
		// (set) Token: 0x06006874 RID: 26740 RVA: 0x00033682 File Offset: 0x00031882
		public unsafe CardCharmDragHandler __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardCharmDragHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06006875 RID: 26741 RVA: 0x001A0D30 File Offset: 0x0019EF30
		// (set) Token: 0x06006876 RID: 26742 RVA: 0x000336A1 File Offset: 0x000318A1
		public unsafe IEnumerable<Entity> cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr_cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsDown_d__28.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004415 RID: 17429
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004416 RID: 17430
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004417 RID: 17431
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004418 RID: 17432
		private static readonly IntPtr NativeFieldInfoPtr_cards;

		// Token: 0x04004419 RID: 17433
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400441A RID: 17434
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400441B RID: 17435
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400441C RID: 17436
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400441D RID: 17437
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400441E RID: 17438
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200058E RID: 1422
	[ObfuscatedName("CardCharmDragHandler+<FlipDown>d__29")]
	public sealed class _FlipDown_d__29 : Il2CppSystem.Object
	{
		// Token: 0x06006877 RID: 26743 RVA: 0x001A0D60 File Offset: 0x0019EF60
		// Note: this type is marked as 'beforefieldinit'.
		static _FlipDown_d__29()
		{
			Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "<FlipDown>d__29");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr);
			CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, "<>1__state");
			CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, "<>2__current");
			CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, "delay");
			CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, "card");
			CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, 100665620);
			CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, 100665621);
			CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, 100665622);
			CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, 100665623);
			CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, 100665624);
			CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr, 100665625);
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x001A0E54 File Offset: 0x0019F054
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _FlipDown_d__29(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmDragHandler._FlipDown_d__29>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x001A0E9C File Offset: 0x0019F09C
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x001A0ED0 File Offset: 0x0019F0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35348, XrefRangeEnd = 35353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x0600687B RID: 26747 RVA: 0x001A0F0C File Offset: 0x0019F10C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x001A0F4C File Offset: 0x0019F14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35353, XrefRangeEnd = 35359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x0600687D RID: 26749 RVA: 0x001A0F80 File Offset: 0x0019F180
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipDown_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x000336C0 File Offset: 0x000318C0
		public _FlipDown_d__29(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x0600687F RID: 26751 RVA: 0x001A0FC0 File Offset: 0x0019F1C0
		// (set) Token: 0x06006880 RID: 26752 RVA: 0x000336C9 File Offset: 0x000318C9
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06006881 RID: 26753 RVA: 0x001A0FE8 File Offset: 0x0019F1E8
		// (set) Token: 0x06006882 RID: 26754 RVA: 0x000336E4 File Offset: 0x000318E4
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06006883 RID: 26755 RVA: 0x001A1018 File Offset: 0x0019F218
		// (set) Token: 0x06006884 RID: 26756 RVA: 0x00033703 File Offset: 0x00031903
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06006885 RID: 26757 RVA: 0x001A1040 File Offset: 0x0019F240
		// (set) Token: 0x06006886 RID: 26758 RVA: 0x0003371E File Offset: 0x0003191E
		public unsafe Entity card
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr_card);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipDown_d__29.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400441F RID: 17439
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004420 RID: 17440
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004421 RID: 17441
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04004422 RID: 17442
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x04004423 RID: 17443
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004424 RID: 17444
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004425 RID: 17445
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004426 RID: 17446
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004427 RID: 17447
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004428 RID: 17448
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200058F RID: 1423
	[ObfuscatedName("CardCharmDragHandler+<FlipCardsUp>d__30")]
	public sealed class _FlipCardsUp_d__30 : Il2CppSystem.Object
	{
		// Token: 0x06006887 RID: 26759 RVA: 0x001A1070 File Offset: 0x0019F270
		// Note: this type is marked as 'beforefieldinit'.
		static _FlipCardsUp_d__30()
		{
			Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "<FlipCardsUp>d__30");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr);
			CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, "<>1__state");
			CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, "<>2__current");
			CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, "<>4__this");
			CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, "cards");
			CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, 100665626);
			CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, 100665627);
			CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, 100665628);
			CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, 100665629);
			CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, 100665630);
			CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr, 100665631);
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x001A1164 File Offset: 0x0019F364
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _FlipCardsUp_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmDragHandler._FlipCardsUp_d__30>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x001A11AC File Offset: 0x0019F3AC
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x001A11E0 File Offset: 0x0019F3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35359, XrefRangeEnd = 35387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x0600688B RID: 26763 RVA: 0x001A121C File Offset: 0x0019F41C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x001A125C File Offset: 0x0019F45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35387, XrefRangeEnd = 35393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x0600688D RID: 26765 RVA: 0x001A1290 File Offset: 0x0019F490
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipCardsUp_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x0003373D File Offset: 0x0003193D
		public _FlipCardsUp_d__30(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x0600688F RID: 26767 RVA: 0x001A12D0 File Offset: 0x0019F4D0
		// (set) Token: 0x06006890 RID: 26768 RVA: 0x00033746 File Offset: 0x00031946
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x001A12F8 File Offset: 0x0019F4F8
		// (set) Token: 0x06006892 RID: 26770 RVA: 0x00033761 File Offset: 0x00031961
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06006893 RID: 26771 RVA: 0x001A1328 File Offset: 0x0019F528
		// (set) Token: 0x06006894 RID: 26772 RVA: 0x00033780 File Offset: 0x00031980
		public unsafe CardCharmDragHandler __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardCharmDragHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06006895 RID: 26773 RVA: 0x001A1358 File Offset: 0x0019F558
		// (set) Token: 0x06006896 RID: 26774 RVA: 0x0003379F File Offset: 0x0003199F
		public unsafe IEnumerable<Entity> cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr_cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipCardsUp_d__30.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004429 RID: 17449
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400442A RID: 17450
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400442B RID: 17451
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400442C RID: 17452
		private static readonly IntPtr NativeFieldInfoPtr_cards;

		// Token: 0x0400442D RID: 17453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400442E RID: 17454
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400442F RID: 17455
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004430 RID: 17456
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004431 RID: 17457
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004432 RID: 17458
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000590 RID: 1424
	[ObfuscatedName("CardCharmDragHandler+<FlipUp>d__31")]
	public sealed class _FlipUp_d__31 : Il2CppSystem.Object
	{
		// Token: 0x06006897 RID: 26775 RVA: 0x001A1388 File Offset: 0x0019F588
		// Note: this type is marked as 'beforefieldinit'.
		static _FlipUp_d__31()
		{
			Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "<FlipUp>d__31");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr);
			CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, "<>1__state");
			CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, "<>2__current");
			CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, "delay");
			CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, "card");
			CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, 100665632);
			CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, 100665633);
			CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, 100665634);
			CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, 100665635);
			CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, 100665636);
			CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr, 100665637);
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x001A147C File Offset: 0x0019F67C
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _FlipUp_d__31(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmDragHandler._FlipUp_d__31>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x001A14C4 File Offset: 0x0019F6C4
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600689A RID: 26778 RVA: 0x001A14F8 File Offset: 0x0019F6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35393, XrefRangeEnd = 35398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x0600689B RID: 26779 RVA: 0x001A1534 File Offset: 0x0019F734
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x001A1574 File Offset: 0x0019F774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35398, XrefRangeEnd = 35404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x0600689D RID: 26781 RVA: 0x001A15A8 File Offset: 0x0019F7A8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._FlipUp_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600689E RID: 26782 RVA: 0x000337BE File Offset: 0x000319BE
		public _FlipUp_d__31(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x001A15E8 File Offset: 0x0019F7E8
		// (set) Token: 0x060068A0 RID: 26784 RVA: 0x000337C7 File Offset: 0x000319C7
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x060068A1 RID: 26785 RVA: 0x001A1610 File Offset: 0x0019F810
		// (set) Token: 0x060068A2 RID: 26786 RVA: 0x000337E2 File Offset: 0x000319E2
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x060068A3 RID: 26787 RVA: 0x001A1640 File Offset: 0x0019F840
		// (set) Token: 0x060068A4 RID: 26788 RVA: 0x00033801 File Offset: 0x00031A01
		public unsafe float delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x060068A5 RID: 26789 RVA: 0x001A1668 File Offset: 0x0019F868
		// (set) Token: 0x060068A6 RID: 26790 RVA: 0x0003381C File Offset: 0x00031A1C
		public unsafe Entity card
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr_card);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._FlipUp_d__31.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004433 RID: 17459
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004434 RID: 17460
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004435 RID: 17461
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04004436 RID: 17462
		private static readonly IntPtr NativeFieldInfoPtr_card;

		// Token: 0x04004437 RID: 17463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004438 RID: 17464
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004439 RID: 17465
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400443A RID: 17466
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400443B RID: 17467
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400443C RID: 17468
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000591 RID: 1425
	[ObfuscatedName("CardCharmDragHandler+<Assign>d__32")]
	public sealed class _Assign_d__32 : Il2CppSystem.Object
	{
		// Token: 0x060068A7 RID: 26791 RVA: 0x001A1698 File Offset: 0x0019F898
		// Note: this type is marked as 'beforefieldinit'.
		static _Assign_d__32()
		{
			Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardCharmDragHandler>.NativeClassPtr, "<Assign>d__32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr);
			CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, "<>1__state");
			CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, "<>2__current");
			CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, "<>4__this");
			CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr_upgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, "upgrade");
			CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, "entity");
			CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr__upgradeData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, "<upgradeData>5__2");
			CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, 100665638);
			CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, 100665639);
			CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, 100665640);
			CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, 100665641);
			CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, 100665642);
			CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr, 100665643);
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x001A17B4 File Offset: 0x0019F9B4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Assign_d__32(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmDragHandler._Assign_d__32>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068A9 RID: 26793 RVA: 0x001A17FC File Offset: 0x0019F9FC
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068AA RID: 26794 RVA: 0x001A1830 File Offset: 0x0019FA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35404, XrefRangeEnd = 35419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x060068AB RID: 26795 RVA: 0x001A186C File Offset: 0x0019FA6C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060068AC RID: 26796 RVA: 0x001A18AC File Offset: 0x0019FAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35419, XrefRangeEnd = 35425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x060068AD RID: 26797 RVA: 0x001A18E0 File Offset: 0x0019FAE0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmDragHandler._Assign_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060068AE RID: 26798 RVA: 0x0003383B File Offset: 0x00031A3B
		public _Assign_d__32(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x060068AF RID: 26799 RVA: 0x001A1920 File Offset: 0x0019FB20
		// (set) Token: 0x060068B0 RID: 26800 RVA: 0x00033844 File Offset: 0x00031A44
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x060068B1 RID: 26801 RVA: 0x001A1948 File Offset: 0x0019FB48
		// (set) Token: 0x060068B2 RID: 26802 RVA: 0x0003385F File Offset: 0x00031A5F
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x060068B3 RID: 26803 RVA: 0x001A1978 File Offset: 0x0019FB78
		// (set) Token: 0x060068B4 RID: 26804 RVA: 0x0003387E File Offset: 0x00031A7E
		public unsafe CardCharmDragHandler __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardCharmDragHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x060068B5 RID: 26805 RVA: 0x001A19A8 File Offset: 0x0019FBA8
		// (set) Token: 0x060068B6 RID: 26806 RVA: 0x0003389D File Offset: 0x00031A9D
		public unsafe UpgradeDisplay upgrade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr_upgrade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpgradeDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr_upgrade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x060068B7 RID: 26807 RVA: 0x001A19D8 File Offset: 0x0019FBD8
		// (set) Token: 0x060068B8 RID: 26808 RVA: 0x000338BC File Offset: 0x00031ABC
		public unsafe Entity entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x060068B9 RID: 26809 RVA: 0x001A1A08 File Offset: 0x0019FC08
		// (set) Token: 0x060068BA RID: 26810 RVA: 0x000338DB File Offset: 0x00031ADB
		public unsafe CardUpgradeData _upgradeData_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr__upgradeData_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardUpgradeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmDragHandler._Assign_d__32.NativeFieldInfoPtr__upgradeData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400443D RID: 17469
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400443E RID: 17470
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400443F RID: 17471
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004440 RID: 17472
		private static readonly IntPtr NativeFieldInfoPtr_upgrade;

		// Token: 0x04004441 RID: 17473
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x04004442 RID: 17474
		private static readonly IntPtr NativeFieldInfoPtr__upgradeData_5__2;

		// Token: 0x04004443 RID: 17475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004444 RID: 17476
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004445 RID: 17477
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004446 RID: 17478
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004447 RID: 17479
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004448 RID: 17480
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}


using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Token: 0x020000EB RID: 235
public class CardCharmInteraction : MonoBehaviourRect
{
	// Token: 0x06000CC4 RID: 3268 RVA: 0x0007C8C8 File Offset: 0x0007AAC8
	// Note: this type is marked as 'beforefieldinit'.
	static CardCharmInteraction()
	{
		Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardCharmInteraction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr);
		CardCharmInteraction.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "image");
		CardCharmInteraction.NativeFieldInfoPtr_dragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "dragHandler");
		CardCharmInteraction.NativeFieldInfoPtr_canHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "canHover");
		CardCharmInteraction.NativeFieldInfoPtr_canDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "canDrag");
		CardCharmInteraction.NativeFieldInfoPtr_hover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "hover");
		CardCharmInteraction.NativeFieldInfoPtr_preHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "preHover");
		CardCharmInteraction.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "press");
		CardCharmInteraction.NativeFieldInfoPtr_drag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "drag");
		CardCharmInteraction.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "popUpOffset");
		CardCharmInteraction.NativeFieldInfoPtr_onHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "onHover");
		CardCharmInteraction.NativeFieldInfoPtr_onUnHover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "onUnHover");
		CardCharmInteraction.NativeFieldInfoPtr_onDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "onDrag");
		CardCharmInteraction.NativeFieldInfoPtr_onDragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "onDragEnd");
		CardCharmInteraction.NativeFieldInfoPtr__upgradeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "_upgradeDisplay");
		CardCharmInteraction.NativeMethodInfoPtr_get_upgradeDisplay_Private_get_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665644);
		CardCharmInteraction.NativeMethodInfoPtr_get_DragHandlerDragging_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665645);
		CardCharmInteraction.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665646);
		CardCharmInteraction.NativeMethodInfoPtr_UpdateInputSystem_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665647);
		CardCharmInteraction.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665648);
		CardCharmInteraction.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665649);
		CardCharmInteraction.NativeMethodInfoPtr_Press_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665650);
		CardCharmInteraction.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665651);
		CardCharmInteraction.NativeMethodInfoPtr_Hover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665652);
		CardCharmInteraction.NativeMethodInfoPtr_UnHover_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665653);
		CardCharmInteraction.NativeMethodInfoPtr_StartDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665654);
		CardCharmInteraction.NativeMethodInfoPtr_StopDrag_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665655);
		CardCharmInteraction.NativeMethodInfoPtr_CancelDrag_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665656);
		CardCharmInteraction.NativeMethodInfoPtr_PopUpDescription_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665657);
		CardCharmInteraction.NativeMethodInfoPtr_HideDescription_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665658);
		CardCharmInteraction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, 100665659);
	}

	// Token: 0x1700033A RID: 826
	// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x0007CB50 File Offset: 0x0007AD50
	public unsafe UpgradeDisplay upgradeDisplay
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 35663, RefRangeEnd = 35666, XrefRangeStart = 35659, XrefRangeEnd = 35663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_get_upgradeDisplay_Private_get_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpgradeDisplay>(intPtr3) : null;
		}
	}

	// Token: 0x1700033B RID: 827
	// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0007CB90 File Offset: 0x0007AD90
	public unsafe bool DragHandlerDragging
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35666, XrefRangeEnd = 35670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_get_DragHandlerDragging_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000CC7 RID: 3271 RVA: 0x0007CBCC File Offset: 0x0007ADCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35670, XrefRangeEnd = 35711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LateUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CC8 RID: 3272 RVA: 0x0007CC00 File Offset: 0x0007AE00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35711, XrefRangeEnd = 35716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator UpdateInputSystem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_UpdateInputSystem_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000CC9 RID: 3273 RVA: 0x0007CC40 File Offset: 0x0007AE40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35716, XrefRangeEnd = 35717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerEnter(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CCA RID: 3274 RVA: 0x0007CC84 File Offset: 0x0007AE84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35717, XrefRangeEnd = 35727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerExit(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CCB RID: 3275 RVA: 0x0007CCC8 File Offset: 0x0007AEC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35727, XrefRangeEnd = 35728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Press()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_Press_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CCC RID: 3276 RVA: 0x0007CCFC File Offset: 0x0007AEFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35728, XrefRangeEnd = 35750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CCD RID: 3277 RVA: 0x0007CD30 File Offset: 0x0007AF30
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35769, RefRangeEnd = 35770, XrefRangeStart = 35750, XrefRangeEnd = 35769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hover()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_Hover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CCE RID: 3278 RVA: 0x0007CD64 File Offset: 0x0007AF64
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 35788, RefRangeEnd = 35792, XrefRangeStart = 35770, XrefRangeEnd = 35788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnHover()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_UnHover_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CCF RID: 3279 RVA: 0x0007CD98 File Offset: 0x0007AF98
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 35816, RefRangeEnd = 35818, XrefRangeStart = 35792, XrefRangeEnd = 35816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartDrag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_StartDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CD0 RID: 3280 RVA: 0x0007CDCC File Offset: 0x0007AFCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35818, XrefRangeEnd = 35841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopDrag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_StopDrag_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CD1 RID: 3281 RVA: 0x0007CE00 File Offset: 0x0007B000
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35841, XrefRangeEnd = 35857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CancelDrag()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_CancelDrag_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CD2 RID: 3282 RVA: 0x0007CE34 File Offset: 0x0007B034
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 35876, RefRangeEnd = 35877, XrefRangeStart = 35857, XrefRangeEnd = 35876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PopUpDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_PopUpDescription_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CD3 RID: 3283 RVA: 0x0007CE68 File Offset: 0x0007B068
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35877, XrefRangeEnd = 35884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideDescription()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr_HideDescription_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CD4 RID: 3284 RVA: 0x0007CE9C File Offset: 0x0007B09C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35884, XrefRangeEnd = 35885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardCharmInteraction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000CD5 RID: 3285 RVA: 0x00007AF0 File Offset: 0x00005CF0
	public CardCharmInteraction(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700032C RID: 812
	// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0007CED8 File Offset: 0x0007B0D8
	// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00007AF9 File Offset: 0x00005CF9
	public unsafe GameObject image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700032D RID: 813
	// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x0007CF08 File Offset: 0x0007B108
	// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00007B18 File Offset: 0x00005D18
	public unsafe CardCharmDragHandler dragHandler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_dragHandler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardCharmDragHandler>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_dragHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700032E RID: 814
	// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0007CF38 File Offset: 0x0007B138
	// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00007B37 File Offset: 0x00005D37
	public unsafe bool canHover
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_canHover);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_canHover)) = value;
		}
	}

	// Token: 0x1700032F RID: 815
	// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0007CF60 File Offset: 0x0007B160
	// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00007B52 File Offset: 0x00005D52
	public unsafe bool canDrag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_canDrag);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_canDrag)) = value;
		}
	}

	// Token: 0x17000330 RID: 816
	// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0007CF88 File Offset: 0x0007B188
	// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00007B6D File Offset: 0x00005D6D
	public unsafe bool hover
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_hover);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_hover)) = value;
		}
	}

	// Token: 0x17000331 RID: 817
	// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0007CFB0 File Offset: 0x0007B1B0
	// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00007B88 File Offset: 0x00005D88
	public unsafe bool preHover
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_preHover);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_preHover)) = value;
		}
	}

	// Token: 0x17000332 RID: 818
	// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0007CFD8 File Offset: 0x0007B1D8
	// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00007BA3 File Offset: 0x00005DA3
	public unsafe bool press
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_press);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_press)) = value;
		}
	}

	// Token: 0x17000333 RID: 819
	// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0007D000 File Offset: 0x0007B200
	// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00007BBE File Offset: 0x00005DBE
	public unsafe bool drag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_drag);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_drag)) = value;
		}
	}

	// Token: 0x17000334 RID: 820
	// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0007D028 File Offset: 0x0007B228
	// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00007BD9 File Offset: 0x00005DD9
	public unsafe Vector2 popUpOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_popUpOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_popUpOffset)) = value;
		}
	}

	// Token: 0x17000335 RID: 821
	// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0007D050 File Offset: 0x0007B250
	// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00007BF4 File Offset: 0x00005DF4
	public unsafe UnityEvent<UpgradeDisplay> onHover
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_onHover);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<UpgradeDisplay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_onHover), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000336 RID: 822
	// (get) Token: 0x06000CEA RID: 3306 RVA: 0x0007D080 File Offset: 0x0007B280
	// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00007C13 File Offset: 0x00005E13
	public unsafe UnityEvent<UpgradeDisplay> onUnHover
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_onUnHover);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<UpgradeDisplay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_onUnHover), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000337 RID: 823
	// (get) Token: 0x06000CEC RID: 3308 RVA: 0x0007D0B0 File Offset: 0x0007B2B0
	// (set) Token: 0x06000CED RID: 3309 RVA: 0x00007C32 File Offset: 0x00005E32
	public unsafe UnityEvent<UpgradeDisplay> onDrag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_onDrag);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<UpgradeDisplay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_onDrag), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000338 RID: 824
	// (get) Token: 0x06000CEE RID: 3310 RVA: 0x0007D0E0 File Offset: 0x0007B2E0
	// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00007C51 File Offset: 0x00005E51
	public unsafe UnityEvent<UpgradeDisplay> onDragEnd
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_onDragEnd);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<UpgradeDisplay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr_onDragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000339 RID: 825
	// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0007D110 File Offset: 0x0007B310
	// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00007C70 File Offset: 0x00005E70
	public unsafe UpgradeDisplay _upgradeDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr__upgradeDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpgradeDisplay>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction.NativeFieldInfoPtr__upgradeDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400080F RID: 2063
	private static readonly IntPtr NativeFieldInfoPtr_image;

	// Token: 0x04000810 RID: 2064
	private static readonly IntPtr NativeFieldInfoPtr_dragHandler;

	// Token: 0x04000811 RID: 2065
	private static readonly IntPtr NativeFieldInfoPtr_canHover;

	// Token: 0x04000812 RID: 2066
	private static readonly IntPtr NativeFieldInfoPtr_canDrag;

	// Token: 0x04000813 RID: 2067
	private static readonly IntPtr NativeFieldInfoPtr_hover;

	// Token: 0x04000814 RID: 2068
	private static readonly IntPtr NativeFieldInfoPtr_preHover;

	// Token: 0x04000815 RID: 2069
	private static readonly IntPtr NativeFieldInfoPtr_press;

	// Token: 0x04000816 RID: 2070
	private static readonly IntPtr NativeFieldInfoPtr_drag;

	// Token: 0x04000817 RID: 2071
	private static readonly IntPtr NativeFieldInfoPtr_popUpOffset;

	// Token: 0x04000818 RID: 2072
	private static readonly IntPtr NativeFieldInfoPtr_onHover;

	// Token: 0x04000819 RID: 2073
	private static readonly IntPtr NativeFieldInfoPtr_onUnHover;

	// Token: 0x0400081A RID: 2074
	private static readonly IntPtr NativeFieldInfoPtr_onDrag;

	// Token: 0x0400081B RID: 2075
	private static readonly IntPtr NativeFieldInfoPtr_onDragEnd;

	// Token: 0x0400081C RID: 2076
	private static readonly IntPtr NativeFieldInfoPtr__upgradeDisplay;

	// Token: 0x0400081D RID: 2077
	private static readonly IntPtr NativeMethodInfoPtr_get_upgradeDisplay_Private_get_UpgradeDisplay_0;

	// Token: 0x0400081E RID: 2078
	private static readonly IntPtr NativeMethodInfoPtr_get_DragHandlerDragging_Private_get_Boolean_0;

	// Token: 0x0400081F RID: 2079
	private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

	// Token: 0x04000820 RID: 2080
	private static readonly IntPtr NativeMethodInfoPtr_UpdateInputSystem_Private_IEnumerator_0;

	// Token: 0x04000821 RID: 2081
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000822 RID: 2082
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000823 RID: 2083
	private static readonly IntPtr NativeMethodInfoPtr_Press_Private_Void_0;

	// Token: 0x04000824 RID: 2084
	private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

	// Token: 0x04000825 RID: 2085
	private static readonly IntPtr NativeMethodInfoPtr_Hover_Private_Void_0;

	// Token: 0x04000826 RID: 2086
	private static readonly IntPtr NativeMethodInfoPtr_UnHover_Public_Void_0;

	// Token: 0x04000827 RID: 2087
	private static readonly IntPtr NativeMethodInfoPtr_StartDrag_Private_Void_0;

	// Token: 0x04000828 RID: 2088
	private static readonly IntPtr NativeMethodInfoPtr_StopDrag_Private_Void_0;

	// Token: 0x04000829 RID: 2089
	private static readonly IntPtr NativeMethodInfoPtr_CancelDrag_Public_Void_0;

	// Token: 0x0400082A RID: 2090
	private static readonly IntPtr NativeMethodInfoPtr_PopUpDescription_Public_Void_0;

	// Token: 0x0400082B RID: 2091
	private static readonly IntPtr NativeMethodInfoPtr_HideDescription_Public_Void_0;

	// Token: 0x0400082C RID: 2092
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000592 RID: 1426
	[ObfuscatedName("CardCharmInteraction+<UpdateInputSystem>d__19")]
	public sealed class _UpdateInputSystem_d__19 : Il2CppSystem.Object
	{
		// Token: 0x060068BB RID: 26811 RVA: 0x001A1A38 File Offset: 0x0019FC38
		// Note: this type is marked as 'beforefieldinit'.
		static _UpdateInputSystem_d__19()
		{
			Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardCharmInteraction>.NativeClassPtr, "<UpdateInputSystem>d__19");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr);
			CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, "<>1__state");
			CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, "<>2__current");
			CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, "<>4__this");
			CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, 100665660);
			CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, 100665661);
			CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, 100665662);
			CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, 100665663);
			CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, 100665664);
			CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr, 100665665);
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x001A1B18 File Offset: 0x0019FD18
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _UpdateInputSystem_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmInteraction._UpdateInputSystem_d__19>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x001A1B60 File Offset: 0x0019FD60
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x001A1B94 File Offset: 0x0019FD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35647, XrefRangeEnd = 35649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x060068BF RID: 26815 RVA: 0x001A1BD0 File Offset: 0x0019FDD0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x001A1C10 File Offset: 0x0019FE10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35649, XrefRangeEnd = 35659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x060068C1 RID: 26817 RVA: 0x001A1C44 File Offset: 0x0019FE44
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmInteraction._UpdateInputSystem_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x000338FA File Offset: 0x00031AFA
		public _UpdateInputSystem_d__19(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x060068C3 RID: 26819 RVA: 0x001A1C84 File Offset: 0x0019FE84
		// (set) Token: 0x060068C4 RID: 26820 RVA: 0x00033903 File Offset: 0x00031B03
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x060068C5 RID: 26821 RVA: 0x001A1CAC File Offset: 0x0019FEAC
		// (set) Token: 0x060068C6 RID: 26822 RVA: 0x0003391E File Offset: 0x00031B1E
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x060068C7 RID: 26823 RVA: 0x001A1CDC File Offset: 0x0019FEDC
		// (set) Token: 0x060068C8 RID: 26824 RVA: 0x0003393D File Offset: 0x00031B3D
		public unsafe CardCharmInteraction __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardCharmInteraction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmInteraction._UpdateInputSystem_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004449 RID: 17481
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400444A RID: 17482
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400444B RID: 17483
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400444C RID: 17484
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400444D RID: 17485
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400444E RID: 17486
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400444F RID: 17487
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004450 RID: 17488
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004451 RID: 17489
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

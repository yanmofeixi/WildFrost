using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000120 RID: 288
public class CardCharmHolder : UpgradeHolder
{
	// Token: 0x060011B0 RID: 4528 RVA: 0x0008AFD4 File Offset: 0x000891D4
	// Note: this type is marked as 'beforefieldinit'.
	static CardCharmHolder()
	{
		Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardCharmHolder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr);
		CardCharmHolder.NativeFieldInfoPtr_angleAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, "angleAdd");
		CardCharmHolder.NativeFieldInfoPtr_charmPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, "charmPivot");
		CardCharmHolder.NativeFieldInfoPtr_ropeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, "ropeImage");
		CardCharmHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666684);
		CardCharmHolder.NativeMethodInfoPtr_CalculateSiblingIndex_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666685);
		CardCharmHolder.NativeMethodInfoPtr_Add_Public_Virtual_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666686);
		CardCharmHolder.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666687);
		CardCharmHolder.NativeMethodInfoPtr_CharmAdded_Private_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666688);
		CardCharmHolder.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666689);
		CardCharmHolder.NativeMethodInfoPtr_SetInputOverrides_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666690);
		CardCharmHolder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr, 100666691);
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x0008B0E0 File Offset: 0x000892E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44907, XrefRangeEnd = 44919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetPositions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardCharmHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x0008B11C File Offset: 0x0008931C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 44924, RefRangeEnd = 44925, XrefRangeStart = 44919, XrefRangeEnd = 44924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CalculateSiblingIndex(int listIndex, int listLength)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref listIndex;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref listLength;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmHolder.NativeMethodInfoPtr_CalculateSiblingIndex_Private_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x0008B168 File Offset: 0x00089368
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44925, XrefRangeEnd = 44926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Add(UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardCharmHolder.NativeMethodInfoPtr_Add_Public_Virtual_Void_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x0008B1B8 File Offset: 0x000893B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44926, XrefRangeEnd = 44942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Insert(int index, UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref index;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardCharmHolder.NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x0008B214 File Offset: 0x00089414
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 44951, RefRangeEnd = 44953, XrefRangeStart = 44942, XrefRangeEnd = 44951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CharmAdded(UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmHolder.NativeMethodInfoPtr_CharmAdded_Private_Void_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x0008B258 File Offset: 0x00089458
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44953, XrefRangeEnd = 44959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardCharmHolder.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x0008B294 File Offset: 0x00089494
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44959, XrefRangeEnd = 44972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetInputOverrides()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardCharmHolder.NativeMethodInfoPtr_SetInputOverrides_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x0008B2D0 File Offset: 0x000894D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44972, XrefRangeEnd = 44973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardCharmHolder() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharmHolder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharmHolder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x0000A712 File Offset: 0x00008912
	public CardCharmHolder(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x060011BA RID: 4538 RVA: 0x0008B30C File Offset: 0x0008950C
	// (set) Token: 0x060011BB RID: 4539 RVA: 0x0000A71B File Offset: 0x0000891B
	public unsafe float angleAdd
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_angleAdd);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_angleAdd)) = value;
		}
	}

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x060011BC RID: 4540 RVA: 0x0008B334 File Offset: 0x00089534
	// (set) Token: 0x060011BD RID: 4541 RVA: 0x0000A736 File Offset: 0x00008936
	public unsafe Vector2 charmPivot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_charmPivot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_charmPivot)) = value;
		}
	}

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x060011BE RID: 4542 RVA: 0x0008B35C File Offset: 0x0008955C
	// (set) Token: 0x060011BF RID: 4543 RVA: 0x0000A751 File Offset: 0x00008951
	public unsafe Image ropeImage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_ropeImage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharmHolder.NativeFieldInfoPtr_ropeImage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000B14 RID: 2836
	private static readonly IntPtr NativeFieldInfoPtr_angleAdd;

	// Token: 0x04000B15 RID: 2837
	private static readonly IntPtr NativeFieldInfoPtr_charmPivot;

	// Token: 0x04000B16 RID: 2838
	private static readonly IntPtr NativeFieldInfoPtr_ropeImage;

	// Token: 0x04000B17 RID: 2839
	private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Virtual_Void_0;

	// Token: 0x04000B18 RID: 2840
	private static readonly IntPtr NativeMethodInfoPtr_CalculateSiblingIndex_Private_Static_Int32_Int32_Int32_0;

	// Token: 0x04000B19 RID: 2841
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Void_UpgradeDisplay_0;

	// Token: 0x04000B1A RID: 2842
	private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_Void_Int32_UpgradeDisplay_0;

	// Token: 0x04000B1B RID: 2843
	private static readonly IntPtr NativeMethodInfoPtr_CharmAdded_Private_Void_UpgradeDisplay_0;

	// Token: 0x04000B1C RID: 2844
	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;

	// Token: 0x04000B1D RID: 2845
	private static readonly IntPtr NativeMethodInfoPtr_SetInputOverrides_Public_Virtual_Void_0;

	// Token: 0x04000B1E RID: 2846
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

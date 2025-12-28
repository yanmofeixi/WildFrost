using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

// Token: 0x02000122 RID: 290
public class UpgradeHolder : MonoBehaviour
{
	// Token: 0x060011D0 RID: 4560 RVA: 0x0008B620 File Offset: 0x00089820
	// Note: this type is marked as 'beforefieldinit'.
	static UpgradeHolder()
	{
		Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UpgradeHolder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr);
		UpgradeHolder.NativeFieldInfoPtr_prefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, "prefabRef");
		UpgradeHolder.NativeFieldInfoPtr_dragHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, "dragHandler");
		UpgradeHolder.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, "list");
		UpgradeHolder.NativeFieldInfoPtr_autoUpdateOverrideInputs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, "autoUpdateOverrideInputs");
		UpgradeHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666696);
		UpgradeHolder.NativeMethodInfoPtr_Create_Public_Virtual_New_UpgradeDisplay_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666697);
		UpgradeHolder.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666698);
		UpgradeHolder.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666699);
		UpgradeHolder.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666700);
		UpgradeHolder.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666701);
		UpgradeHolder.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666702);
		UpgradeHolder.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666703);
		UpgradeHolder.NativeMethodInfoPtr_SetInputOverrides_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666704);
		UpgradeHolder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, 100666705);
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x0008B768 File Offset: 0x00089968
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45069, XrefRangeEnd = 45091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetPositions()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_SetPositions_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x0008B7A4 File Offset: 0x000899A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45091, XrefRangeEnd = 45129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual UpgradeDisplay Create(CardUpgradeData upgradeData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_Create_Public_Virtual_New_UpgradeDisplay_CardUpgradeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<UpgradeDisplay>(intPtr3) : null;
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x0008B800 File Offset: 0x00089A00
	[CallerCount(0)]
	public unsafe virtual void Add(UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_Add_Public_Virtual_New_Void_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x0008B850 File Offset: 0x00089A50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45129, XrefRangeEnd = 45143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Insert(int index, UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref index;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x0008B8AC File Offset: 0x00089AAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45143, XrefRangeEnd = 45148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Remove(UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x0008B8FC File Offset: 0x00089AFC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45148, XrefRangeEnd = 45166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Remove(CardUpgradeData upgradeData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgradeData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_CardUpgradeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x0008B94C File Offset: 0x00089B4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45166, XrefRangeEnd = 45170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual int IndexOf(UpgradeDisplay upgrade)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(upgrade);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_UpgradeDisplay_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x0008B9A4 File Offset: 0x00089BA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45170, XrefRangeEnd = 45175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Clear()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x0008B9E0 File Offset: 0x00089BE0
	[CallerCount(0)]
	public unsafe virtual void SetInputOverrides()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UpgradeHolder.NativeMethodInfoPtr_SetInputOverrides_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x0008BA1C File Offset: 0x00089C1C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 45199, RefRangeEnd = 45201, XrefRangeStart = 45175, XrefRangeEnd = 45199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UpgradeHolder() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpgradeHolder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x0000A800 File Offset: 0x00008A00
	public UpgradeHolder(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x060011DC RID: 4572 RVA: 0x0008BA58 File Offset: 0x00089C58
	// (set) Token: 0x060011DD RID: 4573 RVA: 0x0000A809 File Offset: 0x00008A09
	public unsafe AssetReference prefabRef
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_prefabRef);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_prefabRef), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x060011DE RID: 4574 RVA: 0x0008BA88 File Offset: 0x00089C88
	// (set) Token: 0x060011DF RID: 4575 RVA: 0x0000A828 File Offset: 0x00008A28
	public unsafe CardCharmDragHandler dragHandler
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_dragHandler);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardCharmDragHandler>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_dragHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0008BAB8 File Offset: 0x00089CB8
	// (set) Token: 0x060011E1 RID: 4577 RVA: 0x0000A847 File Offset: 0x00008A47
	public unsafe List<UpgradeDisplay> list
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_list);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UpgradeDisplay>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0008BAE8 File Offset: 0x00089CE8
	// (set) Token: 0x060011E3 RID: 4579 RVA: 0x0000A866 File Offset: 0x00008A66
	public unsafe bool autoUpdateOverrideInputs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_autoUpdateOverrideInputs);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.NativeFieldInfoPtr_autoUpdateOverrideInputs)) = value;
		}
	}

	// Token: 0x04000B28 RID: 2856
	private static readonly IntPtr NativeFieldInfoPtr_prefabRef;

	// Token: 0x04000B29 RID: 2857
	private static readonly IntPtr NativeFieldInfoPtr_dragHandler;

	// Token: 0x04000B2A RID: 2858
	private static readonly IntPtr NativeFieldInfoPtr_list;

	// Token: 0x04000B2B RID: 2859
	private static readonly IntPtr NativeFieldInfoPtr_autoUpdateOverrideInputs;

	// Token: 0x04000B2C RID: 2860
	private static readonly IntPtr NativeMethodInfoPtr_SetPositions_Public_Virtual_New_Void_0;

	// Token: 0x04000B2D RID: 2861
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_New_UpgradeDisplay_CardUpgradeData_0;

	// Token: 0x04000B2E RID: 2862
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_New_Void_UpgradeDisplay_0;

	// Token: 0x04000B2F RID: 2863
	private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Virtual_New_Void_Int32_UpgradeDisplay_0;

	// Token: 0x04000B30 RID: 2864
	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_UpgradeDisplay_0;

	// Token: 0x04000B31 RID: 2865
	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_New_Void_CardUpgradeData_0;

	// Token: 0x04000B32 RID: 2866
	private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Virtual_New_Int32_UpgradeDisplay_0;

	// Token: 0x04000B33 RID: 2867
	private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;

	// Token: 0x04000B34 RID: 2868
	private static readonly IntPtr NativeMethodInfoPtr_SetInputOverrides_Public_Abstract_Virtual_New_Void_0;

	// Token: 0x04000B35 RID: 2869
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	// Token: 0x020005FA RID: 1530
	[ObfuscatedName("UpgradeHolder+<>c__DisplayClass9_0")]
	public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
	{
		// Token: 0x06006C80 RID: 27776 RVA: 0x001AED64 File Offset: 0x001ACF64
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass9_0()
		{
			Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpgradeHolder>.NativeClassPtr, "<>c__DisplayClass9_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass9_0>.NativeClassPtr);
			UpgradeHolder.__c__DisplayClass9_0.NativeFieldInfoPtr_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass9_0>.NativeClassPtr, "upgradeData");
			UpgradeHolder.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass9_0>.NativeClassPtr, 100666706);
			UpgradeHolder.__c__DisplayClass9_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_UpgradeDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass9_0>.NativeClassPtr, 100666707);
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x001AEDCC File Offset: 0x001ACFCC
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpgradeHolder.__c__DisplayClass9_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpgradeHolder.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x001AEE08 File Offset: 0x001AD008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45024, XrefRangeEnd = 45069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Remove_b__0(UpgradeDisplay a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpgradeHolder.__c__DisplayClass9_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_UpgradeDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x00034E28 File Offset: 0x00033028
		public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002158 RID: 8536
		// (get) Token: 0x06006C84 RID: 27780 RVA: 0x001AEE58 File Offset: 0x001AD058
		// (set) Token: 0x06006C85 RID: 27781 RVA: 0x00034E31 File Offset: 0x00033031
		public unsafe CardUpgradeData upgradeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.__c__DisplayClass9_0.NativeFieldInfoPtr_upgradeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardUpgradeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpgradeHolder.__c__DisplayClass9_0.NativeFieldInfoPtr_upgradeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046BE RID: 18110
		private static readonly IntPtr NativeFieldInfoPtr_upgradeData;

		// Token: 0x040046BF RID: 18111
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040046C0 RID: 18112
		private static readonly IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_UpgradeDisplay_0;
	}
}

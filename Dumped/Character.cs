using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x020000FD RID: 253
public class Character : MonoBehaviour
{
	// Token: 0x06000E7C RID: 3708 RVA: 0x00081BA0 File Offset: 0x0007FDA0
	// Note: this type is marked as 'beforefieldinit'.
	static Character()
	{
		Il2CppClassPointerStore<Character>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Character");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Character>.NativeClassPtr);
		Character.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "data");
		Character.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "title");
		Character.NativeFieldInfoPtr_team = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "team");
		Character.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "entity");
		Character.NativeFieldInfoPtr_drawContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "drawContainer");
		Character.NativeFieldInfoPtr_handContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "handContainer");
		Character.NativeFieldInfoPtr_discardContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "discardContainer");
		Character.NativeFieldInfoPtr_reserveContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "reserveContainer");
		Character.NativeFieldInfoPtr_freeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "freeAction");
		Character.NativeFieldInfoPtr_endTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "endTurn");
		Character.NativeFieldInfoPtr_autoTriggerUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character>.NativeClassPtr, "autoTriggerUnits");
		Character.NativeMethodInfoPtr_Assign_Public_Void_PlayerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665883);
		Character.NativeMethodInfoPtr_GetCompanionCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665884);
		Character.NativeMethodInfoPtr_GainGold_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665885);
		Character.NativeMethodInfoPtr_SpendGold_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665886);
		Character.NativeMethodInfoPtr_Gain10Gold_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665887);
		Character.NativeMethodInfoPtr_Gain100Gold_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665888);
		Character.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CharacterSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665889);
		Character.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665890);
		Character.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character>.NativeClassPtr, 100665891);
	}

	// Token: 0x06000E7D RID: 3709 RVA: 0x00081D60 File Offset: 0x0007FF60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38027, XrefRangeEnd = 38028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Assign(PlayerData data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_Assign_Public_Void_PlayerData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E7E RID: 3710 RVA: 0x00081DA4 File Offset: 0x0007FFA4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 38045, RefRangeEnd = 38048, XrefRangeStart = 38028, XrefRangeEnd = 38045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetCompanionCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_GetCompanionCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000E7F RID: 3711 RVA: 0x00081DE0 File Offset: 0x0007FFE0
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 38055, RefRangeEnd = 38061, XrefRangeStart = 38048, XrefRangeEnd = 38055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GainGold(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_GainGold_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E80 RID: 3712 RVA: 0x00081E20 File Offset: 0x00080020
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 38069, RefRangeEnd = 38073, XrefRangeStart = 38061, XrefRangeEnd = 38069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SpendGold(int amount)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref amount;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_SpendGold_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E81 RID: 3713 RVA: 0x00081E60 File Offset: 0x00080060
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38073, XrefRangeEnd = 38074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Gain10Gold()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_Gain10Gold_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E82 RID: 3714 RVA: 0x00081E94 File Offset: 0x00080094
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38074, XrefRangeEnd = 38075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Gain100Gold()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_Gain100Gold_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E83 RID: 3715 RVA: 0x00081EC8 File Offset: 0x000800C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38075, XrefRangeEnd = 38079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual CharacterSaveData Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CharacterSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSaveData>(intPtr3) : null;
	}

	// Token: 0x06000E84 RID: 3716 RVA: 0x00081F08 File Offset: 0x00080108
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38079, XrefRangeEnd = 38082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Il2CppSystem.Object other)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Character.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000E85 RID: 3717 RVA: 0x00081F60 File Offset: 0x00080160
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38082, XrefRangeEnd = 38083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Character() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Character>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E86 RID: 3718 RVA: 0x0000899C File Offset: 0x00006B9C
	public Character(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170003B5 RID: 949
	// (get) Token: 0x06000E87 RID: 3719 RVA: 0x00081F9C File Offset: 0x0008019C
	// (set) Token: 0x06000E88 RID: 3720 RVA: 0x000089A5 File Offset: 0x00006BA5
	public unsafe PlayerData data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B6 RID: 950
	// (get) Token: 0x06000E89 RID: 3721 RVA: 0x00081FCC File Offset: 0x000801CC
	// (set) Token: 0x06000E8A RID: 3722 RVA: 0x000089C4 File Offset: 0x00006BC4
	public unsafe string title
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_title);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170003B7 RID: 951
	// (get) Token: 0x06000E8B RID: 3723 RVA: 0x00081FF4 File Offset: 0x000801F4
	// (set) Token: 0x06000E8C RID: 3724 RVA: 0x000089E3 File Offset: 0x00006BE3
	public unsafe int team
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_team);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_team)) = value;
		}
	}

	// Token: 0x170003B8 RID: 952
	// (get) Token: 0x06000E8D RID: 3725 RVA: 0x0008201C File Offset: 0x0008021C
	// (set) Token: 0x06000E8E RID: 3726 RVA: 0x000089FE File Offset: 0x00006BFE
	public unsafe Entity entity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_entity);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003B9 RID: 953
	// (get) Token: 0x06000E8F RID: 3727 RVA: 0x0008204C File Offset: 0x0008024C
	// (set) Token: 0x06000E90 RID: 3728 RVA: 0x00008A1D File Offset: 0x00006C1D
	public unsafe CardContainer drawContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_drawContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_drawContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BA RID: 954
	// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0008207C File Offset: 0x0008027C
	// (set) Token: 0x06000E92 RID: 3730 RVA: 0x00008A3C File Offset: 0x00006C3C
	public unsafe CardContainer handContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_handContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_handContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BB RID: 955
	// (get) Token: 0x06000E93 RID: 3731 RVA: 0x000820AC File Offset: 0x000802AC
	// (set) Token: 0x06000E94 RID: 3732 RVA: 0x00008A5B File Offset: 0x00006C5B
	public unsafe CardContainer discardContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_discardContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_discardContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BC RID: 956
	// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000820DC File Offset: 0x000802DC
	// (set) Token: 0x06000E96 RID: 3734 RVA: 0x00008A7A File Offset: 0x00006C7A
	public unsafe CardContainer reserveContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_reserveContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_reserveContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170003BD RID: 957
	// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0008210C File Offset: 0x0008030C
	// (set) Token: 0x06000E98 RID: 3736 RVA: 0x00008A99 File Offset: 0x00006C99
	public unsafe bool freeAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_freeAction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_freeAction)) = value;
		}
	}

	// Token: 0x170003BE RID: 958
	// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00082134 File Offset: 0x00080334
	// (set) Token: 0x06000E9A RID: 3738 RVA: 0x00008AB4 File Offset: 0x00006CB4
	public unsafe bool endTurn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_endTurn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_endTurn)) = value;
		}
	}

	// Token: 0x170003BF RID: 959
	// (get) Token: 0x06000E9B RID: 3739 RVA: 0x0008215C File Offset: 0x0008035C
	// (set) Token: 0x06000E9C RID: 3740 RVA: 0x00008ACF File Offset: 0x00006CCF
	public unsafe bool autoTriggerUnits
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_autoTriggerUnits);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Character.NativeFieldInfoPtr_autoTriggerUnits)) = value;
		}
	}

	// Token: 0x04000924 RID: 2340
	private static readonly IntPtr NativeFieldInfoPtr_data;

	// Token: 0x04000925 RID: 2341
	private static readonly IntPtr NativeFieldInfoPtr_title;

	// Token: 0x04000926 RID: 2342
	private static readonly IntPtr NativeFieldInfoPtr_team;

	// Token: 0x04000927 RID: 2343
	private static readonly IntPtr NativeFieldInfoPtr_entity;

	// Token: 0x04000928 RID: 2344
	private static readonly IntPtr NativeFieldInfoPtr_drawContainer;

	// Token: 0x04000929 RID: 2345
	private static readonly IntPtr NativeFieldInfoPtr_handContainer;

	// Token: 0x0400092A RID: 2346
	private static readonly IntPtr NativeFieldInfoPtr_discardContainer;

	// Token: 0x0400092B RID: 2347
	private static readonly IntPtr NativeFieldInfoPtr_reserveContainer;

	// Token: 0x0400092C RID: 2348
	private static readonly IntPtr NativeFieldInfoPtr_freeAction;

	// Token: 0x0400092D RID: 2349
	private static readonly IntPtr NativeFieldInfoPtr_endTurn;

	// Token: 0x0400092E RID: 2350
	private static readonly IntPtr NativeFieldInfoPtr_autoTriggerUnits;

	// Token: 0x0400092F RID: 2351
	private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_PlayerData_0;

	// Token: 0x04000930 RID: 2352
	private static readonly IntPtr NativeMethodInfoPtr_GetCompanionCount_Public_Int32_0;

	// Token: 0x04000931 RID: 2353
	private static readonly IntPtr NativeMethodInfoPtr_GainGold_Public_Void_Int32_0;

	// Token: 0x04000932 RID: 2354
	private static readonly IntPtr NativeMethodInfoPtr_SpendGold_Public_Void_Int32_0;

	// Token: 0x04000933 RID: 2355
	private static readonly IntPtr NativeMethodInfoPtr_Gain10Gold_Public_Void_0;

	// Token: 0x04000934 RID: 2356
	private static readonly IntPtr NativeMethodInfoPtr_Gain100Gold_Public_Void_0;

	// Token: 0x04000935 RID: 2357
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CharacterSaveData_0;

	// Token: 0x04000936 RID: 2358
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x04000937 RID: 2359
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020005A5 RID: 1445
	[ObfuscatedName("Character+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x060069A6 RID: 27046 RVA: 0x001A471C File Offset: 0x001A291C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<Character.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Character>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Character.__c>.NativeClassPtr);
			Character.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character.__c>.NativeClassPtr, "<>9");
			Character.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Character.__c>.NativeClassPtr, "<>9__12_0");
			Character.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character.__c>.NativeClassPtr, 100665893);
			Character.__c.NativeMethodInfoPtr__GetCompanionCount_b__12_0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Character.__c>.NativeClassPtr, 100665894);
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x001A4798 File Offset: 0x001A2998
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Character.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x001A47D4 File Offset: 0x001A29D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38022, XrefRangeEnd = 38027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetCompanionCount_b__12_0(CardData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Character.__c.NativeMethodInfoPtr__GetCompanionCount_b__12_0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x0003404D File Offset: 0x0003224D
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x060069AA RID: 27050 RVA: 0x001A4824 File Offset: 0x001A2A24
		// (set) Token: 0x060069AB RID: 27051 RVA: 0x00034056 File Offset: 0x00032256
		public unsafe static Character.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Character.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Character.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002067 RID: 8295
		// (get) Token: 0x060069AC RID: 27052 RVA: 0x001A484C File Offset: 0x001A2A4C
		// (set) Token: 0x060069AD RID: 27053 RVA: 0x00034068 File Offset: 0x00032268
		public unsafe static Predicate<CardData> __9__12_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Character.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<CardData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Character.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040044DC RID: 17628
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040044DD RID: 17629
		private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

		// Token: 0x040044DE RID: 17630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040044DF RID: 17631
		private static readonly IntPtr NativeMethodInfoPtr__GetCompanionCount_b__12_0_Internal_Boolean_CardData_0;
	}
}

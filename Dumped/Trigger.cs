using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x02000328 RID: 808
public class Trigger : Object
{
	// Token: 0x06003D3E RID: 15678 RVA: 0x0010D8B8 File Offset: 0x0010BAB8
	// Note: this type is marked as 'beforefieldinit'.
	static Trigger()
	{
		Il2CppClassPointerStore<Trigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Trigger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger>.NativeClassPtr);
		Trigger.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "entity");
		Trigger.NativeFieldInfoPtr_triggeredBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "triggeredBy");
		Trigger.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "targets");
		Trigger.NativeFieldInfoPtr_nullified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "nullified");
		Trigger.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "hits");
		Trigger.NativeFieldInfoPtr_countsAsTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "countsAsTrigger");
		Trigger.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "type");
		Trigger.NativeFieldInfoPtr_triggerAgainst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "triggerAgainst");
		Trigger.NativeFieldInfoPtr_triggerAgainstTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "triggerAgainstTarget");
		Trigger.NativeFieldInfoPtr_triggerAgainstContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "triggerAgainstContainer");
		Trigger.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_String_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672986);
		Trigger.NativeMethodInfoPtr_Process_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672987);
		Trigger.NativeMethodInfoPtr_PreProcess_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672988);
		Trigger.NativeMethodInfoPtr_Animate_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672989);
		Trigger.NativeMethodInfoPtr_ProcessHits_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672990);
		Trigger.NativeMethodInfoPtr_PostProcess_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672991);
		Trigger.NativeMethodInfoPtr_ProcessHit_Protected_Static_IEnumerator_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672992);
		Trigger.NativeMethodInfoPtr_GetTargetRow_Public_Static_CardContainer_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672993);
		Trigger.NativeMethodInfoPtr_GetRowIndices_Private_Static_Il2CppStructArray_1_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger>.NativeClassPtr, 100672994);
	}

	// Token: 0x06003D3F RID: 15679 RVA: 0x0010DA64 File Offset: 0x0010BC64
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 107196, RefRangeEnd = 107201, XrefRangeStart = 107187, XrefRangeEnd = 107196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Trigger(Entity entity, Entity triggeredBy, string type, Il2CppReferenceArray<Entity> targets) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggeredBy);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targets);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_String_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003D40 RID: 15680 RVA: 0x0010DAE8 File Offset: 0x0010BCE8
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 107206, RefRangeEnd = 107210, XrefRangeStart = 107201, XrefRangeEnd = 107206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Process()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.NativeMethodInfoPtr_Process_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06003D41 RID: 15681 RVA: 0x0010DB28 File Offset: 0x0010BD28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107210, XrefRangeEnd = 107215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator PreProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Trigger.NativeMethodInfoPtr_PreProcess_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06003D42 RID: 15682 RVA: 0x0010DB74 File Offset: 0x0010BD74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107215, XrefRangeEnd = 107220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator Animate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Trigger.NativeMethodInfoPtr_Animate_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06003D43 RID: 15683 RVA: 0x0010DBC0 File Offset: 0x0010BDC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107220, XrefRangeEnd = 107225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator ProcessHits()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Trigger.NativeMethodInfoPtr_ProcessHits_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06003D44 RID: 15684 RVA: 0x0010DC0C File Offset: 0x0010BE0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107225, XrefRangeEnd = 107230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator PostProcess()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Trigger.NativeMethodInfoPtr_PostProcess_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06003D45 RID: 15685 RVA: 0x0010DC58 File Offset: 0x0010BE58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107230, XrefRangeEnd = 107235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator ProcessHit(Hit hit)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.NativeMethodInfoPtr_ProcessHit_Protected_Static_IEnumerator_Hit_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06003D46 RID: 15686 RVA: 0x0010DC9C File Offset: 0x0010BE9C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107266, RefRangeEnd = 107268, XrefRangeStart = 107235, XrefRangeEnd = 107266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CardContainer GetTargetRow(Entity attacker, Entity target)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(attacker);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.NativeMethodInfoPtr_GetTargetRow_Public_Static_CardContainer_Entity_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr3) : null;
	}

	// Token: 0x06003D47 RID: 15687 RVA: 0x0010DCF4 File Offset: 0x0010BEF4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 107278, RefRangeEnd = 107280, XrefRangeStart = 107268, XrefRangeEnd = 107278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStructArray<int> GetRowIndices(Entity entity)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.NativeMethodInfoPtr_GetRowIndices_Private_Static_Il2CppStructArray_1_Int32_Entity_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
	}

	// Token: 0x06003D48 RID: 15688 RVA: 0x000225E0 File Offset: 0x000207E0
	public Trigger(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17001229 RID: 4649
	// (get) Token: 0x06003D49 RID: 15689 RVA: 0x0010DD38 File Offset: 0x0010BF38
	// (set) Token: 0x06003D4A RID: 15690 RVA: 0x000225E9 File Offset: 0x000207E9
	public unsafe Entity entity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_entity);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700122A RID: 4650
	// (get) Token: 0x06003D4B RID: 15691 RVA: 0x0010DD68 File Offset: 0x0010BF68
	// (set) Token: 0x06003D4C RID: 15692 RVA: 0x00022608 File Offset: 0x00020808
	public unsafe Entity triggeredBy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_triggeredBy);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_triggeredBy), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700122B RID: 4651
	// (get) Token: 0x06003D4D RID: 15693 RVA: 0x0010DD98 File Offset: 0x0010BF98
	// (set) Token: 0x06003D4E RID: 15694 RVA: 0x00022627 File Offset: 0x00020827
	public unsafe Il2CppReferenceArray<Entity> targets
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_targets);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700122C RID: 4652
	// (get) Token: 0x06003D4F RID: 15695 RVA: 0x0010DDC8 File Offset: 0x0010BFC8
	// (set) Token: 0x06003D50 RID: 15696 RVA: 0x00022646 File Offset: 0x00020846
	public unsafe bool nullified
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_nullified);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_nullified)) = value;
		}
	}

	// Token: 0x1700122D RID: 4653
	// (get) Token: 0x06003D51 RID: 15697 RVA: 0x0010DDF0 File Offset: 0x0010BFF0
	// (set) Token: 0x06003D52 RID: 15698 RVA: 0x00022661 File Offset: 0x00020861
	public unsafe Il2CppReferenceArray<Hit> hits
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_hits);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Hit>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700122E RID: 4654
	// (get) Token: 0x06003D53 RID: 15699 RVA: 0x0010DE20 File Offset: 0x0010C020
	// (set) Token: 0x06003D54 RID: 15700 RVA: 0x00022680 File Offset: 0x00020880
	public unsafe bool countsAsTrigger
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_countsAsTrigger);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_countsAsTrigger)) = value;
		}
	}

	// Token: 0x1700122F RID: 4655
	// (get) Token: 0x06003D55 RID: 15701 RVA: 0x0010DE48 File Offset: 0x0010C048
	// (set) Token: 0x06003D56 RID: 15702 RVA: 0x0002269B File Offset: 0x0002089B
	public unsafe string type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_type);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_type), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001230 RID: 4656
	// (get) Token: 0x06003D57 RID: 15703 RVA: 0x0010DE70 File Offset: 0x0010C070
	// (set) Token: 0x06003D58 RID: 15704 RVA: 0x000226BA File Offset: 0x000208BA
	public unsafe bool triggerAgainst
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_triggerAgainst);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_triggerAgainst)) = value;
		}
	}

	// Token: 0x17001231 RID: 4657
	// (get) Token: 0x06003D59 RID: 15705 RVA: 0x0010DE98 File Offset: 0x0010C098
	// (set) Token: 0x06003D5A RID: 15706 RVA: 0x000226D5 File Offset: 0x000208D5
	public unsafe Entity triggerAgainstTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_triggerAgainstTarget);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_triggerAgainstTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001232 RID: 4658
	// (get) Token: 0x06003D5B RID: 15707 RVA: 0x0010DEC8 File Offset: 0x0010C0C8
	// (set) Token: 0x06003D5C RID: 15708 RVA: 0x000226F4 File Offset: 0x000208F4
	public unsafe CardContainer triggerAgainstContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_triggerAgainstContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger.NativeFieldInfoPtr_triggerAgainstContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04002620 RID: 9760
	private static readonly IntPtr NativeFieldInfoPtr_entity;

	// Token: 0x04002621 RID: 9761
	private static readonly IntPtr NativeFieldInfoPtr_triggeredBy;

	// Token: 0x04002622 RID: 9762
	private static readonly IntPtr NativeFieldInfoPtr_targets;

	// Token: 0x04002623 RID: 9763
	private static readonly IntPtr NativeFieldInfoPtr_nullified;

	// Token: 0x04002624 RID: 9764
	private static readonly IntPtr NativeFieldInfoPtr_hits;

	// Token: 0x04002625 RID: 9765
	private static readonly IntPtr NativeFieldInfoPtr_countsAsTrigger;

	// Token: 0x04002626 RID: 9766
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x04002627 RID: 9767
	private static readonly IntPtr NativeFieldInfoPtr_triggerAgainst;

	// Token: 0x04002628 RID: 9768
	private static readonly IntPtr NativeFieldInfoPtr_triggerAgainstTarget;

	// Token: 0x04002629 RID: 9769
	private static readonly IntPtr NativeFieldInfoPtr_triggerAgainstContainer;

	// Token: 0x0400262A RID: 9770
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_String_Il2CppReferenceArray_1_Entity_0;

	// Token: 0x0400262B RID: 9771
	private static readonly IntPtr NativeMethodInfoPtr_Process_Public_IEnumerator_0;

	// Token: 0x0400262C RID: 9772
	private static readonly IntPtr NativeMethodInfoPtr_PreProcess_Protected_Virtual_New_IEnumerator_0;

	// Token: 0x0400262D RID: 9773
	private static readonly IntPtr NativeMethodInfoPtr_Animate_Protected_Virtual_New_IEnumerator_0;

	// Token: 0x0400262E RID: 9774
	private static readonly IntPtr NativeMethodInfoPtr_ProcessHits_Protected_Virtual_New_IEnumerator_0;

	// Token: 0x0400262F RID: 9775
	private static readonly IntPtr NativeMethodInfoPtr_PostProcess_Protected_Virtual_New_IEnumerator_0;

	// Token: 0x04002630 RID: 9776
	private static readonly IntPtr NativeMethodInfoPtr_ProcessHit_Protected_Static_IEnumerator_Hit_0;

	// Token: 0x04002631 RID: 9777
	private static readonly IntPtr NativeMethodInfoPtr_GetTargetRow_Public_Static_CardContainer_Entity_Entity_0;

	// Token: 0x04002632 RID: 9778
	private static readonly IntPtr NativeMethodInfoPtr_GetRowIndices_Private_Static_Il2CppStructArray_1_Int32_Entity_0;

	// Token: 0x02000861 RID: 2145
	[ObfuscatedName("Trigger+<Process>d__11")]
	public sealed class _Process_d__11 : Object
	{
		// Token: 0x0600897F RID: 35199 RVA: 0x00204888 File Offset: 0x00202A88
		// Note: this type is marked as 'beforefieldinit'.
		static _Process_d__11()
		{
			Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "<Process>d__11");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr);
			Trigger._Process_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, "<>1__state");
			Trigger._Process_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, "<>2__current");
			Trigger._Process_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, "<>4__this");
			Trigger._Process_d__11.NativeFieldInfoPtr__attackerString_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, "<attackerString>5__2");
			Trigger._Process_d__11.NativeFieldInfoPtr__targetsString_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, "<targetsString>5__3");
			Trigger._Process_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, 100672995);
			Trigger._Process_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, 100672996);
			Trigger._Process_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, 100672997);
			Trigger._Process_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, 100672998);
			Trigger._Process_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, 100672999);
			Trigger._Process_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr, 100673000);
		}

		// Token: 0x06008980 RID: 35200 RVA: 0x00204990 File Offset: 0x00202B90
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Process_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger._Process_d__11>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Process_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008981 RID: 35201 RVA: 0x002049D8 File Offset: 0x00202BD8
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Process_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008982 RID: 35202 RVA: 0x00204A0C File Offset: 0x00202C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107041, XrefRangeEnd = 107057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Process_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x06008983 RID: 35203 RVA: 0x00204A48 File Offset: 0x00202C48
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Process_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008984 RID: 35204 RVA: 0x00204A88 File Offset: 0x00202C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107057, XrefRangeEnd = 107063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Process_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x06008985 RID: 35205 RVA: 0x00204ABC File Offset: 0x00202CBC
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Process_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x00043A68 File Offset: 0x00041C68
		public _Process_d__11(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x06008987 RID: 35207 RVA: 0x00204AFC File Offset: 0x00202CFC
		// (set) Token: 0x06008988 RID: 35208 RVA: 0x00043A71 File Offset: 0x00041C71
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x06008989 RID: 35209 RVA: 0x00204B24 File Offset: 0x00202D24
		// (set) Token: 0x0600898A RID: 35210 RVA: 0x00043A8C File Offset: 0x00041C8C
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x0600898B RID: 35211 RVA: 0x00204B54 File Offset: 0x00202D54
		// (set) Token: 0x0600898C RID: 35212 RVA: 0x00043AAB File Offset: 0x00041CAB
		public unsafe Trigger __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x0600898D RID: 35213 RVA: 0x00204B84 File Offset: 0x00202D84
		// (set) Token: 0x0600898E RID: 35214 RVA: 0x00043ACA File Offset: 0x00041CCA
		public unsafe string _attackerString_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr__attackerString_5__2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr__attackerString_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x0600898F RID: 35215 RVA: 0x00204BAC File Offset: 0x00202DAC
		// (set) Token: 0x06008990 RID: 35216 RVA: 0x00043AE9 File Offset: 0x00041CE9
		public unsafe string _targetsString_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr__targetsString_5__3);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Process_d__11.NativeFieldInfoPtr__targetsString_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040057E1 RID: 22497
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040057E2 RID: 22498
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040057E3 RID: 22499
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040057E4 RID: 22500
		private static readonly IntPtr NativeFieldInfoPtr__attackerString_5__2;

		// Token: 0x040057E5 RID: 22501
		private static readonly IntPtr NativeFieldInfoPtr__targetsString_5__3;

		// Token: 0x040057E6 RID: 22502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040057E7 RID: 22503
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040057E8 RID: 22504
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040057E9 RID: 22505
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040057EA RID: 22506
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040057EB RID: 22507
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000862 RID: 2146
	[ObfuscatedName("Trigger+<PreProcess>d__12")]
	public sealed class _PreProcess_d__12 : Object
	{
		// Token: 0x06008991 RID: 35217 RVA: 0x00204BD4 File Offset: 0x00202DD4
		// Note: this type is marked as 'beforefieldinit'.
		static _PreProcess_d__12()
		{
			Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "<PreProcess>d__12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr);
			Trigger._PreProcess_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, "<>1__state");
			Trigger._PreProcess_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, "<>2__current");
			Trigger._PreProcess_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, "<>4__this");
			Trigger._PreProcess_d__12.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, "<>7__wrap1");
			Trigger._PreProcess_d__12.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, "<>7__wrap2");
			Trigger._PreProcess_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, 100673001);
			Trigger._PreProcess_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, 100673002);
			Trigger._PreProcess_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, 100673003);
			Trigger._PreProcess_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, 100673004);
			Trigger._PreProcess_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, 100673005);
			Trigger._PreProcess_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr, 100673006);
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x00204CDC File Offset: 0x00202EDC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PreProcess_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger._PreProcess_d__12>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PreProcess_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x00204D24 File Offset: 0x00202F24
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PreProcess_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x00204D58 File Offset: 0x00202F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107063, XrefRangeEnd = 107103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PreProcess_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x06008995 RID: 35221 RVA: 0x00204D94 File Offset: 0x00202F94
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PreProcess_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x00204DD4 File Offset: 0x00202FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107103, XrefRangeEnd = 107109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PreProcess_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x06008997 RID: 35223 RVA: 0x00204E08 File Offset: 0x00203008
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PreProcess_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008998 RID: 35224 RVA: 0x00043B08 File Offset: 0x00041D08
		public _PreProcess_d__12(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x06008999 RID: 35225 RVA: 0x00204E48 File Offset: 0x00203048
		// (set) Token: 0x0600899A RID: 35226 RVA: 0x00043B11 File Offset: 0x00041D11
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x0600899B RID: 35227 RVA: 0x00204E70 File Offset: 0x00203070
		// (set) Token: 0x0600899C RID: 35228 RVA: 0x00043B2C File Offset: 0x00041D2C
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x0600899D RID: 35229 RVA: 0x00204EA0 File Offset: 0x002030A0
		// (set) Token: 0x0600899E RID: 35230 RVA: 0x00043B4B File Offset: 0x00041D4B
		public unsafe Trigger __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0600899F RID: 35231 RVA: 0x00204ED0 File Offset: 0x002030D0
		// (set) Token: 0x060089A0 RID: 35232 RVA: 0x00043B6A File Offset: 0x00041D6A
		public unsafe Il2CppReferenceArray<Hit> __7__wrap1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___7__wrap1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Hit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x060089A1 RID: 35233 RVA: 0x00204F00 File Offset: 0x00203100
		// (set) Token: 0x060089A2 RID: 35234 RVA: 0x00043B89 File Offset: 0x00041D89
		public unsafe int __7__wrap2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___7__wrap2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PreProcess_d__12.NativeFieldInfoPtr___7__wrap2)) = value;
			}
		}

		// Token: 0x040057EC RID: 22508
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040057ED RID: 22509
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040057EE RID: 22510
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040057EF RID: 22511
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

		// Token: 0x040057F0 RID: 22512
		private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

		// Token: 0x040057F1 RID: 22513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040057F2 RID: 22514
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040057F3 RID: 22515
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040057F4 RID: 22516
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040057F5 RID: 22517
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040057F6 RID: 22518
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000863 RID: 2147
	[ObfuscatedName("Trigger+<Animate>d__13")]
	public sealed class _Animate_d__13 : Object
	{
		// Token: 0x060089A3 RID: 35235 RVA: 0x00204F28 File Offset: 0x00203128
		// Note: this type is marked as 'beforefieldinit'.
		static _Animate_d__13()
		{
			Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "<Animate>d__13");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr);
			Trigger._Animate_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, "<>1__state");
			Trigger._Animate_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, "<>2__current");
			Trigger._Animate_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, "<>4__this");
			Trigger._Animate_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, 100673007);
			Trigger._Animate_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, 100673008);
			Trigger._Animate_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, 100673009);
			Trigger._Animate_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, 100673010);
			Trigger._Animate_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, 100673011);
			Trigger._Animate_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr, 100673012);
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x00205008 File Offset: 0x00203208
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Animate_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger._Animate_d__13>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Animate_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x00205050 File Offset: 0x00203250
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Animate_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x00205084 File Offset: 0x00203284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107109, XrefRangeEnd = 107113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Animate_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x060089A7 RID: 35239 RVA: 0x002050C0 File Offset: 0x002032C0
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Animate_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x00205100 File Offset: 0x00203300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107113, XrefRangeEnd = 107119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Animate_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x060089A9 RID: 35241 RVA: 0x00205134 File Offset: 0x00203334
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._Animate_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x00043BA4 File Offset: 0x00041DA4
		public _Animate_d__13(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x060089AB RID: 35243 RVA: 0x00205174 File Offset: 0x00203374
		// (set) Token: 0x060089AC RID: 35244 RVA: 0x00043BAD File Offset: 0x00041DAD
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Animate_d__13.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Animate_d__13.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x060089AD RID: 35245 RVA: 0x0020519C File Offset: 0x0020339C
		// (set) Token: 0x060089AE RID: 35246 RVA: 0x00043BC8 File Offset: 0x00041DC8
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Animate_d__13.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Animate_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x060089AF RID: 35247 RVA: 0x002051CC File Offset: 0x002033CC
		// (set) Token: 0x060089B0 RID: 35248 RVA: 0x00043BE7 File Offset: 0x00041DE7
		public unsafe Trigger __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Animate_d__13.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._Animate_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057F7 RID: 22519
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040057F8 RID: 22520
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040057F9 RID: 22521
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040057FA RID: 22522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040057FB RID: 22523
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040057FC RID: 22524
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040057FD RID: 22525
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040057FE RID: 22526
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040057FF RID: 22527
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000864 RID: 2148
	[ObfuscatedName("Trigger+<ProcessHits>d__14")]
	public sealed class _ProcessHits_d__14 : Object
	{
		// Token: 0x060089B1 RID: 35249 RVA: 0x002051FC File Offset: 0x002033FC
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessHits_d__14()
		{
			Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "<ProcessHits>d__14");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr);
			Trigger._ProcessHits_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, "<>1__state");
			Trigger._ProcessHits_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, "<>2__current");
			Trigger._ProcessHits_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, "<>4__this");
			Trigger._ProcessHits_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, 100673013);
			Trigger._ProcessHits_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, 100673014);
			Trigger._ProcessHits_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, 100673015);
			Trigger._ProcessHits_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, 100673016);
			Trigger._ProcessHits_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, 100673017);
			Trigger._ProcessHits_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr, 100673018);
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x002052DC File Offset: 0x002034DC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessHits_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger._ProcessHits_d__14>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHits_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089B3 RID: 35251 RVA: 0x00205324 File Offset: 0x00203524
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHits_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x00205358 File Offset: 0x00203558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107119, XrefRangeEnd = 107141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHits_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002AEB RID: 10987
		// (get) Token: 0x060089B5 RID: 35253 RVA: 0x00205394 File Offset: 0x00203594
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHits_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060089B6 RID: 35254 RVA: 0x002053D4 File Offset: 0x002035D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107141, XrefRangeEnd = 107147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHits_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002AEC RID: 10988
		// (get) Token: 0x060089B7 RID: 35255 RVA: 0x00205408 File Offset: 0x00203608
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHits_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x00043C06 File Offset: 0x00041E06
		public _ProcessHits_d__14(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AE8 RID: 10984
		// (get) Token: 0x060089B9 RID: 35257 RVA: 0x00205448 File Offset: 0x00203648
		// (set) Token: 0x060089BA RID: 35258 RVA: 0x00043C0F File Offset: 0x00041E0F
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHits_d__14.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHits_d__14.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002AE9 RID: 10985
		// (get) Token: 0x060089BB RID: 35259 RVA: 0x00205470 File Offset: 0x00203670
		// (set) Token: 0x060089BC RID: 35260 RVA: 0x00043C2A File Offset: 0x00041E2A
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHits_d__14.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHits_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEA RID: 10986
		// (get) Token: 0x060089BD RID: 35261 RVA: 0x002054A0 File Offset: 0x002036A0
		// (set) Token: 0x060089BE RID: 35262 RVA: 0x00043C49 File Offset: 0x00041E49
		public unsafe Trigger __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHits_d__14.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHits_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005800 RID: 22528
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04005801 RID: 22529
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04005802 RID: 22530
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04005803 RID: 22531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04005804 RID: 22532
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005805 RID: 22533
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04005806 RID: 22534
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04005807 RID: 22535
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005808 RID: 22536
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000865 RID: 2149
	[ObfuscatedName("Trigger+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x060089BF RID: 35263 RVA: 0x002054D0 File Offset: 0x002036D0
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<Trigger.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger.__c>.NativeClassPtr);
			Trigger.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger.__c>.NativeClassPtr, "<>9");
			Trigger.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger.__c>.NativeClassPtr, "<>9__15_0");
			Trigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger.__c>.NativeClassPtr, 100673020);
			Trigger.__c.NativeMethodInfoPtr__PostProcess_b__15_0_Internal_Entity_Hit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger.__c>.NativeClassPtr, 100673021);
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x0020554C File Offset: 0x0020374C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089C1 RID: 35265 RVA: 0x00205588 File Offset: 0x00203788
		[CallerCount(0)]
		public unsafe Entity _PostProcess_b__15_0(Hit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(hit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger.__c.NativeMethodInfoPtr__PostProcess_b__15_0_Internal_Entity_Hit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x00043C68 File Offset: 0x00041E68
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AED RID: 10989
		// (get) Token: 0x060089C3 RID: 35267 RVA: 0x002055D8 File Offset: 0x002037D8
		// (set) Token: 0x060089C4 RID: 35268 RVA: 0x00043C71 File Offset: 0x00041E71
		public unsafe static Trigger.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Trigger.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Trigger.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AEE RID: 10990
		// (get) Token: 0x060089C5 RID: 35269 RVA: 0x00205600 File Offset: 0x00203800
		// (set) Token: 0x060089C6 RID: 35270 RVA: 0x00043C83 File Offset: 0x00041E83
		public unsafe static Func<Hit, Entity> __9__15_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Trigger.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Hit, Entity>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Trigger.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005809 RID: 22537
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400580A RID: 22538
		private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

		// Token: 0x0400580B RID: 22539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400580C RID: 22540
		private static readonly IntPtr NativeMethodInfoPtr__PostProcess_b__15_0_Internal_Entity_Hit_0;
	}

	// Token: 0x02000866 RID: 2150
	[ObfuscatedName("Trigger+<PostProcess>d__15")]
	public sealed class _PostProcess_d__15 : Object
	{
		// Token: 0x060089C7 RID: 35271 RVA: 0x00205628 File Offset: 0x00203828
		// Note: this type is marked as 'beforefieldinit'.
		static _PostProcess_d__15()
		{
			Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "<PostProcess>d__15");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr);
			Trigger._PostProcess_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, "<>1__state");
			Trigger._PostProcess_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, "<>2__current");
			Trigger._PostProcess_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, "<>4__this");
			Trigger._PostProcess_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, 100673022);
			Trigger._PostProcess_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, 100673023);
			Trigger._PostProcess_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, 100673024);
			Trigger._PostProcess_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, 100673025);
			Trigger._PostProcess_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, 100673026);
			Trigger._PostProcess_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr, 100673027);
		}

		// Token: 0x060089C8 RID: 35272 RVA: 0x00205708 File Offset: 0x00203908
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostProcess_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger._PostProcess_d__15>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PostProcess_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089C9 RID: 35273 RVA: 0x00205750 File Offset: 0x00203950
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PostProcess_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089CA RID: 35274 RVA: 0x00205784 File Offset: 0x00203984
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107147, XrefRangeEnd = 107174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PostProcess_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002AF2 RID: 10994
		// (get) Token: 0x060089CB RID: 35275 RVA: 0x002057C0 File Offset: 0x002039C0
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PostProcess_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060089CC RID: 35276 RVA: 0x00205800 File Offset: 0x00203A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107174, XrefRangeEnd = 107180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PostProcess_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002AF3 RID: 10995
		// (get) Token: 0x060089CD RID: 35277 RVA: 0x00205834 File Offset: 0x00203A34
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._PostProcess_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060089CE RID: 35278 RVA: 0x00043C95 File Offset: 0x00041E95
		public _PostProcess_d__15(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AEF RID: 10991
		// (get) Token: 0x060089CF RID: 35279 RVA: 0x00205874 File Offset: 0x00203A74
		// (set) Token: 0x060089D0 RID: 35280 RVA: 0x00043C9E File Offset: 0x00041E9E
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PostProcess_d__15.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PostProcess_d__15.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002AF0 RID: 10992
		// (get) Token: 0x060089D1 RID: 35281 RVA: 0x0020589C File Offset: 0x00203A9C
		// (set) Token: 0x060089D2 RID: 35282 RVA: 0x00043CB9 File Offset: 0x00041EB9
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PostProcess_d__15.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PostProcess_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF1 RID: 10993
		// (get) Token: 0x060089D3 RID: 35283 RVA: 0x002058CC File Offset: 0x00203ACC
		// (set) Token: 0x060089D4 RID: 35284 RVA: 0x00043CD8 File Offset: 0x00041ED8
		public unsafe Trigger __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PostProcess_d__15.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._PostProcess_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400580D RID: 22541
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400580E RID: 22542
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400580F RID: 22543
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04005810 RID: 22544
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04005811 RID: 22545
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005812 RID: 22546
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04005813 RID: 22547
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04005814 RID: 22548
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005815 RID: 22549
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000867 RID: 2151
	[ObfuscatedName("Trigger+<ProcessHit>d__16")]
	public sealed class _ProcessHit_d__16 : Object
	{
		// Token: 0x060089D5 RID: 35285 RVA: 0x002058FC File Offset: 0x00203AFC
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessHit_d__16()
		{
			Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Trigger>.NativeClassPtr, "<ProcessHit>d__16");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr);
			Trigger._ProcessHit_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, "<>1__state");
			Trigger._ProcessHit_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, "<>2__current");
			Trigger._ProcessHit_d__16.NativeFieldInfoPtr_hit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, "hit");
			Trigger._ProcessHit_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, 100673028);
			Trigger._ProcessHit_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, 100673029);
			Trigger._ProcessHit_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, 100673030);
			Trigger._ProcessHit_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, 100673031);
			Trigger._ProcessHit_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, 100673032);
			Trigger._ProcessHit_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr, 100673033);
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x002059DC File Offset: 0x00203BDC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessHit_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Trigger._ProcessHit_d__16>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHit_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x00205A24 File Offset: 0x00203C24
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHit_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x00205A58 File Offset: 0x00203C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107180, XrefRangeEnd = 107181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHit_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x060089D9 RID: 35289 RVA: 0x00205A94 File Offset: 0x00203C94
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHit_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060089DA RID: 35290 RVA: 0x00205AD4 File Offset: 0x00203CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107181, XrefRangeEnd = 107187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHit_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x060089DB RID: 35291 RVA: 0x00205B08 File Offset: 0x00203D08
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Trigger._ProcessHit_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060089DC RID: 35292 RVA: 0x00043CF7 File Offset: 0x00041EF7
		public _ProcessHit_d__16(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AF4 RID: 10996
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x00205B48 File Offset: 0x00203D48
		// (set) Token: 0x060089DE RID: 35294 RVA: 0x00043D00 File Offset: 0x00041F00
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHit_d__16.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHit_d__16.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x00205B70 File Offset: 0x00203D70
		// (set) Token: 0x060089E0 RID: 35296 RVA: 0x00043D1B File Offset: 0x00041F1B
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHit_d__16.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHit_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x00205BA0 File Offset: 0x00203DA0
		// (set) Token: 0x060089E2 RID: 35298 RVA: 0x00043D3A File Offset: 0x00041F3A
		public unsafe Hit hit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHit_d__16.NativeFieldInfoPtr_hit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Trigger._ProcessHit_d__16.NativeFieldInfoPtr_hit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005816 RID: 22550
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04005817 RID: 22551
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04005818 RID: 22552
		private static readonly IntPtr NativeFieldInfoPtr_hit;

		// Token: 0x04005819 RID: 22553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400581A RID: 22554
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400581B RID: 22555
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400581C RID: 22556
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400581D RID: 22557
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400581E RID: 22558
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

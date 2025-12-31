using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x020000B0 RID: 176
public class ActionTriggerAgainst : ActionTrigger
{
	// Token: 0x0600077D RID: 1917 RVA: 0x0006B0EC File Offset: 0x000692EC
	// Note: this type is marked as 'beforefieldinit'.
	static ActionTriggerAgainst()
	{
		Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ActionTriggerAgainst");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr);
		ActionTriggerAgainst.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, "target");
		ActionTriggerAgainst.NativeFieldInfoPtr_targetContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, "targetContainer");
		ActionTriggerAgainst.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, "trigger");
		ActionTriggerAgainst.NativeFieldInfoPtr_countsAsTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, "countsAsTrigger");
		ActionTriggerAgainst.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664676);
		ActionTriggerAgainst.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664677);
		ActionTriggerAgainst.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664678);
		ActionTriggerAgainst.NativeMethodInfoPtr_GetTrigger_Protected_Virtual_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664679);
		ActionTriggerAgainst.NativeMethodInfoPtr_GetTargets_Protected_Virtual_New_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr, 100664680);
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x0006B1D0 File Offset: 0x000693D0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 26960, RefRangeEnd = 26964, XrefRangeStart = 26957, XrefRangeEnd = 26960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionTriggerAgainst(Entity entity, Entity triggeredBy, Entity target, CardContainer targetContainer) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionTriggerAgainst>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggeredBy);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetContainer);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionTriggerAgainst.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170001A6 RID: 422
	// (get) Token: 0x0600077F RID: 1919 RVA: 0x0006B254 File Offset: 0x00069454
	public unsafe override bool IsRoutine
	{
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 15307, RefRangeEnd = 15433, XrefRangeStart = 15307, XrefRangeEnd = 15433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionTriggerAgainst.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x0006B29C File Offset: 0x0006949C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26964, XrefRangeEnd = 26982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Process()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionTriggerAgainst.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000781 RID: 1921 RVA: 0x0006B2D8 File Offset: 0x000694D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26982, XrefRangeEnd = 26989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Trigger GetTrigger()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionTriggerAgainst.NativeMethodInfoPtr_GetTrigger_Protected_Virtual_Trigger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr3) : null;
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x0006B324 File Offset: 0x00069524
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26989, XrefRangeEnd = 26994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Il2CppReferenceArray<Entity> GetTargets()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionTriggerAgainst.NativeMethodInfoPtr_GetTargets_Protected_Virtual_New_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x00005144 File Offset: 0x00003344
	public ActionTriggerAgainst(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170001A2 RID: 418
	// (get) Token: 0x06000784 RID: 1924 RVA: 0x0006B370 File Offset: 0x00069570
	// (set) Token: 0x06000785 RID: 1925 RVA: 0x0000514D File Offset: 0x0000334D
	public unsafe Entity target
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_target);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A3 RID: 419
	// (get) Token: 0x06000786 RID: 1926 RVA: 0x0006B3A0 File Offset: 0x000695A0
	// (set) Token: 0x06000787 RID: 1927 RVA: 0x0000516C File Offset: 0x0000336C
	public unsafe CardContainer targetContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_targetContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardContainer>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_targetContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A4 RID: 420
	// (get) Token: 0x06000788 RID: 1928 RVA: 0x0006B3D0 File Offset: 0x000695D0
	// (set) Token: 0x06000789 RID: 1929 RVA: 0x0000518B File Offset: 0x0000338B
	public unsafe Trigger trigger
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_trigger);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A5 RID: 421
	// (get) Token: 0x0600078A RID: 1930 RVA: 0x0006B400 File Offset: 0x00069600
	// (set) Token: 0x0600078B RID: 1931 RVA: 0x000051AA File Offset: 0x000033AA
	public unsafe bool countsAsTrigger
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_countsAsTrigger);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTriggerAgainst.NativeFieldInfoPtr_countsAsTrigger)) = value;
		}
	}

	// Token: 0x040004A3 RID: 1187
	private static readonly IntPtr NativeFieldInfoPtr_target;

	// Token: 0x040004A4 RID: 1188
	private static readonly IntPtr NativeFieldInfoPtr_targetContainer;

	// Token: 0x040004A5 RID: 1189
	private static readonly IntPtr NativeFieldInfoPtr_trigger;

	// Token: 0x040004A6 RID: 1190
	private static readonly IntPtr NativeFieldInfoPtr_countsAsTrigger;

	// Token: 0x040004A7 RID: 1191
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Entity_CardContainer_0;

	// Token: 0x040004A8 RID: 1192
	private static readonly IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0;

	// Token: 0x040004A9 RID: 1193
	private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

	// Token: 0x040004AA RID: 1194
	private static readonly IntPtr NativeMethodInfoPtr_GetTrigger_Protected_Virtual_Trigger_0;

	// Token: 0x040004AB RID: 1195
	private static readonly IntPtr NativeMethodInfoPtr_GetTargets_Protected_Virtual_New_Il2CppReferenceArray_1_Entity_0;
}

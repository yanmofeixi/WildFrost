using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x020000AF RID: 175
public class ActionTrigger : PlayAction
{
	// Token: 0x06000771 RID: 1905 RVA: 0x0006AE78 File Offset: 0x00069078
	// Note: this type is marked as 'beforefieldinit'.
	static ActionTrigger()
	{
		Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ActionTrigger");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr);
		ActionTrigger.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, "entity");
		ActionTrigger.NativeFieldInfoPtr_triggeredBy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, "triggeredBy");
		ActionTrigger.NativeFieldInfoPtr_triggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, "triggerType");
		ActionTrigger.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, 100664672);
		ActionTrigger.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, 100664673);
		ActionTrigger.NativeMethodInfoPtr_Process_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, 100664674);
		ActionTrigger.NativeMethodInfoPtr_GetTrigger_Protected_Virtual_New_Trigger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr, 100664675);
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x0006AF34 File Offset: 0x00069134
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 26921, RefRangeEnd = 26930, XrefRangeStart = 26914, XrefRangeEnd = 26921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionTrigger(Entity entity, Entity triggeredBy) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionTrigger>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(triggeredBy);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionTrigger.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170001A1 RID: 417
	// (get) Token: 0x06000773 RID: 1907 RVA: 0x0006AF94 File Offset: 0x00069194
	public unsafe override bool IsRoutine
	{
		[CallerCount(126)]
		[CachedScanResults(RefRangeStart = 15307, RefRangeEnd = 15433, XrefRangeStart = 15307, XrefRangeEnd = 15433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionTrigger.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x0006AFDC File Offset: 0x000691DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26930, XrefRangeEnd = 26948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Process()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionTrigger.NativeMethodInfoPtr_Process_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x0006B018 File Offset: 0x00069218
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26948, XrefRangeEnd = 26957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual Trigger GetTrigger()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActionTrigger.NativeMethodInfoPtr_GetTrigger_Protected_Virtual_New_Trigger_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr3) : null;
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x000050DE File Offset: 0x000032DE
	public ActionTrigger(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700019E RID: 414
	// (get) Token: 0x06000777 RID: 1911 RVA: 0x0006B064 File Offset: 0x00069264
	// (set) Token: 0x06000778 RID: 1912 RVA: 0x000050E7 File Offset: 0x000032E7
	public unsafe Entity entity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_entity);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x06000779 RID: 1913 RVA: 0x0006B094 File Offset: 0x00069294
	// (set) Token: 0x0600077A RID: 1914 RVA: 0x00005106 File Offset: 0x00003306
	public unsafe Entity triggeredBy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_triggeredBy);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_triggeredBy), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x0600077B RID: 1915 RVA: 0x0006B0C4 File Offset: 0x000692C4
	// (set) Token: 0x0600077C RID: 1916 RVA: 0x00005125 File Offset: 0x00003325
	public unsafe string triggerType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_triggerType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionTrigger.NativeFieldInfoPtr_triggerType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400049C RID: 1180
	private static readonly IntPtr NativeFieldInfoPtr_entity;

	// Token: 0x0400049D RID: 1181
	private static readonly IntPtr NativeFieldInfoPtr_triggeredBy;

	// Token: 0x0400049E RID: 1182
	private static readonly IntPtr NativeFieldInfoPtr_triggerType;

	// Token: 0x0400049F RID: 1183
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0;

	// Token: 0x040004A0 RID: 1184
	private static readonly IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_get_Boolean_0;

	// Token: 0x040004A1 RID: 1185
	private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_Void_0;

	// Token: 0x040004A2 RID: 1186
	private static readonly IntPtr NativeMethodInfoPtr_GetTrigger_Protected_Virtual_New_Trigger_0;
}

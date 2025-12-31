using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x020000B4 RID: 180
public class ActionQueue : MonoBehaviourSingleton<ActionQueue>
{
	// Token: 0x060007A8 RID: 1960 RVA: 0x0006B9EC File Offset: 0x00069BEC
	// Note: this type is marked as 'beforefieldinit'.
	static ActionQueue()
	{
		Il2CppClassPointerStore<ActionQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "ActionQueue");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr);
		ActionQueue.NativeFieldInfoPtr_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "queue");
		ActionQueue.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "count");
		ActionQueue.NativeFieldInfoPtr_delayBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "delayBefore");
		ActionQueue.NativeFieldInfoPtr_delayAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "delayAfter");
		ActionQueue.NativeFieldInfoPtr_current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "current");
		ActionQueue.NativeFieldInfoPtr_parallelClump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "parallelClump");
		ActionQueue.NativeMethodInfoPtr_get_Empty_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664691);
		ActionQueue.NativeMethodInfoPtr_Insert_Public_Static_PlayAction_Int32_PlayAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664692);
		ActionQueue.NativeMethodInfoPtr_Add_Public_Static_PlayAction_PlayAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664693);
		ActionQueue.NativeMethodInfoPtr_Stack_Public_Static_PlayAction_PlayAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664694);
		ActionQueue.NativeMethodInfoPtr_GetActions_Public_Static_Il2CppReferenceArray_1_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664695);
		ActionQueue.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664696);
		ActionQueue.NativeMethodInfoPtr_Remove_Public_Static_Boolean_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664697);
		ActionQueue.NativeMethodInfoPtr_Wait_Public_Static_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664698);
		ActionQueue.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664699);
		ActionQueue.NativeMethodInfoPtr_Restart_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664700);
		ActionQueue.NativeMethodInfoPtr_Routine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664701);
		ActionQueue.NativeMethodInfoPtr_RunActionRoutine_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664702);
		ActionQueue.NativeMethodInfoPtr_GetIndexOfHighestPriorityAction_Private_Static_Int32_IReadOnlyList_1_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664703);
		ActionQueue.NativeMethodInfoPtr_Run_Private_IEnumerator_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664704);
		ActionQueue.NativeMethodInfoPtr_PerformAction_Private_IEnumerator_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664705);
		ActionQueue.NativeMethodInfoPtr_PostAction_Private_IEnumerator_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664706);
		ActionQueue.NativeMethodInfoPtr_RunParallel_Public_Static_Void_PlayAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664707);
		ActionQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, 100664708);
	}

	// Token: 0x170001B6 RID: 438
	// (get) Token: 0x060007A9 RID: 1961 RVA: 0x0006BBFC File Offset: 0x00069DFC
	public unsafe static bool Empty
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 27133, RefRangeEnd = 27135, XrefRangeStart = 27129, XrefRangeEnd = 27133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_get_Empty_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060007AA RID: 1962 RVA: 0x0006BC2C File Offset: 0x00069E2C
	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 27156, RefRangeEnd = 27170, XrefRangeStart = 27135, XrefRangeEnd = 27156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayAction Insert(int index, PlayAction action, bool fixedPosition = false)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref index;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedPosition;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Insert_Public_Static_PlayAction_Int32_PlayAction_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAction>(intPtr3) : null;
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x0006BC8C File Offset: 0x00069E8C
	[CallerCount(44)]
	[CachedScanResults(RefRangeStart = 27179, RefRangeEnd = 27223, XrefRangeStart = 27170, XrefRangeEnd = 27179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayAction Add(PlayAction action, bool fixedPosition = false)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedPosition;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Add_Public_Static_PlayAction_PlayAction_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAction>(intPtr3) : null;
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x0006BCE0 File Offset: 0x00069EE0
	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 27227, RefRangeEnd = 27266, XrefRangeStart = 27223, XrefRangeEnd = 27227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static PlayAction Stack(PlayAction action, bool fixedPosition = false)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fixedPosition;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Stack_Public_Static_PlayAction_PlayAction_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayAction>(intPtr3) : null;
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x0006BD34 File Offset: 0x00069F34
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 27274, RefRangeEnd = 27277, XrefRangeStart = 27266, XrefRangeEnd = 27274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<PlayAction> GetActions()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_GetActions_Public_Static_Il2CppReferenceArray_1_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayAction>>(intPtr3) : null;
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x0006BD68 File Offset: 0x00069F68
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27285, RefRangeEnd = 27286, XrefRangeStart = 27277, XrefRangeEnd = 27285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int IndexOf(PlayAction action)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_IndexOf_Public_Static_Int32_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x0006BDAC File Offset: 0x00069FAC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 27307, RefRangeEnd = 27310, XrefRangeStart = 27286, XrefRangeEnd = 27307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Remove(PlayAction action)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Remove_Public_Static_Boolean_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060007B0 RID: 1968 RVA: 0x0006BDF0 File Offset: 0x00069FF0
	[CallerCount(18)]
	[CachedScanResults(RefRangeStart = 27314, RefRangeEnd = 27332, XrefRangeStart = 27310, XrefRangeEnd = 27314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator Wait(bool includeParallel = true)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref includeParallel;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Wait_Public_Static_IEnumerator_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x0006BE30 File Offset: 0x0006A030
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27332, XrefRangeEnd = 27334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x0006BE64 File Offset: 0x0006A064
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27370, RefRangeEnd = 27371, XrefRangeStart = 27334, XrefRangeEnd = 27370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Restart()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Restart_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007B3 RID: 1971 RVA: 0x0006BE8C File Offset: 0x0006A08C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 27376, RefRangeEnd = 27378, XrefRangeStart = 27371, XrefRangeEnd = 27376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Routine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Routine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060007B4 RID: 1972 RVA: 0x0006BECC File Offset: 0x0006A0CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27378, XrefRangeEnd = 27383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator RunActionRoutine()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_RunActionRoutine_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060007B5 RID: 1973 RVA: 0x0006BF0C File Offset: 0x0006A10C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27383, XrefRangeEnd = 27389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetIndexOfHighestPriorityAction(IReadOnlyList<PlayAction> actions)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_GetIndexOfHighestPriorityAction_Private_Static_Int32_IReadOnlyList_1_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060007B6 RID: 1974 RVA: 0x0006BF50 File Offset: 0x0006A150
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27389, XrefRangeEnd = 27395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Run(PlayAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_Run_Private_IEnumerator_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060007B7 RID: 1975 RVA: 0x0006BFA0 File Offset: 0x0006A1A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27395, XrefRangeEnd = 27401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PerformAction(PlayAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_PerformAction_Private_IEnumerator_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060007B8 RID: 1976 RVA: 0x0006BFF0 File Offset: 0x0006A1F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 27407, RefRangeEnd = 27408, XrefRangeStart = 27401, XrefRangeEnd = 27407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator PostAction(PlayAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_PostAction_Private_IEnumerator_PlayAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060007B9 RID: 1977 RVA: 0x0006C040 File Offset: 0x0006A240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27408, XrefRangeEnd = 27424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RunParallel(PlayAction action)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr_RunParallel_Public_Static_Void_PlayAction_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007BA RID: 1978 RVA: 0x0006C078 File Offset: 0x0006A278
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27424, XrefRangeEnd = 27435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ActionQueue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060007BB RID: 1979 RVA: 0x00005286 File Offset: 0x00003486
	public ActionQueue(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170001B0 RID: 432
	// (get) Token: 0x060007BC RID: 1980 RVA: 0x0006C0B4 File Offset: 0x0006A2B4
	// (set) Token: 0x060007BD RID: 1981 RVA: 0x0000528F File Offset: 0x0000348F
	public unsafe List<PlayAction> queue
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue.NativeFieldInfoPtr_queue);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PlayAction>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue.NativeFieldInfoPtr_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B1 RID: 433
	// (get) Token: 0x060007BE RID: 1982 RVA: 0x0006C0E4 File Offset: 0x0006A2E4
	// (set) Token: 0x060007BF RID: 1983 RVA: 0x000052AE File Offset: 0x000034AE
	public unsafe int count
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue.NativeFieldInfoPtr_count);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue.NativeFieldInfoPtr_count)) = value;
		}
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0006C10C File Offset: 0x0006A30C
	// (set) Token: 0x060007C1 RID: 1985 RVA: 0x000052C9 File Offset: 0x000034C9
	public unsafe float delayBefore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue.NativeFieldInfoPtr_delayBefore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue.NativeFieldInfoPtr_delayBefore)) = value;
		}
	}

	// Token: 0x170001B3 RID: 435
	// (get) Token: 0x060007C2 RID: 1986 RVA: 0x0006C134 File Offset: 0x0006A334
	// (set) Token: 0x060007C3 RID: 1987 RVA: 0x000052E4 File Offset: 0x000034E4
	public unsafe float delayAfter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue.NativeFieldInfoPtr_delayAfter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue.NativeFieldInfoPtr_delayAfter)) = value;
		}
	}

	// Token: 0x170001B4 RID: 436
	// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0006C15C File Offset: 0x0006A35C
	// (set) Token: 0x060007C5 RID: 1989 RVA: 0x000052FF File Offset: 0x000034FF
	public unsafe static PlayAction current
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ActionQueue.NativeFieldInfoPtr_current, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayAction>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ActionQueue.NativeFieldInfoPtr_current, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001B5 RID: 437
	// (get) Token: 0x060007C6 RID: 1990 RVA: 0x0006C184 File Offset: 0x0006A384
	// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00005311 File Offset: 0x00003511
	public unsafe static Routine.Clump parallelClump
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(ActionQueue.NativeFieldInfoPtr_parallelClump, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Routine.Clump>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(ActionQueue.NativeFieldInfoPtr_parallelClump, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040004BC RID: 1212
	private static readonly IntPtr NativeFieldInfoPtr_queue;

	// Token: 0x040004BD RID: 1213
	private static readonly IntPtr NativeFieldInfoPtr_count;

	// Token: 0x040004BE RID: 1214
	private static readonly IntPtr NativeFieldInfoPtr_delayBefore;

	// Token: 0x040004BF RID: 1215
	private static readonly IntPtr NativeFieldInfoPtr_delayAfter;

	// Token: 0x040004C0 RID: 1216
	private static readonly IntPtr NativeFieldInfoPtr_current;

	// Token: 0x040004C1 RID: 1217
	private static readonly IntPtr NativeFieldInfoPtr_parallelClump;

	// Token: 0x040004C2 RID: 1218
	private static readonly IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_Boolean_0;

	// Token: 0x040004C3 RID: 1219
	private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Static_PlayAction_Int32_PlayAction_Boolean_0;

	// Token: 0x040004C4 RID: 1220
	private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Static_PlayAction_PlayAction_Boolean_0;

	// Token: 0x040004C5 RID: 1221
	private static readonly IntPtr NativeMethodInfoPtr_Stack_Public_Static_PlayAction_PlayAction_Boolean_0;

	// Token: 0x040004C6 RID: 1222
	private static readonly IntPtr NativeMethodInfoPtr_GetActions_Public_Static_Il2CppReferenceArray_1_PlayAction_0;

	// Token: 0x040004C7 RID: 1223
	private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Static_Int32_PlayAction_0;

	// Token: 0x040004C8 RID: 1224
	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Static_Boolean_PlayAction_0;

	// Token: 0x040004C9 RID: 1225
	private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Static_IEnumerator_Boolean_0;

	// Token: 0x040004CA RID: 1226
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040004CB RID: 1227
	private static readonly IntPtr NativeMethodInfoPtr_Restart_Public_Static_Void_0;

	// Token: 0x040004CC RID: 1228
	private static readonly IntPtr NativeMethodInfoPtr_Routine_Private_IEnumerator_0;

	// Token: 0x040004CD RID: 1229
	private static readonly IntPtr NativeMethodInfoPtr_RunActionRoutine_Private_IEnumerator_0;

	// Token: 0x040004CE RID: 1230
	private static readonly IntPtr NativeMethodInfoPtr_GetIndexOfHighestPriorityAction_Private_Static_Int32_IReadOnlyList_1_PlayAction_0;

	// Token: 0x040004CF RID: 1231
	private static readonly IntPtr NativeMethodInfoPtr_Run_Private_IEnumerator_PlayAction_0;

	// Token: 0x040004D0 RID: 1232
	private static readonly IntPtr NativeMethodInfoPtr_PerformAction_Private_IEnumerator_PlayAction_0;

	// Token: 0x040004D1 RID: 1233
	private static readonly IntPtr NativeMethodInfoPtr_PostAction_Private_IEnumerator_PlayAction_0;

	// Token: 0x040004D2 RID: 1234
	private static readonly IntPtr NativeMethodInfoPtr_RunParallel_Public_Static_Void_PlayAction_0;

	// Token: 0x040004D3 RID: 1235
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000526 RID: 1318
	[ObfuscatedName("ActionQueue+<Wait>d__14")]
	public sealed class _Wait_d__14 : Object
	{
		// Token: 0x0600638A RID: 25482 RVA: 0x001922C4 File Offset: 0x001904C4
		// Note: this type is marked as 'beforefieldinit'.
		static _Wait_d__14()
		{
			Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "<Wait>d__14");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr);
			ActionQueue._Wait_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, "<>1__state");
			ActionQueue._Wait_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, "<>2__current");
			ActionQueue._Wait_d__14.NativeFieldInfoPtr_includeParallel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, "includeParallel");
			ActionQueue._Wait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, 100664710);
			ActionQueue._Wait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, 100664711);
			ActionQueue._Wait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, 100664712);
			ActionQueue._Wait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, 100664713);
			ActionQueue._Wait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, 100664714);
			ActionQueue._Wait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr, 100664715);
		}

		// Token: 0x0600638B RID: 25483 RVA: 0x001923A4 File Offset: 0x001905A4
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Wait_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionQueue._Wait_d__14>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Wait_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600638C RID: 25484 RVA: 0x001923EC File Offset: 0x001905EC
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Wait_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600638D RID: 25485 RVA: 0x00192420 File Offset: 0x00190620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27075, XrefRangeEnd = 27077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Wait_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600638E RID: 25486 RVA: 0x0019245C File Offset: 0x0019065C
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Wait_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600638F RID: 25487 RVA: 0x0019249C File Offset: 0x0019069C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27077, XrefRangeEnd = 27085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Wait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x06006390 RID: 25488 RVA: 0x001924D0 File Offset: 0x001906D0
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Wait_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006391 RID: 25489 RVA: 0x00030D6E File Offset: 0x0002EF6E
		public _Wait_d__14(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x06006392 RID: 25490 RVA: 0x00192510 File Offset: 0x00190710
		// (set) Token: 0x06006393 RID: 25491 RVA: 0x00030D77 File Offset: 0x0002EF77
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Wait_d__14.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Wait_d__14.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x00192538 File Offset: 0x00190738
		// (set) Token: 0x06006395 RID: 25493 RVA: 0x00030D92 File Offset: 0x0002EF92
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Wait_d__14.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Wait_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x06006396 RID: 25494 RVA: 0x00192568 File Offset: 0x00190768
		// (set) Token: 0x06006397 RID: 25495 RVA: 0x00030DB1 File Offset: 0x0002EFB1
		public unsafe bool includeParallel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Wait_d__14.NativeFieldInfoPtr_includeParallel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Wait_d__14.NativeFieldInfoPtr_includeParallel)) = value;
			}
		}

		// Token: 0x04004123 RID: 16675
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004124 RID: 16676
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004125 RID: 16677
		private static readonly IntPtr NativeFieldInfoPtr_includeParallel;

		// Token: 0x04004126 RID: 16678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004127 RID: 16679
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004128 RID: 16680
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004129 RID: 16681
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400412A RID: 16682
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400412B RID: 16683
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000527 RID: 1319
	[ObfuscatedName("ActionQueue+<Routine>d__17")]
	public sealed class _Routine_d__17 : Object
	{
		// Token: 0x06006398 RID: 25496 RVA: 0x00192590 File Offset: 0x00190790
		// Note: this type is marked as 'beforefieldinit'.
		static _Routine_d__17()
		{
			Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "<Routine>d__17");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr);
			ActionQueue._Routine_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, "<>1__state");
			ActionQueue._Routine_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, "<>2__current");
			ActionQueue._Routine_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, "<>4__this");
			ActionQueue._Routine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, 100664716);
			ActionQueue._Routine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, 100664717);
			ActionQueue._Routine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, 100664718);
			ActionQueue._Routine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, 100664719);
			ActionQueue._Routine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, 100664720);
			ActionQueue._Routine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr, 100664721);
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x00192670 File Offset: 0x00190870
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Routine_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionQueue._Routine_d__17>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Routine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x001926B8 File Offset: 0x001908B8
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Routine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600639B RID: 25499 RVA: 0x001926EC File Offset: 0x001908EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27085, XrefRangeEnd = 27087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Routine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x0600639C RID: 25500 RVA: 0x00192728 File Offset: 0x00190928
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Routine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600639D RID: 25501 RVA: 0x00192768 File Offset: 0x00190968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27087, XrefRangeEnd = 27093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Routine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x0600639E RID: 25502 RVA: 0x0019279C File Offset: 0x0019099C
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Routine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x00030DCC File Offset: 0x0002EFCC
		public _Routine_d__17(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x060063A0 RID: 25504 RVA: 0x001927DC File Offset: 0x001909DC
		// (set) Token: 0x060063A1 RID: 25505 RVA: 0x00030DD5 File Offset: 0x0002EFD5
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Routine_d__17.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Routine_d__17.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x060063A2 RID: 25506 RVA: 0x00192804 File Offset: 0x00190A04
		// (set) Token: 0x060063A3 RID: 25507 RVA: 0x00030DF0 File Offset: 0x0002EFF0
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Routine_d__17.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Routine_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x060063A4 RID: 25508 RVA: 0x00192834 File Offset: 0x00190A34
		// (set) Token: 0x060063A5 RID: 25509 RVA: 0x00030E0F File Offset: 0x0002F00F
		public unsafe ActionQueue __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Routine_d__17.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Routine_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400412C RID: 16684
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400412D RID: 16685
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400412E RID: 16686
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400412F RID: 16687
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004130 RID: 16688
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004131 RID: 16689
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004132 RID: 16690
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004133 RID: 16691
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004134 RID: 16692
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000528 RID: 1320
	[ObfuscatedName("ActionQueue+<RunActionRoutine>d__18")]
	public sealed class _RunActionRoutine_d__18 : Object
	{
		// Token: 0x060063A6 RID: 25510 RVA: 0x00192864 File Offset: 0x00190A64
		// Note: this type is marked as 'beforefieldinit'.
		static _RunActionRoutine_d__18()
		{
			Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "<RunActionRoutine>d__18");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr);
			ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, "<>1__state");
			ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, "<>2__current");
			ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, "<>4__this");
			ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr__index_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, "<index>5__2");
			ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, 100664722);
			ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, 100664723);
			ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, 100664724);
			ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, 100664725);
			ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, 100664726);
			ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr, 100664727);
		}

		// Token: 0x060063A7 RID: 25511 RVA: 0x00192958 File Offset: 0x00190B58
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _RunActionRoutine_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionQueue._RunActionRoutine_d__18>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A8 RID: 25512 RVA: 0x001929A0 File Offset: 0x00190BA0
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A9 RID: 25513 RVA: 0x001929D4 File Offset: 0x00190BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27093, XrefRangeEnd = 27104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x060063AA RID: 25514 RVA: 0x00192A10 File Offset: 0x00190C10
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060063AB RID: 25515 RVA: 0x00192A50 File Offset: 0x00190C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27104, XrefRangeEnd = 27110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x060063AC RID: 25516 RVA: 0x00192A84 File Offset: 0x00190C84
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._RunActionRoutine_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060063AD RID: 25517 RVA: 0x00030E2E File Offset: 0x0002F02E
		public _RunActionRoutine_d__18(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x060063AE RID: 25518 RVA: 0x00192AC4 File Offset: 0x00190CC4
		// (set) Token: 0x060063AF RID: 25519 RVA: 0x00030E37 File Offset: 0x0002F037
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x060063B0 RID: 25520 RVA: 0x00192AEC File Offset: 0x00190CEC
		// (set) Token: 0x060063B1 RID: 25521 RVA: 0x00030E52 File Offset: 0x0002F052
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x060063B2 RID: 25522 RVA: 0x00192B1C File Offset: 0x00190D1C
		// (set) Token: 0x060063B3 RID: 25523 RVA: 0x00030E71 File Offset: 0x0002F071
		public unsafe ActionQueue __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x060063B4 RID: 25524 RVA: 0x00192B4C File Offset: 0x00190D4C
		// (set) Token: 0x060063B5 RID: 25525 RVA: 0x00030E90 File Offset: 0x0002F090
		public unsafe int _index_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr__index_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._RunActionRoutine_d__18.NativeFieldInfoPtr__index_5__2)) = value;
			}
		}

		// Token: 0x04004135 RID: 16693
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004136 RID: 16694
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004137 RID: 16695
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004138 RID: 16696
		private static readonly IntPtr NativeFieldInfoPtr__index_5__2;

		// Token: 0x04004139 RID: 16697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400413A RID: 16698
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400413B RID: 16699
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400413C RID: 16700
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400413D RID: 16701
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400413E RID: 16702
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000529 RID: 1321
	[ObfuscatedName("ActionQueue+<Run>d__20")]
	public sealed class _Run_d__20 : Object
	{
		// Token: 0x060063B6 RID: 25526 RVA: 0x00192B74 File Offset: 0x00190D74
		// Note: this type is marked as 'beforefieldinit'.
		static _Run_d__20()
		{
			Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "<Run>d__20");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr);
			ActionQueue._Run_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, "<>1__state");
			ActionQueue._Run_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, "<>2__current");
			ActionQueue._Run_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, "<>4__this");
			ActionQueue._Run_d__20.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, "action");
			ActionQueue._Run_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, 100664728);
			ActionQueue._Run_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, 100664729);
			ActionQueue._Run_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, 100664730);
			ActionQueue._Run_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, 100664731);
			ActionQueue._Run_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, 100664732);
			ActionQueue._Run_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr, 100664733);
		}

		// Token: 0x060063B7 RID: 25527 RVA: 0x00192C68 File Offset: 0x00190E68
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Run_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionQueue._Run_d__20>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Run_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063B8 RID: 25528 RVA: 0x00192CB0 File Offset: 0x00190EB0
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Run_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063B9 RID: 25529 RVA: 0x00192CE4 File Offset: 0x00190EE4
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Run_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001E62 RID: 7778
		// (get) Token: 0x060063BA RID: 25530 RVA: 0x00192D20 File Offset: 0x00190F20
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Run_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060063BB RID: 25531 RVA: 0x00192D60 File Offset: 0x00190F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27110, XrefRangeEnd = 27116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Run_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E63 RID: 7779
		// (get) Token: 0x060063BC RID: 25532 RVA: 0x00192D94 File Offset: 0x00190F94
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._Run_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x00030EAB File Offset: 0x0002F0AB
		public _Run_d__20(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x060063BE RID: 25534 RVA: 0x00192DD4 File Offset: 0x00190FD4
		// (set) Token: 0x060063BF RID: 25535 RVA: 0x00030EB4 File Offset: 0x0002F0B4
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Run_d__20.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Run_d__20.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001E5F RID: 7775
		// (get) Token: 0x060063C0 RID: 25536 RVA: 0x00192DFC File Offset: 0x00190FFC
		// (set) Token: 0x060063C1 RID: 25537 RVA: 0x00030ECF File Offset: 0x0002F0CF
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Run_d__20.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Run_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E60 RID: 7776
		// (get) Token: 0x060063C2 RID: 25538 RVA: 0x00192E2C File Offset: 0x0019102C
		// (set) Token: 0x060063C3 RID: 25539 RVA: 0x00030EEE File Offset: 0x0002F0EE
		public unsafe ActionQueue __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Run_d__20.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Run_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x060063C4 RID: 25540 RVA: 0x00192E5C File Offset: 0x0019105C
		// (set) Token: 0x060063C5 RID: 25541 RVA: 0x00030F0D File Offset: 0x0002F10D
		public unsafe PlayAction action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Run_d__20.NativeFieldInfoPtr_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._Run_d__20.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400413F RID: 16703
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004140 RID: 16704
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004141 RID: 16705
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004142 RID: 16706
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04004143 RID: 16707
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004144 RID: 16708
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004145 RID: 16709
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004146 RID: 16710
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004147 RID: 16711
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004148 RID: 16712
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200052A RID: 1322
	[ObfuscatedName("ActionQueue+<PerformAction>d__21")]
	public sealed class _PerformAction_d__21 : Object
	{
		// Token: 0x060063C6 RID: 25542 RVA: 0x00192E8C File Offset: 0x0019108C
		// Note: this type is marked as 'beforefieldinit'.
		static _PerformAction_d__21()
		{
			Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "<PerformAction>d__21");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr);
			ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, "<>1__state");
			ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, "<>2__current");
			ActionQueue._PerformAction_d__21.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, "action");
			ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, "<>4__this");
			ActionQueue._PerformAction_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, 100664734);
			ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, 100664735);
			ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, 100664736);
			ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, 100664737);
			ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, 100664738);
			ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr, 100664739);
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x00192F80 File Offset: 0x00191180
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PerformAction_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionQueue._PerformAction_d__21>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PerformAction_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x00192FC8 File Offset: 0x001911C8
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x00192FFC File Offset: 0x001911FC
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x060063CA RID: 25546 RVA: 0x00193038 File Offset: 0x00191238
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x00193078 File Offset: 0x00191278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27116, XrefRangeEnd = 27122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x060063CC RID: 25548 RVA: 0x001930AC File Offset: 0x001912AC
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PerformAction_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x00030F2C File Offset: 0x0002F12C
		public _PerformAction_d__21(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x060063CE RID: 25550 RVA: 0x001930EC File Offset: 0x001912EC
		// (set) Token: 0x060063CF RID: 25551 RVA: 0x00030F35 File Offset: 0x0002F135
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x060063D0 RID: 25552 RVA: 0x00193114 File Offset: 0x00191314
		// (set) Token: 0x060063D1 RID: 25553 RVA: 0x00030F50 File Offset: 0x0002F150
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x060063D2 RID: 25554 RVA: 0x00193144 File Offset: 0x00191344
		// (set) Token: 0x060063D3 RID: 25555 RVA: 0x00030F6F File Offset: 0x0002F16F
		public unsafe PlayAction action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PerformAction_d__21.NativeFieldInfoPtr_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PerformAction_d__21.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x00193174 File Offset: 0x00191374
		// (set) Token: 0x060063D5 RID: 25557 RVA: 0x00030F8E File Offset: 0x0002F18E
		public unsafe ActionQueue __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PerformAction_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004149 RID: 16713
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400414A RID: 16714
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400414B RID: 16715
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x0400414C RID: 16716
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400414D RID: 16717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400414E RID: 16718
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400414F RID: 16719
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004150 RID: 16720
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004151 RID: 16721
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004152 RID: 16722
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200052B RID: 1323
	[ObfuscatedName("ActionQueue+<PostAction>d__22")]
	public sealed class _PostAction_d__22 : Object
	{
		// Token: 0x060063D6 RID: 25558 RVA: 0x001931A4 File Offset: 0x001913A4
		// Note: this type is marked as 'beforefieldinit'.
		static _PostAction_d__22()
		{
			Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActionQueue>.NativeClassPtr, "<PostAction>d__22");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr);
			ActionQueue._PostAction_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, "<>1__state");
			ActionQueue._PostAction_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, "<>2__current");
			ActionQueue._PostAction_d__22.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, "action");
			ActionQueue._PostAction_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, "<>4__this");
			ActionQueue._PostAction_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, 100664740);
			ActionQueue._PostAction_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, 100664741);
			ActionQueue._PostAction_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, 100664742);
			ActionQueue._PostAction_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, 100664743);
			ActionQueue._PostAction_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, 100664744);
			ActionQueue._PostAction_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr, 100664745);
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x00193298 File Offset: 0x00191498
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PostAction_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActionQueue._PostAction_d__22>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PostAction_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x001932E0 File Offset: 0x001914E0
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PostAction_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x00193314 File Offset: 0x00191514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27122, XrefRangeEnd = 27123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PostAction_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x060063DA RID: 25562 RVA: 0x00193350 File Offset: 0x00191550
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PostAction_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x00193390 File Offset: 0x00191590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27123, XrefRangeEnd = 27129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PostAction_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x060063DC RID: 25564 RVA: 0x001933C4 File Offset: 0x001915C4
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActionQueue._PostAction_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x00030FAD File Offset: 0x0002F1AD
		public _PostAction_d__22(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x00193404 File Offset: 0x00191604
		// (set) Token: 0x060063DF RID: 25567 RVA: 0x00030FB6 File Offset: 0x0002F1B6
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PostAction_d__22.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PostAction_d__22.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x060063E0 RID: 25568 RVA: 0x0019342C File Offset: 0x0019162C
		// (set) Token: 0x060063E1 RID: 25569 RVA: 0x00030FD1 File Offset: 0x0002F1D1
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PostAction_d__22.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PostAction_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x0019345C File Offset: 0x0019165C
		// (set) Token: 0x060063E3 RID: 25571 RVA: 0x00030FF0 File Offset: 0x0002F1F0
		public unsafe PlayAction action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PostAction_d__22.NativeFieldInfoPtr_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayAction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PostAction_d__22.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x0019348C File Offset: 0x0019168C
		// (set) Token: 0x060063E5 RID: 25573 RVA: 0x0003100F File Offset: 0x0002F20F
		public unsafe ActionQueue __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PostAction_d__22.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActionQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActionQueue._PostAction_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004153 RID: 16723
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004154 RID: 16724
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004155 RID: 16725
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04004156 RID: 16726
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004157 RID: 16727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004158 RID: 16728
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004159 RID: 16729
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400415A RID: 16730
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400415B RID: 16731
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400415C RID: 16732
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

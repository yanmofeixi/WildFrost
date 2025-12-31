using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x020000B3 RID: 179
public class PlayAction : Object
{
	// Token: 0x06000795 RID: 1941 RVA: 0x0006B6A0 File Offset: 0x000698A0
	// Note: this type is marked as 'beforefieldinit'.
	static PlayAction()
	{
		Il2CppClassPointerStore<PlayAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayAction");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAction>.NativeClassPtr);
		PlayAction.NativeFieldInfoPtr_pauseBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, "pauseBefore");
		PlayAction.NativeFieldInfoPtr_pauseAfter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, "pauseAfter");
		PlayAction.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, "priority");
		PlayAction.NativeFieldInfoPtr_fixedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, "fixedPosition");
		PlayAction.NativeFieldInfoPtr_parallel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, "parallel");
		PlayAction.NativeFieldInfoPtr_note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, "note");
		PlayAction.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664686);
		PlayAction.NativeMethodInfoPtr_Process_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664687);
		PlayAction.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664688);
		PlayAction.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664689);
		PlayAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAction>.NativeClassPtr, 100664690);
	}

	// Token: 0x170001AE RID: 430
	// (get) Token: 0x06000796 RID: 1942 RVA: 0x0006B7AC File Offset: 0x000699AC
	public unsafe virtual bool IsRoutine
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25335, RefRangeEnd = 25349, XrefRangeStart = 25335, XrefRangeEnd = 25349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayAction.NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x0006B7F4 File Offset: 0x000699F4
	[CallerCount(12683)]
	[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Process()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayAction.NativeMethodInfoPtr_Process_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0006B830 File Offset: 0x00069A30
	[CallerCount(44)]
	[CachedScanResults(RefRangeStart = 27019, RefRangeEnd = 27063, XrefRangeStart = 27019, XrefRangeEnd = 27019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator Run()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayAction.NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x170001AF RID: 431
	// (get) Token: 0x06000799 RID: 1945 RVA: 0x0006B87C File Offset: 0x00069A7C
	public unsafe virtual string Name
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27063, XrefRangeEnd = 27075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayAction.NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x0006B8C0 File Offset: 0x00069AC0
	[CallerCount(1911)]
	[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAction>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x000051D7 File Offset: 0x000033D7
	public PlayAction(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170001A8 RID: 424
	// (get) Token: 0x0600079C RID: 1948 RVA: 0x0006B8FC File Offset: 0x00069AFC
	// (set) Token: 0x0600079D RID: 1949 RVA: 0x000051E0 File Offset: 0x000033E0
	public unsafe float pauseBefore
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_pauseBefore);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_pauseBefore)) = value;
		}
	}

	// Token: 0x170001A9 RID: 425
	// (get) Token: 0x0600079E RID: 1950 RVA: 0x0006B924 File Offset: 0x00069B24
	// (set) Token: 0x0600079F RID: 1951 RVA: 0x000051FB File Offset: 0x000033FB
	public unsafe float pauseAfter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_pauseAfter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_pauseAfter)) = value;
		}
	}

	// Token: 0x170001AA RID: 426
	// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0006B94C File Offset: 0x00069B4C
	// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00005216 File Offset: 0x00003416
	public unsafe int priority
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_priority);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_priority)) = value;
		}
	}

	// Token: 0x170001AB RID: 427
	// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0006B974 File Offset: 0x00069B74
	// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00005231 File Offset: 0x00003431
	public unsafe bool fixedPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_fixedPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_fixedPosition)) = value;
		}
	}

	// Token: 0x170001AC RID: 428
	// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0006B99C File Offset: 0x00069B9C
	// (set) Token: 0x060007A5 RID: 1957 RVA: 0x0000524C File Offset: 0x0000344C
	public unsafe bool parallel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_parallel);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_parallel)) = value;
		}
	}

	// Token: 0x170001AD RID: 429
	// (get) Token: 0x060007A6 RID: 1958 RVA: 0x0006B9C4 File Offset: 0x00069BC4
	// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00005267 File Offset: 0x00003467
	public unsafe string note
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_note);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAction.NativeFieldInfoPtr_note), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040004B1 RID: 1201
	private static readonly IntPtr NativeFieldInfoPtr_pauseBefore;

	// Token: 0x040004B2 RID: 1202
	private static readonly IntPtr NativeFieldInfoPtr_pauseAfter;

	// Token: 0x040004B3 RID: 1203
	private static readonly IntPtr NativeFieldInfoPtr_priority;

	// Token: 0x040004B4 RID: 1204
	private static readonly IntPtr NativeFieldInfoPtr_fixedPosition;

	// Token: 0x040004B5 RID: 1205
	private static readonly IntPtr NativeFieldInfoPtr_parallel;

	// Token: 0x040004B6 RID: 1206
	private static readonly IntPtr NativeFieldInfoPtr_note;

	// Token: 0x040004B7 RID: 1207
	private static readonly IntPtr NativeMethodInfoPtr_get_IsRoutine_Public_Virtual_New_get_Boolean_0;

	// Token: 0x040004B8 RID: 1208
	private static readonly IntPtr NativeMethodInfoPtr_Process_Public_Virtual_New_Void_0;

	// Token: 0x040004B9 RID: 1209
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_New_IEnumerator_0;

	// Token: 0x040004BA RID: 1210
	private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_New_get_String_0;

	// Token: 0x040004BB RID: 1211
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.SceneManagement;

// Token: 0x020001DC RID: 476
public class RedrawBellSystem : GameSystem
{
	// Token: 0x060021E7 RID: 8679 RVA: 0x000BBB18 File Offset: 0x000B9D18
	// Note: this type is marked as 'beforefieldinit'.
	static RedrawBellSystem()
	{
		Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "RedrawBellSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr);
		RedrawBellSystem.NativeFieldInfoPtr__rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "_rectTransform");
		RedrawBellSystem.NativeFieldInfoPtr_bell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "bell");
		RedrawBellSystem.NativeFieldInfoPtr_bellActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "bellActive");
		RedrawBellSystem.NativeFieldInfoPtr_chargeParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "chargeParticleSystem");
		RedrawBellSystem.NativeFieldInfoPtr_hitParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "hitParticleSystem");
		RedrawBellSystem.NativeFieldInfoPtr_navigationItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "navigationItem");
		RedrawBellSystem.NativeFieldInfoPtr_counterChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "counterChange");
		RedrawBellSystem.NativeFieldInfoPtr_counterIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "counterIcon");
		RedrawBellSystem.NativeFieldInfoPtr_popUpKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "popUpKeyword");
		RedrawBellSystem.NativeFieldInfoPtr_popUpOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "popUpOffset");
		RedrawBellSystem.NativeFieldInfoPtr_textNotCharged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "textNotCharged");
		RedrawBellSystem.NativeFieldInfoPtr_textCharged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "textCharged");
		RedrawBellSystem.NativeFieldInfoPtr__animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "_animator");
		RedrawBellSystem.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "owner");
		RedrawBellSystem.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "controller");
		RedrawBellSystem.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "counter");
		RedrawBellSystem.NativeFieldInfoPtr_reset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "reset");
		RedrawBellSystem.NativeFieldInfoPtr_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "interactable");
		RedrawBellSystem.NativeFieldInfoPtr_poppedUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "poppedUp");
		RedrawBellSystem.NativeFieldInfoPtr_nav = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, "nav");
		RedrawBellSystem.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669017);
		RedrawBellSystem.NativeMethodInfoPtr_get_animator_Private_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669018);
		RedrawBellSystem.NativeMethodInfoPtr_get_IsCharged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669019);
		RedrawBellSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669020);
		RedrawBellSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669021);
		RedrawBellSystem.NativeMethodInfoPtr_BecomeInteractable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669022);
		RedrawBellSystem.NativeMethodInfoPtr_Show_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669023);
		RedrawBellSystem.NativeMethodInfoPtr_Hide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669024);
		RedrawBellSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669025);
		RedrawBellSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669026);
		RedrawBellSystem.NativeMethodInfoPtr_CounterIncrement_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669027);
		RedrawBellSystem.NativeMethodInfoPtr_Assign_Public_Void_Character_CardController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669028);
		RedrawBellSystem.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669029);
		RedrawBellSystem.NativeMethodInfoPtr_Counter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669030);
		RedrawBellSystem.NativeMethodInfoPtr_SetCounter_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669031);
		RedrawBellSystem.NativeMethodInfoPtr_Pop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669032);
		RedrawBellSystem.NativeMethodInfoPtr_UnPop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669033);
		RedrawBellSystem.NativeMethodInfoPtr_AnimatorTrigger_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669034);
		RedrawBellSystem.NativeMethodInfoPtr_AnimatorSetHover_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669035);
		RedrawBellSystem.NativeMethodInfoPtr_AnimatorSetPress_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669036);
		RedrawBellSystem.NativeMethodInfoPtr_PlayChargeParticleSystem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669037);
		RedrawBellSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr, 100669038);
	}

	// Token: 0x170009CD RID: 2509
	// (get) Token: 0x060021E8 RID: 8680 RVA: 0x000BBE90 File Offset: 0x000BA090
	public unsafe RectTransform rectTransform
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69448, XrefRangeEnd = 69452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}
	}

	// Token: 0x170009CE RID: 2510
	// (get) Token: 0x060021E9 RID: 8681 RVA: 0x000BBED0 File Offset: 0x000BA0D0
	public unsafe UnityEngine.Animator animator
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69452, XrefRangeEnd = 69456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_get_animator_Private_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.Animator>(intPtr3) : null;
		}
	}

	// Token: 0x170009CF RID: 2511
	// (get) Token: 0x060021EA RID: 8682 RVA: 0x000BBF10 File Offset: 0x000BA110
	public unsafe bool IsCharged
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 69457, RefRangeEnd = 69458, XrefRangeStart = 69456, XrefRangeEnd = 69457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_get_IsCharged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x000BBF4C File Offset: 0x000BA14C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69458, XrefRangeEnd = 69484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000BBF80 File Offset: 0x000BA180
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69484, XrefRangeEnd = 69506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x000BBFB4 File Offset: 0x000BA1B4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 69528, RefRangeEnd = 69531, XrefRangeStart = 69506, XrefRangeEnd = 69528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BecomeInteractable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_BecomeInteractable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000BBFE8 File Offset: 0x000BA1E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69531, XrefRangeEnd = 69546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Show_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000BC01C File Offset: 0x000BA21C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 69551, RefRangeEnd = 69553, XrefRangeStart = 69546, XrefRangeEnd = 69551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Hide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x000BC050 File Offset: 0x000BA250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69553, XrefRangeEnd = 69558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SceneChanged(Scene scene)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref scene;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x000BC090 File Offset: 0x000BA290
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69558, XrefRangeEnd = 69581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattlePhaseStart(Battle.Phase phase)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref phase;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x000BC0D0 File Offset: 0x000BA2D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69581, XrefRangeEnd = 69597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CounterIncrement(int turnNumber)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref turnNumber;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_CounterIncrement_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x000BC110 File Offset: 0x000BA310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69597, XrefRangeEnd = 69603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Assign(Character owner, CardController controller)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controller);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Assign_Public_Void_Character_CardController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x000BC164 File Offset: 0x000BA364
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69603, XrefRangeEnd = 69651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Activate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x000BC198 File Offset: 0x000BA398
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69651, XrefRangeEnd = 69665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Counter()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Counter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x000BC1CC File Offset: 0x000BA3CC
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 69689, RefRangeEnd = 69698, XrefRangeStart = 69665, XrefRangeEnd = 69689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCounter(int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_SetCounter_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x000BC20C File Offset: 0x000BA40C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69698, XrefRangeEnd = 69728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_Pop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000BC240 File Offset: 0x000BA440
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69728, XrefRangeEnd = 69730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnPop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_UnPop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x000BC274 File Offset: 0x000BA474
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 69736, RefRangeEnd = 69742, XrefRangeStart = 69730, XrefRangeEnd = 69736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimatorTrigger(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_AnimatorTrigger_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x000BC2B8 File Offset: 0x000BA4B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69742, XrefRangeEnd = 69750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimatorSetHover(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_AnimatorSetHover_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x000BC2F8 File Offset: 0x000BA4F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69750, XrefRangeEnd = 69758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AnimatorSetPress(bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_AnimatorSetPress_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000BC338 File Offset: 0x000BA538
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69758, XrefRangeEnd = 69760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayChargeParticleSystem()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr_PlayChargeParticleSystem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x000BC36C File Offset: 0x000BA56C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69760, XrefRangeEnd = 69761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RedrawBellSystem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RedrawBellSystem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RedrawBellSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x00013421 File Offset: 0x00011621
	public RedrawBellSystem(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170009B9 RID: 2489
	// (get) Token: 0x060021FF RID: 8703 RVA: 0x000BC3A8 File Offset: 0x000BA5A8
	// (set) Token: 0x06002200 RID: 8704 RVA: 0x0001342A File Offset: 0x0001162A
	public unsafe RectTransform _rectTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr__rectTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr__rectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009BA RID: 2490
	// (get) Token: 0x06002201 RID: 8705 RVA: 0x000BC3D8 File Offset: 0x000BA5D8
	// (set) Token: 0x06002202 RID: 8706 RVA: 0x00013449 File Offset: 0x00011649
	public unsafe GameObject bell
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_bell);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_bell), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009BB RID: 2491
	// (get) Token: 0x06002203 RID: 8707 RVA: 0x000BC408 File Offset: 0x000BA608
	// (set) Token: 0x06002204 RID: 8708 RVA: 0x00013468 File Offset: 0x00011668
	public unsafe GameObject bellActive
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_bellActive);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_bellActive), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009BC RID: 2492
	// (get) Token: 0x06002205 RID: 8709 RVA: 0x000BC438 File Offset: 0x000BA638
	// (set) Token: 0x06002206 RID: 8710 RVA: 0x00013487 File Offset: 0x00011687
	public unsafe ParticleSystem chargeParticleSystem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_chargeParticleSystem);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_chargeParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009BD RID: 2493
	// (get) Token: 0x06002207 RID: 8711 RVA: 0x000BC468 File Offset: 0x000BA668
	// (set) Token: 0x06002208 RID: 8712 RVA: 0x000134A6 File Offset: 0x000116A6
	public unsafe ParticleSystem hitParticleSystem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_hitParticleSystem);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_hitParticleSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009BE RID: 2494
	// (get) Token: 0x06002209 RID: 8713 RVA: 0x000BC498 File Offset: 0x000BA698
	// (set) Token: 0x0600220A RID: 8714 RVA: 0x000134C5 File Offset: 0x000116C5
	public unsafe UINavigationItem navigationItem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_navigationItem);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UINavigationItem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_navigationItem), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009BF RID: 2495
	// (get) Token: 0x0600220B RID: 8715 RVA: 0x000BC4C8 File Offset: 0x000BA6C8
	// (set) Token: 0x0600220C RID: 8716 RVA: 0x000134E4 File Offset: 0x000116E4
	public unsafe int counterChange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counterChange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counterChange)) = value;
		}
	}

	// Token: 0x170009C0 RID: 2496
	// (get) Token: 0x0600220D RID: 8717 RVA: 0x000BC4F0 File Offset: 0x000BA6F0
	// (set) Token: 0x0600220E RID: 8718 RVA: 0x000134FF File Offset: 0x000116FF
	public unsafe StatusIcon counterIcon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counterIcon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusIcon>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counterIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009C1 RID: 2497
	// (get) Token: 0x0600220F RID: 8719 RVA: 0x000BC520 File Offset: 0x000BA720
	// (set) Token: 0x06002210 RID: 8720 RVA: 0x0001351E File Offset: 0x0001171E
	public unsafe KeywordData popUpKeyword
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_popUpKeyword);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeywordData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_popUpKeyword), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009C2 RID: 2498
	// (get) Token: 0x06002211 RID: 8721 RVA: 0x000BC550 File Offset: 0x000BA750
	// (set) Token: 0x06002212 RID: 8722 RVA: 0x0001353D File Offset: 0x0001173D
	public unsafe Vector2 popUpOffset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_popUpOffset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_popUpOffset)) = value;
		}
	}

	// Token: 0x170009C3 RID: 2499
	// (get) Token: 0x06002213 RID: 8723 RVA: 0x000BC578 File Offset: 0x000BA778
	// (set) Token: 0x06002214 RID: 8724 RVA: 0x00013558 File Offset: 0x00011758
	public unsafe LocalizedString textNotCharged
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_textNotCharged);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_textNotCharged), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009C4 RID: 2500
	// (get) Token: 0x06002215 RID: 8725 RVA: 0x000BC5A8 File Offset: 0x000BA7A8
	// (set) Token: 0x06002216 RID: 8726 RVA: 0x00013577 File Offset: 0x00011777
	public unsafe LocalizedString textCharged
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_textCharged);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_textCharged), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009C5 RID: 2501
	// (get) Token: 0x06002217 RID: 8727 RVA: 0x000BC5D8 File Offset: 0x000BA7D8
	// (set) Token: 0x06002218 RID: 8728 RVA: 0x00013596 File Offset: 0x00011796
	public unsafe UnityEngine.Animator _animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr__animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr__animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009C6 RID: 2502
	// (get) Token: 0x06002219 RID: 8729 RVA: 0x000BC608 File Offset: 0x000BA808
	// (set) Token: 0x0600221A RID: 8730 RVA: 0x000135B5 File Offset: 0x000117B5
	public unsafe Character owner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_owner);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009C7 RID: 2503
	// (get) Token: 0x0600221B RID: 8731 RVA: 0x000BC638 File Offset: 0x000BA838
	// (set) Token: 0x0600221C RID: 8732 RVA: 0x000135D4 File Offset: 0x000117D4
	public unsafe CardController controller
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_controller);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardController>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009C8 RID: 2504
	// (get) Token: 0x0600221D RID: 8733 RVA: 0x000BC668 File Offset: 0x000BA868
	// (set) Token: 0x0600221E RID: 8734 RVA: 0x000135F3 File Offset: 0x000117F3
	public unsafe Stat counter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_counter)) = value;
		}
	}

	// Token: 0x170009C9 RID: 2505
	// (get) Token: 0x0600221F RID: 8735 RVA: 0x000BC690 File Offset: 0x000BA890
	// (set) Token: 0x06002220 RID: 8736 RVA: 0x0001360E File Offset: 0x0001180E
	public unsafe bool reset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_reset);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_reset)) = value;
		}
	}

	// Token: 0x170009CA RID: 2506
	// (get) Token: 0x06002221 RID: 8737 RVA: 0x000BC6B8 File Offset: 0x000BA8B8
	// (set) Token: 0x06002222 RID: 8738 RVA: 0x00013629 File Offset: 0x00011829
	public unsafe bool interactable
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_interactable);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_interactable)) = value;
		}
	}

	// Token: 0x170009CB RID: 2507
	// (get) Token: 0x06002223 RID: 8739 RVA: 0x000BC6E0 File Offset: 0x000BA8E0
	// (set) Token: 0x06002224 RID: 8740 RVA: 0x00013644 File Offset: 0x00011844
	public unsafe bool poppedUp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_poppedUp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RedrawBellSystem.NativeFieldInfoPtr_poppedUp)) = value;
		}
	}

	// Token: 0x170009CC RID: 2508
	// (get) Token: 0x06002225 RID: 8741 RVA: 0x000BC708 File Offset: 0x000BA908
	// (set) Token: 0x06002226 RID: 8742 RVA: 0x0001365F File Offset: 0x0001185F
	public unsafe static UINavigationItem nav
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(RedrawBellSystem.NativeFieldInfoPtr_nav, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UINavigationItem>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(RedrawBellSystem.NativeFieldInfoPtr_nav, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04001541 RID: 5441
	private static readonly IntPtr NativeFieldInfoPtr__rectTransform;

	// Token: 0x04001542 RID: 5442
	private static readonly IntPtr NativeFieldInfoPtr_bell;

	// Token: 0x04001543 RID: 5443
	private static readonly IntPtr NativeFieldInfoPtr_bellActive;

	// Token: 0x04001544 RID: 5444
	private static readonly IntPtr NativeFieldInfoPtr_chargeParticleSystem;

	// Token: 0x04001545 RID: 5445
	private static readonly IntPtr NativeFieldInfoPtr_hitParticleSystem;

	// Token: 0x04001546 RID: 5446
	private static readonly IntPtr NativeFieldInfoPtr_navigationItem;

	// Token: 0x04001547 RID: 5447
	private static readonly IntPtr NativeFieldInfoPtr_counterChange;

	// Token: 0x04001548 RID: 5448
	private static readonly IntPtr NativeFieldInfoPtr_counterIcon;

	// Token: 0x04001549 RID: 5449
	private static readonly IntPtr NativeFieldInfoPtr_popUpKeyword;

	// Token: 0x0400154A RID: 5450
	private static readonly IntPtr NativeFieldInfoPtr_popUpOffset;

	// Token: 0x0400154B RID: 5451
	private static readonly IntPtr NativeFieldInfoPtr_textNotCharged;

	// Token: 0x0400154C RID: 5452
	private static readonly IntPtr NativeFieldInfoPtr_textCharged;

	// Token: 0x0400154D RID: 5453
	private static readonly IntPtr NativeFieldInfoPtr__animator;

	// Token: 0x0400154E RID: 5454
	private static readonly IntPtr NativeFieldInfoPtr_owner;

	// Token: 0x0400154F RID: 5455
	private static readonly IntPtr NativeFieldInfoPtr_controller;

	// Token: 0x04001550 RID: 5456
	private static readonly IntPtr NativeFieldInfoPtr_counter;

	// Token: 0x04001551 RID: 5457
	private static readonly IntPtr NativeFieldInfoPtr_reset;

	// Token: 0x04001552 RID: 5458
	private static readonly IntPtr NativeFieldInfoPtr_interactable;

	// Token: 0x04001553 RID: 5459
	private static readonly IntPtr NativeFieldInfoPtr_poppedUp;

	// Token: 0x04001554 RID: 5460
	private static readonly IntPtr NativeFieldInfoPtr_nav;

	// Token: 0x04001555 RID: 5461
	private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;

	// Token: 0x04001556 RID: 5462
	private static readonly IntPtr NativeMethodInfoPtr_get_animator_Private_get_Animator_0;

	// Token: 0x04001557 RID: 5463
	private static readonly IntPtr NativeMethodInfoPtr_get_IsCharged_Public_get_Boolean_0;

	// Token: 0x04001558 RID: 5464
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04001559 RID: 5465
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x0400155A RID: 5466
	private static readonly IntPtr NativeMethodInfoPtr_BecomeInteractable_Public_Void_0;

	// Token: 0x0400155B RID: 5467
	private static readonly IntPtr NativeMethodInfoPtr_Show_Private_Void_0;

	// Token: 0x0400155C RID: 5468
	private static readonly IntPtr NativeMethodInfoPtr_Hide_Private_Void_0;

	// Token: 0x0400155D RID: 5469
	private static readonly IntPtr NativeMethodInfoPtr_SceneChanged_Private_Void_Scene_0;

	// Token: 0x0400155E RID: 5470
	private static readonly IntPtr NativeMethodInfoPtr_BattlePhaseStart_Private_Void_Phase_0;

	// Token: 0x0400155F RID: 5471
	private static readonly IntPtr NativeMethodInfoPtr_CounterIncrement_Private_Void_Int32_0;

	// Token: 0x04001560 RID: 5472
	private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_Character_CardController_0;

	// Token: 0x04001561 RID: 5473
	private static readonly IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;

	// Token: 0x04001562 RID: 5474
	private static readonly IntPtr NativeMethodInfoPtr_Counter_Public_Void_0;

	// Token: 0x04001563 RID: 5475
	private static readonly IntPtr NativeMethodInfoPtr_SetCounter_Public_Void_Int32_0;

	// Token: 0x04001564 RID: 5476
	private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Void_0;

	// Token: 0x04001565 RID: 5477
	private static readonly IntPtr NativeMethodInfoPtr_UnPop_Public_Void_0;

	// Token: 0x04001566 RID: 5478
	private static readonly IntPtr NativeMethodInfoPtr_AnimatorTrigger_Public_Void_String_0;

	// Token: 0x04001567 RID: 5479
	private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetHover_Public_Void_Boolean_0;

	// Token: 0x04001568 RID: 5480
	private static readonly IntPtr NativeMethodInfoPtr_AnimatorSetPress_Public_Void_Boolean_0;

	// Token: 0x04001569 RID: 5481
	private static readonly IntPtr NativeMethodInfoPtr_PlayChargeParticleSystem_Public_Void_0;

	// Token: 0x0400156A RID: 5482
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

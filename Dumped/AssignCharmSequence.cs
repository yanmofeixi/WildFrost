using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020002BF RID: 703
public class AssignCharmSequence : UISequence
{
	// Token: 0x06003538 RID: 13624 RVA: 0x000F64C0 File Offset: 0x000F46C0
	// Note: this type is marked as 'beforefieldinit'.
	static AssignCharmSequence()
	{
		Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AssignCharmSequence");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr);
		AssignCharmSequence.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "background");
		AssignCharmSequence.NativeFieldInfoPtr_backgroundAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "backgroundAlpha");
		AssignCharmSequence.NativeFieldInfoPtr_cardHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "cardHolder");
		AssignCharmSequence.NativeFieldInfoPtr_cardScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "cardScale");
		AssignCharmSequence.NativeFieldInfoPtr_glows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "glows");
		AssignCharmSequence.NativeFieldInfoPtr_ding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "ding");
		AssignCharmSequence.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "animator");
		AssignCharmSequence.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "target");
		AssignCharmSequence.NativeFieldInfoPtr_upgradeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "upgradeData");
		AssignCharmSequence.NativeFieldInfoPtr_fade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "fade");
		AssignCharmSequence.NativeFieldInfoPtr_fadeInDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "fadeInDur");
		AssignCharmSequence.NativeFieldInfoPtr_fadeOutDur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "fadeOutDur");
		AssignCharmSequence.NativeFieldInfoPtr_previousParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "previousParent");
		AssignCharmSequence.NativeFieldInfoPtr_previousChildIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "previousChildIndex");
		AssignCharmSequence.NativeFieldInfoPtr_previousPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "previousPosition");
		AssignCharmSequence.NativeMethodInfoPtr_Assign_Public_Void_Entity_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671948);
		AssignCharmSequence.NativeMethodInfoPtr_Focus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671949);
		AssignCharmSequence.NativeMethodInfoPtr_Unfocus_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671950);
		AssignCharmSequence.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671951);
		AssignCharmSequence.NativeMethodInfoPtr_BackgroundFade_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671952);
		AssignCharmSequence.NativeMethodInfoPtr_Rumble_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671953);
		AssignCharmSequence.NativeMethodInfoPtr_AssignCharm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671954);
		AssignCharmSequence.NativeMethodInfoPtr_StartGlow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671955);
		AssignCharmSequence.NativeMethodInfoPtr_Ding_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671956);
		AssignCharmSequence.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671957);
		AssignCharmSequence.NativeMethodInfoPtr__BackgroundFade_b__19_0_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, 100671959);
	}

	// Token: 0x06003539 RID: 13625 RVA: 0x000F66F8 File Offset: 0x000F48F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99005, XrefRangeEnd = 99007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Assign(Entity target, CardUpgradeData upgradeData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(upgradeData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr_Assign_Public_Void_Entity_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600353A RID: 13626 RVA: 0x000F674C File Offset: 0x000F494C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99007, XrefRangeEnd = 99039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Focus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr_Focus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600353B RID: 13627 RVA: 0x000F6780 File Offset: 0x000F4980
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99039, XrefRangeEnd = 99050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unfocus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr_Unfocus_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600353C RID: 13628 RVA: 0x000F67B4 File Offset: 0x000F49B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99050, XrefRangeEnd = 99055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator Run()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssignCharmSequence.NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600353D RID: 13629 RVA: 0x000F6800 File Offset: 0x000F4A00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99055, XrefRangeEnd = 99071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BackgroundFade(float alpha, float dur)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref alpha;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dur;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr_BackgroundFade_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600353E RID: 13630 RVA: 0x000F684C File Offset: 0x000F4A4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99071, XrefRangeEnd = 99072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Rumble()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr_Rumble_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600353F RID: 13631 RVA: 0x000F6880 File Offset: 0x000F4A80
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99072, XrefRangeEnd = 99078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AssignCharm()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr_AssignCharm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003540 RID: 13632 RVA: 0x000F68B4 File Offset: 0x000F4AB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99078, XrefRangeEnd = 99080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StartGlow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr_StartGlow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003541 RID: 13633 RVA: 0x000F68E8 File Offset: 0x000F4AE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99080, XrefRangeEnd = 99082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Ding()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr_Ding_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003542 RID: 13634 RVA: 0x000F691C File Offset: 0x000F4B1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99082, XrefRangeEnd = 99083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AssignCharmSequence() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003543 RID: 13635 RVA: 0x000F6958 File Offset: 0x000F4B58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99083, XrefRangeEnd = 99084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _BackgroundFade_b__19_0(float a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref a;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence.NativeMethodInfoPtr__BackgroundFade_b__19_0_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003544 RID: 13636 RVA: 0x0001D750 File Offset: 0x0001B950
	public AssignCharmSequence(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000F92 RID: 3986
	// (get) Token: 0x06003545 RID: 13637 RVA: 0x000F6998 File Offset: 0x000F4B98
	// (set) Token: 0x06003546 RID: 13638 RVA: 0x0001D759 File Offset: 0x0001B959
	public unsafe Image background
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_background);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000F93 RID: 3987
	// (get) Token: 0x06003547 RID: 13639 RVA: 0x000F69C8 File Offset: 0x000F4BC8
	// (set) Token: 0x06003548 RID: 13640 RVA: 0x0001D778 File Offset: 0x0001B978
	public unsafe float backgroundAlpha
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_backgroundAlpha);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_backgroundAlpha)) = value;
		}
	}

	// Token: 0x17000F94 RID: 3988
	// (get) Token: 0x06003549 RID: 13641 RVA: 0x000F69F0 File Offset: 0x000F4BF0
	// (set) Token: 0x0600354A RID: 13642 RVA: 0x0001D793 File Offset: 0x0001B993
	public unsafe Transform cardHolder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_cardHolder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_cardHolder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000F95 RID: 3989
	// (get) Token: 0x0600354B RID: 13643 RVA: 0x000F6A20 File Offset: 0x000F4C20
	// (set) Token: 0x0600354C RID: 13644 RVA: 0x0001D7B2 File Offset: 0x0001B9B2
	public unsafe float cardScale
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_cardScale);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_cardScale)) = value;
		}
	}

	// Token: 0x17000F96 RID: 3990
	// (get) Token: 0x0600354D RID: 13645 RVA: 0x000F6A48 File Offset: 0x000F4C48
	// (set) Token: 0x0600354E RID: 13646 RVA: 0x0001D7CD File Offset: 0x0001B9CD
	public unsafe ParticleSystem glows
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_glows);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_glows), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000F97 RID: 3991
	// (get) Token: 0x0600354F RID: 13647 RVA: 0x000F6A78 File Offset: 0x000F4C78
	// (set) Token: 0x06003550 RID: 13648 RVA: 0x0001D7EC File Offset: 0x0001B9EC
	public unsafe ParticleSystem ding
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_ding);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_ding), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000F98 RID: 3992
	// (get) Token: 0x06003551 RID: 13649 RVA: 0x000F6AA8 File Offset: 0x000F4CA8
	// (set) Token: 0x06003552 RID: 13650 RVA: 0x0001D80B File Offset: 0x0001BA0B
	public unsafe UnityEngine.Animator animator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_animator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Animator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000F99 RID: 3993
	// (get) Token: 0x06003553 RID: 13651 RVA: 0x000F6AD8 File Offset: 0x000F4CD8
	// (set) Token: 0x06003554 RID: 13652 RVA: 0x0001D82A File Offset: 0x0001BA2A
	public unsafe Entity target
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_target);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000F9A RID: 3994
	// (get) Token: 0x06003555 RID: 13653 RVA: 0x000F6B08 File Offset: 0x000F4D08
	// (set) Token: 0x06003556 RID: 13654 RVA: 0x0001D849 File Offset: 0x0001BA49
	public unsafe CardUpgradeData upgradeData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_upgradeData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardUpgradeData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_upgradeData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000F9B RID: 3995
	// (get) Token: 0x06003557 RID: 13655 RVA: 0x000F6B38 File Offset: 0x000F4D38
	// (set) Token: 0x06003558 RID: 13656 RVA: 0x0001D868 File Offset: 0x0001BA68
	public unsafe float fade
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_fade);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_fade)) = value;
		}
	}

	// Token: 0x17000F9C RID: 3996
	// (get) Token: 0x06003559 RID: 13657 RVA: 0x000F6B60 File Offset: 0x000F4D60
	// (set) Token: 0x0600355A RID: 13658 RVA: 0x0001D883 File Offset: 0x0001BA83
	public unsafe static float fadeInDur
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(AssignCharmSequence.NativeFieldInfoPtr_fadeInDur, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AssignCharmSequence.NativeFieldInfoPtr_fadeInDur, (void*)(&value));
		}
	}

	// Token: 0x17000F9D RID: 3997
	// (get) Token: 0x0600355B RID: 13659 RVA: 0x000F6B7C File Offset: 0x000F4D7C
	// (set) Token: 0x0600355C RID: 13660 RVA: 0x0001D891 File Offset: 0x0001BA91
	public unsafe static float fadeOutDur
	{
		get
		{
			float result;
			IL2CPP.il2cpp_field_static_get_value(AssignCharmSequence.NativeFieldInfoPtr_fadeOutDur, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AssignCharmSequence.NativeFieldInfoPtr_fadeOutDur, (void*)(&value));
		}
	}

	// Token: 0x17000F9E RID: 3998
	// (get) Token: 0x0600355D RID: 13661 RVA: 0x000F6B98 File Offset: 0x000F4D98
	// (set) Token: 0x0600355E RID: 13662 RVA: 0x0001D89F File Offset: 0x0001BA9F
	public unsafe Transform previousParent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_previousParent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_previousParent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000F9F RID: 3999
	// (get) Token: 0x0600355F RID: 13663 RVA: 0x000F6BC8 File Offset: 0x000F4DC8
	// (set) Token: 0x06003560 RID: 13664 RVA: 0x0001D8BE File Offset: 0x0001BABE
	public unsafe int previousChildIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_previousChildIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_previousChildIndex)) = value;
		}
	}

	// Token: 0x17000FA0 RID: 4000
	// (get) Token: 0x06003561 RID: 13665 RVA: 0x000F6BF0 File Offset: 0x000F4DF0
	// (set) Token: 0x06003562 RID: 13666 RVA: 0x0001D8D9 File Offset: 0x0001BAD9
	public unsafe Vector3 previousPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_previousPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence.NativeFieldInfoPtr_previousPosition)) = value;
		}
	}

	// Token: 0x04002156 RID: 8534
	private static readonly IntPtr NativeFieldInfoPtr_background;

	// Token: 0x04002157 RID: 8535
	private static readonly IntPtr NativeFieldInfoPtr_backgroundAlpha;

	// Token: 0x04002158 RID: 8536
	private static readonly IntPtr NativeFieldInfoPtr_cardHolder;

	// Token: 0x04002159 RID: 8537
	private static readonly IntPtr NativeFieldInfoPtr_cardScale;

	// Token: 0x0400215A RID: 8538
	private static readonly IntPtr NativeFieldInfoPtr_glows;

	// Token: 0x0400215B RID: 8539
	private static readonly IntPtr NativeFieldInfoPtr_ding;

	// Token: 0x0400215C RID: 8540
	private static readonly IntPtr NativeFieldInfoPtr_animator;

	// Token: 0x0400215D RID: 8541
	private static readonly IntPtr NativeFieldInfoPtr_target;

	// Token: 0x0400215E RID: 8542
	private static readonly IntPtr NativeFieldInfoPtr_upgradeData;

	// Token: 0x0400215F RID: 8543
	private static readonly IntPtr NativeFieldInfoPtr_fade;

	// Token: 0x04002160 RID: 8544
	private static readonly IntPtr NativeFieldInfoPtr_fadeInDur;

	// Token: 0x04002161 RID: 8545
	private static readonly IntPtr NativeFieldInfoPtr_fadeOutDur;

	// Token: 0x04002162 RID: 8546
	private static readonly IntPtr NativeFieldInfoPtr_previousParent;

	// Token: 0x04002163 RID: 8547
	private static readonly IntPtr NativeFieldInfoPtr_previousChildIndex;

	// Token: 0x04002164 RID: 8548
	private static readonly IntPtr NativeFieldInfoPtr_previousPosition;

	// Token: 0x04002165 RID: 8549
	private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_Entity_CardUpgradeData_0;

	// Token: 0x04002166 RID: 8550
	private static readonly IntPtr NativeMethodInfoPtr_Focus_Private_Void_0;

	// Token: 0x04002167 RID: 8551
	private static readonly IntPtr NativeMethodInfoPtr_Unfocus_Private_Void_0;

	// Token: 0x04002168 RID: 8552
	private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_IEnumerator_0;

	// Token: 0x04002169 RID: 8553
	private static readonly IntPtr NativeMethodInfoPtr_BackgroundFade_Private_Void_Single_Single_0;

	// Token: 0x0400216A RID: 8554
	private static readonly IntPtr NativeMethodInfoPtr_Rumble_Private_Void_0;

	// Token: 0x0400216B RID: 8555
	private static readonly IntPtr NativeMethodInfoPtr_AssignCharm_Private_Void_0;

	// Token: 0x0400216C RID: 8556
	private static readonly IntPtr NativeMethodInfoPtr_StartGlow_Private_Void_0;

	// Token: 0x0400216D RID: 8557
	private static readonly IntPtr NativeMethodInfoPtr_Ding_Private_Void_0;

	// Token: 0x0400216E RID: 8558
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0400216F RID: 8559
	private static readonly IntPtr NativeMethodInfoPtr__BackgroundFade_b__19_0_Private_Void_Single_0;

	// Token: 0x020007FC RID: 2044
	[ObfuscatedName("AssignCharmSequence+<Run>d__18")]
	public sealed class _Run_d__18 : Il2CppSystem.Object
	{
		// Token: 0x0600845B RID: 33883 RVA: 0x001F5148 File Offset: 0x001F3348
		// Note: this type is marked as 'beforefieldinit'.
		static _Run_d__18()
		{
			Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssignCharmSequence>.NativeClassPtr, "<Run>d__18");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr);
			AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, "<>1__state");
			AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, "<>2__current");
			AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, "<>4__this");
			AssignCharmSequence._Run_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, 100671960);
			AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, 100671961);
			AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, 100671962);
			AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, 100671963);
			AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, 100671964);
			AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr, 100671965);
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x001F5228 File Offset: 0x001F3428
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Run_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssignCharmSequence._Run_d__18>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence._Run_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x001F5270 File Offset: 0x001F3470
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x001F52A4 File Offset: 0x001F34A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98992, XrefRangeEnd = 98999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002913 RID: 10515
		// (get) Token: 0x0600845F RID: 33887 RVA: 0x001F52E0 File Offset: 0x001F34E0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x001F5320 File Offset: 0x001F3520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98999, XrefRangeEnd = 99005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002914 RID: 10516
		// (get) Token: 0x06008461 RID: 33889 RVA: 0x001F5354 File Offset: 0x001F3554
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssignCharmSequence._Run_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x00041133 File Offset: 0x0003F333
		public _Run_d__18(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002910 RID: 10512
		// (get) Token: 0x06008463 RID: 33891 RVA: 0x001F5394 File Offset: 0x001F3594
		// (set) Token: 0x06008464 RID: 33892 RVA: 0x0004113C File Offset: 0x0003F33C
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002911 RID: 10513
		// (get) Token: 0x06008465 RID: 33893 RVA: 0x001F53BC File Offset: 0x001F35BC
		// (set) Token: 0x06008466 RID: 33894 RVA: 0x00041157 File Offset: 0x0003F357
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002912 RID: 10514
		// (get) Token: 0x06008467 RID: 33895 RVA: 0x001F53EC File Offset: 0x001F35EC
		// (set) Token: 0x06008468 RID: 33896 RVA: 0x00041176 File Offset: 0x0003F376
		public unsafe AssignCharmSequence __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignCharmSequence>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssignCharmSequence._Run_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054D1 RID: 21713
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040054D2 RID: 21714
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040054D3 RID: 21715
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040054D4 RID: 21716
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040054D5 RID: 21717
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040054D6 RID: 21718
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040054D7 RID: 21719
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040054D8 RID: 21720
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040054D9 RID: 21721
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

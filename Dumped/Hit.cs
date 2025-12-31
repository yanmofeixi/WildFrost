using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200030A RID: 778
public class Hit : Object
{
	// Token: 0x06003B5D RID: 15197 RVA: 0x00108708 File Offset: 0x00106908
	// Note: this type is marked as 'beforefieldinit'.
	static Hit()
	{
		Il2CppClassPointerStore<Hit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Hit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hit>.NativeClassPtr);
		Hit.NativeFieldInfoPtr_attacker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "attacker");
		Hit.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "owner");
		Hit.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "target");
		Hit.NativeFieldInfoPtr_damageType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "damageType");
		Hit.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "trigger");
		Hit.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "damage");
		Hit.NativeFieldInfoPtr_damageBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "damageBlocked");
		Hit.NativeFieldInfoPtr__damageDealt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "<damageDealt>k__BackingField");
		Hit.NativeFieldInfoPtr_counterReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "counterReduction");
		Hit.NativeFieldInfoPtr_screenShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "screenShake");
		Hit.NativeFieldInfoPtr_countsAsHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "countsAsHit");
		Hit.NativeFieldInfoPtr_canBeNullified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "canBeNullified");
		Hit.NativeFieldInfoPtr_nullified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "nullified");
		Hit.NativeFieldInfoPtr_statusEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "statusEffects");
		Hit.NativeFieldInfoPtr_doAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "doAnimation");
		Hit.NativeFieldInfoPtr_canRetaliate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "canRetaliate");
		Hit.NativeFieldInfoPtr_dodged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "dodged");
		Hit.NativeFieldInfoPtr__Offensive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "<Offensive>k__BackingField");
		Hit.NativeFieldInfoPtr_extraOffensiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "extraOffensiveness");
		Hit.NativeFieldInfoPtr_processing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit>.NativeClassPtr, "processing");
		Hit.NativeMethodInfoPtr_get_damageDealt_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672843);
		Hit.NativeMethodInfoPtr_set_damageDealt_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672844);
		Hit.NativeMethodInfoPtr_get_Offensive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672845);
		Hit.NativeMethodInfoPtr_set_Offensive_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672846);
		Hit.NativeMethodInfoPtr_GetOffensiveness_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672847);
		Hit.NativeMethodInfoPtr_get_Supportive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672848);
		Hit.NativeMethodInfoPtr_GetSupportiveness_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672849);
		Hit.NativeMethodInfoPtr_get_BasicHit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672850);
		Hit.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672851);
		Hit.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672852);
		Hit.NativeMethodInfoPtr_AddAttackerStatuses_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672853);
		Hit.NativeMethodInfoPtr_CalculateAttackEffectAmount_Private_Int32_StatusEffectData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672854);
		Hit.NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672855);
		Hit.NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672856);
		Hit.NativeMethodInfoPtr_Process_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672857);
		Hit.NativeMethodInfoPtr_FlagAsOffensive_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit>.NativeClassPtr, 100672858);
	}

	// Token: 0x17001199 RID: 4505
	// (get) Token: 0x06003B5E RID: 15198 RVA: 0x00108A08 File Offset: 0x00106C08
	// (set) Token: 0x06003B5F RID: 15199 RVA: 0x00108A44 File Offset: 0x00106C44
	public unsafe int damageDealt
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_get_damageDealt_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_set_damageDealt_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700119A RID: 4506
	// (get) Token: 0x06003B60 RID: 15200 RVA: 0x00108A84 File Offset: 0x00106C84
	// (set) Token: 0x06003B61 RID: 15201 RVA: 0x00108AC0 File Offset: 0x00106CC0
	public unsafe bool Offensive
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_get_Offensive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_set_Offensive_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06003B62 RID: 15202 RVA: 0x00108B00 File Offset: 0x00106D00
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 105781, RefRangeEnd = 105783, XrefRangeStart = 105767, XrefRangeEnd = 105781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetOffensiveness()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_GetOffensiveness_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x1700119B RID: 4507
	// (get) Token: 0x06003B63 RID: 15203 RVA: 0x00108B3C File Offset: 0x00106D3C
	public unsafe bool Supportive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105783, XrefRangeEnd = 105799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_get_Supportive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06003B64 RID: 15204 RVA: 0x00108B78 File Offset: 0x00106D78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105799, XrefRangeEnd = 105813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSupportiveness()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_GetSupportiveness_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x1700119C RID: 4508
	// (get) Token: 0x06003B65 RID: 15205 RVA: 0x00108BB4 File Offset: 0x00106DB4
	public unsafe bool BasicHit
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 105816, RefRangeEnd = 105826, XrefRangeStart = 105813, XrefRangeEnd = 105816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_get_BasicHit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06003B66 RID: 15206 RVA: 0x00108BF0 File Offset: 0x00106DF0
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 105843, RefRangeEnd = 105848, XrefRangeStart = 105826, XrefRangeEnd = 105843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hit(Entity attacker, Entity target) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hit>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(attacker);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003B67 RID: 15207 RVA: 0x00108C50 File Offset: 0x00106E50
	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 105860, RefRangeEnd = 105876, XrefRangeStart = 105848, XrefRangeEnd = 105860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Hit(Entity attacker, Entity target, int damage) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hit>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(attacker);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damage;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003B68 RID: 15208 RVA: 0x00108CBC File Offset: 0x00106EBC
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 105898, RefRangeEnd = 105903, XrefRangeStart = 105876, XrefRangeEnd = 105898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAttackerStatuses()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_AddAttackerStatuses_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003B69 RID: 15209 RVA: 0x00108CF0 File Offset: 0x00106EF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105903, XrefRangeEnd = 105904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int CalculateAttackEffectAmount(StatusEffectData data, int statusEffectStacks)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref statusEffectStacks;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_CalculateAttackEffectAmount_Private_Int32_StatusEffectData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06003B6A RID: 15210 RVA: 0x00108D4C File Offset: 0x00106F4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105904, XrefRangeEnd = 105914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddStatusEffect(CardData.StatusEffectStacks statusEffect)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(statusEffect);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003B6B RID: 15211 RVA: 0x00108D90 File Offset: 0x00106F90
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 105929, RefRangeEnd = 105939, XrefRangeStart = 105914, XrefRangeEnd = 105929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddStatusEffect(StatusEffectData statusEffectData, int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(statusEffectData);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003B6C RID: 15212 RVA: 0x00108DE0 File Offset: 0x00106FE0
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 105944, RefRangeEnd = 105959, XrefRangeStart = 105939, XrefRangeEnd = 105944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Process()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_Process_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06003B6D RID: 15213 RVA: 0x00108E20 File Offset: 0x00107020
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 105959, RefRangeEnd = 105962, XrefRangeStart = 105959, XrefRangeEnd = 105959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FlagAsOffensive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit.NativeMethodInfoPtr_FlagAsOffensive_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003B6E RID: 15214 RVA: 0x000212B0 File Offset: 0x0001F4B0
	public Hit(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17001185 RID: 4485
	// (get) Token: 0x06003B6F RID: 15215 RVA: 0x00108E54 File Offset: 0x00107054
	// (set) Token: 0x06003B70 RID: 15216 RVA: 0x000212B9 File Offset: 0x0001F4B9
	public unsafe Entity attacker
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_attacker);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_attacker), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001186 RID: 4486
	// (get) Token: 0x06003B71 RID: 15217 RVA: 0x00108E84 File Offset: 0x00107084
	// (set) Token: 0x06003B72 RID: 15218 RVA: 0x000212D8 File Offset: 0x0001F4D8
	public unsafe Character owner
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_owner);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001187 RID: 4487
	// (get) Token: 0x06003B73 RID: 15219 RVA: 0x00108EB4 File Offset: 0x001070B4
	// (set) Token: 0x06003B74 RID: 15220 RVA: 0x000212F7 File Offset: 0x0001F4F7
	public unsafe Entity target
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_target);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001188 RID: 4488
	// (get) Token: 0x06003B75 RID: 15221 RVA: 0x00108EE4 File Offset: 0x001070E4
	// (set) Token: 0x06003B76 RID: 15222 RVA: 0x00021316 File Offset: 0x0001F516
	public unsafe string damageType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damageType);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damageType), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001189 RID: 4489
	// (get) Token: 0x06003B77 RID: 15223 RVA: 0x00108F0C File Offset: 0x0010710C
	// (set) Token: 0x06003B78 RID: 15224 RVA: 0x00021335 File Offset: 0x0001F535
	public unsafe Trigger trigger
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_trigger);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Trigger>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700118A RID: 4490
	// (get) Token: 0x06003B79 RID: 15225 RVA: 0x00108F3C File Offset: 0x0010713C
	// (set) Token: 0x06003B7A RID: 15226 RVA: 0x00021354 File Offset: 0x0001F554
	public unsafe int damage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damage)) = value;
		}
	}

	// Token: 0x1700118B RID: 4491
	// (get) Token: 0x06003B7B RID: 15227 RVA: 0x00108F64 File Offset: 0x00107164
	// (set) Token: 0x06003B7C RID: 15228 RVA: 0x0002136F File Offset: 0x0001F56F
	public unsafe int damageBlocked
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damageBlocked);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_damageBlocked)) = value;
		}
	}

	// Token: 0x1700118C RID: 4492
	// (get) Token: 0x06003B7D RID: 15229 RVA: 0x00108F8C File Offset: 0x0010718C
	// (set) Token: 0x06003B7E RID: 15230 RVA: 0x0002138A File Offset: 0x0001F58A
	public unsafe int _damageDealt_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr__damageDealt_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr__damageDealt_k__BackingField)) = value;
		}
	}

	// Token: 0x1700118D RID: 4493
	// (get) Token: 0x06003B7F RID: 15231 RVA: 0x00108FB4 File Offset: 0x001071B4
	// (set) Token: 0x06003B80 RID: 15232 RVA: 0x000213A5 File Offset: 0x0001F5A5
	public unsafe int counterReduction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_counterReduction);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_counterReduction)) = value;
		}
	}

	// Token: 0x1700118E RID: 4494
	// (get) Token: 0x06003B81 RID: 15233 RVA: 0x00108FDC File Offset: 0x001071DC
	// (set) Token: 0x06003B82 RID: 15234 RVA: 0x000213C0 File Offset: 0x0001F5C0
	public unsafe float screenShake
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_screenShake);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_screenShake)) = value;
		}
	}

	// Token: 0x1700118F RID: 4495
	// (get) Token: 0x06003B83 RID: 15235 RVA: 0x00109004 File Offset: 0x00107204
	// (set) Token: 0x06003B84 RID: 15236 RVA: 0x000213DB File Offset: 0x0001F5DB
	public unsafe bool countsAsHit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_countsAsHit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_countsAsHit)) = value;
		}
	}

	// Token: 0x17001190 RID: 4496
	// (get) Token: 0x06003B85 RID: 15237 RVA: 0x0010902C File Offset: 0x0010722C
	// (set) Token: 0x06003B86 RID: 15238 RVA: 0x000213F6 File Offset: 0x0001F5F6
	public unsafe bool canBeNullified
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_canBeNullified);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_canBeNullified)) = value;
		}
	}

	// Token: 0x17001191 RID: 4497
	// (get) Token: 0x06003B87 RID: 15239 RVA: 0x00109054 File Offset: 0x00107254
	// (set) Token: 0x06003B88 RID: 15240 RVA: 0x00021411 File Offset: 0x0001F611
	public unsafe bool nullified
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_nullified);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_nullified)) = value;
		}
	}

	// Token: 0x17001192 RID: 4498
	// (get) Token: 0x06003B89 RID: 15241 RVA: 0x0010907C File Offset: 0x0010727C
	// (set) Token: 0x06003B8A RID: 15242 RVA: 0x0002142C File Offset: 0x0001F62C
	public unsafe List<CardData.StatusEffectStacks> statusEffects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_statusEffects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_statusEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001193 RID: 4499
	// (get) Token: 0x06003B8B RID: 15243 RVA: 0x001090AC File Offset: 0x001072AC
	// (set) Token: 0x06003B8C RID: 15244 RVA: 0x0002144B File Offset: 0x0001F64B
	public unsafe bool doAnimation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_doAnimation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_doAnimation)) = value;
		}
	}

	// Token: 0x17001194 RID: 4500
	// (get) Token: 0x06003B8D RID: 15245 RVA: 0x001090D4 File Offset: 0x001072D4
	// (set) Token: 0x06003B8E RID: 15246 RVA: 0x00021466 File Offset: 0x0001F666
	public unsafe bool canRetaliate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_canRetaliate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_canRetaliate)) = value;
		}
	}

	// Token: 0x17001195 RID: 4501
	// (get) Token: 0x06003B8F RID: 15247 RVA: 0x001090FC File Offset: 0x001072FC
	// (set) Token: 0x06003B90 RID: 15248 RVA: 0x00021481 File Offset: 0x0001F681
	public unsafe bool dodged
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_dodged);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_dodged)) = value;
		}
	}

	// Token: 0x17001196 RID: 4502
	// (get) Token: 0x06003B91 RID: 15249 RVA: 0x00109124 File Offset: 0x00107324
	// (set) Token: 0x06003B92 RID: 15250 RVA: 0x0002149C File Offset: 0x0001F69C
	public unsafe bool _Offensive_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr__Offensive_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr__Offensive_k__BackingField)) = value;
		}
	}

	// Token: 0x17001197 RID: 4503
	// (get) Token: 0x06003B93 RID: 15251 RVA: 0x0010914C File Offset: 0x0010734C
	// (set) Token: 0x06003B94 RID: 15252 RVA: 0x000214B7 File Offset: 0x0001F6B7
	public unsafe int extraOffensiveness
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_extraOffensiveness);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_extraOffensiveness)) = value;
		}
	}

	// Token: 0x17001198 RID: 4504
	// (get) Token: 0x06003B95 RID: 15253 RVA: 0x00109174 File Offset: 0x00107374
	// (set) Token: 0x06003B96 RID: 15254 RVA: 0x000214D2 File Offset: 0x0001F6D2
	public unsafe bool processing
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_processing);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit.NativeFieldInfoPtr_processing)) = value;
		}
	}

	// Token: 0x04002514 RID: 9492
	private static readonly IntPtr NativeFieldInfoPtr_attacker;

	// Token: 0x04002515 RID: 9493
	private static readonly IntPtr NativeFieldInfoPtr_owner;

	// Token: 0x04002516 RID: 9494
	private static readonly IntPtr NativeFieldInfoPtr_target;

	// Token: 0x04002517 RID: 9495
	private static readonly IntPtr NativeFieldInfoPtr_damageType;

	// Token: 0x04002518 RID: 9496
	private static readonly IntPtr NativeFieldInfoPtr_trigger;

	// Token: 0x04002519 RID: 9497
	private static readonly IntPtr NativeFieldInfoPtr_damage;

	// Token: 0x0400251A RID: 9498
	private static readonly IntPtr NativeFieldInfoPtr_damageBlocked;

	// Token: 0x0400251B RID: 9499
	private static readonly IntPtr NativeFieldInfoPtr__damageDealt_k__BackingField;

	// Token: 0x0400251C RID: 9500
	private static readonly IntPtr NativeFieldInfoPtr_counterReduction;

	// Token: 0x0400251D RID: 9501
	private static readonly IntPtr NativeFieldInfoPtr_screenShake;

	// Token: 0x0400251E RID: 9502
	private static readonly IntPtr NativeFieldInfoPtr_countsAsHit;

	// Token: 0x0400251F RID: 9503
	private static readonly IntPtr NativeFieldInfoPtr_canBeNullified;

	// Token: 0x04002520 RID: 9504
	private static readonly IntPtr NativeFieldInfoPtr_nullified;

	// Token: 0x04002521 RID: 9505
	private static readonly IntPtr NativeFieldInfoPtr_statusEffects;

	// Token: 0x04002522 RID: 9506
	private static readonly IntPtr NativeFieldInfoPtr_doAnimation;

	// Token: 0x04002523 RID: 9507
	private static readonly IntPtr NativeFieldInfoPtr_canRetaliate;

	// Token: 0x04002524 RID: 9508
	private static readonly IntPtr NativeFieldInfoPtr_dodged;

	// Token: 0x04002525 RID: 9509
	private static readonly IntPtr NativeFieldInfoPtr__Offensive_k__BackingField;

	// Token: 0x04002526 RID: 9510
	private static readonly IntPtr NativeFieldInfoPtr_extraOffensiveness;

	// Token: 0x04002527 RID: 9511
	private static readonly IntPtr NativeFieldInfoPtr_processing;

	// Token: 0x04002528 RID: 9512
	private static readonly IntPtr NativeMethodInfoPtr_get_damageDealt_Public_get_Int32_0;

	// Token: 0x04002529 RID: 9513
	private static readonly IntPtr NativeMethodInfoPtr_set_damageDealt_Private_set_Void_Int32_0;

	// Token: 0x0400252A RID: 9514
	private static readonly IntPtr NativeMethodInfoPtr_get_Offensive_Public_get_Boolean_0;

	// Token: 0x0400252B RID: 9515
	private static readonly IntPtr NativeMethodInfoPtr_set_Offensive_Private_set_Void_Boolean_0;

	// Token: 0x0400252C RID: 9516
	private static readonly IntPtr NativeMethodInfoPtr_GetOffensiveness_Public_Int32_0;

	// Token: 0x0400252D RID: 9517
	private static readonly IntPtr NativeMethodInfoPtr_get_Supportive_Public_get_Boolean_0;

	// Token: 0x0400252E RID: 9518
	private static readonly IntPtr NativeMethodInfoPtr_GetSupportiveness_Public_Int32_0;

	// Token: 0x0400252F RID: 9519
	private static readonly IntPtr NativeMethodInfoPtr_get_BasicHit_Public_get_Boolean_0;

	// Token: 0x04002530 RID: 9520
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_0;

	// Token: 0x04002531 RID: 9521
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Entity_Int32_0;

	// Token: 0x04002532 RID: 9522
	private static readonly IntPtr NativeMethodInfoPtr_AddAttackerStatuses_Public_Void_0;

	// Token: 0x04002533 RID: 9523
	private static readonly IntPtr NativeMethodInfoPtr_CalculateAttackEffectAmount_Private_Int32_StatusEffectData_Int32_0;

	// Token: 0x04002534 RID: 9524
	private static readonly IntPtr NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectStacks_0;

	// Token: 0x04002535 RID: 9525
	private static readonly IntPtr NativeMethodInfoPtr_AddStatusEffect_Public_Void_StatusEffectData_Int32_0;

	// Token: 0x04002536 RID: 9526
	private static readonly IntPtr NativeMethodInfoPtr_Process_Public_IEnumerator_0;

	// Token: 0x04002537 RID: 9527
	private static readonly IntPtr NativeMethodInfoPtr_FlagAsOffensive_Public_Void_0;

	// Token: 0x02000859 RID: 2137
	[ObfuscatedName("Hit+<Process>d__38")]
	public sealed class _Process_d__38 : Object
	{
		// Token: 0x06008933 RID: 35123 RVA: 0x00203B98 File Offset: 0x00201D98
		// Note: this type is marked as 'beforefieldinit'.
		static _Process_d__38()
		{
			Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hit>.NativeClassPtr, "<Process>d__38");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr);
			Hit._Process_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, "<>1__state");
			Hit._Process_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, "<>2__current");
			Hit._Process_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, "<>4__this");
			Hit._Process_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, 100672859);
			Hit._Process_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, 100672860);
			Hit._Process_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, 100672861);
			Hit._Process_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, 100672862);
			Hit._Process_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, 100672863);
			Hit._Process_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr, 100672864);
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x00203C78 File Offset: 0x00201E78
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Process_d__38(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hit._Process_d__38>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x00203CC0 File Offset: 0x00201EC0
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008936 RID: 35126 RVA: 0x00203CF4 File Offset: 0x00201EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105711, XrefRangeEnd = 105761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x06008937 RID: 35127 RVA: 0x00203D30 File Offset: 0x00201F30
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x00203D70 File Offset: 0x00201F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105761, XrefRangeEnd = 105767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x06008939 RID: 35129 RVA: 0x00203DA4 File Offset: 0x00201FA4
		public unsafe Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hit._Process_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x00043822 File Offset: 0x00041A22
		public _Process_d__38(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x0600893B RID: 35131 RVA: 0x00203DE4 File Offset: 0x00201FE4
		// (set) Token: 0x0600893C RID: 35132 RVA: 0x0004382B File Offset: 0x00041A2B
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit._Process_d__38.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit._Process_d__38.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x0600893D RID: 35133 RVA: 0x00203E0C File Offset: 0x0020200C
		// (set) Token: 0x0600893E RID: 35134 RVA: 0x00043846 File Offset: 0x00041A46
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit._Process_d__38.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit._Process_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x0600893F RID: 35135 RVA: 0x00203E3C File Offset: 0x0020203C
		// (set) Token: 0x06008940 RID: 35136 RVA: 0x00043865 File Offset: 0x00041A65
		public unsafe Hit __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit._Process_d__38.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hit._Process_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057B9 RID: 22457
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x040057BA RID: 22458
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x040057BB RID: 22459
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x040057BC RID: 22460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040057BD RID: 22461
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x040057BE RID: 22462
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x040057BF RID: 22463
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x040057C0 RID: 22464
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x040057C1 RID: 22465
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

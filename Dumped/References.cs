using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000395 RID: 917
public class References : MonoBehaviourSingleton<References>
{
	// Token: 0x060047E8 RID: 18408 RVA: 0x0012F67C File Offset: 0x0012D87C
	// Note: this type is marked as 'beforefieldinit'.
	static References()
	{
		Il2CppClassPointerStore<References>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "References");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<References>.NativeClassPtr);
		References.NativeFieldInfoPtr_PlayerData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "PlayerData");
		References.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "Player");
		References.NativeFieldInfoPtr_Map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "Map");
		References.NativeFieldInfoPtr_Campaign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "Campaign");
		References.NativeFieldInfoPtr_Battle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "Battle");
		References.NativeFieldInfoPtr_classes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "classes");
		References.NativeFieldInfoPtr_areas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "areas");
		References.NativeFieldInfoPtr_hardModeModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "hardModeModifiers");
		References.NativeFieldInfoPtr_bossRewardPools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "bossRewardPools");
		References.NativeFieldInfoPtr__minibossCameraMover = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "_minibossCameraMover");
		References.NativeFieldInfoPtr_DefaultGameModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "DefaultGameModeName");
		References.NativeFieldInfoPtr_TutorialGameModeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References>.NativeClassPtr, "TutorialGameModeName");
		References.NativeMethodInfoPtr_get_LeaderData_Public_Static_get_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674639);
		References.NativeMethodInfoPtr_get_Classes_Public_Static_get_Il2CppReferenceArray_1_ClassData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674640);
		References.NativeMethodInfoPtr_get_Areas_Public_Static_get_Il2CppReferenceArray_1_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674641);
		References.NativeMethodInfoPtr_get_MinibossCameraMover_Public_Static_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674642);
		References.NativeMethodInfoPtr_GetCurrentArea_Public_Static_AreaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674643);
		References.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References>.NativeClassPtr, 100674644);
	}

	// Token: 0x17001554 RID: 5460
	// (get) Token: 0x060047E9 RID: 18409 RVA: 0x0012F814 File Offset: 0x0012DA14
	public unsafe static CardData LeaderData
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 119595, RefRangeEnd = 119598, XrefRangeStart = 119574, XrefRangeEnd = 119595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_get_LeaderData_Public_Static_get_CardData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr3) : null;
		}
	}

	// Token: 0x17001555 RID: 5461
	// (get) Token: 0x060047EA RID: 18410 RVA: 0x0012F848 File Offset: 0x0012DA48
	public unsafe static Il2CppReferenceArray<ClassData> Classes
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 119602, RefRangeEnd = 119606, XrefRangeStart = 119598, XrefRangeEnd = 119602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_get_Classes_Public_Static_get_Il2CppReferenceArray_1_ClassData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClassData>>(intPtr3) : null;
		}
	}

	// Token: 0x17001556 RID: 5462
	// (get) Token: 0x060047EB RID: 18411 RVA: 0x0012F87C File Offset: 0x0012DA7C
	public unsafe static Il2CppReferenceArray<AreaData> Areas
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119610, RefRangeEnd = 119611, XrefRangeStart = 119606, XrefRangeEnd = 119610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_get_Areas_Public_Static_get_Il2CppReferenceArray_1_AreaData_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AreaData>>(intPtr3) : null;
		}
	}

	// Token: 0x17001557 RID: 5463
	// (get) Token: 0x060047EC RID: 18412 RVA: 0x0012F8B0 File Offset: 0x0012DAB0
	public unsafe static Transform MinibossCameraMover
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 119625, RefRangeEnd = 119634, XrefRangeStart = 119611, XrefRangeEnd = 119625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_get_MinibossCameraMover_Public_Static_get_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}
	}

	// Token: 0x060047ED RID: 18413 RVA: 0x0012F8E4 File Offset: 0x0012DAE4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 119641, RefRangeEnd = 119647, XrefRangeStart = 119634, XrefRangeEnd = 119641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AreaData GetCurrentArea()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr_GetCurrentArea_Public_Static_AreaData_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AreaData>(intPtr3) : null;
	}

	// Token: 0x060047EE RID: 18414 RVA: 0x0012F918 File Offset: 0x0012DB18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119647, XrefRangeEnd = 119650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe References() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<References>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(References.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060047EF RID: 18415 RVA: 0x0002771F File Offset: 0x0002591F
	public References(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17001548 RID: 5448
	// (get) Token: 0x060047F0 RID: 18416 RVA: 0x0012F954 File Offset: 0x0012DB54
	// (set) Token: 0x060047F1 RID: 18417 RVA: 0x00027728 File Offset: 0x00025928
	public unsafe static PlayerData PlayerData
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_PlayerData, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_PlayerData, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001549 RID: 5449
	// (get) Token: 0x060047F2 RID: 18418 RVA: 0x0012F97C File Offset: 0x0012DB7C
	// (set) Token: 0x060047F3 RID: 18419 RVA: 0x0002773A File Offset: 0x0002593A
	public unsafe static Character Player
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_Player, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Character>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_Player, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700154A RID: 5450
	// (get) Token: 0x060047F4 RID: 18420 RVA: 0x0012F9A4 File Offset: 0x0012DBA4
	// (set) Token: 0x060047F5 RID: 18421 RVA: 0x0002774C File Offset: 0x0002594C
	public unsafe static MapNew Map
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_Map, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapNew>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_Map, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700154B RID: 5451
	// (get) Token: 0x060047F6 RID: 18422 RVA: 0x0012F9CC File Offset: 0x0012DBCC
	// (set) Token: 0x060047F7 RID: 18423 RVA: 0x0002775E File Offset: 0x0002595E
	public unsafe static Campaign Campaign
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_Campaign, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Campaign>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_Campaign, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700154C RID: 5452
	// (get) Token: 0x060047F8 RID: 18424 RVA: 0x0012F9F4 File Offset: 0x0012DBF4
	// (set) Token: 0x060047F9 RID: 18425 RVA: 0x00027770 File Offset: 0x00025970
	public unsafe static Battle Battle
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_Battle, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Battle>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_Battle, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700154D RID: 5453
	// (get) Token: 0x060047FA RID: 18426 RVA: 0x0012FA1C File Offset: 0x0012DC1C
	// (set) Token: 0x060047FB RID: 18427 RVA: 0x00027782 File Offset: 0x00025982
	public unsafe Il2CppReferenceArray<ClassData> classes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_classes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ClassData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_classes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700154E RID: 5454
	// (get) Token: 0x060047FC RID: 18428 RVA: 0x0012FA4C File Offset: 0x0012DC4C
	// (set) Token: 0x060047FD RID: 18429 RVA: 0x000277A1 File Offset: 0x000259A1
	public unsafe Il2CppReferenceArray<AreaData> areas
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_areas);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AreaData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_areas), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700154F RID: 5455
	// (get) Token: 0x060047FE RID: 18430 RVA: 0x0012FA7C File Offset: 0x0012DC7C
	// (set) Token: 0x060047FF RID: 18431 RVA: 0x000277C0 File Offset: 0x000259C0
	public unsafe Il2CppReferenceArray<HardModeModifierData> hardModeModifiers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_hardModeModifiers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HardModeModifierData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_hardModeModifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001550 RID: 5456
	// (get) Token: 0x06004800 RID: 18432 RVA: 0x0012FAAC File Offset: 0x0012DCAC
	// (set) Token: 0x06004801 RID: 18433 RVA: 0x000277DF File Offset: 0x000259DF
	public unsafe Il2CppReferenceArray<BossRewardPool> bossRewardPools
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_bossRewardPools);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BossRewardPool>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(References.NativeFieldInfoPtr_bossRewardPools), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001551 RID: 5457
	// (get) Token: 0x06004802 RID: 18434 RVA: 0x0012FADC File Offset: 0x0012DCDC
	// (set) Token: 0x06004803 RID: 18435 RVA: 0x000277FE File Offset: 0x000259FE
	public unsafe static Transform _minibossCameraMover
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr__minibossCameraMover, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr__minibossCameraMover, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001552 RID: 5458
	// (get) Token: 0x06004804 RID: 18436 RVA: 0x0012FB04 File Offset: 0x0012DD04
	// (set) Token: 0x06004805 RID: 18437 RVA: 0x00027810 File Offset: 0x00025A10
	public unsafe static string DefaultGameModeName
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_DefaultGameModeName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_DefaultGameModeName, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001553 RID: 5459
	// (get) Token: 0x06004806 RID: 18438 RVA: 0x0012FB24 File Offset: 0x0012DD24
	// (set) Token: 0x06004807 RID: 18439 RVA: 0x00027822 File Offset: 0x00025A22
	public unsafe static string TutorialGameModeName
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(References.NativeFieldInfoPtr_TutorialGameModeName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(References.NativeFieldInfoPtr_TutorialGameModeName, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04002D17 RID: 11543
	private static readonly IntPtr NativeFieldInfoPtr_PlayerData;

	// Token: 0x04002D18 RID: 11544
	private static readonly IntPtr NativeFieldInfoPtr_Player;

	// Token: 0x04002D19 RID: 11545
	private static readonly IntPtr NativeFieldInfoPtr_Map;

	// Token: 0x04002D1A RID: 11546
	private static readonly IntPtr NativeFieldInfoPtr_Campaign;

	// Token: 0x04002D1B RID: 11547
	private static readonly IntPtr NativeFieldInfoPtr_Battle;

	// Token: 0x04002D1C RID: 11548
	private static readonly IntPtr NativeFieldInfoPtr_classes;

	// Token: 0x04002D1D RID: 11549
	private static readonly IntPtr NativeFieldInfoPtr_areas;

	// Token: 0x04002D1E RID: 11550
	private static readonly IntPtr NativeFieldInfoPtr_hardModeModifiers;

	// Token: 0x04002D1F RID: 11551
	private static readonly IntPtr NativeFieldInfoPtr_bossRewardPools;

	// Token: 0x04002D20 RID: 11552
	private static readonly IntPtr NativeFieldInfoPtr__minibossCameraMover;

	// Token: 0x04002D21 RID: 11553
	private static readonly IntPtr NativeFieldInfoPtr_DefaultGameModeName;

	// Token: 0x04002D22 RID: 11554
	private static readonly IntPtr NativeFieldInfoPtr_TutorialGameModeName;

	// Token: 0x04002D23 RID: 11555
	private static readonly IntPtr NativeMethodInfoPtr_get_LeaderData_Public_Static_get_CardData_0;

	// Token: 0x04002D24 RID: 11556
	private static readonly IntPtr NativeMethodInfoPtr_get_Classes_Public_Static_get_Il2CppReferenceArray_1_ClassData_0;

	// Token: 0x04002D25 RID: 11557
	private static readonly IntPtr NativeMethodInfoPtr_get_Areas_Public_Static_get_Il2CppReferenceArray_1_AreaData_0;

	// Token: 0x04002D26 RID: 11558
	private static readonly IntPtr NativeMethodInfoPtr_get_MinibossCameraMover_Public_Static_get_Transform_0;

	// Token: 0x04002D27 RID: 11559
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentArea_Public_Static_AreaData_0;

	// Token: 0x04002D28 RID: 11560
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020008FE RID: 2302
	[ObfuscatedName("References+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06009060 RID: 36960 RVA: 0x0021A850 File Offset: 0x00218A50
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<References.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<References>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<References.__c>.NativeClassPtr);
			References.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References.__c>.NativeClassPtr, "<>9");
			References.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<References.__c>.NativeClassPtr, "<>9__2_0");
			References.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References.__c>.NativeClassPtr, 100674646);
			References.__c.NativeMethodInfoPtr__get_LeaderData_b__2_0_Internal_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<References.__c>.NativeClassPtr, 100674647);
		}

		// Token: 0x06009061 RID: 36961 RVA: 0x0021A8CC File Offset: 0x00218ACC
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<References.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(References.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x0021A908 File Offset: 0x00218B08
		[CallerCount(0)]
		public unsafe bool _get_LeaderData_b__2_0(CardData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(References.__c.NativeMethodInfoPtr__get_LeaderData_b__2_0_Internal_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x00046F40 File Offset: 0x00045140
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x06009064 RID: 36964 RVA: 0x0021A958 File Offset: 0x00218B58
		// (set) Token: 0x06009065 RID: 36965 RVA: 0x00046F49 File Offset: 0x00045149
		public unsafe static References.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(References.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<References.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(References.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x06009066 RID: 36966 RVA: 0x0021A980 File Offset: 0x00218B80
		// (set) Token: 0x06009067 RID: 36967 RVA: 0x00046F5B File Offset: 0x0004515B
		public unsafe static Func<CardData, bool> __9__2_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(References.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardData, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(References.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005C13 RID: 23571
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04005C14 RID: 23572
		private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

		// Token: 0x04005C15 RID: 23573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005C16 RID: 23574
		private static readonly IntPtr NativeMethodInfoPtr__get_LeaderData_b__2_0_Internal_Boolean_CardData_0;
	}
}

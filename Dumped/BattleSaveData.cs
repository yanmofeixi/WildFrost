using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000314 RID: 788
[Serializable]
public class BattleSaveData : Object
{
	// Token: 0x06003BF0 RID: 15344 RVA: 0x00109E2C File Offset: 0x0010802C
	// Note: this type is marked as 'beforefieldinit'.
	static BattleSaveData()
	{
		Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "BattleSaveData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr);
		BattleSaveData.NativeFieldInfoPtr_campaignNodeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "campaignNodeId");
		BattleSaveData.NativeFieldInfoPtr_turnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "turnCount");
		BattleSaveData.NativeFieldInfoPtr_redrawBellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "redrawBellCount");
		BattleSaveData.NativeFieldInfoPtr_playerRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "playerRows");
		BattleSaveData.NativeFieldInfoPtr_enemyRows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "enemyRows");
		BattleSaveData.NativeFieldInfoPtr_playerHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "playerHand");
		BattleSaveData.NativeFieldInfoPtr_playerDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "playerDraw");
		BattleSaveData.NativeFieldInfoPtr_playerDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "playerDiscard");
		BattleSaveData.NativeFieldInfoPtr_playerReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "playerReserve");
		BattleSaveData.NativeFieldInfoPtr_enemyReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "enemyReserve");
		BattleSaveData.NativeFieldInfoPtr_statuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "statuses");
		BattleSaveData.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "destroyed");
		BattleSaveData.NativeFieldInfoPtr_enemyWaves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "enemyWaves");
		BattleSaveData.NativeFieldInfoPtr_battleMusicState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "battleMusicState");
		BattleSaveData.NativeFieldInfoPtr_storeStatusData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "storeStatusData");
		BattleSaveData.NativeFieldInfoPtr_gold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "gold");
		BattleSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, 100672883);
		BattleSaveData.NativeMethodInfoPtr_HasMissingCardData_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, 100672884);
	}

	// Token: 0x06003BF1 RID: 15345 RVA: 0x00109FC4 File Offset: 0x001081C4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 106118, RefRangeEnd = 106119, XrefRangeStart = 106109, XrefRangeEnd = 106118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BattleSaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003BF2 RID: 15346 RVA: 0x0010A000 File Offset: 0x00108200
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 106158, RefRangeEnd = 106159, XrefRangeStart = 106119, XrefRangeEnd = 106158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool HasMissingCardData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.NativeMethodInfoPtr_HasMissingCardData_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06003BF3 RID: 15347 RVA: 0x000218EA File Offset: 0x0001FAEA
	public BattleSaveData(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170011B9 RID: 4537
	// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x0010A03C File Offset: 0x0010823C
	// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x000218F3 File Offset: 0x0001FAF3
	public unsafe int campaignNodeId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_campaignNodeId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_campaignNodeId)) = value;
		}
	}

	// Token: 0x170011BA RID: 4538
	// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x0010A064 File Offset: 0x00108264
	// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x0002190E File Offset: 0x0001FB0E
	public unsafe int turnCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_turnCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_turnCount)) = value;
		}
	}

	// Token: 0x170011BB RID: 4539
	// (get) Token: 0x06003BF8 RID: 15352 RVA: 0x0010A08C File Offset: 0x0010828C
	// (set) Token: 0x06003BF9 RID: 15353 RVA: 0x00021929 File Offset: 0x0001FB29
	public unsafe int redrawBellCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_redrawBellCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_redrawBellCount)) = value;
		}
	}

	// Token: 0x170011BC RID: 4540
	// (get) Token: 0x06003BFA RID: 15354 RVA: 0x0010A0B4 File Offset: 0x001082B4
	// (set) Token: 0x06003BFB RID: 15355 RVA: 0x00021944 File Offset: 0x0001FB44
	public unsafe BattleSaveData.ContainerGroup playerRows
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerRows);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.ContainerGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerRows), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011BD RID: 4541
	// (get) Token: 0x06003BFC RID: 15356 RVA: 0x0010A0E4 File Offset: 0x001082E4
	// (set) Token: 0x06003BFD RID: 15357 RVA: 0x00021963 File Offset: 0x0001FB63
	public unsafe BattleSaveData.ContainerGroup enemyRows
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyRows);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.ContainerGroup>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyRows), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011BE RID: 4542
	// (get) Token: 0x06003BFE RID: 15358 RVA: 0x0010A114 File Offset: 0x00108314
	// (set) Token: 0x06003BFF RID: 15359 RVA: 0x00021982 File Offset: 0x0001FB82
	public unsafe BattleSaveData.Container playerHand
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerHand);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Container>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerHand), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011BF RID: 4543
	// (get) Token: 0x06003C00 RID: 15360 RVA: 0x0010A144 File Offset: 0x00108344
	// (set) Token: 0x06003C01 RID: 15361 RVA: 0x000219A1 File Offset: 0x0001FBA1
	public unsafe BattleSaveData.Container playerDraw
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerDraw);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Container>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerDraw), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C0 RID: 4544
	// (get) Token: 0x06003C02 RID: 15362 RVA: 0x0010A174 File Offset: 0x00108374
	// (set) Token: 0x06003C03 RID: 15363 RVA: 0x000219C0 File Offset: 0x0001FBC0
	public unsafe BattleSaveData.Container playerDiscard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerDiscard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Container>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerDiscard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C1 RID: 4545
	// (get) Token: 0x06003C04 RID: 15364 RVA: 0x0010A1A4 File Offset: 0x001083A4
	// (set) Token: 0x06003C05 RID: 15365 RVA: 0x000219DF File Offset: 0x0001FBDF
	public unsafe BattleSaveData.Container playerReserve
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerReserve);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Container>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_playerReserve), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C2 RID: 4546
	// (get) Token: 0x06003C06 RID: 15366 RVA: 0x0010A1D4 File Offset: 0x001083D4
	// (set) Token: 0x06003C07 RID: 15367 RVA: 0x000219FE File Offset: 0x0001FBFE
	public unsafe BattleSaveData.Container enemyReserve
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyReserve);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Container>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyReserve), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C3 RID: 4547
	// (get) Token: 0x06003C08 RID: 15368 RVA: 0x0010A204 File Offset: 0x00108404
	// (set) Token: 0x06003C09 RID: 15369 RVA: 0x00021A1D File Offset: 0x0001FC1D
	public unsafe Il2CppReferenceArray<BattleSaveData.Status> statuses
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_statuses);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BattleSaveData.Status>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_statuses), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C4 RID: 4548
	// (get) Token: 0x06003C0A RID: 15370 RVA: 0x0010A234 File Offset: 0x00108434
	// (set) Token: 0x06003C0B RID: 15371 RVA: 0x00021A3C File Offset: 0x0001FC3C
	public unsafe Il2CppReferenceArray<BattleEntityData> destroyed
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_destroyed);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BattleEntityData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_destroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C5 RID: 4549
	// (get) Token: 0x06003C0C RID: 15372 RVA: 0x0010A264 File Offset: 0x00108464
	// (set) Token: 0x06003C0D RID: 15373 RVA: 0x00021A5B File Offset: 0x0001FC5B
	public unsafe BattleWaveData enemyWaves
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyWaves);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleWaveData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_enemyWaves), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C6 RID: 4550
	// (get) Token: 0x06003C0E RID: 15374 RVA: 0x0010A294 File Offset: 0x00108494
	// (set) Token: 0x06003C0F RID: 15375 RVA: 0x00021A7A File Offset: 0x0001FC7A
	public unsafe BattleMusicSaveData battleMusicState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_battleMusicState);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleMusicSaveData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_battleMusicState), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C7 RID: 4551
	// (get) Token: 0x06003C10 RID: 15376 RVA: 0x0010A2C4 File Offset: 0x001084C4
	// (set) Token: 0x06003C11 RID: 15377 RVA: 0x00021A99 File Offset: 0x0001FC99
	public unsafe Dictionary<string, Object> storeStatusData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_storeStatusData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_storeStatusData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170011C8 RID: 4552
	// (get) Token: 0x06003C12 RID: 15378 RVA: 0x0010A2F4 File Offset: 0x001084F4
	// (set) Token: 0x06003C13 RID: 15379 RVA: 0x00021AB8 File Offset: 0x0001FCB8
	public unsafe int gold
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_gold);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.NativeFieldInfoPtr_gold)) = value;
		}
	}

	// Token: 0x04002563 RID: 9571
	private static readonly IntPtr NativeFieldInfoPtr_campaignNodeId;

	// Token: 0x04002564 RID: 9572
	private static readonly IntPtr NativeFieldInfoPtr_turnCount;

	// Token: 0x04002565 RID: 9573
	private static readonly IntPtr NativeFieldInfoPtr_redrawBellCount;

	// Token: 0x04002566 RID: 9574
	private static readonly IntPtr NativeFieldInfoPtr_playerRows;

	// Token: 0x04002567 RID: 9575
	private static readonly IntPtr NativeFieldInfoPtr_enemyRows;

	// Token: 0x04002568 RID: 9576
	private static readonly IntPtr NativeFieldInfoPtr_playerHand;

	// Token: 0x04002569 RID: 9577
	private static readonly IntPtr NativeFieldInfoPtr_playerDraw;

	// Token: 0x0400256A RID: 9578
	private static readonly IntPtr NativeFieldInfoPtr_playerDiscard;

	// Token: 0x0400256B RID: 9579
	private static readonly IntPtr NativeFieldInfoPtr_playerReserve;

	// Token: 0x0400256C RID: 9580
	private static readonly IntPtr NativeFieldInfoPtr_enemyReserve;

	// Token: 0x0400256D RID: 9581
	private static readonly IntPtr NativeFieldInfoPtr_statuses;

	// Token: 0x0400256E RID: 9582
	private static readonly IntPtr NativeFieldInfoPtr_destroyed;

	// Token: 0x0400256F RID: 9583
	private static readonly IntPtr NativeFieldInfoPtr_enemyWaves;

	// Token: 0x04002570 RID: 9584
	private static readonly IntPtr NativeFieldInfoPtr_battleMusicState;

	// Token: 0x04002571 RID: 9585
	private static readonly IntPtr NativeFieldInfoPtr_storeStatusData;

	// Token: 0x04002572 RID: 9586
	private static readonly IntPtr NativeFieldInfoPtr_gold;

	// Token: 0x04002573 RID: 9587
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04002574 RID: 9588
	private static readonly IntPtr NativeMethodInfoPtr_HasMissingCardData_Public_Boolean_0;

	// Token: 0x0200085B RID: 2139
	[Serializable]
	public class ContainerGroup : Object
	{
		// Token: 0x06008949 RID: 35145 RVA: 0x00203FC4 File Offset: 0x002021C4
		// Note: this type is marked as 'beforefieldinit'.
		static ContainerGroup()
		{
			Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "ContainerGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr);
			BattleSaveData.ContainerGroup.NativeFieldInfoPtr_containers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr, "containers");
			BattleSaveData.ContainerGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr, 100672885);
			BattleSaveData.ContainerGroup.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr, 100672886);
		}

		// Token: 0x0600894A RID: 35146 RVA: 0x0020402C File Offset: 0x0020222C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.ContainerGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x00204068 File Offset: 0x00202268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106041, RefRangeEnd = 106043, XrefRangeStart = 106017, XrefRangeEnd = 106041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContainerGroup(IEnumerable<CardContainer> containers) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(containers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.ContainerGroup.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x000438B1 File Offset: 0x00041AB1
		public ContainerGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0600894D RID: 35149 RVA: 0x002040B4 File Offset: 0x002022B4
		// (set) Token: 0x0600894E RID: 35150 RVA: 0x000438BA File Offset: 0x00041ABA
		public unsafe Il2CppReferenceArray<BattleSaveData.Container> containers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.ContainerGroup.NativeFieldInfoPtr_containers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BattleSaveData.Container>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.ContainerGroup.NativeFieldInfoPtr_containers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057C6 RID: 22470
		private static readonly IntPtr NativeFieldInfoPtr_containers;

		// Token: 0x040057C7 RID: 22471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040057C8 RID: 22472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_CardContainer_0;

		// Token: 0x02000AAD RID: 2733
		[ObfuscatedName("BattleSaveData+ContainerGroup+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A487 RID: 42119 RVA: 0x00257EE0 File Offset: 0x002560E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData.ContainerGroup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr);
				BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr, "<>9");
				BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr, "<>9__2_0");
				BattleSaveData.ContainerGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr, 100672888);
				BattleSaveData.ContainerGroup.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_Container_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr, 100672889);
			}

			// Token: 0x0600A488 RID: 42120 RVA: 0x00257F5C File Offset: 0x0025615C
			[CallerCount(1911)]
			[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.ContainerGroup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.ContainerGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A489 RID: 42121 RVA: 0x00257F98 File Offset: 0x00256198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106013, XrefRangeEnd = 106017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BattleSaveData.Container __ctor_b__2_0(CardContainer a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.ContainerGroup.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_Container_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Container>(intPtr3) : null;
			}

			// Token: 0x0600A48A RID: 42122 RVA: 0x00050DDF File Offset: 0x0004EFDF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033F1 RID: 13297
			// (get) Token: 0x0600A48B RID: 42123 RVA: 0x00257FE8 File Offset: 0x002561E8
			// (set) Token: 0x0600A48C RID: 42124 RVA: 0x00050DE8 File Offset: 0x0004EFE8
			public unsafe static BattleSaveData.ContainerGroup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.ContainerGroup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F2 RID: 13298
			// (get) Token: 0x0600A48D RID: 42125 RVA: 0x00258010 File Offset: 0x00256210
			// (set) Token: 0x0600A48E RID: 42126 RVA: 0x00050DFA File Offset: 0x0004EFFA
			public unsafe static Func<CardContainer, BattleSaveData.Container> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardContainer, BattleSaveData.Container>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BattleSaveData.ContainerGroup.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069F5 RID: 27125
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040069F6 RID: 27126
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040069F7 RID: 27127
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069F8 RID: 27128
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_Container_CardContainer_0;
		}
	}

	// Token: 0x0200085C RID: 2140
	[Serializable]
	public class Container : Object
	{
		// Token: 0x0600894F RID: 35151 RVA: 0x002040E4 File Offset: 0x002022E4
		// Note: this type is marked as 'beforefieldinit'.
		static Container()
		{
			Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "Container");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr);
			BattleSaveData.Container.NativeFieldInfoPtr_cards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr, "cards");
			BattleSaveData.Container.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr, 100672890);
			BattleSaveData.Container.NativeMethodInfoPtr__ctor_Public_Void_CardContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr, 100672891);
		}

		// Token: 0x06008950 RID: 35152 RVA: 0x0020414C File Offset: 0x0020234C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Container() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008951 RID: 35153 RVA: 0x00204188 File Offset: 0x00202388
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 106095, RefRangeEnd = 106101, XrefRangeStart = 106051, XrefRangeEnd = 106095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Container(CardContainer container) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.NativeMethodInfoPtr__ctor_Public_Void_CardContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008952 RID: 35154 RVA: 0x000438D9 File Offset: 0x00041AD9
		public Container(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x06008953 RID: 35155 RVA: 0x002041D4 File Offset: 0x002023D4
		// (set) Token: 0x06008954 RID: 35156 RVA: 0x000438E2 File Offset: 0x00041AE2
		public unsafe Il2CppReferenceArray<BattleEntityData> cards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Container.NativeFieldInfoPtr_cards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BattleEntityData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Container.NativeFieldInfoPtr_cards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040057C9 RID: 22473
		private static readonly IntPtr NativeFieldInfoPtr_cards;

		// Token: 0x040057CA RID: 22474
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040057CB RID: 22475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CardContainer_0;

		// Token: 0x02000AAE RID: 2734
		[ObfuscatedName("BattleSaveData+Container+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A48F RID: 42127 RVA: 0x00258038 File Offset: 0x00256238
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData.Container>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr);
				BattleSaveData.Container.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, "<>9");
				BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, "<>9__2_0");
				BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, "<>9__2_1");
				BattleSaveData.Container.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, 100672893);
				BattleSaveData.Container.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_BattleEntityData_CardSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, 100672894);
				BattleSaveData.Container.__c.NativeMethodInfoPtr___ctor_b__2_1_Internal_BattleEntityData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr, 100672895);
			}

			// Token: 0x0600A490 RID: 42128 RVA: 0x002580DC File Offset: 0x002562DC
			[CallerCount(1911)]
			[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Container.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A491 RID: 42129 RVA: 0x00258118 File Offset: 0x00256318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106043, XrefRangeEnd = 106047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BattleEntityData __ctor_b__2_0(CardSlot a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.__c.NativeMethodInfoPtr___ctor_b__2_0_Internal_BattleEntityData_CardSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BattleEntityData>(intPtr3) : null;
			}

			// Token: 0x0600A492 RID: 42130 RVA: 0x00258168 File Offset: 0x00256368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106047, XrefRangeEnd = 106051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BattleEntityData __ctor_b__2_1(Entity a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Container.__c.NativeMethodInfoPtr___ctor_b__2_1_Internal_BattleEntityData_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BattleEntityData>(intPtr3) : null;
			}

			// Token: 0x0600A493 RID: 42131 RVA: 0x00050E0C File Offset: 0x0004F00C
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033F3 RID: 13299
			// (get) Token: 0x0600A494 RID: 42132 RVA: 0x002581B8 File Offset: 0x002563B8
			// (set) Token: 0x0600A495 RID: 42133 RVA: 0x00050E15 File Offset: 0x0004F015
			public unsafe static BattleSaveData.Container.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BattleSaveData.Container.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F4 RID: 13300
			// (get) Token: 0x0600A496 RID: 42134 RVA: 0x002581E0 File Offset: 0x002563E0
			// (set) Token: 0x0600A497 RID: 42135 RVA: 0x00050E27 File Offset: 0x0004F027
			public unsafe static Func<CardSlot, BattleEntityData> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardSlot, BattleEntityData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170033F5 RID: 13301
			// (get) Token: 0x0600A498 RID: 42136 RVA: 0x00258208 File Offset: 0x00256408
			// (set) Token: 0x0600A499 RID: 42137 RVA: 0x00050E39 File Offset: 0x0004F039
			public unsafe static Func<Entity, BattleEntityData> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, BattleEntityData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BattleSaveData.Container.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040069F9 RID: 27129
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040069FA RID: 27130
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x040069FB RID: 27131
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x040069FC RID: 27132
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069FD RID: 27133
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_0_Internal_BattleEntityData_CardSlot_0;

			// Token: 0x040069FE RID: 27134
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__2_1_Internal_BattleEntityData_Entity_0;
		}
	}

	// Token: 0x0200085D RID: 2141
	[Serializable]
	public class Status : Object
	{
		// Token: 0x06008955 RID: 35157 RVA: 0x00204204 File Offset: 0x00202404
		// Note: this type is marked as 'beforefieldinit'.
		static Status()
		{
			Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BattleSaveData>.NativeClassPtr, "Status");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr);
			BattleSaveData.Status.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, "name");
			BattleSaveData.Status.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, "count");
			BattleSaveData.Status.NativeFieldInfoPtr_targetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, "targetId");
			BattleSaveData.Status.NativeFieldInfoPtr_hasApplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, "hasApplier");
			BattleSaveData.Status.NativeFieldInfoPtr_applierId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, "applierId");
			BattleSaveData.Status.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, 100672896);
			BattleSaveData.Status.NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr, 100672897);
		}

		// Token: 0x06008956 RID: 35158 RVA: 0x002042BC File Offset: 0x002024BC
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Status() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Status.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008957 RID: 35159 RVA: 0x002042F8 File Offset: 0x002024F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 106108, RefRangeEnd = 106109, XrefRangeStart = 106101, XrefRangeEnd = 106108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Status(StatusEffectData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BattleSaveData.Status>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BattleSaveData.Status.NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008958 RID: 35160 RVA: 0x00043901 File Offset: 0x00041B01
		public Status(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x06008959 RID: 35161 RVA: 0x00204344 File Offset: 0x00202544
		// (set) Token: 0x0600895A RID: 35162 RVA: 0x0004390A File Offset: 0x00041B0A
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x0600895B RID: 35163 RVA: 0x0020436C File Offset: 0x0020256C
		// (set) Token: 0x0600895C RID: 35164 RVA: 0x00043929 File Offset: 0x00041B29
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x0600895D RID: 35165 RVA: 0x00204394 File Offset: 0x00202594
		// (set) Token: 0x0600895E RID: 35166 RVA: 0x00043944 File Offset: 0x00041B44
		public unsafe ulong targetId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_targetId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_targetId)) = value;
			}
		}

		// Token: 0x17002ACB RID: 10955
		// (get) Token: 0x0600895F RID: 35167 RVA: 0x002043BC File Offset: 0x002025BC
		// (set) Token: 0x06008960 RID: 35168 RVA: 0x0004395F File Offset: 0x00041B5F
		public unsafe bool hasApplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_hasApplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_hasApplier)) = value;
			}
		}

		// Token: 0x17002ACC RID: 10956
		// (get) Token: 0x06008961 RID: 35169 RVA: 0x002043E4 File Offset: 0x002025E4
		// (set) Token: 0x06008962 RID: 35170 RVA: 0x0004397A File Offset: 0x00041B7A
		public unsafe ulong applierId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_applierId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BattleSaveData.Status.NativeFieldInfoPtr_applierId)) = value;
			}
		}

		// Token: 0x040057CC RID: 22476
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040057CD RID: 22477
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x040057CE RID: 22478
		private static readonly IntPtr NativeFieldInfoPtr_targetId;

		// Token: 0x040057CF RID: 22479
		private static readonly IntPtr NativeFieldInfoPtr_hasApplier;

		// Token: 0x040057D0 RID: 22480
		private static readonly IntPtr NativeFieldInfoPtr_applierId;

		// Token: 0x040057D1 RID: 22481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040057D2 RID: 22482
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_0;
	}
}

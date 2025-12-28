using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x0200011F RID: 287
public class CardCharm : UpgradeDisplay
{
	// Token: 0x0600118D RID: 4493 RVA: 0x0008AA78 File Offset: 0x00088C78
	// Note: this type is marked as 'beforefieldinit'.
	static CardCharm()
	{
		Il2CppClassPointerStore<CardCharm>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardCharm");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardCharm>.NativeClassPtr);
		CardCharm.NativeFieldInfoPtr_holder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "holder");
		CardCharm.NativeFieldInfoPtr_movementInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "movementInfluence");
		CardCharm.NativeFieldInfoPtr_rotationMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "rotationMax");
		CardCharm.NativeFieldInfoPtr_wobbleFactorRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "wobbleFactorRange");
		CardCharm.NativeFieldInfoPtr_wobbleDampingRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "wobbleDampingRange");
		CardCharm.NativeFieldInfoPtr_wobbleAccRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "wobbleAccRange");
		CardCharm.NativeFieldInfoPtr_wobbleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "wobbleFactor");
		CardCharm.NativeFieldInfoPtr_wobbleDamping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "wobbleDamping");
		CardCharm.NativeFieldInfoPtr_wobbleAcc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "wobbleAcc");
		CardCharm.NativeFieldInfoPtr_prePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "prePosition");
		CardCharm.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "rotation");
		CardCharm.NativeFieldInfoPtr_rotationVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "rotationVelocity");
		CardCharm.NativeFieldInfoPtr_startingZAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, "startingZAngle");
		CardCharm.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666677);
		CardCharm.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666678);
		CardCharm.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666679);
		CardCharm.NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666680);
		CardCharm.NativeMethodInfoPtr_SetAngle_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666681);
		CardCharm.NativeMethodInfoPtr_StopWobble_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666682);
		CardCharm.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardCharm>.NativeClassPtr, 100666683);
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x0008AC38 File Offset: 0x00088E38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44873, XrefRangeEnd = 44876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x0008AC6C File Offset: 0x00088E6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44876, XrefRangeEnd = 44881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x0008ACA0 File Offset: 0x00088EA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44881, XrefRangeEnd = 44897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x0008ACD4 File Offset: 0x00088ED4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44897, XrefRangeEnd = 44904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Wobble(Vector3 movement)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref movement;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x0008AD14 File Offset: 0x00088F14
	[CallerCount(0)]
	public unsafe void SetAngle(float angle)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref angle;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_SetAngle_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x0008AD54 File Offset: 0x00088F54
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44904, XrefRangeEnd = 44906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void StopWobble()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr_StopWobble_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001194 RID: 4500 RVA: 0x0008AD88 File Offset: 0x00088F88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 44906, XrefRangeEnd = 44907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardCharm() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardCharm>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardCharm.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001195 RID: 4501 RVA: 0x0000A5A6 File Offset: 0x000087A6
	public CardCharm(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170004B7 RID: 1207
	// (get) Token: 0x06001196 RID: 4502 RVA: 0x0008ADC4 File Offset: 0x00088FC4
	// (set) Token: 0x06001197 RID: 4503 RVA: 0x0000A5AF File Offset: 0x000087AF
	public unsafe Transform holder
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_holder);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_holder), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x06001198 RID: 4504 RVA: 0x0008ADF4 File Offset: 0x00088FF4
	// (set) Token: 0x06001199 RID: 4505 RVA: 0x0000A5CE File Offset: 0x000087CE
	public unsafe Vector3 movementInfluence
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_movementInfluence);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_movementInfluence)) = value;
		}
	}

	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x0600119A RID: 4506 RVA: 0x0008AE1C File Offset: 0x0008901C
	// (set) Token: 0x0600119B RID: 4507 RVA: 0x0000A5E9 File Offset: 0x000087E9
	public unsafe float rotationMax
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotationMax);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotationMax)) = value;
		}
	}

	// Token: 0x170004BA RID: 1210
	// (get) Token: 0x0600119C RID: 4508 RVA: 0x0008AE44 File Offset: 0x00089044
	// (set) Token: 0x0600119D RID: 4509 RVA: 0x0000A604 File Offset: 0x00008804
	public unsafe Vector2 wobbleFactorRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleFactorRange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleFactorRange)) = value;
		}
	}

	// Token: 0x170004BB RID: 1211
	// (get) Token: 0x0600119E RID: 4510 RVA: 0x0008AE6C File Offset: 0x0008906C
	// (set) Token: 0x0600119F RID: 4511 RVA: 0x0000A61F File Offset: 0x0000881F
	public unsafe Vector2 wobbleDampingRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleDampingRange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleDampingRange)) = value;
		}
	}

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0008AE94 File Offset: 0x00089094
	// (set) Token: 0x060011A1 RID: 4513 RVA: 0x0000A63A File Offset: 0x0000883A
	public unsafe Vector2 wobbleAccRange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleAccRange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleAccRange)) = value;
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0008AEBC File Offset: 0x000890BC
	// (set) Token: 0x060011A3 RID: 4515 RVA: 0x0000A655 File Offset: 0x00008855
	public unsafe float wobbleFactor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleFactor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleFactor)) = value;
		}
	}

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0008AEE4 File Offset: 0x000890E4
	// (set) Token: 0x060011A5 RID: 4517 RVA: 0x0000A670 File Offset: 0x00008870
	public unsafe float wobbleDamping
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleDamping);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleDamping)) = value;
		}
	}

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0008AF0C File Offset: 0x0008910C
	// (set) Token: 0x060011A7 RID: 4519 RVA: 0x0000A68B File Offset: 0x0000888B
	public unsafe float wobbleAcc
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleAcc);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_wobbleAcc)) = value;
		}
	}

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x060011A8 RID: 4520 RVA: 0x0008AF34 File Offset: 0x00089134
	// (set) Token: 0x060011A9 RID: 4521 RVA: 0x0000A6A6 File Offset: 0x000088A6
	public unsafe Vector3 prePosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_prePosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_prePosition)) = value;
		}
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x060011AA RID: 4522 RVA: 0x0008AF5C File Offset: 0x0008915C
	// (set) Token: 0x060011AB RID: 4523 RVA: 0x0000A6C1 File Offset: 0x000088C1
	public unsafe float rotation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotation)) = value;
		}
	}

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x060011AC RID: 4524 RVA: 0x0008AF84 File Offset: 0x00089184
	// (set) Token: 0x060011AD RID: 4525 RVA: 0x0000A6DC File Offset: 0x000088DC
	public unsafe float rotationVelocity
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotationVelocity);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_rotationVelocity)) = value;
		}
	}

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x060011AE RID: 4526 RVA: 0x0008AFAC File Offset: 0x000891AC
	// (set) Token: 0x060011AF RID: 4527 RVA: 0x0000A6F7 File Offset: 0x000088F7
	public unsafe float startingZAngle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_startingZAngle);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardCharm.NativeFieldInfoPtr_startingZAngle)) = value;
		}
	}

	// Token: 0x04000B00 RID: 2816
	private static readonly IntPtr NativeFieldInfoPtr_holder;

	// Token: 0x04000B01 RID: 2817
	private static readonly IntPtr NativeFieldInfoPtr_movementInfluence;

	// Token: 0x04000B02 RID: 2818
	private static readonly IntPtr NativeFieldInfoPtr_rotationMax;

	// Token: 0x04000B03 RID: 2819
	private static readonly IntPtr NativeFieldInfoPtr_wobbleFactorRange;

	// Token: 0x04000B04 RID: 2820
	private static readonly IntPtr NativeFieldInfoPtr_wobbleDampingRange;

	// Token: 0x04000B05 RID: 2821
	private static readonly IntPtr NativeFieldInfoPtr_wobbleAccRange;

	// Token: 0x04000B06 RID: 2822
	private static readonly IntPtr NativeFieldInfoPtr_wobbleFactor;

	// Token: 0x04000B07 RID: 2823
	private static readonly IntPtr NativeFieldInfoPtr_wobbleDamping;

	// Token: 0x04000B08 RID: 2824
	private static readonly IntPtr NativeFieldInfoPtr_wobbleAcc;

	// Token: 0x04000B09 RID: 2825
	private static readonly IntPtr NativeFieldInfoPtr_prePosition;

	// Token: 0x04000B0A RID: 2826
	private static readonly IntPtr NativeFieldInfoPtr_rotation;

	// Token: 0x04000B0B RID: 2827
	private static readonly IntPtr NativeFieldInfoPtr_rotationVelocity;

	// Token: 0x04000B0C RID: 2828
	private static readonly IntPtr NativeFieldInfoPtr_startingZAngle;

	// Token: 0x04000B0D RID: 2829
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000B0E RID: 2830
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000B0F RID: 2831
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000B10 RID: 2832
	private static readonly IntPtr NativeMethodInfoPtr_Wobble_Public_Void_Vector3_0;

	// Token: 0x04000B11 RID: 2833
	private static readonly IntPtr NativeMethodInfoPtr_SetAngle_Public_Void_Single_0;

	// Token: 0x04000B12 RID: 2834
	private static readonly IntPtr NativeMethodInfoPtr_StopWobble_Public_Void_0;

	// Token: 0x04000B13 RID: 2835
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

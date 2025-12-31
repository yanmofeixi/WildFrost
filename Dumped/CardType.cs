using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Localization;

// Token: 0x02000359 RID: 857
public class CardType : DataFile
{
	// Token: 0x0600405B RID: 16475 RVA: 0x00116654 File Offset: 0x00114854
	// Note: this type is marked as 'beforefieldinit'.
	static CardType()
	{
		Il2CppClassPointerStore<CardType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardType");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardType>.NativeClassPtr);
		CardType.NativeFieldInfoPtr_sortPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "sortPriority");
		CardType.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "icon");
		CardType.NativeFieldInfoPtr_prefabRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "prefabRef");
		CardType.NativeFieldInfoPtr_textBoxSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "textBoxSprite");
		CardType.NativeFieldInfoPtr_nameTagSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "nameTagSprite");
		CardType.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "titleKey");
		CardType.NativeFieldInfoPtr_canDie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "canDie");
		CardType.NativeFieldInfoPtr_canTakeCrown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "canTakeCrown");
		CardType.NativeFieldInfoPtr_canRecall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "canRecall");
		CardType.NativeFieldInfoPtr_canReserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "canReserve");
		CardType.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "item");
		CardType.NativeFieldInfoPtr_unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "unit");
		CardType.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "tag");
		CardType.NativeFieldInfoPtr_miniboss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "miniboss");
		CardType.NativeFieldInfoPtr_discoverInJournal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "discoverInJournal");
		CardType.NativeFieldInfoPtr_descriptionColours = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardType>.NativeClassPtr, "descriptionColours");
		CardType.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardType>.NativeClassPtr, 100673568);
		CardType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardType>.NativeClassPtr, 100673569);
	}

	// Token: 0x17001346 RID: 4934
	// (get) Token: 0x0600405C RID: 16476 RVA: 0x001167EC File Offset: 0x001149EC
	public unsafe string title
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111556, RefRangeEnd = 111558, XrefRangeStart = 111554, XrefRangeEnd = 111556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardType.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600405D RID: 16477 RVA: 0x00116824 File Offset: 0x00114A24
	[CallerCount(128)]
	[CachedScanResults(RefRangeStart = 107295, RefRangeEnd = 107423, XrefRangeStart = 107295, XrefRangeEnd = 107423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardType() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardType>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600405E RID: 16478 RVA: 0x00024525 File Offset: 0x00022725
	public CardType(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17001336 RID: 4918
	// (get) Token: 0x0600405F RID: 16479 RVA: 0x00116860 File Offset: 0x00114A60
	// (set) Token: 0x06004060 RID: 16480 RVA: 0x0002452E File Offset: 0x0002272E
	public unsafe int sortPriority
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_sortPriority);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_sortPriority)) = value;
		}
	}

	// Token: 0x17001337 RID: 4919
	// (get) Token: 0x06004061 RID: 16481 RVA: 0x00116888 File Offset: 0x00114A88
	// (set) Token: 0x06004062 RID: 16482 RVA: 0x00024549 File Offset: 0x00022749
	public unsafe Sprite icon
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_icon);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001338 RID: 4920
	// (get) Token: 0x06004063 RID: 16483 RVA: 0x001168B8 File Offset: 0x00114AB8
	// (set) Token: 0x06004064 RID: 16484 RVA: 0x00024568 File Offset: 0x00022768
	public unsafe AssetReference prefabRef
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_prefabRef);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_prefabRef), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001339 RID: 4921
	// (get) Token: 0x06004065 RID: 16485 RVA: 0x001168E8 File Offset: 0x00114AE8
	// (set) Token: 0x06004066 RID: 16486 RVA: 0x00024587 File Offset: 0x00022787
	public unsafe Sprite textBoxSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_textBoxSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_textBoxSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700133A RID: 4922
	// (get) Token: 0x06004067 RID: 16487 RVA: 0x00116918 File Offset: 0x00114B18
	// (set) Token: 0x06004068 RID: 16488 RVA: 0x000245A6 File Offset: 0x000227A6
	public unsafe Sprite nameTagSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_nameTagSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_nameTagSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700133B RID: 4923
	// (get) Token: 0x06004069 RID: 16489 RVA: 0x00116948 File Offset: 0x00114B48
	// (set) Token: 0x0600406A RID: 16490 RVA: 0x000245C5 File Offset: 0x000227C5
	public unsafe LocalizedString titleKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_titleKey);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700133C RID: 4924
	// (get) Token: 0x0600406B RID: 16491 RVA: 0x00116978 File Offset: 0x00114B78
	// (set) Token: 0x0600406C RID: 16492 RVA: 0x000245E4 File Offset: 0x000227E4
	public unsafe bool canDie
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canDie);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canDie)) = value;
		}
	}

	// Token: 0x1700133D RID: 4925
	// (get) Token: 0x0600406D RID: 16493 RVA: 0x001169A0 File Offset: 0x00114BA0
	// (set) Token: 0x0600406E RID: 16494 RVA: 0x000245FF File Offset: 0x000227FF
	public unsafe bool canTakeCrown
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canTakeCrown);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canTakeCrown)) = value;
		}
	}

	// Token: 0x1700133E RID: 4926
	// (get) Token: 0x0600406F RID: 16495 RVA: 0x001169C8 File Offset: 0x00114BC8
	// (set) Token: 0x06004070 RID: 16496 RVA: 0x0002461A File Offset: 0x0002281A
	public unsafe bool canRecall
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canRecall);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canRecall)) = value;
		}
	}

	// Token: 0x1700133F RID: 4927
	// (get) Token: 0x06004071 RID: 16497 RVA: 0x001169F0 File Offset: 0x00114BF0
	// (set) Token: 0x06004072 RID: 16498 RVA: 0x00024635 File Offset: 0x00022835
	public unsafe bool canReserve
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canReserve);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_canReserve)) = value;
		}
	}

	// Token: 0x17001340 RID: 4928
	// (get) Token: 0x06004073 RID: 16499 RVA: 0x00116A18 File Offset: 0x00114C18
	// (set) Token: 0x06004074 RID: 16500 RVA: 0x00024650 File Offset: 0x00022850
	public unsafe bool item
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_item);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_item)) = value;
		}
	}

	// Token: 0x17001341 RID: 4929
	// (get) Token: 0x06004075 RID: 16501 RVA: 0x00116A40 File Offset: 0x00114C40
	// (set) Token: 0x06004076 RID: 16502 RVA: 0x0002466B File Offset: 0x0002286B
	public unsafe bool unit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_unit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_unit)) = value;
		}
	}

	// Token: 0x17001342 RID: 4930
	// (get) Token: 0x06004077 RID: 16503 RVA: 0x00116A68 File Offset: 0x00114C68
	// (set) Token: 0x06004078 RID: 16504 RVA: 0x00024686 File Offset: 0x00022886
	public unsafe string tag
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_tag);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_tag), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001343 RID: 4931
	// (get) Token: 0x06004079 RID: 16505 RVA: 0x00116A90 File Offset: 0x00114C90
	// (set) Token: 0x0600407A RID: 16506 RVA: 0x000246A5 File Offset: 0x000228A5
	public unsafe bool miniboss
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_miniboss);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_miniboss)) = value;
		}
	}

	// Token: 0x17001344 RID: 4932
	// (get) Token: 0x0600407B RID: 16507 RVA: 0x00116AB8 File Offset: 0x00114CB8
	// (set) Token: 0x0600407C RID: 16508 RVA: 0x000246C0 File Offset: 0x000228C0
	public unsafe bool discoverInJournal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_discoverInJournal);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_discoverInJournal)) = value;
		}
	}

	// Token: 0x17001345 RID: 4933
	// (get) Token: 0x0600407D RID: 16509 RVA: 0x00116AE0 File Offset: 0x00114CE0
	// (set) Token: 0x0600407E RID: 16510 RVA: 0x000246DB File Offset: 0x000228DB
	public Text.ColourProfileHex descriptionColours
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_descriptionColours);
			return new Text.ColourProfileHex(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardType.NativeFieldInfoPtr_descriptionColours), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Text.ColourProfileHex>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x040027E3 RID: 10211
	private static readonly IntPtr NativeFieldInfoPtr_sortPriority;

	// Token: 0x040027E4 RID: 10212
	private static readonly IntPtr NativeFieldInfoPtr_icon;

	// Token: 0x040027E5 RID: 10213
	private static readonly IntPtr NativeFieldInfoPtr_prefabRef;

	// Token: 0x040027E6 RID: 10214
	private static readonly IntPtr NativeFieldInfoPtr_textBoxSprite;

	// Token: 0x040027E7 RID: 10215
	private static readonly IntPtr NativeFieldInfoPtr_nameTagSprite;

	// Token: 0x040027E8 RID: 10216
	private static readonly IntPtr NativeFieldInfoPtr_titleKey;

	// Token: 0x040027E9 RID: 10217
	private static readonly IntPtr NativeFieldInfoPtr_canDie;

	// Token: 0x040027EA RID: 10218
	private static readonly IntPtr NativeFieldInfoPtr_canTakeCrown;

	// Token: 0x040027EB RID: 10219
	private static readonly IntPtr NativeFieldInfoPtr_canRecall;

	// Token: 0x040027EC RID: 10220
	private static readonly IntPtr NativeFieldInfoPtr_canReserve;

	// Token: 0x040027ED RID: 10221
	private static readonly IntPtr NativeFieldInfoPtr_item;

	// Token: 0x040027EE RID: 10222
	private static readonly IntPtr NativeFieldInfoPtr_unit;

	// Token: 0x040027EF RID: 10223
	private static readonly IntPtr NativeFieldInfoPtr_tag;

	// Token: 0x040027F0 RID: 10224
	private static readonly IntPtr NativeFieldInfoPtr_miniboss;

	// Token: 0x040027F1 RID: 10225
	private static readonly IntPtr NativeFieldInfoPtr_discoverInJournal;

	// Token: 0x040027F2 RID: 10226
	private static readonly IntPtr NativeFieldInfoPtr_descriptionColours;

	// Token: 0x040027F3 RID: 10227
	private static readonly IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;

	// Token: 0x040027F4 RID: 10228
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}

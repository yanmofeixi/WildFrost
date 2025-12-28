using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.Localization;

// Token: 0x02000358 RID: 856
public class CardData : DataFile
{
	// Token: 0x06003FDE RID: 16350 RVA: 0x00115170 File Offset: 0x00113370
	// Note: this type is marked as 'beforefieldinit'.
	static CardData()
	{
		Il2CppClassPointerStore<CardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData>.NativeClassPtr);
		CardData.NativeFieldInfoPtr_idCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "idCurrent");
		CardData.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "<id>k__BackingField");
		CardData.NativeFieldInfoPtr_titleFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "titleFallback");
		CardData.NativeFieldInfoPtr_forceTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "forceTitle");
		CardData.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "desc");
		CardData.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "titleKey");
		CardData.NativeFieldInfoPtr_textKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "textKey");
		CardData.NativeFieldInfoPtr_textInsert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "textInsert");
		CardData.NativeFieldInfoPtr_flavour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "flavour");
		CardData.NativeFieldInfoPtr_flavourKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "flavourKey");
		CardData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "value");
		CardData.NativeFieldInfoPtr_idleAnimationProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "idleAnimationProfile");
		CardData.NativeFieldInfoPtr_greetMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "greetMessages");
		CardData.NativeFieldInfoPtr_bloodProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "bloodProfile");
		CardData.NativeFieldInfoPtr_hasAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "hasAttack");
		CardData.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "damage");
		CardData.NativeFieldInfoPtr_hasHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "hasHealth");
		CardData.NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "hp");
		CardData.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "counter");
		CardData.NativeFieldInfoPtr_canBeHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "canBeHit");
		CardData.NativeFieldInfoPtr_targetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "targetMode");
		CardData.NativeFieldInfoPtr_attackEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "attackEffects");
		CardData.NativeFieldInfoPtr_mainSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "mainSprite");
		CardData.NativeFieldInfoPtr_backgroundSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "backgroundSprite");
		CardData.NativeFieldInfoPtr_cardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "cardType");
		CardData.NativeFieldInfoPtr_playType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "playType");
		CardData.NativeFieldInfoPtr_needsTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "needsTarget");
		CardData.NativeFieldInfoPtr_canPlayOnBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "canPlayOnBoard");
		CardData.NativeFieldInfoPtr_canPlayOnHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "canPlayOnHand");
		CardData.NativeFieldInfoPtr_canPlayOnFriendly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "canPlayOnFriendly");
		CardData.NativeFieldInfoPtr_canPlayOnEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "canPlayOnEnemy");
		CardData.NativeFieldInfoPtr_playOnSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "playOnSlot");
		CardData.NativeFieldInfoPtr_canShoveToOtherRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "canShoveToOtherRow");
		CardData.NativeFieldInfoPtr_defaultPlayPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "defaultPlayPosition");
		CardData.NativeFieldInfoPtr_uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "uses");
		CardData.NativeFieldInfoPtr_startWithEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "startWithEffects");
		CardData.NativeFieldInfoPtr_traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "traits");
		CardData.NativeFieldInfoPtr_targetConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "targetConstraints");
		CardData.NativeFieldInfoPtr_effectBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "effectBonus");
		CardData.NativeFieldInfoPtr_effectFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "effectFactor");
		CardData.NativeFieldInfoPtr_injuries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "injuries");
		CardData.NativeFieldInfoPtr_upgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "upgrades");
		CardData.NativeFieldInfoPtr_random3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "random3");
		CardData.NativeFieldInfoPtr_charmSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "charmSlots");
		CardData.NativeFieldInfoPtr_tokenSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "tokenSlots");
		CardData.NativeFieldInfoPtr_crownSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "crownSlots");
		CardData.NativeFieldInfoPtr_scriptableImagePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "scriptableImagePrefab");
		CardData.NativeFieldInfoPtr_createScripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "createScripts");
		CardData.NativeFieldInfoPtr_customData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "customData");
		CardData.NativeFieldInfoPtr__original_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData>.NativeClassPtr, "<original>k__BackingField");
		CardData.NativeMethodInfoPtr_get_id_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673526);
		CardData.NativeMethodInfoPtr_set_id_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673527);
		CardData.NativeMethodInfoPtr_SetId_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673528);
		CardData.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673529);
		CardData.NativeMethodInfoPtr_get_HasCustomText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673530);
		CardData.NativeMethodInfoPtr_GetCustomText_Public_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673531);
		CardData.NativeMethodInfoPtr_get_IsItem_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673532);
		CardData.NativeMethodInfoPtr_get_DoesShove_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673533);
		CardData.NativeMethodInfoPtr_get_original_Public_get_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673534);
		CardData.NativeMethodInfoPtr_set_original_Private_set_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673535);
		CardData.NativeMethodInfoPtr_get_HasCrown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673536);
		CardData.NativeMethodInfoPtr_GetCrown_Public_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673537);
		CardData.NativeMethodInfoPtr_RemoveCrown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673538);
		CardData.NativeMethodInfoPtr_Clone_Public_CardData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673539);
		CardData.NativeMethodInfoPtr_Clone_Public_CardData_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673540);
		CardData.NativeMethodInfoPtr_Clone_Public_CardData_Vector3_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673541);
		CardData.NativeMethodInfoPtr_RunCreateScripts_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673542);
		CardData.NativeMethodInfoPtr_SetCustomData_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673543);
		CardData.NativeMethodInfoPtr_TryGetCustomData_Public_Boolean_String_byref_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673544);
		CardData.NativeMethodInfoPtr_IsOffensive_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673545);
		CardData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673546);
		CardData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673547);
		CardData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData>.NativeClassPtr, 100673548);
	}

	// Token: 0x1700132F RID: 4911
	// (get) Token: 0x06003FDF RID: 16351 RVA: 0x00115754 File Offset: 0x00113954
	// (set) Token: 0x06003FE0 RID: 16352 RVA: 0x00115790 File Offset: 0x00113990
	public unsafe ulong id
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_id_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_set_id_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06003FE1 RID: 16353 RVA: 0x001157D0 File Offset: 0x001139D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111261, XrefRangeEnd = 111263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetId(ulong value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_SetId_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17001330 RID: 4912
	// (get) Token: 0x06003FE2 RID: 16354 RVA: 0x00115810 File Offset: 0x00113A10
	public unsafe string title
	{
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 111266, RefRangeEnd = 111300, XrefRangeStart = 111263, XrefRangeEnd = 111266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17001331 RID: 4913
	// (get) Token: 0x06003FE3 RID: 16355 RVA: 0x00115848 File Offset: 0x00113A48
	public unsafe bool HasCustomText
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 111301, RefRangeEnd = 111305, XrefRangeStart = 111300, XrefRangeEnd = 111301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_HasCustomText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06003FE4 RID: 16356 RVA: 0x00115884 File Offset: 0x00113A84
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 111327, RefRangeEnd = 111331, XrefRangeStart = 111305, XrefRangeEnd = 111327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe string GetCustomText(bool silenced = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref silenced;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_GetCustomText_Public_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x17001332 RID: 4914
	// (get) Token: 0x06003FE5 RID: 16357 RVA: 0x001158C8 File Offset: 0x00113AC8
	public unsafe bool IsItem
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_IsItem_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17001333 RID: 4915
	// (get) Token: 0x06003FE6 RID: 16358 RVA: 0x00115904 File Offset: 0x00113B04
	public unsafe bool DoesShove
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_DoesShove_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17001334 RID: 4916
	// (get) Token: 0x06003FE7 RID: 16359 RVA: 0x00115940 File Offset: 0x00113B40
	// (set) Token: 0x06003FE8 RID: 16360 RVA: 0x00115980 File Offset: 0x00113B80
	public unsafe CardData original
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_original_Public_get_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111331, XrefRangeEnd = 111332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_set_original_Private_set_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17001335 RID: 4917
	// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x001159C4 File Offset: 0x00113BC4
	public unsafe bool HasCrown
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 111337, RefRangeEnd = 111342, XrefRangeStart = 111332, XrefRangeEnd = 111337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_get_HasCrown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06003FEA RID: 16362 RVA: 0x00115A00 File Offset: 0x00113C00
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 111361, RefRangeEnd = 111366, XrefRangeStart = 111342, XrefRangeEnd = 111361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardUpgradeData GetCrown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_GetCrown_Public_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardUpgradeData>(intPtr3) : null;
	}

	// Token: 0x06003FEB RID: 16363 RVA: 0x00115A40 File Offset: 0x00113C40
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111368, RefRangeEnd = 111369, XrefRangeStart = 111366, XrefRangeEnd = 111368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCrown()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_RemoveCrown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003FEC RID: 16364 RVA: 0x00115A74 File Offset: 0x00113C74
	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 111376, RefRangeEnd = 111408, XrefRangeStart = 111369, XrefRangeEnd = 111376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardData Clone(bool runCreateScripts = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref runCreateScripts;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_Clone_Public_CardData_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr3) : null;
	}

	// Token: 0x06003FED RID: 16365 RVA: 0x00115AC0 File Offset: 0x00113CC0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111411, RefRangeEnd = 111413, XrefRangeStart = 111408, XrefRangeEnd = 111411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardData Clone(Vector3 random3, bool runCreateScripts = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref random3;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runCreateScripts;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_Clone_Public_CardData_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr3) : null;
	}

	// Token: 0x06003FEE RID: 16366 RVA: 0x00115B1C File Offset: 0x00113D1C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 111462, RefRangeEnd = 111467, XrefRangeStart = 111413, XrefRangeEnd = 111462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardData Clone(Vector3 random3, ulong id, bool runCreateScripts = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref random3;
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref runCreateScripts;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_Clone_Public_CardData_Vector3_UInt64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr3) : null;
	}

	// Token: 0x06003FEF RID: 16367 RVA: 0x00115B84 File Offset: 0x00113D84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111467, XrefRangeEnd = 111475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunCreateScripts()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_RunCreateScripts_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003FF0 RID: 16368 RVA: 0x00115BB8 File Offset: 0x00113DB8
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 111486, RefRangeEnd = 111491, XrefRangeStart = 111475, XrefRangeEnd = 111486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCustomData(string key, Il2CppSystem.Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_SetCustomData_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003FF1 RID: 16369 RVA: 0x00115C0C File Offset: 0x00113E0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111491, XrefRangeEnd = 111501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool TryGetCustomData<T>(string key, out T value, T defaultValue)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		IntPtr intPtr2;
		if (!typeof(T).IsValueType)
		{
			intPtr = 0;
			intPtr2 = &intPtr;
		}
		else
		{
			intPtr2 = ref value;
		}
		ptr2 = intPtr2;
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr3;
		if (!typeof(T).IsValueType)
		{
			T t = defaultValue;
			intPtr3 = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr3 = ref defaultValue;
		}
		ptr3 = intPtr3;
		IntPtr intPtr5;
		IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(CardData.MethodInfoStoreGeneric_TryGetCustomData_Public_Boolean_String_byref_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
		Il2CppException.RaiseExceptionIfNecessary(intPtr5);
		if (!typeof(T).IsValueType)
		{
			IntPtr intPtr6 = intPtr;
			value = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
		}
		return *IL2CPP.il2cpp_object_unbox(intPtr4);
	}

	// Token: 0x06003FF2 RID: 16370 RVA: 0x00115CF0 File Offset: 0x00113EF0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111541, RefRangeEnd = 111542, XrefRangeStart = 111501, XrefRangeEnd = 111541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsOffensive()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_IsOffensive_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06003FF3 RID: 16371 RVA: 0x00115D2C File Offset: 0x00113F2C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111546, RefRangeEnd = 111548, XrefRangeStart = 111542, XrefRangeEnd = 111546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual CardSaveData Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardSaveData>(intPtr3) : null;
	}

	// Token: 0x06003FF4 RID: 16372 RVA: 0x00115D6C File Offset: 0x00113F6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111548, XrefRangeEnd = 111553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06003FF5 RID: 16373 RVA: 0x00115DB4 File Offset: 0x00113FB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111553, XrefRangeEnd = 111554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06003FF6 RID: 16374 RVA: 0x00023F7F File Offset: 0x0002217F
	public CardData(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170012FD RID: 4861
	// (get) Token: 0x06003FF7 RID: 16375 RVA: 0x00115DF0 File Offset: 0x00113FF0
	// (set) Token: 0x06003FF8 RID: 16376 RVA: 0x00023F88 File Offset: 0x00022188
	public unsafe static ulong idCurrent
	{
		get
		{
			ulong result;
			IL2CPP.il2cpp_field_static_get_value(CardData.NativeFieldInfoPtr_idCurrent, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(CardData.NativeFieldInfoPtr_idCurrent, (void*)(&value));
		}
	}

	// Token: 0x170012FE RID: 4862
	// (get) Token: 0x06003FF9 RID: 16377 RVA: 0x00115E0C File Offset: 0x0011400C
	// (set) Token: 0x06003FFA RID: 16378 RVA: 0x00023F96 File Offset: 0x00022196
	public unsafe ulong _id_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr__id_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr__id_k__BackingField)) = value;
		}
	}

	// Token: 0x170012FF RID: 4863
	// (get) Token: 0x06003FFB RID: 16379 RVA: 0x00115E34 File Offset: 0x00114034
	// (set) Token: 0x06003FFC RID: 16380 RVA: 0x00023FB1 File Offset: 0x000221B1
	public unsafe string titleFallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_titleFallback);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_titleFallback), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001300 RID: 4864
	// (get) Token: 0x06003FFD RID: 16381 RVA: 0x00115E5C File Offset: 0x0011405C
	// (set) Token: 0x06003FFE RID: 16382 RVA: 0x00023FD0 File Offset: 0x000221D0
	public unsafe string forceTitle
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_forceTitle);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_forceTitle), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001301 RID: 4865
	// (get) Token: 0x06003FFF RID: 16383 RVA: 0x00115E84 File Offset: 0x00114084
	// (set) Token: 0x06004000 RID: 16384 RVA: 0x00023FEF File Offset: 0x000221EF
	public unsafe string desc
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_desc);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_desc), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001302 RID: 4866
	// (get) Token: 0x06004001 RID: 16385 RVA: 0x00115EAC File Offset: 0x001140AC
	// (set) Token: 0x06004002 RID: 16386 RVA: 0x0002400E File Offset: 0x0002220E
	public unsafe LocalizedString titleKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_titleKey);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001303 RID: 4867
	// (get) Token: 0x06004003 RID: 16387 RVA: 0x00115EDC File Offset: 0x001140DC
	// (set) Token: 0x06004004 RID: 16388 RVA: 0x0002402D File Offset: 0x0002222D
	public unsafe LocalizedString textKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_textKey);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_textKey), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001304 RID: 4868
	// (get) Token: 0x06004005 RID: 16389 RVA: 0x00115F0C File Offset: 0x0011410C
	// (set) Token: 0x06004006 RID: 16390 RVA: 0x0002404C File Offset: 0x0002224C
	public unsafe string textInsert
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_textInsert);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_textInsert), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001305 RID: 4869
	// (get) Token: 0x06004007 RID: 16391 RVA: 0x00115F34 File Offset: 0x00114134
	// (set) Token: 0x06004008 RID: 16392 RVA: 0x0002406B File Offset: 0x0002226B
	public unsafe string flavour
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_flavour);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_flavour), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17001306 RID: 4870
	// (get) Token: 0x06004009 RID: 16393 RVA: 0x00115F5C File Offset: 0x0011415C
	// (set) Token: 0x0600400A RID: 16394 RVA: 0x0002408A File Offset: 0x0002228A
	public unsafe LocalizedString flavourKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_flavourKey);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_flavourKey), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001307 RID: 4871
	// (get) Token: 0x0600400B RID: 16395 RVA: 0x00115F8C File Offset: 0x0011418C
	// (set) Token: 0x0600400C RID: 16396 RVA: 0x000240A9 File Offset: 0x000222A9
	public unsafe int value
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_value);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_value)) = value;
		}
	}

	// Token: 0x17001308 RID: 4872
	// (get) Token: 0x0600400D RID: 16397 RVA: 0x00115FB4 File Offset: 0x001141B4
	// (set) Token: 0x0600400E RID: 16398 RVA: 0x000240C4 File Offset: 0x000222C4
	public unsafe CardAnimationProfile idleAnimationProfile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_idleAnimationProfile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardAnimationProfile>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_idleAnimationProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001309 RID: 4873
	// (get) Token: 0x0600400F RID: 16399 RVA: 0x00115FE4 File Offset: 0x001141E4
	// (set) Token: 0x06004010 RID: 16400 RVA: 0x000240E3 File Offset: 0x000222E3
	public unsafe Il2CppStringArray greetMessages
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_greetMessages);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_greetMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700130A RID: 4874
	// (get) Token: 0x06004011 RID: 16401 RVA: 0x00116014 File Offset: 0x00114214
	// (set) Token: 0x06004012 RID: 16402 RVA: 0x00024102 File Offset: 0x00022302
	public unsafe BloodProfile bloodProfile
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_bloodProfile);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BloodProfile>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_bloodProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700130B RID: 4875
	// (get) Token: 0x06004013 RID: 16403 RVA: 0x00116044 File Offset: 0x00114244
	// (set) Token: 0x06004014 RID: 16404 RVA: 0x00024121 File Offset: 0x00022321
	public unsafe bool hasAttack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hasAttack);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hasAttack)) = value;
		}
	}

	// Token: 0x1700130C RID: 4876
	// (get) Token: 0x06004015 RID: 16405 RVA: 0x0011606C File Offset: 0x0011426C
	// (set) Token: 0x06004016 RID: 16406 RVA: 0x0002413C File Offset: 0x0002233C
	public unsafe int damage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_damage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_damage)) = value;
		}
	}

	// Token: 0x1700130D RID: 4877
	// (get) Token: 0x06004017 RID: 16407 RVA: 0x00116094 File Offset: 0x00114294
	// (set) Token: 0x06004018 RID: 16408 RVA: 0x00024157 File Offset: 0x00022357
	public unsafe bool hasHealth
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hasHealth);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hasHealth)) = value;
		}
	}

	// Token: 0x1700130E RID: 4878
	// (get) Token: 0x06004019 RID: 16409 RVA: 0x001160BC File Offset: 0x001142BC
	// (set) Token: 0x0600401A RID: 16410 RVA: 0x00024172 File Offset: 0x00022372
	public unsafe int hp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_hp)) = value;
		}
	}

	// Token: 0x1700130F RID: 4879
	// (get) Token: 0x0600401B RID: 16411 RVA: 0x001160E4 File Offset: 0x001142E4
	// (set) Token: 0x0600401C RID: 16412 RVA: 0x0002418D File Offset: 0x0002238D
	public unsafe int counter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_counter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_counter)) = value;
		}
	}

	// Token: 0x17001310 RID: 4880
	// (get) Token: 0x0600401D RID: 16413 RVA: 0x0011610C File Offset: 0x0011430C
	// (set) Token: 0x0600401E RID: 16414 RVA: 0x000241A8 File Offset: 0x000223A8
	public unsafe bool canBeHit
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canBeHit);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canBeHit)) = value;
		}
	}

	// Token: 0x17001311 RID: 4881
	// (get) Token: 0x0600401F RID: 16415 RVA: 0x00116134 File Offset: 0x00114334
	// (set) Token: 0x06004020 RID: 16416 RVA: 0x000241C3 File Offset: 0x000223C3
	public unsafe TargetMode targetMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_targetMode);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetMode>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_targetMode), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001312 RID: 4882
	// (get) Token: 0x06004021 RID: 16417 RVA: 0x00116164 File Offset: 0x00114364
	// (set) Token: 0x06004022 RID: 16418 RVA: 0x000241E2 File Offset: 0x000223E2
	public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> attackEffects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_attackEffects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_attackEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001313 RID: 4883
	// (get) Token: 0x06004023 RID: 16419 RVA: 0x00116194 File Offset: 0x00114394
	// (set) Token: 0x06004024 RID: 16420 RVA: 0x00024201 File Offset: 0x00022401
	public unsafe Sprite mainSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_mainSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_mainSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001314 RID: 4884
	// (get) Token: 0x06004025 RID: 16421 RVA: 0x001161C4 File Offset: 0x001143C4
	// (set) Token: 0x06004026 RID: 16422 RVA: 0x00024220 File Offset: 0x00022420
	public unsafe Sprite backgroundSprite
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_backgroundSprite);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_backgroundSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001315 RID: 4885
	// (get) Token: 0x06004027 RID: 16423 RVA: 0x001161F4 File Offset: 0x001143F4
	// (set) Token: 0x06004028 RID: 16424 RVA: 0x0002423F File Offset: 0x0002243F
	public unsafe CardType cardType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_cardType);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardType>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_cardType), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001316 RID: 4886
	// (get) Token: 0x06004029 RID: 16425 RVA: 0x00116224 File Offset: 0x00114424
	// (set) Token: 0x0600402A RID: 16426 RVA: 0x0002425E File Offset: 0x0002245E
	public unsafe Card.PlayType playType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_playType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_playType)) = value;
		}
	}

	// Token: 0x17001317 RID: 4887
	// (get) Token: 0x0600402B RID: 16427 RVA: 0x0011624C File Offset: 0x0011444C
	// (set) Token: 0x0600402C RID: 16428 RVA: 0x00024279 File Offset: 0x00022479
	public unsafe bool needsTarget
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_needsTarget);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_needsTarget)) = value;
		}
	}

	// Token: 0x17001318 RID: 4888
	// (get) Token: 0x0600402D RID: 16429 RVA: 0x00116274 File Offset: 0x00114474
	// (set) Token: 0x0600402E RID: 16430 RVA: 0x00024294 File Offset: 0x00022494
	public unsafe bool canPlayOnBoard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnBoard);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnBoard)) = value;
		}
	}

	// Token: 0x17001319 RID: 4889
	// (get) Token: 0x0600402F RID: 16431 RVA: 0x0011629C File Offset: 0x0011449C
	// (set) Token: 0x06004030 RID: 16432 RVA: 0x000242AF File Offset: 0x000224AF
	public unsafe bool canPlayOnHand
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnHand);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnHand)) = value;
		}
	}

	// Token: 0x1700131A RID: 4890
	// (get) Token: 0x06004031 RID: 16433 RVA: 0x001162C4 File Offset: 0x001144C4
	// (set) Token: 0x06004032 RID: 16434 RVA: 0x000242CA File Offset: 0x000224CA
	public unsafe bool canPlayOnFriendly
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnFriendly);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnFriendly)) = value;
		}
	}

	// Token: 0x1700131B RID: 4891
	// (get) Token: 0x06004033 RID: 16435 RVA: 0x001162EC File Offset: 0x001144EC
	// (set) Token: 0x06004034 RID: 16436 RVA: 0x000242E5 File Offset: 0x000224E5
	public unsafe bool canPlayOnEnemy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnEnemy);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canPlayOnEnemy)) = value;
		}
	}

	// Token: 0x1700131C RID: 4892
	// (get) Token: 0x06004035 RID: 16437 RVA: 0x00116314 File Offset: 0x00114514
	// (set) Token: 0x06004036 RID: 16438 RVA: 0x00024300 File Offset: 0x00022500
	public unsafe bool playOnSlot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_playOnSlot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_playOnSlot)) = value;
		}
	}

	// Token: 0x1700131D RID: 4893
	// (get) Token: 0x06004037 RID: 16439 RVA: 0x0011633C File Offset: 0x0011453C
	// (set) Token: 0x06004038 RID: 16440 RVA: 0x0002431B File Offset: 0x0002251B
	public unsafe bool canShoveToOtherRow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canShoveToOtherRow);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_canShoveToOtherRow)) = value;
		}
	}

	// Token: 0x1700131E RID: 4894
	// (get) Token: 0x06004039 RID: 16441 RVA: 0x00116364 File Offset: 0x00114564
	// (set) Token: 0x0600403A RID: 16442 RVA: 0x00024336 File Offset: 0x00022536
	public unsafe CardData.PlayPosition defaultPlayPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_defaultPlayPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_defaultPlayPosition)) = value;
		}
	}

	// Token: 0x1700131F RID: 4895
	// (get) Token: 0x0600403B RID: 16443 RVA: 0x0011638C File Offset: 0x0011458C
	// (set) Token: 0x0600403C RID: 16444 RVA: 0x00024351 File Offset: 0x00022551
	public unsafe int uses
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_uses);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_uses)) = value;
		}
	}

	// Token: 0x17001320 RID: 4896
	// (get) Token: 0x0600403D RID: 16445 RVA: 0x001163B4 File Offset: 0x001145B4
	// (set) Token: 0x0600403E RID: 16446 RVA: 0x0002436C File Offset: 0x0002256C
	public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> startWithEffects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_startWithEffects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_startWithEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001321 RID: 4897
	// (get) Token: 0x0600403F RID: 16447 RVA: 0x001163E4 File Offset: 0x001145E4
	// (set) Token: 0x06004040 RID: 16448 RVA: 0x0002438B File Offset: 0x0002258B
	public unsafe List<CardData.TraitStacks> traits
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_traits);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardData.TraitStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_traits), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001322 RID: 4898
	// (get) Token: 0x06004041 RID: 16449 RVA: 0x00116414 File Offset: 0x00114614
	// (set) Token: 0x06004042 RID: 16450 RVA: 0x000243AA File Offset: 0x000225AA
	public unsafe Il2CppReferenceArray<TargetConstraint> targetConstraints
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_targetConstraints);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TargetConstraint>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_targetConstraints), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001323 RID: 4899
	// (get) Token: 0x06004043 RID: 16451 RVA: 0x00116444 File Offset: 0x00114644
	// (set) Token: 0x06004044 RID: 16452 RVA: 0x000243C9 File Offset: 0x000225C9
	public unsafe int effectBonus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_effectBonus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_effectBonus)) = value;
		}
	}

	// Token: 0x17001324 RID: 4900
	// (get) Token: 0x06004045 RID: 16453 RVA: 0x0011646C File Offset: 0x0011466C
	// (set) Token: 0x06004046 RID: 16454 RVA: 0x000243E4 File Offset: 0x000225E4
	public unsafe float effectFactor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_effectFactor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_effectFactor)) = value;
		}
	}

	// Token: 0x17001325 RID: 4901
	// (get) Token: 0x06004047 RID: 16455 RVA: 0x00116494 File Offset: 0x00114694
	// (set) Token: 0x06004048 RID: 16456 RVA: 0x000243FF File Offset: 0x000225FF
	public unsafe List<CardData.StatusEffectStacks> injuries
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_injuries);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_injuries), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001326 RID: 4902
	// (get) Token: 0x06004049 RID: 16457 RVA: 0x001164C4 File Offset: 0x001146C4
	// (set) Token: 0x0600404A RID: 16458 RVA: 0x0002441E File Offset: 0x0002261E
	public unsafe List<CardUpgradeData> upgrades
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_upgrades);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardUpgradeData>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_upgrades), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001327 RID: 4903
	// (get) Token: 0x0600404B RID: 16459 RVA: 0x001164F4 File Offset: 0x001146F4
	// (set) Token: 0x0600404C RID: 16460 RVA: 0x0002443D File Offset: 0x0002263D
	public unsafe Vector3 random3
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_random3);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_random3)) = value;
		}
	}

	// Token: 0x17001328 RID: 4904
	// (get) Token: 0x0600404D RID: 16461 RVA: 0x0011651C File Offset: 0x0011471C
	// (set) Token: 0x0600404E RID: 16462 RVA: 0x00024458 File Offset: 0x00022658
	public unsafe int charmSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_charmSlots);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_charmSlots)) = value;
		}
	}

	// Token: 0x17001329 RID: 4905
	// (get) Token: 0x0600404F RID: 16463 RVA: 0x00116544 File Offset: 0x00114744
	// (set) Token: 0x06004050 RID: 16464 RVA: 0x00024473 File Offset: 0x00022673
	public unsafe int tokenSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_tokenSlots);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_tokenSlots)) = value;
		}
	}

	// Token: 0x1700132A RID: 4906
	// (get) Token: 0x06004051 RID: 16465 RVA: 0x0011656C File Offset: 0x0011476C
	// (set) Token: 0x06004052 RID: 16466 RVA: 0x0002448E File Offset: 0x0002268E
	public unsafe int crownSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_crownSlots);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_crownSlots)) = value;
		}
	}

	// Token: 0x1700132B RID: 4907
	// (get) Token: 0x06004053 RID: 16467 RVA: 0x00116594 File Offset: 0x00114794
	// (set) Token: 0x06004054 RID: 16468 RVA: 0x000244A9 File Offset: 0x000226A9
	public unsafe ScriptableCardImage scriptableImagePrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_scriptableImagePrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableCardImage>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_scriptableImagePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700132C RID: 4908
	// (get) Token: 0x06004055 RID: 16469 RVA: 0x001165C4 File Offset: 0x001147C4
	// (set) Token: 0x06004056 RID: 16470 RVA: 0x000244C8 File Offset: 0x000226C8
	public unsafe Il2CppReferenceArray<CardScript> createScripts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_createScripts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardScript>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_createScripts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700132D RID: 4909
	// (get) Token: 0x06004057 RID: 16471 RVA: 0x001165F4 File Offset: 0x001147F4
	// (set) Token: 0x06004058 RID: 16472 RVA: 0x000244E7 File Offset: 0x000226E7
	public unsafe Dictionary<string, Il2CppSystem.Object> customData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_customData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr_customData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700132E RID: 4910
	// (get) Token: 0x06004059 RID: 16473 RVA: 0x00116624 File Offset: 0x00114824
	// (set) Token: 0x0600405A RID: 16474 RVA: 0x00024506 File Offset: 0x00022706
	public unsafe CardData _original_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr__original_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.NativeFieldInfoPtr__original_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400279A RID: 10138
	private static readonly IntPtr NativeFieldInfoPtr_idCurrent;

	// Token: 0x0400279B RID: 10139
	private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

	// Token: 0x0400279C RID: 10140
	private static readonly IntPtr NativeFieldInfoPtr_titleFallback;

	// Token: 0x0400279D RID: 10141
	private static readonly IntPtr NativeFieldInfoPtr_forceTitle;

	// Token: 0x0400279E RID: 10142
	private static readonly IntPtr NativeFieldInfoPtr_desc;

	// Token: 0x0400279F RID: 10143
	private static readonly IntPtr NativeFieldInfoPtr_titleKey;

	// Token: 0x040027A0 RID: 10144
	private static readonly IntPtr NativeFieldInfoPtr_textKey;

	// Token: 0x040027A1 RID: 10145
	private static readonly IntPtr NativeFieldInfoPtr_textInsert;

	// Token: 0x040027A2 RID: 10146
	private static readonly IntPtr NativeFieldInfoPtr_flavour;

	// Token: 0x040027A3 RID: 10147
	private static readonly IntPtr NativeFieldInfoPtr_flavourKey;

	// Token: 0x040027A4 RID: 10148
	private static readonly IntPtr NativeFieldInfoPtr_value;

	// Token: 0x040027A5 RID: 10149
	private static readonly IntPtr NativeFieldInfoPtr_idleAnimationProfile;

	// Token: 0x040027A6 RID: 10150
	private static readonly IntPtr NativeFieldInfoPtr_greetMessages;

	// Token: 0x040027A7 RID: 10151
	private static readonly IntPtr NativeFieldInfoPtr_bloodProfile;

	// Token: 0x040027A8 RID: 10152
	private static readonly IntPtr NativeFieldInfoPtr_hasAttack;

	// Token: 0x040027A9 RID: 10153
	private static readonly IntPtr NativeFieldInfoPtr_damage;

	// Token: 0x040027AA RID: 10154
	private static readonly IntPtr NativeFieldInfoPtr_hasHealth;

	// Token: 0x040027AB RID: 10155
	private static readonly IntPtr NativeFieldInfoPtr_hp;

	// Token: 0x040027AC RID: 10156
	private static readonly IntPtr NativeFieldInfoPtr_counter;

	// Token: 0x040027AD RID: 10157
	private static readonly IntPtr NativeFieldInfoPtr_canBeHit;

	// Token: 0x040027AE RID: 10158
	private static readonly IntPtr NativeFieldInfoPtr_targetMode;

	// Token: 0x040027AF RID: 10159
	private static readonly IntPtr NativeFieldInfoPtr_attackEffects;

	// Token: 0x040027B0 RID: 10160
	private static readonly IntPtr NativeFieldInfoPtr_mainSprite;

	// Token: 0x040027B1 RID: 10161
	private static readonly IntPtr NativeFieldInfoPtr_backgroundSprite;

	// Token: 0x040027B2 RID: 10162
	private static readonly IntPtr NativeFieldInfoPtr_cardType;

	// Token: 0x040027B3 RID: 10163
	private static readonly IntPtr NativeFieldInfoPtr_playType;

	// Token: 0x040027B4 RID: 10164
	private static readonly IntPtr NativeFieldInfoPtr_needsTarget;

	// Token: 0x040027B5 RID: 10165
	private static readonly IntPtr NativeFieldInfoPtr_canPlayOnBoard;

	// Token: 0x040027B6 RID: 10166
	private static readonly IntPtr NativeFieldInfoPtr_canPlayOnHand;

	// Token: 0x040027B7 RID: 10167
	private static readonly IntPtr NativeFieldInfoPtr_canPlayOnFriendly;

	// Token: 0x040027B8 RID: 10168
	private static readonly IntPtr NativeFieldInfoPtr_canPlayOnEnemy;

	// Token: 0x040027B9 RID: 10169
	private static readonly IntPtr NativeFieldInfoPtr_playOnSlot;

	// Token: 0x040027BA RID: 10170
	private static readonly IntPtr NativeFieldInfoPtr_canShoveToOtherRow;

	// Token: 0x040027BB RID: 10171
	private static readonly IntPtr NativeFieldInfoPtr_defaultPlayPosition;

	// Token: 0x040027BC RID: 10172
	private static readonly IntPtr NativeFieldInfoPtr_uses;

	// Token: 0x040027BD RID: 10173
	private static readonly IntPtr NativeFieldInfoPtr_startWithEffects;

	// Token: 0x040027BE RID: 10174
	private static readonly IntPtr NativeFieldInfoPtr_traits;

	// Token: 0x040027BF RID: 10175
	private static readonly IntPtr NativeFieldInfoPtr_targetConstraints;

	// Token: 0x040027C0 RID: 10176
	private static readonly IntPtr NativeFieldInfoPtr_effectBonus;

	// Token: 0x040027C1 RID: 10177
	private static readonly IntPtr NativeFieldInfoPtr_effectFactor;

	// Token: 0x040027C2 RID: 10178
	private static readonly IntPtr NativeFieldInfoPtr_injuries;

	// Token: 0x040027C3 RID: 10179
	private static readonly IntPtr NativeFieldInfoPtr_upgrades;

	// Token: 0x040027C4 RID: 10180
	private static readonly IntPtr NativeFieldInfoPtr_random3;

	// Token: 0x040027C5 RID: 10181
	private static readonly IntPtr NativeFieldInfoPtr_charmSlots;

	// Token: 0x040027C6 RID: 10182
	private static readonly IntPtr NativeFieldInfoPtr_tokenSlots;

	// Token: 0x040027C7 RID: 10183
	private static readonly IntPtr NativeFieldInfoPtr_crownSlots;

	// Token: 0x040027C8 RID: 10184
	private static readonly IntPtr NativeFieldInfoPtr_scriptableImagePrefab;

	// Token: 0x040027C9 RID: 10185
	private static readonly IntPtr NativeFieldInfoPtr_createScripts;

	// Token: 0x040027CA RID: 10186
	private static readonly IntPtr NativeFieldInfoPtr_customData;

	// Token: 0x040027CB RID: 10187
	private static readonly IntPtr NativeFieldInfoPtr__original_k__BackingField;

	// Token: 0x040027CC RID: 10188
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_UInt64_0;

	// Token: 0x040027CD RID: 10189
	private static readonly IntPtr NativeMethodInfoPtr_set_id_Private_set_Void_UInt64_0;

	// Token: 0x040027CE RID: 10190
	private static readonly IntPtr NativeMethodInfoPtr_SetId_Private_Void_UInt64_0;

	// Token: 0x040027CF RID: 10191
	private static readonly IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;

	// Token: 0x040027D0 RID: 10192
	private static readonly IntPtr NativeMethodInfoPtr_get_HasCustomText_Public_get_Boolean_0;

	// Token: 0x040027D1 RID: 10193
	private static readonly IntPtr NativeMethodInfoPtr_GetCustomText_Public_String_Boolean_0;

	// Token: 0x040027D2 RID: 10194
	private static readonly IntPtr NativeMethodInfoPtr_get_IsItem_Private_get_Boolean_0;

	// Token: 0x040027D3 RID: 10195
	private static readonly IntPtr NativeMethodInfoPtr_get_DoesShove_Private_get_Boolean_0;

	// Token: 0x040027D4 RID: 10196
	private static readonly IntPtr NativeMethodInfoPtr_get_original_Public_get_CardData_0;

	// Token: 0x040027D5 RID: 10197
	private static readonly IntPtr NativeMethodInfoPtr_set_original_Private_set_Void_CardData_0;

	// Token: 0x040027D6 RID: 10198
	private static readonly IntPtr NativeMethodInfoPtr_get_HasCrown_Public_get_Boolean_0;

	// Token: 0x040027D7 RID: 10199
	private static readonly IntPtr NativeMethodInfoPtr_GetCrown_Public_CardUpgradeData_0;

	// Token: 0x040027D8 RID: 10200
	private static readonly IntPtr NativeMethodInfoPtr_RemoveCrown_Public_Void_0;

	// Token: 0x040027D9 RID: 10201
	private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_CardData_Boolean_0;

	// Token: 0x040027DA RID: 10202
	private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_CardData_Vector3_Boolean_0;

	// Token: 0x040027DB RID: 10203
	private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_CardData_Vector3_UInt64_Boolean_0;

	// Token: 0x040027DC RID: 10204
	private static readonly IntPtr NativeMethodInfoPtr_RunCreateScripts_Public_Void_0;

	// Token: 0x040027DD RID: 10205
	private static readonly IntPtr NativeMethodInfoPtr_SetCustomData_Public_Void_String_Object_0;

	// Token: 0x040027DE RID: 10206
	private static readonly IntPtr NativeMethodInfoPtr_TryGetCustomData_Public_Boolean_String_byref_T_T_0;

	// Token: 0x040027DF RID: 10207
	private static readonly IntPtr NativeMethodInfoPtr_IsOffensive_Public_Boolean_0;

	// Token: 0x040027E0 RID: 10208
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardSaveData_0;

	// Token: 0x040027E1 RID: 10209
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x040027E2 RID: 10210
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020008B5 RID: 2229
	public enum PlayPosition
	{
		// Token: 0x04005A90 RID: 23184
		None,
		// Token: 0x04005A91 RID: 23185
		Friendly,
		// Token: 0x04005A92 RID: 23186
		Enemy,
		// Token: 0x04005A93 RID: 23187
		Hand,
		// Token: 0x04005A94 RID: 23188
		FriendlyRow,
		// Token: 0x04005A95 RID: 23189
		EnemyRow,
		// Token: 0x04005A96 RID: 23190
		Field,
		// Token: 0x04005A97 RID: 23191
		FriendlySlot,
		// Token: 0x04005A98 RID: 23192
		EnemySlot
	}

	// Token: 0x020008B6 RID: 2230
	[Serializable]
	public class StatusEffectStacks : Il2CppSystem.Object
	{
		// Token: 0x06008E04 RID: 36356 RVA: 0x00211D58 File Offset: 0x0020FF58
		// Note: this type is marked as 'beforefieldinit'.
		static StatusEffectStacks()
		{
			Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardData>.NativeClassPtr, "StatusEffectStacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr);
			CardData.StatusEffectStacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, "data");
			CardData.StatusEffectStacks.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, "count");
			CardData.StatusEffectStacks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673549);
			CardData.StatusEffectStacks.NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673550);
			CardData.StatusEffectStacks.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_StatusEffectSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673551);
			CardData.StatusEffectStacks.NativeMethodInfoPtr_Stack_Public_Static_Il2CppReferenceArray_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673552);
			CardData.StatusEffectStacks.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673553);
			CardData.StatusEffectStacks.NativeMethodInfoPtr_Clone_Public_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, 100673554);
		}

		// Token: 0x06008E05 RID: 36357 RVA: 0x00211E24 File Offset: 0x00210024
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusEffectStacks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E06 RID: 36358 RVA: 0x00211E60 File Offset: 0x00210060
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 26271, RefRangeEnd = 26287, XrefRangeStart = 26271, XrefRangeEnd = 26287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StatusEffectStacks(StatusEffectData data, int count) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x00211EBC File Offset: 0x002100BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111124, RefRangeEnd = 111125, XrefRangeStart = 111118, XrefRangeEnd = 111124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual StatusEffectSaveData Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_StatusEffectSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StatusEffectSaveData>(intPtr3) : null;
		}

		// Token: 0x06008E08 RID: 36360 RVA: 0x00211EFC File Offset: 0x002100FC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 111173, RefRangeEnd = 111187, XrefRangeStart = 111125, XrefRangeEnd = 111173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<CardData.StatusEffectStacks> Stack(IEnumerable<CardData.StatusEffectStacks> currentEffects, IEnumerable<CardData.StatusEffectStacks> newEffects)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentEffects);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newEffects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr_Stack_Public_Static_Il2CppReferenceArray_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardData.StatusEffectStacks>>(intPtr3) : null;
		}

		// Token: 0x06008E09 RID: 36361 RVA: 0x00211F54 File Offset: 0x00210154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111187, XrefRangeEnd = 111194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardData.StatusEffectStacks.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x00211F98 File Offset: 0x00210198
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 111199, RefRangeEnd = 111203, XrefRangeStart = 111194, XrefRangeEnd = 111199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CardData.StatusEffectStacks Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.NativeMethodInfoPtr_Clone_Public_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardData.StatusEffectStacks>(intPtr3) : null;
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x00045FCB File Offset: 0x000441CB
		public StatusEffectStacks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x06008E0C RID: 36364 RVA: 0x00211FD8 File Offset: 0x002101D8
		// (set) Token: 0x06008E0D RID: 36365 RVA: 0x00045FD4 File Offset: 0x000441D4
		public unsafe StatusEffectData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StatusEffectData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x06008E0E RID: 36366 RVA: 0x00212008 File Offset: 0x00210208
		// (set) Token: 0x06008E0F RID: 36367 RVA: 0x00045FF3 File Offset: 0x000441F3
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x04005A99 RID: 23193
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04005A9A RID: 23194
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04005A9B RID: 23195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005A9C RID: 23196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StatusEffectData_Int32_0;

		// Token: 0x04005A9D RID: 23197
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_StatusEffectSaveData_0;

		// Token: 0x04005A9E RID: 23198
		private static readonly IntPtr NativeMethodInfoPtr_Stack_Public_Static_Il2CppReferenceArray_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_IEnumerable_1_StatusEffectStacks_0;

		// Token: 0x04005A9F RID: 23199
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04005AA0 RID: 23200
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_StatusEffectStacks_0;

		// Token: 0x02000AB1 RID: 2737
		[ObfuscatedName("CardData+StatusEffectStacks+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A4AD RID: 42157 RVA: 0x0025858C File Offset: 0x0025678C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardData.StatusEffectStacks>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr);
				CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr, "e");
				CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr, 100673555);
				CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr, 100673556);
			}

			// Token: 0x0600A4AE RID: 42158 RVA: 0x002585F4 File Offset: 0x002567F4
			[CallerCount(1911)]
			[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.StatusEffectStacks.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A4AF RID: 42159 RVA: 0x00258630 File Offset: 0x00256830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111113, XrefRangeEnd = 111118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Stack_b__0(CardData.StatusEffectStacks a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A4B0 RID: 42160 RVA: 0x00050ECD File Offset: 0x0004F0CD
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170033FB RID: 13307
			// (get) Token: 0x0600A4B1 RID: 42161 RVA: 0x00258680 File Offset: 0x00256880
			// (set) Token: 0x0600A4B2 RID: 42162 RVA: 0x00050ED6 File Offset: 0x0004F0D6
			public unsafe CardData.StatusEffectStacks e
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeFieldInfoPtr_e);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData.StatusEffectStacks>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.StatusEffectStacks.__c__DisplayClass5_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A09 RID: 27145
			private static readonly IntPtr NativeFieldInfoPtr_e;

			// Token: 0x04006A0A RID: 27146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A0B RID: 27147
			private static readonly IntPtr NativeMethodInfoPtr__Stack_b__0_Internal_Boolean_StatusEffectStacks_0;
		}
	}

	// Token: 0x020008B7 RID: 2231
	[Serializable]
	public class TraitStacks : Il2CppSystem.Object
	{
		// Token: 0x06008E10 RID: 36368 RVA: 0x00212030 File Offset: 0x00210230
		// Note: this type is marked as 'beforefieldinit'.
		static TraitStacks()
		{
			Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardData>.NativeClassPtr, "TraitStacks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr);
			CardData.TraitStacks.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, "data");
			CardData.TraitStacks.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, "count");
			CardData.TraitStacks.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_TraitSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, 100673557);
			CardData.TraitStacks.NativeMethodInfoPtr_Stack_Public_Static_Void_byref_List_1_TraitStacks_IEnumerable_1_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, 100673558);
			CardData.TraitStacks.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, 100673559);
			CardData.TraitStacks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr, 100673560);
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x002120D4 File Offset: 0x002102D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111203, XrefRangeEnd = 111209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TraitSaveData Save()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.TraitStacks.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_TraitSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TraitSaveData>(intPtr3) : null;
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x00212114 File Offset: 0x00210314
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 111249, RefRangeEnd = 111252, XrefRangeStart = 111209, XrefRangeEnd = 111249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Stack(ref List<CardData.TraitStacks> traits, IEnumerable<CardData.TraitStacks> newTraits)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(traits);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newTraits);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CardData.TraitStacks.NativeMethodInfoPtr_Stack_Public_Static_Void_byref_List_1_TraitStacks_IEnumerable_1_TraitStacks_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			traits = ((intPtr4 == 0) ? null : new List<CardData.TraitStacks>(intPtr4));
		}

		// Token: 0x06008E13 RID: 36371 RVA: 0x00212174 File Offset: 0x00210374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111252, XrefRangeEnd = 111259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CardData.TraitStacks.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008E14 RID: 36372 RVA: 0x002121B8 File Offset: 0x002103B8
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TraitStacks() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.TraitStacks>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.TraitStacks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E15 RID: 36373 RVA: 0x0004600E File Offset: 0x0004420E
		public TraitStacks(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x06008E16 RID: 36374 RVA: 0x002121F4 File Offset: 0x002103F4
		// (set) Token: 0x06008E17 RID: 36375 RVA: 0x00046017 File Offset: 0x00044217
		public unsafe TraitData data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.TraitStacks.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TraitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.TraitStacks.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x06008E18 RID: 36376 RVA: 0x00212224 File Offset: 0x00210424
		// (set) Token: 0x06008E19 RID: 36377 RVA: 0x00046036 File Offset: 0x00044236
		public unsafe int count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.TraitStacks.NativeFieldInfoPtr_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardData.TraitStacks.NativeFieldInfoPtr_count)) = value;
			}
		}

		// Token: 0x04005AA1 RID: 23201
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04005AA2 RID: 23202
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04005AA3 RID: 23203
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_TraitSaveData_0;

		// Token: 0x04005AA4 RID: 23204
		private static readonly IntPtr NativeMethodInfoPtr_Stack_Public_Static_Void_byref_List_1_TraitStacks_IEnumerable_1_TraitStacks_0;

		// Token: 0x04005AA5 RID: 23205
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04005AA6 RID: 23206
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020008B8 RID: 2232
	[ObfuscatedName("CardData+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06008E1A RID: 36378 RVA: 0x0021224C File Offset: 0x0021044C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<CardData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardData>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr);
			CardData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9");
			CardData.__c.NativeFieldInfoPtr___9__69_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__69_0");
			CardData.__c.NativeFieldInfoPtr___9__73_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__73_0");
			CardData.__c.NativeFieldInfoPtr___9__73_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__73_1");
			CardData.__c.NativeFieldInfoPtr___9__77_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__77_0");
			CardData.__c.NativeFieldInfoPtr___9__77_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, "<>9__77_1");
			CardData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673562);
			CardData.__c.NativeMethodInfoPtr__GetCrown_b__69_0_Internal_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673563);
			CardData.__c.NativeMethodInfoPtr__Clone_b__73_0_Internal_String_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673564);
			CardData.__c.NativeMethodInfoPtr__Clone_b__73_1_Internal_Object_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673565);
			CardData.__c.NativeMethodInfoPtr__IsOffensive_b__77_0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673566);
			CardData.__c.NativeMethodInfoPtr__IsOffensive_b__77_1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr, 100673567);
		}

		// Token: 0x06008E1B RID: 36379 RVA: 0x00212368 File Offset: 0x00210568
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardData.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E1C RID: 36380 RVA: 0x002123A4 File Offset: 0x002105A4
		[CallerCount(0)]
		public unsafe bool _GetCrown_b__69_0(CardUpgradeData a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__GetCrown_b__69_0_Internal_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E1D RID: 36381 RVA: 0x002123F4 File Offset: 0x002105F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111259, XrefRangeEnd = 111260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _Clone_b__73_0(KeyValuePair<string, Il2CppSystem.Object> entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__Clone_b__73_0_Internal_String_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008E1E RID: 36382 RVA: 0x00212444 File Offset: 0x00210644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111260, XrefRangeEnd = 111261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppSystem.Object _Clone_b__73_1(KeyValuePair<string, Il2CppSystem.Object> entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(entry));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__Clone_b__73_1_Internal_Object_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
		}

		// Token: 0x06008E1F RID: 36383 RVA: 0x0021249C File Offset: 0x0021069C
		[CallerCount(0)]
		public unsafe bool _IsOffensive_b__77_0(CardData.StatusEffectStacks s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__IsOffensive_b__77_0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E20 RID: 36384 RVA: 0x002124EC File Offset: 0x002106EC
		[CallerCount(0)]
		public unsafe bool _IsOffensive_b__77_1(CardData.StatusEffectStacks s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardData.__c.NativeMethodInfoPtr__IsOffensive_b__77_1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x00046051 File Offset: 0x00044251
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C70 RID: 11376
		// (get) Token: 0x06008E22 RID: 36386 RVA: 0x0021253C File Offset: 0x0021073C
		// (set) Token: 0x06008E23 RID: 36387 RVA: 0x0004605A File Offset: 0x0004425A
		public unsafe static CardData.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C71 RID: 11377
		// (get) Token: 0x06008E24 RID: 36388 RVA: 0x00212564 File Offset: 0x00210764
		// (set) Token: 0x06008E25 RID: 36389 RVA: 0x0004606C File Offset: 0x0004426C
		public unsafe static Predicate<CardUpgradeData> __9__69_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__69_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<CardUpgradeData>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__69_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C72 RID: 11378
		// (get) Token: 0x06008E26 RID: 36390 RVA: 0x0021258C File Offset: 0x0021078C
		// (set) Token: 0x06008E27 RID: 36391 RVA: 0x0004607E File Offset: 0x0004427E
		public unsafe static Func<KeyValuePair<string, Il2CppSystem.Object>, string> __9__73_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__73_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Il2CppSystem.Object>, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__73_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C73 RID: 11379
		// (get) Token: 0x06008E28 RID: 36392 RVA: 0x002125B4 File Offset: 0x002107B4
		// (set) Token: 0x06008E29 RID: 36393 RVA: 0x00046090 File Offset: 0x00044290
		public unsafe static Func<KeyValuePair<string, Il2CppSystem.Object>, Il2CppSystem.Object> __9__73_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__73_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Il2CppSystem.Object>, Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__73_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C74 RID: 11380
		// (get) Token: 0x06008E2A RID: 36394 RVA: 0x002125DC File Offset: 0x002107DC
		// (set) Token: 0x06008E2B RID: 36395 RVA: 0x000460A2 File Offset: 0x000442A2
		public unsafe static Func<CardData.StatusEffectStacks, bool> __9__77_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__77_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardData.StatusEffectStacks, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__77_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C75 RID: 11381
		// (get) Token: 0x06008E2C RID: 36396 RVA: 0x00212604 File Offset: 0x00210804
		// (set) Token: 0x06008E2D RID: 36397 RVA: 0x000460B4 File Offset: 0x000442B4
		public unsafe static Func<CardData.StatusEffectStacks, bool> __9__77_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardData.__c.NativeFieldInfoPtr___9__77_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardData.StatusEffectStacks, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardData.__c.NativeFieldInfoPtr___9__77_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AA7 RID: 23207
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04005AA8 RID: 23208
		private static readonly IntPtr NativeFieldInfoPtr___9__69_0;

		// Token: 0x04005AA9 RID: 23209
		private static readonly IntPtr NativeFieldInfoPtr___9__73_0;

		// Token: 0x04005AAA RID: 23210
		private static readonly IntPtr NativeFieldInfoPtr___9__73_1;

		// Token: 0x04005AAB RID: 23211
		private static readonly IntPtr NativeFieldInfoPtr___9__77_0;

		// Token: 0x04005AAC RID: 23212
		private static readonly IntPtr NativeFieldInfoPtr___9__77_1;

		// Token: 0x04005AAD RID: 23213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AAE RID: 23214
		private static readonly IntPtr NativeMethodInfoPtr__GetCrown_b__69_0_Internal_Boolean_CardUpgradeData_0;

		// Token: 0x04005AAF RID: 23215
		private static readonly IntPtr NativeMethodInfoPtr__Clone_b__73_0_Internal_String_KeyValuePair_2_String_Object_0;

		// Token: 0x04005AB0 RID: 23216
		private static readonly IntPtr NativeMethodInfoPtr__Clone_b__73_1_Internal_Object_KeyValuePair_2_String_Object_0;

		// Token: 0x04005AB1 RID: 23217
		private static readonly IntPtr NativeMethodInfoPtr__IsOffensive_b__77_0_Internal_Boolean_StatusEffectStacks_0;

		// Token: 0x04005AB2 RID: 23218
		private static readonly IntPtr NativeMethodInfoPtr__IsOffensive_b__77_1_Internal_Boolean_StatusEffectStacks_0;
	}

	// Token: 0x020008B9 RID: 2233
	private sealed class MethodInfoStoreGeneric_TryGetCustomData_Public_Boolean_String_byref_T_T_0<T>
	{
		// Token: 0x04005AB3 RID: 23219
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CardData.NativeMethodInfoPtr_TryGetCustomData_Public_Boolean_String_byref_T_T_0, Il2CppClassPointerStore<CardData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}
}

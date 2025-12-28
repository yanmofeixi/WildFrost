using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

// Token: 0x0200035A RID: 858
public class CardUpgradeData : DataFile
{
	// Token: 0x0600407F RID: 16511 RVA: 0x00116B10 File Offset: 0x00114D10
	// Note: this type is marked as 'beforefieldinit'.
	static CardUpgradeData()
	{
		Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CardUpgradeData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr);
		CardUpgradeData.NativeFieldInfoPtr_tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "tier");
		CardUpgradeData.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "titleKey");
		CardUpgradeData.NativeFieldInfoPtr_textKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "textKey");
		CardUpgradeData.NativeFieldInfoPtr_image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "image");
		CardUpgradeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "type");
		CardUpgradeData.NativeFieldInfoPtr_attackEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "attackEffects");
		CardUpgradeData.NativeFieldInfoPtr_effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "effects");
		CardUpgradeData.NativeFieldInfoPtr_giveTraits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "giveTraits");
		CardUpgradeData.NativeFieldInfoPtr_scripts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "scripts");
		CardUpgradeData.NativeFieldInfoPtr_becomesTargetedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "becomesTargetedCard");
		CardUpgradeData.NativeFieldInfoPtr_canBeRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "canBeRemoved");
		CardUpgradeData.NativeFieldInfoPtr_takeSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "takeSlot");
		CardUpgradeData.NativeFieldInfoPtr_targetConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "targetConstraints");
		CardUpgradeData.NativeFieldInfoPtr_damage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "damage");
		CardUpgradeData.NativeFieldInfoPtr_hp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "hp");
		CardUpgradeData.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "counter");
		CardUpgradeData.NativeFieldInfoPtr_uses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "uses");
		CardUpgradeData.NativeFieldInfoPtr_effectBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "effectBonus");
		CardUpgradeData.NativeFieldInfoPtr_setDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "setDamage");
		CardUpgradeData.NativeFieldInfoPtr_setHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "setHp");
		CardUpgradeData.NativeFieldInfoPtr_setCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "setCounter");
		CardUpgradeData.NativeFieldInfoPtr_setUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "setUses");
		CardUpgradeData.NativeFieldInfoPtr_effectsAffected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "effectsAffected");
		CardUpgradeData.NativeFieldInfoPtr_traitsAffected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "traitsAffected");
		CardUpgradeData.NativeFieldInfoPtr_attackEffectsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "attackEffectsApplied");
		CardUpgradeData.NativeFieldInfoPtr_startWithEffectsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "startWithEffectsApplied");
		CardUpgradeData.NativeFieldInfoPtr_damageChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "damageChange");
		CardUpgradeData.NativeFieldInfoPtr_hpChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "hpChange");
		CardUpgradeData.NativeFieldInfoPtr_counterChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "counterChange");
		CardUpgradeData.NativeFieldInfoPtr_usesChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "usesChange");
		CardUpgradeData.NativeMethodInfoPtr_get_title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673570);
		CardUpgradeData.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673571);
		CardUpgradeData.NativeMethodInfoPtr_Assign_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673572);
		CardUpgradeData.NativeMethodInfoPtr_AdjustStats_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673573);
		CardUpgradeData.NativeMethodInfoPtr_RunScripts_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673574);
		CardUpgradeData.NativeMethodInfoPtr_AdjustEffectBonus_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673575);
		CardUpgradeData.NativeMethodInfoPtr_GainEffects_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673576);
		CardUpgradeData.NativeMethodInfoPtr_Assign_Public_IEnumerator_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673577);
		CardUpgradeData.NativeMethodInfoPtr_UnAssign_Public_Void_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673578);
		CardUpgradeData.NativeMethodInfoPtr_CanAssign_Public_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673579);
		CardUpgradeData.NativeMethodInfoPtr_CanAssign_Public_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673580);
		CardUpgradeData.NativeMethodInfoPtr_Display_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673581);
		CardUpgradeData.NativeMethodInfoPtr_Clone_Public_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673582);
		CardUpgradeData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardUpgradeSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673583);
		CardUpgradeData.NativeMethodInfoPtr_CheckSlots_Private_Boolean_CardData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673584);
		CardUpgradeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673585);
		CardUpgradeData.NativeMethodInfoPtr__CheckSlots_b__47_0_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673586);
		CardUpgradeData.NativeMethodInfoPtr__CheckSlots_b__47_1_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673587);
		CardUpgradeData.NativeMethodInfoPtr__CheckSlots_b__47_2_Private_Boolean_CardUpgradeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, 100673588);
	}

	// Token: 0x17001365 RID: 4965
	// (get) Token: 0x06004080 RID: 16512 RVA: 0x00116F14 File Offset: 0x00115114
	public unsafe string title
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 111592, RefRangeEnd = 111600, XrefRangeStart = 111590, XrefRangeEnd = 111592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_get_title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17001366 RID: 4966
	// (get) Token: 0x06004081 RID: 16513 RVA: 0x00116F4C File Offset: 0x0011514C
	public unsafe string text
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 111602, RefRangeEnd = 111611, XrefRangeStart = 111600, XrefRangeEnd = 111602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06004082 RID: 16514 RVA: 0x00116F84 File Offset: 0x00115184
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 111623, RefRangeEnd = 111633, XrefRangeStart = 111611, XrefRangeEnd = 111623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Assign(CardData cardData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Assign_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x00116FC8 File Offset: 0x001151C8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111637, RefRangeEnd = 111638, XrefRangeStart = 111633, XrefRangeEnd = 111637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustStats(CardData cardData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_AdjustStats_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x0011700C File Offset: 0x0011520C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111639, RefRangeEnd = 111640, XrefRangeStart = 111638, XrefRangeEnd = 111639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RunScripts(CardData cardData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_RunScripts_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004085 RID: 16517 RVA: 0x00117050 File Offset: 0x00115250
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111678, RefRangeEnd = 111680, XrefRangeStart = 111640, XrefRangeEnd = 111678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AdjustEffectBonus(CardData cardData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_AdjustEffectBonus_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004086 RID: 16518 RVA: 0x00117094 File Offset: 0x00115294
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111754, RefRangeEnd = 111756, XrefRangeStart = 111680, XrefRangeEnd = 111754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GainEffects(CardData cardData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_GainEffects_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004087 RID: 16519 RVA: 0x001170D8 File Offset: 0x001152D8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111762, RefRangeEnd = 111764, XrefRangeStart = 111756, XrefRangeEnd = 111762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Assign(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Assign_Public_IEnumerator_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06004088 RID: 16520 RVA: 0x00117128 File Offset: 0x00115328
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 111845, RefRangeEnd = 111847, XrefRangeStart = 111764, XrefRangeEnd = 111845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnAssign(CardData assignedTo)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(assignedTo);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_UnAssign_Public_Void_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004089 RID: 16521 RVA: 0x0011716C File Offset: 0x0011536C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111897, RefRangeEnd = 111898, XrefRangeStart = 111847, XrefRangeEnd = 111897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanAssign(Entity card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_CanAssign_Public_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600408A RID: 16522 RVA: 0x001171BC File Offset: 0x001153BC
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 111948, RefRangeEnd = 111957, XrefRangeStart = 111898, XrefRangeEnd = 111948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CanAssign(CardData cardData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_CanAssign_Public_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600408B RID: 16523 RVA: 0x0011720C File Offset: 0x0011540C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 111972, RefRangeEnd = 111973, XrefRangeStart = 111957, XrefRangeEnd = 111972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Display(Entity entity)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Display_Public_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600408C RID: 16524 RVA: 0x00117250 File Offset: 0x00115450
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 111976, RefRangeEnd = 111999, XrefRangeStart = 111973, XrefRangeEnd = 111976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardUpgradeData Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Clone_Public_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardUpgradeData>(intPtr3) : null;
	}

	// Token: 0x0600408D RID: 16525 RVA: 0x00117290 File Offset: 0x00115490
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111999, XrefRangeEnd = 112004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual CardUpgradeSaveData Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardUpgradeSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardUpgradeSaveData>(intPtr3) : null;
	}

	// Token: 0x0600408E RID: 16526 RVA: 0x001172D0 File Offset: 0x001154D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112004, XrefRangeEnd = 112018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool CheckSlots(CardData cardData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr_CheckSlots_Private_Boolean_CardData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600408F RID: 16527 RVA: 0x00117320 File Offset: 0x00115520
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112018, XrefRangeEnd = 112019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardUpgradeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06004090 RID: 16528 RVA: 0x0011735C File Offset: 0x0011555C
	[CallerCount(0)]
	public unsafe bool _CheckSlots_b__47_0(CardUpgradeData a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CheckSlots_b__47_0_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06004091 RID: 16529 RVA: 0x001173AC File Offset: 0x001155AC
	[CallerCount(0)]
	public unsafe bool _CheckSlots_b__47_1(CardUpgradeData a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CheckSlots_b__47_1_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06004092 RID: 16530 RVA: 0x001173FC File Offset: 0x001155FC
	[CallerCount(0)]
	public unsafe bool _CheckSlots_b__47_2(CardUpgradeData a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.NativeMethodInfoPtr__CheckSlots_b__47_2_Private_Boolean_CardUpgradeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06004093 RID: 16531 RVA: 0x00024709 File Offset: 0x00022909
	public CardUpgradeData(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17001347 RID: 4935
	// (get) Token: 0x06004094 RID: 16532 RVA: 0x0011744C File Offset: 0x0011564C
	// (set) Token: 0x06004095 RID: 16533 RVA: 0x00024712 File Offset: 0x00022912
	public unsafe int tier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_tier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_tier)) = value;
		}
	}

	// Token: 0x17001348 RID: 4936
	// (get) Token: 0x06004096 RID: 16534 RVA: 0x00117474 File Offset: 0x00115674
	// (set) Token: 0x06004097 RID: 16535 RVA: 0x0002472D File Offset: 0x0002292D
	public unsafe LocalizedString titleKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_titleKey);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_titleKey), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001349 RID: 4937
	// (get) Token: 0x06004098 RID: 16536 RVA: 0x001174A4 File Offset: 0x001156A4
	// (set) Token: 0x06004099 RID: 16537 RVA: 0x0002474C File Offset: 0x0002294C
	public unsafe LocalizedString textKey
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_textKey);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedString>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_textKey), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700134A RID: 4938
	// (get) Token: 0x0600409A RID: 16538 RVA: 0x001174D4 File Offset: 0x001156D4
	// (set) Token: 0x0600409B RID: 16539 RVA: 0x0002476B File Offset: 0x0002296B
	public unsafe Sprite image
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_image);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_image), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700134B RID: 4939
	// (get) Token: 0x0600409C RID: 16540 RVA: 0x00117504 File Offset: 0x00115704
	// (set) Token: 0x0600409D RID: 16541 RVA: 0x0002478A File Offset: 0x0002298A
	public unsafe CardUpgradeData.Type type
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_type);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_type)) = value;
		}
	}

	// Token: 0x1700134C RID: 4940
	// (get) Token: 0x0600409E RID: 16542 RVA: 0x0011752C File Offset: 0x0011572C
	// (set) Token: 0x0600409F RID: 16543 RVA: 0x000247A5 File Offset: 0x000229A5
	public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> attackEffects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_attackEffects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_attackEffects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700134D RID: 4941
	// (get) Token: 0x060040A0 RID: 16544 RVA: 0x0011755C File Offset: 0x0011575C
	// (set) Token: 0x060040A1 RID: 16545 RVA: 0x000247C4 File Offset: 0x000229C4
	public unsafe Il2CppReferenceArray<CardData.StatusEffectStacks> effects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effects);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effects), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700134E RID: 4942
	// (get) Token: 0x060040A2 RID: 16546 RVA: 0x0011758C File Offset: 0x0011578C
	// (set) Token: 0x060040A3 RID: 16547 RVA: 0x000247E3 File Offset: 0x000229E3
	public unsafe Il2CppReferenceArray<CardData.TraitStacks> giveTraits
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_giveTraits);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardData.TraitStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_giveTraits), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700134F RID: 4943
	// (get) Token: 0x060040A4 RID: 16548 RVA: 0x001175BC File Offset: 0x001157BC
	// (set) Token: 0x060040A5 RID: 16549 RVA: 0x00024802 File Offset: 0x00022A02
	public unsafe Il2CppReferenceArray<CardScript> scripts
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_scripts);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CardScript>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_scripts), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001350 RID: 4944
	// (get) Token: 0x060040A6 RID: 16550 RVA: 0x001175EC File Offset: 0x001157EC
	// (set) Token: 0x060040A7 RID: 16551 RVA: 0x00024821 File Offset: 0x00022A21
	public unsafe bool becomesTargetedCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_becomesTargetedCard);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_becomesTargetedCard)) = value;
		}
	}

	// Token: 0x17001351 RID: 4945
	// (get) Token: 0x060040A8 RID: 16552 RVA: 0x00117614 File Offset: 0x00115814
	// (set) Token: 0x060040A9 RID: 16553 RVA: 0x0002483C File Offset: 0x00022A3C
	public unsafe bool canBeRemoved
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_canBeRemoved);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_canBeRemoved)) = value;
		}
	}

	// Token: 0x17001352 RID: 4946
	// (get) Token: 0x060040AA RID: 16554 RVA: 0x0011763C File Offset: 0x0011583C
	// (set) Token: 0x060040AB RID: 16555 RVA: 0x00024857 File Offset: 0x00022A57
	public unsafe bool takeSlot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_takeSlot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_takeSlot)) = value;
		}
	}

	// Token: 0x17001353 RID: 4947
	// (get) Token: 0x060040AC RID: 16556 RVA: 0x00117664 File Offset: 0x00115864
	// (set) Token: 0x060040AD RID: 16557 RVA: 0x00024872 File Offset: 0x00022A72
	public unsafe Il2CppReferenceArray<TargetConstraint> targetConstraints
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_targetConstraints);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TargetConstraint>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_targetConstraints), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001354 RID: 4948
	// (get) Token: 0x060040AE RID: 16558 RVA: 0x00117694 File Offset: 0x00115894
	// (set) Token: 0x060040AF RID: 16559 RVA: 0x00024891 File Offset: 0x00022A91
	public unsafe int damage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_damage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_damage)) = value;
		}
	}

	// Token: 0x17001355 RID: 4949
	// (get) Token: 0x060040B0 RID: 16560 RVA: 0x001176BC File Offset: 0x001158BC
	// (set) Token: 0x060040B1 RID: 16561 RVA: 0x000248AC File Offset: 0x00022AAC
	public unsafe int hp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_hp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_hp)) = value;
		}
	}

	// Token: 0x17001356 RID: 4950
	// (get) Token: 0x060040B2 RID: 16562 RVA: 0x001176E4 File Offset: 0x001158E4
	// (set) Token: 0x060040B3 RID: 16563 RVA: 0x000248C7 File Offset: 0x00022AC7
	public unsafe int counter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_counter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_counter)) = value;
		}
	}

	// Token: 0x17001357 RID: 4951
	// (get) Token: 0x060040B4 RID: 16564 RVA: 0x0011770C File Offset: 0x0011590C
	// (set) Token: 0x060040B5 RID: 16565 RVA: 0x000248E2 File Offset: 0x00022AE2
	public unsafe int uses
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_uses);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_uses)) = value;
		}
	}

	// Token: 0x17001358 RID: 4952
	// (get) Token: 0x060040B6 RID: 16566 RVA: 0x00117734 File Offset: 0x00115934
	// (set) Token: 0x060040B7 RID: 16567 RVA: 0x000248FD File Offset: 0x00022AFD
	public unsafe int effectBonus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effectBonus);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effectBonus)) = value;
		}
	}

	// Token: 0x17001359 RID: 4953
	// (get) Token: 0x060040B8 RID: 16568 RVA: 0x0011775C File Offset: 0x0011595C
	// (set) Token: 0x060040B9 RID: 16569 RVA: 0x00024918 File Offset: 0x00022B18
	public unsafe bool setDamage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setDamage);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setDamage)) = value;
		}
	}

	// Token: 0x1700135A RID: 4954
	// (get) Token: 0x060040BA RID: 16570 RVA: 0x00117784 File Offset: 0x00115984
	// (set) Token: 0x060040BB RID: 16571 RVA: 0x00024933 File Offset: 0x00022B33
	public unsafe bool setHp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setHp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setHp)) = value;
		}
	}

	// Token: 0x1700135B RID: 4955
	// (get) Token: 0x060040BC RID: 16572 RVA: 0x001177AC File Offset: 0x001159AC
	// (set) Token: 0x060040BD RID: 16573 RVA: 0x0002494E File Offset: 0x00022B4E
	public unsafe bool setCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setCounter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setCounter)) = value;
		}
	}

	// Token: 0x1700135C RID: 4956
	// (get) Token: 0x060040BE RID: 16574 RVA: 0x001177D4 File Offset: 0x001159D4
	// (set) Token: 0x060040BF RID: 16575 RVA: 0x00024969 File Offset: 0x00022B69
	public unsafe bool setUses
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setUses);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_setUses)) = value;
		}
	}

	// Token: 0x1700135D RID: 4957
	// (get) Token: 0x060040C0 RID: 16576 RVA: 0x001177FC File Offset: 0x001159FC
	// (set) Token: 0x060040C1 RID: 16577 RVA: 0x00024984 File Offset: 0x00022B84
	public unsafe List<CardData.StatusEffectStacks> effectsAffected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effectsAffected);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_effectsAffected), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700135E RID: 4958
	// (get) Token: 0x060040C2 RID: 16578 RVA: 0x0011782C File Offset: 0x00115A2C
	// (set) Token: 0x060040C3 RID: 16579 RVA: 0x000249A3 File Offset: 0x00022BA3
	public unsafe List<CardData.TraitStacks> traitsAffected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_traitsAffected);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardData.TraitStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_traitsAffected), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700135F RID: 4959
	// (get) Token: 0x060040C4 RID: 16580 RVA: 0x0011785C File Offset: 0x00115A5C
	// (set) Token: 0x060040C5 RID: 16581 RVA: 0x000249C2 File Offset: 0x00022BC2
	public unsafe List<CardData.StatusEffectStacks> attackEffectsApplied
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_attackEffectsApplied);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_attackEffectsApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001360 RID: 4960
	// (get) Token: 0x060040C6 RID: 16582 RVA: 0x0011788C File Offset: 0x00115A8C
	// (set) Token: 0x060040C7 RID: 16583 RVA: 0x000249E1 File Offset: 0x00022BE1
	public unsafe List<CardData.StatusEffectStacks> startWithEffectsApplied
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_startWithEffectsApplied);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CardData.StatusEffectStacks>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_startWithEffectsApplied), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17001361 RID: 4961
	// (get) Token: 0x060040C8 RID: 16584 RVA: 0x001178BC File Offset: 0x00115ABC
	// (set) Token: 0x060040C9 RID: 16585 RVA: 0x00024A00 File Offset: 0x00022C00
	public unsafe int damageChange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_damageChange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_damageChange)) = value;
		}
	}

	// Token: 0x17001362 RID: 4962
	// (get) Token: 0x060040CA RID: 16586 RVA: 0x001178E4 File Offset: 0x00115AE4
	// (set) Token: 0x060040CB RID: 16587 RVA: 0x00024A1B File Offset: 0x00022C1B
	public unsafe int hpChange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_hpChange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_hpChange)) = value;
		}
	}

	// Token: 0x17001363 RID: 4963
	// (get) Token: 0x060040CC RID: 16588 RVA: 0x0011790C File Offset: 0x00115B0C
	// (set) Token: 0x060040CD RID: 16589 RVA: 0x00024A36 File Offset: 0x00022C36
	public unsafe int counterChange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_counterChange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_counterChange)) = value;
		}
	}

	// Token: 0x17001364 RID: 4964
	// (get) Token: 0x060040CE RID: 16590 RVA: 0x00117934 File Offset: 0x00115B34
	// (set) Token: 0x060040CF RID: 16591 RVA: 0x00024A51 File Offset: 0x00022C51
	public unsafe int usesChange
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_usesChange);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.NativeFieldInfoPtr_usesChange)) = value;
		}
	}

	// Token: 0x040027F5 RID: 10229
	private static readonly IntPtr NativeFieldInfoPtr_tier;

	// Token: 0x040027F6 RID: 10230
	private static readonly IntPtr NativeFieldInfoPtr_titleKey;

	// Token: 0x040027F7 RID: 10231
	private static readonly IntPtr NativeFieldInfoPtr_textKey;

	// Token: 0x040027F8 RID: 10232
	private static readonly IntPtr NativeFieldInfoPtr_image;

	// Token: 0x040027F9 RID: 10233
	private static readonly IntPtr NativeFieldInfoPtr_type;

	// Token: 0x040027FA RID: 10234
	private static readonly IntPtr NativeFieldInfoPtr_attackEffects;

	// Token: 0x040027FB RID: 10235
	private static readonly IntPtr NativeFieldInfoPtr_effects;

	// Token: 0x040027FC RID: 10236
	private static readonly IntPtr NativeFieldInfoPtr_giveTraits;

	// Token: 0x040027FD RID: 10237
	private static readonly IntPtr NativeFieldInfoPtr_scripts;

	// Token: 0x040027FE RID: 10238
	private static readonly IntPtr NativeFieldInfoPtr_becomesTargetedCard;

	// Token: 0x040027FF RID: 10239
	private static readonly IntPtr NativeFieldInfoPtr_canBeRemoved;

	// Token: 0x04002800 RID: 10240
	private static readonly IntPtr NativeFieldInfoPtr_takeSlot;

	// Token: 0x04002801 RID: 10241
	private static readonly IntPtr NativeFieldInfoPtr_targetConstraints;

	// Token: 0x04002802 RID: 10242
	private static readonly IntPtr NativeFieldInfoPtr_damage;

	// Token: 0x04002803 RID: 10243
	private static readonly IntPtr NativeFieldInfoPtr_hp;

	// Token: 0x04002804 RID: 10244
	private static readonly IntPtr NativeFieldInfoPtr_counter;

	// Token: 0x04002805 RID: 10245
	private static readonly IntPtr NativeFieldInfoPtr_uses;

	// Token: 0x04002806 RID: 10246
	private static readonly IntPtr NativeFieldInfoPtr_effectBonus;

	// Token: 0x04002807 RID: 10247
	private static readonly IntPtr NativeFieldInfoPtr_setDamage;

	// Token: 0x04002808 RID: 10248
	private static readonly IntPtr NativeFieldInfoPtr_setHp;

	// Token: 0x04002809 RID: 10249
	private static readonly IntPtr NativeFieldInfoPtr_setCounter;

	// Token: 0x0400280A RID: 10250
	private static readonly IntPtr NativeFieldInfoPtr_setUses;

	// Token: 0x0400280B RID: 10251
	private static readonly IntPtr NativeFieldInfoPtr_effectsAffected;

	// Token: 0x0400280C RID: 10252
	private static readonly IntPtr NativeFieldInfoPtr_traitsAffected;

	// Token: 0x0400280D RID: 10253
	private static readonly IntPtr NativeFieldInfoPtr_attackEffectsApplied;

	// Token: 0x0400280E RID: 10254
	private static readonly IntPtr NativeFieldInfoPtr_startWithEffectsApplied;

	// Token: 0x0400280F RID: 10255
	private static readonly IntPtr NativeFieldInfoPtr_damageChange;

	// Token: 0x04002810 RID: 10256
	private static readonly IntPtr NativeFieldInfoPtr_hpChange;

	// Token: 0x04002811 RID: 10257
	private static readonly IntPtr NativeFieldInfoPtr_counterChange;

	// Token: 0x04002812 RID: 10258
	private static readonly IntPtr NativeFieldInfoPtr_usesChange;

	// Token: 0x04002813 RID: 10259
	private static readonly IntPtr NativeMethodInfoPtr_get_title_Public_get_String_0;

	// Token: 0x04002814 RID: 10260
	private static readonly IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;

	// Token: 0x04002815 RID: 10261
	private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_Void_CardData_0;

	// Token: 0x04002816 RID: 10262
	private static readonly IntPtr NativeMethodInfoPtr_AdjustStats_Public_Void_CardData_0;

	// Token: 0x04002817 RID: 10263
	private static readonly IntPtr NativeMethodInfoPtr_RunScripts_Public_Void_CardData_0;

	// Token: 0x04002818 RID: 10264
	private static readonly IntPtr NativeMethodInfoPtr_AdjustEffectBonus_Public_Void_CardData_0;

	// Token: 0x04002819 RID: 10265
	private static readonly IntPtr NativeMethodInfoPtr_GainEffects_Public_Void_CardData_0;

	// Token: 0x0400281A RID: 10266
	private static readonly IntPtr NativeMethodInfoPtr_Assign_Public_IEnumerator_Entity_0;

	// Token: 0x0400281B RID: 10267
	private static readonly IntPtr NativeMethodInfoPtr_UnAssign_Public_Void_CardData_0;

	// Token: 0x0400281C RID: 10268
	private static readonly IntPtr NativeMethodInfoPtr_CanAssign_Public_Boolean_Entity_0;

	// Token: 0x0400281D RID: 10269
	private static readonly IntPtr NativeMethodInfoPtr_CanAssign_Public_Boolean_CardData_0;

	// Token: 0x0400281E RID: 10270
	private static readonly IntPtr NativeMethodInfoPtr_Display_Public_Void_Entity_0;

	// Token: 0x0400281F RID: 10271
	private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_CardUpgradeData_0;

	// Token: 0x04002820 RID: 10272
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CardUpgradeSaveData_0;

	// Token: 0x04002821 RID: 10273
	private static readonly IntPtr NativeMethodInfoPtr_CheckSlots_Private_Boolean_CardData_0;

	// Token: 0x04002822 RID: 10274
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04002823 RID: 10275
	private static readonly IntPtr NativeMethodInfoPtr__CheckSlots_b__47_0_Private_Boolean_CardUpgradeData_0;

	// Token: 0x04002824 RID: 10276
	private static readonly IntPtr NativeMethodInfoPtr__CheckSlots_b__47_1_Private_Boolean_CardUpgradeData_0;

	// Token: 0x04002825 RID: 10277
	private static readonly IntPtr NativeMethodInfoPtr__CheckSlots_b__47_2_Private_Boolean_CardUpgradeData_0;

	// Token: 0x020008BA RID: 2234
	public enum Type
	{
		// Token: 0x04005AB5 RID: 23221
		None,
		// Token: 0x04005AB6 RID: 23222
		Charm,
		// Token: 0x04005AB7 RID: 23223
		Token,
		// Token: 0x04005AB8 RID: 23224
		Crown
	}

	// Token: 0x020008BB RID: 2235
	[ObfuscatedName("CardUpgradeData+<>c__DisplayClass39_0")]
	public sealed class __c__DisplayClass39_0 : Il2CppSystem.Object
	{
		// Token: 0x06008E2F RID: 36399 RVA: 0x00212680 File Offset: 0x00210880
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass39_0()
		{
			Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass39_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_0>.NativeClassPtr);
			CardUpgradeData.__c__DisplayClass39_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_0>.NativeClassPtr, "e");
			CardUpgradeData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_0>.NativeClassPtr, 100673589);
			CardUpgradeData.__c__DisplayClass39_0.NativeMethodInfoPtr__GainEffects_b__0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_0>.NativeClassPtr, 100673590);
		}

		// Token: 0x06008E30 RID: 36400 RVA: 0x002126E8 File Offset: 0x002108E8
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass39_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E31 RID: 36401 RVA: 0x00212724 File Offset: 0x00210924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111558, XrefRangeEnd = 111563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GainEffects_b__0(CardData.StatusEffectStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass39_0.NativeMethodInfoPtr__GainEffects_b__0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E32 RID: 36402 RVA: 0x000460C6 File Offset: 0x000442C6
		public __c__DisplayClass39_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x06008E33 RID: 36403 RVA: 0x00212774 File Offset: 0x00210974
		// (set) Token: 0x06008E34 RID: 36404 RVA: 0x000460CF File Offset: 0x000442CF
		public unsafe CardData.StatusEffectStacks e
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass39_0.NativeFieldInfoPtr_e);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData.StatusEffectStacks>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass39_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AB9 RID: 23225
		private static readonly IntPtr NativeFieldInfoPtr_e;

		// Token: 0x04005ABA RID: 23226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005ABB RID: 23227
		private static readonly IntPtr NativeMethodInfoPtr__GainEffects_b__0_Internal_Boolean_StatusEffectStacks_0;
	}

	// Token: 0x020008BC RID: 2236
	[ObfuscatedName("CardUpgradeData+<>c__DisplayClass39_1")]
	public sealed class __c__DisplayClass39_1 : Il2CppSystem.Object
	{
		// Token: 0x06008E35 RID: 36405 RVA: 0x002127A4 File Offset: 0x002109A4
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass39_1()
		{
			Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass39_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_1>.NativeClassPtr);
			CardUpgradeData.__c__DisplayClass39_1.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_1>.NativeClassPtr, "e");
			CardUpgradeData.__c__DisplayClass39_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_1>.NativeClassPtr, 100673591);
			CardUpgradeData.__c__DisplayClass39_1.NativeMethodInfoPtr__GainEffects_b__1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_1>.NativeClassPtr, 100673592);
		}

		// Token: 0x06008E36 RID: 36406 RVA: 0x0021280C File Offset: 0x00210A0C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass39_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass39_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass39_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E37 RID: 36407 RVA: 0x00212848 File Offset: 0x00210A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111563, XrefRangeEnd = 111568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GainEffects_b__1(CardData.StatusEffectStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass39_1.NativeMethodInfoPtr__GainEffects_b__1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E38 RID: 36408 RVA: 0x000460EE File Offset: 0x000442EE
		public __c__DisplayClass39_1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x06008E39 RID: 36409 RVA: 0x00212898 File Offset: 0x00210A98
		// (set) Token: 0x06008E3A RID: 36410 RVA: 0x000460F7 File Offset: 0x000442F7
		public unsafe CardData.StatusEffectStacks e
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass39_1.NativeFieldInfoPtr_e);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData.StatusEffectStacks>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass39_1.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005ABC RID: 23228
		private static readonly IntPtr NativeFieldInfoPtr_e;

		// Token: 0x04005ABD RID: 23229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005ABE RID: 23230
		private static readonly IntPtr NativeMethodInfoPtr__GainEffects_b__1_Internal_Boolean_StatusEffectStacks_0;
	}

	// Token: 0x020008BD RID: 2237
	[ObfuscatedName("CardUpgradeData+<Assign>d__40")]
	public sealed class _Assign_d__40 : Il2CppSystem.Object
	{
		// Token: 0x06008E3B RID: 36411 RVA: 0x002128C8 File Offset: 0x00210AC8
		// Note: this type is marked as 'beforefieldinit'.
		static _Assign_d__40()
		{
			Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<Assign>d__40");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr);
			CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, "<>1__state");
			CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, "<>2__current");
			CardUpgradeData._Assign_d__40.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, "entity");
			CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, "<>4__this");
			CardUpgradeData._Assign_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, 100673593);
			CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, 100673594);
			CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, 100673595);
			CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, 100673596);
			CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, 100673597);
			CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr, 100673598);
		}

		// Token: 0x06008E3C RID: 36412 RVA: 0x002129BC File Offset: 0x00210BBC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Assign_d__40(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData._Assign_d__40>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E3D RID: 36413 RVA: 0x00212A04 File Offset: 0x00210C04
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E3E RID: 36414 RVA: 0x00212A38 File Offset: 0x00210C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111568, XrefRangeEnd = 111569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x06008E3F RID: 36415 RVA: 0x00212A74 File Offset: 0x00210C74
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x00212AB4 File Offset: 0x00210CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111569, XrefRangeEnd = 111575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002C7D RID: 11389
		// (get) Token: 0x06008E41 RID: 36417 RVA: 0x00212AE8 File Offset: 0x00210CE8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData._Assign_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x00046116 File Offset: 0x00044316
		public _Assign_d__40(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x00212B28 File Offset: 0x00210D28
		// (set) Token: 0x06008E44 RID: 36420 RVA: 0x0004611F File Offset: 0x0004431F
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x06008E45 RID: 36421 RVA: 0x00212B50 File Offset: 0x00210D50
		// (set) Token: 0x06008E46 RID: 36422 RVA: 0x0004613A File Offset: 0x0004433A
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x06008E47 RID: 36423 RVA: 0x00212B80 File Offset: 0x00210D80
		// (set) Token: 0x06008E48 RID: 36424 RVA: 0x00046159 File Offset: 0x00044359
		public unsafe Entity entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__40.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__40.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x06008E49 RID: 36425 RVA: 0x00212BB0 File Offset: 0x00210DB0
		// (set) Token: 0x06008E4A RID: 36426 RVA: 0x00046178 File Offset: 0x00044378
		public unsafe CardUpgradeData __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardUpgradeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData._Assign_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005ABF RID: 23231
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04005AC0 RID: 23232
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04005AC1 RID: 23233
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x04005AC2 RID: 23234
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04005AC3 RID: 23235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04005AC4 RID: 23236
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005AC5 RID: 23237
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04005AC6 RID: 23238
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04005AC7 RID: 23239
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04005AC8 RID: 23240
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020008BE RID: 2238
	[ObfuscatedName("CardUpgradeData+<>c__DisplayClass41_0")]
	public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
	{
		// Token: 0x06008E4B RID: 36427 RVA: 0x00212BE0 File Offset: 0x00210DE0
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass41_0()
		{
			Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass41_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_0>.NativeClassPtr);
			CardUpgradeData.__c__DisplayClass41_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_0>.NativeClassPtr, "e");
			CardUpgradeData.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_0>.NativeClassPtr, 100673599);
			CardUpgradeData.__c__DisplayClass41_0.NativeMethodInfoPtr__UnAssign_b__0_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_0>.NativeClassPtr, 100673600);
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x00212C48 File Offset: 0x00210E48
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E4D RID: 36429 RVA: 0x00212C84 File Offset: 0x00210E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111575, XrefRangeEnd = 111580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UnAssign_b__0(CardData.StatusEffectStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass41_0.NativeMethodInfoPtr__UnAssign_b__0_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E4E RID: 36430 RVA: 0x00046197 File Offset: 0x00044397
		public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C7E RID: 11390
		// (get) Token: 0x06008E4F RID: 36431 RVA: 0x00212CD4 File Offset: 0x00210ED4
		// (set) Token: 0x06008E50 RID: 36432 RVA: 0x000461A0 File Offset: 0x000443A0
		public unsafe CardData.StatusEffectStacks e
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass41_0.NativeFieldInfoPtr_e);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData.StatusEffectStacks>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass41_0.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AC9 RID: 23241
		private static readonly IntPtr NativeFieldInfoPtr_e;

		// Token: 0x04005ACA RID: 23242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005ACB RID: 23243
		private static readonly IntPtr NativeMethodInfoPtr__UnAssign_b__0_Internal_Boolean_StatusEffectStacks_0;
	}

	// Token: 0x020008BF RID: 2239
	[ObfuscatedName("CardUpgradeData+<>c__DisplayClass41_1")]
	public sealed class __c__DisplayClass41_1 : Il2CppSystem.Object
	{
		// Token: 0x06008E51 RID: 36433 RVA: 0x00212D04 File Offset: 0x00210F04
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass41_1()
		{
			Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass41_1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_1>.NativeClassPtr);
			CardUpgradeData.__c__DisplayClass41_1.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_1>.NativeClassPtr, "e");
			CardUpgradeData.__c__DisplayClass41_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_1>.NativeClassPtr, 100673601);
			CardUpgradeData.__c__DisplayClass41_1.NativeMethodInfoPtr__UnAssign_b__1_Internal_Boolean_StatusEffectStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_1>.NativeClassPtr, 100673602);
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00212D6C File Offset: 0x00210F6C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass41_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass41_1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass41_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00212DA8 File Offset: 0x00210FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111580, XrefRangeEnd = 111585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _UnAssign_b__1(CardData.StatusEffectStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass41_1.NativeMethodInfoPtr__UnAssign_b__1_Internal_Boolean_StatusEffectStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E54 RID: 36436 RVA: 0x000461BF File Offset: 0x000443BF
		public __c__DisplayClass41_1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C7F RID: 11391
		// (get) Token: 0x06008E55 RID: 36437 RVA: 0x00212DF8 File Offset: 0x00210FF8
		// (set) Token: 0x06008E56 RID: 36438 RVA: 0x000461C8 File Offset: 0x000443C8
		public unsafe CardData.StatusEffectStacks e
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass41_1.NativeFieldInfoPtr_e);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData.StatusEffectStacks>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass41_1.NativeFieldInfoPtr_e), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005ACC RID: 23244
		private static readonly IntPtr NativeFieldInfoPtr_e;

		// Token: 0x04005ACD RID: 23245
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005ACE RID: 23246
		private static readonly IntPtr NativeMethodInfoPtr__UnAssign_b__1_Internal_Boolean_StatusEffectStacks_0;
	}

	// Token: 0x020008C0 RID: 2240
	[ObfuscatedName("CardUpgradeData+<>c__DisplayClass42_0")]
	public sealed class __c__DisplayClass42_0 : Il2CppSystem.Object
	{
		// Token: 0x06008E57 RID: 36439 RVA: 0x00212E28 File Offset: 0x00211028
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass42_0()
		{
			Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass42_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass42_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass42_0>.NativeClassPtr);
			CardUpgradeData.__c__DisplayClass42_0.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass42_0>.NativeClassPtr, "t");
			CardUpgradeData.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass42_0>.NativeClassPtr, 100673603);
			CardUpgradeData.__c__DisplayClass42_0.NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass42_0>.NativeClassPtr, 100673604);
		}

		// Token: 0x06008E58 RID: 36440 RVA: 0x00212E90 File Offset: 0x00211090
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass42_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass42_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass42_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E59 RID: 36441 RVA: 0x00212ECC File Offset: 0x002110CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111585, XrefRangeEnd = 111589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CanAssign_b__1(CardData.TraitStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass42_0.NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x000461E7 File Offset: 0x000443E7
		public __c__DisplayClass42_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C80 RID: 11392
		// (get) Token: 0x06008E5B RID: 36443 RVA: 0x00212F1C File Offset: 0x0021111C
		// (set) Token: 0x06008E5C RID: 36444 RVA: 0x000461F0 File Offset: 0x000443F0
		public unsafe CardData.TraitStacks t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass42_0.NativeFieldInfoPtr_t);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData.TraitStacks>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass42_0.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005ACF RID: 23247
		private static readonly IntPtr NativeFieldInfoPtr_t;

		// Token: 0x04005AD0 RID: 23248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AD1 RID: 23249
		private static readonly IntPtr NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0;
	}

	// Token: 0x020008C1 RID: 2241
	[ObfuscatedName("CardUpgradeData+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06008E5D RID: 36445 RVA: 0x00212F4C File Offset: 0x0021114C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr);
			CardUpgradeData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, "<>9");
			CardUpgradeData.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, "<>9__42_0");
			CardUpgradeData.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, "<>9__43_0");
			CardUpgradeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, 100673606);
			CardUpgradeData.__c.NativeMethodInfoPtr__CanAssign_b__42_0_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, 100673607);
			CardUpgradeData.__c.NativeMethodInfoPtr__CanAssign_b__43_0_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr, 100673608);
		}

		// Token: 0x06008E5E RID: 36446 RVA: 0x00212FF0 File Offset: 0x002111F0
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E5F RID: 36447 RVA: 0x0021302C File Offset: 0x0021122C
		[CallerCount(0)]
		public unsafe bool _CanAssign_b__42_0(CardData.TraitStacks t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c.NativeMethodInfoPtr__CanAssign_b__42_0_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E60 RID: 36448 RVA: 0x0021307C File Offset: 0x0021127C
		[CallerCount(0)]
		public unsafe bool _CanAssign_b__43_0(CardData.TraitStacks t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c.NativeMethodInfoPtr__CanAssign_b__43_0_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E61 RID: 36449 RVA: 0x0004620F File Offset: 0x0004440F
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C81 RID: 11393
		// (get) Token: 0x06008E62 RID: 36450 RVA: 0x002130CC File Offset: 0x002112CC
		// (set) Token: 0x06008E63 RID: 36451 RVA: 0x00046218 File Offset: 0x00044418
		public unsafe static CardUpgradeData.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardUpgradeData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardUpgradeData.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardUpgradeData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C82 RID: 11394
		// (get) Token: 0x06008E64 RID: 36452 RVA: 0x002130F4 File Offset: 0x002112F4
		// (set) Token: 0x06008E65 RID: 36453 RVA: 0x0004622A File Offset: 0x0004442A
		public unsafe static Func<CardData.TraitStacks, bool> __9__42_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardUpgradeData.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardData.TraitStacks, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardUpgradeData.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C83 RID: 11395
		// (get) Token: 0x06008E66 RID: 36454 RVA: 0x0021311C File Offset: 0x0021131C
		// (set) Token: 0x06008E67 RID: 36455 RVA: 0x0004623C File Offset: 0x0004443C
		public unsafe static Func<CardData.TraitStacks, bool> __9__43_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CardUpgradeData.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CardData.TraitStacks, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CardUpgradeData.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AD2 RID: 23250
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04005AD3 RID: 23251
		private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

		// Token: 0x04005AD4 RID: 23252
		private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

		// Token: 0x04005AD5 RID: 23253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005AD6 RID: 23254
		private static readonly IntPtr NativeMethodInfoPtr__CanAssign_b__42_0_Internal_Boolean_TraitStacks_0;

		// Token: 0x04005AD7 RID: 23255
		private static readonly IntPtr NativeMethodInfoPtr__CanAssign_b__43_0_Internal_Boolean_TraitStacks_0;
	}

	// Token: 0x020008C2 RID: 2242
	[ObfuscatedName("CardUpgradeData+<>c__DisplayClass43_0")]
	public sealed class __c__DisplayClass43_0 : Il2CppSystem.Object
	{
		// Token: 0x06008E68 RID: 36456 RVA: 0x00213144 File Offset: 0x00211344
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass43_0()
		{
			Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass43_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CardUpgradeData>.NativeClassPtr, "<>c__DisplayClass43_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass43_0>.NativeClassPtr);
			CardUpgradeData.__c__DisplayClass43_0.NativeFieldInfoPtr_t = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass43_0>.NativeClassPtr, "t");
			CardUpgradeData.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass43_0>.NativeClassPtr, 100673609);
			CardUpgradeData.__c__DisplayClass43_0.NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass43_0>.NativeClassPtr, 100673610);
		}

		// Token: 0x06008E69 RID: 36457 RVA: 0x002131AC File Offset: 0x002113AC
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass43_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CardUpgradeData.__c__DisplayClass43_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass43_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E6A RID: 36458 RVA: 0x002131E8 File Offset: 0x002113E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111589, XrefRangeEnd = 111590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CanAssign_b__1(CardData.TraitStacks a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CardUpgradeData.__c__DisplayClass43_0.NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008E6B RID: 36459 RVA: 0x0004624E File Offset: 0x0004444E
		public __c__DisplayClass43_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002C84 RID: 11396
		// (get) Token: 0x06008E6C RID: 36460 RVA: 0x00213238 File Offset: 0x00211438
		// (set) Token: 0x06008E6D RID: 36461 RVA: 0x00046257 File Offset: 0x00044457
		public unsafe CardData.TraitStacks t
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass43_0.NativeFieldInfoPtr_t);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardData.TraitStacks>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CardUpgradeData.__c__DisplayClass43_0.NativeFieldInfoPtr_t), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005AD8 RID: 23256
		private static readonly IntPtr NativeFieldInfoPtr_t;

		// Token: 0x04005AD9 RID: 23257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005ADA RID: 23258
		private static readonly IntPtr NativeMethodInfoPtr__CanAssign_b__1_Internal_Boolean_TraitStacks_0;
	}
}

using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x020000D5 RID: 213
public class Campaign : MonoBehaviour
{
	// Token: 0x06000A59 RID: 2649 RVA: 0x00073F78 File Offset: 0x00072178
	// Note: this type is marked as 'beforefieldinit'.
	static Campaign()
	{
		Il2CppClassPointerStore<Campaign>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Campaign");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Campaign>.NativeClassPtr);
		Campaign.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "instance");
		Campaign.NativeFieldInfoPtr_characterContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "characterContainer");
		Campaign.NativeFieldInfoPtr_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "characters");
		Campaign.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "nodes");
		Campaign.NativeFieldInfoPtr_systems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "systems");
		Campaign.NativeFieldInfoPtr_preset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "preset");
		Campaign.NativeFieldInfoPtr_battleTiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "battleTiers");
		Campaign.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "Data");
		Campaign.NativeFieldInfoPtr__result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "<result>k__BackingField");
		Campaign.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665243);
		Campaign.NativeMethodInfoPtr_get_result_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665244);
		Campaign.NativeMethodInfoPtr_set_result_Private_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665245);
		Campaign.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665246);
		Campaign.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665247);
		Campaign.NativeMethodInfoPtr_BattleEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665248);
		Campaign.NativeMethodInfoPtr_Begin_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665249);
		Campaign.NativeMethodInfoPtr_End_Public_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665250);
		Campaign.NativeMethodInfoPtr_Final_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665251);
		Campaign.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665252);
		Campaign.NativeMethodInfoPtr_GetNode_Public_Static_CampaignNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665253);
		Campaign.NativeMethodInfoPtr_GetCharacter_Public_Static_Character_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665254);
		Campaign.NativeMethodInfoPtr_GetCharacterId_Public_Static_Int32_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665255);
		Campaign.NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_Character_CampaignNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665256);
		Campaign.NativeMethodInfoPtr_FindCharacterNode_Public_Static_CampaignNode_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665257);
		Campaign.NativeMethodInfoPtr_TryEnterNode_Public_Static_Boolean_CampaignNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665258);
		Campaign.NativeMethodInfoPtr_EnterNode_Private_Static_IEnumerator_CampaignNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665259);
		Campaign.NativeMethodInfoPtr_FirstSave_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665260);
		Campaign.NativeMethodInfoPtr_PromptSave_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665261);
		Campaign.NativeMethodInfoPtr_CheckVictory_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665262);
		Campaign.NativeMethodInfoPtr_CheckContinue_Public_Static_Boolean_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665263);
		Campaign.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CampaignSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665264);
		Campaign.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign>.NativeClassPtr, 100665265);
	}

	// Token: 0x06000A5A RID: 2650 RVA: 0x00074228 File Offset: 0x00072428
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32276, XrefRangeEnd = 32284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0007425C File Offset: 0x0007245C
	// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00074298 File Offset: 0x00072498
	public unsafe Campaign.Result result
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 32284, RefRangeEnd = 32287, XrefRangeStart = 32284, XrefRangeEnd = 32284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_get_result_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_set_result_Private_set_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000A5D RID: 2653 RVA: 0x000742D8 File Offset: 0x000724D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32287, XrefRangeEnd = 32295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A5E RID: 2654 RVA: 0x0007430C File Offset: 0x0007250C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32295, XrefRangeEnd = 32303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A5F RID: 2655 RVA: 0x00074340 File Offset: 0x00072540
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32303, XrefRangeEnd = 32311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BattleEnd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_BattleEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A60 RID: 2656 RVA: 0x00074374 File Offset: 0x00072574
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 32332, RefRangeEnd = 32334, XrefRangeStart = 32311, XrefRangeEnd = 32332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Begin()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_Begin_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A61 RID: 2657 RVA: 0x0007439C File Offset: 0x0007259C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 32345, RefRangeEnd = 32348, XrefRangeStart = 32334, XrefRangeEnd = 32345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void End(Campaign.Result result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref result;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_End_Public_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A62 RID: 2658 RVA: 0x000743DC File Offset: 0x000725DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32358, RefRangeEnd = 32359, XrefRangeStart = 32348, XrefRangeEnd = 32358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Final()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_Final_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A63 RID: 2659 RVA: 0x00074410 File Offset: 0x00072610
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32359, XrefRangeEnd = 32364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000A64 RID: 2660 RVA: 0x00074450 File Offset: 0x00072650
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 32370, RefRangeEnd = 32374, XrefRangeStart = 32364, XrefRangeEnd = 32370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CampaignNode GetNode(int id)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_GetNode_Public_Static_CampaignNode_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CampaignNode>(intPtr3) : null;
	}

	// Token: 0x06000A65 RID: 2661 RVA: 0x00074490 File Offset: 0x00072690
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32380, RefRangeEnd = 32381, XrefRangeStart = 32374, XrefRangeEnd = 32380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Character GetCharacter(int id)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_GetCharacter_Public_Static_Character_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Character>(intPtr3) : null;
	}

	// Token: 0x06000A66 RID: 2662 RVA: 0x000744D0 File Offset: 0x000726D0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 32387, RefRangeEnd = 32389, XrefRangeStart = 32381, XrefRangeEnd = 32387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCharacterId(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_GetCharacterId_Public_Static_Int32_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000A67 RID: 2663 RVA: 0x00074514 File Offset: 0x00072714
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32405, RefRangeEnd = 32406, XrefRangeStart = 32389, XrefRangeEnd = 32405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MoveCharacter(Character character, CampaignNode toNode)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toNode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_Character_CampaignNode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A68 RID: 2664 RVA: 0x0007455C File Offset: 0x0007275C
	[CallerCount(35)]
	[CachedScanResults(RefRangeStart = 32426, RefRangeEnd = 32461, XrefRangeStart = 32406, XrefRangeEnd = 32426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CampaignNode FindCharacterNode(Character character)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(character);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_FindCharacterNode_Public_Static_CampaignNode_Character_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CampaignNode>(intPtr3) : null;
	}

	// Token: 0x06000A69 RID: 2665 RVA: 0x000745A0 File Offset: 0x000727A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32479, RefRangeEnd = 32480, XrefRangeStart = 32461, XrefRangeEnd = 32479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool TryEnterNode(CampaignNode node, bool delay = true)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_TryEnterNode_Public_Static_Boolean_CampaignNode_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000A6A RID: 2666 RVA: 0x000745F0 File Offset: 0x000727F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32480, XrefRangeEnd = 32485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IEnumerator EnterNode(CampaignNode node, bool delay = true)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_EnterNode_Private_Static_IEnumerator_CampaignNode_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00074644 File Offset: 0x00072844
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32520, RefRangeEnd = 32521, XrefRangeStart = 32485, XrefRangeEnd = 32520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FirstSave()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_FirstSave_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x0007466C File Offset: 0x0007286C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 32545, RefRangeEnd = 32550, XrefRangeStart = 32521, XrefRangeEnd = 32545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PromptSave()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_PromptSave_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00074694 File Offset: 0x00072894
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32554, RefRangeEnd = 32555, XrefRangeStart = 32550, XrefRangeEnd = 32554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckVictory()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_CheckVictory_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x000746C4 File Offset: 0x000728C4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 32571, RefRangeEnd = 32575, XrefRangeStart = 32555, XrefRangeEnd = 32571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckContinue(GameMode gameMode)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_CheckContinue_Public_Static_Boolean_GameMode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00074708 File Offset: 0x00072908
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32575, XrefRangeEnd = 32579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual CampaignSaveData Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CampaignSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CampaignSaveData>(intPtr3) : null;
	}

	// Token: 0x06000A70 RID: 2672 RVA: 0x00074748 File Offset: 0x00072948
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32579, XrefRangeEnd = 32595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Campaign() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Campaign>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000A71 RID: 2673 RVA: 0x0000695B File Offset: 0x00004B5B
	public Campaign(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x06000A72 RID: 2674 RVA: 0x00074784 File Offset: 0x00072984
	// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00006964 File Offset: 0x00004B64
	public unsafe static Campaign instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Campaign.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Campaign>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Campaign.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x06000A74 RID: 2676 RVA: 0x000747AC File Offset: 0x000729AC
	// (set) Token: 0x06000A75 RID: 2677 RVA: 0x00006976 File Offset: 0x00004B76
	public unsafe Transform characterContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_characterContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_characterContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x06000A76 RID: 2678 RVA: 0x000747DC File Offset: 0x000729DC
	// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00006995 File Offset: 0x00004B95
	public unsafe List<Character> characters
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_characters);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Character>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_characters), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0007480C File Offset: 0x00072A0C
	// (set) Token: 0x06000A79 RID: 2681 RVA: 0x000069B4 File Offset: 0x00004BB4
	public unsafe List<CampaignNode> nodes
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_nodes);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CampaignNode>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0007483C File Offset: 0x00072A3C
	// (set) Token: 0x06000A7B RID: 2683 RVA: 0x000069D3 File Offset: 0x00004BD3
	public unsafe GameObject systems
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_systems);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_systems), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0007486C File Offset: 0x00072A6C
	// (set) Token: 0x06000A7D RID: 2685 RVA: 0x000069F2 File Offset: 0x00004BF2
	public unsafe TextAsset preset
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_preset);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_preset), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0007489C File Offset: 0x00072A9C
	// (set) Token: 0x06000A7F RID: 2687 RVA: 0x00006A11 File Offset: 0x00004C11
	public unsafe string battleTiers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_battleTiers);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr_battleTiers), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x06000A80 RID: 2688 RVA: 0x000748C4 File Offset: 0x00072AC4
	// (set) Token: 0x06000A81 RID: 2689 RVA: 0x00006A30 File Offset: 0x00004C30
	public unsafe static CampaignData Data
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Campaign.NativeFieldInfoPtr_Data, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CampaignData>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Campaign.NativeFieldInfoPtr_Data, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x06000A82 RID: 2690 RVA: 0x000748EC File Offset: 0x00072AEC
	// (set) Token: 0x06000A83 RID: 2691 RVA: 0x00006A42 File Offset: 0x00004C42
	public unsafe Campaign.Result _result_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr__result_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign.NativeFieldInfoPtr__result_k__BackingField)) = value;
		}
	}

	// Token: 0x04000666 RID: 1638
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x04000667 RID: 1639
	private static readonly IntPtr NativeFieldInfoPtr_characterContainer;

	// Token: 0x04000668 RID: 1640
	private static readonly IntPtr NativeFieldInfoPtr_characters;

	// Token: 0x04000669 RID: 1641
	private static readonly IntPtr NativeFieldInfoPtr_nodes;

	// Token: 0x0400066A RID: 1642
	private static readonly IntPtr NativeFieldInfoPtr_systems;

	// Token: 0x0400066B RID: 1643
	private static readonly IntPtr NativeFieldInfoPtr_preset;

	// Token: 0x0400066C RID: 1644
	private static readonly IntPtr NativeFieldInfoPtr_battleTiers;

	// Token: 0x0400066D RID: 1645
	private static readonly IntPtr NativeFieldInfoPtr_Data;

	// Token: 0x0400066E RID: 1646
	private static readonly IntPtr NativeFieldInfoPtr__result_k__BackingField;

	// Token: 0x0400066F RID: 1647
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000670 RID: 1648
	private static readonly IntPtr NativeMethodInfoPtr_get_result_Public_get_Result_0;

	// Token: 0x04000671 RID: 1649
	private static readonly IntPtr NativeMethodInfoPtr_set_result_Private_set_Void_Result_0;

	// Token: 0x04000672 RID: 1650
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000673 RID: 1651
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x04000674 RID: 1652
	private static readonly IntPtr NativeMethodInfoPtr_BattleEnd_Private_Void_0;

	// Token: 0x04000675 RID: 1653
	private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_Void_0;

	// Token: 0x04000676 RID: 1654
	private static readonly IntPtr NativeMethodInfoPtr_End_Public_Void_Result_0;

	// Token: 0x04000677 RID: 1655
	private static readonly IntPtr NativeMethodInfoPtr_Final_Public_Void_0;

	// Token: 0x04000678 RID: 1656
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;

	// Token: 0x04000679 RID: 1657
	private static readonly IntPtr NativeMethodInfoPtr_GetNode_Public_Static_CampaignNode_Int32_0;

	// Token: 0x0400067A RID: 1658
	private static readonly IntPtr NativeMethodInfoPtr_GetCharacter_Public_Static_Character_Int32_0;

	// Token: 0x0400067B RID: 1659
	private static readonly IntPtr NativeMethodInfoPtr_GetCharacterId_Public_Static_Int32_Character_0;

	// Token: 0x0400067C RID: 1660
	private static readonly IntPtr NativeMethodInfoPtr_MoveCharacter_Public_Static_Void_Character_CampaignNode_0;

	// Token: 0x0400067D RID: 1661
	private static readonly IntPtr NativeMethodInfoPtr_FindCharacterNode_Public_Static_CampaignNode_Character_0;

	// Token: 0x0400067E RID: 1662
	private static readonly IntPtr NativeMethodInfoPtr_TryEnterNode_Public_Static_Boolean_CampaignNode_Boolean_0;

	// Token: 0x0400067F RID: 1663
	private static readonly IntPtr NativeMethodInfoPtr_EnterNode_Private_Static_IEnumerator_CampaignNode_Boolean_0;

	// Token: 0x04000680 RID: 1664
	private static readonly IntPtr NativeMethodInfoPtr_FirstSave_Private_Static_Void_0;

	// Token: 0x04000681 RID: 1665
	private static readonly IntPtr NativeMethodInfoPtr_PromptSave_Public_Static_Void_0;

	// Token: 0x04000682 RID: 1666
	private static readonly IntPtr NativeMethodInfoPtr_CheckVictory_Public_Static_Boolean_0;

	// Token: 0x04000683 RID: 1667
	private static readonly IntPtr NativeMethodInfoPtr_CheckContinue_Public_Static_Boolean_GameMode_0;

	// Token: 0x04000684 RID: 1668
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_Final_New_CampaignSaveData_0;

	// Token: 0x04000685 RID: 1669
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000575 RID: 1397
	public enum Result
	{
		// Token: 0x0400436C RID: 17260
		None,
		// Token: 0x0400436D RID: 17261
		Win,
		// Token: 0x0400436E RID: 17262
		Lose,
		// Token: 0x0400436F RID: 17263
		Restart
	}

	// Token: 0x02000576 RID: 1398
	[ObfuscatedName("Campaign+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06006747 RID: 26439 RVA: 0x0019D5E0 File Offset: 0x0019B7E0
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<Campaign.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Campaign.__c>.NativeClassPtr);
			Campaign.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign.__c>.NativeClassPtr, "<>9");
			Campaign.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign.__c>.NativeClassPtr, "<>9__20_0");
			Campaign.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign.__c>.NativeClassPtr, 100665267);
			Campaign.__c.NativeMethodInfoPtr__Start_b__20_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign.__c>.NativeClassPtr, 100665268);
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x0019D65C File Offset: 0x0019B85C
		[CallerCount(1911)]
		[CachedScanResults(RefRangeStart = 13358, RefRangeEnd = 15269, XrefRangeStart = 13358, XrefRangeEnd = 15269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Campaign.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006749 RID: 26441 RVA: 0x0019D698 File Offset: 0x0019B898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32066, XrefRangeEnd = 32070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Start_b__20_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign.__c.NativeMethodInfoPtr__Start_b__20_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x00032CF5 File Offset: 0x00030EF5
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x0600674B RID: 26443 RVA: 0x0019D6D4 File Offset: 0x0019B8D4
		// (set) Token: 0x0600674C RID: 26444 RVA: 0x00032CFE File Offset: 0x00030EFE
		public unsafe static Campaign.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Campaign.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Campaign.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Campaign.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x0600674D RID: 26445 RVA: 0x0019D6FC File Offset: 0x0019B8FC
		// (set) Token: 0x0600674E RID: 26446 RVA: 0x00032D10 File Offset: 0x00030F10
		public unsafe static Func<bool> __9__20_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Campaign.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Campaign.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004370 RID: 17264
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04004371 RID: 17265
		private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

		// Token: 0x04004372 RID: 17266
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004373 RID: 17267
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__20_0_Internal_Boolean_0;
	}

	// Token: 0x02000577 RID: 1399
	[ObfuscatedName("Campaign+<Start>d__20")]
	public sealed class _Start_d__20 : Il2CppSystem.Object
	{
		// Token: 0x0600674F RID: 26447 RVA: 0x0019D724 File Offset: 0x0019B924
		// Note: this type is marked as 'beforefieldinit'.
		static _Start_d__20()
		{
			Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "<Start>d__20");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr);
			Campaign._Start_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, "<>1__state");
			Campaign._Start_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, "<>2__current");
			Campaign._Start_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, "<>4__this");
			Campaign._Start_d__20.NativeFieldInfoPtr__continueBattleNode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, "<continueBattleNode>5__2");
			Campaign._Start_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, 100665269);
			Campaign._Start_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, 100665270);
			Campaign._Start_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, 100665271);
			Campaign._Start_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, 100665272);
			Campaign._Start_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, 100665273);
			Campaign._Start_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr, 100665274);
		}

		// Token: 0x06006750 RID: 26448 RVA: 0x0019D818 File Offset: 0x0019BA18
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _Start_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Campaign._Start_d__20>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._Start_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006751 RID: 26449 RVA: 0x0019D860 File Offset: 0x0019BA60
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._Start_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006752 RID: 26450 RVA: 0x0019D894 File Offset: 0x0019BA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32070, XrefRangeEnd = 32262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._Start_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06006753 RID: 26451 RVA: 0x0019D8D0 File Offset: 0x0019BAD0
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._Start_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006754 RID: 26452 RVA: 0x0019D910 File Offset: 0x0019BB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32262, XrefRangeEnd = 32268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._Start_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x06006755 RID: 26453 RVA: 0x0019D944 File Offset: 0x0019BB44
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._Start_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x00032D22 File Offset: 0x00030F22
		public _Start_d__20(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x0019D984 File Offset: 0x0019BB84
		// (set) Token: 0x06006758 RID: 26456 RVA: 0x00032D2B File Offset: 0x00030F2B
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._Start_d__20.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._Start_d__20.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06006759 RID: 26457 RVA: 0x0019D9AC File Offset: 0x0019BBAC
		// (set) Token: 0x0600675A RID: 26458 RVA: 0x00032D46 File Offset: 0x00030F46
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._Start_d__20.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._Start_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x0600675B RID: 26459 RVA: 0x0019D9DC File Offset: 0x0019BBDC
		// (set) Token: 0x0600675C RID: 26460 RVA: 0x00032D65 File Offset: 0x00030F65
		public unsafe Campaign __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._Start_d__20.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Campaign>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._Start_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x0600675D RID: 26461 RVA: 0x0019DA0C File Offset: 0x0019BC0C
		// (set) Token: 0x0600675E RID: 26462 RVA: 0x00032D84 File Offset: 0x00030F84
		public unsafe CampaignNode _continueBattleNode_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._Start_d__20.NativeFieldInfoPtr__continueBattleNode_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CampaignNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._Start_d__20.NativeFieldInfoPtr__continueBattleNode_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004374 RID: 17268
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04004375 RID: 17269
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004376 RID: 17270
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04004377 RID: 17271
		private static readonly IntPtr NativeFieldInfoPtr__continueBattleNode_5__2;

		// Token: 0x04004378 RID: 17272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004379 RID: 17273
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400437A RID: 17274
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400437B RID: 17275
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400437C RID: 17276
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400437D RID: 17277
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000578 RID: 1400
	[ObfuscatedName("Campaign+<EnterNode>d__27")]
	public sealed class _EnterNode_d__27 : Il2CppSystem.Object
	{
		// Token: 0x0600675F RID: 26463 RVA: 0x0019DA3C File Offset: 0x0019BC3C
		// Note: this type is marked as 'beforefieldinit'.
		static _EnterNode_d__27()
		{
			Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Campaign>.NativeClassPtr, "<EnterNode>d__27");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr);
			Campaign._EnterNode_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, "<>1__state");
			Campaign._EnterNode_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, "<>2__current");
			Campaign._EnterNode_d__27.NativeFieldInfoPtr_node = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, "node");
			Campaign._EnterNode_d__27.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, "delay");
			Campaign._EnterNode_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, 100665275);
			Campaign._EnterNode_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, 100665276);
			Campaign._EnterNode_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, 100665277);
			Campaign._EnterNode_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, 100665278);
			Campaign._EnterNode_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, 100665279);
			Campaign._EnterNode_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr, 100665280);
		}

		// Token: 0x06006760 RID: 26464 RVA: 0x0019DB30 File Offset: 0x0019BD30
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 54, XrefRangeStart = 1, XrefRangeEnd = 54, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _EnterNode_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Campaign._EnterNode_d__27>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <>1__state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._EnterNode_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x0019DB78 File Offset: 0x0019BD78
		[CallerCount(12683)]
		[CachedScanResults(RefRangeStart = 54, RefRangeEnd = 12737, XrefRangeStart = 54, XrefRangeEnd = 12737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._EnterNode_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006762 RID: 26466 RVA: 0x0019DBAC File Offset: 0x0019BDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32268, XrefRangeEnd = 32270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._EnterNode_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17001FA1 RID: 8097
		// (get) Token: 0x06006763 RID: 26467 RVA: 0x0019DBE8 File Offset: 0x0019BDE8
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._EnterNode_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006764 RID: 26468 RVA: 0x0019DC28 File Offset: 0x0019BE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32270, XrefRangeEnd = 32276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._EnterNode_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001FA2 RID: 8098
		// (get) Token: 0x06006765 RID: 26469 RVA: 0x0019DC5C File Offset: 0x0019BE5C
		public unsafe Il2CppSystem.Object Current
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 12743, RefRangeEnd = 12755, XrefRangeStart = 12743, XrefRangeEnd = 12755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Campaign._EnterNode_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06006766 RID: 26470 RVA: 0x00032DA3 File Offset: 0x00030FA3
		public _EnterNode_d__27(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x06006767 RID: 26471 RVA: 0x0019DC9C File Offset: 0x0019BE9C
		// (set) Token: 0x06006768 RID: 26472 RVA: 0x00032DAC File Offset: 0x00030FAC
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._EnterNode_d__27.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._EnterNode_d__27.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x06006769 RID: 26473 RVA: 0x0019DCC4 File Offset: 0x0019BEC4
		// (set) Token: 0x0600676A RID: 26474 RVA: 0x00032DC7 File Offset: 0x00030FC7
		public unsafe Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._EnterNode_d__27.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._EnterNode_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600676B RID: 26475 RVA: 0x0019DCF4 File Offset: 0x0019BEF4
		// (set) Token: 0x0600676C RID: 26476 RVA: 0x00032DE6 File Offset: 0x00030FE6
		public unsafe CampaignNode node
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._EnterNode_d__27.NativeFieldInfoPtr_node);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CampaignNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._EnterNode_d__27.NativeFieldInfoPtr_node), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x0600676D RID: 26477 RVA: 0x0019DD24 File Offset: 0x0019BF24
		// (set) Token: 0x0600676E RID: 26478 RVA: 0x00032E05 File Offset: 0x00031005
		public unsafe bool delay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._EnterNode_d__27.NativeFieldInfoPtr_delay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Campaign._EnterNode_d__27.NativeFieldInfoPtr_delay)) = value;
			}
		}

		// Token: 0x0400437E RID: 17278
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400437F RID: 17279
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04004380 RID: 17280
		private static readonly IntPtr NativeFieldInfoPtr_node;

		// Token: 0x04004381 RID: 17281
		private static readonly IntPtr NativeFieldInfoPtr_delay;

		// Token: 0x04004382 RID: 17282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04004383 RID: 17283
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004384 RID: 17284
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04004385 RID: 17285
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04004386 RID: 17286
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04004387 RID: 17287
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}

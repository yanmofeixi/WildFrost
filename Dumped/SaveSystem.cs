using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

// Token: 0x020001E2 RID: 482
public class SaveSystem : GameSystem
{
	// Token: 0x0600226D RID: 8813 RVA: 0x000BD6B4 File Offset: 0x000BB8B4
	// Note: this type is marked as 'beforefieldinit'.
	static SaveSystem()
	{
		Il2CppClassPointerStore<SaveSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "SaveSystem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr);
		SaveSystem.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "instance");
		SaveSystem.NativeFieldInfoPtr__Profile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "<Profile>k__BackingField");
		SaveSystem.NativeFieldInfoPtr_encode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "encode");
		SaveSystem.NativeFieldInfoPtr_beautify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "beautify");
		SaveSystem.NativeFieldInfoPtr_promptSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "promptSave");
		SaveSystem.NativeFieldInfoPtr_busy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "busy");
		SaveSystem.NativeFieldInfoPtr_profileFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "profileFolder");
		SaveSystem.NativeFieldInfoPtr_folderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "folderName");
		SaveSystem.NativeFieldInfoPtr_progressSaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "progressSaver");
		SaveSystem.NativeFieldInfoPtr_campaignSaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "campaignSaver");
		SaveSystem.NativeFieldInfoPtr_battleSaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "battleSaver");
		SaveSystem.NativeFieldInfoPtr_statsSaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "statsSaver");
		SaveSystem.NativeFieldInfoPtr_historySaver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "historySaver");
		SaveSystem.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "settings");
		SaveSystem.NativeFieldInfoPtr_gotSaveTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "gotSaveTimestamp");
		SaveSystem.NativeFieldInfoPtr_saveTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "saveTimestamp");
		SaveSystem.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669133);
		SaveSystem.NativeMethodInfoPtr_get_Profile_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669134);
		SaveSystem.NativeMethodInfoPtr_set_Profile_Private_Static_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669135);
		SaveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669136);
		SaveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669137);
		SaveSystem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669138);
		SaveSystem.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669139);
		SaveSystem.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669140);
		SaveSystem.NativeMethodInfoPtr_SaveProgressData_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669141);
		SaveSystem.NativeMethodInfoPtr_SaveCampaignData_Public_Static_Void_GameMode_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669142);
		SaveSystem.NativeMethodInfoPtr_SaveStatsData_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669143);
		SaveSystem.NativeMethodInfoPtr_SaveHistoryData_Public_Static_Void_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669144);
		SaveSystem.NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669145);
		SaveSystem.NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669146);
		SaveSystem.NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669147);
		SaveSystem.NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669148);
		SaveSystem.NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669149);
		SaveSystem.NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669150);
		SaveSystem.NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669151);
		SaveSystem.NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669152);
		SaveSystem.NativeMethodInfoPtr_ProgressExists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669153);
		SaveSystem.NativeMethodInfoPtr_CampaignExists_Public_Static_Boolean_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669154);
		SaveSystem.NativeMethodInfoPtr_StatsExists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669155);
		SaveSystem.NativeMethodInfoPtr_HistoryExists_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669156);
		SaveSystem.NativeMethodInfoPtr_ProgressDataExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669157);
		SaveSystem.NativeMethodInfoPtr_CampaignDataExists_Public_Static_Boolean_GameMode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669158);
		SaveSystem.NativeMethodInfoPtr_StatsDataExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669159);
		SaveSystem.NativeMethodInfoPtr_HistoryDataExists_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669160);
		SaveSystem.NativeMethodInfoPtr_DeleteProgress_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669161);
		SaveSystem.NativeMethodInfoPtr_DeleteCampaign_Public_Static_Void_GameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669162);
		SaveSystem.NativeMethodInfoPtr_DeleteProfile_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669163);
		SaveSystem.NativeMethodInfoPtr_DeleteStats_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669164);
		SaveSystem.NativeMethodInfoPtr_DeleteHistory_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669165);
		SaveSystem.NativeMethodInfoPtr_DeleteProgressData_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669166);
		SaveSystem.NativeMethodInfoPtr_GetProfile_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669167);
		SaveSystem.NativeMethodInfoPtr_SetProfile_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669168);
		SaveSystem.NativeMethodInfoPtr_EncryptSaveData_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669169);
		SaveSystem.NativeMethodInfoPtr_ConvertSaveFile_Private_Static_Void_Saver_String_String_ES3Settings_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669170);
		SaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, 100669171);
	}

	// Token: 0x170009EB RID: 2539
	// (get) Token: 0x0600226E RID: 8814 RVA: 0x000BDB30 File Offset: 0x000BBD30
	public unsafe static bool Enabled
	{
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 71263, RefRangeEnd = 71291, XrefRangeStart = 71255, XrefRangeEnd = 71263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170009EC RID: 2540
	// (get) Token: 0x0600226F RID: 8815 RVA: 0x000BDB60 File Offset: 0x000BBD60
	// (set) Token: 0x06002270 RID: 8816 RVA: 0x000BDB8C File Offset: 0x000BBD8C
	public unsafe static string Profile
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71291, XrefRangeEnd = 71295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_get_Profile_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71295, XrefRangeEnd = 71301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_set_Profile_Private_Static_set_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06002271 RID: 8817 RVA: 0x000BDBC4 File Offset: 0x000BBDC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71301, XrefRangeEnd = 71302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002272 RID: 8818 RVA: 0x000BDBF8 File Offset: 0x000BBDF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71302, XrefRangeEnd = 71303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002273 RID: 8819 RVA: 0x000BDC2C File Offset: 0x000BBE2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71303, XrefRangeEnd = 71309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002274 RID: 8820 RVA: 0x000BDC60 File Offset: 0x000BBE60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71309, XrefRangeEnd = 71477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002275 RID: 8821 RVA: 0x000BDC94 File Offset: 0x000BBE94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71477, XrefRangeEnd = 71485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002276 RID: 8822 RVA: 0x000BDCC8 File Offset: 0x000BBEC8
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 71494, RefRangeEnd = 71517, XrefRangeStart = 71485, XrefRangeEnd = 71494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveProgressData<T>(string key, T value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = value;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref value;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_SaveProgressData_Public_Static_Void_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
	}

	// Token: 0x06002277 RID: 8823 RVA: 0x000BDD48 File Offset: 0x000BBF48
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 71524, RefRangeEnd = 71527, XrefRangeStart = 71517, XrefRangeEnd = 71524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveCampaignData<T>(GameMode gameMode, string key, T value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMode);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = value;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref value;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_SaveCampaignData_Public_Static_Void_GameMode_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
	}

	// Token: 0x06002278 RID: 8824 RVA: 0x000BDDD8 File Offset: 0x000BBFD8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 71536, RefRangeEnd = 71538, XrefRangeStart = 71527, XrefRangeEnd = 71536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveStatsData<T>(string key, T value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = value;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref value;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_SaveStatsData_Public_Static_Void_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
	}

	// Token: 0x06002279 RID: 8825 RVA: 0x000BDE58 File Offset: 0x000BC058
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71547, RefRangeEnd = 71548, XrefRangeStart = 71538, XrefRangeEnd = 71547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveHistoryData<T>(string key, T value)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = value;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref value;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_SaveHistoryData_Public_Static_Void_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
	}

	// Token: 0x0600227A RID: 8826 RVA: 0x000BDED8 File Offset: 0x000BC0D8
	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 71551, RefRangeEnd = 71583, XrefRangeStart = 71548, XrefRangeEnd = 71551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T LoadProgressData<T>(string key) where T : class
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadProgressData_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x0600227B RID: 8827 RVA: 0x000BDF18 File Offset: 0x000BC118
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 71594, RefRangeEnd = 71605, XrefRangeStart = 71583, XrefRangeEnd = 71594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T LoadCampaignData<T>(GameMode gameMode, string key) where T : class
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMode);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadCampaignData_Public_Static_T_GameMode_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000BDF68 File Offset: 0x000BC168
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71608, RefRangeEnd = 71609, XrefRangeStart = 71605, XrefRangeEnd = 71608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T LoadStatsData<T>(string key) where T : class
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadStatsData_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x000BDFA8 File Offset: 0x000BC1A8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 71612, RefRangeEnd = 71615, XrefRangeStart = 71609, XrefRangeEnd = 71612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T LoadHistoryData<T>(string key) where T : class
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadHistoryData_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x000BDFE8 File Offset: 0x000BC1E8
	[CallerCount(23)]
	[CachedScanResults(RefRangeStart = 71624, RefRangeEnd = 71647, XrefRangeStart = 71615, XrefRangeEnd = 71624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T LoadProgressData<T>(string key, T defaultValue)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = defaultValue;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref defaultValue;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadProgressData_Public_Static_T_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x000BE070 File Offset: 0x000BC270
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 71655, RefRangeEnd = 71666, XrefRangeStart = 71647, XrefRangeEnd = 71655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T LoadCampaignData<T>(GameMode gameMode, string key, T defaultValue)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMode);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = defaultValue;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref defaultValue;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadCampaignData_Public_Static_T_GameMode_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	// Token: 0x06002280 RID: 8832 RVA: 0x000BE108 File Offset: 0x000BC308
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71666, XrefRangeEnd = 71675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T LoadStatsData<T>(string key, T defaultValue)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = defaultValue;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref defaultValue;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadStatsData_Public_Static_T_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	// Token: 0x06002281 RID: 8833 RVA: 0x000BE190 File Offset: 0x000BC390
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71675, XrefRangeEnd = 71684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static T LoadHistoryData<T>(string key, T defaultValue)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr;
		if (!typeof(T).IsValueType)
		{
			T t = defaultValue;
			intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref defaultValue;
		}
		ptr2 = intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.MethodInfoStoreGeneric_LoadHistoryData_Public_Static_T_String_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	// Token: 0x06002282 RID: 8834 RVA: 0x000BE218 File Offset: 0x000BC418
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 71689, RefRangeEnd = 71691, XrefRangeStart = 71684, XrefRangeEnd = 71689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ProgressExists()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_ProgressExists_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002283 RID: 8835 RVA: 0x000BE248 File Offset: 0x000BC448
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 71695, RefRangeEnd = 71699, XrefRangeStart = 71691, XrefRangeEnd = 71695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CampaignExists(GameMode gameMode)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_CampaignExists_Public_Static_Boolean_GameMode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002284 RID: 8836 RVA: 0x000BE28C File Offset: 0x000BC48C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71704, RefRangeEnd = 71705, XrefRangeStart = 71699, XrefRangeEnd = 71704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StatsExists()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_StatsExists_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002285 RID: 8837 RVA: 0x000BE2BC File Offset: 0x000BC4BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71705, XrefRangeEnd = 71710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HistoryExists()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_HistoryExists_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002286 RID: 8838 RVA: 0x000BE2EC File Offset: 0x000BC4EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71710, XrefRangeEnd = 71715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool ProgressDataExists(string key)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_ProgressDataExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002287 RID: 8839 RVA: 0x000BE330 File Offset: 0x000BC530
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 71719, RefRangeEnd = 71722, XrefRangeStart = 71715, XrefRangeEnd = 71719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CampaignDataExists(GameMode gameMode, string key)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMode);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_CampaignDataExists_Public_Static_Boolean_GameMode_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002288 RID: 8840 RVA: 0x000BE384 File Offset: 0x000BC584
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71727, RefRangeEnd = 71728, XrefRangeStart = 71722, XrefRangeEnd = 71727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StatsDataExists(string key)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_StatsDataExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06002289 RID: 8841 RVA: 0x000BE3C8 File Offset: 0x000BC5C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71728, XrefRangeEnd = 71733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool HistoryDataExists(string key)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_HistoryDataExists_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600228A RID: 8842 RVA: 0x000BE40C File Offset: 0x000BC60C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 71743, RefRangeEnd = 71746, XrefRangeStart = 71733, XrefRangeEnd = 71743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteProgress()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteProgress_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600228B RID: 8843 RVA: 0x000BE434 File Offset: 0x000BC634
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 71754, RefRangeEnd = 71760, XrefRangeStart = 71746, XrefRangeEnd = 71754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteCampaign(GameMode gameMode)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameMode);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteCampaign_Public_Static_Void_GameMode_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600228C RID: 8844 RVA: 0x000BE46C File Offset: 0x000BC66C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71768, RefRangeEnd = 71769, XrefRangeStart = 71760, XrefRangeEnd = 71768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteProfile(string profileName)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(profileName);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteProfile_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600228D RID: 8845 RVA: 0x000BE4A4 File Offset: 0x000BC6A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71769, XrefRangeEnd = 71779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteStats()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteStats_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600228E RID: 8846 RVA: 0x000BE4CC File Offset: 0x000BC6CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71779, XrefRangeEnd = 71789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteHistory()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteHistory_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600228F RID: 8847 RVA: 0x000BE4F4 File Offset: 0x000BC6F4
	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 71803, RefRangeEnd = 71820, XrefRangeStart = 71789, XrefRangeEnd = 71803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DeleteProgressData(string key)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_DeleteProgressData_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002290 RID: 8848 RVA: 0x000BE52C File Offset: 0x000BC72C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 71834, RefRangeEnd = 71835, XrefRangeStart = 71820, XrefRangeEnd = 71834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetProfile()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_GetProfile_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06002291 RID: 8849 RVA: 0x000BE558 File Offset: 0x000BC758
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 71877, RefRangeEnd = 71879, XrefRangeStart = 71835, XrefRangeEnd = 71877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetProfile(string name, bool save = true)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref save;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_SetProfile_Public_Static_Void_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002292 RID: 8850 RVA: 0x000BE59C File Offset: 0x000BC79C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71879, XrefRangeEnd = 71900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EncryptSaveData()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_EncryptSaveData_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002293 RID: 8851 RVA: 0x000BE5C4 File Offset: 0x000BC7C4
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 71954, RefRangeEnd = 71962, XrefRangeStart = 71900, XrefRangeEnd = 71954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConvertSaveFile(SaveSystem.Saver saver, string folder, string fileName, ES3Settings oldSettings, ES3Settings newSettings)
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(saver);
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(folder);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldSettings);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newSettings);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr_ConvertSaveFile_Private_Static_Void_Saver_String_String_ES3Settings_ES3Settings_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002294 RID: 8852 RVA: 0x000BE644 File Offset: 0x000BC844
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 21506, RefRangeEnd = 21513, XrefRangeStart = 21506, XrefRangeEnd = 21513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SaveSystem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06002295 RID: 8853 RVA: 0x0001378E File Offset: 0x0001198E
	public SaveSystem(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x170009DB RID: 2523
	// (get) Token: 0x06002296 RID: 8854 RVA: 0x000BE680 File Offset: 0x000BC880
	// (set) Token: 0x06002297 RID: 8855 RVA: 0x00013797 File Offset: 0x00011997
	public unsafe static SaveSystem instance
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_instance, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveSystem>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009DC RID: 2524
	// (get) Token: 0x06002298 RID: 8856 RVA: 0x000BE6A8 File Offset: 0x000BC8A8
	// (set) Token: 0x06002299 RID: 8857 RVA: 0x000137A9 File Offset: 0x000119A9
	public unsafe static string _Profile_k__BackingField
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr__Profile_k__BackingField, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr__Profile_k__BackingField, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170009DD RID: 2525
	// (get) Token: 0x0600229A RID: 8858 RVA: 0x000BE6C8 File Offset: 0x000BC8C8
	// (set) Token: 0x0600229B RID: 8859 RVA: 0x000137BB File Offset: 0x000119BB
	public unsafe bool encode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_encode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_encode)) = value;
		}
	}

	// Token: 0x170009DE RID: 2526
	// (get) Token: 0x0600229C RID: 8860 RVA: 0x000BE6F0 File Offset: 0x000BC8F0
	// (set) Token: 0x0600229D RID: 8861 RVA: 0x000137D6 File Offset: 0x000119D6
	public unsafe bool beautify
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_beautify);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_beautify)) = value;
		}
	}

	// Token: 0x170009DF RID: 2527
	// (get) Token: 0x0600229E RID: 8862 RVA: 0x000BE718 File Offset: 0x000BC918
	// (set) Token: 0x0600229F RID: 8863 RVA: 0x000137F1 File Offset: 0x000119F1
	public unsafe bool promptSave
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_promptSave);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_promptSave)) = value;
		}
	}

	// Token: 0x170009E0 RID: 2528
	// (get) Token: 0x060022A0 RID: 8864 RVA: 0x000BE740 File Offset: 0x000BC940
	// (set) Token: 0x060022A1 RID: 8865 RVA: 0x0001380C File Offset: 0x00011A0C
	public unsafe bool busy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_busy);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.NativeFieldInfoPtr_busy)) = value;
		}
	}

	// Token: 0x170009E1 RID: 2529
	// (get) Token: 0x060022A2 RID: 8866 RVA: 0x000BE768 File Offset: 0x000BC968
	// (set) Token: 0x060022A3 RID: 8867 RVA: 0x00013827 File Offset: 0x00011A27
	public unsafe static string profileFolder
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_profileFolder, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_profileFolder, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170009E2 RID: 2530
	// (get) Token: 0x060022A4 RID: 8868 RVA: 0x000BE788 File Offset: 0x000BC988
	// (set) Token: 0x060022A5 RID: 8869 RVA: 0x00013839 File Offset: 0x00011A39
	public unsafe static string folderName
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_folderName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_folderName, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170009E3 RID: 2531
	// (get) Token: 0x060022A6 RID: 8870 RVA: 0x000BE7A8 File Offset: 0x000BC9A8
	// (set) Token: 0x060022A7 RID: 8871 RVA: 0x0001384B File Offset: 0x00011A4B
	public unsafe static SaveSystem.Saver progressSaver
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_progressSaver, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveSystem.Saver>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_progressSaver, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009E4 RID: 2532
	// (get) Token: 0x060022A8 RID: 8872 RVA: 0x000BE7D0 File Offset: 0x000BC9D0
	// (set) Token: 0x060022A9 RID: 8873 RVA: 0x0001385D File Offset: 0x00011A5D
	public unsafe static SaveSystem.Saver campaignSaver
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_campaignSaver, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveSystem.Saver>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_campaignSaver, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009E5 RID: 2533
	// (get) Token: 0x060022AA RID: 8874 RVA: 0x000BE7F8 File Offset: 0x000BC9F8
	// (set) Token: 0x060022AB RID: 8875 RVA: 0x0001386F File Offset: 0x00011A6F
	public unsafe static SaveSystem.Saver battleSaver
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_battleSaver, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveSystem.Saver>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_battleSaver, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009E6 RID: 2534
	// (get) Token: 0x060022AC RID: 8876 RVA: 0x000BE820 File Offset: 0x000BCA20
	// (set) Token: 0x060022AD RID: 8877 RVA: 0x00013881 File Offset: 0x00011A81
	public unsafe static SaveSystem.Saver statsSaver
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_statsSaver, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveSystem.Saver>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_statsSaver, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009E7 RID: 2535
	// (get) Token: 0x060022AE RID: 8878 RVA: 0x000BE848 File Offset: 0x000BCA48
	// (set) Token: 0x060022AF RID: 8879 RVA: 0x00013893 File Offset: 0x00011A93
	public unsafe static SaveSystem.Saver historySaver
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_historySaver, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveSystem.Saver>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_historySaver, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009E8 RID: 2536
	// (get) Token: 0x060022B0 RID: 8880 RVA: 0x000BE870 File Offset: 0x000BCA70
	// (set) Token: 0x060022B1 RID: 8881 RVA: 0x000138A5 File Offset: 0x00011AA5
	public unsafe static ES3Settings settings
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_settings, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ES3Settings>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_settings, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170009E9 RID: 2537
	// (get) Token: 0x060022B2 RID: 8882 RVA: 0x000BE898 File Offset: 0x000BCA98
	// (set) Token: 0x060022B3 RID: 8883 RVA: 0x000138B7 File Offset: 0x00011AB7
	public unsafe static bool gotSaveTimestamp
	{
		get
		{
			bool result;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_gotSaveTimestamp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_gotSaveTimestamp, (void*)(&value));
		}
	}

	// Token: 0x170009EA RID: 2538
	// (get) Token: 0x060022B4 RID: 8884 RVA: 0x000BE8B4 File Offset: 0x000BCAB4
	// (set) Token: 0x060022B5 RID: 8885 RVA: 0x000138C5 File Offset: 0x00011AC5
	public unsafe static DateTime saveTimestamp
	{
		get
		{
			DateTime result;
			IL2CPP.il2cpp_field_static_get_value(SaveSystem.NativeFieldInfoPtr_saveTimestamp, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SaveSystem.NativeFieldInfoPtr_saveTimestamp, (void*)(&value));
		}
	}

	// Token: 0x0400159C RID: 5532
	private static readonly IntPtr NativeFieldInfoPtr_instance;

	// Token: 0x0400159D RID: 5533
	private static readonly IntPtr NativeFieldInfoPtr__Profile_k__BackingField;

	// Token: 0x0400159E RID: 5534
	private static readonly IntPtr NativeFieldInfoPtr_encode;

	// Token: 0x0400159F RID: 5535
	private static readonly IntPtr NativeFieldInfoPtr_beautify;

	// Token: 0x040015A0 RID: 5536
	private static readonly IntPtr NativeFieldInfoPtr_promptSave;

	// Token: 0x040015A1 RID: 5537
	private static readonly IntPtr NativeFieldInfoPtr_busy;

	// Token: 0x040015A2 RID: 5538
	private static readonly IntPtr NativeFieldInfoPtr_profileFolder;

	// Token: 0x040015A3 RID: 5539
	private static readonly IntPtr NativeFieldInfoPtr_folderName;

	// Token: 0x040015A4 RID: 5540
	private static readonly IntPtr NativeFieldInfoPtr_progressSaver;

	// Token: 0x040015A5 RID: 5541
	private static readonly IntPtr NativeFieldInfoPtr_campaignSaver;

	// Token: 0x040015A6 RID: 5542
	private static readonly IntPtr NativeFieldInfoPtr_battleSaver;

	// Token: 0x040015A7 RID: 5543
	private static readonly IntPtr NativeFieldInfoPtr_statsSaver;

	// Token: 0x040015A8 RID: 5544
	private static readonly IntPtr NativeFieldInfoPtr_historySaver;

	// Token: 0x040015A9 RID: 5545
	private static readonly IntPtr NativeFieldInfoPtr_settings;

	// Token: 0x040015AA RID: 5546
	private static readonly IntPtr NativeFieldInfoPtr_gotSaveTimestamp;

	// Token: 0x040015AB RID: 5547
	private static readonly IntPtr NativeFieldInfoPtr_saveTimestamp;

	// Token: 0x040015AC RID: 5548
	private static readonly IntPtr NativeMethodInfoPtr_get_Enabled_Public_Static_get_Boolean_0;

	// Token: 0x040015AD RID: 5549
	private static readonly IntPtr NativeMethodInfoPtr_get_Profile_Public_Static_get_String_0;

	// Token: 0x040015AE RID: 5550
	private static readonly IntPtr NativeMethodInfoPtr_set_Profile_Private_Static_set_Void_String_0;

	// Token: 0x040015AF RID: 5551
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x040015B0 RID: 5552
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x040015B1 RID: 5553
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040015B2 RID: 5554
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040015B3 RID: 5555
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x040015B4 RID: 5556
	private static readonly IntPtr NativeMethodInfoPtr_SaveProgressData_Public_Static_Void_String_T_0;

	// Token: 0x040015B5 RID: 5557
	private static readonly IntPtr NativeMethodInfoPtr_SaveCampaignData_Public_Static_Void_GameMode_String_T_0;

	// Token: 0x040015B6 RID: 5558
	private static readonly IntPtr NativeMethodInfoPtr_SaveStatsData_Public_Static_Void_String_T_0;

	// Token: 0x040015B7 RID: 5559
	private static readonly IntPtr NativeMethodInfoPtr_SaveHistoryData_Public_Static_Void_String_T_0;

	// Token: 0x040015B8 RID: 5560
	private static readonly IntPtr NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_0;

	// Token: 0x040015B9 RID: 5561
	private static readonly IntPtr NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_0;

	// Token: 0x040015BA RID: 5562
	private static readonly IntPtr NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_0;

	// Token: 0x040015BB RID: 5563
	private static readonly IntPtr NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_0;

	// Token: 0x040015BC RID: 5564
	private static readonly IntPtr NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_T_0;

	// Token: 0x040015BD RID: 5565
	private static readonly IntPtr NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_T_0;

	// Token: 0x040015BE RID: 5566
	private static readonly IntPtr NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_T_0;

	// Token: 0x040015BF RID: 5567
	private static readonly IntPtr NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_T_0;

	// Token: 0x040015C0 RID: 5568
	private static readonly IntPtr NativeMethodInfoPtr_ProgressExists_Public_Static_Boolean_0;

	// Token: 0x040015C1 RID: 5569
	private static readonly IntPtr NativeMethodInfoPtr_CampaignExists_Public_Static_Boolean_GameMode_0;

	// Token: 0x040015C2 RID: 5570
	private static readonly IntPtr NativeMethodInfoPtr_StatsExists_Public_Static_Boolean_0;

	// Token: 0x040015C3 RID: 5571
	private static readonly IntPtr NativeMethodInfoPtr_HistoryExists_Public_Static_Boolean_0;

	// Token: 0x040015C4 RID: 5572
	private static readonly IntPtr NativeMethodInfoPtr_ProgressDataExists_Public_Static_Boolean_String_0;

	// Token: 0x040015C5 RID: 5573
	private static readonly IntPtr NativeMethodInfoPtr_CampaignDataExists_Public_Static_Boolean_GameMode_String_0;

	// Token: 0x040015C6 RID: 5574
	private static readonly IntPtr NativeMethodInfoPtr_StatsDataExists_Public_Static_Boolean_String_0;

	// Token: 0x040015C7 RID: 5575
	private static readonly IntPtr NativeMethodInfoPtr_HistoryDataExists_Public_Static_Boolean_String_0;

	// Token: 0x040015C8 RID: 5576
	private static readonly IntPtr NativeMethodInfoPtr_DeleteProgress_Public_Static_Void_0;

	// Token: 0x040015C9 RID: 5577
	private static readonly IntPtr NativeMethodInfoPtr_DeleteCampaign_Public_Static_Void_GameMode_0;

	// Token: 0x040015CA RID: 5578
	private static readonly IntPtr NativeMethodInfoPtr_DeleteProfile_Public_Static_Void_String_0;

	// Token: 0x040015CB RID: 5579
	private static readonly IntPtr NativeMethodInfoPtr_DeleteStats_Public_Static_Void_0;

	// Token: 0x040015CC RID: 5580
	private static readonly IntPtr NativeMethodInfoPtr_DeleteHistory_Public_Static_Void_0;

	// Token: 0x040015CD RID: 5581
	private static readonly IntPtr NativeMethodInfoPtr_DeleteProgressData_Public_Static_Void_String_0;

	// Token: 0x040015CE RID: 5582
	private static readonly IntPtr NativeMethodInfoPtr_GetProfile_Public_Static_String_0;

	// Token: 0x040015CF RID: 5583
	private static readonly IntPtr NativeMethodInfoPtr_SetProfile_Public_Static_Void_String_Boolean_0;

	// Token: 0x040015D0 RID: 5584
	private static readonly IntPtr NativeMethodInfoPtr_EncryptSaveData_Private_Static_Void_0;

	// Token: 0x040015D1 RID: 5585
	private static readonly IntPtr NativeMethodInfoPtr_ConvertSaveFile_Private_Static_Void_Saver_String_String_ES3Settings_ES3Settings_0;

	// Token: 0x040015D2 RID: 5586
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020006F2 RID: 1778
	public class Saver : Object
	{
		// Token: 0x060077FE RID: 30718 RVA: 0x001D0694 File Offset: 0x001CE894
		// Note: this type is marked as 'beforefieldinit'.
		static Saver()
		{
			Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveSystem>.NativeClassPtr, "Saver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr);
			SaveSystem.Saver.NativeFieldInfoPtr_baseFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, "baseFileName");
			SaveSystem.Saver.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, "settings");
			SaveSystem.Saver.NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669173);
			SaveSystem.Saver.NativeMethodInfoPtr_SaveValue_Public_Void_String_TValue_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669174);
			SaveSystem.Saver.NativeMethodInfoPtr_LoadValue_Public_TValue_String_String_TValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669175);
			SaveSystem.Saver.NativeMethodInfoPtr_FileExists_Public_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669176);
			SaveSystem.Saver.NativeMethodInfoPtr_KeyExists_Public_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669177);
			SaveSystem.Saver.NativeMethodInfoPtr_Delete_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669178);
			SaveSystem.Saver.NativeMethodInfoPtr_DeleteKey_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669179);
			SaveSystem.Saver.NativeMethodInfoPtr_CheckBackup_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr, 100669180);
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x001D0788 File Offset: 0x001CE988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71064, XrefRangeEnd = 71071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Saver(string baseFileName, ES3Settings settings = null) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseFileName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x001D07E8 File Offset: 0x001CE9E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71071, XrefRangeEnd = 71117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveValue<TValue>(string key, TValue value, string folderName, string fileName = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(folderName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.MethodInfoStoreGeneric_SaveValue_Public_Void_String_TValue_String_String_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x001D0898 File Offset: 0x001CEA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71117, XrefRangeEnd = 71172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TValue LoadValue<TValue>(string key, string folderName, TValue defaultValue, string fileName = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(folderName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = defaultValue;
				intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.MethodInfoStoreGeneric_LoadValue_Public_TValue_String_String_TValue_String_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TValue>(intPtr2, false, true);
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x001D0950 File Offset: 0x001CEB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71172, XrefRangeEnd = 71177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool FileExists(string folderName, string fileName = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_FileExists_Public_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x001D09B0 File Offset: 0x001CEBB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 71196, RefRangeEnd = 71197, XrefRangeStart = 71177, XrefRangeEnd = 71196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool KeyExists(string key, string folderName, string fileName = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(folderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_KeyExists_Public_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x001D0A24 File Offset: 0x001CEC24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 71202, RefRangeEnd = 71206, XrefRangeStart = 71197, XrefRangeEnd = 71202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete(string folderName, string fileName = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_Delete_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x001D0A78 File Offset: 0x001CEC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71206, XrefRangeEnd = 71211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteKey(string key, string folderName, string fileName = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(folderName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_DeleteKey_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x001D0AE0 File Offset: 0x001CECE0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 71248, RefRangeEnd = 71255, XrefRangeStart = 71211, XrefRangeEnd = 71248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckBackup(string folderName, string fileName = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(folderName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveSystem.Saver.NativeMethodInfoPtr_CheckBackup_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x0003AD29 File Offset: 0x00038F29
		public Saver(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700251D RID: 9501
		// (get) Token: 0x06007808 RID: 30728 RVA: 0x001D0B34 File Offset: 0x001CED34
		// (set) Token: 0x06007809 RID: 30729 RVA: 0x0003AD32 File Offset: 0x00038F32
		public unsafe string baseFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.Saver.NativeFieldInfoPtr_baseFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.Saver.NativeFieldInfoPtr_baseFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700251E RID: 9502
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x001D0B5C File Offset: 0x001CED5C
		// (set) Token: 0x0600780B RID: 30731 RVA: 0x0003AD51 File Offset: 0x00038F51
		public unsafe ES3Settings settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.Saver.NativeFieldInfoPtr_settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ES3Settings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveSystem.Saver.NativeFieldInfoPtr_settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D7A RID: 19834
		private static readonly IntPtr NativeFieldInfoPtr_baseFileName;

		// Token: 0x04004D7B RID: 19835
		private static readonly IntPtr NativeFieldInfoPtr_settings;

		// Token: 0x04004D7C RID: 19836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ES3Settings_0;

		// Token: 0x04004D7D RID: 19837
		private static readonly IntPtr NativeMethodInfoPtr_SaveValue_Public_Void_String_TValue_String_String_0;

		// Token: 0x04004D7E RID: 19838
		private static readonly IntPtr NativeMethodInfoPtr_LoadValue_Public_TValue_String_String_TValue_String_0;

		// Token: 0x04004D7F RID: 19839
		private static readonly IntPtr NativeMethodInfoPtr_FileExists_Public_Boolean_String_String_0;

		// Token: 0x04004D80 RID: 19840
		private static readonly IntPtr NativeMethodInfoPtr_KeyExists_Public_Boolean_String_String_String_0;

		// Token: 0x04004D81 RID: 19841
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_String_String_0;

		// Token: 0x04004D82 RID: 19842
		private static readonly IntPtr NativeMethodInfoPtr_DeleteKey_Public_Void_String_String_String_0;

		// Token: 0x04004D83 RID: 19843
		private static readonly IntPtr NativeMethodInfoPtr_CheckBackup_Public_Void_String_String_0;

		// Token: 0x02000A95 RID: 2709
		private sealed class MethodInfoStoreGeneric_SaveValue_Public_Void_String_TValue_String_String_0<TValue>
		{
			// Token: 0x0400696D RID: 26989
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.Saver.NativeMethodInfoPtr_SaveValue_Public_Void_String_TValue_String_String_0, Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A96 RID: 2710
		private sealed class MethodInfoStoreGeneric_LoadValue_Public_TValue_String_String_TValue_String_0<TValue>
		{
			// Token: 0x0400696E RID: 26990
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.Saver.NativeMethodInfoPtr_LoadValue_Public_TValue_String_String_TValue_String_0, Il2CppClassPointerStore<SaveSystem.Saver>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}

	// Token: 0x020006F3 RID: 1779
	private sealed class MethodInfoStoreGeneric_SaveProgressData_Public_Static_Void_String_T_0<T>
	{
		// Token: 0x04004D84 RID: 19844
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_SaveProgressData_Public_Static_Void_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006F4 RID: 1780
	private sealed class MethodInfoStoreGeneric_SaveCampaignData_Public_Static_Void_GameMode_String_T_0<T>
	{
		// Token: 0x04004D85 RID: 19845
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_SaveCampaignData_Public_Static_Void_GameMode_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006F5 RID: 1781
	private sealed class MethodInfoStoreGeneric_SaveStatsData_Public_Static_Void_String_T_0<T>
	{
		// Token: 0x04004D86 RID: 19846
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_SaveStatsData_Public_Static_Void_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006F6 RID: 1782
	private sealed class MethodInfoStoreGeneric_SaveHistoryData_Public_Static_Void_String_T_0<T>
	{
		// Token: 0x04004D87 RID: 19847
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_SaveHistoryData_Public_Static_Void_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006F7 RID: 1783
	private sealed class MethodInfoStoreGeneric_LoadProgressData_Public_Static_T_String_0<T>
	{
		// Token: 0x04004D88 RID: 19848
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006F8 RID: 1784
	private sealed class MethodInfoStoreGeneric_LoadCampaignData_Public_Static_T_GameMode_String_0<T>
	{
		// Token: 0x04004D89 RID: 19849
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006F9 RID: 1785
	private sealed class MethodInfoStoreGeneric_LoadStatsData_Public_Static_T_String_0<T>
	{
		// Token: 0x04004D8A RID: 19850
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006FA RID: 1786
	private sealed class MethodInfoStoreGeneric_LoadHistoryData_Public_Static_T_String_0<T>
	{
		// Token: 0x04004D8B RID: 19851
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006FB RID: 1787
	private sealed class MethodInfoStoreGeneric_LoadProgressData_Public_Static_T_String_T_0<T>
	{
		// Token: 0x04004D8C RID: 19852
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadProgressData_Public_Static_T_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006FC RID: 1788
	private sealed class MethodInfoStoreGeneric_LoadCampaignData_Public_Static_T_GameMode_String_T_0<T>
	{
		// Token: 0x04004D8D RID: 19853
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadCampaignData_Public_Static_T_GameMode_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006FD RID: 1789
	private sealed class MethodInfoStoreGeneric_LoadStatsData_Public_Static_T_String_T_0<T>
	{
		// Token: 0x04004D8E RID: 19854
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadStatsData_Public_Static_T_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}

	// Token: 0x020006FE RID: 1790
	private sealed class MethodInfoStoreGeneric_LoadHistoryData_Public_Static_T_String_T_0<T>
	{
		// Token: 0x04004D8F RID: 19855
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SaveSystem.NativeMethodInfoPtr_LoadHistoryData_Public_Static_T_String_T_0, Il2CppClassPointerStore<SaveSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
		}))));
	}
}

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <stdint.h>

#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"


// System.Void
struct Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017;

struct EVENT_FILTER_DESCRIPTOR_t24FD3DB96806FFE8C96FFDB38B1B8331EA0D72BB ;
struct Guid_t ;


IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.ValueType
struct  ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t4D0C27076F7C36E76190FB3328E232BCB1CD1FFF_marshaled_com
{
};

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};


// System.Void
struct  Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t22962CB4C05B1D89B55A6E1139F0E87A90987017__padding[1];
	};

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif

extern "C" void DEFAULT_CALL ReversePInvokeWrapper_EventProvider_EtwEnableCallBack_m32987ABF4E909DC5476F09C034714951CB4A8048(Guid_t * ___sourceId0, int32_t ___controlCode1, uint8_t ___setLevel2, int64_t ___anyKeyword3, int64_t ___allKeyword4, EVENT_FILTER_DESCRIPTOR_t24FD3DB96806FFE8C96FFDB38B1B8331EA0D72BB * ___filterData5, void* ___callbackContext6);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_m056BCE43FF155AAE872FF7E565F8F72A50D26147(intptr_t ___arg0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_AppleStoreImpl_MessageCallback_m03941E0038DEE1E35B1EF9FCCE9F8CED13FD330F(char* ___subject0, char* ___payload1, char* ___receipt2, char* ___transactionId3);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_FacebookStoreImpl_MessageCallback_mF57250297EC7438A836AF55830B98161D6D6B8EA(char* ___subject0, char* ___payload1, char* ___receipt2, char* ___transactionId3);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidShow_mFC4C90084ECAF433BA5490DBF84A30FD585AFC61(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidHide_mECF110B7068EACEB8DBDE775E84B0FC51E0CD740(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerClick_mF26B4B008063FB7EFB101D511ED1DC16404AE9D0(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidError_m257EC80C14CABF935DA430E68EEE90420F9B9E16(char* ___message0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidUnload_m3FC190B1488006104F0C4F611EB22F3002065BD4(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidLoad_mAF2F81438ACD578DC71BAE3C33835CE4E41EA0EC(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosPlatform_UnityAdsReady_m8CDE1ED129C57BA3EAC05B35E5F38C0F94FEC477(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosPlatform_UnityAdsDidError_mA3A727D852680AAAF152EC2DFABFF03A8DC66833(int64_t ___rawError0, char* ___message1);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosPlatform_UnityAdsDidStart_m14656A449C0022657041F4651594340AD8E8CACA(char* ___placementId0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_IosPlatform_UnityAdsDidFinish_m167C97C7564D57B6430CBFA8B475D933538D77BE(char* ___placementId0, int64_t ___rawShowResult1);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PurchasingPlatform_UnityAdsDidInitiatePurchasingCommand_m6FA57B1916F51606FF489FF0FD1AC38DE06778B6(char* ___eventString0);
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingGetProductCatalog_m5DFF17D5C03AD0679C1C7B9748B6C94AAAE84852();
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingGetPurchasingVersion_mFA117E5B8B0A8CF8AECE17CAF618C45EEC0B7097();
extern "C" void DEFAULT_CALL ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingInitialize_mEC9D4F47F2FF226B501BFB535BE1F7FA0A0530D2();


extern const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[];
const Il2CppMethodPointer g_ReversePInvokeWrapperPointers[18] = 
{
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_EventProvider_EtwEnableCallBack_m32987ABF4E909DC5476F09C034714951CB4A8048),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_OSSpecificSynchronizationContext_InvocationEntry_m056BCE43FF155AAE872FF7E565F8F72A50D26147),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_AppleStoreImpl_MessageCallback_m03941E0038DEE1E35B1EF9FCCE9F8CED13FD330F),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_FacebookStoreImpl_MessageCallback_mF57250297EC7438A836AF55830B98161D6D6B8EA),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidShow_mFC4C90084ECAF433BA5490DBF84A30FD585AFC61),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidHide_mECF110B7068EACEB8DBDE775E84B0FC51E0CD740),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerClick_mF26B4B008063FB7EFB101D511ED1DC16404AE9D0),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidError_m257EC80C14CABF935DA430E68EEE90420F9B9E16),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidUnload_m3FC190B1488006104F0C4F611EB22F3002065BD4),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosBanner_UnityAdsBannerDidLoad_mAF2F81438ACD578DC71BAE3C33835CE4E41EA0EC),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosPlatform_UnityAdsReady_m8CDE1ED129C57BA3EAC05B35E5F38C0F94FEC477),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosPlatform_UnityAdsDidError_mA3A727D852680AAAF152EC2DFABFF03A8DC66833),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosPlatform_UnityAdsDidStart_m14656A449C0022657041F4651594340AD8E8CACA),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_IosPlatform_UnityAdsDidFinish_m167C97C7564D57B6430CBFA8B475D933538D77BE),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_PurchasingPlatform_UnityAdsDidInitiatePurchasingCommand_m6FA57B1916F51606FF489FF0FD1AC38DE06778B6),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingGetProductCatalog_m5DFF17D5C03AD0679C1C7B9748B6C94AAAE84852),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingGetPurchasingVersion_mFA117E5B8B0A8CF8AECE17CAF618C45EEC0B7097),
	reinterpret_cast<Il2CppMethodPointer>(ReversePInvokeWrapper_PurchasingPlatform_UnityAdsPurchasingInitialize_mEC9D4F47F2FF226B501BFB535BE1F7FA0A0530D2),
};

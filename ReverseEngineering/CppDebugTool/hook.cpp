// hook.cpp : Implementation of DLL Exports.


// Note: Proxy/Stub Information
//      To build a separate proxy/stub DLL, 
//      run nmake -f hookps.mk in the project directory.

#include "stdafx.h"
#include "resource.h"
#include <initguid.h>

#include "hook_i.c"
#include "HookScript.h"

CComModule _Module;

BEGIN_OBJECT_MAP(ObjectMap)
END_OBJECT_MAP()
/////////////////////////////////////////////////////////////////////////////
// DLL Entry Point
extern "C"
BOOL WINAPI DllMain(HINSTANCE hInstance, DWORD dwReason, LPVOID /*lpReserved*/)
{
#ifdef _DEBUG
	int tmpDbgFlag = _CrtSetDbgFlag(_CRTDBG_REPORT_FLAG);
	tmpDbgFlag |= _CRTDBG_DELAY_FREE_MEM_DF;
    tmpDbgFlag |= _CRTDBG_LEAK_CHECK_DF;
    _CrtSetDbgFlag(tmpDbgFlag);
#endif
    if (dwReason == DLL_PROCESS_ATTACH)
    {		
        _Module.Init(ObjectMap, hInstance, &LIBID_HOOKLib);
        DisableThreadLibraryCalls(hInstance);	
		::CoUninitialize();
		::OleUninitialize();
		::OleInitialize(NULL);
    }
    else if (dwReason == DLL_PROCESS_DETACH)
	{
		::_Finalize();
		::OleUninitialize();
		_Module.Term();
	}
	else if (dwReason == DLL_THREAD_ATTACH)
	{
		::CoUninitialize();
		::OleUninitialize();
		::OleInitialize(NULL);
		::_ThreadInit();
	}
	else if (dwReason == DLL_THREAD_DETACH)
	{
		::_ThreadFinalize();
		::OleUninitialize();
	}
    return TRUE;    // ok
}

/////////////////////////////////////////////////////////////////////////////
// Used to determine whether the DLL can be unloaded by OLE

STDAPI DllCanUnloadNow(void)
{
    return (_Module.GetLockCount()==0) ? S_OK : S_FALSE;
}

/////////////////////////////////////////////////////////////////////////////
// Returns a class factory to create an object of the requested type

STDAPI DllGetClassObject(REFCLSID rclsid, REFIID riid, LPVOID* ppv)
{
    return _Module.GetClassObject(rclsid, riid, ppv);
}

/////////////////////////////////////////////////////////////////////////////
// DllRegisterServer - Adds entries to the system registry

STDAPI DllRegisterServer(void)
{
    // registers object, typelib and all interfaces in typelib
    return _Module.RegisterServer(TRUE);
}

/////////////////////////////////////////////////////////////////////////////
// DllUnregisterServer - Removes entries from the system registry

STDAPI DllUnregisterServer(void)
{
    return _Module.UnregisterServer(TRUE);
}

extern "C" __declspec(dllexport) void Init(void)
{	
	::_Init();
}
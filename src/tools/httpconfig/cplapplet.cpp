//---------------------------------------------------------------------------
// cplapplet.cpp
//
// Zucchini HttpConfig Control Panel Applet
//
// The use and distribution terms for this software are covered by the
// Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file CPL.TXT at the root of this distribution.
// By using this software in any fashion, you are agreeing to be bound by
// the terms of this license. You must not remove this notice, or any other,
// from this software.
//
// Contributor(s):
//	Michael G. Brehm (original author)
//---------------------------------------------------------------------------

#include "stdafx.h"					// Include project pre-compiled headers
#include "resource.h"				// Include project resource declarations

using namespace System;
using namespace System::Reflection;
using namespace System::Runtime::InteropServices;
using namespace System::Windows::Forms;
using namespace zucchini::tools::httpconfig::applet;

#pragma warning(push, 4)			// Enable maximum compiler warnings
#pragma warning(disable:4100)		// "unreferenced formal parameter"

//---------------------------------------------------------------------------
// Function Prototypes
//---------------------------------------------------------------------------

Assembly^ OnAssemblyResolve(Object^, ResolveEventArgs^);

LONG OnDoubleClick(UINT);				// CPL_DBLCLK Handler
LONG OnExit(void);						// CPL_EXIT Handler
LONG OnGetCount(void);					// CPL_GETCOUNT Handler
LONG OnInit(void);						// CPL_INIT Handler
LONG OnInquire(UINT, CPLINFO*);			// CPL_INQUIRE Handler

//---------------------------------------------------------------------------
// Global Variables
//---------------------------------------------------------------------------

HMODULE						g_hModule = NULL;	// Global DLL module handle
gcroot<HttpConfigApplet^>	g_applet;			// Global applet GCHandle

//---------------------------------------------------------------------------
// DllMain
//
// Main library entry point
//
// Arguments :
//
//	hModule			- DLL module handle (base address)
//	dwReason		- Reason that DllMain is being called
//	pvReserved		- Load context - reserved under Win32

#pragma managed(push, off)
BOOL WINAPI DllMain(HMODULE hModule, DWORD dwReason, void *pvReserved)
{
	// The only thing we really need to do in here is grab a copy of
	// the DLL base address so we can find out information about it

	if(dwReason == DLL_PROCESS_ATTACH) { g_hModule = hModule; }
	return TRUE;
}
#pragma managed(pop)

//---------------------------------------------------------------------------
// CPlApplet
//
// Main control panel applet entry point
//
// Arguments :
//
//	hwndCpl			- Handle to the calling application's window
//	uMsg			- Message being sent to the applet
//	lpParamA		- Message-specific information
//	lpParamB		- Message-specific information

LONG WINAPI CPlApplet(HWND hwndCpl, UINT uMsg, LPARAM lpParamA, LPARAM lpParamB)
{
	static bool appDomainSetup = false;			// Flag for application domain setup

	// If the default application domain has not been set up with the custom event
	// handler(s), do so now and set the static variable to TRUE.  Concurrency shouldn't
	// be a problem at all in here, so there is no need to synchronize this ...

	if(!appDomainSetup) {

		AppDomain::CurrentDomain->AssemblyResolve += gcnew ResolveEventHandler(OnAssemblyResolve);
		appDomainSetup = true;
	}

	// Depending on what message has been sent in, call into the appropriate
	// function to handle it ...

	switch(uMsg) {

		// CPL_INIT : Sent immediately after the DLL has been loaded into memory

		case CPL_INIT : 
			return OnInit();

		// CPL_GETCOUNT : Sent after CPL_INIT to determine the number of applets
		
		case CPL_GETCOUNT : 
			return OnGetCount();

		// CPL_INQUIRE : Sent after CPL_GETCOUNT to get info about a specific applet

		case CPL_INQUIRE : 
			return OnInquire(static_cast<UINT>(lpParamA), reinterpret_cast<CPLINFO*>(lpParamB));

		// CPL_DBLCLK : Sent when the user chooses an applet from Control Panel

		case CPL_DBLCLK : 
			return OnDoubleClick(static_cast<UINT>(lpParamA));

		// CPL_EXIT : Sent immediately before the DLL is about to be unloaded

		case CPL_EXIT : 
			return OnExit();
	}

	return 0;
}

//---------------------------------------------------------------------------
// OnAssemblyResolve
//
// Custom assembly resolver to load the embedded applet module
//
// Arguments:
//
//	sender		- Object raising this event
//	args		- Assembly resolution event arguments

Assembly^ OnAssemblyResolve(Object^ sender, ResolveEventArgs^ args)
{
	HRSRC				hResource;			// Located resource handle
	HGLOBAL				hResData;			// Resource data handle
	array<Byte>^		rgResource;			// Resource as managed byte array

	if(!args->Name->StartsWith("zucchini.tools.httpconfig.applet")) return nullptr;

	// Attempt to locate and load the unmanaged resource containing the assembly

	hResource = FindResource(g_hModule, MAKEINTRESOURCE(IDR_APPLETASSEMBLY), L"ASSEMBLY");
	if(hResource == NULL) return nullptr;

	hResData = LoadResource(g_hModule, hResource);
	if(hResData == NULL) return nullptr;

	// The resource has been located.  Generate a managed byte array of the proper
	// size and copy the assembly data into it.  Note that you don't need to release
	// resource memory, so just call LockResource() and forget about it.  (Of course
	// by making this an UNMANAGED resource we end up with the data in memory twice,
	// but for whatever reason I'd prefer to stick with this implementation)

	rgResource = gcnew array<Byte>(SizeofResource(g_hModule, hResource));
	Marshal::Copy(IntPtr(LockResource(hResData)), rgResource, 0, rgResource->Length);

	return Assembly::Load(rgResource);		// Load the COFF assembly 
}

//---------------------------------------------------------------------------
// OnDoubleClick
//
// Called in response to the CPL_DBLCLK message
//
// Arguments :
//
//	uAppNum			- Dialog box (applet) number

LONG OnDoubleClick(UINT uAppNum)
{
	if(static_cast<HttpConfigApplet^>(g_applet) == nullptr) return -1;
	g_applet->ShowDialog();

	return 0;
}

//---------------------------------------------------------------------------
// OnExit
//
// Called in response to the CPL_EXIT message
//
// Arguments :
//
//	NONE

LONG OnExit(void)
{
	HttpConfigApplet^ applet = g_applet;		// Reference applet
	if(applet != nullptr) delete applet;		// Dispose of applet
	g_applet = nullptr;							// Release GCHandle

	return 0;
}

//---------------------------------------------------------------------------
// OnGetCount
//
// Called in response to the CPL_GETCOUNT message
//
// Arguments :
//
//	NONE

LONG OnGetCount(void)
{
	return 1;
}

//---------------------------------------------------------------------------
// OnInit
//
// Called in response to the CPL_INIT message
//
// Arguments :
//
//	NONE

LONG OnInit(void)
{
	// These would usually go in a sub main(), but since RUNDLL32 isn't
	// going to set them, doing it before we create any forms should suffice

	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	try { g_applet = gcnew HttpConfigApplet(); }
	catch(Exception^ ex) { 
	
		MessageBox::Show("Unable to launch control panel applet:\r\n\r\n" + ex->Message, 
			"Zucchini Http Configuration", MessageBoxButtons::OK, MessageBoxIcon::Error);
		return FALSE; 
	}

	return TRUE;
}

//---------------------------------------------------------------------------
// OnInquire
//
// Called in response to the CPL_INQUIRE message
//
// Arguments :
//
//	uAppNum			- Dialog box (applet) number
//	pInfo			- Pointer to the control panel applet information

LONG OnInquire(UINT uAppNum, CPLINFO *pInfo)
{
	if(static_cast<int>(uAppNum) >= 1) return -1;

	ZeroMemory(pInfo, sizeof(CPLINFO));
	pInfo->idIcon = IDI_HTTPCONFIG;
	pInfo->idInfo = IDS_APPLETDESCRIPTION;
	pInfo->idName = IDS_APPLETNAME;
	pInfo->lData = 0;

	return 0;
}

//---------------------------------------------------------------------------

#pragma warning(pop)

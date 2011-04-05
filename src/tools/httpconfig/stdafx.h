//---------------------------------------------------------------------------
// stdafx.h
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

#ifndef __STDAFX_H_
#define __STDAFX_H_
#pragma once

#if !defined(UNICODE) || !defined(_UNICODE)
#error This module must be built using the Unicode API set
#endif

//---------------------------------------------------------------------------
// BEGIN_NAMESPACE / END_NAMESPACE
//
// Used to define namespaces, since C++/CLI still doesn't let you combine them
// into one statement

#define BEGIN_NAMESPACE(__x) namespace __x {
#define END_NAMESPACE(__x) }

//---------------------------------------------------------------------------
// CHECK_DISPOSED
//
// Used throughout to make object disposed exceptions easier to read and not
// require hard-coding a class name into the statement.  This will throw the
// function name, but that's actually better in my opinion

#define CHECK_DISPOSED(__flag) \
	if(__flag) throw gcnew ObjectDisposedException(gcnew String(__FUNCTION__));

//---------------------------------------------------------------------------
// Win32 / CRT Declarations

#define WINVER			0x0501			// Windows XP (Service Pack 2)
#define _WIN32_WINNT	0x0501			// Windows XP (Service Pack 2)

#include <windows.h>				// Include main Win32 declarations
#include <cpl.h>					// Include Win32 control panel decls
#include <vcclr.h>					// Include VC CLR declarations

//---------------------------------------------------------------------------

#endif	// __STDAFX_H_



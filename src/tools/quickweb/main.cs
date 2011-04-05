//---------------------------------------------------------------------------
// main.cs
//
// Zucchini QuickWeb
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

using System;
using System.Windows.Forms;
using zuki.web.server;

namespace zucchini.tools.quickweb
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Deal with the boilerplate .NET startup code and launch
			// the main application form

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
			
			// After the main application form has been shut down, ensure
			// that all listeners are stopped before exiting the process

			WebServer.Shutdown();
		}
	}
}
//---------------------------------------------------------------------------
// main.cs
//
// Zucchini Virtual File System Generator
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
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace zucchini.tools.makevweb
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		private const string STRUCTURED_x86 = "embedded.x86.zuki.data.structured.dll";
		private const string STRUCTURED_x64 = "embedded.x64.zuki.data.structured.dll";

		// TODO: Clean this mess up, it was just for testing purposes
		static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
		{
			if (args.Name.StartsWith("zuki.data.structured", StringComparison.OrdinalIgnoreCase))
			{
				string resName = (typeof(Program).Assembly.GetName().ProcessorArchitecture == ProcessorArchitecture.Amd64) ?
					STRUCTURED_x64 : STRUCTURED_x86;

				Stream resStream = typeof(Program).Assembly.GetManifestResourceStream(typeof(Program), resName);
				if(resStream == null) return null;

				byte[] rg = new byte[(int)resStream.Length];
				resStream.Read(rg, 0, (int)resStream.Length);
				resStream.Close();
				
				return Assembly.Load(rg);
			}
			return null;
		}
	}
}
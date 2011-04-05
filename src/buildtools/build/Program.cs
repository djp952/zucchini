using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace build
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// NOTE: Build me twice, changing the "DEBUG" to "RELEASE", and saving off the
			// generated .EXE in the tree root.  Cheesy, but everything is controled via the
			// SRC\BUILDALL.BAT, so it's not likely this program needs to change much if ever

			ProcessStartInfo si = new ProcessStartInfo();
			si.Arguments = "/C " + Environment.CurrentDirectory + "\\SRC\\BUILDALL.BAT RELEASE";
			//si.Arguments = "/C " + Environment.CurrentDirectory + "\\SRC\\BUILDALL.BAT DEBUG";
			si.FileName = "CMD.EXE";
			si.WorkingDirectory = Environment.CurrentDirectory;

			Process p = new Process();
			p.StartInfo = si;
			if (p.Start()) p.WaitForExit();
		}
	}
}
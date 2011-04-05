//---------------------------------------------------------------------------
// MainForm.cs
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using zuki.web.server;

namespace zucchini.tools.quickweb
{
	public partial class MainForm : zuki.ui.VistaForm
	{
		/// <summary>
		/// Instance constructor
		/// </summary>
		public MainForm()
		{
			InitializeComponent();

			// Create the contained WebApplicationConfiguration instance

			m_config = new WebApplicationConfiguration();
			ResetUIFromConfiguration();

			// Adjust the background color of the left panel to the theme,
			// but don't do it if it's white since it will absorb the version

			Color backColor = SystemColors.InactiveCaption;
			if (backColor != Color.White) m_leftPanel.BackColor = backColor;
		}

		//-------------------------------------------------------------------
		// Event Handlers
		//-------------------------------------------------------------------

		/// <summary>
		/// Invoked when the form has been loaded
		/// </summary>
		/// <param name="sender">Object raising this event</param>
		/// <param name="args">Standard event arguments</param>
		private void OnFormLoad(object sender, EventArgs args)
		{
			m_version.Text = "Zucchini " + this.GetType().Assembly.GetName().Version.ToString(2);
		}

		/// <summary>
		/// Invoked when the user selects the "HTTP Configuration Utility" link label
		/// </summary>
		/// <param name="sender">Object raising this event</param>
		/// <param name="args">LinkLabel event arguments</param>
		private void OnLaunchHttpConfig(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//
			// TODO: HTTPCFG isn't installed by default on XP ... oops
			// I'd rather take that guy's code and make it into a new app, I'll
			// have to ask what his reuse policy happens to be for that
			//
			
			// VISTA: CMD.EXE /K NETSH -C WINHTTP
			// XP: CMD.EXE /K HTTPCFG
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.Arguments = "/k " + ((s_isVista) ? "netsh -c winhttp" : "httpcfg");
			startInfo.FileName = "cmd.exe";

			Process process = new Process();
			process.StartInfo = startInfo;
			process.Start();
		}

		/// <summary>
		/// Invoked when the user selects the LAUNCH button
		/// </summary>
		/// <param name="sender">Object raising this event</param>
		/// <param name="args">Standard event arguments</param>
		private void OnLaunchWeb(object sender, EventArgs args)
		{
			// TODO
			m_trayIcon.Visible = true;
			m_trayIcon.ShowBalloonTip(5000, "Zucchini", "TipText Here", ToolTipIcon.Info);
		}

		/// <summary>
		/// Invoked when the contents of the Phyiscal Root textbox changes
		/// </summary>
		/// <param name="sender">Object raising this event</param>
		/// <param name="args">Standard event arguments</param>
		private void OnPhysicalRootChanged(object sender, EventArgs args)
		{
			m_config.PhysicalRoot = m_sourceFolder.Text;
			EnableDisableLaunch();
		}

		//-------------------------------------------------------------------
		// Private Member Functions
		//-------------------------------------------------------------------

		/// <summary>
		/// Enables or disables the LAUNCH button based on the settings
		/// </summary>
		private void EnableDisableLaunch()
		{
			// If the configuration information is complete, allow the user
			// to actually launch the application
			m_launch.Enabled = m_config.IsComplete;
		}

		private void ResetUIFromConfiguration()
		{
			m_sourceFolder.Text = m_config.PhysicalRoot;
			// TODO
		}

		/// <summary>
		/// Saves the current configuration to a disk file
		/// </summary>
		/// <param name="fileName">Target file name</param>
		private void SaveConfiguration(string fileName)
		{
			// This is really simple, since WebApplicationConfiguration is
			// [Serializable]. Just throw the object at a BinaryFormatter
			// and have at it. (Loading can be more complicated, though)

			using (FileStream fs = File.Create(fileName))
				new BinaryFormatter().Serialize(fs, m_config);
		}

		//-------------------------------------------------------------------
		// Member Variables
		//-------------------------------------------------------------------

		private WebApplicationConfiguration m_config;		// Contained config

		private static bool s_isVista = (Environment.OSVersion.Version.Major >= 6);
	}
}
//---------------------------------------------------------------------------
// HttpConfigApplet.cs
//
// Zucchini HttpConfig Control Panel Applet
//
// Based on "Http Configuration Tool" project Copyright (C)2006 Steve Johnson
// <http://www.stevestechspot.com/>
//
// The use and distribution terms for this software are covered by the
// Common Public License 1.0 (http://opensource.org/licenses/cpl.php)
// which can be found in the file CPL.TXT at the root of this distribution.
// By using this software in any fashion, you are agreeing to be bound by
// the terms of this license. You must not remove this notice, or any other,
// from this software.
//
// Contributor(s):
//  Steve Johnson (original author - Original Work)
//	Michael G. Brehm (original author - Derived Work)
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace zucchini.tools.httpconfig.applet
{
	public partial class HttpConfigApplet : zuki.ui.VistaForm
	{
		/// <summary>
		/// Instance constructor
		/// </summary>
		public HttpConfigApplet()
		{
			InitializeComponent();

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

		//-------------------------------------------------------------------
		// Private Member Functions
		//-------------------------------------------------------------------

		//-------------------------------------------------------------------
		// Member Variables
		//-------------------------------------------------------------------
	}
}

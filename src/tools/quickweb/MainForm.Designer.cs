namespace zucchini.tools.quickweb
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.m_leftPanel = new System.Windows.Forms.Panel();
			this.vistaMetaDataLink3 = new zuki.ui.VistaMetaDataLink();
			this.vistaMetaDataLabel2 = new zuki.ui.VistaMetaDataLabel();
			this.vistaMetaDataLink2 = new zuki.ui.VistaMetaDataLink();
			this.vistaMetaDataLabel1 = new zuki.ui.VistaMetaDataLabel();
			this.vistaMetaDataLink1 = new zuki.ui.VistaMetaDataLink();
			this.m_version = new zuki.ui.VistaMetaDataLabel();
			this.m_logo = new System.Windows.Forms.PictureBox();
			this.m_buttonPanel = new System.Windows.Forms.Panel();
			this.m_launch = new zuki.ui.VistaCommandLink();
			this.m_workspacePanel = new System.Windows.Forms.Panel();
			this.m_warningLabel = new System.Windows.Forms.Label();
			this.m_warningIcon = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.vistaLink1 = new zuki.ui.VistaLink();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.m_destBrowse = new zuki.ui.VistaLink();
			this.m_destinationFile = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.m_sourceBrowse = new zuki.ui.VistaLink();
			this.m_sourceFolder = new System.Windows.Forms.TextBox();
			this.m_serverSeparator = new zuki.ui.VistaStaticSeparator();
			this.m_applicationSeparator = new zuki.ui.VistaStaticSeparator();
			this.m_heading = new zuki.ui.VistaMainInstruction();
			this.m_sourceFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.m_destFileBrowser = new System.Windows.Forms.SaveFileDialog();
			this.m_trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.m_trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitQuickWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.m_leftPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_logo)).BeginInit();
			this.m_buttonPanel.SuspendLayout();
			this.m_workspacePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_warningIcon)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.m_trayContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_leftPanel
			// 
			this.m_leftPanel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.m_leftPanel.Controls.Add(this.vistaMetaDataLink3);
			this.m_leftPanel.Controls.Add(this.vistaMetaDataLabel2);
			this.m_leftPanel.Controls.Add(this.vistaMetaDataLink2);
			this.m_leftPanel.Controls.Add(this.vistaMetaDataLabel1);
			this.m_leftPanel.Controls.Add(this.vistaMetaDataLink1);
			this.m_leftPanel.Controls.Add(this.m_version);
			this.m_leftPanel.Controls.Add(this.m_logo);
			this.m_leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_leftPanel.Location = new System.Drawing.Point(0, 0);
			this.m_leftPanel.Name = "m_leftPanel";
			this.m_leftPanel.Padding = new System.Windows.Forms.Padding(4, 6, 4, 4);
			this.m_leftPanel.Size = new System.Drawing.Size(180, 465);
			this.m_leftPanel.TabIndex = 0;
			// 
			// vistaMetaDataLink3
			// 
			this.vistaMetaDataLink3.FontSize = 9F;
			this.vistaMetaDataLink3.FontStyle = System.Drawing.FontStyle.Regular;
			this.vistaMetaDataLink3.Location = new System.Drawing.Point(12, 236);
			this.vistaMetaDataLink3.Name = "vistaMetaDataLink3";
			this.vistaMetaDataLink3.Size = new System.Drawing.Size(156, 20);
			this.vistaMetaDataLink3.TabIndex = 6;
			this.vistaMetaDataLink3.TabStop = true;
			this.vistaMetaDataLink3.Text = "Save current host settings";
			// 
			// vistaMetaDataLabel2
			// 
			this.vistaMetaDataLabel2.FontSize = 9F;
			this.vistaMetaDataLabel2.FontStyle = System.Drawing.FontStyle.Bold;
			this.vistaMetaDataLabel2.Location = new System.Drawing.Point(6, 188);
			this.vistaMetaDataLabel2.Name = "vistaMetaDataLabel2";
			this.vistaMetaDataLabel2.Size = new System.Drawing.Size(138, 19);
			this.vistaMetaDataLabel2.TabIndex = 5;
			this.vistaMetaDataLabel2.Text = "Host Settings";
			// 
			// vistaMetaDataLink2
			// 
			this.vistaMetaDataLink2.FontSize = 9F;
			this.vistaMetaDataLink2.FontStyle = System.Drawing.FontStyle.Regular;
			this.vistaMetaDataLink2.Location = new System.Drawing.Point(12, 212);
			this.vistaMetaDataLink2.Name = "vistaMetaDataLink2";
			this.vistaMetaDataLink2.Size = new System.Drawing.Size(156, 20);
			this.vistaMetaDataLink2.TabIndex = 4;
			this.vistaMetaDataLink2.TabStop = true;
			this.vistaMetaDataLink2.Text = "Load existing host settings";
			// 
			// vistaMetaDataLabel1
			// 
			this.vistaMetaDataLabel1.FontSize = 9F;
			this.vistaMetaDataLabel1.FontStyle = System.Drawing.FontStyle.Bold;
			this.vistaMetaDataLabel1.Location = new System.Drawing.Point(6, 272);
			this.vistaMetaDataLabel1.Name = "vistaMetaDataLabel1";
			this.vistaMetaDataLabel1.Size = new System.Drawing.Size(138, 19);
			this.vistaMetaDataLabel1.TabIndex = 3;
			this.vistaMetaDataLabel1.Text = "External Tools";
			// 
			// vistaMetaDataLink1
			// 
			this.vistaMetaDataLink1.FontSize = 9F;
			this.vistaMetaDataLink1.FontStyle = System.Drawing.FontStyle.Regular;
			this.vistaMetaDataLink1.Location = new System.Drawing.Point(12, 296);
			this.vistaMetaDataLink1.Name = "vistaMetaDataLink1";
			this.vistaMetaDataLink1.Size = new System.Drawing.Size(156, 20);
			this.vistaMetaDataLink1.TabIndex = 2;
			this.vistaMetaDataLink1.TabStop = true;
			this.vistaMetaDataLink1.Text = "HTTP Configuration Utility";
			this.vistaMetaDataLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLaunchHttpConfig);
			// 
			// m_version
			// 
			this.m_version.BackColor = System.Drawing.Color.Transparent;
			this.m_version.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_version.FontSize = 10F;
			this.m_version.FontStyle = System.Drawing.FontStyle.Regular;
			this.m_version.Location = new System.Drawing.Point(4, 439);
			this.m_version.Name = "m_version";
			this.m_version.Size = new System.Drawing.Size(172, 22);
			this.m_version.TabIndex = 1;
			this.m_version.Text = "{version}";
			this.m_version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// m_logo
			// 
			this.m_logo.BackColor = System.Drawing.Color.Transparent;
			this.m_logo.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_logo.Image = ((System.Drawing.Image)(resources.GetObject("m_logo.Image")));
			this.m_logo.Location = new System.Drawing.Point(4, 6);
			this.m_logo.Name = "m_logo";
			this.m_logo.Size = new System.Drawing.Size(172, 164);
			this.m_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.m_logo.TabIndex = 0;
			this.m_logo.TabStop = false;
			// 
			// m_buttonPanel
			// 
			this.m_buttonPanel.Controls.Add(this.m_launch);
			this.m_buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_buttonPanel.Location = new System.Drawing.Point(180, 398);
			this.m_buttonPanel.Name = "m_buttonPanel";
			this.m_buttonPanel.Size = new System.Drawing.Size(546, 67);
			this.m_buttonPanel.TabIndex = 2;
			// 
			// m_launch
			// 
			this.m_launch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.m_launch.Enabled = false;
			this.m_launch.Location = new System.Drawing.Point(426, 12);
			this.m_launch.Name = "m_launch";
			this.m_launch.Note = "";
			this.m_launch.Size = new System.Drawing.Size(108, 42);
			this.m_launch.TabIndex = 21;
			this.m_launch.Text = "Launch";
			this.m_launch.UseVisualStyleBackColor = true;
			this.m_launch.Click += new System.EventHandler(this.OnLaunchWeb);
			// 
			// m_workspacePanel
			// 
			this.m_workspacePanel.Controls.Add(this.m_warningLabel);
			this.m_workspacePanel.Controls.Add(this.m_warningIcon);
			this.m_workspacePanel.Controls.Add(this.groupBox1);
			this.m_workspacePanel.Controls.Add(this.vistaLink1);
			this.m_workspacePanel.Controls.Add(this.textBox2);
			this.m_workspacePanel.Controls.Add(this.label2);
			this.m_workspacePanel.Controls.Add(this.textBox1);
			this.m_workspacePanel.Controls.Add(this.label1);
			this.m_workspacePanel.Controls.Add(this.m_destBrowse);
			this.m_workspacePanel.Controls.Add(this.m_destinationFile);
			this.m_workspacePanel.Controls.Add(this.checkBox1);
			this.m_workspacePanel.Controls.Add(this.m_sourceBrowse);
			this.m_workspacePanel.Controls.Add(this.m_sourceFolder);
			this.m_workspacePanel.Controls.Add(this.m_serverSeparator);
			this.m_workspacePanel.Controls.Add(this.m_applicationSeparator);
			this.m_workspacePanel.Controls.Add(this.m_heading);
			this.m_workspacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_workspacePanel.Location = new System.Drawing.Point(180, 0);
			this.m_workspacePanel.Name = "m_workspacePanel";
			this.m_workspacePanel.Size = new System.Drawing.Size(546, 398);
			this.m_workspacePanel.TabIndex = 3;
			// 
			// m_warningLabel
			// 
			this.m_warningLabel.Location = new System.Drawing.Point(308, 312);
			this.m_warningLabel.Name = "m_warningLabel";
			this.m_warningLabel.Size = new System.Drawing.Size(212, 56);
			this.m_warningLabel.TabIndex = 37;
			this.m_warningLabel.Text = "Multiple Ports / Protocols have been configured and can only be changed within th" +
				"e Advanced Host Options";
			this.m_warningLabel.Visible = false;
			// 
			// m_warningIcon
			// 
			this.m_warningIcon.Image = global::zucchini.tools.quickweb.Properties.Resources.info_16x16;
			this.m_warningIcon.Location = new System.Drawing.Point(284, 328);
			this.m_warningIcon.Name = "m_warningIcon";
			this.m_warningIcon.Size = new System.Drawing.Size(16, 16);
			this.m_warningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.m_warningIcon.TabIndex = 36;
			this.m_warningIcon.TabStop = false;
			this.m_warningIcon.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(134, 312);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 44);
			this.groupBox1.TabIndex = 34;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Protocol";
			// 
			// radioButton2
			// 
			this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton2.Location = new System.Drawing.Point(66, 17);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(56, 20);
			this.radioButton2.TabIndex = 32;
			this.radioButton2.Text = "https:";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton1.Location = new System.Drawing.Point(12, 17);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(56, 20);
			this.radioButton1.TabIndex = 31;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "http:";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// vistaLink1
			// 
			this.vistaLink1.Enabled = false;
			this.vistaLink1.Location = new System.Drawing.Point(30, 368);
			this.vistaLink1.Name = "vistaLink1";
			this.vistaLink1.Size = new System.Drawing.Size(198, 20);
			this.vistaLink1.TabIndex = 33;
			this.vistaLink1.TabStop = true;
			this.vistaLink1.Text = "Advanced Host Options";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(32, 330);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(76, 23);
			this.textBox2.TabIndex = 27;
			this.textBox2.Text = "80";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 312);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 15);
			this.label2.TabIndex = 26;
			this.label2.Text = "Port";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(32, 278);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(494, 23);
			this.textBox1.TabIndex = 25;
			this.textBox1.Text = "/";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 260);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 15);
			this.label1.TabIndex = 24;
			this.label1.Text = "Virtual Root";
			// 
			// m_destBrowse
			// 
			this.m_destBrowse.Enabled = false;
			this.m_destBrowse.Location = new System.Drawing.Point(52, 198);
			this.m_destBrowse.Name = "m_destBrowse";
			this.m_destBrowse.Size = new System.Drawing.Size(144, 20);
			this.m_destBrowse.TabIndex = 23;
			this.m_destBrowse.TabStop = true;
			this.m_destBrowse.Text = "Browse locations";
			// 
			// m_destinationFile
			// 
			this.m_destinationFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_destinationFile.Enabled = false;
			this.m_destinationFile.Location = new System.Drawing.Point(52, 172);
			this.m_destinationFile.Name = "m_destinationFile";
			this.m_destinationFile.Size = new System.Drawing.Size(474, 23);
			this.m_destinationFile.TabIndex = 22;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1.Location = new System.Drawing.Point(34, 140);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(299, 20);
			this.checkBox1.TabIndex = 21;
			this.checkBox1.Text = "This application uses a Zucchini Virtual File System";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// m_sourceBrowse
			// 
			this.m_sourceBrowse.Location = new System.Drawing.Point(32, 112);
			this.m_sourceBrowse.Name = "m_sourceBrowse";
			this.m_sourceBrowse.Size = new System.Drawing.Size(144, 20);
			this.m_sourceBrowse.TabIndex = 20;
			this.m_sourceBrowse.TabStop = true;
			this.m_sourceBrowse.Text = "Browse folders";
			// 
			// m_sourceFolder
			// 
			this.m_sourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_sourceFolder.Location = new System.Drawing.Point(32, 86);
			this.m_sourceFolder.Name = "m_sourceFolder";
			this.m_sourceFolder.Size = new System.Drawing.Size(494, 23);
			this.m_sourceFolder.TabIndex = 19;
			this.m_sourceFolder.TextChanged += new System.EventHandler(this.OnPhysicalRootChanged);
			// 
			// m_serverSeparator
			// 
			this.m_serverSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_serverSeparator.Location = new System.Drawing.Point(20, 232);
			this.m_serverSeparator.Name = "m_serverSeparator";
			this.m_serverSeparator.Size = new System.Drawing.Size(506, 15);
			this.m_serverSeparator.TabIndex = 18;
			this.m_serverSeparator.Text = "Host Options";
			// 
			// m_applicationSeparator
			// 
			this.m_applicationSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_applicationSeparator.Location = new System.Drawing.Point(20, 56);
			this.m_applicationSeparator.Name = "m_applicationSeparator";
			this.m_applicationSeparator.Size = new System.Drawing.Size(506, 15);
			this.m_applicationSeparator.TabIndex = 9;
			this.m_applicationSeparator.Text = "Application";
			// 
			// m_heading
			// 
			this.m_heading.AutoSize = true;
			this.m_heading.Location = new System.Drawing.Point(18, 16);
			this.m_heading.Name = "m_heading";
			this.m_heading.Size = new System.Drawing.Size(259, 21);
			this.m_heading.TabIndex = 7;
			this.m_heading.Text = "Host a Zucchini ASP.NET application";
			// 
			// m_sourceFolderBrowser
			// 
			this.m_sourceFolderBrowser.Description = "Select the root folder of the ASP.NET Application or ASP.NET Web Service to be co" +
				"nverted into a Virtual File System";
			this.m_sourceFolderBrowser.ShowNewFolderButton = false;
			// 
			// m_destFileBrowser
			// 
			this.m_destFileBrowser.DefaultExt = "vweb";
			this.m_destFileBrowser.Filter = "Zucchini Virtual File Systems (*.vweb)|*.vweb|All Files (*.*)|*.*";
			this.m_destFileBrowser.SupportMultiDottedExtensions = true;
			this.m_destFileBrowser.Title = "Select Virtual File System location";
			// 
			// m_trayIcon
			// 
			this.m_trayIcon.ContextMenuStrip = this.m_trayContextMenu;
			this.m_trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("m_trayIcon.Icon")));
			this.m_trayIcon.Text = "Zucchini QuickWeb";
			// 
			// m_trayContextMenu
			// 
			this.m_trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.exitQuickWebToolStripMenuItem});
			this.m_trayContextMenu.Name = "m_trayContextMenu";
			this.m_trayContextMenu.Size = new System.Drawing.Size(175, 76);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Image = global::zucchini.tools.quickweb.Properties.Resources.bluerecycle_16x16;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(174, 22);
			this.toolStripMenuItem3.Text = "&Restart Application";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Image = global::zucchini.tools.quickweb.Properties.Resources.redx_16x16;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(174, 22);
			this.toolStripMenuItem2.Text = "&Stop Application";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
			// 
			// exitQuickWebToolStripMenuItem
			// 
			this.exitQuickWebToolStripMenuItem.Name = "exitQuickWebToolStripMenuItem";
			this.exitQuickWebToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.exitQuickWebToolStripMenuItem.Text = "E&xit QuickWeb";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(726, 465);
			this.Controls.Add(this.m_workspacePanel);
			this.Controls.Add(this.m_buttonPanel);
			this.Controls.Add(this.m_leftPanel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zucchini QuickWeb";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.m_leftPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_logo)).EndInit();
			this.m_buttonPanel.ResumeLayout(false);
			this.m_workspacePanel.ResumeLayout(false);
			this.m_workspacePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_warningIcon)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.m_trayContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel m_leftPanel;
		private System.Windows.Forms.PictureBox m_logo;
		private zuki.ui.VistaMetaDataLabel m_version;
		private System.Windows.Forms.Panel m_buttonPanel;
		private System.Windows.Forms.Panel m_workspacePanel;
		private zuki.ui.VistaMainInstruction m_heading;
		private zuki.ui.VistaStaticSeparator m_applicationSeparator;
		private zuki.ui.VistaStaticSeparator m_serverSeparator;
		private System.Windows.Forms.FolderBrowserDialog m_sourceFolderBrowser;
		private System.Windows.Forms.SaveFileDialog m_destFileBrowser;
		private zuki.ui.VistaCommandLink m_launch;
		private zuki.ui.VistaLink m_sourceBrowse;
		private System.Windows.Forms.TextBox m_sourceFolder;
		private System.Windows.Forms.CheckBox checkBox1;
		private zuki.ui.VistaLink m_destBrowse;
		private System.Windows.Forms.TextBox m_destinationFile;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private zuki.ui.VistaLink vistaLink1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private zuki.ui.VistaMetaDataLabel vistaMetaDataLabel1;
		private zuki.ui.VistaMetaDataLink vistaMetaDataLink1;
		private zuki.ui.VistaMetaDataLink vistaMetaDataLink3;
		private zuki.ui.VistaMetaDataLabel vistaMetaDataLabel2;
		private zuki.ui.VistaMetaDataLink vistaMetaDataLink2;
		private System.Windows.Forms.PictureBox m_warningIcon;
		private System.Windows.Forms.Label m_warningLabel;
		private System.Windows.Forms.NotifyIcon m_trayIcon;
		private System.Windows.Forms.ContextMenuStrip m_trayContextMenu;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitQuickWebToolStripMenuItem;


	}
}


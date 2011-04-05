namespace zucchini.tools.httpconfig.applet
{
	partial class HttpConfigApplet
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HttpConfigApplet));
			this.m_leftPanel = new System.Windows.Forms.Panel();
			this.m_version = new zuki.ui.VistaMetaDataLabel();
			this.m_logo = new System.Windows.Forms.PictureBox();
			this.m_workspacePanel = new System.Windows.Forms.Panel();
			this.m_permissionsSeparator = new zuki.ui.VistaStaticSeparator();
			this.m_sslSeparator = new zuki.ui.VistaStaticSeparator();
			this.m_listenersSeparator = new zuki.ui.VistaStaticSeparator();
			this.vistaLink1 = new zuki.ui.VistaLink();
			this.m_heading = new zuki.ui.VistaMainInstruction();
			this.m_leftPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_logo)).BeginInit();
			this.m_workspacePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_leftPanel
			// 
			this.m_leftPanel.BackColor = System.Drawing.Color.LightSteelBlue;
			this.m_leftPanel.Controls.Add(this.m_version);
			this.m_leftPanel.Controls.Add(this.m_logo);
			this.m_leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.m_leftPanel.Location = new System.Drawing.Point(0, 0);
			this.m_leftPanel.Name = "m_leftPanel";
			this.m_leftPanel.Padding = new System.Windows.Forms.Padding(4, 6, 4, 4);
			this.m_leftPanel.Size = new System.Drawing.Size(180, 455);
			this.m_leftPanel.TabIndex = 1;
			// 
			// m_version
			// 
			this.m_version.BackColor = System.Drawing.Color.Transparent;
			this.m_version.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.m_version.FontSize = 10F;
			this.m_version.FontStyle = System.Drawing.FontStyle.Regular;
			this.m_version.Location = new System.Drawing.Point(4, 429);
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
			// m_workspacePanel
			// 
			this.m_workspacePanel.Controls.Add(this.m_permissionsSeparator);
			this.m_workspacePanel.Controls.Add(this.m_sslSeparator);
			this.m_workspacePanel.Controls.Add(this.m_listenersSeparator);
			this.m_workspacePanel.Controls.Add(this.vistaLink1);
			this.m_workspacePanel.Controls.Add(this.m_heading);
			this.m_workspacePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.m_workspacePanel.Location = new System.Drawing.Point(180, 0);
			this.m_workspacePanel.Name = "m_workspacePanel";
			this.m_workspacePanel.Size = new System.Drawing.Size(536, 455);
			this.m_workspacePanel.TabIndex = 4;
			// 
			// m_permissionsSeparator
			// 
			this.m_permissionsSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_permissionsSeparator.Location = new System.Drawing.Point(20, 312);
			this.m_permissionsSeparator.Name = "m_permissionsSeparator";
			this.m_permissionsSeparator.Size = new System.Drawing.Size(506, 15);
			this.m_permissionsSeparator.TabIndex = 12;
			this.m_permissionsSeparator.Text = "Permissions";
			// 
			// m_sslSeparator
			// 
			this.m_sslSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_sslSeparator.Location = new System.Drawing.Point(20, 180);
			this.m_sslSeparator.Name = "m_sslSeparator";
			this.m_sslSeparator.Size = new System.Drawing.Size(506, 15);
			this.m_sslSeparator.TabIndex = 11;
			this.m_sslSeparator.Text = "Secure Sockets Layer (SSL)";
			// 
			// m_listenersSeparator
			// 
			this.m_listenersSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.m_listenersSeparator.Location = new System.Drawing.Point(20, 56);
			this.m_listenersSeparator.Name = "m_listenersSeparator";
			this.m_listenersSeparator.Size = new System.Drawing.Size(506, 15);
			this.m_listenersSeparator.TabIndex = 10;
			this.m_listenersSeparator.Text = "Listeners";
			// 
			// vistaLink1
			// 
			this.vistaLink1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.vistaLink1.Location = new System.Drawing.Point(0, 432);
			this.vistaLink1.Name = "vistaLink1";
			this.vistaLink1.Size = new System.Drawing.Size(536, 23);
			this.vistaLink1.TabIndex = 8;
			this.vistaLink1.TabStop = true;
			this.vistaLink1.Text = "Based on HttpConfig - Copyright ©2006 Steve Johnson";
			this.vistaLink1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// m_heading
			// 
			this.m_heading.AutoSize = true;
			this.m_heading.Location = new System.Drawing.Point(18, 16);
			this.m_heading.Name = "m_heading";
			this.m_heading.Size = new System.Drawing.Size(317, 21);
			this.m_heading.TabIndex = 7;
			this.m_heading.Text = "Configure the HTTP Listeners for this system";
			// 
			// HttpConfigApplet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(716, 455);
			this.Controls.Add(this.m_workspacePanel);
			this.Controls.Add(this.m_leftPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "HttpConfigApplet";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zucchini HTTP Configuration";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.m_leftPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.m_logo)).EndInit();
			this.m_workspacePanel.ResumeLayout(false);
			this.m_workspacePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel m_leftPanel;
		private zuki.ui.VistaMetaDataLabel m_version;
		private System.Windows.Forms.PictureBox m_logo;
		private System.Windows.Forms.Panel m_workspacePanel;
		private zuki.ui.VistaLink vistaLink1;
		private zuki.ui.VistaMainInstruction m_heading;
		private zuki.ui.VistaStaticSeparator m_listenersSeparator;
		private zuki.ui.VistaStaticSeparator m_permissionsSeparator;
		private zuki.ui.VistaStaticSeparator m_sslSeparator;
	}
}
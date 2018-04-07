namespace SecuritySystem
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEnroll = new System.Windows.Forms.ToolStripButton();
            this.btnVerify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleteUser = new System.Windows.Forms.ToolStripButton();
            this.btnClearDatabase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.DAR = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShipState = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToggleUsers = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOfficrCount = new System.Windows.Forms.Label();
            this.lblOnBoardCount = new System.Windows.Forms.Label();
            this.pbExtractedImage = new System.Windows.Forms.PictureBox();
            this.lblDATE = new System.Windows.Forms.Label();
            this.OFFICERS = new System.Windows.Forms.Label();
            this.ONBOARD = new System.Windows.Forms.Label();
            this.lblSTRENGTH = new System.Windows.Forms.Label();
            this.lblADDRESS = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.lbDatabase = new System.Windows.Forms.ListBox();
            this.SecurityCam = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.crewTableAdapter1 = new SecuritySystem.dbDataSetTableAdapters.crewTableAdapter();
            this.appSetingsTableAdapter1 = new SecuritySystem.dbDataSetTableAdapters.appSetingsTableAdapter();
            this.timeLogTableAdapter1 = new SecuritySystem.dbDataSetTableAdapters.timeLogTableAdapter();
            this.getRanksTableAdapter1 = new SecuritySystem.dbDataSetTableAdapters.getRanksTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtractedImage)).BeginInit();
            this.tlpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecurityCam)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEnroll,
            this.btnVerify,
            this.toolStripSeparator2,
            this.btnDeleteUser,
            this.btnClearDatabase,
            this.toolStripSeparator1,
            this.btnSettings,
            this.toolStripSeparator3,
            this.btnAbout,
            this.toolStripSeparator4,
            this.DAR,
            this.toolStripSeparator6,
            this.toolStripButtonShipState,
            this.toolStripSeparator5,
            this.ToggleUsers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(981, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnEnroll
            // 
            this.btnEnroll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEnroll.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnroll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEnroll.Name = "btnEnroll";
            this.btnEnroll.Size = new System.Drawing.Size(47, 22);
            this.btnEnroll.Text = "Enroll";
            this.btnEnroll.Click += new System.EventHandler(this.btnEnroll_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnVerify.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(51, 22);
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Image = global::SecuritySystem.Properties.Resources.Delete;
            this.btnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(85, 22);
            this.btnDeleteUser.Text = "Delete user";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnClearDatabase
            // 
            this.btnClearDatabase.Image = global::SecuritySystem.Properties.Resources.DeleteFolderHS;
            this.btnClearDatabase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearDatabase.Name = "btnClearDatabase";
            this.btnClearDatabase.Size = new System.Drawing.Size(105, 22);
            this.btnClearDatabase.Text = "Clear Database";
            this.btnClearDatabase.Click += new System.EventHandler(this.btnClearDatabase_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::SecuritySystem.Properties.Resources.OptionsHS;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(69, 22);
            this.btnSettings.Text = "Settings";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::SecuritySystem.Properties.Resources.Info;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(60, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // DAR
            // 
            this.DAR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DAR.Image = ((System.Drawing.Image)(resources.GetObject("DAR.Image")));
            this.DAR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DAR.Name = "DAR";
            this.DAR.Size = new System.Drawing.Size(80, 22);
            this.DAR.Text = "Total Present";
            this.DAR.Click += new System.EventHandler(this.DAR_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonShipState
            // 
            this.toolStripButtonShipState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonShipState.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShipState.Image")));
            this.toolStripButtonShipState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShipState.Name = "toolStripButtonShipState";
            this.toolStripButtonShipState.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonShipState.Text = "Ship State";
            this.toolStripButtonShipState.Visible = false;
            this.toolStripButtonShipState.Click += new System.EventHandler(this.toolStripButtonShipState_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToggleUsers
            // 
            this.ToggleUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToggleUsers.Image = ((System.Drawing.Image)(resources.GetObject("ToggleUsers.Image")));
            this.ToggleUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToggleUsers.Name = "ToggleUsers";
            this.ToggleUsers.Size = new System.Drawing.Size(97, 22);
            this.ToggleUsers.Text = "Toggle DB Users";
            this.ToggleUsers.Click += new System.EventHandler(this.ToggleUsers_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tlpLeft);
            this.splitContainer1.Size = new System.Drawing.Size(981, 539);
            this.splitContainer1.SplitterDistance = 671;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSend);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(88, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 75);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(51, 34);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(100, 20);
            this.txtSend.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Serial port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOfficrCount);
            this.panel1.Controls.Add(this.lblOnBoardCount);
            this.panel1.Controls.Add(this.pbExtractedImage);
            this.panel1.Controls.Add(this.lblDATE);
            this.panel1.Controls.Add(this.OFFICERS);
            this.panel1.Controls.Add(this.ONBOARD);
            this.panel1.Controls.Add(this.lblSTRENGTH);
            this.panel1.Controls.Add(this.lblADDRESS);
            this.panel1.Controls.Add(this.lblUnitName);
            this.panel1.Location = new System.Drawing.Point(32, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 273);
            this.panel1.TabIndex = 2;
            // 
            // lblOfficrCount
            // 
            this.lblOfficrCount.AutoSize = true;
            this.lblOfficrCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficrCount.Location = new System.Drawing.Point(183, 173);
            this.lblOfficrCount.Name = "lblOfficrCount";
            this.lblOfficrCount.Size = new System.Drawing.Size(27, 29);
            this.lblOfficrCount.TabIndex = 11;
            this.lblOfficrCount.Text = "0";
            this.lblOfficrCount.Visible = false;
            // 
            // lblOnBoardCount
            // 
            this.lblOnBoardCount.AutoSize = true;
            this.lblOnBoardCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnBoardCount.Location = new System.Drawing.Point(308, 134);
            this.lblOnBoardCount.Name = "lblOnBoardCount";
            this.lblOnBoardCount.Size = new System.Drawing.Size(27, 29);
            this.lblOnBoardCount.TabIndex = 9;
            this.lblOnBoardCount.Text = "0";
            // 
            // pbExtractedImage
            // 
            this.pbExtractedImage.Location = new System.Drawing.Point(-29, -23);
            this.pbExtractedImage.Name = "pbExtractedImage";
            this.pbExtractedImage.Size = new System.Drawing.Size(51, 45);
            this.pbExtractedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbExtractedImage.TabIndex = 0;
            this.pbExtractedImage.TabStop = false;
            this.pbExtractedImage.Visible = false;
            this.pbExtractedImage.Click += new System.EventHandler(this.pbExtractedImage_Click);
            // 
            // lblDATE
            // 
            this.lblDATE.AutoSize = true;
            this.lblDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDATE.Location = new System.Drawing.Point(28, 211);
            this.lblDATE.Name = "lblDATE";
            this.lblDATE.Size = new System.Drawing.Size(109, 29);
            this.lblDATE.TabIndex = 8;
            this.lblDATE.Text = "DATE !: ";
            // 
            // OFFICERS
            // 
            this.OFFICERS.AutoSize = true;
            this.OFFICERS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OFFICERS.Location = new System.Drawing.Point(28, 173);
            this.OFFICERS.Name = "OFFICERS";
            this.OFFICERS.Size = new System.Drawing.Size(149, 29);
            this.OFFICERS.TabIndex = 4;
            this.OFFICERS.Text = "OFFICERS:";
            this.OFFICERS.Visible = false;
            // 
            // ONBOARD
            // 
            this.ONBOARD.AutoSize = true;
            this.ONBOARD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ONBOARD.Location = new System.Drawing.Point(24, 134);
            this.ONBOARD.Name = "ONBOARD";
            this.ONBOARD.Size = new System.Drawing.Size(278, 29);
            this.ONBOARD.TabIndex = 3;
            this.ONBOARD.Text = "PRESENT/ONBOARD:";
            // 
            // lblSTRENGTH
            // 
            this.lblSTRENGTH.AutoSize = true;
            this.lblSTRENGTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTRENGTH.Location = new System.Drawing.Point(24, 93);
            this.lblSTRENGTH.Name = "lblSTRENGTH";
            this.lblSTRENGTH.Size = new System.Drawing.Size(253, 29);
            this.lblSTRENGTH.TabIndex = 2;
            this.lblSTRENGTH.Text = "TOTAL STRENGTH:";
            // 
            // lblADDRESS
            // 
            this.lblADDRESS.AutoSize = true;
            this.lblADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADDRESS.Location = new System.Drawing.Point(28, 54);
            this.lblADDRESS.Name = "lblADDRESS";
            this.lblADDRESS.Size = new System.Drawing.Size(141, 29);
            this.lblADDRESS.TabIndex = 1;
            this.lblADDRESS.Text = "ADDRESS:";
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitName.Location = new System.Drawing.Point(24, 16);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(161, 29);
            this.lblUnitName.TabIndex = 0;
            this.lblUnitName.Text = "UNIT NAME:";
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.lbDatabase, 0, 2);
            this.tlpLeft.Controls.Add(this.SecurityCam, 0, 0);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(0, 0);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 3;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 404F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeft.Size = new System.Drawing.Size(306, 539);
            this.tlpLeft.TabIndex = 0;
            // 
            // lbDatabase
            // 
            this.lbDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDatabase.FormattingEnabled = true;
            this.lbDatabase.Location = new System.Drawing.Point(3, 138);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(300, 398);
            this.lbDatabase.TabIndex = 10;
            this.lbDatabase.SelectedIndexChanged += new System.EventHandler(this.lbDatabase_SelectedIndexChanged);
            this.lbDatabase.DoubleClick += new System.EventHandler(this.lbDatabase_DoubleClick);
            // 
            // SecurityCam
            // 
            this.SecurityCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecurityCam.Location = new System.Drawing.Point(3, 3);
            this.SecurityCam.Name = "SecurityCam";
            this.SecurityCam.Size = new System.Drawing.Size(300, 229);
            this.SecurityCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecurityCam.TabIndex = 9;
            this.SecurityCam.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(981, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // crewTableAdapter1
            // 
            this.crewTableAdapter1.ClearBeforeFill = true;
            // 
            // appSetingsTableAdapter1
            // 
            this.appSetingsTableAdapter1.ClearBeforeFill = true;
            // 
            // timeLogTableAdapter1
            // 
            this.timeLogTableAdapter1.ClearBeforeFill = true;
            // 
            // getRanksTableAdapter1
            // 
            this.getRanksTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 586);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Security System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtractedImage)).EndInit();
            this.tlpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SecurityCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnEnroll;
		private System.Windows.Forms.ToolStripButton btnVerify;
        private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnDeleteUser;
		private System.Windows.Forms.ToolStripButton btnSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton btnClearDatabase;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.PictureBox pbExtractedImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblADDRESS;
        private System.Windows.Forms.Label lblSTRENGTH;
        private System.Windows.Forms.Label ONBOARD;
        private System.Windows.Forms.Label OFFICERS;
        private System.Windows.Forms.Label lblDATE;
        private SecuritySystem.dbDataSetTableAdapters.crewTableAdapter crewTableAdapter1;
        private SecuritySystem.dbDataSetTableAdapters.appSetingsTableAdapter appSetingsTableAdapter1;
        private System.Windows.Forms.PictureBox SecurityCam;
        private System.Windows.Forms.ListBox lbDatabase;
        private SecuritySystem.dbDataSetTableAdapters.timeLogTableAdapter timeLogTableAdapter1;
        private System.Windows.Forms.Label lblOnBoardCount;
        private SecuritySystem.dbDataSetTableAdapters.getRanksTableAdapter getRanksTableAdapter1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton DAR;
        private System.Windows.Forms.Label lblOfficrCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ToggleUsers;
        private System.Windows.Forms.ToolStripButton toolStripButtonShipState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSend;

	}
}


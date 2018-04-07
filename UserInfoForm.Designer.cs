namespace SecuritySystem
{
	partial class UserInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUserFinger = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.lblContctNo = new System.Windows.Forms.Label();
            this.lblDesg = new System.Windows.Forms.Label();
            this.cmbDesg = new System.Windows.Forms.ComboBox();
            this.ranksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new SecuritySystem.dbDataSet();
            this.txtNumbr = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.crewTableAdapter = new SecuritySystem.dbDataSetTableAdapters.crewTableAdapter();
            this.ranksTableAdapter = new SecuritySystem.dbDataSetTableAdapters.RanksTableAdapter();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserFinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblUserName);
            this.splitContainer1.Panel1.Controls.Add(this.pbUserFinger);
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.lblNo);
            this.splitContainer1.Panel2.Controls.Add(this.txtno);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxImage);
            this.splitContainer1.Panel2.Controls.Add(this.lblContctNo);
            this.splitContainer1.Panel2.Controls.Add(this.lblDesg);
            this.splitContainer1.Panel2.Controls.Add(this.cmbDesg);
            this.splitContainer1.Panel2.Controls.Add(this.txtNumbr);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(746, 349);
            this.splitContainer1.SplitterDistance = 247;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUserName.Location = new System.Drawing.Point(0, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(247, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "label1";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbUserFinger
            // 
            this.pbUserFinger.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbUserFinger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUserFinger.Location = new System.Drawing.Point(0, 0);
            this.pbUserFinger.Name = "pbUserFinger";
            this.pbUserFinger.Size = new System.Drawing.Size(247, 349);
            this.pbUserFinger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbUserFinger.TabIndex = 5;
            this.pbUserFinger.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(531, 345);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(154, 47);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(151, 117);
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save and Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(151, 230);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(83, 13);
            this.lblNo.TabIndex = 9;
            this.lblNo.Text = "PNo/ONO/NIC:";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(243, 227);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(121, 20);
            this.txtno.TabIndex = 8;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(495, 203);
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // lblContctNo
            // 
            this.lblContctNo.AutoSize = true;
            this.lblContctNo.Location = new System.Drawing.Point(151, 277);
            this.lblContctNo.Name = "lblContctNo";
            this.lblContctNo.Size = new System.Drawing.Size(87, 13);
            this.lblContctNo.TabIndex = 5;
            this.lblContctNo.Text = "Contact Number:";
            // 
            // lblDesg
            // 
            this.lblDesg.AutoSize = true;
            this.lblDesg.Location = new System.Drawing.Point(202, 256);
            this.lblDesg.Name = "lblDesg";
            this.lblDesg.Size = new System.Drawing.Size(36, 13);
            this.lblDesg.TabIndex = 4;
            this.lblDesg.Text = "Rank:";
            // 
            // cmbDesg
            // 
            this.cmbDesg.DataSource = this.ranksBindingSource;
            this.cmbDesg.DisplayMember = "Rank";
            this.cmbDesg.FormattingEnabled = true;
            this.cmbDesg.Location = new System.Drawing.Point(243, 253);
            this.cmbDesg.Name = "cmbDesg";
            this.cmbDesg.Size = new System.Drawing.Size(121, 21);
            this.cmbDesg.TabIndex = 0;
            this.cmbDesg.ValueMember = "ID";
            // 
            // ranksBindingSource
            // 
            this.ranksBindingSource.DataMember = "Ranks";
            this.ranksBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNumbr
            // 
            this.txtNumbr.Location = new System.Drawing.Point(243, 280);
            this.txtNumbr.Name = "txtNumbr";
            this.txtNumbr.Size = new System.Drawing.Size(121, 20);
            this.txtNumbr.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 203);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(495, 146);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // crewTableAdapter
            // 
            this.crewTableAdapter.ClearBeforeFill = true;
            // 
            // ranksTableAdapter
            // 
            this.ranksTableAdapter.ClearBeforeFill = true;
            // 
            // UserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 349);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserInfoForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "User Information";
            this.Load += new System.EventHandler(this.UserInfoForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInfoForm_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserFinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ranksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbUserFinger;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbDesg;
        private System.Windows.Forms.TextBox txtNumbr;
        private SecuritySystem.dbDataSetTableAdapters.crewTableAdapter crewTableAdapter;
        
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblDesg;
        private System.Windows.Forms.Label lblContctNo;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource ranksBindingSource;
        private SecuritySystem.dbDataSetTableAdapters.RanksTableAdapter ranksTableAdapter;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox;


    }
}
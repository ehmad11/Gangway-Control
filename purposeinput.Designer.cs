namespace SecuritySystem
{
    partial class purposeinput
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.timeLogTableAdapter1 = new SecuritySystem.dbDataSetTableAdapters.timeLogTableAdapter();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(43, 37);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(13, 13);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "_";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(46, 71);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(289, 20);
            this.txtReason.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(342, 71);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 2;
            this.btn.Text = "Ok";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(424, 70);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // timeLogTableAdapter1
            // 
            this.timeLogTableAdapter1.ClearBeforeFill = true;
            // 
            // purposeinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 103);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblInfo);
            this.Name = "purposeinput";
            this.Text = "purposeinput";
            this.Load += new System.EventHandler(this.purposeinput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnCancel;
        private SecuritySystem.dbDataSetTableAdapters.timeLogTableAdapter timeLogTableAdapter1;
    }
}
namespace DVLD.Car_Number
{
    partial class frmMakeCarNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPersonInfoNext = new System.Windows.Forms.Button();
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctrlPersonCardWithFilter1 = new DVLD.Controls.ctrlPersonCardWithFilter();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCarNo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tcUserInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(374, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make Car Number";
            // 
            // btnPersonInfoNext
            // 
            this.btnPersonInfoNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonInfoNext.Image = global::DVLD.Properties.Resources.Next_32;
            this.btnPersonInfoNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonInfoNext.Location = new System.Drawing.Point(924, 400);
            this.btnPersonInfoNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonInfoNext.Name = "btnPersonInfoNext";
            this.btnPersonInfoNext.Size = new System.Drawing.Size(126, 37);
            this.btnPersonInfoNext.TabIndex = 120;
            this.btnPersonInfoNext.Text = "Next";
            this.btnPersonInfoNext.UseVisualStyleBackColor = true;
            this.btnPersonInfoNext.Click += new System.EventHandler(this.btnPersonInfoNext_Click);
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tabPage1);
            this.tcUserInfo.Controls.Add(this.tpLoginInfo);
            this.tcUserInfo.Location = new System.Drawing.Point(2, 105);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(1063, 468);
            this.tcUserInfo.TabIndex = 121;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctrlPersonCardWithFilter1);
            this.tabPage1.Controls.Add(this.btnPersonInfoNext);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1055, 442);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ctrlPersonCardWithFilter1
            // 
            this.ctrlPersonCardWithFilter1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ctrlPersonCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCardWithFilter1.FilterEnabled = true;
            this.ctrlPersonCardWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlPersonCardWithFilter1.Location = new System.Drawing.Point(4, 5);
            this.ctrlPersonCardWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            this.ctrlPersonCardWithFilter1.ShowAddPerson = true;
            this.ctrlPersonCardWithFilter1.Size = new System.Drawing.Size(1047, 385);
            this.ctrlPersonCardWithFilter1.TabIndex = 3;
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.button1);
            this.tpLoginInfo.Controls.Add(this.lblCarNo);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(1055, 442);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "tabPage2";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(933, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Make Car No";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCarNo
            // 
            this.lblCarNo.AutoSize = true;
            this.lblCarNo.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarNo.Location = new System.Drawing.Point(466, 53);
            this.lblCarNo.Name = "lblCarNo";
            this.lblCarNo.Size = new System.Drawing.Size(80, 25);
            this.lblCarNo.TabIndex = 0;
            this.lblCarNo.Text = "[????]";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::DVLD.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(939, 591);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 37);
            this.btnSave.TabIndex = 122;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(794, 591);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 37);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMakeCarNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 630);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tcUserInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmMakeCarNumber";
            this.Text = "frmMakeCarNumber";
            this.tcUserInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private System.Windows.Forms.Label lblCarNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}
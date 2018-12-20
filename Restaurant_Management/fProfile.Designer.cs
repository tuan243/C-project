namespace Restaurant_Management
{
    partial class fProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_ChangePass = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Lbl_Comfirm = new System.Windows.Forms.Panel();
            this.Txb_Confirm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Txb_NewPass = new System.Windows.Forms.TextBox();
            this.Lbl_NewPassword = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Txb_OldPass = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Txb_UserName = new System.Windows.Forms.TextBox();
            this.Lbl_UserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txb_Type = new System.Windows.Forms.TextBox();
            this.Lbl_AccountType = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Txb_DisplayName = new System.Windows.Forms.TextBox();
            this.Lbl_DisplayName = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Lbl_Comfirm.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Update);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 325);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_ChangePass);
            this.groupBox2.Controls.Add(this.Btn_Cancel);
            this.groupBox2.Controls.Add(this.Lbl_Comfirm);
            this.groupBox2.Controls.Add(this.panel7);
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Location = new System.Drawing.Point(5, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password Option";
            // 
            // Btn_ChangePass
            // 
            this.Btn_ChangePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ChangePass.Location = new System.Drawing.Point(260, 125);
            this.Btn_ChangePass.Name = "Btn_ChangePass";
            this.Btn_ChangePass.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChangePass.TabIndex = 6;
            this.Btn_ChangePass.Text = "Change";
            this.Btn_ChangePass.UseVisualStyleBackColor = true;
            this.Btn_ChangePass.Click += new System.EventHandler(this.Btn_ChangePass_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancel.Location = new System.Drawing.Point(341, 125);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 7;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Lbl_Comfirm
            // 
            this.Lbl_Comfirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Comfirm.Controls.Add(this.Txb_Confirm);
            this.Lbl_Comfirm.Controls.Add(this.label5);
            this.Lbl_Comfirm.Location = new System.Drawing.Point(5, 92);
            this.Lbl_Comfirm.Name = "Lbl_Comfirm";
            this.Lbl_Comfirm.Size = new System.Drawing.Size(415, 30);
            this.Lbl_Comfirm.TabIndex = 3;
            // 
            // Txb_Confirm
            // 
            this.Txb_Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_Confirm.Location = new System.Drawing.Point(187, 5);
            this.Txb_Confirm.Name = "Txb_Confirm";
            this.Txb_Confirm.Size = new System.Drawing.Size(224, 20);
            this.Txb_Confirm.TabIndex = 0;
            this.Txb_Confirm.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Comfirm New Password :";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.Txb_NewPass);
            this.panel7.Controls.Add(this.Lbl_NewPassword);
            this.panel7.Location = new System.Drawing.Point(5, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 30);
            this.panel7.TabIndex = 4;
            // 
            // Txb_NewPass
            // 
            this.Txb_NewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_NewPass.Location = new System.Drawing.Point(187, 5);
            this.Txb_NewPass.Name = "Txb_NewPass";
            this.Txb_NewPass.Size = new System.Drawing.Size(224, 20);
            this.Txb_NewPass.TabIndex = 0;
            this.Txb_NewPass.UseSystemPasswordChar = true;
            // 
            // Lbl_NewPassword
            // 
            this.Lbl_NewPassword.AutoSize = true;
            this.Lbl_NewPassword.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NewPassword.Location = new System.Drawing.Point(4, 4);
            this.Lbl_NewPassword.Name = "Lbl_NewPassword";
            this.Lbl_NewPassword.Size = new System.Drawing.Size(120, 19);
            this.Lbl_NewPassword.TabIndex = 0;
            this.Lbl_NewPassword.Text = "New Password :";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.Txb_OldPass);
            this.panel6.Controls.Add(this.Lbl_Password);
            this.panel6.Location = new System.Drawing.Point(5, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(415, 30);
            this.panel6.TabIndex = 5;
            // 
            // Txb_OldPass
            // 
            this.Txb_OldPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_OldPass.Location = new System.Drawing.Point(187, 5);
            this.Txb_OldPass.Name = "Txb_OldPass";
            this.Txb_OldPass.Size = new System.Drawing.Size(224, 20);
            this.Txb_OldPass.TabIndex = 0;
            this.Txb_OldPass.UseSystemPasswordChar = true;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Password.Location = new System.Drawing.Point(4, 4);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(85, 19);
            this.Lbl_Password.TabIndex = 0;
            this.Lbl_Password.Text = "Password :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.Txb_UserName);
            this.panel5.Controls.Add(this.Lbl_UserName);
            this.panel5.Location = new System.Drawing.Point(5, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 30);
            this.panel5.TabIndex = 2;
            // 
            // Txb_UserName
            // 
            this.Txb_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_UserName.Location = new System.Drawing.Point(134, 5);
            this.Txb_UserName.Name = "Txb_UserName";
            this.Txb_UserName.ReadOnly = true;
            this.Txb_UserName.Size = new System.Drawing.Size(277, 20);
            this.Txb_UserName.TabIndex = 0;
            // 
            // Lbl_UserName
            // 
            this.Lbl_UserName.AutoSize = true;
            this.Lbl_UserName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UserName.Location = new System.Drawing.Point(4, 4);
            this.Lbl_UserName.Name = "Lbl_UserName";
            this.Lbl_UserName.Size = new System.Drawing.Size(89, 19);
            this.Lbl_UserName.TabIndex = 0;
            this.Lbl_UserName.Text = "UserName :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.Txb_Type);
            this.panel2.Controls.Add(this.Lbl_AccountType);
            this.panel2.Location = new System.Drawing.Point(5, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 30);
            this.panel2.TabIndex = 3;
            // 
            // Txb_Type
            // 
            this.Txb_Type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_Type.Location = new System.Drawing.Point(134, 5);
            this.Txb_Type.Name = "Txb_Type";
            this.Txb_Type.ReadOnly = true;
            this.Txb_Type.Size = new System.Drawing.Size(277, 20);
            this.Txb_Type.TabIndex = 0;
            // 
            // Lbl_AccountType
            // 
            this.Lbl_AccountType.AutoSize = true;
            this.Lbl_AccountType.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AccountType.Location = new System.Drawing.Point(4, 4);
            this.Lbl_AccountType.Name = "Lbl_AccountType";
            this.Lbl_AccountType.Size = new System.Drawing.Size(111, 19);
            this.Lbl_AccountType.TabIndex = 0;
            this.Lbl_AccountType.Text = "Account Type :";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.Txb_DisplayName);
            this.panel3.Controls.Add(this.Lbl_DisplayName);
            this.panel3.Location = new System.Drawing.Point(5, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 30);
            this.panel3.TabIndex = 4;
            // 
            // Txb_DisplayName
            // 
            this.Txb_DisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_DisplayName.Location = new System.Drawing.Point(134, 5);
            this.Txb_DisplayName.Name = "Txb_DisplayName";
            this.Txb_DisplayName.Size = new System.Drawing.Size(277, 20);
            this.Txb_DisplayName.TabIndex = 0;
            // 
            // Lbl_DisplayName
            // 
            this.Lbl_DisplayName.AutoSize = true;
            this.Lbl_DisplayName.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DisplayName.Location = new System.Drawing.Point(4, 4);
            this.Lbl_DisplayName.Name = "Lbl_DisplayName";
            this.Lbl_DisplayName.Size = new System.Drawing.Size(112, 19);
            this.Lbl_DisplayName.TabIndex = 0;
            this.Lbl_DisplayName.Text = "Display Name :";
            // 
            // Btn_Close
            // 
            this.Btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Close.Location = new System.Drawing.Point(346, 299);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(75, 23);
            this.Btn_Close.TabIndex = 2;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.UseVisualStyleBackColor = true;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Update.Location = new System.Drawing.Point(265, 299);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(75, 23);
            this.Btn_Update.TabIndex = 6;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // fProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 325);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(451, 364);
            this.MinimumSize = new System.Drawing.Size(451, 364);
            this.Name = "fProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fProfile";
            this.Load += new System.EventHandler(this.fProfile_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.Lbl_Comfirm.ResumeLayout(false);
            this.Lbl_Comfirm.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Txb_UserName;
        private System.Windows.Forms.Label Lbl_UserName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Txb_Type;
        private System.Windows.Forms.Label Lbl_AccountType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Txb_DisplayName;
        private System.Windows.Forms.Label Lbl_DisplayName;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_ChangePass;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Panel Lbl_Comfirm;
        private System.Windows.Forms.TextBox Txb_Confirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox Txb_NewPass;
        private System.Windows.Forms.Label Lbl_NewPassword;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox Txb_OldPass;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Button Btn_Update;
    }
}
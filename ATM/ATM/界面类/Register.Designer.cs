namespace ATM
{
    partial class Register
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.labelPasswor = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelID.Location = new System.Drawing.Point(132, 170);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(100, 29);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "身份证";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelName.Location = new System.Drawing.Point(132, 130);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 31);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "开户人";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("RomanC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(263, 170);
            this.txtID.MaxLength = 25575;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(207, 35);
            this.txtID.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("RomanC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(263, 126);
            this.txtName.MaxLength = 25575;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 35);
            this.txtName.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("黑体", 15F);
            this.btnRegister.Location = new System.Drawing.Point(263, 320);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(207, 92);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelPasswor
            // 
            this.labelPasswor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPasswor.Location = new System.Drawing.Point(132, 210);
            this.labelPasswor.Name = "labelPasswor";
            this.labelPasswor.Size = new System.Drawing.Size(100, 30);
            this.labelPasswor.TabIndex = 13;
            this.labelPasswor.Text = "密码";
            this.labelPasswor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("RomanC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(263, 210);
            this.txtPassword.MaxLength = 12;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 35);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // labelConfirm
            // 
            this.labelConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelConfirm.Location = new System.Drawing.Point(132, 251);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(100, 30);
            this.labelConfirm.TabIndex = 14;
            this.labelConfirm.Text = "确认密码";
            this.labelConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("RomanC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.Location = new System.Drawing.Point(263, 252);
            this.txtConfirm.MaxLength = 12;
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(207, 35);
            this.txtConfirm.TabIndex = 3;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 540);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.labelConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPasswor);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label labelPasswor;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
    }
}
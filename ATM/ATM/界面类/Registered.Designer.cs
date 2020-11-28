namespace ATM
{
    partial class Registered
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
            this.labelSuccess = new System.Windows.Forms.Label();
            this.labelAccountID = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSuccess
            // 
            this.labelSuccess.Font = new System.Drawing.Font("宋体", 15F);
            this.labelSuccess.Location = new System.Drawing.Point(131, 56);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(226, 76);
            this.labelSuccess.TabIndex = 0;
            this.labelSuccess.Text = "注册成功";
            this.labelSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAccountID
            // 
            this.labelAccountID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelAccountID.Font = new System.Drawing.Font("宋体", 15F);
            this.labelAccountID.Location = new System.Drawing.Point(89, 132);
            this.labelAccountID.Name = "labelAccountID";
            this.labelAccountID.Size = new System.Drawing.Size(315, 76);
            this.labelAccountID.TabIndex = 1;
            this.labelAccountID.Text = "账号ID：";
            this.labelAccountID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("黑体", 12F);
            this.btnLogin.Location = new System.Drawing.Point(172, 252);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(152, 75);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "立即登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Registered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.labelAccountID);
            this.Controls.Add(this.labelSuccess);
            this.Name = "Registered";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registered";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.Label labelAccountID;
        private System.Windows.Forms.Button btnLogin;
    }
}
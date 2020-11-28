namespace ATM
{
    partial class PersonalCentre
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
            this.btnFetch = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.panelOperate = new System.Windows.Forms.Panel();
            this.panelIDInfo = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelRemainings = new System.Windows.Forms.Label();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.labelConfirm = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.panelRecord = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTransfer = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.txtNumberToTransfer = new System.Windows.Forms.TextBox();
            this.btnTransfered = new System.Windows.Forms.Button();
            this.labelNumberToTransfer = new System.Windows.Forms.Label();
            this.panelDeposit = new System.Windows.Forms.Panel();
            this.txtNumberToDeposit = new System.Windows.Forms.TextBox();
            this.btnDeposited = new System.Windows.Forms.Button();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.panelFetch = new System.Windows.Forms.Panel();
            this.txtNumberToFetch = new System.Windows.Forms.TextBox();
            this.btnFetched = new System.Windows.Forms.Button();
            this.labelFetch = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.btnIDInfo = new System.Windows.Forms.Button();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.panelOperate.SuspendLayout();
            this.panelIDInfo.SuspendLayout();
            this.panelChangePassword.SuspendLayout();
            this.panelRecord.SuspendLayout();
            this.panelTransfer.SuspendLayout();
            this.panelDeposit.SuspendLayout();
            this.panelFetch.SuspendLayout();
            this.panelOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(3, 0);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(111, 60);
            this.btnFetch.TabIndex = 0;
            this.btnFetch.Text = "取款";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(3, 66);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(111, 60);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "存款";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(3, 132);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(111, 60);
            this.btnTransfer.TabIndex = 2;
            this.btnTransfer.Text = "跨行转账";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(3, 264);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(111, 60);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "修改密码";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // panelOperate
            // 
            this.panelOperate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOperate.Controls.Add(this.panelIDInfo);
            this.panelOperate.Controls.Add(this.panelChangePassword);
            this.panelOperate.Controls.Add(this.panelRecord);
            this.panelOperate.Controls.Add(this.panelTransfer);
            this.panelOperate.Controls.Add(this.panelDeposit);
            this.panelOperate.Controls.Add(this.panelFetch);
            this.panelOperate.Location = new System.Drawing.Point(138, 12);
            this.panelOperate.Name = "panelOperate";
            this.panelOperate.Size = new System.Drawing.Size(557, 390);
            this.panelOperate.TabIndex = 4;
            // 
            // panelIDInfo
            // 
            this.panelIDInfo.Controls.Add(this.labelDate);
            this.panelIDInfo.Controls.Add(this.labelName);
            this.panelIDInfo.Controls.Add(this.labelRemainings);
            this.panelIDInfo.Location = new System.Drawing.Point(3, 312);
            this.panelIDInfo.Name = "panelIDInfo";
            this.panelIDInfo.Size = new System.Drawing.Size(240, 145);
            this.panelIDInfo.TabIndex = 5;
            this.panelIDInfo.Visible = false;
            // 
            // labelDate
            // 
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDate.Location = new System.Drawing.Point(0, 94);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(237, 25);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "注册日期：";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelName.Location = new System.Drawing.Point(0, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(237, 25);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "持卡人:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRemainings
            // 
            this.labelRemainings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRemainings.Location = new System.Drawing.Point(0, 55);
            this.labelRemainings.Name = "labelRemainings";
            this.labelRemainings.Size = new System.Drawing.Size(237, 25);
            this.labelRemainings.TabIndex = 3;
            this.labelRemainings.Text = "账户余额:";
            this.labelRemainings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.txtConfirm);
            this.panelChangePassword.Controls.Add(this.labelConfirm);
            this.panelChangePassword.Controls.Add(this.txtPassword);
            this.panelChangePassword.Controls.Add(this.btnChange);
            this.panelChangePassword.Controls.Add(this.labelPassword);
            this.panelChangePassword.Location = new System.Drawing.Point(18, 208);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(240, 145);
            this.panelChangePassword.TabIndex = 4;
            this.panelChangePassword.Visible = false;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirm.Location = new System.Drawing.Point(133, 50);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(94, 25);
            this.txtConfirm.TabIndex = 1;
            // 
            // labelConfirm
            // 
            this.labelConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelConfirm.Location = new System.Drawing.Point(23, 50);
            this.labelConfirm.Name = "labelConfirm";
            this.labelConfirm.Size = new System.Drawing.Size(94, 24);
            this.labelConfirm.TabIndex = 2;
            this.labelConfirm.Text = "确认新密码";
            this.labelConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(133, 18);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(94, 25);
            this.txtPassword.TabIndex = 0;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(68, 89);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(94, 45);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "确认修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPassword.Location = new System.Drawing.Point(23, 18);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(94, 24);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "新密码";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelRecord
            // 
            this.panelRecord.AutoScroll = true;
            this.panelRecord.Controls.Add(this.labelTitle);
            this.panelRecord.Location = new System.Drawing.Point(493, 234);
            this.panelRecord.Name = "panelRecord";
            this.panelRecord.Size = new System.Drawing.Size(540, 366);
            this.panelRecord.TabIndex = 3;
            this.panelRecord.Visible = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(3, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(500, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "     日期        金额       操作          目标账户       ";
            // 
            // panelTransfer
            // 
            this.panelTransfer.Controls.Add(this.btnConfirm);
            this.panelTransfer.Controls.Add(this.txtAccount);
            this.panelTransfer.Controls.Add(this.labelID);
            this.panelTransfer.Controls.Add(this.txtNumberToTransfer);
            this.panelTransfer.Controls.Add(this.btnTransfered);
            this.panelTransfer.Controls.Add(this.labelNumberToTransfer);
            this.panelTransfer.Location = new System.Drawing.Point(47, 31);
            this.panelTransfer.Name = "panelTransfer";
            this.panelTransfer.Size = new System.Drawing.Size(375, 224);
            this.panelTransfer.TabIndex = 2;
            this.panelTransfer.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(242, 38);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 25);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确认信息";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtAccount
            // 
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Location = new System.Drawing.Point(133, 38);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(94, 25);
            this.txtAccount.TabIndex = 3;
            // 
            // labelID
            // 
            this.labelID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelID.Location = new System.Drawing.Point(23, 39);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(94, 24);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "目标卡号";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumberToTransfer
            // 
            this.txtNumberToTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberToTransfer.Location = new System.Drawing.Point(133, 84);
            this.txtNumberToTransfer.Name = "txtNumberToTransfer";
            this.txtNumberToTransfer.Size = new System.Drawing.Size(94, 25);
            this.txtNumberToTransfer.TabIndex = 0;
            // 
            // btnTransfered
            // 
            this.btnTransfered.Location = new System.Drawing.Point(133, 150);
            this.btnTransfered.Name = "btnTransfered";
            this.btnTransfered.Size = new System.Drawing.Size(94, 45);
            this.btnTransfered.TabIndex = 1;
            this.btnTransfered.Text = "确认转账";
            this.btnTransfered.UseVisualStyleBackColor = true;
            this.btnTransfered.Click += new System.EventHandler(this.btnTransfered_Click);
            // 
            // labelNumberToTransfer
            // 
            this.labelNumberToTransfer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNumberToTransfer.Location = new System.Drawing.Point(23, 84);
            this.labelNumberToTransfer.Name = "labelNumberToTransfer";
            this.labelNumberToTransfer.Size = new System.Drawing.Size(94, 24);
            this.labelNumberToTransfer.TabIndex = 0;
            this.labelNumberToTransfer.Text = "转账金额";
            this.labelNumberToTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDeposit
            // 
            this.panelDeposit.Controls.Add(this.txtNumberToDeposit);
            this.panelDeposit.Controls.Add(this.btnDeposited);
            this.panelDeposit.Controls.Add(this.labelDeposit);
            this.panelDeposit.Location = new System.Drawing.Point(369, 12);
            this.panelDeposit.Name = "panelDeposit";
            this.panelDeposit.Size = new System.Drawing.Size(243, 148);
            this.panelDeposit.TabIndex = 1;
            this.panelDeposit.Visible = false;
            // 
            // txtNumberToDeposit
            // 
            this.txtNumberToDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberToDeposit.Location = new System.Drawing.Point(124, 19);
            this.txtNumberToDeposit.Name = "txtNumberToDeposit";
            this.txtNumberToDeposit.Size = new System.Drawing.Size(94, 25);
            this.txtNumberToDeposit.TabIndex = 0;
            // 
            // btnDeposited
            // 
            this.btnDeposited.Location = new System.Drawing.Point(124, 75);
            this.btnDeposited.Name = "btnDeposited";
            this.btnDeposited.Size = new System.Drawing.Size(94, 45);
            this.btnDeposited.TabIndex = 1;
            this.btnDeposited.Text = "确认存款";
            this.btnDeposited.UseVisualStyleBackColor = true;
            this.btnDeposited.Click += new System.EventHandler(this.btnDeposited_Click);
            // 
            // labelDeposit
            // 
            this.labelDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDeposit.Location = new System.Drawing.Point(14, 19);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(94, 24);
            this.labelDeposit.TabIndex = 0;
            this.labelDeposit.Text = "存款金额";
            this.labelDeposit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFetch
            // 
            this.panelFetch.Controls.Add(this.txtNumberToFetch);
            this.panelFetch.Controls.Add(this.btnFetched);
            this.panelFetch.Controls.Add(this.labelFetch);
            this.panelFetch.Location = new System.Drawing.Point(222, 261);
            this.panelFetch.Name = "panelFetch";
            this.panelFetch.Size = new System.Drawing.Size(240, 145);
            this.panelFetch.TabIndex = 0;
            this.panelFetch.Visible = false;
            // 
            // txtNumberToFetch
            // 
            this.txtNumberToFetch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumberToFetch.Location = new System.Drawing.Point(133, 18);
            this.txtNumberToFetch.Name = "txtNumberToFetch";
            this.txtNumberToFetch.Size = new System.Drawing.Size(94, 25);
            this.txtNumberToFetch.TabIndex = 0;
            // 
            // btnFetched
            // 
            this.btnFetched.Location = new System.Drawing.Point(133, 74);
            this.btnFetched.Name = "btnFetched";
            this.btnFetched.Size = new System.Drawing.Size(94, 45);
            this.btnFetched.TabIndex = 1;
            this.btnFetched.Text = "确认取款";
            this.btnFetched.UseVisualStyleBackColor = true;
            this.btnFetched.Click += new System.EventHandler(this.btnFetched_Click);
            // 
            // labelFetch
            // 
            this.labelFetch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFetch.Location = new System.Drawing.Point(23, 18);
            this.labelFetch.Name = "labelFetch";
            this.labelFetch.Size = new System.Drawing.Size(94, 24);
            this.labelFetch.TabIndex = 0;
            this.labelFetch.Text = "取款金额";
            this.labelFetch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(111, 60);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "返回";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(3, 198);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(111, 60);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "操作纪录";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatus.Location = new System.Drawing.Point(138, 408);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(557, 120);
            this.panelStatus.TabIndex = 5;
            // 
            // btnIDInfo
            // 
            this.btnIDInfo.Location = new System.Drawing.Point(3, 330);
            this.btnIDInfo.Name = "btnIDInfo";
            this.btnIDInfo.Size = new System.Drawing.Size(111, 60);
            this.btnIDInfo.TabIndex = 5;
            this.btnIDInfo.Text = "账户资料";
            this.btnIDInfo.UseVisualStyleBackColor = true;
            this.btnIDInfo.Click += new System.EventHandler(this.btnIDInfo_Click);
            // 
            // panelOperations
            // 
            this.panelOperations.Controls.Add(this.btnFetch);
            this.panelOperations.Controls.Add(this.btnIDInfo);
            this.panelOperations.Controls.Add(this.btnDeposit);
            this.panelOperations.Controls.Add(this.btnTransfer);
            this.panelOperations.Controls.Add(this.btnRecord);
            this.panelOperations.Controls.Add(this.btnChangePassword);
            this.panelOperations.Location = new System.Drawing.Point(12, 127);
            this.panelOperations.Name = "panelOperations";
            this.panelOperations.Size = new System.Drawing.Size(120, 401);
            this.panelOperations.TabIndex = 7;
            // 
            // PersonalCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 540);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelOperate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalCentre";
            this.Text = "PersonalCentre";
            this.panelOperate.ResumeLayout(false);
            this.panelIDInfo.ResumeLayout(false);
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.panelRecord.ResumeLayout(false);
            this.panelRecord.PerformLayout();
            this.panelTransfer.ResumeLayout(false);
            this.panelTransfer.PerformLayout();
            this.panelDeposit.ResumeLayout(false);
            this.panelDeposit.PerformLayout();
            this.panelFetch.ResumeLayout(false);
            this.panelFetch.PerformLayout();
            this.panelOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Panel panelOperate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelFetch;
        private System.Windows.Forms.Button btnFetched;
        private System.Windows.Forms.Label labelFetch;
        private System.Windows.Forms.Button btnIDInfo;
        private System.Windows.Forms.TextBox txtNumberToFetch;
        private System.Windows.Forms.Label labelRemainings;
        private System.Windows.Forms.Panel panelDeposit;
        private System.Windows.Forms.TextBox txtNumberToDeposit;
        private System.Windows.Forms.Button btnDeposited;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Panel panelIDInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panelTransfer;
        private System.Windows.Forms.TextBox txtNumberToTransfer;
        private System.Windows.Forms.Button btnTransfered;
        private System.Windows.Forms.Label labelNumberToTransfer;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Panel panelRecord;
        private System.Windows.Forms.Label labelConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDate;
    }
}
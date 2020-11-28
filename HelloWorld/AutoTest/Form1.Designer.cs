namespace AutoTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RBtnA = new System.Windows.Forms.RadioButton();
            this.RBtnB = new System.Windows.Forms.RadioButton();
            this.RBtnC = new System.Windows.Forms.RadioButton();
            this.RBtnD = new System.Windows.Forms.RadioButton();
            this.LabelQuestion = new System.Windows.Forms.Label();
            this.LabelAns = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelCountdown = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LabelRes = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.RBtnA);
            this.flowLayoutPanel1.Controls.Add(this.RBtnB);
            this.flowLayoutPanel1.Controls.Add(this.RBtnC);
            this.flowLayoutPanel1.Controls.Add(this.RBtnD);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 151);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(664, 42);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // RBtnA
            // 
            this.RBtnA.Font = new System.Drawing.Font("RomanD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnA.Location = new System.Drawing.Point(3, 3);
            this.RBtnA.Name = "RBtnA";
            this.RBtnA.Size = new System.Drawing.Size(150, 24);
            this.RBtnA.TabIndex = 0;
            this.RBtnA.Text = "A ";
            this.RBtnA.UseVisualStyleBackColor = true;
            this.RBtnA.CheckedChanged += new System.EventHandler(this.RBtnA_CheckedChanged);
            // 
            // RBtnB
            // 
            this.RBtnB.Font = new System.Drawing.Font("RomanD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnB.Location = new System.Drawing.Point(159, 3);
            this.RBtnB.Name = "RBtnB";
            this.RBtnB.Size = new System.Drawing.Size(150, 24);
            this.RBtnB.TabIndex = 1;
            this.RBtnB.Text = "B ";
            this.RBtnB.UseVisualStyleBackColor = true;
            this.RBtnB.CheckedChanged += new System.EventHandler(this.RBtnB_CheckedChanged);
            // 
            // RBtnC
            // 
            this.RBtnC.Font = new System.Drawing.Font("RomanD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnC.Location = new System.Drawing.Point(315, 3);
            this.RBtnC.Name = "RBtnC";
            this.RBtnC.Size = new System.Drawing.Size(150, 24);
            this.RBtnC.TabIndex = 2;
            this.RBtnC.Text = "C ";
            this.RBtnC.UseVisualStyleBackColor = true;
            this.RBtnC.CheckedChanged += new System.EventHandler(this.RBtnC_CheckedChanged);
            // 
            // RBtnD
            // 
            this.RBtnD.Font = new System.Drawing.Font("RomanD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBtnD.Location = new System.Drawing.Point(471, 3);
            this.RBtnD.Name = "RBtnD";
            this.RBtnD.Size = new System.Drawing.Size(150, 24);
            this.RBtnD.TabIndex = 3;
            this.RBtnD.Text = "D ";
            this.RBtnD.UseVisualStyleBackColor = true;
            this.RBtnD.CheckedChanged += new System.EventHandler(this.RBtnD_CheckedChanged);
            // 
            // LabelQuestion
            // 
            this.LabelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelQuestion.Font = new System.Drawing.Font("RomanD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuestion.Location = new System.Drawing.Point(7, 51);
            this.LabelQuestion.Name = "LabelQuestion";
            this.LabelQuestion.Size = new System.Drawing.Size(558, 97);
            this.LabelQuestion.TabIndex = 1;
            this.LabelQuestion.Text = "timu";
            this.LabelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelAns
            // 
            this.LabelAns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelAns.Font = new System.Drawing.Font("RomanD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAns.Location = new System.Drawing.Point(7, 196);
            this.LabelAns.Name = "LabelAns";
            this.LabelAns.Size = new System.Drawing.Size(664, 97);
            this.LabelAns.TabIndex = 2;
            this.LabelAns.Text = "daan";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LabelCountdown
            // 
            this.LabelCountdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelCountdown.Font = new System.Drawing.Font("RomanD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCountdown.Location = new System.Drawing.Point(571, 51);
            this.LabelCountdown.Name = "LabelCountdown";
            this.LabelCountdown.Size = new System.Drawing.Size(100, 97);
            this.LabelCountdown.TabIndex = 3;
            this.LabelCountdown.Text = "daojishi";
            this.LabelCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(7, 12);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(85, 36);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "开始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(539, 244);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(119, 35);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = "好的，下一题";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Visible = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LabelRes
            // 
            this.LabelRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelRes.Font = new System.Drawing.Font("RomanD", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRes.Location = new System.Drawing.Point(7, 302);
            this.LabelRes.Name = "LabelRes";
            this.LabelRes.Size = new System.Drawing.Size(664, 223);
            this.LabelRes.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 534);
            this.Controls.Add(this.LabelRes);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LabelCountdown);
            this.Controls.Add(this.LabelAns);
            this.Controls.Add(this.LabelQuestion);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton RBtnA;
        private System.Windows.Forms.RadioButton RBtnB;
        private System.Windows.Forms.RadioButton RBtnC;
        private System.Windows.Forms.RadioButton RBtnD;
        private System.Windows.Forms.Label LabelQuestion;
        private System.Windows.Forms.Label LabelAns;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelCountdown;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label LabelRes;
    }
}


namespace MyCrawler
{
    partial class MyCrawler
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
            this.lblSearching = new System.Windows.Forms.Label();
            this.StartKeyWordText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endBtn = new System.Windows.Forms.Button();
            this.MsgListBox = new System.Windows.Forms.ListBox();
            this.StartUrlText = new System.Windows.Forms.TextBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StartEngine = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSearching
            // 
            this.lblSearching.AutoSize = true;
            this.lblSearching.Location = new System.Drawing.Point(10, 80);
            this.lblSearching.Name = "lblSearching";
            this.lblSearching.Size = new System.Drawing.Size(59, 12);
            this.lblSearching.TabIndex = 26;
            this.lblSearching.Text = "搜索中...";
            // 
            // StartKeyWordText
            // 
            this.StartKeyWordText.Location = new System.Drawing.Point(203, 49);
            this.StartKeyWordText.Margin = new System.Windows.Forms.Padding(2);
            this.StartKeyWordText.Name = "StartKeyWordText";
            this.StartKeyWordText.Size = new System.Drawing.Size(312, 21);
            this.StartKeyWordText.TabIndex = 22;
            this.StartKeyWordText.TextChanged += new System.EventHandler(this.StartKeyWordText_TextChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "搜索关键词   请输入关键词：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "搜索邮箱   请输入网址：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endBtn
            // 
            this.endBtn.Location = new System.Drawing.Point(661, 261);
            this.endBtn.Margin = new System.Windows.Forms.Padding(2);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(97, 26);
            this.endBtn.TabIndex = 19;
            this.endBtn.Text = "结束";
            this.endBtn.UseVisualStyleBackColor = true;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // MsgListBox
            // 
            this.MsgListBox.FormattingEnabled = true;
            this.MsgListBox.ItemHeight = 12;
            this.MsgListBox.Location = new System.Drawing.Point(10, 97);
            this.MsgListBox.Margin = new System.Windows.Forms.Padding(2);
            this.MsgListBox.Name = "MsgListBox";
            this.MsgListBox.Size = new System.Drawing.Size(749, 160);
            this.MsgListBox.TabIndex = 18;
            // 
            // StartUrlText
            // 
            this.StartUrlText.Location = new System.Drawing.Point(203, 10);
            this.StartUrlText.Margin = new System.Windows.Forms.Padding(2);
            this.StartUrlText.Name = "StartUrlText";
            this.StartUrlText.Size = new System.Drawing.Size(312, 21);
            this.StartUrlText.TabIndex = 17;
            this.StartUrlText.TextChanged += new System.EventHandler(this.StartUrlText_TextChanged);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(662, 73);
            this.startBtn.Margin = new System.Windows.Forms.Padding(2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(97, 22);
            this.startBtn.TabIndex = 16;
            this.startBtn.Text = "开始";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(519, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "搜索引擎";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartEngine
            // 
            this.StartEngine.FormattingEnabled = true;
            this.StartEngine.Items.AddRange(new object[] {
            "360",
            "Bing",
            "百度"});
            this.StartEngine.Location = new System.Drawing.Point(602, 12);
            this.StartEngine.Name = "StartEngine";
            this.StartEngine.Size = new System.Drawing.Size(156, 20);
            this.StartEngine.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 292);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(747, 352);
            this.listBox1.TabIndex = 27;
            // 
            // MyCrawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 652);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblSearching);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartEngine);
            this.Controls.Add(this.StartKeyWordText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.MsgListBox);
            this.Controls.Add(this.StartUrlText);
            this.Controls.Add(this.startBtn);
            this.Name = "MyCrawler";
            this.Text = "爬虫";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearching;
        private System.Windows.Forms.TextBox StartKeyWordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.ListBox MsgListBox;
        private System.Windows.Forms.TextBox StartUrlText;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StartEngine;
        private System.Windows.Forms.ListBox listBox1;
    }
}


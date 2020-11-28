namespace Format
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
            this.OpenFD = new System.Windows.Forms.OpenFileDialog();
            this.btn_open = new System.Windows.Forms.Button();
            this.rtB_NewFile = new System.Windows.Forms.RichTextBox();
            this.rTB_oldFile = new System.Windows.Forms.RichTextBox();
            this.lbl_oldFileWords = new System.Windows.Forms.Label();
            this.lbl_oldFileLines = new System.Windows.Forms.Label();
            this.lbl_newFileWords = new System.Windows.Forms.Label();
            this.lbl_newFileLines = new System.Windows.Forms.Label();
            this.btn_genrate = new System.Windows.Forms.Button();
            this.dgv_rate = new System.Windows.Forms.DataGridView();
            this.flpanel_oldFile = new System.Windows.Forms.FlowLayoutPanel();
            this.flpanel_newFile = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_countRates = new System.Windows.Forms.Button();
            this.word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rate)).BeginInit();
            this.flpanel_oldFile.SuspendLayout();
            this.flpanel_newFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFD
            // 
            this.OpenFD.FileName = "openFileDialog1";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(12, 12);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(104, 41);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "选择文件";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // rtB_NewFile
            // 
            this.rtB_NewFile.Location = new System.Drawing.Point(410, 59);
            this.rtB_NewFile.Name = "rtB_NewFile";
            this.rtB_NewFile.ReadOnly = true;
            this.rtB_NewFile.Size = new System.Drawing.Size(392, 519);
            this.rtB_NewFile.TabIndex = 3;
            this.rtB_NewFile.TabStop = false;
            this.rtB_NewFile.Text = "";
            this.rtB_NewFile.WordWrap = false;
            // 
            // rTB_oldFile
            // 
            this.rTB_oldFile.Location = new System.Drawing.Point(12, 59);
            this.rTB_oldFile.Name = "rTB_oldFile";
            this.rTB_oldFile.ReadOnly = true;
            this.rTB_oldFile.Size = new System.Drawing.Size(392, 516);
            this.rTB_oldFile.TabIndex = 4;
            this.rTB_oldFile.TabStop = false;
            this.rTB_oldFile.Text = "";
            this.rTB_oldFile.WordWrap = false;
            // 
            // lbl_oldFileWords
            // 
            this.lbl_oldFileWords.AutoSize = true;
            this.lbl_oldFileWords.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_oldFileWords.Location = new System.Drawing.Point(276, 0);
            this.lbl_oldFileWords.Name = "lbl_oldFileWords";
            this.lbl_oldFileWords.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.lbl_oldFileWords.Size = new System.Drawing.Size(62, 26);
            this.lbl_oldFileWords.TabIndex = 2;
            this.lbl_oldFileWords.Text = "单词数";
            // 
            // lbl_oldFileLines
            // 
            this.lbl_oldFileLines.AutoSize = true;
            this.lbl_oldFileLines.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_oldFileLines.Location = new System.Drawing.Point(344, 0);
            this.lbl_oldFileLines.Name = "lbl_oldFileLines";
            this.lbl_oldFileLines.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.lbl_oldFileLines.Size = new System.Drawing.Size(45, 26);
            this.lbl_oldFileLines.TabIndex = 0;
            this.lbl_oldFileLines.Text = "行数";
            // 
            // lbl_newFileWords
            // 
            this.lbl_newFileWords.AutoSize = true;
            this.lbl_newFileWords.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_newFileWords.Location = new System.Drawing.Point(276, 0);
            this.lbl_newFileWords.Name = "lbl_newFileWords";
            this.lbl_newFileWords.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.lbl_newFileWords.Size = new System.Drawing.Size(62, 26);
            this.lbl_newFileWords.TabIndex = 1;
            this.lbl_newFileWords.Text = "单词数";
            // 
            // lbl_newFileLines
            // 
            this.lbl_newFileLines.AutoSize = true;
            this.lbl_newFileLines.Font = new System.Drawing.Font("宋体", 10F);
            this.lbl_newFileLines.Location = new System.Drawing.Point(344, 0);
            this.lbl_newFileLines.Name = "lbl_newFileLines";
            this.lbl_newFileLines.Padding = new System.Windows.Forms.Padding(3, 9, 0, 0);
            this.lbl_newFileLines.Size = new System.Drawing.Size(45, 26);
            this.lbl_newFileLines.TabIndex = 0;
            this.lbl_newFileLines.Text = "行数";
            // 
            // btn_genrate
            // 
            this.btn_genrate.Location = new System.Drawing.Point(410, 14);
            this.btn_genrate.Name = "btn_genrate";
            this.btn_genrate.Size = new System.Drawing.Size(104, 41);
            this.btn_genrate.TabIndex = 1;
            this.btn_genrate.Text = "格式化文件";
            this.btn_genrate.UseVisualStyleBackColor = true;
            this.btn_genrate.Click += new System.EventHandler(this.btn_genrate_Click);
            // 
            // dgv_rate
            // 
            this.dgv_rate.AllowUserToResizeRows = false;
            this.dgv_rate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rate.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_rate.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_rate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_rate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.word,
            this.rate});
            this.dgv_rate.Location = new System.Drawing.Point(809, 59);
            this.dgv_rate.Name = "dgv_rate";
            this.dgv_rate.ReadOnly = true;
            this.dgv_rate.RowHeadersVisible = false;
            this.dgv_rate.RowTemplate.Height = 27;
            this.dgv_rate.Size = new System.Drawing.Size(332, 519);
            this.dgv_rate.TabIndex = 8;
            this.dgv_rate.TabStop = false;
            // 
            // flpanel_oldFile
            // 
            this.flpanel_oldFile.Controls.Add(this.lbl_oldFileLines);
            this.flpanel_oldFile.Controls.Add(this.lbl_oldFileWords);
            this.flpanel_oldFile.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpanel_oldFile.Location = new System.Drawing.Point(12, 581);
            this.flpanel_oldFile.Name = "flpanel_oldFile";
            this.flpanel_oldFile.Size = new System.Drawing.Size(392, 41);
            this.flpanel_oldFile.TabIndex = 9;
            // 
            // flpanel_newFile
            // 
            this.flpanel_newFile.Controls.Add(this.lbl_newFileLines);
            this.flpanel_newFile.Controls.Add(this.lbl_newFileWords);
            this.flpanel_newFile.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpanel_newFile.Location = new System.Drawing.Point(410, 581);
            this.flpanel_newFile.Name = "flpanel_newFile";
            this.flpanel_newFile.Size = new System.Drawing.Size(392, 41);
            this.flpanel_newFile.TabIndex = 10;
            // 
            // btn_countRates
            // 
            this.btn_countRates.Location = new System.Drawing.Point(809, 14);
            this.btn_countRates.Name = "btn_countRates";
            this.btn_countRates.Size = new System.Drawing.Size(125, 41);
            this.btn_countRates.TabIndex = 2;
            this.btn_countRates.Text = "统计单词频率";
            this.btn_countRates.UseVisualStyleBackColor = true;
            this.btn_countRates.Click += new System.EventHandler(this.btn_countRates_Click);
            // 
            // word
            // 
            this.word.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.word.FillWeight = 134.0102F;
            this.word.HeaderText = "单词";
            this.word.Name = "word";
            this.word.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.FillWeight = 65.98985F;
            this.rate.HeaderText = "频率";
            this.rate.MinimumWidth = 3;
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 634);
            this.Controls.Add(this.btn_countRates);
            this.Controls.Add(this.flpanel_oldFile);
            this.Controls.Add(this.dgv_rate);
            this.Controls.Add(this.flpanel_newFile);
            this.Controls.Add(this.btn_genrate);
            this.Controls.Add(this.rTB_oldFile);
            this.Controls.Add(this.rtB_NewFile);
            this.Controls.Add(this.btn_open);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rate)).EndInit();
            this.flpanel_oldFile.ResumeLayout(false);
            this.flpanel_oldFile.PerformLayout();
            this.flpanel_newFile.ResumeLayout(false);
            this.flpanel_newFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFD;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.RichTextBox rtB_NewFile;
        private System.Windows.Forms.RichTextBox rTB_oldFile;
        private System.Windows.Forms.Label lbl_oldFileLines;
        private System.Windows.Forms.Label lbl_newFileWords;
        private System.Windows.Forms.Label lbl_newFileLines;
        private System.Windows.Forms.Button btn_genrate;
        private System.Windows.Forms.Label lbl_oldFileWords;
        private System.Windows.Forms.DataGridView dgv_rate;
        private System.Windows.Forms.FlowLayoutPanel flpanel_oldFile;
        private System.Windows.Forms.FlowLayoutPanel flpanel_newFile;
        private System.Windows.Forms.Button btn_countRates;
        private System.Windows.Forms.DataGridViewTextBoxColumn word;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
    }
}


namespace StuManageSys
{
    partial class StuManageSys
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_searchSchool = new System.Windows.Forms.Button();
            this.Btn_modifySchool = new System.Windows.Forms.Button();
            this.Btn_deleteSchool = new System.Windows.Forms.Button();
            this.Btn_addSchool = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_searchClass = new System.Windows.Forms.Button();
            this.Btn_addClass = new System.Windows.Forms.Button();
            this.Btn_modifyClass = new System.Windows.Forms.Button();
            this.Btn_deleteClass = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_searchStudent = new System.Windows.Forms.Button();
            this.Btn_addStudent = new System.Windows.Forms.Button();
            this.Btn_modifyStudent = new System.Windows.Forms.Button();
            this.Btn_deleteStudent = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Btn_searchLog = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(364, 358);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "学校";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_searchSchool);
            this.panel1.Controls.Add(this.Btn_modifySchool);
            this.panel1.Controls.Add(this.Btn_deleteSchool);
            this.panel1.Controls.Add(this.Btn_addSchool);
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 392);
            this.panel1.TabIndex = 1;
            // 
            // Btn_searchSchool
            // 
            this.Btn_searchSchool.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_searchSchool.Location = new System.Drawing.Point(112, 175);
            this.Btn_searchSchool.Name = "Btn_searchSchool";
            this.Btn_searchSchool.Size = new System.Drawing.Size(133, 44);
            this.Btn_searchSchool.TabIndex = 3;
            this.Btn_searchSchool.Text = "查";
            this.Btn_searchSchool.UseVisualStyleBackColor = true;
            this.Btn_searchSchool.Click += new System.EventHandler(this.Btn_searchSchool_Click);
            // 
            // Btn_modifySchool
            // 
            this.Btn_modifySchool.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_modifySchool.Location = new System.Drawing.Point(112, 125);
            this.Btn_modifySchool.Name = "Btn_modifySchool";
            this.Btn_modifySchool.Size = new System.Drawing.Size(133, 44);
            this.Btn_modifySchool.TabIndex = 2;
            this.Btn_modifySchool.Text = "改";
            this.Btn_modifySchool.UseVisualStyleBackColor = true;
            this.Btn_modifySchool.Click += new System.EventHandler(this.Btn_modifySchool_Click);
            // 
            // Btn_deleteSchool
            // 
            this.Btn_deleteSchool.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_deleteSchool.Location = new System.Drawing.Point(112, 75);
            this.Btn_deleteSchool.Name = "Btn_deleteSchool";
            this.Btn_deleteSchool.Size = new System.Drawing.Size(133, 44);
            this.Btn_deleteSchool.TabIndex = 1;
            this.Btn_deleteSchool.Text = "删";
            this.Btn_deleteSchool.UseVisualStyleBackColor = true;
            this.Btn_deleteSchool.Click += new System.EventHandler(this.Btn_deleteSchool_Click);
            // 
            // Btn_addSchool
            // 
            this.Btn_addSchool.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_addSchool.Location = new System.Drawing.Point(112, 25);
            this.Btn_addSchool.Name = "Btn_addSchool";
            this.Btn_addSchool.Size = new System.Drawing.Size(133, 44);
            this.Btn_addSchool.TabIndex = 0;
            this.Btn_addSchool.Text = "增";
            this.Btn_addSchool.UseVisualStyleBackColor = true;
            this.Btn_addSchool.Click += new System.EventHandler(this.Btn_addSchool_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(383, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(364, 358);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "班级";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Btn_searchClass);
            this.panel2.Controls.Add(this.Btn_addClass);
            this.panel2.Controls.Add(this.Btn_modifyClass);
            this.panel2.Controls.Add(this.Btn_deleteClass);
            this.panel2.Location = new System.Drawing.Point(3, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 392);
            this.panel2.TabIndex = 2;
            // 
            // Btn_searchClass
            // 
            this.Btn_searchClass.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_searchClass.Location = new System.Drawing.Point(106, 175);
            this.Btn_searchClass.Name = "Btn_searchClass";
            this.Btn_searchClass.Size = new System.Drawing.Size(133, 44);
            this.Btn_searchClass.TabIndex = 7;
            this.Btn_searchClass.Text = "查";
            this.Btn_searchClass.UseVisualStyleBackColor = true;
            this.Btn_searchClass.Click += new System.EventHandler(this.Btn_searchClass_Click);
            // 
            // Btn_addClass
            // 
            this.Btn_addClass.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_addClass.Location = new System.Drawing.Point(106, 25);
            this.Btn_addClass.Name = "Btn_addClass";
            this.Btn_addClass.Size = new System.Drawing.Size(133, 44);
            this.Btn_addClass.TabIndex = 4;
            this.Btn_addClass.Text = "增";
            this.Btn_addClass.UseVisualStyleBackColor = true;
            this.Btn_addClass.Click += new System.EventHandler(this.Btn_addClass_Click);
            // 
            // Btn_modifyClass
            // 
            this.Btn_modifyClass.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_modifyClass.Location = new System.Drawing.Point(106, 125);
            this.Btn_modifyClass.Name = "Btn_modifyClass";
            this.Btn_modifyClass.Size = new System.Drawing.Size(133, 44);
            this.Btn_modifyClass.TabIndex = 6;
            this.Btn_modifyClass.Text = "改";
            this.Btn_modifyClass.UseVisualStyleBackColor = true;
            this.Btn_modifyClass.Click += new System.EventHandler(this.Btn_modifyClass_Click);
            // 
            // Btn_deleteClass
            // 
            this.Btn_deleteClass.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_deleteClass.Location = new System.Drawing.Point(106, 75);
            this.Btn_deleteClass.Name = "Btn_deleteClass";
            this.Btn_deleteClass.Size = new System.Drawing.Size(133, 44);
            this.Btn_deleteClass.TabIndex = 5;
            this.Btn_deleteClass.Text = "删";
            this.Btn_deleteClass.UseVisualStyleBackColor = true;
            this.Btn_deleteClass.Click += new System.EventHandler(this.Btn_deleteClass_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.panel3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(753, 12);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(364, 366);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "学生";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Btn_searchStudent);
            this.panel3.Controls.Add(this.Btn_addStudent);
            this.panel3.Controls.Add(this.Btn_modifyStudent);
            this.panel3.Controls.Add(this.Btn_deleteStudent);
            this.panel3.Location = new System.Drawing.Point(3, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 392);
            this.panel3.TabIndex = 2;
            // 
            // Btn_searchStudent
            // 
            this.Btn_searchStudent.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_searchStudent.Location = new System.Drawing.Point(114, 175);
            this.Btn_searchStudent.Name = "Btn_searchStudent";
            this.Btn_searchStudent.Size = new System.Drawing.Size(133, 44);
            this.Btn_searchStudent.TabIndex = 11;
            this.Btn_searchStudent.Text = "查";
            this.Btn_searchStudent.UseVisualStyleBackColor = true;
            this.Btn_searchStudent.Click += new System.EventHandler(this.Btn_searchStudent_Click);
            // 
            // Btn_addStudent
            // 
            this.Btn_addStudent.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_addStudent.Location = new System.Drawing.Point(114, 25);
            this.Btn_addStudent.Name = "Btn_addStudent";
            this.Btn_addStudent.Size = new System.Drawing.Size(133, 44);
            this.Btn_addStudent.TabIndex = 8;
            this.Btn_addStudent.Text = "增";
            this.Btn_addStudent.UseVisualStyleBackColor = true;
            this.Btn_addStudent.Click += new System.EventHandler(this.Btn_addStudent_Click);
            // 
            // Btn_modifyStudent
            // 
            this.Btn_modifyStudent.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_modifyStudent.Location = new System.Drawing.Point(114, 125);
            this.Btn_modifyStudent.Name = "Btn_modifyStudent";
            this.Btn_modifyStudent.Size = new System.Drawing.Size(133, 44);
            this.Btn_modifyStudent.TabIndex = 10;
            this.Btn_modifyStudent.Text = "改";
            this.Btn_modifyStudent.UseVisualStyleBackColor = true;
            this.Btn_modifyStudent.Click += new System.EventHandler(this.Btn_modifyStudent_Click);
            // 
            // Btn_deleteStudent
            // 
            this.Btn_deleteStudent.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_deleteStudent.Location = new System.Drawing.Point(114, 75);
            this.Btn_deleteStudent.Name = "Btn_deleteStudent";
            this.Btn_deleteStudent.Size = new System.Drawing.Size(133, 44);
            this.Btn_deleteStudent.TabIndex = 9;
            this.Btn_deleteStudent.Text = "删";
            this.Btn_deleteStudent.UseVisualStyleBackColor = true;
            this.Btn_deleteStudent.Click += new System.EventHandler(this.Btn_deleteStudent_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.listBox);
            this.flowLayoutPanel4.Controls.Add(this.textBox);
            this.flowLayoutPanel4.Controls.Add(this.Btn_searchLog);
            this.flowLayoutPanel4.Controls.Add(this.Btn_reset);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(10, 376);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1104, 350);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1098, 46);
            this.label4.TabIndex = 12;
            this.label4.Text = "操作记录";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(3, 52);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1098, 232);
            this.listBox.TabIndex = 13;
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.textBox.Location = new System.Drawing.Point(3, 290);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(835, 29);
            this.textBox.TabIndex = 14;
            // 
            // Btn_searchLog
            // 
            this.Btn_searchLog.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_searchLog.Location = new System.Drawing.Point(844, 290);
            this.Btn_searchLog.Name = "Btn_searchLog";
            this.Btn_searchLog.Size = new System.Drawing.Size(165, 29);
            this.Btn_searchLog.TabIndex = 15;
            this.Btn_searchLog.Text = "查询";
            this.Btn_searchLog.UseVisualStyleBackColor = true;
            this.Btn_searchLog.Click += new System.EventHandler(this.Btn_searchLog_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Btn_reset.Location = new System.Drawing.Point(1015, 290);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(72, 29);
            this.Btn_reset.TabIndex = 16;
            this.Btn_reset.Text = "重置";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // StuManageSys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 738);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "StuManageSys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生管理系统";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_searchSchool;
        private System.Windows.Forms.Button Btn_modifySchool;
        private System.Windows.Forms.Button Btn_deleteSchool;
        private System.Windows.Forms.Button Btn_addSchool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_searchClass;
        private System.Windows.Forms.Button Btn_addClass;
        private System.Windows.Forms.Button Btn_modifyClass;
        private System.Windows.Forms.Button Btn_deleteClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Btn_searchStudent;
        private System.Windows.Forms.Button Btn_addStudent;
        private System.Windows.Forms.Button Btn_modifyStudent;
        private System.Windows.Forms.Button Btn_deleteStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Btn_searchLog;
        private System.Windows.Forms.Button Btn_reset;
    }
}


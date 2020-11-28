using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LabelQuestion.Text = "准备好开始答题了吗，点击开始";
            LabelCountdown.Text = "倒计时";
            LabelAns.Text = "";
            RBtnA.Enabled = false;
            RBtnB.Enabled = false;
            RBtnC.Enabled = false;
            RBtnD.Enabled = false;
            RBtnA.Checked = false;
            RBtnB.Checked = false;
            RBtnC.Checked = false;
            RBtnD.Checked = false;
        }
        public static int Limit = 10;//每题限制时间
        public static int Point = 1;//每题分数
        public static int Number = 10;//题目总数
        public int numOfQuestion = 0;//题号
        public string question;//当前题目
        public string[] totalQuestion = new string[10];//全部题目
        public int ans;//当前题目答案
        public int[] totalAns = new int[10];//全部答案
        public string index;//当前答案选项
        public string[] totalIndex = new string[10];//全部答案所在选项
        public int limitTime = Limit;//倒计时
        public int score = 0;//得分
        public bool Start = false;//开始
        public bool End = false;//结束
        
        //自动跳题
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Start && !End)
            {
                limitTime--;
                LabelCountdown.Text = "" + limitTime;
                if (limitTime == 0)
                {
                    if (numOfQuestion == Number)
                    {
                        endTest();
                        numOfQuestion = 0;
                    }
                    if (numOfQuestion >= Number)//防止用户点击过快导致越界问题
                    {
                        BtnNext.Visible = false;
                    }
                    autoRandom(question,ref ans,ref numOfQuestion);                    
                    numOfQuestion++;
                    limitTime = Limit;
                }
            }
        }

        //自动出题
        public void autoRandom(string s, ref int ans,ref int numOfQuestion)
        {            
            Random random = new Random();
            //随机生成加减运算符  0为+ 1为-
            int opt = random.Next(0, 2);
            //随机生成运算数
            int[] op = new int[2];
            for(int i = 0; i < 2; i++)
            {
                op[i] = random.Next(1,1000);
            }
            //生成题目 及 答案
            if (opt == 0)
            {
                s = op[0] + "+" + op[1];
                ans = op[0] + op[1];
            }
            else
            {
                s = op[0] + "-" + op[1];
                ans = op[0] - op[1];
            }
            LabelQuestion.Text = numOfQuestion + 1 + ". " + s;
            totalQuestion[numOfQuestion] = s;
            totalAns[numOfQuestion] = ans;
            //生成选项
            RBtnA.Enabled = true;
            RBtnB.Enabled = true;
            RBtnC.Enabled = true;
            RBtnD.Enabled = true;
            RBtnA.Checked = false;
            RBtnB.Checked = false;
            RBtnC.Checked = false;
            RBtnD.Checked = false;
            LabelAns.Text = "";
            switch (random.Next(1, 5))
            {
                case 1:
                    index = "A";
                    RBtnA.Text = "A " + ans;
                    RBtnB.Text = "B " + (ans + random.Next(1,10));
                    RBtnC.Text = "C " + (ans + random.Next(20, 30));
                    RBtnD.Text = "D " + (ans + random.Next(10, 20));
                    break;
                case 2:
                    index = "B";
                    RBtnA.Text = "A " + (ans - random.Next(1, 10));
                    RBtnB.Text = "B " + ans;
                    RBtnC.Text = "C " + (ans + random.Next(10, 20));
                    RBtnD.Text = "D " + (ans + random.Next(20, 30));
                    break;
                case 3:
                    index = "C";
                    RBtnA.Text = "A " + (ans - random.Next(20, 30));
                    RBtnB.Text = "B " + (ans - random.Next(10, 20));
                    RBtnC.Text = "C " + ans;
                    RBtnD.Text = "D " + (ans + random.Next(1, 10));
                    break;
                case 4:
                    index = "D";
                    RBtnA.Text = "A " + (ans - random.Next(10, 20));
                    RBtnB.Text = "B " + (ans - random.Next(20, 30));
                    RBtnC.Text = "C " + (ans - random.Next(1, 10));
                    RBtnD.Text = "D " + ans;
                    break;
                default:
                    break;
            }
            totalIndex[numOfQuestion] = index;
        }

        //实时改题
        public void Check(object sender)
        {
            if (numOfQuestion >= 10) { BtnNext.Text = "结束"; }
            else { BtnNext.Text = "好的，下一题"; }
            BtnNext.Visible = true;
            RadioButton RBtn = sender as RadioButton;
            if (RBtn.Text[0] +""== index)
            {
                LabelAns.Text = "回答正确";
                score++;
            }
            else
            {
                LabelAns.Text = "回答错误,正确选项为" + index + " " + ans;
            }
            RBtnA.Enabled = false;
            RBtnB.Enabled = false;
            RBtnC.Enabled = false;
            RBtnD.Enabled = false;
        }

        //结束
        public void endTest()
        {
            End = true;
            limitTime = Limit;
            numOfQuestion = 0;
            LabelRes.Text = "最终得分:" + score;
        }

        private void RBtnA_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnA.Checked == true)
            {
                Check(sender);
            }
        }

        private void RBtnB_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnB.Checked == true)
            {
                Check(sender);
            }
        }

        private void RBtnC_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnC.Checked == true)
            {
                Check(sender);
            }
        }

        private void RBtnD_CheckedChanged(object sender, EventArgs e)
        {
            if (RBtnD.Checked == true)
            {
                Check(sender);
            }
        }

        //开始测试
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!End && !Start)
            {
                BtnNext.Visible = false;
                autoRandom(question, ref ans, ref numOfQuestion);
                numOfQuestion++;
                Start = true;
                LabelCountdown.Text = "10";
                RBtnA.Enabled = true;
                RBtnB.Enabled = true;
                RBtnC.Enabled = true;
                RBtnD.Enabled = true;
            }
            else if(End)
            {
                BtnNext.Visible = false;
                End = false;
                numOfQuestion = 0;
                score = 0;
                question = "";
                LabelRes.Text = "";
                ans = 0;
                autoRandom(question, ref ans, ref numOfQuestion);
                numOfQuestion++;
                Start = true;
                LabelCountdown.Text = "10";
                RBtnA.Enabled = true;
                RBtnB.Enabled = true;
                RBtnC.Enabled = true;
                RBtnD.Enabled = true;                
            }
        }

        //手动跳过
        private void BtnNext_Click(object sender, EventArgs e)
        {
            if(numOfQuestion >= 10)
            {
                endTest();
            }
            else
            {
                autoRandom(question, ref ans, ref numOfQuestion);
                numOfQuestion++;
                limitTime = Limit;
            }
            BtnNext.Visible = false;
        }
    }
}

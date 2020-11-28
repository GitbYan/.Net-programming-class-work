using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrawler
{
    public partial class MyCrawler : Form
    {
        public MyCrawler()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            StartEngine.SelectedIndex = 0;
        }
        public Crawler crawler;

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (m.Msg == WM_SYSCOMMAND && ((int)m.WParam == SC_CLOSE))
            {
                System.Environment.Exit(0);
                this.Close();
                return;
            }
            base.WndProc(ref m);
        }

        public void start()
        {
            MsgListBox.Items.Clear();
            crawler.SendMsg += str =>
            {
                MsgListBox.BeginUpdate();
                MsgListBox.Items.Add(str);
                MsgListBox.EndUpdate();
                MsgListBox.SelectedIndex = MsgListBox.Items.Count - 1;
            };
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //0百度 1Bing
            if (StartUrlText.Text != "")
            {
                crawler = new Crawler(StartUrlText.Text);
                start();
                new Thread(crawler.Crawl).Start();
                lblSearching.Text = "搜索zhong...";
                new Thread(end).Start();
            }
            else if (StartKeyWordText.Text != "")
            {
                switch (StartEngine.SelectedIndex)
                {
                    case 0://360
                        crawler = new Crawler("https://www.so.com/s?ie=utf-8&src=360se7_addr&q=" + StartKeyWordText.Text);
                        break;
                    case 1://bing
                        crawler = new Crawler("https://cn.bing.com/search?q="+StartKeyWordText.Text);
                        break;
                    case 2://百度
                        crawler = new Crawler("https://tieba.baidu.com/f?kw=" + StartKeyWordText.Text);
                        break;
                    default:
                        crawler = new Crawler("https://www.so.com/s?ie=utf-8&src=360se7_addr&q=" + StartKeyWordText.Text);
                        break;
                }
                start();
                new Thread(crawler.Crawl).Start();
                lblSearching.Text = "搜索zhong...";
                new Thread(end).Start();
            }
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            lblSearching.Text = "搜索结束";
            crawler.Stop = true;
            foreach(KeyValuePair<string,string> keyValues in crawler.dictionary)
            {
                listBox1.Items.Add(keyValues.Key + "   url:" + keyValues.Value);
                Console.WriteLine(keyValues.Key+"   url:"+keyValues.Value);
            }
        }

        private void StartUrlText_TextChanged(object sender, EventArgs e)
        {
            if (StartUrlText.Text != "")
            {
                StartKeyWordText.Text = "";
            }
        }

        private void StartKeyWordText_TextChanged(object sender, EventArgs e)
        {
            if (StartKeyWordText.Text != "")
            {
                StartUrlText.Text = "";
            }
        }

        private void end()
        {
            while (true)
            {
                if (crawler.Stop)
                {
                    foreach (KeyValuePair<string, string> keyValues in crawler.dictionary)
                    {
                        listBox1.Items.Add(keyValues.Key + "   url:" + keyValues.Value);
                        Console.WriteLine(keyValues.Key + "   url:" + keyValues.Value);
                    }
                    break;
                }
            }
        }
    }
}

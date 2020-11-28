using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Format
{
    public partial class Form1 : Form
    {
        public string fileName;//文件名
        public string fileContent;//文本内容
        public string newFileConTent;//文本内容（新）
        public int oldLines = 0;//行数
        public int oldWords = 0;//单词数
        public int newLines = 0;//行数（新）
        public int newWords = 0;//单词数（新）
        public int process = 0;//控制流程

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFD.InitialDirectory = @"F:\2020课程\C#\Format\Format";
            OpenFD.Filter = "c#源文件(*.cs)|*.cs|文本文件(*.txt)|*.txt";
            OpenFD.FileName = "";
            if (!System.IO.Directory.Exists(@"F:\2020课程\C#\ATM\ATM"))
            {
                OpenFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }            
            if (OpenFD.ShowDialog() == DialogResult.OK)
            {
                rtB_NewFile.Text = "";
                rTB_oldFile.Text = "";
                fileName = OpenFD.FileName;
                System.IO.StreamReader streamReader = System.IO.File.OpenText(fileName);
                fileContent = streamReader.ReadToEnd();
                streamReader.Close();
                string[] line = turnLines(fileContent);
                CountLines(line, out oldLines);
                CountWords(line, out oldWords);
                rTB_oldFile.Text = fileContent;
                lbl_oldFileLines.Text = "行数：" + oldLines;
                lbl_oldFileWords.Text = "单词数：" + oldWords;
                process = 1;
            }
        }

        private void btn_genrate_Click(object sender, EventArgs e)
        {
            if (process == 0)
            {
                return;
            }
            Generate();
            string[] line = turnLines(newFileConTent);
            CountLines(line, out newLines);
            CountWords(line, out newWords);
            rtB_NewFile.Text = newFileConTent;
            lbl_newFileLines.Text = "行数：" + newLines;
            lbl_newFileWords.Text = "单词数：" + newWords;
            process = 2;
        }
  
        public void Generate()
        {
            string[] line = turnLines(fileContent);
            for (int i = 0; i < fileContent.Length; i++)
            {
                bool isline = false;
                string tmp = initLine(line[i]);
                for (int j = 0; j < line[i].Length; j++)
                {
                    if (tmp[0] == '/' && tmp[1] == '/' && tmp[2] != '/')
                    {
                        break;
                    }
                    if (line[i][j] == '\r' || line[i][j] == '\n' || line[i][j] == '\t' || line[i][j] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        isline = true;
                    }
                }
                newFileConTent += isline ? line[i] : "";
            }
        }

        public void CountLines(string[] s, out int res)//统计行数
        {
            int count = 0;
            string[] line = s;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Contains('\n')) 
                {
                    count++;
                }
            }
            res = count;
        } 

        public void CountWords(string[] s, out int res)//统计单词数
        {
            int count = 0;
            Dictionary<string, int> Words = new Dictionary<string, int>();
            for (int i = 0; i < s.Length; i++)
            {
                Dictionary<string, int> words = checkWords(s[i]);
                foreach(string key in words.Keys)
                {
                    if (Words.Keys.Contains(key))
                    {
                        Words[key]++;
                    }
                    else
                    {
                        Words.Add(key, words[key]);
                    }
                }
            }
            foreach(string key in Words.Keys)
            {
                count += Words[key];
            }
            res = count;
        }

        public string[] turnLines(string s)//纯文本转化为段落数组
        {
            string[] line = new string[s.Length];
            int index = 0;//字符位置
            for (int i = 0; i < s.Length; i++)
            {
                line[i] = "";
                if (s[i] == '\n')
                {
                    line[i] = s.Substring(index, i - index + 1);
                    index = i + 1;
                }
            }
            return line;
        }

        public string initLine(string s)//递归清除每一行开头的空格
        {
            if (s.Length == 0)
            {
                return s;
            }
            if (s[0] == ' ' || s[0] == '\r' || s[0] == '\t')
            {
                return initLine(s.Substring(1));
            }
            else
            {
                return s;
            }
        }

        public Dictionary<string,int> checkWords(string line)//统计一行的单词数
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            line = initLine(line);
            int[] segmentation = new int[line.Length];
            int index = 0;
            for(int i = 0; i < line.Length; i++)
            {
                if (Char.IsLetter(line[i]))
                {
                    continue;
                }
                else
                {
                    segmentation[index] = i;
                    index++;
                }
            }
            for(int i = 0; i < index; i++)
            {
                if (i == index - 1)
                {
                     break;
                }
                else
                {
                    if (segmentation[i] + 1 == segmentation[i + 1])
                    {
                        continue;
                    }
                    else
                    {
                        string word = line.Substring(segmentation[i] + 1, segmentation[i + 1] - segmentation[i] - 1);
                        string pattern = @"^[A-Za-z0-9]+$";
                        Regex regex = new Regex(pattern);
                        if (regex.IsMatch(word))
                        {
                            bool found = false;
                            foreach (string key in words.Keys)
                            {
                                if (key == word)
                                {
                                    found = true;
                                }
                            }
                            if (!found)
                            {
                                words.Add(word, 1);
                            }
                            else
                            {
                                words[word]++;
                            }
                        }
                    }
                }
            }
            return words;
        }

        private void btn_countRates_Click(object sender, EventArgs e)
        {
            if(process <= 1)
            {
                return;
            }
            string[] line = turnLines(newFileConTent);
            Dictionary<string, int> rate = new Dictionary<string, int>();
            for (int i = 0; i < line.Length; i++)
            {
                Dictionary<string, int> words = checkWords(line[i]);
                foreach (string key in words.Keys)
                {
                    if (rate.Keys.Contains(key))
                    {
                        rate[key]++;
                    }
                    else
                    {
                        rate.Add(key, words[key]);
                    }
                }
            }
            foreach (string key in rate.Keys)
            {
                int index = dgv_rate.Rows.Add();
                dgv_rate.Rows[index].Cells[0].Value = key;
                dgv_rate.Rows[index].Cells[1].Value = rate[key];
                dgv_rate.Refresh();
            }
        }
    }
}

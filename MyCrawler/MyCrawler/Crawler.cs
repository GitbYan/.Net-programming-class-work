using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyCrawler
{
    public class Crawler
    {
        public HashSet<string> Urls = new HashSet<string>();//存放已爬取地址
        public Queue<string> WaitUrls = new Queue<string>();//存放待爬取地址
        public string StartUrl = "https://www.baidu.com/s?wd=邮箱";//初始页面
        public int Number = 100;//爬取邮箱总数
        public int Count = 0;//已爬取邮箱数
        public Dictionary<string, string> dictionary = new Dictionary<string, string>();//存储邮箱<mail,url>

        public bool Stop = false;
        public event Action<string> SendMsg;

        public WebClient webClient;

        public Crawler(string starturl)
        {            
            StartUrl = starturl;
        }

        public void Crawl()
        {
            int count = 0;
            WaitUrls.Enqueue(StartUrl);
            while (WaitUrls.Count != 0)//待爬取页面存在未爬取url时
            {
                if (Count >= Number || Stop)
                {
                    SendMsg("总共爬取" + Count + "个邮箱");

                    break;
                }
                string currentUrl = WaitUrls.Dequeue();
                if (Urls.Contains(currentUrl)) continue;//已被爬取，跳过
                SendMsg("第" + (count + 1) + "次爬取" + currentUrl);
                string html = DownLoad(currentUrl);
                Parse(currentUrl, html);
                SendMsg("爬取结束");
                Urls.Add(currentUrl);
                count++;
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                webClient = new WebClient();
                webClient.Credentials = CredentialCache.DefaultCredentials;
                webClient.Encoding = Encoding.UTF8;
                Byte[] page = webClient.DownloadData(url);
                string html = System.Text.Encoding.UTF8.GetString(page);
                //Console.WriteLine(html);
                Console.WriteLine("下载成功");
                return html;
            }
            catch (Exception ex)
            {
                SendMsg(ex.Message);
                return "";
            }
        }

        public void Parse(string currentUrl, string html)
        {
            try
            {
                /*
                string pagehtml = html.Replace("\t", "");
                string[] words = pagehtml.Split('\n');
                foreach(string word in words)
                {
                    string pattern = @"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$";
                    Regex rx = new Regex(pattern);
                    Match m = rx.Match(word);
                    if (m.Success)
                        getMail(m.Value, currentUrl);
                }*/
                string reg = @"(?<mail1>[a-zA-Z0-9_]+@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)+)"
                + @"|((?<mail2>[a-zA-Z0-9_]+@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)+))";
                Regex re = new Regex(reg);
                //string strRef1 = @"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$";
                //Regex re = new Regex(@"[\w!#$%&'*+/=?^_`{|}~-]+(?:\.[\w!#$%&'*+/=?^_`{|}~-]+)*@(?:[\w](?:[\w-]*[\w])?\.)+[\w](?:[\w-]*[\w])?");
                MatchCollection matches1 = re.Matches(html);
                foreach (Match match in matches1)
                {
                    getMail(match.ToString(), currentUrl);
                }
                string strRef2 = @"(href|HREF)[ ]*=[ ]*[""'][^""'#>]+[""'#?]";
                MatchCollection matches2 = new Regex(strRef2).Matches(html);
                foreach (Match match in matches2)
                {
                    strRef2 = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>', '?'); ;
                    if (strRef2.Length == 0) continue;
                    if (Urls.Contains(strRef2)) continue;
                    WaitUrls.Enqueue(strRef2);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("解析失败" + e.Message);
            }
        }     
        

        public void getMail(string mail, string url)
        {
            try
            {
                dictionary.Add(mail, url);
                Console.WriteLine(mail + "  :  " + url);
                Count++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04 {
    class Program {
        static void Main(string[] args) {

            new Program();


        }
     





        public Program() {

        
            

        




    


           int area = 0;
            Console.WriteLine("yahoo! 週間天気");
            Console.WriteLine("");
            Console.WriteLine("地域コードを入力");
            Console.WriteLine("1  前橋");
            Console.WriteLine("2：みなかみ");
            Console.WriteLine("3　宇都宮");
            Console.WriteLine("4 水戸");
            Console.WriteLine("9: その他（直接入力）");
            Console.WriteLine();

            Console.WriteLine(">");

            area = int.Parse(Console.ReadLine());
            if(area == 1) {
                area = 4210;
            } else if(area==2){
                area = 4220;
            }else if(area == 3) {
                area = 4110;

            }else if(area==4){
                area = 4010;
            } else {
                Console.WriteLine("直接地域コードを入力");
                area = int.Parse(Console.ReadLine());
            }




            var results = GetWeatherReportFromYahoo(area);
            foreach(var s in results) {
                Console.WriteLine(s);
           
            }
            Console.ReadLine();
        }
          
        
        public void DownloadString() {
            var wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            var html = wc.DownloadString("https://yahoo.co.jp/");
            Console.WriteLine(html); 
        
        }
        private void DownloadFileAsync() {
            var wc = new WebClient();
            var url = new Uri(@"C:\Users\ks32003\Desktop\sql_kaito.pdf");
            var filename = @"C:\temp\example.zip";
            wc.DownloadProgressChanged += wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += wc_DownloadFileCompleted;
            wc.DownloadFileAsync(url, filename);
            Console.ReadLine();//アプリケーションを終了しないようにする
        }

        static void wc_DownloadProgressChanged(object sender,
                            DownloadProgressChangedEventArgs e) {
            Console.WriteLine("{0}% {1}/{2}", e.ProgressPercentage,
                              e.BytesReceived, e.TotalBytesToReceive);
        }

        static void wc_DownloadFileCompleted(object sender,
                            System.ComponentModel.AsyncCompletedEventArgs e) {
            Console.WriteLine("ダウンロード完了");
        }

        public void OpenReadSample() {
            var wo = new WebClient();
            using(var stream = wo.OpenRead(@"https://yahoo.co.jp"))
            using(var sr = new StreamReader(stream, Encoding.UTF8)) {
                string html = sr.ReadToEnd();
                Console.WriteLine(html);


            }
        }
            private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode) {
                using(var wc = new WebClient()) {
                    wc.Headers.Add("Content-type", "charset=UTF-8");
                    var uriString = string.Format(
                        @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                    var url = new Uri(uriString);
                    var stream = wc.OpenRead(url);

                    XDocument xdoc = XDocument.Load(stream);
                    var nodes = xdoc.Root.Descendants("title");
                    foreach(var node in nodes) {
                        string s = Regex.Replace(node.Value, "【|】-Yahoo", "");
                        yield return s;
                    }
                
            }



        }








    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        IEnumerable<ItemData> items = null;

        public Form1() {
            InitializeComponent();

        }

        private void btRead_Click(object sender, EventArgs e) {

            GetWeatherReportFromYahoo(tburl.Text);


        }




        public void GetWeatherReportFromYahoo(string uri) {
            using(var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");





                var stream = wc.OpenRead(uri);
                XDocument xdoc = XDocument.Load(stream);
                 items = xdoc.Root.Descendants("item").Select(x => new ItemData {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("description")

                });
               

                foreach(var item in items) {
                    lbTitles.Items.Add(item.Title);



                }

            }




        }

        private void lbTitles_MouseDoubleClick(object sender, MouseEventArgs e) {
        
            label2.Text += (items.ToArray())[lbTitles.SelectedIndex].Description;
            label2.Text += (items.ToArray())[lbTitles.SelectedIndex].PubDate;
            
        }

        private void button1_Click(object sender, EventArgs e) {
            string link = (items.ToArray())[lbTitles.SelectedIndex].Link;
            var wbform = new Form2();
           wbform.webBrowser1.Url  = new Uri(link);

            wbform.Show();
        }
    }
}


            
        
   


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
        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            
                GetWeatherReportFromYahoo(tburl.Text);


            }




            private void IEnumerable<string> GetWeatherReportFromYahoo(string bturl) {
                using(var wc = new WebClient()) {
                    wc.Headers.Add("Content-type", "charset=UTF-8");



                    var stream = wc.OpenRead(bturl.te);
                XComment xdoc = XDocument.Load(stream);
                        var nodes = xdoc.Root.Descendants("title");
                    
                }


            }



        }
    }
}

            
        
   


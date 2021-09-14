using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Modorubutton1_Click(object sender, EventArgs e) {
            if(webBrowser1.CanGoBack ) {
                // ★★★前ページに戻る★★★
                webBrowser1.GoBack();
            }
        }




        private void Susumubutton2_Click(object sender, EventArgs e) {
            if(webBrowser1.CanGoForward ) {
                // ★★★次ページに進む★★★
                webBrowser1.GoForward();
            }


        }

      
    }
}





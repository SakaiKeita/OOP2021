using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        string inputPath = "";
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var lines = new[] { "===", "今日の", "あ" };
            var filePath = @"C:\Users\infosys\Desktop\using_System.txt";
           

                using(var writer =new StreamWriter(filePath, append: true)) {
                    foreach(var item in lines) {
                        writer.WriteLine(item);
                    }                
                
                
                }




            }
        }
    }
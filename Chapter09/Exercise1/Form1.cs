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

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                int count = 0;
                using(var reader = new StreamReader(openFileDialog1.FileName, Encoding.GetEncoding("shift_jis"))) {
                    while(!reader.EndOfStream) {
                        var line = reader.ReadLine(); //1行読み込み
                        if(line.Contains(textBox1.Text)) {
                            count++;
                        }
                        textBox2.Text = "キーワード「" + textBox1.Text + "]が含まれている行は、" + count.ToString() + "行です";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) {

            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                int count = 0;
                var lines = File.ReadAllLines(openFileDialog1.FileName, Encoding.GetEncoding("shift_jis"));
                foreach(var line in lines) {
                    if(line.Contains(textBox1.Text))
                        count++;
                }
                textBox2.Text = "キーワード「" + textBox1.Text + "]が含まれている行は、" + count.ToString() + "行です";
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                int count = 0;
                var lines = File.ReadLines(openFileDialog1.FileName, Encoding.GetEncoding("shift_jis"));
                foreach(var line in lines) {
                    if(line.Contains(textBox1.Text))
                        count++;
                }
                textBox2.Text = "キーワード「" + textBox1.Text + "]が含まれている行は、" + count.ToString() + "行です";
            }
        }
    }
    }



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execise3 {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }
        //フォームがロードされるとき一回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {

            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            //問題5.4
            inputStrData.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void button1_Click(object sender, EventArgs e) {
            var count = inputStrText.Text.Count(n => n == ' ');
            TextBoxWordChange.Text = count.ToString();


        }

        private void button2_Click(object sender, EventArgs e) {

            var mozi = inputStrText.Text;
            var a = mozi.Replace("big", "small");
            textBox1.Text = a.ToString();
        }

        private void button3_Click(object sender, EventArgs e) {
            textBox2.Text = inputStrText.Text.Split(' ').Length.ToString();

        }

        private void button4_Click(object sender, EventArgs e) {
            var words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach(var item in words) {
                textBox3.Text += item + " ";
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            //var text=inputStrText.Text.Split(' ').ToArray();
            //if(array.Length>0){var sb =new StringBuilder(text[0]);
            //foreach(var word in text.Skip(1)){
            //sb.append(' ');
            //sb.append(word);
            //}
            //tbStrBuillder.Text=sb.Tostring();
            var sb = new StringBuilder();
            var text = inputStrText.Text.Split(' ').ToArray();
            foreach(var item in text) {
                sb.Append(item + ' ');
            }
            textBox4.Text = sb.ToString();
        }

        private void Button5_4_Click(object sender, EventArgs e) {
            foreach(var pair in inputStrData.Text.Split(';')) {
                var array = pair.Split('=');
                outputStrData.Text += ToJapanese(array[0]) + ":" + array[1] + "\r\n";//改行
            }
        }
        private string ToJapanese(string key) {
            switch(key) {
                case "Novelist":
                    return "作家";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生日";
            }
            throw new ArgumentException("引数が正しくありません");
            
        }
    }
}

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

namespace Exercise2 {
    public partial class Form1 : Form {
        string inputPath = "";//変換元ファイル
        string outputPath = "";//変換先ファイル
        public Form1() {
            InitializeComponent();
        }
        //変換元のファイルを指定
        private void button1_Click(object sender, EventArgs e) {
            if(openFileDialog1.ShowDialog() == DialogResult.OK) {
                inputPath = openFileDialog1.FileName;



            }
        }
        //変換したファイルの保存先を指定
        private void button2_Click(object sender, EventArgs e) {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK) {
                outputPath = saveFileDialog1.FileName;



            }
        }
        //行番号を追加する処理
        private void button3_Click(object sender, EventArgs e) {
            var lines = File.ReadLines(inputPath).Select((s, ix) => String.Format("{0,4}:{1}", ix + 1, s)).ToArray();
            File.WriteAllLines(outputPath, lines);

        }

    }
}
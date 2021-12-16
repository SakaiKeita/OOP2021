using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_system {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Bitmap bitmap = new Bitmap(@"\Users\infosys\source\repos\SakaiKeita\OOP2021\Library\library system\20E58PIC2ie53eT027d5c_PIC2018.jpg");

            this.BackgroundImage = bitmap;                  // 背景画像
            this.BackgroundImageLayout = ImageLayout.Tile;  // 配置
                                                            //描画先とするImageオブジェクトを作成する
            pictureBox1.ImageLocation = (@"C:\Users\infosys\source\repos\SakaiKeita\OOP2021\Library\library system\R.png");

            pictureBox2.ImageLocation = (@"C:\Users\infosys\source\repos\SakaiKeita\OOP2021\Library\library system\R (1).png");

            bitmap.MakeTransparent(bitmap.GetPixel(0, 0));
        }

      

        private void button3_Click(object sender, EventArgs e) {
            Form2 f2 = new Form2();
            f2.Show();
            
        }

        private void button4_Click(object sender, EventArgs e) {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            Form4 f4 = new Form4();
            f4.Show();        
        }

        private void button1_Click(object sender, EventArgs e) {

        }
    }


    }


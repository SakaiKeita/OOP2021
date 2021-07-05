using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        Stopwatch sw = new Stopwatch();
            public Form1() {
            InitializeComponent();
            
        
        
        }

       

        private void button1_Click(object sender, EventArgs e) {
            sw.Start();
            tm.Tick += Tm_Tick;

           
           
        }
        private void Form1_Load(object sender, EventArgs e) {
            lbtimer.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            //lbtimer.Text = "00:00:00.00";これでもいい
        }
        private void Tm_Tick(object sender, EventArgs e) {
            throw new NotImplementedException();
            sw.Stop();
        }
    }
}

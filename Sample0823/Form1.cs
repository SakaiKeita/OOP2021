using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823 {
    public partial class Form1 : Form {
        public Form1() {
            int n;
            InitializeComponent();
        }

        private void Exect_Click(object sender, EventArgs e) {
          int num1=  int.Parse( Value.Text);
           int num2= int.Parse(Jyo.Text);
            int.Parse(Result.Text);
            Result.Text = Math.Pow(num1, num2).ToString();
            for(int i= 1;i<=Value; i++) {
            
                
                Jyo=Jyo*i;
            
            }
        
        
        }
    }
}

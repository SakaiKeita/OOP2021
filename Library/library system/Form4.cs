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
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) {
            this.test_TableTableAdapter1.Fill(this.infosys202101DataSet1.Test_Table);
      
        }
    }
}

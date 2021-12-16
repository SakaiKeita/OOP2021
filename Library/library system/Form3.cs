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
    public partial class Form3 : Form {
        public Form3() {
         
        }

        private void Form3_Load(object sender, EventArgs e) {
        
            PersondataGridView1.Columns[1].HeaderText = "名前";
           PersondataGridView1.Columns[2].HeaderText = "タイトル";
            PersondataGridView1.Columns[3].HeaderText = "出版社";
            


        }

        private void button1_Click(object sender, EventArgs e) {
            PersondataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
            PersondataGridView1.CurrentRow.Cells[3].Value = dateTimePicker1.Value;
           PersondataGridView1.CurrentRow.Cells[2].Value = textBox2.Text;
            this.Validate();
            this.bindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.infosys202101DataSet1);


        }

        private void PersondataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

      
    }
}

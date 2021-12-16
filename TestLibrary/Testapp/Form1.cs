using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Testapp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202101DataSet.Test_Table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.test_TableTableAdapter.Fill(this.infosys202101DataSet.Test_Table);



        }




        private void button2_Click(object sender, EventArgs e) {
          test_TableDataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            test_TableDataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            test_TableDataGridView1.CurrentRow.Cells[2].Value = dateTimePicker1.Value;
            test_TableDataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;


            this.test_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202101DataSet);
        }

        private void button3_Click(object sender, EventArgs e) {
            this.test_TableTableAdapter.Fill(this.infosys202101DataSet.Test_Table);
        }

        private void test_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.test_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202101DataSet);

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testapp2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void test_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.test_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202101DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: このコード行はデータを 'infosys202101DataSet.Test_Table' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.test_TableTableAdapter.Fill(this.infosys202101DataSet.Test_Table);

        }
    }
}

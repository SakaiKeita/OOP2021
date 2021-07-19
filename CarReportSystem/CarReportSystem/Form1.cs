using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();

            dgvRegistDate.DataSource = listCarReport;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();//アプリケーション終了
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if(ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //追加ボタンのイベントハンドラ
        private void btDataAdd_Click(object sender, EventArgs e) {

            if(cbAuthor.Text == "" || cbCarName.Text == "") {//!=で○○以外なら
                MessageBox.Show("入力されていません");
                return;
            }
            CarReport carReport = new CarReport {

                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbPeport.Text,
                Picture = pbPicture.Image

            };

            listCarReport.Add(carReport);
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }
        private CarReport.MakerGroup selectedGroup() {
            foreach(var rb in gbMaker.Controls) {
                if(((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse((string)((RadioButton)rb).Tag);
                }
            }
            return CarReport.MakerGroup.その他;
        }
        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if(!cbAuthor.Items.Contains(author)) {//!で判定を逆にする
                cbAuthor.Items.Add(author);
            }
        }
        //コンボボックスに車名をセットする    
        private void setCbCarName(string author) {
            if(!cbCarName.Items.Contains(author)) {//!で判定を逆にする
                cbCarName.Items.Add(author);
            }



        }

        private void dgvRegistDate_MouseClick(object sender, MouseEventArgs e) {
            //CarReport selectedCar = listCarReport[0];











        }

        private void dgvRegistDate_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.RowIndex == -1)
                return;


            //選択された行のデータを取得
            CarReport selectedCar = listCarReport[e.RowIndex];
            //取得したデータ項目を各コントロールへ設定
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);
            cbCarName.Text = selectedCar.CarName;
            tbPeport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;


        }

        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch(mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbtoyot.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rdNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rdHond.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rdsubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外国車:
                    rdinport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;

            }
        }
        //削除
        private void btDataDelete_Click(object sender, EventArgs e) {
            listCarReport.RemoveAt(dgvRegistDate.CurrentRow.Index);

        }

        /*private void btDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistDate.CurrentRow.Index].UpDate(dtpDate.Value, cbAuthor.Text, selectedGroup(),
                cbCarName.Text, tbPeport.Text, pbPicture.Image);
            dgvRegistDate.Update();
        
        
        
        }
        */
        private void btDataCorrect_Click(object sender, EventArgs e) {
            listCarReport[dgvRegistDate.CurrentRow.Index].UpDate(dtpDate.Value,
                                                                cbAuthor.Text,
                                                                selectedGroup(),
                                                                cbCarName.Text,
                                                                tbPeport.Text,
                                                                pbPicture.Image
                                                                );
            dgvRegistDate.Refresh();//コントロールの強制再描画

        }

        //保存
        private void btSave_Click(object sender, EventArgs e) {
            if(sfdFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    var bf = new BinaryFormatter();
                    using(FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);

                }

            }
        }

        private void btOpen_Click(object sender, EventArgs e) {
            if(ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try { 
                //バイナリ形式で逆シリアル化
                var bf = new BinaryFormatter();
                    using(FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {

                        //逆シリアル化して読み込む
                        listCarReport = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistDate.DataSource = null;
                        dgvRegistDate.DataSource = listCarReport;
                    }
                    }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);

                }
                //読み込んだデータを各コンボボックスに登録する

                foreach(var item in listCarReport) {
                    cbAuthor.Items.Add(item.Auther);
                    cbCarName.Items.Add(item.CarName);
                }

                //for(int i = 0; i < dgvRegistDate.RowCount; i++) {

                //    setCbAuthor(dgvRegistDate.Rows[i].Cells[1].Value.ToString());
                //    setCbCarName(dgvRegistDate.Rows[i].Cells[1].Value.ToString());
                //}


            }
        }

        private void fmMain_Load(object sender, EventArgs e) {
            dgvRegistDate.Columns[5].Visible = false;
        }
    }
}



namespace CarReportSystem {
    partial class fmMain {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.dgvRegistDate = new System.Windows.Forms.DataGridView();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rdinport = new System.Windows.Forms.RadioButton();
            this.rdsubaru = new System.Windows.Forms.RadioButton();
            this.rdHond = new System.Windows.Forms.RadioButton();
            this.rdNissan = new System.Windows.Forms.RadioButton();
            this.rbtoyot = new System.Windows.Forms.RadioButton();
            this.tbPeport = new System.Windows.Forms.TextBox();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btOpen = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureDelete = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btDataAdd = new System.Windows.Forms.Button();
            this.btDataCorrect = new System.Windows.Forms.Button();
            this.btDataDelete = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.ofdPictureOpen = new System.Windows.Forms.OpenFileDialog();
            this.ofdFileOpen = new System.Windows.Forms.OpenFileDialog();
            this.sfdFileSave = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbMaker.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistDate
            // 
            this.dgvRegistDate.AllowUserToAddRows = false;
            this.dgvRegistDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistDate.Location = new System.Drawing.Point(115, 538);
            this.dgvRegistDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRegistDate.MultiSelect = false;
            this.dgvRegistDate.Name = "dgvRegistDate";
            this.dgvRegistDate.RowHeadersWidth = 51;
            this.dgvRegistDate.RowTemplate.Height = 21;
            this.dgvRegistDate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistDate.Size = new System.Drawing.Size(889, 239);
            this.dgvRegistDate.TabIndex = 0;
            this.dgvRegistDate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistDate_CellClick);
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPicture.Location = new System.Drawing.Point(653, 125);
            this.pbPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(367, 306);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // gbMaker
            // 
            this.gbMaker.AutoSize = true;
            this.gbMaker.Controls.Add(this.rbOther);
            this.gbMaker.Controls.Add(this.rdinport);
            this.gbMaker.Controls.Add(this.rdsubaru);
            this.gbMaker.Controls.Add(this.rdHond);
            this.gbMaker.Controls.Add(this.rdNissan);
            this.gbMaker.Controls.Add(this.rbtoyot);
            this.gbMaker.Location = new System.Drawing.Point(115, 161);
            this.gbMaker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMaker.Size = new System.Drawing.Size(516, 66);
            this.gbMaker.TabIndex = 2;
            this.gbMaker.TabStop = false;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Checked = true;
            this.rbOther.Location = new System.Drawing.Point(436, 22);
            this.rbOther.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(66, 19);
            this.rbOther.TabIndex = 0;
            this.rbOther.TabStop = true;
            this.rbOther.Tag = "5";
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rdinport
            // 
            this.rdinport.AutoSize = true;
            this.rdinport.Location = new System.Drawing.Point(349, 22);
            this.rdinport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdinport.Name = "rdinport";
            this.rdinport.Size = new System.Drawing.Size(73, 19);
            this.rdinport.TabIndex = 0;
            this.rdinport.Tag = "4";
            this.rdinport.Text = "外国車";
            this.rdinport.UseVisualStyleBackColor = true;
            // 
            // rdsubaru
            // 
            this.rdsubaru.AutoSize = true;
            this.rdsubaru.Location = new System.Drawing.Point(272, 24);
            this.rdsubaru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdsubaru.Name = "rdsubaru";
            this.rdsubaru.Size = new System.Drawing.Size(64, 19);
            this.rdsubaru.TabIndex = 0;
            this.rdsubaru.Tag = "3";
            this.rdsubaru.Text = "スバル";
            this.rdsubaru.UseVisualStyleBackColor = true;
            // 
            // rdHond
            // 
            this.rdHond.AutoSize = true;
            this.rdHond.Location = new System.Drawing.Point(176, 22);
            this.rdHond.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdHond.Name = "rdHond";
            this.rdHond.Size = new System.Drawing.Size(62, 19);
            this.rdHond.TabIndex = 0;
            this.rdHond.Tag = "2";
            this.rdHond.Text = "ホンダ";
            this.rdHond.UseVisualStyleBackColor = true;
            // 
            // rdNissan
            // 
            this.rdNissan.AutoSize = true;
            this.rdNissan.Location = new System.Drawing.Point(95, 22);
            this.rdNissan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNissan.Name = "rdNissan";
            this.rdNissan.Size = new System.Drawing.Size(58, 19);
            this.rdNissan.TabIndex = 0;
            this.rdNissan.Tag = "1";
            this.rdNissan.Text = "日産";
            this.rdNissan.UseVisualStyleBackColor = true;
            // 
            // rbtoyot
            // 
            this.rbtoyot.AutoSize = true;
            this.rbtoyot.Location = new System.Drawing.Point(24, 22);
            this.rbtoyot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtoyot.Name = "rbtoyot";
            this.rbtoyot.Size = new System.Drawing.Size(58, 19);
            this.rbtoyot.TabIndex = 0;
            this.rbtoyot.Tag = "0";
            this.rbtoyot.Text = "トヨタ";
            this.rbtoyot.UseVisualStyleBackColor = true;
            // 
            // tbPeport
            // 
            this.tbPeport.Location = new System.Drawing.Point(115, 290);
            this.tbPeport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPeport.Multiline = true;
            this.tbPeport.Name = "tbPeport";
            this.tbPeport.Size = new System.Drawing.Size(427, 213);
            this.tbPeport.TabIndex = 3;
            // 
            // cbCarName
            // 
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(115, 251);
            this.cbCarName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(252, 23);
            this.cbCarName.TabIndex = 4;
            // 
            // cbAuthor
            // 
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(115, 92);
            this.cbAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(331, 23);
            this.cbAuthor.TabIndex = 4;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(605, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "画像:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "記録者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "メーカー：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 251);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "車名:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "レポート:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 522);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "記事一覧：";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(7, 556);
            this.btOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(100, 29);
            this.btOpen.TabIndex = 7;
            this.btOpen.Text = "開く...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(7, 622);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 29);
            this.btSave.TabIndex = 7;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(115, 40);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 8;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.Location = new System.Drawing.Point(688, 89);
            this.btPictureOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(100, 29);
            this.btPictureOpen.TabIndex = 7;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btPictureDelete
            // 
            this.btPictureDelete.ForeColor = System.Drawing.Color.Black;
            this.btPictureDelete.Location = new System.Drawing.Point(841, 89);
            this.btPictureDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btPictureDelete.Name = "btPictureDelete";
            this.btPictureDelete.Size = new System.Drawing.Size(100, 29);
            this.btPictureDelete.TabIndex = 7;
            this.btPictureDelete.Text = "削除";
            this.btPictureDelete.UseVisualStyleBackColor = true;
            this.btPictureDelete.Click += new System.EventHandler(this.btPictureDelete_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1527, -485);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 7;
            this.button5.Text = "button1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btDataAdd
            // 
            this.btDataAdd.Location = new System.Drawing.Point(623, 444);
            this.btDataAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDataAdd.Name = "btDataAdd";
            this.btDataAdd.Size = new System.Drawing.Size(100, 60);
            this.btDataAdd.TabIndex = 7;
            this.btDataAdd.Text = "追加";
            this.btDataAdd.UseVisualStyleBackColor = true;
            this.btDataAdd.Click += new System.EventHandler(this.btDataAdd_Click);
            // 
            // btDataCorrect
            // 
            this.btDataCorrect.Location = new System.Drawing.Point(752, 444);
            this.btDataCorrect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDataCorrect.Name = "btDataCorrect";
            this.btDataCorrect.Size = new System.Drawing.Size(100, 60);
            this.btDataCorrect.TabIndex = 7;
            this.btDataCorrect.Text = "修正";
            this.btDataCorrect.UseVisualStyleBackColor = true;
            this.btDataCorrect.Click += new System.EventHandler(this.btDataCorrect_Click);
            // 
            // btDataDelete
            // 
            this.btDataDelete.Location = new System.Drawing.Point(889, 444);
            this.btDataDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDataDelete.Name = "btDataDelete";
            this.btDataDelete.Size = new System.Drawing.Size(100, 60);
            this.btDataDelete.TabIndex = 7;
            this.btDataDelete.Text = "削除";
            this.btDataDelete.UseVisualStyleBackColor = true;
            this.btDataDelete.Click += new System.EventHandler(this.btDataDelete_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(7, 748);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 29);
            this.btExit.TabIndex = 7;
            this.btExit.Text = "終了";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // ofdPictureOpen
            // 
            this.ofdPictureOpen.FileName = "openFileDialog1";
            // 
            // ofdFileOpen
            // 
            this.ofdFileOpen.FileName = "openFileDialog1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 791);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btDataDelete);
            this.Controls.Add(this.btDataCorrect);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btPictureDelete);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.btDataAdd);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAuthor);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.tbPeport);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.dgvRegistDate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "fmMain";
            this.Text = "試乗レポート管理システム";
            this.Load += new System.EventHandler(this.fmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistDate;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.TextBox tbPeport;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rdinport;
        private System.Windows.Forms.RadioButton rdsubaru;
        private System.Windows.Forms.RadioButton rdHond;
        private System.Windows.Forms.RadioButton rdNissan;
        private System.Windows.Forms.RadioButton rbtoyot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureDelete;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btDataAdd;
        private System.Windows.Forms.Button btDataCorrect;
        private System.Windows.Forms.Button btDataDelete;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.OpenFileDialog ofdPictureOpen;
        private System.Windows.Forms.OpenFileDialog ofdFileOpen;
        private System.Windows.Forms.SaveFileDialog sfdFileSave;
    }
}


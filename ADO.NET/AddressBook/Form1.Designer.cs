
namespace AddressBook {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            this.personDataGridView = new System.Windows.Forms.DataGridView();
            this.btConnect = new System.Windows.Forms.Button();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telehomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202101DataSet = new AddressBook.infosys202101DataSet();
            this.personTableAdapter = new AddressBook.infosys202101DataSetTableAdapters.PersonTableAdapter();
            this.tableAdapterManager = new AddressBook.infosys202101DataSetTableAdapters.TableAdapterManager();
            this.personTableAdapter1 = new AddressBook.infosys202101DataSetTableAdapters.PersonTableAdapter();
            this.btNameFillter = new System.Windows.Forms.Button();
            this.tbNameSearch = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.btBirthday = new System.Windows.Forms.Button();
            this.dtpbt = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202101DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // personDataGridView
            // 
            this.personDataGridView.AllowUserToAddRows = false;
            this.personDataGridView.AutoGenerateColumns = false;
            this.personDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.telehomeDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn});
            this.personDataGridView.DataSource = this.personBindingSource;
            this.personDataGridView.Location = new System.Drawing.Point(-4, 175);
            this.personDataGridView.MultiSelect = false;
            this.personDataGridView.Name = "personDataGridView";
            this.personDataGridView.ReadOnly = true;
            this.personDataGridView.RowTemplate.Height = 21;
            this.personDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personDataGridView.Size = new System.Drawing.Size(800, 224);
            this.personDataGridView.TabIndex = 1;
            this.personDataGridView.SelectionChanged += new System.EventHandler(this.personDataGridView_SelectionChanged);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(13, 428);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(107, 26);
            this.btConnect.TabIndex = 2;
            this.btConnect.Text = "接続";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telehomeDataGridViewTextBoxColumn
            // 
            this.telehomeDataGridViewTextBoxColumn.DataPropertyName = "Telehome";
            this.telehomeDataGridViewTextBoxColumn.HeaderText = "Telehome";
            this.telehomeDataGridViewTextBoxColumn.Name = "telehomeDataGridViewTextBoxColumn";
            this.telehomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            this.memoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.infosys202101DataSet;
            // 
            // infosys202101DataSet
            // 
            this.infosys202101DataSet.DataSetName = "infosys202101DataSet";
            this.infosys202101DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableAdapter = this.personTableAdapter;
            this.tableAdapterManager.UpdateOrder = AddressBook.infosys202101DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personTableAdapter1
            // 
            this.personTableAdapter1.ClearBeforeFill = true;
            // 
            // btNameFillter
            // 
            this.btNameFillter.Location = new System.Drawing.Point(270, 405);
            this.btNameFillter.Name = "btNameFillter";
            this.btNameFillter.Size = new System.Drawing.Size(177, 83);
            this.btNameFillter.TabIndex = 3;
            this.btNameFillter.Text = "名前抽出";
            this.btNameFillter.UseVisualStyleBackColor = true;
            this.btNameFillter.Click += new System.EventHandler(this.btNameFillter_Click);
            // 
            // tbNameSearch
            // 
            this.tbNameSearch.Location = new System.Drawing.Point(143, 469);
            this.tbNameSearch.Name = "tbNameSearch";
            this.tbNameSearch.Size = new System.Drawing.Size(100, 19);
            this.tbNameSearch.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(13, 460);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(107, 28);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "保存";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "名前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "誕生日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "電話番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "備考";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(58, 45);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(87, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 19);
            this.tbName.TabIndex = 11;
            // 
            // tbTelephone
            // 
            this.tbTelephone.Location = new System.Drawing.Point(87, 70);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(100, 19);
            this.tbTelephone.TabIndex = 12;
            // 
            // tbMemo
            // 
            this.tbMemo.Location = new System.Drawing.Point(431, 9);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.Size = new System.Drawing.Size(311, 141);
            this.tbMemo.TabIndex = 13;
            // 
            // btBirthday
            // 
            this.btBirthday.Location = new System.Drawing.Point(676, 405);
            this.btBirthday.Name = "btBirthday";
            this.btBirthday.Size = new System.Drawing.Size(133, 103);
            this.btBirthday.TabIndex = 14;
            this.btBirthday.Text = "誕生日抽出";
            this.btBirthday.UseVisualStyleBackColor = true;
            this.btBirthday.Click += new System.EventHandler(this.btBirthday_Click);
            // 
            // dtpbt
            // 
            this.dtpbt.Location = new System.Drawing.Point(470, 460);
            this.dtpbt.Name = "dtpbt";
            this.dtpbt.Size = new System.Drawing.Size(200, 19);
            this.dtpbt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 500);
            this.Controls.Add(this.dtpbt);
            this.Controls.Add(this.btBirthday);
            this.Controls.Add(this.tbMemo);
            this.Controls.Add(this.tbTelephone);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbNameSearch);
            this.Controls.Add(this.btNameFillter);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.personDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202101DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202101DataSet infosys202101DataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private infosys202101DataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private infosys202101DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView personDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telehomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private infosys202101DataSetTableAdapters.PersonTableAdapter personTableAdapter1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btNameFillter;
        private System.Windows.Forms.TextBox tbNameSearch;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.Button btBirthday;
        private System.Windows.Forms.DateTimePicker dtpbt;
    }
}


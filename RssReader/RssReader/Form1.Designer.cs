﻿
namespace RssReader {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tburl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(46, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tburl
            // 
            this.tburl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tburl.Location = new System.Drawing.Point(251, 15);
            this.tburl.Name = "tburl";
            this.tburl.Size = new System.Drawing.Size(388, 37);
            this.tburl.TabIndex = 1;
            // 
            // lbTitles
            // 
            this.lbTitles.Font = new System.Drawing.Font("MS UI Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 17;
            this.lbTitles.Location = new System.Drawing.Point(12, 71);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(263, 378);
            this.lbTitles.TabIndex = 2;
            this.lbTitles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbTitles_MouseDoubleClick);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(402, 58);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(304, 400);
            this.wbBrowser.TabIndex = 3;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(668, 22);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(75, 23);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読み込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tburl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "32003";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tburl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btRead;
    }
}


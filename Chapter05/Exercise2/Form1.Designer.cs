
namespace Exercise2 {
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
            this.inStrNum = new System.Windows.Forms.TextBox();
            this.Button5_2 = new System.Windows.Forms.Button();
            this.outStrNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inStrNum
            // 
            this.inStrNum.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inStrNum.Location = new System.Drawing.Point(100, 12);
            this.inStrNum.Name = "inStrNum";
            this.inStrNum.Size = new System.Drawing.Size(193, 31);
            this.inStrNum.TabIndex = 0;
            // 
            // Button5_2
            // 
            this.Button5_2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Button5_2.Location = new System.Drawing.Point(309, 10);
            this.Button5_2.Name = "Button5_2";
            this.Button5_2.Size = new System.Drawing.Size(118, 50);
            this.Button5_2.TabIndex = 1;
            this.Button5_2.Text = "問題5.2";
            this.Button5_2.UseVisualStyleBackColor = true;
            this.Button5_2.Click += new System.EventHandler(this.Button5_2_Click);
            // 
            // outStrNum
            // 
            this.outStrNum.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outStrNum.Location = new System.Drawing.Point(100, 60);
            this.outStrNum.Name = "outStrNum";
            this.outStrNum.Size = new System.Drawing.Size(193, 31);
            this.outStrNum.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(19, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "変換前";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(19, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "変換後";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Button5_2);
            this.Controls.Add(this.outStrNum);
            this.Controls.Add(this.inStrNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inStrNum;
        private System.Windows.Forms.Button Button5_2;
        private System.Windows.Forms.TextBox outStrNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


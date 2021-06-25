
namespace Execise3 {
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
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxWordChange = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Button5_4 = new System.Windows.Forms.Button();
            this.outputStrData = new System.Windows.Forms.TextBox();
            this.inputStrData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "問題5.3\r\n";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(25, 47);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(561, 31);
            this.inputStrText.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "空白をカウント";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxWordChange
            // 
            this.TextBoxWordChange.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxWordChange.Location = new System.Drawing.Point(164, 115);
            this.TextBoxWordChange.Name = "TextBoxWordChange";
            this.TextBoxWordChange.Size = new System.Drawing.Size(344, 26);
            this.TextBoxWordChange.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "big→small";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(164, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 26);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "カウント";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(164, 346);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(344, 31);
            this.textBox2.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 402);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 6;
            this.button4.Text = "4文字以下";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(164, 422);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(275, 31);
            this.textBox3.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(25, 473);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 69);
            this.button5.TabIndex = 8;
            this.button5.Text = "連結";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox4.Location = new System.Drawing.Point(164, 487);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(326, 31);
            this.textBox4.TabIndex = 9;
            // 
            // Button5_4
            // 
            this.Button5_4.Location = new System.Drawing.Point(25, 626);
            this.Button5_4.Name = "Button5_4";
            this.Button5_4.Size = new System.Drawing.Size(91, 62);
            this.Button5_4.TabIndex = 10;
            this.Button5_4.Text = "問題5.4";
            this.Button5_4.UseVisualStyleBackColor = true;
            this.Button5_4.Click += new System.EventHandler(this.Button5_4_Click);
            // 
            // outputStrData
            // 
            this.outputStrData.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.outputStrData.Location = new System.Drawing.Point(141, 694);
            this.outputStrData.Multiline = true;
            this.outputStrData.Name = "outputStrData";
            this.outputStrData.Size = new System.Drawing.Size(487, 112);
            this.outputStrData.TabIndex = 11;
            // 
            // inputStrData
            // 
            this.inputStrData.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrData.Location = new System.Drawing.Point(141, 662);
            this.inputStrData.Name = "inputStrData";
            this.inputStrData.Size = new System.Drawing.Size(487, 26);
            this.inputStrData.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 827);
            this.Controls.Add(this.inputStrData);
            this.Controls.Add(this.outputStrData);
            this.Controls.Add(this.Button5_4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TextBoxWordChange);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxWordChange;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Button5_4;
        private System.Windows.Forms.TextBox outputStrData;
        private System.Windows.Forms.TextBox inputStrData;
    }
}


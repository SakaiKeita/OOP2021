
namespace RssReader {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.Modorubutton1 = new System.Windows.Forms.Button();
            this.Susumubutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 110);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(800, 340);
            this.webBrowser1.TabIndex = 0;
            // 
            // Modorubutton1
            // 
            this.Modorubutton1.Location = new System.Drawing.Point(12, 51);
            this.Modorubutton1.Name = "Modorubutton1";
            this.Modorubutton1.Size = new System.Drawing.Size(75, 23);
            this.Modorubutton1.TabIndex = 1;
            this.Modorubutton1.Text = "戻る";
            this.Modorubutton1.UseVisualStyleBackColor = true;
            this.Modorubutton1.Click += new System.EventHandler(this.Modorubutton1_Click);
            // 
            // Susumubutton2
            // 
            this.Susumubutton2.Location = new System.Drawing.Point(188, 51);
            this.Susumubutton2.Name = "Susumubutton2";
            this.Susumubutton2.Size = new System.Drawing.Size(75, 23);
            this.Susumubutton2.TabIndex = 2;
            this.Susumubutton2.Text = "進む\r\n";
            this.Susumubutton2.UseVisualStyleBackColor = true;
            this.Susumubutton2.Click += new System.EventHandler(this.Susumubutton2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Susumubutton2);
            this.Controls.Add(this.Modorubutton1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button Modorubutton1;
        private System.Windows.Forms.Button Susumubutton2;
    }
}
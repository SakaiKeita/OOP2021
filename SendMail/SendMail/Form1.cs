using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class Form1 : Form {
        private ConfigForm cf = new ConfigForm();
      //設定情報
        public Settings setting = Settings.getInstance();
        public Form1() {
            InitializeComponent();
         


        }

        private void btSend_Click(object sender, EventArgs e) {

            try {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
               //差出人アドレス
                mailMessage.From = new MailAddress(setting.MailAdder);
                //宛先()
                mailMessage.To.Add(tbTo.Text);                
                mailMessage.CC.Add(tbCc.Text);
                mailMessage.Bcc.Add(tbBcc.Text);
                //件名(タイトル) 
                mailMessage.Subject = tbTitle.Text;                         //32003@ojs.ac.jp
                //本文
                mailMessage.Body = tbMessage.Text;
            //smtpを使ってメールを送信する
                SmtpClient smtpClient=new SmtpClient();
                //メール送信のための認証情報を設定(ユーザー名、パスわーど)
                  smtpClient.Credentials = new NetworkCredential(setting.MailAdder,setting.Pass);
                // smtpClient.Host = "smtp.gmail.com";
           
                smtpClient.Host = cf.setting.Host;
                smtpClient.Port = cf.setting.Port;
                smtpClient.EnableSsl =cf.setting.Ssl;
                
                
                
                //smtpClient.Port = 587;
                //smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);

                MessageBox.Show("送信完了");
            
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                
            }






        }

        private void btConfig_Click(object sender, EventArgs e) {
         cf.ShowDialog(); 



        }
    }
}

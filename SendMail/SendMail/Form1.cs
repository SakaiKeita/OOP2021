using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace SendMail {
    public partial class Form1 : Form {
        private ConfigForm cf = new ConfigForm();
      //設定情報
        public Settings setting = Settings.getInstance();
        private FileStream fs;
        private SmtpClient settings;

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
                if(tbCc.Text!="") {
                    mailMessage.CC.Add(tbCc.Text);
                } else{ 
                   }
                if(tbBcc.Text != "") {
                    mailMessage.Bcc.Add(tbBcc.Text);
                } else {
                  
                }
              
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

                smtpClient.Send(mailMessage);
                //送信完了時に呼ばれるイベントハンドラの登録
                smtpClient.SendCompleted += SmtpClient_SendCompleted; 
            //   smtpClient.SendCompleted += new SendCompletedEventHandler(SmtpClient_SendCompleted);    //古い書き方                                                        
              


                string userState = "SendMail";
                smtpClient.SendAsync(mailMessage, userState);
            
                   

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                
            }






        }
        //送信が完了すると呼ばれるコールバックめぞっど
        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if(e.Error != null) {
                MessageBox.Show(e.Error.Message);
            } else {
                MessageBox.Show("送信完了");
            }
          
        }

        private void btConfig_Click(object sender, EventArgs e) {
         cf.ShowDialog(); 



        }

        private void Form1_Load(object sender, EventArgs e) {
            using(var reader = XmlReader.Create("mailsetting.xml")) {
                var serializer = new DataContractSerializer(typeof(Settings));
                settings = serializer.ReadObject(reader) as Settings;              
              
              //  setting.Host = .Host;
              //setting.MailAdder = novel.MailAdder;
              //  setting.Pass = novel.Pass;
              //  setting.Port = novel.Port;
           
            }
        }
    }
}

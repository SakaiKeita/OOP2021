using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail {
    public partial class ConfigForm : Form {
        public Settings setting =  Settings.getInstance();
      
        public ConfigForm() {
         
        InitializeComponent();
        }
      
        private void btDefault_Click(object sender, EventArgs e) {
         
            tbHost.Text = setting.sHost();
            tbPass.Text = setting.sPass();
            tbPort.Text = setting.sPort();
            tbUserName.Text = setting.sMailAddr();
            cbSsl.Checked = setting.bSsl();
            tbSender.Text  =setting.sMailAddr();
        
        }

        private void btOK_Click(object sender, EventArgs e) {
            SettingRegist();
            this.Close();
       
            }

        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void SettingRegist() {
            setting.Host = tbHost.Text;
            setting.MailAdder = tbUserName.Text;
            setting.Pass = tbPass.Text;
            setting.Port = int.Parse(tbPort.Text);
            setting.Ssl = cbSsl.Checked; ;

            this.Close();


        }


        private void btApply_Click(object sender, EventArgs e) {
            SettingRegist();
            
            
            //setting.Host = tbHost.Text;
            //setting.MailAdder = tbUserName.Text;
            //setting.Pass = tbPass.Text;
            //setting.Port = int.Parse(tbPort.Text);
            //setting.Ssl = cbSsl.Checked; ;

        
        }
    }
    }


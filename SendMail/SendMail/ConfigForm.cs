using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail {
    public partial class ConfigForm : Form {
        public Settings setting = Settings.getInstance();

        public ConfigForm() {

            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e) {

            tbHost.Text = setting.sHost();
            tbPass.Text = setting.sPass();
            tbPort.Text = setting.sPort();
            tbUserName.Text = setting.sMailAddr();
            cbSsl.Checked = setting.bSsl();
            tbSender.Text = setting.sMailAddr();

        }

        private void btOK_Click(object sender, EventArgs e) {
            //   SettingRegist();
            //setting.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked,);
            btApply_Click(sender, e);
            this.Close();



          
        

        }






        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();



        }


        //private void SettingRegist() {
        //    setting.Host = tbHost.Text;
        //    setting.MailAdder = tbUserName.Text;
        //    setting.Pass = tbPass.Text;
        //    setting.Port = int.Parse(tbPort.Text);
        //    setting.Ssl = cbSsl.Checked; ;
    //}


       
        

        private void btApply_Click(object sender, EventArgs e) {
            // SettingRegist();


            //setting.Host = tbHost.Text;
            //setting.MailAdder = tbUserName.Text;
            //setting.Pass = tbPass.Text;
            //setting.Port = int.Parse(tbPort.Text);
            //setting.Ssl = cbSsl.Checked; ;
            setting.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);

        }

        private void ConfigForm_Load(object sender, EventArgs e) {


            tbHost.Text = setting.Host;
            tbPort.Text=setting.Port.ToString();
            tbPass.Text = setting.Pass;
            tbUserName.Text = setting.MailAdder;
            cbSsl.Checked = setting.Ssl;
            tbSender.Text = setting.MailAdder;

        }
    }
}

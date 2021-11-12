using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Security;

namespace SendMail {
    public class Settings {
        private static Settings instance = null;
        public static bool Set { get; private set; } = true;

        public int Port { get; set; }//ポート番号
        public string Host { get; set; }//ホスト名
        public string MailAdder { get; set; }//メールアドレス
        public string Pass { get; set; }//パスワード
        public bool Ssl { get; set; }//SSL
        //コンストラクタ
        private Settings() {

        }

        //インスタンスの取得
        public static Settings getInstance() {

            if(instance == null) {
                instance = new Settings();
                try {
                  
                    using(var reader = XmlReader.Create("mailsetting.xml")) {
                        var serializer = new DataContractSerializer(typeof(Settings));
                        var readSetting = serializer.ReadObject(reader) as Settings;
                        instance.Host = readSetting.Host;
                        instance.Port = readSetting.Port;
                        instance.MailAdder = readSetting.MailAdder;
                        instance.Pass = readSetting.Pass;
                        instance.Ssl = readSetting.Ssl;
                        
                    }
                }
                //ファイルがない場合
                catch(FileNotFoundException ) {
                    Set = false;//データ設定                  
                }
        
            }

            return instance;
        }
        //送信データ登録
        public bool setSendConfig(string host, int port, string mailAddr, string pass, bool ssl ) {
            //シリアル化
            Host = host;
            MailAdder = mailAddr;
            Pass = pass;
            Port = port;
            Ssl = ssl;

            //XMLファイルへ書き出し（シリアル化）
            var xws = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using(var writer = XmlWriter.Create("mailsetting.xml", xws)) {

                var serializer = new DataContractSerializer(this.GetType());
                serializer.WriteObject(writer, this);

            }
            Set = true;
            return true;//登録完了
        }
        //初期値
        public string sHost() {

            return "smtp.gmail.com";
        }

        public string sPort() {

            return 587.ToString();
        }


        public string sMailAddr() {

            return "ojsinfosys01@gmail.com";
        }

        public string sPass() {

            return "Infosys2021";
        }

        public bool bSsl() {

            return true;

        }
    }
}

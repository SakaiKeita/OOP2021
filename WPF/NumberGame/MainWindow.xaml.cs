using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>

    public partial class MainWindow : Window {
                 Random rnd = new Random();
        int r1 = 0;
        int stop =0;
        int x;
        public MainWindow() {
            r1 = rnd.Next(1, 26);

           


        }

        private void Button_Click(object sender, RoutedEventArgs e) {
          

            Button btn = (Button)sender;
                if(int.Parse(btn.Content.ToString()) == r1) {
                    Ransuu.Text = "正解"
                    
                
                ;
                } else if(int.Parse(btn.Content.ToString()) < r1) {


                } else { Ransuu.Text = "大きい"; }

        }


    }
}


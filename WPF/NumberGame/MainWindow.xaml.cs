using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public MainWindow() {


            Random rnd = new Random();

            for(int j = 0; j < 10; j++) {
                Console.Write("{0} ", rnd.Next(1, 25));
            }
            Console.WriteLine(Environment.TickCount);







        }

        private void Button1_Click(object sender, RoutedEventArgs e) {
            Random rnd = new Random();
            if(rnd.Next(1, 25) == 1) {
                Button1.
            }


        }
    }
}


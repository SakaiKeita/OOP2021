using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            if(args.Length >= 1 && args[0] == "-tom") {
                // フィートからメートルへの対応表を出力
                PrintMeterToFeetList(1, 10);
            } else {
                // メートルからフィートへの対応表を出力
                PrintInchToMeterList(1, 10);
            }


           

        }

        private static void PrintInchToMeterList(int start, int stop) {

            for(int meter = start; meter <= stop; meter++) {


                double inch = Class1.ToMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} inch", meter, inch);
            }
        }
        private static void PrintMeterToFeetList(int start, int stop) {


            for(int meter = start; meter <= stop; meter++) {

                double inch = Class1.FromMeter(meter);
                Console.WriteLine("{0} inch = {1:0.0000}m ", inch, meter);
            }
        }  
        }
}

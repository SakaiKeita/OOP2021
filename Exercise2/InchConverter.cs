using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    //フィートとメートルの単位変換クラス(静的クラス)

    /*FeetConberter*///インチとメートルの単位変換クラス（静的）
    public static class Class1 {
        private const double ratio = 0.3048;



        public static double FromMeter(double meter) {
            return meter / ratio;
        }
        public static double ToMeter(double feet) {
            return feet * ratio;
        }
    }
}


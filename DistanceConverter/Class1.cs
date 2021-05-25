using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
   //フィートとメートルの単位変換クラス(静的クラス)
    
    /*FeetConberter*/
   public static class Class1 {
        public static double FromMeter(double meter) {
            return meter / 0.3048;
        }
        public static double ToMeter(double feet) { 
        return feet *0.3048;
    }
    
    
    }
}

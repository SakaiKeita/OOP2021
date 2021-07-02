using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrcise03 {
    class Program {
        static void Main(string[] args) {

            var abbrs = new Abbreviations();
            var count = abbrs.Count;
            Console.WriteLine("----7.2.3 Countの呼び出し ----");
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

            //7.2.3(Removeの呼び出し)
            Console.WriteLine("----7.2.3 Removeの呼び出し ----");
            if(abbrs.Remove("IOC")) {
                Console.WriteLine("削除されました");
            }
            if(abbrs.Remove("IOC")) {
                Console.WriteLine("削除されました");
            } else {
                Console.WriteLine("削除エラー");
            }

            //7.2.3(Removeでちゃんと消えたか確認)
            count = abbrs.Count;
            Console.WriteLine("----7.2.3 Countの呼び出し ----");
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

        }
    }
    }
}

        
        

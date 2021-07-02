using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_2(string text) {

        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();//
            foreach(var c in text) {
                //大文字の区別がないためすべて大文字に変換して処理
                var uc = char.ToUpper(c);
                if('A' <= uc && uc <= 'Z') {
                    if(dict.ContainsKey(uc)) {
                        dict[uc]++;
                
                    } else {
                        dict[uc] = 1;//新しく登録する

                    }  
                }
            }
           
            foreach(var item in dict.OrderBy(x=>x.Key)) {
                Console.WriteLine("{0}:{1}",item.Key,item.Value);
            }
        
        }
    }
}


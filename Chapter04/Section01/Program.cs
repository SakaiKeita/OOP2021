using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if(product == null) {
                //Productが取得できなかった時の処理
                Console.WriteLine("productが取得できなかった");
            } else {
               //productが取得できたとき
                Console.WriteLine("productが取得できた");
            }
        } 
            //int count = 0;
            //Console.WriteLine($"後置:{count++}");
            //Console.WriteLine($"前置:{++count}");
            // var ret = GetProductA();
            //var list = new List<int> { 10, 20, 30, 40, };
            //var key = 40;
            //var num = list.Contains(key) ? 1 : 0;//成り立ったら1
            //Console.Write(num);
            //string code = "12345";
            // var message = GetMessage(code) ?? DefaultMessage();
            //Console.WriteLine(message);
        }

      /*  private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Product = new Product();
            sale = null;
            return sale?.Product;//null条件演算子
        }

*/

    }
     
  /*  class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
    
    
  */  
    
    
    
    
    
    //スタブ
       // private static object DefaultMessage() {  
         //return "Default Message";   
           // }

    //private static object GetMessage(object code) {
    //
      //  return null;
    
    
    //}


            
            
            //0 var person = new Person {
              //  Name = "あ",
               // Birthday = new DateTime(1995, 11, 23),
             //   PhoneNumber = "123-3456-789"
           // };
       // }
           
    
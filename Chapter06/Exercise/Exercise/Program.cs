﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);

        }


        private static void Exercise1_1(int[] numbers) {


            Console.WriteLine(numbers.Max(x => x).ToString());
        }
        private static void Exercise1_2(int[] numbers) {
            var skip = numbers.Length - 2;
            foreach(var n in numbers.Skip(skip)) {
                Console.WriteLine(n);
            }
        }
      
        private static void Exercise1_3(int[] numbers) {
            var num= numbers.Select(n => n.ToString());
            foreach(var item in num) {
                Console.WriteLine(item);
            }

        }
        
        private static void Exercise1_4(int[] numbers) {
            var nums = numbers.OrderBy(n => n).Take(3);
            foreach(var num in nums) {
                Console.WriteLine(num);
            }


        }
        private static void Exercise1_5(int[] numbers) {
            var num = numbers.Distinct().Count(n => n >= 10).ToString();
            foreach(var item in num) {
                Console.WriteLine(item);
            }
        }
    }

}
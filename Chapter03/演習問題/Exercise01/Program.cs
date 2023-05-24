using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);
        }

        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            if (exists)
                Console.WriteLine("存在しています。");
            else
                Console.WriteLine("存在していません。");
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(s => Console.WriteLine(s / 2.0));
        }

        private static void Exercise1_3(List<int> numbers) {
            var wheres = numbers.Where(s => s >= 50);
            foreach(var w in wheres) {
                Console.WriteLine(w);
            }
        }
        /*短縮版
         * foreach(var w in numbars.Where(s => s >= 50){
         *     Console.WriteLine(w + " ");
         * }
         * 
         * 一行で書く場合
         * (numbers.Where(s => s >= 50).ToList()).ForEach(Console.WriteLine);
         * 
         */
        

        private static void Exercise1_4(List<int> numbers) {
            var lists = numbers.Select(s => s * 2).ToList();
            foreach(var s in lists) {
                Console.WriteLine(s + " ");
            }
        }
        //一行で書く場合(numbers.Select(s => s * 2).ToList()).ForEach(Console.WriteLine);
    }
}

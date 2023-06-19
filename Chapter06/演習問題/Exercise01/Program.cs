using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
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
            var pages = numbers.Max();
            Console.WriteLine(pages);
        }

        private static void Exercise1_2(int[] numbers) {
            var index = numbers.Skip(numbers.Length - 2);
            foreach (var s in index) {
                Console.WriteLine(s);
            }
        }

        private static void Exercise1_3(int[] numbers) {
            var select = numbers.Select(s => s.ToString());
            foreach (var item in select) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_4(int[] numbers) {
            var order = numbers.OrderBy(o => o);
            foreach (var orders in order.Skip(0).Take(3)) {
                Console.WriteLine(orders);
            }
        }

        private static void Exercise1_5(int[] numbers) {
            var results = numbers.Distinct().Count(c => c > 10);
            Console.WriteLine(results);
        }
    }
}

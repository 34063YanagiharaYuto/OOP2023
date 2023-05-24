using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var names = new List<string> {
                 "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };
            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);
        }

        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("**3.1**");
            Console.WriteLine("都市名を入力。空行で終了。");
            do {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) {
                    break;
                }
                int idx = names.FindIndex(s => s == line);
                Console.WriteLine(idx);
               
            } while (true);
                
        }

        private static void Exercise2_2(List<string> names) {
            Console.WriteLine("**3.2**");
            var cnts = names.Count(s => s.Contains("o"));
            Console.WriteLine(cnts);
        }

        private static void Exercise2_3(List<string> names) {
            Console.WriteLine("**3.3**");
            var arrays = names.Where(s => s.Contains("o")).ToArray();
            foreach(var a in arrays) {
                Console.WriteLine(a);
            }
        }

        private static void Exercise2_4(List<string> names) {
            Console.WriteLine("**3.4**");

        }
    }
}

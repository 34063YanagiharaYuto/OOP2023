using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var list = text.Split(' ').Length - 1;
            // var list = text.Count(c => c == ' '); ←この方法もある
            Console.WriteLine("空白数：{0}",list);
        }

        private static void Exercise3_2(string text) {
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            var wordcnt = text.Split(' ');
            Console.WriteLine("単語数：{0}",wordcnt.Length);
        }

        private static void Exercise3_4(string text) {
            var words = text.Split(' ').Where(w => w.Length <= 4);
            foreach (var word in words) {
                Console.WriteLine(word);
            }
        }

        private static void Exercise3_5(string text) {
            var word = text.Split(' ').ToArray();
            
            if(word.Length > 0) {
                var sb = new StringBuilder();
                foreach(var w in word) {
                    sb.Append(w + ' ');
                }
                var texts = sb.ToString();
                var replecad = texts.TrimEnd();
                Console.WriteLine("{0}",replecad);
            }
        }
    }
}

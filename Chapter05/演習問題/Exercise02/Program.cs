using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("文字列数字：");
            var num = Console.ReadLine();
            int.TryParse(num, out var nums);
            var number = nums.ToString("#,0");
            Console.WriteLine(number);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {

        static void Main(string[] args) {
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4, 15, 45, 40, 25, 35 };

            //// 5の倍数
            //int count = numbers.Count(n => n > 0 && n % 5 == 0);

            //// 3以上8未満
            //int count = numbers.Count(n => 3 <= n && n > 8);

            //// 1が含まれている数
            //int count = numbers.Count(n => n.ToString().Contains('1'));

            // 合計値(偶数のみ合計)
            var sum = numbers.Where(n => n % 2 == 0).Sum();

            Console.WriteLine(sum);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section07 {
    class Program {
        static void Main(string[] args) {
            var str = "123";

            int height;
            if (int.TryParse(str, out height)) {
                // heightには変換された値が入っている。
                Console.WriteLine(height);
            }
            else {
                // 変換に失敗した。
                Console.WriteLine("変換できません");
            }
        }

        // TryParse(変換する文字, out 変換した値を入れる変数)
    }
}

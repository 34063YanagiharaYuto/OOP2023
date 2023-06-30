using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            // 7.2.3
            // 上のAddメソッドで、2つのオブジェクトを追加しているので、
            // 読み込んだ単語数+2が、Countの値になる。

            var count = abbrs.Count;
            Console.WriteLine(count);

            Console.WriteLine(); // 改行

            // 7.2.3(Removeの呼び出し)
            if (abbrs.Remove("NPT"))
                Console.WriteLine(abbrs.Count);
            if (!abbrs.Remove("NPT"))
                Console.WriteLine("削除できません。");
            Console.WriteLine(); // 改行

            // IEnumerable<>を実装したので、LINQが使える。
            var where = abbrs.Where(w => w.Key.Length == 3);
            foreach(var a in where) {
                Console.WriteLine("{0} = {1}", a.Key, a.Value);
            }
                
            

        }
    }
}

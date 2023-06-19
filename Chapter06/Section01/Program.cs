using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4, };
            Console.WriteLine(numbers.Average());


            var books = Books.GetBooks();

            Console.WriteLine(books.Average(b => b.Price)); // Booksの価格の平均を求める
            Console.WriteLine(books.Max(n => n.Price)); // Booksの最大価格を求める

            // 500円以上の本のタイトルをすべて出力
            var title = books.Where(t => t.Title.Contains("物語"));
            var booksobj = books.Where(w => w.Price >= 500).OrderBy(d => d.Price);
            foreach(var book in booksobj) {
                Console.WriteLine("本のタイトル：{0}　 価格：{1}円",book.Title,book.Price);
            }
            


        }
    }
}

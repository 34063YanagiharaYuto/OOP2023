using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var maxprice = Library.Books.First(f => f.Price == Library.Books.Max(m => m.Price));
            Console.WriteLine(maxprice);
        }

        private static void Exercise1_3() {
            var selected = Library.Books
                            .GroupBy(g => g.PublishedYear)
                            .OrderBy(o => o.Key);                          
            foreach(var book in selected) {
                Console.WriteLine("{0}年　{1}冊",book.Key,book.Count());
            }
        }

        private static void Exercise1_4() {
            var order = Library.Books
                         .OrderByDescending(od => od.PublishedYear)
                         .OrderByDescending(o => o.Price)
                         .Join(Library.Categories, book => book.CategoryId, category => category.Id,
                               (book, category) => new {
                                   PublishedYear = book.PublishedYear,
                                   Price = book.Price,
                                   Title = book.Title,
                                   Category = category.Name,
                               }
                               );
            foreach(var v in order) {
                Console.WriteLine($"{v.PublishedYear}年 {v.Price}円 {v.Title} ({v.Category})");
            }
        }

        private static void Exercise1_5() {

        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {
        }

        private static void Exercise1_8() {
        }
    }
}

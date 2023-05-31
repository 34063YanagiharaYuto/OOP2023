using Exercise01;
using System;
using System.Linq;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            #region 演習問題4.1
            //var ym = new YearMonth(2023,12);
            //var c21 = ym.Is21Century;
            //var ymNextMonth = ym.AddOneMonth();
            //Console.WriteLine(ym); // 〇〇年〇月
            //Console.WriteLine(ymNextMonth);
            //Console.WriteLine(c21);
            #endregion

            // 4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2020, 12),
            };

            // 4.2.2
            Console.WriteLine("\n- 4.2.2 ---");
            Exercise2_2(ymCollection);
            Console.WriteLine("\n- 4.2.4 ---");

            // 4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("\n- 4.2.5 ---");


            // 4.2.5
            Exercise2_5(ymCollection);
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {

            foreach (var yearmonth in ymCollection) {
                Console.WriteLine(yearmonth);
            }

        }

        static YearMonth FindFirst21C(YearMonth[] yms) {
            foreach(var i in yms) {
                if (i.Is21Century) {
                    return i;
                }
            }return null;
            
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var ym = FindFirst21C(ymCollection);
            if(ym == null) {
                Console.WriteLine("21世紀のデータがありません。");
            }
            else {
                Console.WriteLine(ym);
            }
  
                
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var numbers = ymCollection.Select(s => s.AddOneMonth()).ToArray();
            foreach(var n in numbers) {
                Console.WriteLine(n);
            }
        }
    }
}

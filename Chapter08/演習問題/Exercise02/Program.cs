using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var day = DateTime.Now;
            var syougatuday = new DateTime(2023, 12, 28);
            var s1 = day.ToString("d");
            var s2 = syougatuday.ToString("d");
            foreach (var dayfweek in Enum.GetValues(typeof(DayOfWeek))){
                Console.Write("{0}の次の週の{1}：",s1,dayfweek);
                DateTime next = NextDay(day, (DayOfWeek)dayfweek + 7);
                Console.WriteLine(next.ToString("yyyy/MM/dd(ddd)"));
            }

            Console.WriteLine(); // 改行

            foreach (var dayfweek in Enum.GetValues(typeof(DayOfWeek))) {
                Console.Write("{0}の次の週の{1}：", s2, dayfweek);
                DateTime next = NextDay(syougatuday, (DayOfWeek)dayfweek + 7);
                Console.WriteLine(next.ToString("yyyy/MM/dd(ddd)"));
            }
        }

        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if(days <= 0)
                days += 7;
            return date.AddDays(days);
        }
    }
}

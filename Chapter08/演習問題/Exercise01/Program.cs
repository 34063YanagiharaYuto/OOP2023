using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var dateTime = new DateTime(2019, 1, 15, 19, 48, 32);
            DisplayDatePattern1(dateTime);
            DisplayDatePattern2(dateTime);
            DisplayDatePattern3(dateTime);
            DisplayDatePattern3_2(dateTime);
        }

        private static void DisplayDatePattern1(DateTime dateTime) {
            // 2019/1/15 19:48
            var dt1 = dateTime.ToString("g");
            Console.WriteLine(dt1);
            // 現在時刻
            var date = DateTime.Now;
            var dt2 = date.ToString("g");
            Console.WriteLine(dt2);
        }

        private static void DisplayDatePattern2(DateTime dateTime) {
            // 2019年01月15日 19時48日32秒
            var dt3 = dateTime.ToString("yyyy年MM月dd日 HH時mm分ss秒");
            Console.WriteLine(dt3);
            
        }

        private static void DisplayDatePattern3(DateTime dateTime) {
            // 平成31年 1月15日(火曜日)
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var dt4 = dateTime.ToString("ggyy年M月d日(dddd)");
            Console.WriteLine(dt4);
        }

        private static void DisplayDatePattern3_2(DateTime dateTime) {
            
        }
    }
}

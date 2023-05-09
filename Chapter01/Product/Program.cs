using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    class Program {
        static void Main(string[] args) {

            // 曜日の配列
            string[] DayOfWeekJp = 
                { "日曜日", "月曜日", "火曜日", "水曜日", "木曜日", "金曜日", "土曜日"};

            #region P26のサンプルプログラム
            //// インスタンス作成
            //Product karinto = new Product(123, "かりんとう", 180);
            //Product daifuku = new Product(235, "大福もち", 160);

            //// かりんとうオブジェクト表示
            //Console.WriteLine("商品コード：" + karinto.Code);
            //Console.WriteLine("商品名：" + karinto.Name);
            //Console.WriteLine("商品価格：" + karinto.Price);
            //Console.WriteLine("税込価格：" + karinto.GetPriceIncludingTax());

            //Console.WriteLine();　// 改行

            //// 大福もちオブジェクト表示
            //Console.WriteLine("商品コード：" + daifuku.Code);
            //Console.WriteLine("商品名：" + daifuku.Name);
            //Console.WriteLine("商品価格：" + daifuku.Price);
            //Console.WriteLine("税込価格：" + daifuku.GetPriceIncludingTax());
            #endregion

            #region 0508演習1
            //// DateTime date = new DateTime(2023, 5, 8);
            //DateTime date = DateTime.Today;

            //// 10日後を求める
            //DateTime daysAfter10 = date.AddDays(10);
            //DateTime daysBefore10 = date.AddDays(-10);
            //Console.WriteLine("今日の日付：" + DateTime.Today.ToString("yyyy年MM月dd日"));
            //Console.WriteLine("10日前：" + daysAfter10.ToString("yyyy年MM月dd日"));
            //Console.WriteLine("10日前：" + daysBefore10.ToString("yyyy年MM月dd日"));


            //Console.WriteLine("今日の10日後は、" + daysAfter10.Day + "日です。");
            #endregion

            #region 0508演習2
            Console.WriteLine("誕生日を入力");
            // 西暦の入力
            Console.Write("西暦:");
            int year = int.Parse(Console.ReadLine());
            // 月の入力
            Console.Write("月:");
            int month = int.Parse(Console.ReadLine());
            // 日の入力
            Console.Write("日:");
            int day = int.Parse(Console.ReadLine());

            DateTime time1 = new DateTime(year, month, day);

            DateTime time2 = DateTime.Today;

            TimeSpan TotalDays = time2 - time1;

            Console.WriteLine("あなたが生まれた曜日は" + DayOfWeekJp[(int)time1.DayOfWeek] + "です。");

            Console.WriteLine("あなたが生まれてから今日まで" + TotalDays.Days + "日目です。");
            // こっちのやり方もある↓
            // Console.WriteLine("あなたが生まれてから今日まで{0}日目です。" + TotalDays.Days);
            #endregion

        }
    }
    /* ・折り畳み
     * #region コメント文
     * ～　#endregion
     * 
     * ・コメント
     * #if false ←コメント化
     * ～　#endif
     * 
     */
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    class Program {
        static void Main(string[] args) {
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

            // DateTime date = new DateTime(2023, 5, 8);
            DateTime date = DateTime.Today;

            // 10日後を求める
            DateTime daysAfter10 = date.AddDays(10);
            DateTime daysBefore10 = date.AddDays(-10);
            Console.WriteLine("今日の日付：" + DateTime.Today.ToString("yyyy年MM月dd日"));
            Console.WriteLine("10日前：" + daysAfter10.ToString("yyyy年MM月dd日"));
            Console.WriteLine("10日前：" + daysBefore10.ToString("yyyy年MM月dd日"));


            Console.WriteLine("今日の10日後は、" + daysAfter10.Day + "日です。");



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

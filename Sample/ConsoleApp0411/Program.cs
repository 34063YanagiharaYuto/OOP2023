using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0411 {
    class Program {
        static void Main(string[] args) {

            //配列
            string[] moneyString = {"一万円札","五千円札","二千円札","千円札","五百円玉","百円玉","五十円玉","十円玉","五円玉","一円玉"};
            int[] moneyInteger = {10000,5000,2000,1000,500,100,50,10,5,1};

            //金額入力
            Console.Write("金額:");
            int total = int.Parse(Console.ReadLine());

            //支払い入力
            Console.Write("支払い:");
            int pay = int.Parse(Console.ReadLine());
            
            //おつり計算していくらかを出力
            int Change = pay - total;
            Console.Write("おつり:{0}円",Change) ;
            Console.WriteLine();//改行


            //金額枚数出力のfor文
            for (int i = 0; i < moneyString.Length; i++)
            {
                //Console.WriteLine(moneyString[i] + "：{0}枚", Change / moneyInteger[i]);
                Console.WriteLine(moneyString[i] + ":");
                astOut(Change / moneyInteger[i]);
                Change %= moneyInteger[i];
            }

            /*for (int i = 0; i < count; i++)
            {
                // 空白を出力
                for (int j = 0; j <(i + 1); j++)
                {
                    Console.Write(" ");
                }

                // "*"を出力
                for (int k = 0; k < count - (i + 1); k++)
                {
                    Console.Write("＊");  
                }

 
                Console.WriteLine();//改行
            }*/
        }

        // *出力
        private static void astOut(int count) {
            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); // 改行
        }
    }
}

/*
Ctrl + F5 デバックなしで実行
F9 ブレイクポイント
F10 ステップオーバー
F11 ステップイン

拡張子
.cs ←C#ソースファイル
.exe ←実行ファイル
*/
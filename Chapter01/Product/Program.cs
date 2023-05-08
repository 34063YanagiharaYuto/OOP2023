using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSample {
    class Program {
        static void Main(string[] args) {
            // インスタンス作成
            Product karinto = new Product(123, "かりんとう", 180);
            Product daifuku = new Product(235, "大福もち", 160);
            
            // かりんとうオブジェクト表示
            Console.WriteLine("商品コード：" + karinto.Code);
            Console.WriteLine("商品名：" + karinto.Name);
            Console.WriteLine("商品価格：" + karinto.Price);
            Console.WriteLine("税込価格：" + karinto.GetPriceIncludingTax());

            Console.WriteLine();　// 改行

            // 大福もちオブジェクト表示
            Console.WriteLine("商品コード：" + daifuku.Code);
            Console.WriteLine("商品名：" + daifuku.Name);
            Console.WriteLine("商品価格：" + daifuku.Price);
            Console.WriteLine("税込価格：" + daifuku.GetPriceIncludingTax());

        }
    }
}

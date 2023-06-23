using System;
using System.Collections.Generic;
using System.Linq;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            #region p187のプログラム
            //var flowerDict = new Dictionary<string, int>() {
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["rose"] = 500,
            //    ["dahlia"] = 450,
            //};

            //// morning glory(あさがお) [250円]を追加
            ////自分で書いた方　→　flowerDict.Add("morning glory", 250);

            //flowerDict["morning glory"] = 250;

            //Console.WriteLine("ひまわりの価格は{0}円です。", flowerDict["sunflower"]);
            //Console.WriteLine("チューリップの価格は{0}円です。", flowerDict["tulip"]);
            //Console.WriteLine("あさがおの価格は{0}円です。", flowerDict["morning glory"]);
            #endregion

            #region 県庁所在地の登録プログラム
            var Prefectures = new Dictionary<string, CityInfo>();
            Console.WriteLine("***県庁所在地の登録***");
            Console.Write("県名:");
            var Prefecture = Console.ReadLine();
            while (Prefecture != "999") {
                var cityinfo = new CityInfo();
                Console.Write("県庁所在地:");
                cityinfo.City = Console.ReadLine();
                Prefectures[Prefecture] = cityinfo;
                Console.Write("人口:");
                cityinfo.Population = int.Parse(Console.ReadLine());
                Prefectures[Prefecture] = cityinfo;

                Console.Write("県名:");
                Prefecture = Console.ReadLine();

                if (Prefectures.ContainsKey(Prefecture)) {
                    Console.WriteLine("既に入力されたものがあります。");
                    Console.WriteLine("上書きをしますか？　yes / no");
                    var uwagaki = Console.ReadLine();
                    if (uwagaki == "yes") {
                        Prefectures[Prefecture] = cityinfo;
                    }
                }
            }

            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var suuji = Console.ReadLine();
            if (suuji == "1") {
                foreach (var kennmei in Prefectures.OrderByDescending(p => p.Value.Population)) {
        
                    Console.WriteLine
                        ("{0} 【{1}(人口：{2}人)】", kennmei.Key, kennmei.Value.City,kennmei.Value.Population);
                }
            }
            else if (suuji == "2") {
                Console.Write("県名を入力:");
                var anser = Console.ReadLine();
                Console.WriteLine("【{0}(人口：{1}人)】", Prefectures[anser].City, Prefectures[anser].Population);
            }
            #endregion
        }
    }

    #region 県庁所在地の登録のCityInfoクラス
    class CityInfo {
        public string City { get; set; }    // 都市
        public int Population { get; set; } // 人口
    };
    #endregion
}

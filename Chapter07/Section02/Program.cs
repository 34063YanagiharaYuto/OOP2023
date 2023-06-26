using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02 {
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
            var prefdict = new Dictionary<string, List<CityInfo>>();
            string pref;
            Console.WriteLine("***市町村の登録***");
            while (true) {
                var cityinfo = new CityInfo();
                Console.Write("県名:");
                pref = Console.ReadLine();
                if (pref == "999") break;
                Console.Write("市町村:");
                cityinfo.City = Console.ReadLine();
                Console.Write("人口:");
                cityinfo.Population = int.Parse(Console.ReadLine());

                if (prefdict.ContainsKey(pref)) {
                    prefdict[pref].Add(cityinfo);
                }
                else {
                    prefdict[pref] = new List<CityInfo> { cityinfo };
                }
            }

            Console.WriteLine("1:一覧表示, 2:県名指定");
            Console.Write(">");
            var suuji = Console.ReadLine();
            if (suuji == "1") {
                Console.WriteLine("**市町村一覧表示**");
                foreach (var kennmei in prefdict) {
                    foreach (var term in kennmei.Value.OrderByDescending(o => o.Population)) {
                        Console.WriteLine
                            ("{0} 【{1}(人口：{2}人)】", kennmei.Key, term.City, term.Population);
                    }
                }
            }
            else if (suuji == "2") {
                Console.Write("出力する県名を入力:");
                var anser = Console.ReadLine();
                try {
                    Console.WriteLine("**{0}**", anser);
                    foreach (var kenmei in prefdict[anser]) {
                        Console.WriteLine("【{0}(人口：{1}人)】", kenmei.City, kenmei.Population);
                    }
                }
                catch (KeyNotFoundException e){
                    throw new ArgumentOutOfRangeException("入力した県名がありません。もう一度入力してください。", e);
                }
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

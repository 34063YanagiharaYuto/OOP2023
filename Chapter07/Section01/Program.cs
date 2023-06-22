using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var Prefectures = new Dictionary<string, string>() {
            };
            string Prefecture, PrefecturalCapital;
            Console.WriteLine("***県庁所在地の登録***");
            Console.Write("県名:");
            Prefecture = Console.ReadLine();

            while(Prefecture != "999") {
                Console.Write("県庁所在地:");
                PrefecturalCapital = Console.ReadLine();
                Prefectures[Prefecture] = PrefecturalCapital;

                Console.Write("県名:");
                Prefecture = Console.ReadLine();
                if (Prefectures.ContainsKey(Prefecture)) {
                    Console.WriteLine("上書きをしますか？　YES / NO");
                    var uwagaki = Console.ReadLine();
                    if(uwagaki == "yes" || uwagaki == "YES") {
                        Prefectures[Prefecture] = PrefecturalCapital;
                    } 
                }

            }

            Console.WriteLine("1:一覧表示,2:県名指定");
            Console.Write(">");
            var suuji = Console.ReadLine();
            if(suuji == "1") {
                foreach(var kennmei in Prefectures) {
                    Console.WriteLine("{0} ({1})", kennmei.Key, kennmei.Value);
                }
            }else if(suuji == "2") {
                Console.Write("県名を入力:");
                var anser = Console.ReadLine();
                Console.WriteLine("県庁所在地は、{0}です。", Prefectures[anser]);
            }
        }
    }

    class CityInfo {
        public string City { get; set; }
        public int Population { get; set; }
    };
}

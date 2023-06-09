﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {
    class Program {
        static void Main(string[] args) {
            var list = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London",
                "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //・Existsメソッド
            //var exists = list.Exists(s => s[0] == 'B');
            //Console.WriteLine(exists);

            //・Findメソッド 
            //var name = list.Find(s => s.Length == 6);
            //Console.WriteLine(name);

            //・FindIndexメソッド
            //int index = list.FindIndex(s => s == "London");
            //Console.WriteLine(index);

            //・FindAllメソッド
            //var names = list.FindAll(s => s.Length <= 5);
            //names.ForEach(s => Console.WriteLine(s));

            //・ConvertAllメソッド
            var names = list.ConvertAll(s => s.ToLower());
            names.ForEach(s => Console.WriteLine(s));

        }
    }
}

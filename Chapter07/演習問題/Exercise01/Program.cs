﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);
            Console.WriteLine();
            Exercise1_2(text);
        }

        private static void Exercise1_1(string text) {
            var dict = new Dictionary<Char, int>();
            foreach(var d in text) {
                var om = char.ToUpper(d);
                if('A' <= om  && om <= 'Z') {
                    if (dict.ContainsKey(om)) {
                        dict[om] ++;
                    }
                    else {
                        dict[om] = 1;
                    }
                }
            }

            foreach(var c in dict.OrderBy(s => s.Key)){
                Console.WriteLine("'{0}' : {1}", c.Key, c.Value);
            }
        }

        private static void Exercise1_2(string text) {
            var dict = new SortedDictionary<Char, int>();
            foreach (var d in text) {
                var om = char.ToUpper(d);
                if ('A' <= om && om <= 'Z') {
                    if (dict.ContainsKey(om)) {
                        dict[om]++;
                    }
                    else {
                        dict[om] = 1;
                    }
                }
            }

            foreach (var c in dict.OrderBy(s => s.Key)) {
                Console.WriteLine("'{0}' : {1}", c.Key, c.Value);
            }
        }
    }
}

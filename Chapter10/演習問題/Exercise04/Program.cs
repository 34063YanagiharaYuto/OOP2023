using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise04 {
    class Program {
        
        static void Main(string[] args) {
            List<string> b = new List<string>();
            var lines = File.ReadAllLines("sample.txt");
            var pattern = @"version=v4.0";
            
            foreach (var item in lines) {
                var a = Regex.Replace(item, pattern, "version=v5.0");
                b.Add(a);
            }
            
            // 書き込み
            File.WriteAllLines("sample.txt",b);

            // これ以降は確認用
            var text = File.ReadAllText("sample.txt");
            Console.WriteLine(text);
        }
    }
}

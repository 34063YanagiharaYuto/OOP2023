using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class ToHankakuProcessor : TextProcessor{
        private List<string> _items = new List<string>();
        private static Dictionary<char, char> _dictionary =
            new Dictionary<char, char>() {
                {'０', '0'},{'１', '1'},{'２', '2'},{'３', '3'},{'４', '4'},
                {'５', '5'},{'６', '6'},{'７', '7'},{'８', '8'},{'９', '9'}
            };

        protected override void Initialize(string fname) {
            
        }

        protected override void Execute(string line) {
            foreach(var d in _dictionary) {
                line = line.Replace(d.Key, d.Value);
            }
            _items.Add(line);
        }

        protected override void Terminate() {
            foreach (var item in _items) {
                Console.WriteLine(item);
            }
            
        }
    }
}

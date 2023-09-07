using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Novelist novelist = (Novelist)Exercise2_1("sample.xml");
            Exercise2_2(novelist, "novelist.json");

            // これは確認のためのコード 12.2.1
            Console.WriteLine("{0} {1}", novelist.Name, novelist.Birth);
            foreach (var title in novelist.Masterpieces) {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            // これは確認のためのコード 12.2.2
            Console.WriteLine(File.ReadAllText("novelist.json"));
            Console.WriteLine();
        }

        private static object Exercise2_1(string v) {
            using(var nove = XmlReader.Create("sample.xml")) {
                var samples = new XmlSerializer(typeof(Novelist));
                var novelist = samples.Deserialize(nove) as Novelist;
                return novelist;
            }
            
        }

        private static void Exercise2_2(object novelist, string v) {
            using(var date = new FileStream("novelist.json", FileMode.Create, FileAccess.Write)) {
                var setting = new DataContractJsonSerializerSettings {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                };
                var serializer = new DataContractJsonSerializer(novelist.GetType(),setting);
                serializer.WriteObject(date, novelist);
            }
        }
    }
}

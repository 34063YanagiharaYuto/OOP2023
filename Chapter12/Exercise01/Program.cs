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

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Exercise1_1("employee.xml");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Console.WriteLine();
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string v) {
            var emp = new Employee {
                Id = 10001,
                Name = "少林寺権三郎",
                HireDate = new DateTime(2000,1,1),
            };
            using(var writer = XmlWriter.Create("employee.xml")) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }
            using(var reader = XmlReader.Create("employee.xml")) {
                var serializer = new XmlSerializer(typeof(Employee));
                var date = serializer.Deserialize(reader) as Employee;
                Console.WriteLine(date);
            }
        }

        private static void Exercise1_2(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 10002,
                    Name = "無事山火今次郎",
                    HireDate = new DateTime(1998,5,4),
                },
                new Employee {
                    Id = 10003,
                    Name = "丸藤微次郎",
                    HireDate = new DateTime(1934,8,30),
                },
            };
            using(var writers = XmlWriter.Create("employees.xml")) {
                var serializers = new DataContractSerializer(emps.GetType());
                serializers.WriteObject(writers, emps);
            }
            
        }

        private static void Exercise1_3(string v) {
            using(XmlReader readers = XmlReader.Create("employees.xml")) {
                var serializers = new DataContractSerializer(typeof(Employee[]));
                var dates = serializers.ReadObject(readers) as Employee[];
                foreach(var date in dates) {
                    Console.WriteLine(date);
                }
            }


        }

        private static void Exercise1_4(string v) {
            var emps = new Employee[] {
                new Employee {
                    Id = 10004,
                    Name = "剛造門司丸",
                    HireDate = new DateTime(2002,1,2),
                },
                new Employee {
                    Id = 10005,
                    Name = "残門司大朗",
                    HireDate = new DateTime(2023,11,23),
                },
            };
            using(var stream = new FileStream("employees.json", FileMode.Create,FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(emps.GetType());
                serializer.WriteObject(stream, emps);
            }
            using(var streams = new FileStream("employees.json", FileMode.Open, FileAccess.Read)) {
                var serializer = new DataContractJsonSerializer(typeof(Employee[]));
                var employees = serializer.ReadObject(streams) as Employee[];
                foreach(var employee in employees) {
                    Console.WriteLine(employee);
                }
            }


        }
    }
}

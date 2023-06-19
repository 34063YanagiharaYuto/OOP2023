using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);
        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>(); // 売り上げデータを格納する
            var lines = File.ReadAllLines(filePath); // ファイルからすべてのデータを読み込む

            foreach (var line in lines) { // すべての行から一行ずつ取り出す
                var items = line.Split(','); // 区切りで項目別に分ける
                var student = new Student { // Studentインスタンスを生成
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(student); // Saleインスタンスをコレクションに追加
            }
            return scores;

        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach (var score in _score) {
                if (dict.ContainsKey(score.Name))
                    dict[score.Name] += score.Score;
                else
                    dict[score.Name] = score.Score;
            }
            return dict;

        }
    }
}

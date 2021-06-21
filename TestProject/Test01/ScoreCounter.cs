using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _student;

            public ScoreCounter(string filePath) {
                _student = ReadScore(filePath);
            }


        


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> scores = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines) {
                string[] items = line.Split(',');
                Student sale = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(sale);
            }
            return scores;
        }


        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {
                var dict = new Dictionary<string, int>();
                foreach(var sale in _student) {
                    if(dict.ContainsKey(sale.Subject))
                        //既にコレクションに店舗が設定されている
                        dict[sale.Subject] += sale.Score;
                    else
                        //コレクションへ店舗を登録
                        dict[sale.Subject] = sale.Score;
                }

        return dict;

                }
            }
}

namespace Test01 {
    class Student {
        // コンストラクタ
        public Student(string name,string subject,int score) {
            Name = name;
            Subject = subject;
            Score = score;
        }

        public string Name { get; set; }
        public string Subject { get; set; }
        public int Score { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        private Timer moveTimer;  // タイマー用
        private SoccerBall soccerBall;
        private PictureBox pb;


        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {
            // Form form = new Form();  newはメインメソッドでしてるためしない

            // this.Width = 1200; // 幅プロパティ(下でSizeを指定してるためしない)
            // this.Height = 800; // 高さプロパティ(下でSizeを指定してるためしない)

            this.Size = new Size(800, 600); // (幅, 高さ);
            this.BackColor = Color.Green;
            this.Text = "BallGame";

            // ボールインスタンス生成
            soccerBall = new SoccerBall();
            pb = new PictureBox();  // 画像を表示するコントロール
            pb.Image = soccerBall.Image;
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);  //　画像の位置 (double型をint型にキャストする)
            pb.Size = new Size(50, 50);  // 画像の表示サイズ
            pb.SizeMode = PictureBoxSizeMode.StretchImage;　// 画像の表示モード   ※列挙型(PictureBoxSizeMode)

            pb.Parent = this;

            moveTimer = new Timer();
            moveTimer.Interval = 0001;  // タイマーのインターバル (ms:ミリ秒)
            moveTimer.Start();  // タイマースタート
            moveTimer.Tick += MoveTimer_Tick;

        }

        private void MoveTimer_Tick(object sender, EventArgs e) {
            soccerBall.Move(); // 移動のメッセージを送る
            pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);  //　画像の位置 (double型をint型にキャストする)
        }

       


        /*
         * ・Formクラス ←Fromではないのでスペル注意!
         *   アプリケーションのユーザーインターフェイスを構成するウィンドウまたは
         *   ダイヤログボックスを表す。
         * 
         * ・エラーが起きてるところにカーソル合わせて
         *   Alt + Enter で修正内容を表示できる
         * 
         * ・プロパティは()がいらない
         * 
         * ・継承するときは:クラス名
         * 
         * ・ctorでTabをやるとコンストラクタ生成
         * 
         */
    }
}

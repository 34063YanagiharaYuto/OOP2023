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
        private TennisBall tennisBall;
        private PictureBox pb;

        private int ballCount = 0;

        private List<SoccerBall> balls1 = new List<SoccerBall>();  // ボールインスタンス
        private List<PictureBox> pbs1 = new List<PictureBox>();  // 表示用

        private List<TennisBall> balls2 = new List<TennisBall>();  // ボールインスタンス
        private List<PictureBox> pbs2 = new List<PictureBox>();  // 表示用





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
            this.MouseClick += Program_MouseClick;
            
            moveTimer = new Timer();
            moveTimer.Interval = 1;  // タイマーのインターバル (ms:ミリ秒)
            moveTimer.Tick += MoveTimer_Tick; // デリゲート登録 (タイマーがこの時間になったら呼ばれる)


        }

        private void Program_MouseDoubleClick(object sender, MouseEventArgs e) {
            
        }

        // マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            // ボールインスタンス生成

            if (e.Button == MouseButtons.Left)
            {
                soccerBall = new SoccerBall(e.X - 25, e.Y - 25);
                pb = new PictureBox();  // 画像を表示するコントロール
                pb.Image = soccerBall.Image;
                pb.Location = new Point((int)soccerBall.PosX, (int)soccerBall.PosY);  //　画像の位置 (double型をint型にキャストする)
                pb.Size = new Size(50, 50);  // 画像の表示サイズ
                pb.SizeMode = PictureBoxSizeMode.StretchImage;　// 画像の表示モード   ※列挙型(PictureBoxSizeMode)
                pb.Parent = this;

                balls1.Add(soccerBall);
                pbs1.Add(pb);

            }
            else 
            { 
                tennisBall = new TennisBall(e.X - 25, e.Y - 25);
                pb = new PictureBox();  // 画像を表示するコントロール
                pb.Image = tennisBall.Image;
                pb.Location = new Point((int)tennisBall.PosX, (int)tennisBall.PosY);  //　画像の位置 (double型をint型にキャストする)
                pb.Size = new Size(50, 50);  // 画像の表示サイズ
                pb.SizeMode = PictureBoxSizeMode.StretchImage;　// 画像の表示モード   ※列挙型(PictureBoxSizeMode)
                pb.Parent = this;

                balls2.Add(tennisBall);
                pbs2.Add(pb);

                
            }
            
            this.Text = "BallGame" + (++ballCount);

            moveTimer.Start();  // タイマースタート
        }

        // タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls1.Count; i++)
            {
                balls1[i].Move(); // 移動のメッセージを送る
                pbs1[i].Location = new Point((int)balls1[i].PosX, (int)balls1[i].PosY);  //　画像の位置 (double型をint型にキャストする)
            }
            for (int i = 0; i < balls2.Count; i++)
            {
                balls2[i].Move(); // 移動のメッセージを送る
                pbs2[i].Location = new Point((int)balls2[i].PosX, (int)balls2[i].PosY);  //　画像の位置 (double型をint型にキャストする)
            }
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

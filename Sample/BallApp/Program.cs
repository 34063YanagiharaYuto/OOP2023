using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Program :Form {

        Bar bar; // Barインスタンス格納用
        PictureBox pbBar; // Bar表示用

        private Timer moveTimer;  // タイマー用
       
        // Listコレクション
        private List<Obj> balls = new List<Obj>();  // ボールインスタンス
        private List<PictureBox> pbs = new List<PictureBox>();  // 表示用




        static void Main(string[] args) {
            Application.Run(new Program());
        }

        public Program() {
            // Form form = new Form();  newはメインメソッドでしてるためしない

            // this.Width = 1200; // 幅プロパティ(下でSizeを指定してるためしない)
            // this.Height = 800; // 高さプロパティ(下でSizeを指定してるためしない)

            // フォーム
            this.Size = new Size(800, 600); // (幅, 高さ);
            this.BackColor = Color.Green;
            this.Text = "BallGame";
            this.MouseClick += Program_MouseClick;
            this.KeyDown += Program_KeyDown;

            // Barインスタンス作成
            bar = new Bar(700,700);
            pbBar = new PictureBox();
            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;
            
            moveTimer = new Timer();
            moveTimer.Interval = 1;  // タイマーのインターバル (ms:ミリ秒)
            moveTimer.Tick += MoveTimer_Tick; // デリゲート登録 (タイマーがこの時間になったら呼ばれる)


        }

        // キーが押された時のイベントハンドラ
        private void Program_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyData);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

     
        // マウスクリック時のイベントハンドラ
        private void Program_MouseClick(object sender, MouseEventArgs e) {
            // ボールインスタンス生成
            Obj ballObj = null;


            PictureBox pb = new PictureBox();  // 画像を表示するコントロール
            if (e.Button == MouseButtons.Left)
            {
                ballObj = new SoccerBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(50, 50);  // 画像の表示サイズ
                
                
            }
            else if(e.Button == MouseButtons.Right)
            {
                ballObj = new TennisBall(e.X - 25, e.Y - 25);
                pb.Size = new Size(25, 25);  // 画像の表示サイズ
                
                
            }
            
            
            pb.Image = ballObj.Image;
            pb.Location = new Point((int)ballObj.PosX, (int)ballObj.PosY);  //　画像の位置 (double型をint型にキャストする)
            
            pb.SizeMode = PictureBoxSizeMode.StretchImage;　// 画像の表示モード   ※列挙型(PictureBoxSizeMode)
            pb.Parent = this;

            balls.Add(ballObj);
            pbs.Add(pb);

            this.Text = "BallGame" + "サッカーボール：" + SoccerBall.BallCount + "テニスボール：" + TennisBall.BallCount ;

            moveTimer.Start();  // タイマースタート
        }



        // タイマータイムアウト時のイベントハンドラ
        private void MoveTimer_Tick(object sender, EventArgs e) {
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Move(pbBar,pbs[i]); // 移動のメッセージを送る
                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);  //　画像の位置 (double型をint型にキャストする)
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

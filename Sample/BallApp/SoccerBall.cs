using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall {
        // フィールド
        private Image image;  // 画像データ

        private double posX;  // X座標
        private double posY;  // Y座標

        private double moveX = 7.0;  // 移動量 (X方向)
        private double moveY = 6.0;  // 移動量 (Y方向)

        // コンストラクタ
        public SoccerBall() {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = 0.0;
            PosY = 0.0;
        }

        // プロパティ
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public Image Image { get => image; set => image = value; }

        // メソッド
        public void Move() {

            Console.WriteLine("posX(X座標) = {0},posY(Y座標) = {1}", posX, posY);

            if(posX > 740 || posX < 0)
            {
                moveX = -moveX;

            }
            if(posY > 520 || posY < 0)
            {
                moveY = -moveY;
            }
            
            PosX += moveX;
            PosY += moveY;



        }
    }
}

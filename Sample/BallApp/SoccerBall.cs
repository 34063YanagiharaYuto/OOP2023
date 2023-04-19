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

        private double moveX;  // 移動量 (X方向)
        private double moveY;  // 移動量 (Y方向)

        Random rd = new Random();

        // コンストラクタ
        public SoccerBall(double xp,double yp) {
            Image = Image.FromFile(@"pic\soccer_ball.png");
            PosX = xp;
            PosY = yp;

            int rdX = rd.Next(-15, 50);
            int rdY = rd.Next(-15, 50);

            moveX = (rdX != 0 ? rdX : 1);
            moveY = (rdY != 0 ? rdY : -1);
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

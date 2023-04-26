using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class SoccerBall : Obj{

        

        Random rd = new Random(); // 乱数インスタンス
        private static int ballCount = 0;

        public static int BallCount { get => ballCount; set => ballCount = value; }

        // コンストラクタ
        public SoccerBall(double xp, double yp) : base(xp,yp,@"pic\soccer_ball.png") {

            int rdX = rd.Next(-15, 25);
            MoveX = (rdX != 0 ? rdX : 1); // 乱数で移動量を設定

            int rdY = rd.Next(-15, 25);
            MoveY = (rdY != 0 ? rdY : -1); // 乱数で移動量を設定
            BallCount++;

        }

        // メソッド
        public override void Move() {

            // Console.WriteLine("posX(X座標) = {0},posY(Y座標) = {1}", PosX, PosY);

            if (PosX > 740 || PosX < 0)
            {
                MoveX = -MoveX;

            }
            if (PosY > 520 || PosY < 0)
            {
                MoveY = -MoveY;
            }

            PosX += MoveX;
            PosY += MoveY;

        }
            
  
    }
}

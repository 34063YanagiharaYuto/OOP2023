using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    class TennisBall : Obj {

        Random rd = new Random();

        public TennisBall(double xp, double yp) : base(xp, yp, @"pic\tennis_ball.png") {

            int rdX = rd.Next(-15, 25);
            MoveX = (rdX != 0 ? rdX : 1); // 乱数で移動量を設定

            int rdY = rd.Next(-15, 25);
            MoveY = (rdY != 0 ? rdY : -1); // 乱数で移動量を設定

        }

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

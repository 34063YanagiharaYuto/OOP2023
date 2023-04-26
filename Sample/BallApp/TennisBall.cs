using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class TennisBall : Obj {

        Random rd = new Random();
        private static int ballCount = 0;

        public static int BallCount { get => ballCount; set => ballCount = value; }

        public TennisBall(double xp, double yp) : base(xp, yp, @"pic\tennis_ball.png") {

            int rdX = rd.Next(-15, 25);
            MoveX = (rdX != 0 ? rdX : 1); // 乱数で移動量を設定

            int rdY = rd.Next(-15, 25);
            MoveY = (rdY != 0 ? rdY : -1); // 乱数で移動量を設定
            BallCount++;
        }

        public override void Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBall.Location.X, pbBall.Location.Y, pbBall.Width, pbBall.Height);

            Rectangle rBall = new Rectangle(pbBar.Location.X, pbBar.Location.Y, pbBar.Width, pbBar.Height);

            // Console.WriteLine("posX(X座標) = {0},posY(Y座標) = {1}", PosX, PosY);

            if (PosX > 740 || PosX < 0 || rBar.IntersectsWith(rBall))
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
        public override void Move(Keys directrion) {
            ;
        }
    }
}

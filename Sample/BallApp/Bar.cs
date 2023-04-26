using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    class Bar : Obj {
        public Bar(double xp,double yp) : base(300,500, @"pic\bar.png") {
            base.MoveX = 10;
            base.MoveY = 0;
        }

        // 抽象クラスを継承してるので、不要なメソッドは空にする
        public override void Move(PictureBox pbBar, PictureBox pbBall) {
            ; // (からのメソッドにする)
        }

        public override void Move(Keys direction) {
            if (direction == Keys.Left)
            {
                if(PosX > 0)
                {
                    PosX -= MoveX;
                }
            }else if (direction == Keys.Right)
            {
                if(PosX < 635)
                {
                    PosX += MoveX;
                }
                
            }
        }

    }
}

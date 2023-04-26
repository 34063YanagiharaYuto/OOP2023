using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallApp {
    // 抽象クラス
    abstract class Obj {
        // フィールド
        private Image image;  // 画像データ
        private double posX;  // X座標
        private double posY;  // Y座標
        private double moveX;  // 移動量 (X方向)
        private double moveY;  // 移動量 (Y方向)

        // コンストラクタ
        public Obj(double PosX, double PosY,string path) {
            this.PosX = PosX;
            this.PosY = PosY;
            Image = Image.FromFile(path);
            
            // 後ほど追加あり
        }

        // プロパティ
        public Image Image { get => image; set => image = value; }
        public double PosX { get => posX; set => posX = value; }
        public double PosY { get => posY; set => posY = value; }
        public double MoveX { get => moveX; set => moveX = value; }
        public double MoveY { get => moveY; set => moveY = value; }

        // 移動メソッド(抽象メソッド)
        public abstract void Move(PictureBox pbBar, PictureBox pbBall);
        public abstract void Move(Keys directrion);
        
    }
}

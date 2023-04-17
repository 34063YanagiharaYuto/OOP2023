using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

      
        private void btButton_Click(object sender, EventArgs e) {

            this.BackColor = Color.LightSteelBlue;
            btButton.BackColor = Color.Red;
            //tbAnswer.Text = (int.Parse(tbNum1.Text) + int.Parse(tbNum2.Text)).ToString();
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAnswer.Text = sum.ToString();

        }

        // イベントハンドラ
        private void btPow_Click(object sender, EventArgs e) {
            int num01 = (int)nmdX.Value;
            int num02 = (int)nmdY.Value;
            int sum = 1; // 初期値を1にする(0にしてしまうと掛け算で0になるから)
            for (int i = 0; i < num02; i++) // num01がnum02乗分繰り返す
            {
                sum = sum * num01;
            }
            tbResult.Text = sum.ToString();
        }

    }
    /* プログラム作成
     * ↓
     *ビルド Ctrl + Shift + B　ビルド含め下はCtrl + F5 (F5)
     *↓
     *実行ファイル(.exe)
     *↓ダブルクリック
     *アプリの実行
     */
}

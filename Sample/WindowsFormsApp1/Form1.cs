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
            // tbNum1.Text = "楽しいC＃";
            this.BackColor = Color.LightSteelBlue;
            btButton.BackColor = Color.Red;
            //tbAnswer.Text = (int.Parse(tbNum1.Text) + int.Parse(tbNum2.Text)).ToString();
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            int sum = num1 + num2;
            tbAnswer.Text = sum.ToString();

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

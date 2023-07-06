using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            
        }

        private void btdayCalc_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            var dtp = dtpDate.Value;
            var anser = (now - dtp).Days;

            tbMessage.Text = "あなたの誕生日から" + anser + "日が経ちました。";
        }

        private void tbTimeNow_TextChanged(object sender, EventArgs e) {
        }

        private void Form1_Load(object sender, EventArgs e) {
            tmTimeDisp.Start(); // タイマースタート
        }

        private void btAge_Click(object sender, EventArgs e) {
            var age = GetAge(dtpDate.Value, DateTime.Now);
            tbMessage.Text = "あなたの年齢は、" + age + "才です。";
        }

        public static int GetAge(DateTime birthday,DateTime targetday) {
            var age = targetday.Year - birthday.Year;
            if(targetday < birthday.AddYears(age)) {
                age--;
            }
            return age;

        }

        // タイマーイベントハンドラー
        private void tmTimeDisp_Tick(object sender, EventArgs e) {
            var now = DateTime.Now;
            tbTimeNow.Text = now.ToString("yyyy年MM月dd日(dddd)　 HH時mm分ss秒");
        }

        #region マイナスする年月日
        private void minusYear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(-1);
            tbMessage.Text = dtpDate.Value.ToLongDateString();
        }

        private void minusMonth_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddMonths(-1);
            tbMessage.Text = dtpDate.Value.ToLongDateString();
        }

        private void minusDay_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddDays(-1);
            tbMessage.Text = dtpDate.Value.ToLongDateString();
        }
        #endregion

        #region プラスする年月日
        private void plusYear_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddYears(1);
            tbMessage.Text = dtpDate.Value.ToLongDateString();
        }

        private void plusMonth_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddMonths(1);
            tbMessage.Text = dtpDate.Value.ToLongDateString();
        }

        private void plusDay_Click(object sender, EventArgs e) {
            dtpDate.Value = dtpDate.Value.AddDays(1);
            tbMessage.Text = dtpDate.Value.ToLongDateString();
        }
        #endregion
    }
}

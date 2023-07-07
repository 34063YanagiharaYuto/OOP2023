using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        // 管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        // 追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport cr = new CarReport();
            cr.Date = dtpDate.Value;
            cr.Author = cbAuthor.Text;
            cr.Maker = getSelectedMaker();
            cr.CarName = cbCarName.Text;
            cr.Report = tbReport.Text;
            cr.CarImage = pbCarImage.Image;

            CarReports.Add(cr);
            dgvCarReports.DataSource = CarReports;
        }

        private CarReport.MakerGroup getSelectedMaker() {
            
            if (rbToyota.Checked == true)
                return CarReport.MakerGroup.トヨタ;
            if (rbHonda.Checked == true)
                return CarReport.MakerGroup.ホンダ;
            return CarReport.MakerGroup.その他;
        }
    }
}

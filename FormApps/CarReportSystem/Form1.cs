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

        // ステータスラベルのテキスト表示・非表示(引数なしは、メッセージ非表示)
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        // 追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {

            if(cbAuthor.Text == "") {
                statasLabelDisp( "記録者を入力してください。");
                return;
            }else if(cbCarName.Text == "") {
                statasLabelDisp("車名を入力してください。");
                return;
            }
            else {
                statasLabelDisp(); // ステータスラベルのテキスト非表示
            }

            var cr = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCarImage.Image,
            };
            CarReports.Add(cr);
            if (!cbAuthor.Items.Contains(cbAuthor.Text)) {
                cbAuthor.Items.Add(cbAuthor.Text);
            }
            if (!cbCarName.Items.Contains(cbCarName.Text)) {
                cbCarName.Items.Add(cbCarName.Text);
            }
            dgvCarReports.DataSource = CarReports;
            dgvCarReports.ClearSelection();
            clear();
            
        }

        // ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                    return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
        }

        // 指定したメーカーのラジオボタンをセット
        private void setSelectedfMaler(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFileOpen.ShowDialog();
            pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
            Close();
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            if (CarReports.Count == 0) {
                btDeleteReport.Enabled = false;
                btModifyReport.Enabled = false;
                clear();
            }
            clear();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false; // 画像項目非表示
            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;

        }

        private void dgvCarReports_Click(object sender, EventArgs e) {
            btModifyReport.Enabled = true;
            btDeleteReport.Enabled = true;
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            var temp = dgvCarReports.CurrentRow.Cells[2].Value;
            setSelectedfMaler((CarReport.MakerGroup)temp);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;

        }

        // 修正ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {
            CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
            CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
            CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
            CarReports[dgvCarReports.CurrentRow.Index].CarImage = pbCarImage.Image;
            dgvCarReports.Refresh();  // 一覧更新


            //dgvCarReports.CurrentRow.Cells[0].Value = dtpDate.Value;
            //dgvCarReports.CurrentRow.Cells[1].Value = cbAuthor.Text;
            //dgvCarReports.CurrentRow.Cells[2].Value = getSelectedMaker();
            //dgvCarReports.CurrentRow.Cells[3].Value = cbCarName.Text;
            //dgvCarReports.CurrentRow.Cells[4].Value = tbReport.Text;
            //dgvCarReports.CurrentRow.Cells[5].Value = pbCarImage.Image;


        }
        private void clear() {
            cbAuthor.Text = "";
            rbToyota.Checked = true;
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();   // モーダルダイヤログの
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }
    }

}


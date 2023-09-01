using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        // 管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private int num = 0;

        // 設定情報保存用オブジェクト
        Settings settings = new Settings();

        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        // ステータスラベルのテキスト表示・非表示(引数なしは、メッセージ非表示)
        private void statasLabelDisp(string msg = "") {
            tsText.Text = msg;
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
            Setauthor(cbAuthor.Text);
            SetcarName(cbCarName.Text);
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
            if(ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
                btScaleChange.Enabled = true;
                btImageDelete.Enabled = true;
            }
        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            CarReports.RemoveAt(dgvCarReports.CurrentRow.Index);
            btDeleteReport.Enabled = false;
            btModifyReport.Enabled = false;
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;
            clear();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false; // 画像項目非表示
            tsText.Text = "";
            btModifyReport.Enabled = false;
            btDeleteReport.Enabled = false;
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;
            tmNow.Start();

            dgvCarReports.RowsDefaultCellStyle.BackColor = Color.Beige; // 全体に色を設定
            dgvCarReports.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine; // 奇数行の色を上書き設定

            try {
                // 設定ファイルを逆シリアル化して背景を設定
                using (var reader = XmlReader.Create("settings.xml")) {
                    var serializer = new XmlSerializer(typeof(Settings));
                    settings = serializer.Deserialize(reader) as Settings;
                    BackColor = Color.FromArgb(settings.MainFormColor);
                }
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        

        // 修正ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count != 0) {
                CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
                CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
                CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
                CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
                CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
                CarReports[dgvCarReports.CurrentRow.Index].CarImage = pbCarImage.Image;
                dgvCarReports.Refresh();  // 一覧更新
                dgvCarReports.ClearSelection();
            }

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
            dgvCarReports.ClearSelection();
        }

        // 終了メニュー選択時のイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();   // モーダルダイヤログとして表示
        }

        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
            if(pbCarImage.Image == null) {
                btScaleChange.Enabled = false;
                btImageDelete.Enabled = false;
            }
        }

        // カーレポートシステムの裏の色設定
        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if(cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }           
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
            //pbCarImage.SizeMode = 
            //    mode < PictureBoxSizeMode.Zoom ? 
            //    ((mode == PictureBoxSizeMode.StretchImage) ? PictureBoxSizeMode.CenterImage : ++mode)
            //    : PictureBoxSizeMode.Normal;

            num = num < 4 ? ((num == 1) ? 3 : ++num) : 0;
            pbCarImage.SizeMode = (PictureBoxSizeMode)num;
        }

        private void tmNow_Tick(object sender, EventArgs e) {
            var now = DateTime.Now;
            tsTimerNow.Text = now.ToString("現在時刻：" + "yyyy年MM月dd日(ddd)HH時mm分ss秒");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            // 設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("Settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void 開くOToolStripMenuItem_Click(object sender, EventArgs e) {
            if (ofdCarRepoOpen1.ShowDialog() == DialogResult.OK) {
                try {
                    // 逆シリアル化でバイナリ形式を取り込む
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdCarRepoOpen1.FileName, FileMode.Open, FileAccess.Read)) {
                        CarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReports.DataSource = null;
                        dgvCarReports.DataSource = CarReports;
                        dgvCarReports.ClearSelection();
                        dgvCarReports.Columns[5].Visible = false; // 画像項目非表示
                        cbAuthor.Items.Clear();
                        cbCarName.Items.Clear();
                        clear(); // 入力途中などのデータをすべて削除
                        foreach(var reports in CarReports) {
                            Setauthor(reports.Author);
                            SetcarName(reports.CarName);
                        }                        
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // ファイルの保存する
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e) {
            if(sfdCarRepoSave.ShowDialog() == DialogResult.OK) {
                try {
                    // バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdCarRepoSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, CarReports);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        // cbAuthorのコンボボックス登録
        private void Setauthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        // cbCarNameのコンボボックスの登録
        private void SetcarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        private void dgvCarReports_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (0 < dgvCarReports.RowCount) {
                btModifyReport.Enabled = true;
                btDeleteReport.Enabled = true;
                btScaleChange.Enabled = true;
                btImageDelete.Enabled = true;
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                var temp = dgvCarReports.CurrentRow.Cells[2].Value;
                setSelectedfMaler((CarReport.MakerGroup)temp);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCarImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
            }
        }
    }
}


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
        Settings settings = Settings.getInstance();

        public Form1() {
            InitializeComponent();
        }

        // ステータスラベルのテキスト表示・非表示(引数なしは、メッセージ非表示)
        private void statasLabelDisp(string msg = "") {
            tsText.Text = msg;
        }

        // 追加ボタンがクリックされた時のイベントハンドラー
        private void btAddReport_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "") {
                statasLabelDisp("記録者を入力してください。");
                return;
            }
            else if (cbCarName.Text == "") {
                statasLabelDisp("車名を入力してください。");
                return;
            }
            else {
                statasLabelDisp(); // ステータスラベルのテキスト非表示
            }

            DataRow newRow = infosys202308DataSet.CarReportTable.NewRow();

            newRow[1] = dtpDate.Value;
            newRow[2] = cbAuthor.Text;
            newRow[3] = getSelectedMaker();
            newRow[4] = cbCarName.Text;
            newRow[5] = tbReport.Text;
            newRow[6] = ImageToByteArray(pbCarImage.Image);

            infosys202308DataSet.CarReportTable.Rows.Add(newRow);
            this.carReportTableTableAdapter.Update(infosys202308DataSet.CarReportTable);

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
        private void setSelectedfMaler(string makerGroup) {
            switch (makerGroup) {
                case "トヨタ":
                    rbToyota.Checked = true;
                    break;
                case "日産":
                    rbNissan.Checked = true;
                    break;
                case "ホンダ":
                    rbHonda.Checked = true;
                    break;
                case "スバル":
                    rbSubaru.Checked = true;
                    break;
                case "スズキ":
                    rbSuzuki.Checked = true;
                    break;
                case "ダイハツ":
                    rbDaihatsu.Checked = true;
                    break;
                case "輸入車":
                    rbImported.Checked = true;
                    break;
                case "その他":
                    rbOther.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            if (ofdImageFileOpen.ShowDialog() == DialogResult.OK) {
                pbCarImage.Image = Image.FromFile(ofdImageFileOpen.FileName);
                btScaleChange.Enabled = true;
                btImageDelete.Enabled = true;
            }
        }

        // 削除ボタンハンドラ
        private void btDeleteReport_Click(object sender, EventArgs e) {
            dgvCarReports.Rows.RemoveAt(dgvCarReports.CurrentRow.Index);
            this.carReportTableTableAdapter.Update(infosys202308DataSet.CarReportTable);
            btDeleteReport.Enabled = false;
            btModifyReport.Enabled = false;
            btScaleChange.Enabled = false;
            btImageDelete.Enabled = false;
            clear();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[6].Visible = false; // 画像項目非表示
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
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        // 修正ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {

            dgvCarReports.CurrentRow.Cells[1].Value = dtpDate.Value;
            dgvCarReports.CurrentRow.Cells[2].Value = cbAuthor.Text;
            dgvCarReports.CurrentRow.Cells[3].Value = getSelectedMaker();
            dgvCarReports.CurrentRow.Cells[4].Value = cbCarName.Text;
            dgvCarReports.CurrentRow.Cells[5].Value = tbReport.Text;
            dgvCarReports.CurrentRow.Cells[6].Value = pbCarImage.Image;

            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202308DataSet);
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
            if (pbCarImage.Image == null) {
                btScaleChange.Enabled = false;
                btImageDelete.Enabled = false;
            }
        }

        // カーレポートシステムの裏の色設定
        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
        }

        private void btScaleChange_Click(object sender, EventArgs e) {
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
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[1].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[2].Value.ToString();
                var temp = dgvCarReports.CurrentRow.Cells[3].Value;
                setSelectedfMaler(temp.ToString());
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[5].Value.ToString();

                // 別のやり方
                pbCarImage.Image = !dgvCarReports.CurrentRow.Cells[6].Value.Equals(DBNull.Value)
                                        && ((Byte[])dgvCarReports.CurrentRow.Cells[6].Value).Length != 0 ?
                                    ByteArrayToImage((Byte[])dgvCarReports.CurrentRow.Cells[6].Value) : null;
            }
        }

        // バイト配列をImageオブジェクトに変換
        public static Image ByteArrayToImage(byte[] b) {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(b);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img) {
            ImageConverter imgconv = new ImageConverter();
            byte[] b = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return b;
        }

        private void carReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.carReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202308DataSet);
        }

        // 接続イベントハンドラー
        private void dbConnection() {
            // TODO: このコード行はデータを 'infosys202308DataSet.CarReportTable' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.carReportTableTableAdapter.Fill(this.infosys202308DataSet.CarReportTable);
            dgvCarReports.DataSource = infosys202308DataSet.CarReportTable;

            // DBのAuthorとCarNameをコンボボックスに登録
            foreach (var reports in infosys202308DataSet.CarReportTable) {
                Setauthor(reports.Author);
                SetcarName(reports.CarName);
            }
        }

        private void 接続OToolStripMenuItem_Click_1(object sender, EventArgs e) {
            dbConnection();
        }
    }
}


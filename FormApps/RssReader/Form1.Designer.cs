
namespace RssReader {
    partial class fmRssReaderWindow {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btAddUrl = new System.Windows.Forms.Button();
            this.rb = new System.Windows.Forms.RadioButton();
            this.gbButon = new System.Windows.Forms.GroupBox();
            this.rb6 = new System.Windows.Forms.RadioButton();
            this.rb7 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.cbSaveLink = new System.Windows.Forms.ComboBox();
            this.tbUrlName = new System.Windows.Forms.TextBox();
            this.gbButon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(12, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(821, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(839, 12);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(95, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 15;
            this.lbRssTitle.Location = new System.Drawing.Point(245, 102);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(689, 154);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.Click += new System.EventHandler(this.lbRssTitle_Click);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(12, 268);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(922, 393);
            this.wbBrowser.TabIndex = 3;
            // 
            // btAddUrl
            // 
            this.btAddUrl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddUrl.Location = new System.Drawing.Point(839, 59);
            this.btAddUrl.Name = "btAddUrl";
            this.btAddUrl.Size = new System.Drawing.Size(95, 31);
            this.btAddUrl.TabIndex = 5;
            this.btAddUrl.Text = "登録";
            this.btAddUrl.UseVisualStyleBackColor = true;
            this.btAddUrl.Click += new System.EventHandler(this.btAddUrl_Click);
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb.Location = new System.Drawing.Point(6, 18);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(57, 19);
            this.rb.TabIndex = 7;
            this.rb.TabStop = true;
            this.rb.Tag = "0";
            this.rb.Text = "主要";
            this.rb.UseVisualStyleBackColor = true;
            this.rb.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // gbButon
            // 
            this.gbButon.BackColor = System.Drawing.Color.MintCream;
            this.gbButon.Controls.Add(this.rb6);
            this.gbButon.Controls.Add(this.rb7);
            this.gbButon.Controls.Add(this.rb8);
            this.gbButon.Controls.Add(this.rb4);
            this.gbButon.Controls.Add(this.rb5);
            this.gbButon.Controls.Add(this.rb1);
            this.gbButon.Controls.Add(this.rb2);
            this.gbButon.Controls.Add(this.rb3);
            this.gbButon.Controls.Add(this.rb);
            this.gbButon.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gbButon.Location = new System.Drawing.Point(12, 105);
            this.gbButon.Name = "gbButon";
            this.gbButon.Size = new System.Drawing.Size(227, 151);
            this.gbButon.TabIndex = 8;
            this.gbButon.TabStop = false;
            this.gbButon.Text = "ジャンル一覧";
            // 
            // rb6
            // 
            this.rb6.AutoSize = true;
            this.rb6.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb6.Location = new System.Drawing.Point(6, 121);
            this.rb6.Name = "rb6";
            this.rb6.Size = new System.Drawing.Size(40, 19);
            this.rb6.TabIndex = 15;
            this.rb6.TabStop = true;
            this.rb6.Tag = "6";
            this.rb6.Text = "IT";
            this.rb6.UseVisualStyleBackColor = true;
            this.rb6.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb7
            // 
            this.rb7.AutoSize = true;
            this.rb7.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb7.Location = new System.Drawing.Point(78, 121);
            this.rb7.Name = "rb7";
            this.rb7.Size = new System.Drawing.Size(57, 19);
            this.rb7.TabIndex = 14;
            this.rb7.TabStop = true;
            this.rb7.Tag = "7";
            this.rb7.Text = "科学";
            this.rb7.UseVisualStyleBackColor = true;
            this.rb7.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb8.Location = new System.Drawing.Point(149, 121);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(57, 19);
            this.rb8.TabIndex = 13;
            this.rb8.TabStop = true;
            this.rb8.Tag = "8";
            this.rb8.Text = "地域";
            this.rb8.UseVisualStyleBackColor = true;
            this.rb8.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb4.Location = new System.Drawing.Point(78, 69);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(71, 19);
            this.rb4.TabIndex = 12;
            this.rb4.TabStop = true;
            this.rb4.Tag = "4";
            this.rb4.Text = "エンタメ";
            this.rb4.UseVisualStyleBackColor = true;
            this.rb4.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb5.Location = new System.Drawing.Point(149, 69);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(75, 19);
            this.rb5.TabIndex = 11;
            this.rb5.TabStop = true;
            this.rb5.Tag = "5";
            this.rb5.Text = "スポーツ";
            this.rb5.UseVisualStyleBackColor = true;
            this.rb5.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb1.Location = new System.Drawing.Point(78, 17);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(57, 19);
            this.rb1.TabIndex = 10;
            this.rb1.TabStop = true;
            this.rb1.Tag = "1";
            this.rb1.Text = "国内";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb2.Location = new System.Drawing.Point(149, 17);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(57, 19);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Tag = "2";
            this.rb2.Text = "国際";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rb3.Location = new System.Drawing.Point(6, 69);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(57, 19);
            this.rb3.TabIndex = 8;
            this.rb3.TabStop = true;
            this.rb3.Tag = "3";
            this.rb3.Text = "経済";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // cbSaveLink
            // 
            this.cbSaveLink.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbSaveLink.FormattingEnabled = true;
            this.cbSaveLink.Location = new System.Drawing.Point(12, 59);
            this.cbSaveLink.Name = "cbSaveLink";
            this.cbSaveLink.Size = new System.Drawing.Size(427, 32);
            this.cbSaveLink.TabIndex = 9;
            this.cbSaveLink.TextChanged += new System.EventHandler(this.cbSaveLink_TextChanged);
            // 
            // tbUrlName
            // 
            this.tbUrlName.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrlName.Location = new System.Drawing.Point(445, 60);
            this.tbUrlName.Name = "tbUrlName";
            this.tbUrlName.Size = new System.Drawing.Size(388, 31);
            this.tbUrlName.TabIndex = 10;
            // 
            // fmRssReaderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(948, 673);
            this.Controls.Add(this.tbUrlName);
            this.Controls.Add(this.cbSaveLink);
            this.Controls.Add(this.gbButon);
            this.Controls.Add(this.btAddUrl);
            this.Controls.Add(this.wbBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmRssReaderWindow";
            this.Text = "RssReader";
            this.Load += new System.EventHandler(this.fmRssReaderWindow_Load);
            this.gbButon.ResumeLayout(false);
            this.gbButon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btAddUrl;
        private System.Windows.Forms.RadioButton rb;
        private System.Windows.Forms.GroupBox gbButon;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb6;
        private System.Windows.Forms.RadioButton rb7;
        private System.Windows.Forms.RadioButton rb8;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.ComboBox cbSaveLink;
        private System.Windows.Forms.TextBox tbUrlName;
    }
}


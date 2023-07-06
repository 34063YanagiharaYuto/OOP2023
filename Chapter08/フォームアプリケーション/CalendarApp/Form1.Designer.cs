
namespace CalendarApp {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btdayCalc = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.minusMonth = new System.Windows.Forms.Button();
            this.plusYear = new System.Windows.Forms.Button();
            this.minusYear = new System.Windows.Forms.Button();
            this.plusMonth = new System.Windows.Forms.Button();
            this.minusDay = new System.Windows.Forms.Button();
            this.plusDay = new System.Windows.Forms.Button();
            this.nowClock = new System.Windows.Forms.Label();
            this.tbTimeNow = new System.Windows.Forms.TextBox();
            this.btAge = new System.Windows.Forms.Button();
            this.tmTimeDisp = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "日付：";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dtpDate.Location = new System.Drawing.Point(88, 24);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 31);
            this.dtpDate.TabIndex = 1;
            // 
            // btdayCalc
            // 
            this.btdayCalc.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btdayCalc.Location = new System.Drawing.Point(119, 83);
            this.btdayCalc.Name = "btdayCalc";
            this.btdayCalc.Size = new System.Drawing.Size(133, 42);
            this.btdayCalc.TabIndex = 2;
            this.btdayCalc.Text = "日数計算";
            this.btdayCalc.UseVisualStyleBackColor = true;
            this.btdayCalc.Click += new System.EventHandler(this.btdayCalc_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMessage.Location = new System.Drawing.Point(294, 2);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(555, 294);
            this.tbMessage.TabIndex = 3;
            // 
            // minusMonth
            // 
            this.minusMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minusMonth.Location = new System.Drawing.Point(105, 256);
            this.minusMonth.Name = "minusMonth";
            this.minusMonth.Size = new System.Drawing.Size(75, 38);
            this.minusMonth.TabIndex = 4;
            this.minusMonth.Text = "ー月";
            this.minusMonth.UseVisualStyleBackColor = true;
            this.minusMonth.Click += new System.EventHandler(this.minusMonth_Click);
            // 
            // plusYear
            // 
            this.plusYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plusYear.Location = new System.Drawing.Point(203, 212);
            this.plusYear.Name = "plusYear";
            this.plusYear.Size = new System.Drawing.Size(75, 38);
            this.plusYear.TabIndex = 4;
            this.plusYear.Text = "＋年";
            this.plusYear.UseVisualStyleBackColor = true;
            this.plusYear.Click += new System.EventHandler(this.plusYear_Click);
            // 
            // minusYear
            // 
            this.minusYear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minusYear.Location = new System.Drawing.Point(105, 212);
            this.minusYear.Name = "minusYear";
            this.minusYear.Size = new System.Drawing.Size(75, 38);
            this.minusYear.TabIndex = 4;
            this.minusYear.Text = "ー年";
            this.minusYear.UseVisualStyleBackColor = true;
            this.minusYear.Click += new System.EventHandler(this.minusYear_Click);
            // 
            // plusMonth
            // 
            this.plusMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plusMonth.Location = new System.Drawing.Point(203, 258);
            this.plusMonth.Name = "plusMonth";
            this.plusMonth.Size = new System.Drawing.Size(75, 38);
            this.plusMonth.TabIndex = 4;
            this.plusMonth.Text = "＋月";
            this.plusMonth.UseVisualStyleBackColor = true;
            this.plusMonth.Click += new System.EventHandler(this.plusMonth_Click);
            // 
            // minusDay
            // 
            this.minusDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minusDay.Location = new System.Drawing.Point(105, 300);
            this.minusDay.Name = "minusDay";
            this.minusDay.Size = new System.Drawing.Size(75, 38);
            this.minusDay.TabIndex = 4;
            this.minusDay.Text = "ー日";
            this.minusDay.UseVisualStyleBackColor = true;
            this.minusDay.Click += new System.EventHandler(this.minusDay_Click);
            // 
            // plusDay
            // 
            this.plusDay.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plusDay.Location = new System.Drawing.Point(203, 302);
            this.plusDay.Name = "plusDay";
            this.plusDay.Size = new System.Drawing.Size(75, 38);
            this.plusDay.TabIndex = 4;
            this.plusDay.Text = "＋日";
            this.plusDay.UseVisualStyleBackColor = true;
            this.plusDay.Click += new System.EventHandler(this.plusDay_Click);
            // 
            // nowClock
            // 
            this.nowClock.AutoSize = true;
            this.nowClock.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nowClock.Location = new System.Drawing.Point(12, 405);
            this.nowClock.Name = "nowClock";
            this.nowClock.Size = new System.Drawing.Size(118, 24);
            this.nowClock.TabIndex = 0;
            this.nowClock.Text = "現在時刻：";
            // 
            // tbTimeNow
            // 
            this.tbTimeNow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTimeNow.Location = new System.Drawing.Point(136, 402);
            this.tbTimeNow.Multiline = true;
            this.tbTimeNow.Name = "tbTimeNow";
            this.tbTimeNow.Size = new System.Drawing.Size(560, 33);
            this.tbTimeNow.TabIndex = 3;
            this.tbTimeNow.TextChanged += new System.EventHandler(this.tbTimeNow_TextChanged);
            // 
            // btAge
            // 
            this.btAge.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAge.Location = new System.Drawing.Point(119, 131);
            this.btAge.Name = "btAge";
            this.btAge.Size = new System.Drawing.Size(133, 43);
            this.btAge.TabIndex = 5;
            this.btAge.Text = "年齢";
            this.btAge.UseVisualStyleBackColor = true;
            this.btAge.Click += new System.EventHandler(this.btAge_Click);
            // 
            // tmTimeDisp
            // 
            this.tmTimeDisp.Interval = 500;
            this.tmTimeDisp.Tick += new System.EventHandler(this.tmTimeDisp_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.btAge);
            this.Controls.Add(this.plusYear);
            this.Controls.Add(this.minusYear);
            this.Controls.Add(this.plusDay);
            this.Controls.Add(this.plusMonth);
            this.Controls.Add(this.minusDay);
            this.Controls.Add(this.minusMonth);
            this.Controls.Add(this.tbTimeNow);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btdayCalc);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.nowClock);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "カレンダーアプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btdayCalc;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button minusMonth;
        private System.Windows.Forms.Button plusYear;
        private System.Windows.Forms.Button minusYear;
        private System.Windows.Forms.Button plusMonth;
        private System.Windows.Forms.Button minusDay;
        private System.Windows.Forms.Button plusDay;
        private System.Windows.Forms.Label nowClock;
        private System.Windows.Forms.TextBox tbTimeNow;
        private System.Windows.Forms.Button btAge;
        private System.Windows.Forms.Timer tmTimeDisp;
    }
}


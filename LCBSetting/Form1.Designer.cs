namespace LCBSetting {
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : global::System.Windows.Forms.Form {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing) {
            if (disposing && this.components != null) {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitializeComponent() {
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::LCBSetting.Form1));
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.radioButton3 = new global::System.Windows.Forms.RadioButton();
            this.radioButton2 = new global::System.Windows.Forms.RadioButton();
            this.radioButton1 = new global::System.Windows.Forms.RadioButton();
            this.button1 = new global::System.Windows.Forms.Button();
            this.button2 = new global::System.Windows.Forms.Button();
            this.checkedListBox1 = new global::System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new global::System.Windows.Forms.ComboBox();
            this.label1 = new global::System.Windows.Forms.Label();
            this.comboBox2 = new global::System.Windows.Forms.ComboBox();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label3 = new global::System.Windows.Forms.Label();
            this.comboBox3 = new global::System.Windows.Forms.ComboBox();
            this.label4 = new global::System.Windows.Forms.Label();
            this.comboBox4 = new global::System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new global::System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new global::System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new global::System.Windows.Forms.TrackBar();
            this.label5 = new global::System.Windows.Forms.Label();
            this.label6 = new global::System.Windows.Forms.Label();
            this.label7 = new global::System.Windows.Forms.Label();
            this.trackBar2 = new global::System.Windows.Forms.TrackBar();
            this.trackBar3 = new global::System.Windows.Forms.TrackBar();
            this.button3 = new global::System.Windows.Forms.Button();
            this.label8 = new global::System.Windows.Forms.Label();
            this.textBox1 = new global::System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numericUpDown3).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.trackBar2).BeginInit();
            ((global::System.ComponentModel.ISupportInitialize)this.trackBar3).BeginInit();
            base.SuspendLayout();
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new global::System.Drawing.Point(353, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new global::System.Drawing.Size(98, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "提供元";
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new global::System.Drawing.Point(7, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new global::System.Drawing.Size(72, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "HanGame";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new global::System.Drawing.Point(6, 40);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new global::System.Drawing.Size(63, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "GungHo";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = global::System.Windows.Forms.Cursors.Default;
            this.radioButton1.Location = new global::System.Drawing.Point(6, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new global::System.Drawing.Size(45, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "UJJ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.button1.Enabled = false;
            this.button1.Location = new global::System.Drawing.Point(376, 105);
            this.button1.Name = "button1";
            this.button1.Size = new global::System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "読込";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new global::System.EventHandler(this.Btn_click);
            this.button2.Enabled = false;
            this.button2.Location = new global::System.Drawing.Point(376, 132);
            this.button2.Name = "button2";
            this.button2.Size = new global::System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "保存";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new global::System.EventHandler(this.Btn_click);
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[]
            {
                "パッシブモード",
                "キャラクター音声",
                "MOB音声",
                "エモーション音声",
                "フルスクリーン",
                "合成",
                "天候表示",
                "影表示",
                "露店表示",
                "ドールエフェクト",
                "帽子を表示しない",
                "地震を表示",
                "アイテム取得表示",
                "経験値表示",
                "クラス経験値表示",
                "キャラクター情報表示",
                "キャラクターイメージ表示",
                "キャラクター会話表示",
                "取引拒否",
                "フレ登録拒否",
                "PT勧誘拒否",
                "ギルド勧誘拒否",
                "全ての情報ウィンドウを固定",
                "輪郭線を表示しない",
                "ゲームを行わない(?)",
                "システムテーマ設定",
                "ショートカット設定",
                "CPUディレイ",
                "規約に同意"
            });
            this.checkedListBox1.Location = new global::System.Drawing.Point(12, 9);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new global::System.Drawing.Size(187, 452);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.ItemCheck += new global::System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox1_ItemCheck);
            this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "全て表示",
                "自分のみ表示",
                "非表示"
            });
            this.comboBox1.Location = new global::System.Drawing.Point(205, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new global::System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(205, 11);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(74, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "スキルエフェクト";
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[]
            {
                "日本",
                "台湾",
                "香港"
            });
            this.comboBox2.Location = new global::System.Drawing.Point(205, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new global::System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 6;
            this.label2.AutoSize = true;
            this.label2.Location = new global::System.Drawing.Point(205, 51);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(17, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "国";
            this.label3.AutoSize = true;
            this.label3.Location = new global::System.Drawing.Point(205, 91);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(35, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "サーバ";
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[]
            {
                "アトラス",
                "ディオネ",
                "メティス"
            });
            this.comboBox3.Location = new global::System.Drawing.Point(205, 107);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new global::System.Drawing.Size(121, 20);
            this.comboBox3.TabIndex = 9;
            this.label4.AutoSize = true;
            this.label4.Location = new global::System.Drawing.Point(207, 131);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(41, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "解像度";
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[]
            {
                "800×480",
                "800×600",
                "1024×600",
                "1024×768",
                "1280×768",
                "1280×800",
                "1280×960"
            });
            this.comboBox4.Location = new global::System.Drawing.Point(205, 147);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new global::System.Drawing.Size(121, 20);
            this.comboBox4.TabIndex = 11;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.ImeMode = global::System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new global::System.Drawing.Point(205, 187);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new global::System.Drawing.Size(50, 19);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.Spin_changed);
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new global::System.Drawing.Point(205, 226);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new global::System.Drawing.Size(50, 19);
            this.numericUpDown2.TabIndex = 13;
            this.numericUpDown2.ValueChanged += new global::System.EventHandler(this.Spin_changed);
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new global::System.Drawing.Point(205, 265);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new global::System.Drawing.Size(50, 19);
            this.numericUpDown3.TabIndex = 14;
            this.numericUpDown3.ValueChanged += new global::System.EventHandler(this.Spin_changed);
            this.trackBar1.AutoSize = false;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new global::System.Drawing.Point(261, 187);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new global::System.Drawing.Size(190, 19);
            this.trackBar1.TabIndex = 15;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new global::System.EventHandler(this.Bar_move);
            this.label5.AutoSize = true;
            this.label5.Location = new global::System.Drawing.Point(205, 171);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size(30, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "BGM";
            this.label6.AutoSize = true;
            this.label6.Location = new global::System.Drawing.Point(203, 210);
            this.label6.Name = "label6";
            this.label6.Size = new global::System.Drawing.Size(41, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "効果音";
            this.label7.AutoSize = true;
            this.label7.Location = new global::System.Drawing.Point(207, 249);
            this.label7.Name = "label7";
            this.label7.Size = new global::System.Drawing.Size(29, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "音声";
            this.trackBar2.AutoSize = false;
            this.trackBar2.Enabled = false;
            this.trackBar2.Location = new global::System.Drawing.Point(261, 226);
            this.trackBar2.Maximum = 100;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new global::System.Drawing.Size(190, 19);
            this.trackBar2.TabIndex = 19;
            this.trackBar2.TickFrequency = 10;
            this.trackBar2.Scroll += new global::System.EventHandler(this.Bar_move);
            this.trackBar3.AutoSize = false;
            this.trackBar3.Enabled = false;
            this.trackBar3.Location = new global::System.Drawing.Point(261, 265);
            this.trackBar3.Maximum = 100;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new global::System.Drawing.Size(190, 19);
            this.trackBar3.TabIndex = 20;
            this.trackBar3.TickFrequency = 10;
            this.trackBar3.Scroll += new global::System.EventHandler(this.Bar_move);
            this.button3.Location = new global::System.Drawing.Point(376, 159);
            this.button3.Name = "button3";
            this.button3.Size = new global::System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "終了";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new global::System.EventHandler(this.Btn_click);
            this.label8.AutoSize = true;
            this.label8.Location = new global::System.Drawing.Point(205, 291);
            this.label8.Name = "label8";
            this.label8.Size = new global::System.Drawing.Size(53, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "ログイン名";
            this.textBox1.Enabled = false;
            this.textBox1.Location = new global::System.Drawing.Point(205, 306);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new global::System.Drawing.Size(169, 19);
            this.textBox1.TabIndex = 23;
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
            base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(467, 479);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.trackBar3);
            base.Controls.Add(this.trackBar2);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.trackBar1);
            base.Controls.Add(this.numericUpDown3);
            base.Controls.Add(this.numericUpDown2);
            base.Controls.Add(this.numericUpDown1);
            base.Controls.Add(this.comboBox4);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.comboBox3);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.comboBox2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.checkedListBox1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.groupBox1);
            //base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "Form1";
            this.Text = "ル・シエル・ブルー環境設定";
            base.Load += new global::System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numericUpDown2).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.numericUpDown3).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.trackBar2).EndInit();
            ((global::System.ComponentModel.ISupportInitialize)this.trackBar3).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private global::System.ComponentModel.IContainer components;

        private global::System.Windows.Forms.GroupBox groupBox1;

        private global::System.Windows.Forms.RadioButton radioButton3;

        private global::System.Windows.Forms.RadioButton radioButton2;

        private global::System.Windows.Forms.RadioButton radioButton1;

        private global::System.Windows.Forms.Button button1;

        private global::System.Windows.Forms.Button button2;

        private global::System.Windows.Forms.CheckedListBox checkedListBox1;

        private global::System.Windows.Forms.ComboBox comboBox1;

        private global::System.Windows.Forms.Label label1;

        private global::System.Windows.Forms.ComboBox comboBox2;

        private global::System.Windows.Forms.Label label2;

        private global::System.Windows.Forms.Label label3;

        private global::System.Windows.Forms.ComboBox comboBox3;

        private global::System.Windows.Forms.Label label4;

        private global::System.Windows.Forms.ComboBox comboBox4;

        private global::System.Windows.Forms.NumericUpDown numericUpDown1;

        private global::System.Windows.Forms.NumericUpDown numericUpDown2;

        private global::System.Windows.Forms.NumericUpDown numericUpDown3;

        private global::System.Windows.Forms.TrackBar trackBar1;

        private global::System.Windows.Forms.Label label5;

        private global::System.Windows.Forms.Label label6;

        private global::System.Windows.Forms.Label label7;

        private global::System.Windows.Forms.TrackBar trackBar2;

        private global::System.Windows.Forms.TrackBar trackBar3;

        private global::System.Windows.Forms.Button button3;

        private global::System.Windows.Forms.Label label8;

        private global::System.Windows.Forms.TextBox textBox1;
    }
}

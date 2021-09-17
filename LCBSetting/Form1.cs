namespace LCBSetting {
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    using Microsoft.Win32;

    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form {
        /// <summary>
        /// 
        /// </summary>
        public Form1() {
            InitializeComponent();
            strPath = new string[3];
            strCurPath = string.Empty;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            var array = new string[]
            {
                "SOFTWARE\\fy\\ago",
                "SOFTWARE\\fy\\agogungho",
                "SOFTWARE\\fy\\agohangame"
            };
            var name = "GameDir";
            var array2 = new bool[3];
            var array3 = array2;
            for (var i = 0; i < 3; i++) {
                try {
                    var registryKey = Registry.LocalMachine.OpenSubKey(array[i]);
                    strPath[i] = (string)registryKey.GetValue(name);
                    registryKey.Close();
                    array3[i] = true;
                } catch (NullReferenceException) {
                }
            }
            if (!array3[2]) {
                radioButton3.Enabled = false;
            } else {
                radioButton3.Checked = true;
                button1.Enabled = true;
            }
            if (!array3[1]) {
                radioButton2.Enabled = false;
            } else {
                radioButton2.Checked = true;
                button1.Enabled = true;
            }
            if (!array3[0]) {
                radioButton1.Enabled = false;
                return;
            }
            radioButton1.Checked = true;
            button1.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_click(object sender, EventArgs e) {
            checkedListBox1.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;
            numericUpDown3.Enabled = true;
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            trackBar3.Enabled = true;
            button2.Enabled = true;
            textBox1.Enabled = true;
            if (sender == button1) {
                ChkProvider();
                iniReg = new IniFile(strCurPath + "reg.ini");
                iniMidage = new IniFile(strCurPath + "midage.ini");
                Text = string.Format("ル・シエル・ブルー環境設定(Version {0}) : {1}", iniReg["PROFILE", "Version"], iniMidage["LOGIN", "Name"]);
                GetDialogValue();
                bDQ1 = true;
                return;
            }
            if (sender == button2) {
                SetDialogValue();
                return;
            }
            base.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetDialogValue() {
            var num = 0;
            iniReg["PROFILE", "PassiveMode"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "CharSound"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "MonsSound"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "EmotSound"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "GameWndFullScreen"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowWndMix"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowWeather"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowShadow"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowShop"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "DollEffect"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowNoHeadEQ"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowEarthquake"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowObjMsg"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowCharExpMsg"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowSkillExpMsg"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowCharInfo"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowCharImage"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "ShowCharWords"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "NoTrade"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "NoFriend"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "NoGroup"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "NoGuild"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "LockAllWnd"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "HideRim"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "NoGame"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "SetSysTheme"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "SetShortcutType"] = GetChkMode(num++).ToString();
            iniMidage["SYSTEM", "CPUDelay"] = GetChkMode(num++).ToString();
            iniMidage["LOGIN", "Agreement"] = GetChkMode(num++).ToString();
            iniMidage["OPTION", "SkillEffect"] = comboBox1.SelectedIndex.ToString();
            iniMidage["LOGIN", "AREA"] = comboBox2.SelectedIndex.ToString();
            iniMidage["LOGIN", "SET"] = comboBox3.SelectedIndex.ToString();
            SetResolution();
            iniMidage["OPTION", "MusicVolume"] = numericUpDown1.Value.ToString();
            iniMidage["OPTION", "SoundVolume"] = numericUpDown2.Value.ToString();
            iniMidage["OPTION", "VoiceVolume"] = numericUpDown3.Value.ToString();
            iniMidage["LOGIN", "Name"] = textBox1.Text;
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetResolution() {
            switch (comboBox4.SelectedIndex) {
            case 0:
                iniMidage["OPTION", "GameWndSizeWidth"] = "800";
                iniMidage["OPTION", "GameWndSizeHeight"] = "480";
                return;
            case 1:
                iniMidage["OPTION", "GameWndSizeWidth"] = "800";
                iniMidage["OPTION", "GameWndSizeHeight"] = "600";
                return;
            case 2:
                iniMidage["OPTION", "GameWndSizeWidth"] = "1024";
                iniMidage["OPTION", "GameWndSizeHeight"] = "600";
                return;
            case 3:
                iniMidage["OPTION", "GameWndSizeWidth"] = "1024";
                iniMidage["OPTION", "GameWndSizeHeight"] = "768";
                return;
            case 4:
                iniMidage["OPTION", "GameWndSizeWidth"] = "1280";
                iniMidage["OPTION", "GameWndSizeHeight"] = "768";
                return;
            case 5:
                iniMidage["OPTION", "GameWndSizeWidth"] = "1280";
                iniMidage["OPTION", "GameWndSizeHeight"] = "800";
                return;
            case 6:
                iniMidage["OPTION", "GameWndSizeWidth"] = "1280";
                iniMidage["OPTION", "GameWndSizeHeight"] = "960";
                return;
            default:
                return;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetDialogValue() {
            var num = 0;
            SetChkMode(iniReg["PROFILE", "PassiveMode"], num++);
            SetChkMode(iniMidage["OPTION", "CharSound"], num++);
            SetChkMode(iniMidage["OPTION", "MonsSound"], num++);
            SetChkMode(iniMidage["OPTION", "EmotSound"], num++);
            SetChkMode(iniMidage["OPTION", "GameWndFullScreen"], num++);
            SetChkMode(iniMidage["OPTION", "ShowWndMix"], num++);
            SetChkMode(iniMidage["OPTION", "ShowWeather"], num++);
            SetChkMode(iniMidage["OPTION", "ShowShadow"], num++);
            SetChkMode(iniMidage["OPTION", "ShowShop"], num++);
            SetChkMode(iniMidage["OPTION", "DollEffect"], num++);
            SetChkMode(iniMidage["OPTION", "ShowNoHeadEQ"], num++);
            SetChkMode(iniMidage["OPTION", "ShowEarthquake"], num++);
            SetChkMode(iniMidage["OPTION", "ShowObjMsg"], num++);
            SetChkMode(iniMidage["OPTION", "ShowCharExpMsg"], num++);
            SetChkMode(iniMidage["OPTION", "ShowSkillExpMsg"], num++);
            SetChkMode(iniMidage["OPTION", "ShowCharInfo"], num++);
            SetChkMode(iniMidage["OPTION", "ShowCharImage"], num++);
            SetChkMode(iniMidage["OPTION", "ShowCharWords"], num++);
            SetChkMode(iniMidage["OPTION", "NoTrade"], num++);
            SetChkMode(iniMidage["OPTION", "NoFriend"], num++);
            SetChkMode(iniMidage["OPTION", "NoGroup"], num++);
            SetChkMode(iniMidage["OPTION", "NoGuild"], num++);
            SetChkMode(iniMidage["OPTION", "LockAllWnd"], num++);
            SetChkMode(iniMidage["OPTION", "HideRim"], num++);
            SetChkMode(iniMidage["OPTION", "NoGame"], num++);
            SetChkMode(iniMidage["OPTION", "SetSysTheme"], num++);
            SetChkMode(iniMidage["OPTION", "SetShortcutType"], num++);
            SetChkMode(iniMidage["SYSTEM", "CPUDelay"], num++);
            SetChkMode(iniMidage["LOGIN", "Agreement"], num++);
            int.TryParse(iniMidage["OPTION", "SkillEffect"], out var num2);
            comboBox1.SelectedIndex = num2;
            int.TryParse(iniMidage["LOGIN", "AREA"], out num2);
            comboBox2.SelectedIndex = num2;
            int.TryParse(iniMidage["LOGIN", "SET"], out num2);
            comboBox3.SelectedIndex = num2;
            ChkResolution();
            int.TryParse(iniMidage["OPTION", "MusicVolume"], out num2);
            numericUpDown1.Value = (trackBar1.Value = num2);
            int.TryParse(iniMidage["OPTION", "SoundVolume"], out num2);
            numericUpDown2.Value = (trackBar2.Value = num2);
            int.TryParse(iniMidage["OPTION", "VoiceVolume"], out num2);
            numericUpDown3.Value = (trackBar3.Value = num2);
            textBox1.Text = iniMidage["LOGIN", "Name"];
        }

        /// <summary>
        /// 
        /// </summary>
        private void ChkResolution() {
            int.TryParse(iniMidage["OPTION", "GameWndSizeWidth"], out var num);
            int.TryParse(iniMidage["OPTION", "GameWndSizeHeight"], out var num2);
            var num3 = num * num2;
            if (num3 <= 614400) {
                if (num3 == 384000) {
                    comboBox4.SelectedIndex = 0;
                    return;
                }
                if (num3 == 480000) {
                    comboBox4.SelectedIndex = 1;
                    return;
                }
                if (num3 == 614400) {
                    comboBox4.SelectedIndex = 2;
                    return;
                }
            } else if (num3 <= 983040) {
                if (num3 == 786432) {
                    comboBox4.SelectedIndex = 3;
                    return;
                }
                if (num3 == 983040) {
                    comboBox4.SelectedIndex = 4;
                    return;
                }
            } else {
                if (num3 == 1024000) {
                    comboBox4.SelectedIndex = 5;
                    return;
                }
                if (num3 == 1228800) {
                    comboBox4.SelectedIndex = 6;
                    return;
                }
            }
            MessageBox.Show("設定できない解像度です");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private int GetChkMode(int index) {
            if (checkedListBox1.GetItemChecked(index)) {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        private void SetChkMode(string str, int index) {
            int.TryParse(str, out var num);
            if (num != 0) {
                checkedListBox1.SetItemChecked(index, true);
                return;
            }
            checkedListBox1.SetItemChecked(index, false);
        }

        /// <summary>
        /// 
        /// </summary>
        private void ChkProvider() {
            if (radioButton1.Checked) {
                strCurPath = strPath[0];
                return;
            }
            if (radioButton2.Checked) {
                strCurPath = strPath[1];
                return;
            }
            strCurPath = strPath[2];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bar_move(object sender, EventArgs e) {
            if (sender == trackBar1) {
                numericUpDown1.Value = trackBar1.Value;
                return;
            }
            if (sender == trackBar2) {
                numericUpDown2.Value = trackBar2.Value;
                return;
            }
            numericUpDown3.Value = trackBar3.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spin_changed(object sender, EventArgs e) {
            if (sender == numericUpDown1) {
                trackBar1.Value = (int)numericUpDown1.Value;
                return;
            }
            if (sender == numericUpDown2) {
                trackBar2.Value = (int)numericUpDown2.Value;
                return;
            }
            trackBar3.Value = (int)numericUpDown3.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e) {
            var a = (string)checkedListBox1.Items[e.Index];
            if (a == "ドールエフェクト" && bDQ1 && e.NewValue == CheckState.Checked) {
                for (var i = 0; i < 10; i++) {
                    MessageBox.Show("それをちぇっくするなんてとんでもない");
                }
                MessageBox.Show("やれやれ……");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Conditional("DEBUG")]
        [SuppressMessage("CodeQuality", "IDE0051:使用されていないプライベート メンバーを削除する", Justification = "<保留中>")]
        private void CheckStateLCB() {
            var name = new StackTrace().GetFrame(1).GetMethod().Name;
            Trace.WriteLine("LCBSettingのCheckState開始：");
            Trace.WriteLine("\t呼び出し元：" + name);
            Trace.WriteLine("LCBSettingのCheckState終了");
        }

        private readonly string[] strPath;

        private string strCurPath;

        private IniFile iniMidage;

        private IniFile iniReg;

        private bool bDQ1;
    }
}

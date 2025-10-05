using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__program
{
    public partial class Form3 : Form
    {
        private string[] weekDays = { "なし", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
// ラジオボタン配列
            radioButton1.Text = weekDays[1]; // Mon
            radioButton2.Text = weekDays[2];
            radioButton3.Text = weekDays[3];
            radioButton4.Text = weekDays[4];
            radioButton5.Text = weekDays[5];
            radioButton6.Text = weekDays[6];
            radioButton7.Text = weekDays[7];

            foreach (var rb in new[] { radioButton1, radioButton2, radioButton3, radioButton4,
                                   radioButton5, radioButton6, radioButton7 })
            {
                rb.Checked = false;
            }
 // label2に出力
            RadioButton[] buttons =
                {
        radioButton1, radioButton2, radioButton3,
        radioButton4, radioButton5, radioButton6, radioButton7
    };
            foreach (RadioButton rb in buttons)
            {
                rb.CheckedChanged += RadioButton_CheckedChanged;
            }
// \\\\\
            radioButton8.CheckedChanged += RadioButton8or9_CheckedChanged;
            radioButton9.CheckedChanged += RadioButton8or9_CheckedChanged;


         

            // ボタン1設定
            button1.Cursor = Cursors.Hand;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;

            checkBox1.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox2.CheckedChanged += CheckBoxes_CheckedChanged;
            checkBox3.CheckedChanged += CheckBoxes_CheckedChanged;

            button1.Enabled = false; // デフォルトクリック不可

    // 画像ラジオボタン
            radioButton10.CheckedChanged += LayoutRadioButton_CheckedChanged;
            radioButton11.CheckedChanged += LayoutRadioButton_CheckedChanged;
            radioButton12.CheckedChanged += LayoutRadioButton_CheckedChanged;
        }

   // label2
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                label2.Text = rb.Text;
            }
        }




        private void RadioButton8or9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                label1.Text = rb.Text;
            }

            if (radioButton8.Checked)
            {
                string[] weekdays = { "なし", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(weekdays);

                comboBox1.SelectedIndex = 0;

            }

            if (radioButton9.Checked)
            {
                string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Sep", "Oct", "Aug", "Nov", "Dec" };
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(months);

                comboBox1.SelectedIndex = 0;
            }


        }





 // コンボボックス
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
        }
  // Button1 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;  // 背景色を変更
            button1.ForeColor = Color.Yellow;    // テキスト色変更

        }

        private void CheckBoxes_CheckedChanged(object sender, EventArgs e)
        {
            // 3つすべてチェックされているか確認
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                button1.Enabled = true; // 押せるようにする
            }
            else
            {
                button1.Enabled = false; // 押せなくする
            }
        }


        // マウスがボタンから離れたとき
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control; 
            button1.ForeColor = SystemColors.ControlText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("チェック完了!", "確認", MessageBoxButtons.OK);
        }
 // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


// 画像レイアウト変更
        private void LayoutRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb != null && rb.Checked)
            {
                if (rb == radioButton10)
                {
                    panel5.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else if (rb == radioButton11)
                {
                    panel5.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else if (rb == radioButton12)
                {
                    panel5.BackgroundImageLayout = ImageLayout.Center;
                }
            }
        }

      
    }
}

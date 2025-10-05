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


            // ボタン1設定
            button1.Cursor = Cursors.Hand;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;


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






        // Button1 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Black;  // 背景色を変更
            button1.ForeColor = Color.Yellow;    // テキスト色変更

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
    
    
    }
}

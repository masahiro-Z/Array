using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__program
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.label4.Paint += label4_Paint;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // ファイル取得\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = @"C:\";
                ofd.Filter = "テキストファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            try
            {
                if (!System.IO.File.Exists(path))

                    throw new FileNotFoundException();

                string content = System.IO.File.ReadAllText(path);
                label6.Text = content;
            }
            catch (Exception)
            {
                label6.Text = "ファイルまたはフォルダが存在しません";
            }
        }
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        // 時刻表示\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label4.Text = now.ToString("HH:mm:ss");
        }
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        // グラデーション\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void label4_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;

            // グラデーション背景を描画
            using (LinearGradientBrush brush = new LinearGradientBrush(
                lbl.ClientRectangle,
                Color.White,   // 上の色
                Color.Blue,    // 下の色
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, lbl.ClientRectangle);
            }

            // テキストを描画
            TextRenderer.DrawText(
                e.Graphics,
                lbl.Text,
                lbl.Font,
                lbl.ClientRectangle,
                lbl.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\










        // 色返す\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button4_Click(object sender, EventArgs e)
        {
            label5.BackColor = System.Drawing.Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.BackColor = System.Drawing.Color.Green;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label5.BackColor = System.Drawing.Color.Blue;
        }
        // from2　\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "画面遷移してもよろしいですか？",     // メッセージ本文
        "確認",                      // タイトル
        MessageBoxButtons.OKCancel, // OK と キャンセルのボタンを出す
        MessageBoxIcon.Question     // アイコン
    );

            if (result == DialogResult.OK)
            {
                using (Form2 f2 = new Form2())
                {
                    f2.MessageText = label6.Text;

                    if (f2.ShowDialog(this) == DialogResult.OK)
                    {
                        label5.Text = f2.ResultText;
                    }
                }
            }
        }
        // form3 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("画面遷移してもよろしいですか？", "確認",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                using (Form3 f3 = new Form3())
                {
                    f3.ShowDialog();
                }
            }
        }
        // ファイル上書き\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button6_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;
            string content = label5.Text;

            try
            {
                File.WriteAllText(filePath, content);
                MessageBox.Show("ファイル上書き");
            }
            catch (Exception ex){ MessageBox.Show("エラー"); }
        }
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
    }
}

      
        



    


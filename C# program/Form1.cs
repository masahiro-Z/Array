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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

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
                label6.Text = "ファイルエラー";
            }
        }
        


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

      
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\











    }
}

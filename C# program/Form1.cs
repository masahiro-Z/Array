using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
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

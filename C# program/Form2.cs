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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        public string MessageText { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            // フォームが開かれたときに自動的に label4 に設定
            label4.Text = MessageText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] parts = label4.Text.Split(',');

            if (parts.Length > 0) textBox2.Text = parts[0];
            if (parts.Length > 1) textBox3.Text = parts[1];
            if (parts.Length > 2) textBox4.Text = parts[2];
            if (parts.Length > 3) textBox5.Text = parts[3];

        }
    }
}

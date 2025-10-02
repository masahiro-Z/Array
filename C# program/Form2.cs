using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        // 分割 \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button3_Click(object sender, EventArgs e)
        {
            string[] parts = label4.Text.Split(',');

            if (parts.Length > 0) textBox2.Text = parts[0];
            if (parts.Length > 1) textBox3.Text = parts[1];
            if (parts.Length > 2) textBox4.Text = parts[2];
            if (parts.Length > 3) textBox5.Text = parts[3];
        }
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\


        // 空白削除A 空白削除B \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = RemoveSpaces(textBox2.Text);
            textBox3.Text = RemoveSpaces(textBox3.Text);
            textBox4.Text = RemoveSpaces(textBox4.Text);
            textBox5.Text = RemoveSpaces(textBox5.Text);
        }

        private void TrimTextBoxes(params TextBox[] boxes)
        {
            foreach (var tb in boxes)
            {
                tb.Text = tb.Text.Trim();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            TrimTextBoxes(textBox2, textBox3, textBox4, textBox5);
        }
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        // 形成\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        private void button6_Click(object sender, EventArgs e)
        {
            string[] values = { textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };
            textBox1.Text = string.Join(",", values);
        }
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

        // Close \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        public string ResultText { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultText = textBox1.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        // \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\






















    }
}

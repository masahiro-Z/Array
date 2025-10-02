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

        }
    }
}

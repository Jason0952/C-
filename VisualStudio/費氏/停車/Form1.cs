using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 停車
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int starttime);
            int.TryParse(textBox2.Text, out int startmin);
            int.TryParse(textBox3.Text, out int endtime);
            int.TryParse(textBox4.Text, out int endmin);

            int start = starttime * 60 + startmin;
            int end = endtime * 60 + endmin;
            int needtopay = end - start;
            int total = 0;

            if (needtopay / 30 > 4)
            {
                total = 4 * 30 + (needtopay / 30 - 4) * 40;
                if (needtopay / 30 > 8)
                {
                    total = 4 * 40 + 4 * 30 + (needtopay / 30 - 8) * 60;
                }
            }
            else
            {
                total = needtopay / 30;
                total = total * 30;
            }
            label8.Text = total.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 累進稅率
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double.TryParse(textBox1.Text, out double getdollar);
            double needtopay = 0;

            if (getdollar <= 540000)
            {
                needtopay = getdollar * 0.05;
            }

            if (getdollar > 540000 && getdollar <= 1210000)
            {
                needtopay = 540000 * 0.05 + (getdollar - 540000) * 0.12;
            }

            if (getdollar > 1210000 && getdollar <= 2420000)
            {
                needtopay = 540000 * 0.05 + 670000 * 0.12 + (getdollar - 1210000) * 0.2;
            }

            if (getdollar > 2420000 && getdollar <= 4530000)
            {
                needtopay = 540000 * 0.05 + 670000 * 0.12 + 1210000 * 0.2 + (getdollar - 2420000) * 0.3;
            }

            if (getdollar > 4530000 && getdollar < 10310000)
            {
                needtopay = 540000 * 0.05 + 670000 * 0.12 + 1210000 * 0.2 + 2110000 * 0.3 + (getdollar - 4530000) * 0.4;
            }

            if (getdollar > 10310000)
            {
                needtopay = 540000 * 0.05 + 670000 * 0.12 + 1210000 * 0.2 + 2110000 * 0.3 + 5780000 * 0.4 + (getdollar - 10310000) * 0.5;
            }
            label2.Text = "應繳交金額:" + needtopay.ToString();
        }
    }
}

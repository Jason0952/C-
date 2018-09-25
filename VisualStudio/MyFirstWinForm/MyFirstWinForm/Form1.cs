using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getnum(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getnum(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getnum(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getnum(4);
        }

        public void getnum(int i)
        {
            int x;
            int y;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            switch (i)
            {
                case 1:
                    label1.Text = (x + y).ToString();
                    break;
                case 2:
                    label1.Text = (x - y).ToString();
                    break;
                case 3:
                    label1.Text = (x * y).ToString();
                    break;
                case 4:
                    label1.Text = (x / y).ToString();
                    label3.Text = (x % y).ToString();
                    break;
            }
        }
    }
}

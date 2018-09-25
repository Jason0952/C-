using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 滷味
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int Veg);
            double.TryParse(textBox2.Text, out double bean);
            double.TryParse(textBox3.Text, out double sea);
            int.TryParse(textBox4.Text, out int meat);
            double sum = 0;

            sum = Veg * 30 + bean * 7.5 + sea * 7.5 + meat * 40;
            int intNum = Convert.ToInt32(Math.Ceiling(sum));
            int thousand = intNum / 1000;
            int Fivehundrad = (intNum % 1000) / 500;
            int hundrad = ((intNum % 1000) % 500) / 100;
            int fifty = (intNum % 100) / 50;
            int ten = ((intNum % 100) % 50) / 10;
            int five = (intNum % 10) / 5;
            int one = intNum % 5;

            textBox5.Text = thousand.ToString();
            textBox6.Text = Fivehundrad.ToString();
            textBox7.Text = hundrad.ToString();
            textBox8.Text = fifty.ToString();
            textBox9.Text = ten.ToString();
            textBox10.Text = five.ToString();
            textBox11.Text = one.ToString();

            label11.Text = intNum.ToString();
        }
    }
}

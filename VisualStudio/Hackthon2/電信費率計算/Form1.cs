using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電信費率計算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int hour);
            int.TryParse(textBox2.Text, out int mins);
            int totalmins = hour * 60 + mins;
            label4.Text = $"總時間為{totalmins},";
            int Chunghwapay = 350 + 4 * totalmins;
            int fareastpay = 400 + 3 * totalmins;
            int taiwanpay = 500 + 2 * totalmins;

            if (Chunghwapay < fareastpay)
            {
                if (Chunghwapay < taiwanpay)
                {
                    label4.Text += $"中華電信最便宜,只要{Chunghwapay}元";
                }
                else
                {
                    label4.Text += $"台灣大哥大最便宜,只要{taiwanpay}元";
                }
            }
            else
            {
                if (fareastpay < taiwanpay)
                {
                    label4.Text += $"遠傳最便宜,只要{fareastpay}元";
                }
                else
                {
                    label4.Text += $"台灣大哥大最便宜,只要{taiwanpay}元";
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 猜數字
{
    public partial class Form1 : Form
    {
        private List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random Rd = new Random();
            while (list.Count < 4)
            {
                int i = Rd.Next(0, 10);
                if (list.Any((x) => x == i.ToString()))
                {
                    continue;
                }
                else
                {
                    list.Add(i.ToString());
                }
            }
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int A = 0;
            int B = 0;
            List<string> Num = new List<string>();
            string type = textBox1.Text;
            int a = int.Parse(type);

            int first = a / 1000;
            string F = first.ToString();
            Num.Add(F);
            if (Num.Any((x) => x == list[0])) //list的第0位在Num陣列裡任一位置的數字有交集(找相同數字)
            {
                if (list.IndexOf(F) == 0) //判斷是否在相同位置
                {
                    A++;
                }
                else
                {
                    B++;
                }
            }

            int sec = (a % 1000) / 100;
            string S = sec.ToString();
            Num.Add(S);
            if (Num.Any((x) => x == list[1]))
            {
                if (list.IndexOf(S) == 1)
                {
                    A++;
                }
                else
                {
                    B++;
                }
            }

            int third = (a % 1000) % 100 / 10;
            string T = third.ToString();
            Num.Add(T);
            if (Num.Any((x) => x == list[2]))
            {
                if (list.IndexOf(T) == 2)
                {
                    A++;
                }
                else
                {
                    B++;
                }
            }

            int forth = a % 10;
            string F2 = forth.ToString();
            Num.Add(F2);
            if (Num.Any((x) => x == list[3]))
            {
                if (list.IndexOf(F2) == 3)
                {
                    A++;                    
                }
                else
                {
                    B++;
                }
            }
            display(type, A, B);
        }

        private void display(string Type, int a,int b)
        {
            listBox1.Items.Add(Type + ";" + a + "A" + b + "B");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = list[0] + list[1] + list[2] + list[3];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}

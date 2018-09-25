using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxSample
{
    public partial class Form1 : Form
    {
        private List<string> leftlistbox;
        private List<string> rightlistbox;
        public Form1()
        {
            InitializeComponent();
            createlist();
            changedata();
            button2.Enabled = false;
            label1.Text = "農夫";
            label2.Text = " ";
        }

        private void createlist()
        {
            leftlistbox = new List<string> { "狼", "羊", "菜" };
            rightlistbox = new List<string>();
        }

        private void setlistboxdatasource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }

        private void changedata()
        {
            listBox1.DataSource = null; //按一次，就強迫畫面重繪listbox
            listBox2.DataSource = null; //按一次，就強迫畫面重繪listbox
            listBox1.DataSource = leftlistbox;
            listBox2.DataSource = rightlistbox;
            listBox1.SelectedIndex = -1;
            listBox2.SelectedIndex = -1;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string item = (string)listBox1.SelectedItem;
                leftlistbox.Remove(item);
                rightlistbox.Add(item);
                changedata();

                string a = leftlistbox.Find((x) => x == "狼");
                string b = leftlistbox.Find((x) => x == "羊");
                string c = leftlistbox.Find((x) => x == "菜");
                string a1 = rightlistbox.Find((x) => x == "狼");
                string b1 = rightlistbox.Find((x) => x == "羊");
                string c1 = rightlistbox.Find((x) => x == "菜");
                if (a != null && b != null)
                {
                    MessageBox.Show("羊被狼吃掉，遊戲失敗");
                }
                else if (b != null && c != null)
                {
                    MessageBox.Show("菜被羊吃掉，遊戲失敗");
                }
                else if (a1 != null && b1 != null && c1 != null)
                {
                    label2.Text = "農夫";
                    label1.Text = " ";
                    button2.Enabled = true;
                    button1.Enabled = false;
                    MessageBox.Show("恭喜過關");
                }
                label2.Text = "農夫";
                label1.Text = " ";
                button2.Enabled = true;
                button1.Enabled = false;
            }
            else
            {
                string a = leftlistbox.Find((x) => x == "狼");
                string b = leftlistbox.Find((x) => x == "羊");
                string c = leftlistbox.Find((x) => x == "菜");
                string a1 = rightlistbox.Find((x) => x == "狼");
                string b1 = rightlistbox.Find((x) => x == "羊");
                string c1 = rightlistbox.Find((x) => x == "菜");

                button1.Enabled = false;
                button2.Enabled = true;
                label1.Text = " ";
                label2.Text = "農夫";
                if (a != null && b != null && c != null)
                {
                    MessageBox.Show("菜被羊吃掉，羊被郎吃掉!! 遊戲失敗!!");
                }
                else if (a != null && b != null)
                {
                    MessageBox.Show("羊被狼吃掉，遊戲失敗");
                }
                else if (b != null && c != null)
                {
                    MessageBox.Show("菜被羊吃掉，遊戲失敗");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string item = (string)listBox2.SelectedItem;
                leftlistbox.Add(item);
                rightlistbox.Remove(item);
                changedata();

                string a = leftlistbox.Find((x) => x == "狼");
                string b = leftlistbox.Find((x) => x == "羊");
                string c = leftlistbox.Find((x) => x == "菜");
                string a1 = rightlistbox.Find((x) => x == "狼");
                string b1 = rightlistbox.Find((x) => x == "羊");
                string c1 = rightlistbox.Find((x) => x == "菜");

                if (a1 != null && b1 != null)
                {
                    MessageBox.Show("羊被狼吃掉，遊戲失敗");
                }
                if (b1 != null && c1 != null )
                {
                    MessageBox.Show("菜被羊吃掉，遊戲失敗");
                }

                label1.Text = "農夫";
                label2.Text = " ";
                button1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                string a = leftlistbox.Find((x) => x == "狼");
                string b = leftlistbox.Find((x) => x == "羊");
                string c = leftlistbox.Find((x) => x == "菜");
                string a1 = rightlistbox.Find((x) => x == "狼");
                string b1 = rightlistbox.Find((x) => x == "羊");
                string c1 = rightlistbox.Find((x) => x == "菜");

                if (a1 != null && b1 != null)
                {
                    MessageBox.Show("羊被狼吃掉，遊戲失敗");
                }
                if (b1 != null && c1 != null)
                {
                    MessageBox.Show("菜被羊吃掉，遊戲失敗");
                }
                label1.Text = "農夫";
                label2.Text = " ";
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }
    }
}

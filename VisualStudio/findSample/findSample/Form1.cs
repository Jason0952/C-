using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findSample
{
    public partial class Form1 : Form
    {
        private List<string> _list;
        public Form1()
        {
            InitializeComponent();
            createlist();
        }

        public void createlist()
        {
            _list = new List<string>();
            _list.Add("dog");
            _list.Add("horse");
            _list.Add("cat");
            _list.Add("monkey");
            _list.Add("kangaroo");
            _list.Add("elephant");
            _list.Add("dog2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string list = _list.Find((x) => x == textBox1.Text);
            MessageBox.Show("找到" + list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int list = _list.FindIndex((x) => x == textBox1.Text);
            MessageBox.Show("找到索引" + list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> list = _list.FindAll((x) => x.Contains(textBox1.Text));
            string str = string.Empty;
            foreach (string item in list)
            {
                str = str + item + ',';
            }
            MessageBox.Show("找到" + str);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string list = _list.FindLast((x) => x.Contains(textBox1.Text));
            MessageBox.Show("找到" + list);
        }
    }
}

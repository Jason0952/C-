using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadAllLineSample
{
    public partial class Form1 : Form
    {
        private string fileName;
        public Form1()
        {
            InitializeComponent();
            fileName = "test1.text";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                string[] array = File.ReadAllLines(fileName); //讀第二次放入第一個字後(不會換行)!!
                foreach (var text in array)
                {
                    textBox1.Text += text;
                }
            }
            else
            {
                MessageBox.Show("檔案不存在");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(fileName, textBox1.Text);
            textBox1.Clear();
            MessageBox.Show("存檔完成");

        }
    }
}

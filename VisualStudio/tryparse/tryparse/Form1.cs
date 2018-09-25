using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryparse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int result;
            bool isparse;
            string message;

            if (isparse = int.TryParse(text, out result))
            {
                message = $"可以正確解析文字{text}為整數{result}";
            }
            else
            {
                message = $"不能解析該文字{text}";
            }

            MessageBox.Show(message);
        }
    }
}

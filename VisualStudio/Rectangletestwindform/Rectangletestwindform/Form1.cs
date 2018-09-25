using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLabrary;

namespace Rectangletestwindform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 0;
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int w = (int)numericUpDown1.Value;
            int h = (int)numericUpDown2.Value;
            ClassLabrary.Rectangle width = new ClassLabrary.Rectangle() { width = w,height = h};
            RectangleOperation total = new RectangleOperation();
            total.Target = width;
            int Area = total.ComputerArea();
            label4.Text = Area.ToString();
        }
    }
}

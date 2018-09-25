using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 事件與事件委派函式
{
    public partial class Form1 : Form
    {
        public MyClass obj;
        public Form1()
        {
            InitializeComponent();
            obj = new MyClass();
            obj.Xchange += Obj_Xchange;
        }

        private void Obj_Xchange(object sender, EventArgs e)
        {
            MessageBox.Show("X的值改變了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.X += 1;
        }
    }
}

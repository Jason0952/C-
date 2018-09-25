using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 銷售員業績.Model;

namespace 銷售員業績
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
        }

        private List<items> list = new List<items>()
        {
            new items(){ name = "pen",Num = 153,sumprice = 1836},
            new items(){ name = "pencil",Num = 120,sumprice = 1920},
            new items(){ name = "eraser",Num = 167,sumprice = 1670},
            new items(){ name = "ruler",Num = 157,sumprice = 2198},
            new items(){ name = "reply",Num = 121,sumprice = 1815}
        };
    }
}

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
    public partial class Salesman : Form
    {
        public Salesman()
        {
            InitializeComponent();
            dataGridView1.DataSource = list;
        }

        private List<salesman> list = new List<salesman>
        {
            new salesman(){ salesname = "Bill",pen = 33,pencil = 32,eraser = 56,ruler = 45,reply = 45},
            new salesman(){ salesname = "John",pen = 77,pencil = 33,eraser = 68,ruler = 45,reply = 23},
            new salesman(){ salesname = "David",pen = 43,pencil = 55,eraser = 43,ruler = 67,reply = 65}
        };
    }
}

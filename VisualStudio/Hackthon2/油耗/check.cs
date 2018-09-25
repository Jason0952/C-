using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 油耗.Model;

namespace 油耗
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
            data();
        }

        private void data()
        {
            var text = new Createdata();
            var data = text.OilTable.ToList();
            dataGridView1.DataSource = data;
        }
    }
}

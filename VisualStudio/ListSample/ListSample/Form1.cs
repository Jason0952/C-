using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample
{
    public partial class Form1 : Form
    {
        private List<Rec> _list;

        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetcomboBox();
        }

        private void CreateList()
        {
            _list = new List<ListSample.Rec>();
            _list.Add(new Rec { name = "D1", Width = 5, Height = 5 });
            _list.Add(new Rec { name = "D2", Width = 10, Height = 10 });
            _list.Add(new Rec { name = "D3", Width = 20, Height = 20 });
            _list.Add(new Rec { name = "D4", Width = 100, Height = 100 });
        }

        private void SetcomboBox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "GetRec";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thecomboBox = (ComboBox)sender; //sender = comboBox1
            int all = (int)comboBox1.SelectedValue;
            MessageBox.Show("面積為:" + all);
        }
    }
}

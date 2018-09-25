using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listsample
{
    public partial class Form1 : Form
    {
        private List<list> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            ez();
        }

        public void CreateList()
        {
            _list = new List<listsample.list>();
            _list.Add(new list { Name = "爽啦", Width = 5, Height = 5 });
            _list.Add(new list { Name = "愉悅啦", Width = 10, Height = 10 });
            _list.Add(new list { Name = "輕鬆啦", Width = 20, Height = 20 });
            _list.Add(new list { Name = "開心啦", Width = 100, Height = 100 });
        }

        public void ez()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list item = (list)comboBox1.SelectedItem;
            list a = (list)comboBox1.SelectedValue;
            MessageBox.Show(item.Name + "邊為:" + a.GetWidth().ToString() + ",面積為:" + item.GetNum().ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample1
{
    public partial class Form1 : Form
    {
        private List<Rec> _list;
        public Form1()
        {
            InitializeComponent();
            CreateList();
            Display();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged; //做的次數
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox thecombobox = (ComboBox)sender; //sender = comboBox1(型態為object)
            int index = thecombobox.SelectedIndex;
            Rec item = _list[index];
            MessageBox.Show("取得索引:" + index.ToString() + "面積為:" + item.GetArea.ToString());
        }

        private void CreateList()
        {
            _list = new List<ListSample1.Rec>();
            _list.Add(new Rec { name = "D1", Width = 5, Height = 5 });
            _list.Add(new Rec { name = "D2", Width = 10, Height = 10 });
            _list.Add(new Rec { name = "D3", Width = 20, Height = 20 });
            _list.Add(new Rec { name = "D4", Width = 100, Height = 100 });
        }

        public void Display()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "GetArea";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

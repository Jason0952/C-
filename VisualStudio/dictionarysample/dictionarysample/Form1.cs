using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dictionarysample
{
    public partial class Form1 : Form
    {
        private Dictionary<string, dic> _dictionary;
        public Form1()
        {
            InitializeComponent();
            CreateDictionary();
        }

        private void CreateDictionary()
        {
            _dictionary = new Dictionary<string, dic>();
            _dictionary.Add("D1", new dic { width = 5, height = 5 });
            _dictionary.Add("D2", new dic { width = 10, height = 10 });
            _dictionary.Add("D3", new dic { width = 20, height = 20 });
            _dictionary.Add("D4", new dic { width = 100, height = 100 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            if (_dictionary.ContainsKey(key))
            {
                int area = _dictionary[key].GetArea();
                MessageBox.Show(key + "的面積為:" + area.ToString());
            }
            else
            {
                MessageBox.Show("查無資料!");

            }
        }
    }
}

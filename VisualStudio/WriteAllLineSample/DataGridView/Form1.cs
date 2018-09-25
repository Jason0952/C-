using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        bool display = false;
        public Form1()
        {
            InitializeComponent();
            var list = CreateList();
            dataGridView1.DataSource = list;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var source = (List<MyData>)dataGridView1.DataSource;
            List<MyData> ordered;
            switch (e.ColumnIndex)
            {
                case 1:       //點到第一個colum上面
                    if (display == false)
                    {
                        ordered = source.OrderBy((x) => x.DisName).ToList();
                    }
                    else
                    {
                        ordered = source.OrderByDescending((x) => x.DisName).ToList();
                    }
                    display = !display;
                    break;
                case 2:
                    if (display == false)
                    {
                        ordered = source.OrderBy((x) => x.Shop).ToList();
                    }
                    else
                    {
                        ordered = source.OrderByDescending((x) => x.Shop).ToList();
                    }
                    display = !display;
                    break;
                case 3:
                    if (display == false)
                    {
                        ordered = source.OrderBy((x) => x.Address).ToList();
                    }
                    else
                    {
                        ordered = source.OrderByDescending((x) => x.Address).ToList();
                    }
                    display = !display;
                    break;
                case 4:
                    if (display == false)
                    {
                        ordered = source.OrderBy((x) => x.Tel).ToList();
                    }
                    else
                    {
                        ordered = source.OrderByDescending((x) => x.Tel).ToList();
                    }
                    display = !display;
                    break;
                default:      //case不能為0，所以放最後的例外
                    ordered = source.OrderBy((x) => x.Seq).ToList();
                    break;
            }
            dataGridView1.DataSource = ordered;
        }

        private List<MyData> CreateList()
        {
            char[] splits = new char[] { ',' };
            string fileName = "bbb.csv";
            List<MyData> result = new List<MyData>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName); for (int i = 1; i < lines.Count(); i++)
                {
                    string[] items = lines[i].Split(splits);
                    var restaurant = new MyData
                    {
                        Seq = int.Parse(items[0]),
                        DisName = items[1],
                        Shop = items[3],
                        Address = items[4],
                        Tel = items[5]
                    };
                    result.Add(restaurant);
                }
            }
            return result;

        }
    }
}

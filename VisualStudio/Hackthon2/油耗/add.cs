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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            OilTable data = new OilTable()
            {
                RefuelingDate = dateTimePicker1.Value,
                Liter = decimal.ToInt32(numericUpDown1.Value),
                Kilometer = decimal.ToInt32(numericUpDown2.Value)
            };
            try
            {
                Createdata record = new Createdata();
                record.OilTable.Add(data);
                record.SaveChanges();
                MessageBox.Show("存檔完成");
                ClearNum();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }

        private void ClearNum()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 計算假日
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = textBox1.Text;
            int b;
            int.TryParse(a, out b);
            int allsaturday = getsaturday(b);
            int allsunday = getsunday(b);
            label1.Text = "星期六有:" + allsaturday + "天" + "星期天有:" + allsunday + "天";
        }

        private int getsaturday(int days)
        {
            int holiday6 = 0;
            DateTime startyear = new DateTime(days, 1, 1);
            DateTime endyear = new DateTime(days, 12, 31);
            DayOfWeek saturday = DayOfWeek.Saturday;
            while (startyear <= endyear)
            {
                if (startyear.DayOfWeek == saturday)
                {
                    holiday6++;
                }
                startyear = startyear.AddDays(1);
            }
            return holiday6;
        }

        private int getsunday(int days)
        {
            int holiday7 = 0;
            DateTime startyear = new DateTime(days, 1, 1);
            DateTime endyear = new DateTime(days, 12, 31);
            DayOfWeek sunday = DayOfWeek.Sunday;
            while (startyear <= endyear)
            {
                if (startyear.DayOfWeek == sunday)
                {
                    holiday7++;
                }
                startyear = startyear.AddDays(1);
            }
            return holiday7;
        }
    }
}

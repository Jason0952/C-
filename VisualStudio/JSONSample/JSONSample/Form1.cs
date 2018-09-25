using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false; //if(true)有多少欄位就產多少
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string uri = "http://lod2.apc.gov.tw/APCDataApi.ashx?apiId=102015&format=json"; //叫uri去網路上抓資料
            string data = await client.GetStringAsync(uri); //data await(等待)uri從網路拿資料過來 vs uri正在拿資料 ---------
                                                                                              //                         |
            var result = JsonConvert.DeserializeObject<Restaurant[]>(data); //deserializeObject非同步(兩個在做不同的事) <--
            dataGridView1.DataSource = result;

        }
    }
}

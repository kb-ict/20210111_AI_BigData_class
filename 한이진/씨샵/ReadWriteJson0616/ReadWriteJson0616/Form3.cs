using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteJson0616
{
    public partial class Form3 : Form
    {
        public List<Hospital> hospitals = new List<Hospital>();
        public Form3()
        {
            InitializeComponent();
        }

        private void btn_dataview_Click(object sender, EventArgs e)
        {
            //List<Hospital> hospitals = new List<Hospital>();
            using(WebClient wc = new WebClient())
            {
                string url = "https://api.odcloud.kr/api/3076329/v1/uddi:9945bcbc-7f03-4f3e-b374-e24a3e1eb5b2_201604151430?page=1&perPage=24&serviceKey=H7J7uLgD9PdCIm3xPaTGiRqsInYdN2ANv42apuqJVqFywsRVGkqG5Znn0Q6NqulKUbw1%2FXlS%2FwFuRsgj1o4KPg%3D%3D";
                //var json = wc.DownloadString(url);
                var json = wc.DownloadData(url); //데이터가 byte로 받아들여짐 
                var json_string = Encoding.UTF8.GetString(json); //utf8로 인코딩
                //Console.WriteLine(Encoding.UTF8.GetString(json));
                //byte[] bytes = Encoding.Default.GetBytes(json);
                //json = Encoding.UTF8.GetString(bytes);

                File.WriteAllText(@".\Hospital.json", json_string);
                var jArry = JObject.Parse(json_string);

                foreach (var item in jArry["data"])
                {

                    hospitals.Add(new Hospital(
                        int.Parse(item["연번"].ToString()), item["개설일자"].ToString(), item["병상수 계"].ToString(),
                        item["소재지"].ToString(), item["의료기관명"].ToString(),
                        item["종별"].ToString(), item["전화번호"].ToString()
                        ));
                }


            }
            hospitalView.DataSource = null;
            hospitalView.DataSource = hospitals;
            chartView();
        }

        private void chartView()
        {
            Roomchart.Series[0].Name = "병상수";
            for(int i=0; i < hospitals.Count; i++)
            {
                
                Roomchart.ChartAreas[0].AxisY.Maximum = 1200;
                Roomchart.Series[0].Points.AddXY(hospitals[i].num.ToString(),int.Parse(hospitals[i].totalRoom));
            }
        }
    }
}

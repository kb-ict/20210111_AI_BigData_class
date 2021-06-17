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

namespace Json0617
{
    public partial class Form1 : Form
    {
        public List<Doctor> doctors = new List<Doctor>();
        const string FILENAME = @"jsonFile\Doctors.json";
        public Form1()
        {
            InitializeComponent();
            /*chart1.Series[0].Name = "성적";
            //차트에 데이터 넣기
            for( int i=0; i<=10; i++)
            {
                //chart1.Series[0].Points.AddXY(i, i * 10);
                chart1.Series["성적"].Points.AddXY(i, i * 10);
                //Addxy(x축,y출)
            }
            //항목 추가
            chart1.Series.Add("나이");

            for (int i = 0; i <= 10; i++)
            {
                chart1.Series[1].Points.AddXY(i, i * 10);
                //Addxy(x축,y출)
            }*/

        }

        private void but_write_Click(object sender, EventArgs e)
        {
           
            var jdoctorArray = new JArray();
            var jdoctorObject = new JObject();

            try
            {
                //방법1 버튼 강제 클릭
                //but_read.PerformClick(); //읽기 우선하고 데이터 추가
                load(FILENAME);
            }
            catch (Exception ex)
            {

            }
            
            if (doctors.Count > 0)
            {
                foreach(var item in doctors)
                {
                    jdoctorObject = new JObject();
                    jdoctorObject.Add("name", item.name);
                    jdoctorObject.Add("sabeon", item.sabeon);
                    jdoctorArray.Add(jdoctorObject);
                }
            }
            jdoctorObject = new JObject(); // 값 초기화
            jdoctorObject.Add("name", textBox_name.Text);
            jdoctorObject.Add("sabeon", textBox_sabaon.Text);
            jdoctorArray.Add(jdoctorObject);

            var jDoctorArray_Object = new JObject();
            jDoctorArray_Object.Add("doctor", jdoctorArray);

            var jDoctors_Object = new JObject();
            jDoctors_Object.Add("doctors", jDoctorArray_Object);

            //특정폴더 만들고 넣기
            DirectoryInfo di = new DirectoryInfo("jsonFile");
            if (!di.Exists)//해당 폴더가 없는 경우
                di.Create(); //폴더 생성

            //파일 만 생성하고 싶을때
            StreamWriter writer = File.CreateText("Doctors.json");
            writer.Dispose();//메모리 해체
           
            File.WriteAllText(@"jsonFile\Doctors.json", jDoctors_Object.ToString());
        }

        private void but_read_Click(object sender, EventArgs e)
        {
            load(FILENAME);
            /*doctors.Clear();
            string source = File.ReadAllText(@"jsonFile\Doctors.json");
            JObject jsonDoctor = JObject.Parse(source);

            foreach (var item in jsonDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString().Replace("{", "").Replace("}", "");
                temp.sabeon = item["sabeon"].ToString().Replace("{", "").Replace("}", "");

                doctors.Add(temp);

            }
            dataGridView1.DataSource = doctors;*/

            /*//linq 문법
            doctors.Clear();
            doctors =(from item in jsonDoctor["doctors"]["doctor"] select new Doctor()
            {
                name = item["name"].ToString().Replace("{", "").Replace("}", ""),
                sabeon = item["sabeon"].ToString().Replace("{", "").Replace("}", "")

            }).ToList<Doctor>();
            dataGridView1.DataSource = doctors;*/

           

        }
        public void load(string file)
        {
            doctors.Clear();
            string source = File.ReadAllText(file);
            JObject jsonDoctor = JObject.Parse(source);

            foreach (var item in jsonDoctor["doctors"]["doctor"])
            {
                Doctor temp = new Doctor();
                temp.name = item["name"].ToString().Replace("{", "").Replace("}", "");
                temp.sabeon = item["sabeon"].ToString().Replace("{", "").Replace("}", "");

                doctors.Add(temp);

            }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = doctors;
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            //노가다 방식
            //기본 경로 지정해주기
            openFileDialog1.InitialDirectory = @"D:\C-_study\Json0617\Json0617\bin\Debug";
            //방식 2
            //exe파일이 있는 경로를 찾아서 저장
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            //필터 지정 가능
            openFileDialog1.Filter = "json파일 |*.json";
            //파일 추가시에는 "|소스파일 | *.확장자 식으로 추가
            openFileDialog1.Filter += "|소스파일 |*.cs";
            //파일 다이로그 창 띄우기
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//열기 버튼을 클릭 할때
            {
                //MessageBox.Show(openFileDialog1.FileName);//선택한 파일명 메세지창에 알려줌
                load(openFileDialog1.FileName);

            }
        }

        private void button_json_api_Click(object sender, EventArgs e)
        {
            int count = 950; //로또 회차
            string url = "https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo="+count;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                var jArray = JObject.Parse(json);

                foreach(var item in jArray)
                {
                    Console.WriteLine(item.Key);
                    Console.WriteLine(item.Value);
                }
                //get some want key 
                Console.WriteLine(jArray["totSellamnt"]);

                DisplayLotto();

            /*    chart1.Series[0].Name = jArray["drwNo"].ToString()+" 회차 당첨번호";
                chart1.Series[0].Points.AddXY("번호1", int.Parse(jArray["drwtNo1"].ToString()));
                chart1.Series[0].Points.AddXY("번호2", int.Parse(jArray["drwtNo2"].ToString()));
                chart1.Series[0].Points.AddXY("번호3", int.Parse(jArray["drwtNo3"].ToString()));
                chart1.Series[0].Points.AddXY("번호4", int.Parse(jArray["drwtNo4"].ToString()));
                chart1.Series[0].Points.AddXY("번호5", int.Parse(jArray["drwtNo5"].ToString()));
                chart1.Series[0].Points.AddXY("번호6", int.Parse(jArray["drwtNo6"].ToString()));
                chart1.Series[0].Points.AddXY("보너스", int.Parse(jArray["bnusNo"].ToString()));
                */

            }



        }

        private void DisplayLotto()
        {
            List<Lotto> lottos = new List<Lotto>();
            int count = 960;
            while (true)
            {
                using (WebClient wc = new WebClient())
                {
                    var json = wc.DownloadString("https://www.dhlottery.co.kr/common.do?method=getLottoNumber&drwNo=" + count);
                    count++;

                    var jArray = JObject.Parse(json);

                    if (jArray["returnValue"].ToString() == "fail")
                        break;
                    lottos.Add(new Lotto(
                        jArray["drwtNo1"].ToString(),
                        jArray["drwtNo2"].ToString(),
                        jArray["drwtNo3"].ToString(),
                        jArray["drwtNo4"].ToString(),
                        jArray["drwtNo5"].ToString(),
                        jArray["drwtNo6"].ToString(),
                        jArray["bnusNo"].ToString(),
                        jArray["drwNo"].ToString(), jArray["drwNoDate"].ToString()
                        ));

                }
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = lottos;

            }
            chart1.Series[0].Name = lottos[0].drwNo + " 회차 당첨번호";
            for (int i=0; i < lottos.Count; i++)
            {
                if(i>0)
                    chart1.Series.Add(lottos[i].drwNo + " 회차 당첨번호");

                chart1.Series[i].Points.AddXY("번호1", int.Parse(lottos[i].drwtNo1));
                chart1.Series[i].Points.AddXY("번호2", int.Parse(lottos[i].drwtNo2));
                chart1.Series[i].Points.AddXY("번호3", int.Parse(lottos[i].drwtNo3));
                chart1.Series[i].Points.AddXY("번호4", int.Parse(lottos[i].drwtNo4));
                chart1.Series[i].Points.AddXY("번호5", int.Parse(lottos[i].drwtNo5));
                chart1.Series[i].Points.AddXY("번호6", int.Parse(lottos[i].drwtNo6));
                chart1.Series[i].Points.AddXY("보너스", int.Parse(lottos[i].bnusNo));
            }                 
            
        }
    }
}

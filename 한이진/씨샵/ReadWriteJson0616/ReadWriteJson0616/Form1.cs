using Newtonsoft.Json.Linq;
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
using System.Xml.Linq;

namespace ReadWriteJson0616
{
    public partial class Form1 : Form
    {
        const string FILENAME = @"jsonData\Students.json";
        public List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {

            students.Clear();//중복방지
            string source = File.ReadAllText(FILENAME);//파일이름 상수로 지정하여 휴먼에러 줄임
            JObject jsonObjectStudent = JObject.Parse(source);

            //linq 라는 문법 활용
            //리스트에 값을 넣은 하나의 방법
            //디버깅 하기 힘든 단점
            students = (from item in jsonObjectStudent["students"]["student"]
                        select new Student()
                        {
                            name = item["name"].ToString().Replace("{", "").Replace("}", ""),
                            age = int.Parse(item["age"].ToString().Replace("{", "").Replace("}", "")),
                            hakbeon = item["hakbeon"].ToString().Replace("{", "").Replace("}", "")
                        }).ToList<Student>();
            studentsView.DataSource = null;
            studentsView.DataSource = students;


        }

        private void but_write_Click(object sender, EventArgs e)
        {
            try
            {
                //btn_read.PerformClick();//강제 클릭
                load(FILENAME, studentsView);
            }catch(Exception ex)
            {

            }
            
            var jstudentArray = new JArray(); //Newtonsoft.Json 정의한 객체 
            //student []
            //var 데이터 형을 정하지 않는 변수 선언(let 동일)
            //c#은 선언 시점에서 초기화한 데이터형으로 고정
            var jstudentObject = new JObject();
            /*try
            {
                //강제 클릭
                btn_read.PerformClick();
            }
            catch (Exception)
            {
                throw
            }*/
            
            if (students.Count>0)
            {
                foreach(var item in students)
                {
                    jstudentObject = new JObject();
                    jstudentObject.Add("name", item.name);
                    jstudentObject.Add("age", item.age);
                    jstudentObject.Add("hakbeon", item.hakbeon);
                    jstudentArray.Add(jstudentObject);
                }
                
            }
            jstudentObject = new JObject();
            jstudentObject.Add("name", textBox_name.Text);
            jstudentObject.Add("age", textBox_age.Text);
            jstudentObject.Add("hakbeon", textBox_hakbeon.Text);
            jstudentArray.Add(jstudentObject);

            //json 배열에 student 객체 추가

            var jstudentArray_object = new JObject();
            jstudentArray_object.Add("student", jstudentArray);
            // "students"의 객체 {[{ Student}]}
            var jstudents_object = new JObject();
            jstudents_object.Add("students", jstudentArray_object);
            //만약 특정 파일 안에 데이터 넣고 싶은데 그 폴더가 없는 경우
            //
            DirectoryInfo di = new DirectoryInfo("jsonData");
            if (!di.Exists)
                di.Create();
            File.WriteAllText(@"jsonData\Students.json", jstudents_object.ToString());
            //혹은 특정 파일만 생성하고 싶을때
            StreamWriter textfile = File.CreateText("text.txt");
            textfile.Dispose();

            File.WriteAllText(@"jsonData\Students.json", jstudents_object.ToString());
        }

        private void btn_api_Click(object sender, EventArgs e)
        {
            string url = "https://api.odcloud.kr/api/15052028/v1/uddi:5d02dab1-6daf-40b6-82ac-e9331cfd85a2_201912161604?page=1&perPage=10&returnType=XML&serviceKey=H7J7uLgD9PdCIm3xPaTGiRqsInYdN2ANv42apuqJVqFywsRVGkqG5Znn0Q6NqulKUbw1%2FXlS%2FwFuRsgj1o4KPg%3D%3D";
            XElement api = XElement.Load(url);
            List<Facility> facilities = new List<Facility>();
            //foreach (var data in api.Descendants("item"))
            //{
            //    string num = data.("연번");
            //    string city = data.GetNamespaceOfPrefix("시군").NamespaceName;
            //    string type = data.GetNamespaceOfPrefix("시설종류").NamespaceName;
            //    string name = data.GetNamespaceOfPrefix("시설명").NamespaceName;
            //    string address = data.GetNamespaceOfPrefix("소재지").NamespaceName;
            //    string tel = data.GetNamespaceOfPrefix("연락처").NamespaceName;
            //    string allpeople = data.GetNamespaceOfPrefix("정원").NamespaceName;
            //    string people = data.GetNamespaceOfPrefix("현원").NamespaceName; ;
            //    facilities.Add(new Facility(num, city, type, name, address, tel, allpeople, people));
            //}


            foreach (var item in api.Descendants("item"))
            {
                int indexer = 0;
                string num = "";
                string city = "";
                string type = "";
                string name = "";
                string address = "";
                string tel = "";
                string allpeople = "";
                string people = "";
                foreach (var item2 in item.Elements("col").Attributes().ToList())
                {
                    switch (item2.Value)
                    {
                        case "연번":
                            num = item.Elements("col").ToList()[indexer].Value;
                            break;
                        case "시군":
                            city= item.Elements("col").ToList()[indexer].Value;
                            break;
                        case "시설종류":
                            type = item.Elements("col").ToList()[indexer].Value;
                            break;
                        case "시설명":
                            name= item.Elements("col").ToList()[indexer].Value;
                            break;
                        case "소재지":
                            address= item.Elements("col").ToList()[indexer].Value;
                            break;
                        case "연락처":
                            tel = item.Elements("col").ToList()[indexer].Value;
                            break;
                        case "정원":
                            allpeople= item.Elements("col").ToList()[indexer].Value;
                            break;
                        case "현원":
                            people= item.Elements("col").ToList()[indexer].Value;
                            break;
                        default:
                            break;
                    }
                    indexer++;
                }
                facilities.Add(new Facility(num, city, type, name, address, tel, allpeople, people));
            }
            facilityView.DataSource = facilities;
        }

        private void gotoForm2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
        public void load(string filename, DataGridView view)
        {
            students.Clear();
            string source = File.ReadAllText(filename);
            JObject jsonStudent = JObject.Parse(source);

            foreach (var item in jsonStudent["students"]["student"])
            {
                Student temp = new Student();
                temp.name = item["name"].ToString().Replace("{", "").Replace("}", "");
                temp.age = int.Parse(item["age"].ToString().Replace("{", "").Replace("}", ""));
                temp.hakbeon = item["hakbeon"].ToString();

                students.Add(temp);

            }
            view.DataSource = null;
            view.DataSource = students;
        }

        private void goDataview_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}

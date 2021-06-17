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

namespace ReadWriteJson0616
{
    public partial class Form2 : Form
    {
        public List<Member> members = new List<Member>();
        const string FILEMEMBER = @"jsonFile\Members.json";
        public Form2()
        {
            InitializeComponent();
        }

        private void bnt_MemberWrite_Click(object sender, EventArgs e)
        {
            var jmemberArray = new JArray();
            var jmemberObject = new JObject();

            try
            {
                //btn_MemberRead.PerformClick();
                load(FILEMEMBER);

            }
            catch (Exception ex)
            {

            }

            if (members.Count > 0)
            {
                foreach(var item in members)
                {
                    jmemberObject = new JObject();
                    jmemberObject.Add("id", item.id);
                    jmemberObject.Add("name", item.name);
                    jmemberObject.Add("pw", item.pw);
                    jmemberObject.Add("tel", item.tel);
                    jmemberObject.Add("address", item.address);
                    jmemberArray.Add(jmemberObject);
                }
            }
            jmemberObject = new JObject();
            jmemberObject.Add("id", tb_id.Text);
            jmemberObject.Add("name", tb_name.Text);
            jmemberObject.Add("pw", tb_pw.Text);
            jmemberObject.Add("tel", tb_tel.Text);
            jmemberObject.Add("address", tb_address.Text);
            jmemberArray.Add(jmemberObject);

            var jmemberArray_Object = new JObject();
            jmemberArray_Object.Add("member", jmemberArray);

            var jmembers_object = new JObject();
            jmembers_object.Add("members", jmemberArray_Object);

            DirectoryInfo di = new DirectoryInfo("jsonFile");
            if (!di.Exists)
                di.Create();
            StreamWriter writer = File.CreateText("Member.json");
            writer.Dispose();

            File.WriteAllText(@"jsonFile\Members.json", jmembers_object.ToString());
        }

        private void btn_MemberRead_Click(object sender, EventArgs e)
        {
           
            load(FILEMEMBER);
            /*members.Clear();
            string datasource = File.ReadAllText("Members.json");
            JObject jsonMember = JObject.Parse(datasource);

            members = (from item in jsonMember["members"]["member"] select new Member() 
            {
                id= int.Parse(item["id"].ToString().Replace("{","").Replace("}","")),
                name=item["name"].ToString().Replace("{", "").Replace("}", ""),
                pw = item["pw"].ToString().Replace("{", "").Replace("}", ""),
                tel = item["tel"].ToString().Replace("{", "").Replace("}", ""),
                address = item["address"].ToString().Replace("{", "").Replace("}", ""),

            }).ToList<Member>();
            MemberView.DataSource = members;*/
            /*members.Clear();
            string source = File.ReadAllText(FILEMEMBER);
            JObject jsonMember = JObject.Parse(source);

            foreach (var item in jsonMember["members"]["member"])
            {
                Member temp = new Member();
                temp.id = int.Parse(item["id"].ToString());
                temp.name = item["name"].ToString();
                temp.pw = item["pw"].ToString();
                temp.tel = item["tel"].ToString();
                temp.address = item["address"].ToString();

                members.Add(temp);
            }
            MemberView.DataSource = null;
            MemberView.DataSource = members;*/
        }
        public void load(string filename)
        {
            members.Clear();
            string source = File.ReadAllText(filename);
            JObject jsonMember = JObject.Parse(source);

            foreach(var item in jsonMember["members"]["member"])
            {
                Member temp = new Member();
                temp.id = int.Parse(item["id"].ToString());
                temp.name = item["name"].ToString();
                temp.pw = item["pw"].ToString();
                temp.tel = item["tel"].ToString();
                temp.address = item["address"].ToString();

                members.Add(temp);
            }
            MemberView.DataSource = null;
            MemberView.DataSource = members;
        }
    }
}

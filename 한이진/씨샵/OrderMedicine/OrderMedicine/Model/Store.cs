using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMedicine.Model
{
    class Store
    {
        private string stoName;
        private string manager;
        private string phone;
        private string address;

        public Store(string stoName, string manager, string phone, string address)
        {
            this.stoName = stoName;
            this.manager = manager;
            this.phone = phone;
            this.address = address;
        }

        public string StoName { get => stoName; set => stoName = value; }
        public string Manager { get => manager; set => manager = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }

        public override string ToString()
        {
            string data = ">>>>>>>>>>>>> 약국 정보 <<<<<<<<<<";
            data += "약국명: " +stoName + "\n";
            data += "매니저: " + manager + "\n";
            data += "전화번호: " + phone + "\n";
            data += "주소: " + address + "\n";
            data += "---------------------------------";
            return data;
        }
        public void storePrintInfo()
        {
            Console.WriteLine(">>>>>>>>>>>>> 약국 정보 <<<<<<<<<<");
            Console.WriteLine("약국명: " + stoName);
            Console.WriteLine("매지저: " +manager);
            Console.WriteLine("전화번호: " +phone);
            Console.WriteLine("주소: " +address);
            Console.WriteLine("---------------------------------");
        }
    }


}

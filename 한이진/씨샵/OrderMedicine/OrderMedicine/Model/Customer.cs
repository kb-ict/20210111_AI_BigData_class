using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMedicine.Model
{
    class Customer
    {
        private string custId;
        private string custName;
        private string custAge;
        private char custGender;
        private string custAddress;
        private string custPhone;

        public Customer(string custId, string custName, string custAge, char custGender, string custAddress, string custPhone)
        {
            this.custId = custId;
            this.custName = custName;
            this.custAge = custAge;
            this.custGender = custGender;
            this.custAddress = custAddress;
            this.custPhone = custPhone;
        }

        public string CustId { get => custId; set => custId = value; }
        public string CustName { get => custName; set => custName = value; }
        public string CustAge { get => custAge; set => custAge = value; }
        public char CustGender { get => custGender; set => custGender = value; }
        public string CustAddress { get => custAddress; set => custAddress = value; }
        public string CustPhone { get => custPhone; set => custPhone = value; }

        public override string ToString()
        {

            string data = ">>>>>>>>>>>>> 고객 정보 <<<<<<<<<<";
            data += "고객 Id: " + custId + "\n";
            data += "고객 이름: " + custName + "\n";
            data += "생년(YYYY): " + custAge + "\n";
            data += "성별: " + custGender + "\n";
            data += "주소: " + custAddress + "\n";
            data += "전화번호: " + custPhone + "\n";
            data += "---------------------------------";
            return data;
        }

        public void custPrintInfo()
        {
            Console.WriteLine(">>>>>>>>>>>>> 고객 정보 <<<<<<<<<<");
            Console.WriteLine("ID: " + custId);
            Console.WriteLine("Name: " + custName);
            Console.WriteLine("Birth Year(YYYY): " + custAge);
            Console.WriteLine("Gender: " + custGender);
            Console.WriteLine("Address: " + custAddress);
            Console.WriteLine("Phone: " + custPhone);



        }
    }
}

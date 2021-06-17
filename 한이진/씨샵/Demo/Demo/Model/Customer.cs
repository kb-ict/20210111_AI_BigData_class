using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    class Customer
    {
        //인스턴스 변수
        private string name;
        private int age;
        private string tel;
        private string address;
        private char gender;
        //생성자
        public Customer(string name, int age, string tel, string address, char gender)
        {
            this.name = name;
            this.age = age;
            this.tel = tel;
            this.address = address;
            this.gender = gender;
        }

        //get와 set 자동 생성
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public char Gender { get => gender; set => gender = value; }

        public void CustomerInfo()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
            Console.WriteLine("성별: " + gender);
            Console.WriteLine("전화: " + tel);
            Console.WriteLine("주소: " + address);
            Console.WriteLine("--------------------");

        }
        //오버라이딩 object 클래스 상속: 재정의
        public override string ToString()
        {
            string data = "이름: " + name + "\n" + "나이: " + age + "\n" + "성별: " + gender + "\n" + "전화: " + tel + "\n" + "주소: " + address + "\n";
            data += "-------------------------";
            return data; 
            // base는 object클래스를 가르킴
        }

       

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest1
{
    class Student
    {
        public const string SCHCOOL = "대구초등";       
        private string name;
        private int age;
        private char gender;
        private string tel;
        private string addr;
        //생성자
        public Student()
        {
        }
        //매개변수 받는 생성자
        public Student(string name, int age, char gender, string tel, string addr)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.tel = tel;
            this.addr = addr;
        }
        //getter, setter 자동생성
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Addr { get => addr; set => addr = value; }
        
        //오버라이딩
        public override string ToString()
        {
            return base.ToString();
        }

        //인스턴스 메소드 추가
        public void studentInfo()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("gender: " + gender);
            Console.WriteLine("tel: " + tel);
            Console.WriteLine("address: " + addr);
            Console.WriteLine("____________________");
        }
    }



}

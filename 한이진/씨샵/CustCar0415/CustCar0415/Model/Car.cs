using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415.Model
{
    // 모든 클래스의 최상위 클래스는 object
    class Car
    {
        //static 클래스변수
        public const string JIJUM = "동대구영업소"; //상수 변수 선언과 초기화, 공통 사용

        //c#은 명시하지 않으면 자동으로 private! 
        //java는 public
        //인스턴스 변수
        private string model;
        private string color;
        private string company;
        private string price;

       /* public Car() //default 생성자, 객체를 생성시 호출
        { 
            //주력 상품
            model = "아반뗴";
            color = "회색";
            company = "현대";
            price = "2천만원";
        }*/
     
        public Car(string model, string color, string company, string price)//매배변수를 갖는 생성자 오버로딩 한것이다
        {
            this.model = model;
            this.color = color;
            this.company = company;
            this.price = price;
        }

        //geter, seter 메소드 생성 {람다식}
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public string Company { get => company; set => company = value; }
        public string Price { get => price; set => price = value; }

        public void printInfoCar()
        {
            Console.WriteLine("모델: " + model);
            Console.WriteLine("제조사: " + company);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("가격: " + price);
            Console.WriteLine("--------------------");
        }
        //오버라이딩: object의 메소드 재정의
        public override string ToString()
        {
            string str = "모델: " + model + "\n" + "제조사: " + company + "\n" + "색상: " + color + "\n" + "가격: " + price + "\n";
            str += "------------------------";

            return str;
        }
    }
}

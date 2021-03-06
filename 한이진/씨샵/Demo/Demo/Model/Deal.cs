using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    class Deal<Ca, Cu, Se> //제네릭 
    {
        private Ca ca; //거래 차량
        private Cu cu; //거래 고객
        private Se se; //직원
        private string date; // 거래일자
        private string price; //실거래가

        public Deal(Ca ca, Cu cu, Se se, string date, string price)
        {
            this.ca = ca;
            this.cu = cu;
            this.se = se;
            this.date = date;
            this.price = price;
        }

        public Ca Car { get => ca; set => ca = value; }
        public Cu Customer { get => cu; set => cu = value; }
        public Se Seller { get => se; set => se = value; }
        public string Date { get => date; set => date = value; }
        public string Price { get => price; set => price = value; }

        public override string ToString()
        {
            Car car = this.Car as Car; // ca as Car; 동일문
            Customer customer = this.Customer as Customer;
            Seller seller = this.Seller as Seller;
            string data = "★☆★ 구매 차량 정보 ☆★☆" + "\n";
            data += "\n";
            data += car.ToString()+"\n";
            data += "★☆★ 구매 고객 정보 ☆★☆" + "\n";
            data += "\n";
            data += customer.ToString()+"\n";
            data += "★☆★ 판매자 정보☆★☆" + "\n";
            data += "\n";
            data += seller.ToString() + "\n";
            data += "★☆★ 거래 정보 ☆★☆" + "\n";
            data += "\n";
            data += "거래 날짜: " + date + "\n";
            data += "거래 금액: " + price + "\n";

            return data;
        }

        public void dealInfo()
        {
            Car car = this.Car as Car; //as 타입 캐스팅, ca as Car; 동일문
            Customer customer = this.Customer as Customer;
            Seller seller = this.Seller as Seller;
            Console.WriteLine("★☆★ 거래 정보 요약  ☆★☆");
            Console.WriteLine("차량 모델: "+ car.Model);
            Console.WriteLine("차량 가격: " + car.Price);

            Console.WriteLine("구매자: " + customer.Name);
            Console.WriteLine("판매자: " + seller.Name);
            Console.WriteLine("거래일자: " + date);
            Console.WriteLine("실거래가: " + price);
        }
    }
}

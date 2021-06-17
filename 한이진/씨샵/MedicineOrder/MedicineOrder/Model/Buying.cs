using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineOrder.Model
{
    class Buying<Cu,Me,St>
    {
        private Cu cust;
        private Me medi;
        private St store;
        private string date;
        

        public Buying(Cu cust, Me medi, St store, string date)
        {
            this.cust = cust;
            this.medi = medi;
            this.store = store;
            this.date = date;
        }

        public Cu Customer { get => cust; set => cust = value; }
        public Me Medicine { get => medi; set => medi = value; }
        public St Store { get => store; set => store = value; }
        public string Date { get => date; set => date = value; }

        public override string ToString()
        {
            Customer customer = this.Customer as Customer;
            Medicine medicine = this.Medicine as Medicine;
            Store store = this.Store as Store;
            string data = "★☆★ 구매 고객 정보 ☆★☆";
            data += "\n";
            data += customer.ToString()+"\n";
            data += "★☆★ 구매 약품 정보 ☆★☆";
            data += "\n";
            data += medicine.ToString() + "\n";
            data += "★☆★ 약국 정보 ☆★☆";
            data += "\n";
            data += store.ToString() + "\n";

            return data;
        }

        public void buyingInfo()
        {
            Customer customer = this.Customer as Customer;
            Medicine medicine = this.Medicine as Medicine;
            Store store = this.Store as Store;
            Console.WriteLine("★☆★ 구매 정보 요약  ☆★☆");
            Console.WriteLine("제품코드: " + medicine.PId);
            Console.WriteLine("약품명: " + medicine.MediName);
            Console.WriteLine("가격: " + medicine.Price);
            Console.WriteLine("구매 고객명: " + customer.CustName);
            Console.WriteLine("생년(YYYY): " + customer.CustAge);
            Console.WriteLine("거래일자: " + date);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMedicine.Model
{
    class Medicine
    {
        private string pId;
        private string mediName;
        private string effect;
        private string taking;
        private string price;

        //public Medicine() { }
       
        public Medicine(string pId, string mediName, string effect, string taking, string price)
        {
            this.pId = pId;
            this.mediName = mediName;
            this.effect = effect;
            this.taking = taking;
            this.price = price;
        }

        public string PId { get => pId; set => pId = value; }
        public string MediName { get => mediName; set => mediName = value; }
        public string Effect { get => effect; set => effect = value; }
        public string Takeing { get => taking; set => taking = value; }
        public string Price { get => price; set => price = value; }

        public override string ToString()
        {
            string data = ">>>>>>>>>>>>> 약품 정보 <<<<<<<<<<"+"\n";
            data += "제품 코드: " + pId + "\n";
            data += "약품명: " + mediName + "\n";
            data += "효과(증상): " + effect + "\n";
            data += "복용법: " + taking + "\n";
            data += "가격: " + price + "\n";
            data += "---------------------------------";
            return data;
        }

        public void mediPrintInfo()
        {
            Console.WriteLine(">>>>>>>>>>>>> 약품 정보 <<<<<<<<<<");
            Console.WriteLine("PID: " + PId);
            Console.WriteLine("Product: " + mediName);
            Console.WriteLine("Effect: " + effect);
            Console.WriteLine("Taking: " + taking);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("----------------------------------");
        }
    }
}

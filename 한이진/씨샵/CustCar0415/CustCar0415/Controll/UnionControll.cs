using CustCar0415.Common;
using CustCar0415.Model;
using CustCar0415.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustCar0415.Controll
{
    class UnionControll : BaseControll
    {
        CarControll carHandle;
        CustControll custHandle;
        SellControll sellHandle;
        List<Deal<Car, Customer, Seller>> listun; //제네릭 타입 선정

        public UnionControll(RandData rand)
        {
            this.rand = rand;
            listItem = new List<object>();
            listun = listItem.Cast<Deal<Car, Customer, Seller>>().ToList();
            carHandle = new CarControll(rand);
            custHandle = new CustControll(rand);
            sellHandle = new SellControll(rand);
        }
        //생성자 오버로딩
        public UnionControll(CarControll carHandle, CustControll custHandle, SellControll sellHandle)
        {
            this.carHandle = carHandle;
            this.custHandle = custHandle;
            this.sellHandle = sellHandle;
        }

        internal CarControll CarHandle { get => carHandle; set => carHandle = value; }
        internal CustControll CustHandle { get => custHandle; set => custHandle = value; }
        internal SellControll SellHandle { get => sellHandle; set => sellHandle = value; }
        internal List<Deal<Car, Customer, Seller>> Listun { get => listun; set => listun = value; }

        //internal은 default C#에서 명시 않면 private , java는 default
        public void itemViewAll() //상세 정보 출력
        {
            if (listun.Count == 0)
            {
                Console.WriteLine("거래 데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < listun.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listun[i].ToString());
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
            }
        }
        public override void insRandData(int count)
        {
            for (int i = 0; i < count; i++) //getName(), ...=> RandData에서 정의한 메서드
            {
                listun.Add(new Deal<Car, Customer, Seller>(new Car(rand.getModel(), rand.getColor(), rand.getCompany(), rand.getPrice()),
                            new Customer(rand.getName(), rand.getAge(), rand.getTel(), rand.getaddress(), rand.getGender()),
                            new Seller(rand.getName(), rand.getTel(), rand.getLevel(), rand.getOffice()),
                            DateTime.Now.ToString("yyyy년mm월dd일-") + DateTime.Now.ToString("hh:mm분:ss초"), rand.getPrice() + "+500만원"));
            }
        }

        public override void itemView()
        {
            if (listun.Count == 0)
            {
                Console.WriteLine("거래 데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < listun.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                listun[i].dealInfo();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();

            }
        }

        public override void removeAll()
        {
            if (listun.Count == 0)
            {
                Console.WriteLine("거래 데이터가 존재하지 않습니다.");
                return;
            }
            listun.Clear();
        }

        public override void addItem(object item)
        {
            listun.Add(item as Deal<Car,Customer,Seller>);
        }

        public override void delItem(string item)
        {
         
            throw new NotImplementedException();
        }

        public override void updateItem(string[] item)
        {
            throw new NotImplementedException();
        }
    }
}

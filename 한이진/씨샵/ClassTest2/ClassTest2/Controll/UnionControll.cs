using ClassTest2.Model;
using ClassTest2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Controll
{
    class UnionControll
    {
        CarControll carHandle;
        CustControll custHandle;
        SellControll sellHandle;
        List<Deal<Car, Customer, Seller>> listun = new List<Deal<Car, Customer, Seller>>(); //제네릭 타입 선정
        RandData rand;

        public UnionControll(RandData rand)
        {
            this.rand = rand;
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
        //internal은 default C#에서 명시 않면 private , java는 default

        public void addItem(Deal<Car, Customer, Seller> deal) 
        {
            listun.Add(deal);
        }
        public void insrtRandData(int count) //랜덤데이터 생성
        {
            for (int i = 0; i < count; i++) //getName(), ...=> RandData에서 정의한 메서드
            {
                listun.Add(new Deal<Car, Customer, Seller>(new Car(rand.getModel(), rand.getColor(), rand.getCompany(), rand.getPrice()),
                            new Customer(rand.getName(),rand.getAge(),rand.getTel(),rand.getaddress(),rand.getGender()),
                            new Seller(rand.getName(),rand.getTel(),rand.getLevel(),rand.getOffice()),
                            DateTime.Now.ToString("yyyy년mm월dd일-")+DateTime.Now.ToString("hh:mm분:ss초"),rand.getPrice()+"+500만원"));
            }
        }

        public void dealViewAll() //상세 정보 출력
        {
            if (listun.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
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
        public void dealView() // 요약 정보 출력
        {
            if (listun.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
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
    
    }
}

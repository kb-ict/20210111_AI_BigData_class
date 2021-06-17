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
    class CarControll : BaseControll // 상속 extends
    {
        List<Car> listCar; //using ClassTest2.Model;

        internal List<Car> ListCar { get => listCar; set => listCar = value; }

        public CarControll(RandData rand)//싱글톤: 하나의 객체를 생성하여 사용
        {
            listItem = new List<object>();
            listCar = listItem.Cast<Car>().ToList();
            this.rand = rand;
        }
        // 상속받고 메소드 오버라이딩
        public override void insRandData(int count) //java @Override 어노테이션
        {
            for (int i = 0; i < count; i++)
            {
                listCar.Add(new Car(rand.getModel(), rand.getColor(), rand.getCompany(), rand.getPrice()));
            }
        }
        public override void itemView()
        {
            if (listCar.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < listCar.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listCar[i].ToString());
            }
        }

        public override void removeAll()
        {
            if (listCar.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            listCar.Clear();//리스트를 비운다
        }

        public override void addItem(Object item)
        {
            listCar.Add(item as Car);// 형변환
        }

        public override void delItem(string item)
        {
            for (int i = 0; i < listCar.Count; i++)
            {
                if (listCar[i].Model.Equals(item))
                {
                    listCar.RemoveAt(i);//List의 RemoveAt(index); 해당 인덱스의 객체 삭제, 삭제된 후 재배열 
                    i--;// 삭제되면서 배열이 앞으로 당겨진다 그러므로 다시 이전의 인덱스를 검사하도록 인덱스의 값을 -1한다 
                }
            }
        }

        public override void updateItem(string[] item)
        {
            for (int i = 0; i < listCar.Count; i++)
            {
                if (listCar[i].Model.Equals(item[CommMenu.OLD_MODEL]))//기존모델명과 같으면
                {
                    listCar[i].Model = item[CommMenu.NEW_MODEL];//
                }
            }
        }
    }
}

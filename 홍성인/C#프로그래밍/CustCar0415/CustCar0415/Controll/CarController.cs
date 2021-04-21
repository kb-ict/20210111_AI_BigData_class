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
    //  BaseController 상속 , ':' 은 상속의 의미
    class CarController : BaseController
    {
        List<Car> listCar;

        // List<Car> listCar; 선택 후 캡슐화 = getter setter 설정
        internal List<Car> ListCar { get => listCar; set => listCar = value; }          

        public CarController(RandData rand)
        {
            listItem = new List<object>();
            listCar = listItem.Cast<Car>().ToList();
            this.rand = rand;
        }


        public override void insRandData(int count)
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
            listCar.Clear();
        }

        public override void addItem(object item)
        {
            listCar.Add(item as Car);                                       // <----- object 타입을 Car 타입으로 변환
        }

        public override void delItem(string item)
        {
            for (int i = 0; i < listCar.Count; i++)
            {
                if (listCar[i].Model.Equals(item))
                {
                    listCar.RemoveAt(i--);                                  // <------ i를 i--로 수정 ( 삭제 부분 버그 )
                }
            }
        }

        public override void updateItem(string[] item)
        {
            for (int i = 0; i < listCar.Count; i++)
            {
                if (listCar[i].Model.Equals(item[CommMenu.OLD_MODEL]))      //  CommMenu 로 수정한 이유
                {
                    listCar[i].Model = item[CommMenu.NEW_MODEL];
                }
            }
        }
    }
}

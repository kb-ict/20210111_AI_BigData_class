using ClassTest2.Model;
using ClassTest2.Util;
using Demo.Model;
using Demo.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Controll
{
    class CarControll
    {
        //클래스 변수
        const int OLD_MODEL=0;
        const int NEW_MODEL=1;
        List<Car> list = new List<Car>();//using ClassTest2.Model;
        RandData rand;
        public CarControll(RandData rand)//싱글톤: 하나의 객체를 생성하여 사용
        {
            this.rand = rand;
        }

        public void insrtRandData(int count)
        {
            for(int i=0; i<count;i++)
            {
                list.Add(new Car(rand.getModel(),rand.getColor(),rand.getCompany(),rand.getPrice()));
            }
        }
        public void carView()
        {
            if(list.Count==0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for(int i =0; i<list.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(list[i].ToString());
            }
        }
        public void carView2()
        {
            if(list.Count==0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                list[i].printInfoCar();
            }
        }
        public void removeAll()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            list.Clear();//리스트를 비운다
        }
        public void addCarItem(Car car)//입력받아서 추가, menu.addcarMenu()에서 반환된 값추가
            //addCarItem(menu.addCarMenu())
        {
            list.Add(car);
        }

        public void delCarItem(string model)//차량 모델명을 매개변수로 받아 삭제
        {
            for(int i=0; i<list.Count; i++)
            {
                if (list[i].Model.Equals(model))
                {
                    list.RemoveAt(i);//List의 RemoveAt(index); 해당 인덱스의 객체 삭제, 삭제된 후 재배열 
                    i--;// 삭제되면서 배열이 앞으로 당겨진다 그러므로 다시 이전의 인덱스를 검사하도록 인덱스의 값을 -1한다 
                }
            }
               
        }
       
        public void updateCarItem(string[] model)//기존모델명, 수정 모델명
        {
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].Model.Equals(model[OLD_MODEL]))//기존모델명과 같으면
                {
                    list[i].Model=model[NEW_MODEL];//
                }
            }
        }
       

    }
}

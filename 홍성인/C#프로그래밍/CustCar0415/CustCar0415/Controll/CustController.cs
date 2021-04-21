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
    class CustController : BaseController           // 반드시 오버라이딩을 해야 하는 추상 메소드가 들어가 있기 때문에
    {
        List<Customer> listCust;                    // <--- 이 부분 드래그 후 필드 캡슐화 ( getter setter )

        internal List<Customer> ListCust { get => listCust; set => listCust = value; }

        public CustController(RandData rand)
        {
            this.rand = rand;                       // this = CustController를 가리킨다
            listItem = new List<object>();
            listCust = listItem.Cast<Customer>().ToList();
        }

        public override void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                listCust.Add(new Customer(rand.getName(), rand.getAge(), rand.getTel(), rand.getAddress(), rand.getGender()));
            }
        }

        public override void itemView()
        {
            if (listCust.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < listCust.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listCust[i].ToString());
            }
        }

        public override void removeAll()
        {
            if (listCust.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            listCust.Clear();
        }

        public override void addItem(object item)
        {
            listCust.Add(item as Customer);                             // type casting (강제형변환) 해주기
        }

        public override void delItem(string item)
        {
            for (int i = 0; i < listCust.Count; i++)
            {
                if (listCust[i].Name.Equals(item))
                {
                    listCust.RemoveAt(i--);                           // <------ i를 i--로 수정 ( 삭제 부분 버그 )
                }
            }
        }

        public override void updateItem(string[] item)
        {
            for (int i = 0; i < listCust.Count; i++)
            {
                if (listCust[i].Name.Equals(item[CommMenu.OLD_MODEL]))
                {
                    listCust[i].Name = item[CommMenu.NEW_MODEL];
                }
            }
        }
    }
}

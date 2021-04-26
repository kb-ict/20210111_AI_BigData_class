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
    class SellController : BaseController                   // ★★★ 상속 후 반드시 추상 클래스 구현(오버라이딩) 한다
    {
        List<Seller> listSell;

        internal List<Seller> ListSell { get => listSell; set => listSell = value; }

        public SellController(RandData rand)
        {
            listItem = new List<object>();                  // ★★★ 부로로부터 상속 받은 객체 생성
            listSell = listItem.Cast<Seller>().ToList();
            this.rand = rand;
        }

        public override void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                listSell.Add(new Seller(rand.getName(), rand.getTel(), rand.getStatus(), rand.getOffice()));
            }
        }

        public override void itemView()
        {
            if (listSell.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < listSell.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                Console.WriteLine(listSell[i].ToString());
            }
        }

        public override void removeAll()
        {
            throw new NotImplementedException();
        }

        public override void addItem(object item)
        {
            listSell.Add(item as Seller);                                   // type casting ( 강제형변환 ) 하기
        }

        public override void delItem(string item)
        {
            for (int i = 0; i < listSell.Count; i++)
            {
                if (listSell[i].Name.Equals(item))
                {
                    listSell.RemoveAt(i--);                                 // <------ i를 i--로 수정 ( 삭제 부분 버그 )
                }
            }
        }

        public override void updateItem(string[] item)
        {
            for (int i = 0; i < listSell.Count; i++)
            {
                if (listSell[i].Name.Equals(item[CommMenu.OLD_MODEL]))      // item , CommMenu 수정
                {
                    listSell[i].Name = item[CommMenu.NEW_MODEL];
                }
            }
        }
    }
}

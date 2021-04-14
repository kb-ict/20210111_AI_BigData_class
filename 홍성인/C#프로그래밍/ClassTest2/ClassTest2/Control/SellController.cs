using ClassTest2.Model;
using ClassTest2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Control
{
    class SellController
    {
        const int OLD_MODEL = 0;
        const int NEW_MODEL = 1;
        List<Seller> listSell = new List<Seller>();
        RandData rand;

        public SellController(RandData rand)
        {
            this.rand = rand;
        }

        public void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                listSell.Add(new Seller(rand.getName(), rand.getTel(), rand.getStatus(), rand.getOffice()));
            }
        }

        public void sellView()
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

        public void sellView2()
        {
            for (int i = 0; i < listSell.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                listSell[i].SellerInfo();
            }
        }

        public void removeAll()
        {
            if (listSell.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            listSell.Clear();
        }

        public void addSellItem(Seller sell)
        {
            listSell.Add(sell);
        }

        public void delSellItem(string name)
        {
            for (int i = 0; i < listSell.Count; i++)
            {
                if (listSell[i].Name.Equals(name))
                {
                    listSell.RemoveAt(i--);                           // <------ i를 i--로 수정 ( 삭제 부분 버그 )
                }
            }
        }


        public void updateSellItem(string[] name)
        {
            for (int i = 0; i < listSell.Count; i++)
            {
                if (listSell[i].Name.Equals(name[OLD_MODEL]))
                {
                    listSell[i].Name = name[NEW_MODEL];
                }
            }
        }

    }
}

using ClassTest2.Model;
using ClassTest2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Controll
{
    class SellControll
    {
        const int OLD_MODEL=0;
        const int NEW_MODEL=1;
        List<Seller> list = new List<Seller>();
        RandData rand = new RandData();
        public SellControll(RandData rand)
        {
            this.rand = rand;
        }

        public void insertRandSeller(int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(new Seller(rand.getName(), rand.getTel(),rand.getLevel(),rand.getOffice()));
            }
        }
        public void selView()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i=0; i<list.Count;i++)
            {
                Console.WriteLine("직원 번호: " + (i + 1));
                Console.WriteLine(list[i].ToString());
            }
        }
        public void selView2()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i=0; i<list.Count;i++)
            {
                Console.WriteLine("직원 번호: " + (i + 1));
                list[i].SellerInfo();
            }
        }
        public void removeAll() 
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            list.Clear();
        }
        public void addSellerItem(Seller sell)
        {
            list.Add(sell);
        }
        public void delsellItem(string name)
        {
            for(int i=0; i<list.Count;i++)
            {
                if(list[i].Name.Equals(name))
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }
        public void updataSellItem(string[] name)
        {
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].Name.Equals(name[OLD_MODEL]))
                {
                    list[i].Name=name[NEW_MODEL];
                }
            }
        }
    }
}

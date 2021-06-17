using ClassTest2.Model;
using ClassTest2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Controll
{
    class CustControll
    {
        const int OLD_MODEL=0;
        const int NEW_MODEL=1;
        List<Customer> list = new List<Customer>();
        RandData rand;
        
        public CustControll(RandData rand)
        {
            this.rand = rand;
        }
        public void insrtRandCust(int count)
        {
            for(int i=0; i<count;i++)
            {
                list.Add(new Customer(rand.getName(), rand.getAge(), rand.getTel(), rand.getaddress(), rand.getGender()));
            }
        }
        public void custView()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i=0; i<list.Count;i++)
            {
                Console.WriteLine("고객번호: " + (i + 1));
                Console.WriteLine(list[i].ToString());
            }
        }
        public void custView2()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i=0; i<list.Count;i++)
            {
                Console.WriteLine("고객번호: " + (i + 1));
                list[i].CustomerInfo();
            }
        }
        public void removeAll()
        {
            if(list.Count==0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            list.Clear();
        }
        public void addCustItem(Customer cust)
        {
            list.Add(cust);
        }
        public void delCustItem(string name)
        {
            for(int i=0; i<list.Count; i++)
            {
                if(list[i].Name.Equals(name))
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
        }
        public void updataCustItem(string[] name)
        {
            for(int i=0; i<list.Count;i++)
            {
                if(list[i].Name.Equals(name[OLD_MODEL]))
                {
                    list[i].Name=name[NEW_MODEL];
                }
            }
        }
     }
}

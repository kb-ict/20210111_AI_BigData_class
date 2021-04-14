using ClassTest2.Model;
using ClassTest2.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Control
{
    class CustController
    {
        const int OLD_MODEL = 0;
        const int NEW_MODEL = 1;
        List<Customer> listCust = new List<Customer>();
        RandData rand;

        public CustController(RandData rand)
        {
            this.rand = rand;
        }

        public void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                listCust.Add(new Customer(rand.getName(), rand.getAge(), rand.getTel(), rand.getAddress(), rand.getGender()));
            }
        }

        public void custView()
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

        public void custView2()
        {
            for (int i = 0; i < listCust.Count; i++)
            {
                Console.WriteLine("번호: " + (i + 1));
                listCust[i].CustomerInfo();
            }
        }

        public void removeAll()
        {
            if (listCust.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            listCust.Clear();
        }

        public void addCustItem(Customer cust)
        {
            listCust.Add(cust);
        }

        public void delCustItem(string name)
        {
            for (int i = 0; i < listCust.Count; i++)
            {
                if (listCust[i].Name.Equals(name))
                {
                    listCust.RemoveAt(i--);                           // <------ i를 i--로 수정 ( 삭제 부분 버그 )
                }
            }
        }


        public void updateCustItem(string[] name)
        {
            for (int i = 0; i < listCust.Count; i++)
            {
                if (listCust[i].Name.Equals(name[OLD_MODEL]))
                {
                    listCust[i].Name = name[NEW_MODEL];
                }
            }
        }
    }

    
}

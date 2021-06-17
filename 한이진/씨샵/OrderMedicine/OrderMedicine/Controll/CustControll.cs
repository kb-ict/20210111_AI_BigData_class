using OrderMedicine.Common;
using OrderMedicine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMedicine.Controll
{
    class CustControll : BaseControll
    {
        List<Customer> listcust;

        internal List<Customer> Listcust { get => listcust; set => listcust = value; }
        public CustControll()
        {
            listItme = new List<Object>();
            listcust = listItme.Cast<Customer>().ToList();
        }
        public override void addItem(Object item)
        {

            listcust.Add(item as Customer);
            Console.WriteLine("고객 정보 추가 완료!");
        }

        public override void viewItem()
        {
            if (listcust.Count == 0)
            {
                Console.WriteLine("고객 데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < listcust.Count; i++)
            {
                Console.WriteLine((i + 1) + "번 고객");
                Console.WriteLine(listcust[i].ToString());
            }
        }

        public override void dealItem(string item)
        {
            for (int i = 0; i < listcust.Count; i++)
            {
                if (listcust[i].CustId.Equals(item))
                {
                    listcust.RemoveAt(i);
                    i--;
                }
            }
        }

        public override void updataItem(string[] item)
        {
            for (int i = 0; i < listcust.Count; i++)
            {
                if (listcust[i].CustId.Equals(item[0]))
                {
                    listcust[i].CustId = item[1];
                }
            }
        }

        public override void delAll()
        {
            if (listcust.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            listcust.Clear();
            Console.WriteLine("모든 고객 정보를 삭제했습니다.");
        }
    }
}

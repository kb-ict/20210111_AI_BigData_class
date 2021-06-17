using OrderMedicine.Common;
using OrderMedicine.Model;
using OrderMedicine.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMedicine.Controll
{
    class OrderControll : BaseControll
    {
        CustControll custcon;
        MediControll medicon;
        StoreControll storecon;
        List<Buying<Customer, Medicine, Store>> orderlist;
        
        public OrderControll()
        {
            listItme = new List<object>();
            orderlist = listItme.Cast<Buying<Customer, Medicine, Store>>().ToList();
            custcon = new CustControll();
            medicon = new MediControll();
            storecon = new StoreControll();
        }
        public OrderControll(CustControll custcon, MediControll medicon, StoreControll storecon)
        {
            this.custcon = custcon;
            this.medicon = medicon;
            this.storecon = storecon;
        }

        internal CustControll Custcon { get => custcon; set => custcon = value; }
        internal MediControll Medicon { get => medicon; set => medicon = value; }
        internal StoreControll Storecon { get => storecon; set => storecon = value; }
        internal List<Buying<Customer, Medicine, Store>> Orderlist { get => orderlist; set => orderlist = value; }
        public void orderView()
        {
            if(orderlist.Count==0)
            {
                Console.WriteLine("거래 내역 데이터가 존재하지 않습니다.");
            }
            for(int i=0;i<orderlist.Count;i++)
            {
                Console.WriteLine((i + 1) + "번째");
                Console.WriteLine(orderlist[i].ToString());
                Console.WriteLine("----------------------------------------------------");
            }
        }
        public override void addItem(object item)
        {
            orderlist.Add(item as Buying<Customer,Medicine,Store>);
            Console.WriteLine("거래 내역 데이터가 추가되었습니다.");
        }

        public override void viewItem()
        {
            if (orderlist.Count == 0)
            {
                Console.WriteLine("거래 내역 데이터가 존재하지 않습니다.");
            }
            for (int i = 0; i < orderlist.Count; i++)
            {
                Console.WriteLine((i + 1) + "번째");
                orderlist[i].buyingInfo();
                Console.WriteLine("----------------------------------------------------");
            }
        }

        public override void dealItem(string item)
        {
            throw new NotImplementedException();
        }

        public override void updataItem(string[] item)
        {
            throw new NotImplementedException();
        }

        public override void delAll()
        {
            if (orderlist.Count == 0)
            {
                Console.WriteLine("거래 데이터가 존재하지 않습니다.");
                return;
            }
            orderlist.Clear();
            Console.WriteLine("모든 거래 내역이 삭제되었습니다.");
        }
    }
}

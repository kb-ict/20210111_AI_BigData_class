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
    class SellControll : BaseControll
    {
        List<Seller> listSell;

        internal List<Seller> ListSell { get => listSell; set => listSell = value; }

        public SellControll(RandData rand)
        {
            listItem = new List<object>();
            listSell = listItem.Cast<Seller>().ToList();
            this.rand = rand;
        }
        public override void insRandData(int count)
        {

            for (int i = 0; i < count; i++)
            {
                listSell.Add(new Seller(rand.getName(), rand.getTel(), rand.getLevel(), rand.getOffice()));
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
                Console.WriteLine("직원 번호: " + (i + 1));
                Console.WriteLine(listSell[i].ToString());
            }
        }

        public override void removeAll()
        {
            if (listSell.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            listSell.Clear();
        }

        public override void addItem(object item)
        {
            listSell.Add(item as Seller);
        }

        public override void delItem(string item)
        {
            for (int i = 0; i < listSell.Count; i++)
            {
                if (listSell[i].Name.Equals(item))
                {
                    listSell.RemoveAt(i);
                    i--;
                }
            }
        }

        public override void updateItem(string[] item)
        {
            for (int i = 0; i < listSell.Count; i++)
            {
                if (listSell[i].Name.Equals(item[CommMenu.OLD_MODEL]))
                {
                    listSell[i].Name = item[CommMenu.NEW_MODEL];
                }
            }
        }
    }
}

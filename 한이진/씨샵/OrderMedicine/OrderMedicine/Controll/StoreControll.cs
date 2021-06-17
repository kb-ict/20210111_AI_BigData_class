using OrderMedicine.Common;
using OrderMedicine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMedicine.Controll
{
    class StoreControll : BaseControll
    {
        List<Store> listSto;

        internal List<Store> ListSto { get => listSto; set => listSto = value; }
        public StoreControll()
        {
            listItme = new List<object>();
            listSto = listItme.Cast<Store>().ToList();
        }
        public override void addItem(object item)
        {
            listSto.Add(item as Store);
            Console.WriteLine("약국 데이터를 추가하였습니다.");
        }

        public override void viewItem()
        {

            if (listSto.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < listSto.Count; i++)
            {
                Console.WriteLine((i + 1) + "번");
                Console.WriteLine(listSto[i].ToString());
            }
        }

        public override void dealItem(string item)
        {
            for (int i = 0; i < listSto.Count; i++)
            {
                if (listSto[i].StoName.Equals(item))
                {
                    listSto.RemoveAt(i--);
                }
            }
        }

        public override void updataItem(string[] item)
        {
            for (int i = 0; i < listSto.Count; i++)
            {
                if (listSto[i].StoName.Equals(item[0]))
                {
                    listSto[i].StoName = item[1];
                    listSto[i].Manager = item[2];
                    listSto[i].Address = item[3];
                    listSto[i].Phone = item[4];
                }
            }
        }

        public override void delAll()
        {
            if (listSto.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            listSto.Clear();
            Console.WriteLine("모든 약국 정보를 삭제했습니다.");
        }
    }
}

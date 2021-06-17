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
    class MediControll : BaseControll
    {
        List<Medicine> listMedi;

        internal List<Medicine> ListMedi { get => listMedi; set => listMedi = value; }

        public MediControll()
        {
            listItme = new List<object>();
            listMedi = listItme.Cast<Medicine>().ToList(); 
        }
        
        public override void addItem(object item)
        {

            listMedi.Add(item as Medicine);
            Console.WriteLine("약품 정보 추가 완료!");
        }

        public override void viewItem()
        {
            if (listMedi.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for (int i = 0; i < listMedi.Count; i++)
            {
                Console.WriteLine(listMedi[i].ToString());
            }
        }

        public override void dealItem(string item)
        {
            for (int i = 0; i < listMedi.Count; i++)
            {
                if (listMedi[i].PId.Equals(item[0]))
                {
                    listMedi.RemoveAt(i--);
                }
            }
        }

        public override void updataItem(string[] item)
        {
            for (int i = 0; i < listMedi.Count; i++)
            {
                if (listMedi[i].PId.Equals(item[0]))
                {
                    listMedi[i].MediName = item[1];
                    listMedi[i].Effect = item[2];
                    listMedi[i].Takeing = item[3];
                    listMedi[i].Price = item[4];
                }
            }
        }

        public override void delAll()
        {
            if (listMedi.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
            }
            listMedi.Clear();
            Console.WriteLine("모든 약품 정보를 삭제하였습니다.");
        }
    }
}

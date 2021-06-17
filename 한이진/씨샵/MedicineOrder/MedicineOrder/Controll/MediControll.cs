using MedicineOrder.Common;
using MedicineOrder.Model;
using MedicineOrder.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineOrder.Controll
{
    class MediControll : BaseControll
    {
        List<Medicine> listMedi;
 
        internal List<Medicine> ListMedi { get => listMedi; set => listMedi = value; }

        public MediControll()
        {
            listItme = new List<object>();
            listMedi = listItme.Cast<Medicine>().ToList();
            listMedi.Add(new Medicine("199303108", "타이레놀정 500mg", "두통", "1회 1~2정씩 1일 3-4회 필요시 복용한다.", "3100원"));
            listMedi.Add(new Medicine("198601920", "어린이부루펜시럽", "두통", "성인 1회 200-400mg 1일 3-4회 경구투여한다. 어린이는 다음 1회 용량을 1일 3-4회 경구투여한다.", "7500원"));
            listMedi.Add(new Medicine("196800036", "판콜에이내복액", "감기", "성인 1회 30ml 1일 3회 식후 30분에 복용한다.", "2600원"));
            listMedi.Add(new Medicine("198700405", "베아제정", "소화불량", "성인 1회 1정 1일 3회 식후에 복용한다.", "1800원"));
            listMedi.Add(new Medicine("200501321", "신신파스아렉스", "근육통", "1일 1~2회 환부(질환 부위)에 부착한다.", "3500원"));
            listMedi.Add(new Medicine("200300546", "후시딘히드로연고", "피부질환", "1일 3회 적당량을 환부에 부드럽게 바른다.", "4500원"));
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

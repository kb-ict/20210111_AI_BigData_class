using OrderMedicine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMedicine.Util
{
    class MedicineData
    {
        
        //string[] pId = { "199303108", "198601920", "196800036", "198700405", "200501321", "200300546" };
        //string[] name = { "타이레놀정 500mg", "어린이부루펜시럽", "판콜에이내복액", "베아제정", "신신파스아렉스", "후시딘히드로연고" };
        List<Medicine> mediList;
        public MedicineData()
        {
            mediList.Add (new Medicine("199303108", "타이레놀정 500mg", "두통", "1회 1~2정씩 1일 3-4회 필요시 복용한다.", "3100원"));
            mediList.Add(new Medicine("198601920", "어린이부루펜시럽", "두통", "성인 1회 200-400mg 1일 3-4회 경구투여한다. 어린이는 다음 1회 용량을 1일 3-4회 경구투여한다.", "7500원"));
            mediList.Add(new Medicine("196800036", "판콜에이내복액", "감기", "성인 1회 30ml 1일 3회 식후 30분에 복용한다.", "2600원"));
            mediList.Add(new Medicine("198700405", "베아제정", "소화불량", "성인 1회 1정 1일 3회 식후에 복용한다.", "1800원"));
            mediList.Add(new Medicine("200501321", "신신파스아렉스", "근육통", "1일 1~2회 환부(질환 부위)에 부착한다.", "3500원"));
            mediList.Add(new Medicine("200300546", "후시딘히드로연고", "피부질환", "1일 3회 적당량을 환부에 부드럽게 바른다.", "4500원"));

        }

        internal List<Medicine> MediList { get => mediList; set => mediList = value; }

        public void veiwMediInfo()
        {
            if (mediList.Count == 0)
            {
                Console.WriteLine("데이터가 존재하지 않습니다.");
                return;
            }
            for(int i=0; i<mediList.Count;i++)
            {
                Console.WriteLine(mediList[i].ToString());
            }
        }
        


    }
}

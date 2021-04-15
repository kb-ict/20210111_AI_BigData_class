using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.Util
{
    class RandData
    {
        // 인스턴스 변수

        static string[] name = { "루니", "홍성인", "나성대", "꽁대", "나성인" };
        static int[] age = { 30, 40, 50, 60, 70 };
        static string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
        static char[] gender = { '여', '남' };
        static string[] addr = { "서울", "대전", "광주", "대구", "부산" };
        static string[] status = { "주임", "대리", "과장", "차장", "부장" };
        static string[] office = { "동구", "서구", "남구", "북구", "수성구" };
        static string[] model = { "그란카브리오", "가야르도", "기블리", "르반떼", "우라칸" };
        static string[] color = { "블랙", "화이트", "네이비", "레드", "노란색" };
        static string[] price = { "1억원", "1억2천만원", "1억5천만원", "2억원", "2억5천만원" };
        static string[] company = { "마세라티", "포르쉐", "페라리", "벤틀리", "포드" };

        

        Random r = new Random();

        public string getName()
        {
            return name[r.Next(5)];
        }

        public int getAge()
        {
            return age[r.Next(5)];
        }

        public string getTel()
        {
            return tel[r.Next(5)];
        }

        public char getGender()
        {
            return gender[r.Next(2)];
        }

        public string getAddress()
        {
            return addr[r.Next(5)];
        }

        public string getStatus()
        {
            return status[r.Next(5)];
        }

        public string getOffice()
        {
            return office[r.Next(5)];
        }

        public string getModel()
        {
            return model[r.Next(5)];
        }

        public string getColor()
        {
            return color[r.Next(5)];
        }

        public string getPrice()
        {
            return price[r.Next(5)];
        }

        public string getCompany()
        {
            return company[r.Next(5)];
        }

    }
}

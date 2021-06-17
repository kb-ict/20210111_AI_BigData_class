using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Util
{
    class RandData
    {
        Random r = new Random();
        static string[] name = { "Han", "Lee", "Park", "Yoon", "Kim" };
        static int[] age = { 20, 30, 40, 50, 60 };
        static char[] gender = { '여', '남' };
        static string[] tel = { "010-1112-2222", "010-2230-3443", "010-2943-2929", "010-8282-8282", "010-1234-5678" };
        static string[] addr = { "서울 동구", "울산 남구", "부산 해운대구", "대구 수성동", "수원" };
        static string[] level = { "주임", "대리", "과장", "차장", "부장" };
        static string[] office = { "동대구영업소", "북대구영업소", "서대구영업소", "남대구영업소", "효목동영업소" };
        static string[] model = { "k7", "k8", "그랜저", "제네시스", "SM6" };
        static string[] color = { "빨강", "검정", "딥블루", "카키", "실버", "흰색" };
        static string[] price = { "3천만원", "4천만원", "1억", "1억5천만원", "3억" };
        static string[] company = { "현대", "기아", "삼성", "쌍용" };

        public string getName()
        {
            return name[r.Next(5)];
        }

        public int getAge()
        {
            return age[r.Next(5)];
        }
        public char getGender()
        {
            return gender[r.Next(2)];
        }
        public string getTel()
        {
            return tel[r.Next(5)];
        }
        public string getaddress()
        {
            return addr[r.Next(5)];
        }
        public string getLevel()
        {
            return level[r.Next(5)];
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
            return company[r.Next(4)];
        }


    }
}

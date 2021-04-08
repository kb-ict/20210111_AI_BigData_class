using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest1
{
    class Program
    {
        static void Main(string[] args)
        {

            const int MAIN_MENU_INSERT = 1;
            const int MAIN_MENU_VIEW = 2;
            const int MAIN_MENU_EXIT = 3;

            /*
            Car car = new Car("그란카브리오","네이비","마세라티","2억5천만원");
            //car.setModel("그랜저"); 
            //Console.WriteLine("모델: " + car.getModel());
            car.Model = "그란카브리오";
            Console.WriteLine("모델: " + car.Model);
            car.printInfoCar();
            Console.WriteLine("영업소:" + Car.branch);
       

            Car car2 = new Car();
            car2.Model = "그란카브리오";
            car2.printInfoCar();
            Console.WriteLine("영업소:" + Car.branch);

            Console.WriteLine (new Car("가야르도", "노랑", "람보르기니", "6억5천만원").ToString());
            Console.WriteLine("영업소:" + Car.branch);
            */

            Random r = new Random();

            string[] name = { "홍길동", "김길동", "박길동", "최길동", "이길동" };
            int[] age = {30,40,50,60,100};
            char[] gender = { '남','여' };
            string[] tel = { "010-1111-1111", "010-2222-2222", "010-3333-3333", "010-4444-4444", "010-5555-5555" };
            string[] addr = { "서울", "대전", "대구", "부산", "제주도" };


            // 0 ~ 2 까지 랜덤
            //Console.WriteLine(r.Next(3));


            Student[] st = new Student[10];
            //List<Student> list = new List<Student>();

            //for(var i=0;i<st.Length;i++)
            //{
            //    st[i] = new Student(name[r.Next(5)], age[r.Next(5)], gender[r.Next(2)], tel[r.Next(5)], addr[r.Next(5)]);
            //    st[i].studentinfo();
            //}

            while (true)
            {
                switch (menuMain())
                {
                    case MAIN_MENU_INSERT:
                        createRandData(st, name, age, gender, tel, addr, r);
                        break;
                    case MAIN_MENU_VIEW:
                        dataView(st);
                        break;
                    case MAIN_MENU_EXIT:
                        Environment.Exit(0);
                        break;

                }

            }
            
        }


        

        public static int menuMain()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("학생 관리 프로그램 v1.0");
            Console.WriteLine("=======================");
            Console.WriteLine("1.학생정보 생성");
            Console.WriteLine("2.학생정보 출력");
            Console.WriteLine("3.종료");
            Console.WriteLine("=======================");
            Console.WriteLine("메뉴 선택: ");
            int menu =Convert.ToInt32(Console.ReadLine());
            return menu;
        }





        public static void createRandData(Student[] st,string[] name, int[] age, char[] gender, string[] tel, string[] addr, Random r)
        {
            for(int i =0;i<st.Length;i++)
            {
                st[i] = new Student(name[r.Next(5)], age[r.Next(5)], gender[r.Next(2)], tel[r.Next(5)], addr[r.Next(5)]);
            }
        }
        public static void dataView(Student[] s)
        {
            for (int i=0;i<s.Length;i++)
            {
                s[i].studentinfo();
            }
            
        }

    }
}

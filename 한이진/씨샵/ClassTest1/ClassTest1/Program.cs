using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest1
{
    class Program
    {
        const int MAIN_MENU_INSERT = 1;
        const int MAIN_MENU_VIEW = 2;
        const int MAIN_MENU_ADD = 3;
        const int MAIN_MENU_UPDATA = 4;
        const int MAIN_MENU_DELETE = 5;
        const int MAIN_MENU_EXIT = 6;

        static void Main (string[] args)
        {

            Random r = new Random();//랜덤 클래스 생성

            string[] name = { "hong", "kim", "park", "cho", "han" };
            int[] age = { 30, 40, 50, 60, 100 };
            char[] gender = { '남', '여' };
            string[] tel = { "010-222-3333", "010-223-39393", "393842899", "39393939", "49494939" };
            string[] addr = { "서울", "대구 동구", "대구 북구", "부산", "울산" };
            
            Student[] st = null;
            //List<Student> st = new List<Student>();
          
            while (true)
            {
                switch(menuMain())
                {
                    case MAIN_MENU_INSERT:
                        int size = getRandSize();
                     
                        st = new Student[size];
                        createRandData(st, name, age, gender, tel, addr, r);
                        break;
                    case MAIN_MENU_VIEW:
                        try
                        {
                            if (st != null)
                            {
                                dataView2(st);
                            }
                        }catch(Exception e)
                        {
                            Console.WriteLine("데이터 생성 실패");
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case MAIN_MENU_ADD
                        studentAdd(stu);
                        break;
                    case MAIN_MENU_UPDATA:
                        studentUpdata();
                        break;
                    case MAIN_MENU_DELETE:
                        stuDelete();
                        break;
                    case MAIN_MENU_EXIT:
                        Environment.Exit(0);
                        break;
                }
                

            }
        }
        public static int menuMain()
        {
            List<Student> stu = new List<Student>();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("학생 관리 프로그램 v1.0");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1. 학생정보 생성");
            Console.WriteLine("2. 학생정보 출력");
            Console.WriteLine("3. 힉생정보 추가");
            Console.WriteLine("4. 학생정보 수정");
            Console.WriteLine("5. 학생정보 삭제");
            Console.WriteLine("6. 종료");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("선택: ");
            int menu = Convert.ToInt32(Console.ReadLine());
            return menu;
        }
        //랜덤 데이터 크기 설정
        public static int getRandSize()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("램덤 데이터 생성 크기");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("크기 입력: ");
            return Convert.ToInt32(Console.ReadLine());
        }
        //학생 랜덤 데이터 생성
        public static void createRandData(Student[] st, string[] name, int[] age, char[]gender, string[] tel, string[] addr, Random r)
        {
            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student(name[r.Next(5)], age[r.Next(5)], gender[r.Next(2)], tel[r.Next(5)], addr[r.Next(5)]);
            }
            Console.WriteLine("데이터가 정상적으로 생성되었습니다");
        }
        //출력 메소드
        public static void dataView (Student[] s)
        {
            for(int i=0; i < s.Length; i++)
            {
                int count = 1;
                try {
                    Console.WriteLine("번호: "+count++);
                    s[i].studentInfo(); 
                }catch(NullReferenceException e)
                {
                    e.ToString();
                    Console.WriteLine("데이터 생성을 실패하였습니다.");
                    Console.WriteLine(e.Message);
                }
                
            }
        }
        public static void dataView2(Student[] s)
        {
            int count = 1;
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("번호: " + count++);
                s[i].studentInfo();    
            }
        }
        public static void studentAdd(List<Student> stu)
        {
            stu.Add(new Student(name, age, gender, tel, addr));
        }
        public static void studentUpdata()
        {

        }
        public static void stuDelete()
        {

        }
    }
}

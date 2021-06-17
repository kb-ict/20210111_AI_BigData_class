using ClassTest2.Common;
using ClassTest2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2.View
{
    class Menu
    {
        
        #region 1. 메인메뉴 상수 정의
        public const int MENU_MAIN_RAND = 1;
        public const int MENU_MAIN_DEL_ALL = 2;
        public const int MENU_MAIN_VIEW = 3;
        public const int MENU_MAIN_ADD = 4;
        public const int MENU_MAIN_DEL = 5;
        public const int MENU_MAIN_UPDATE = 6;
        public const int MENU_MAIN_EXIT = 7;

        public const int ADD_CAR=1;
        public const int ADD_CUST=2;
        public const int ADD_SELL=3;
        public const int ADD_EXIT=4;

        public const int DEL_CAR=1;
        public const int DEL_CUST=2;
        public const int DEL_SELL=3;
        public const int DEL_EXIT=4;

        public const int UPD_CAR=1;
        public const int UPD_CUST=2;
        public const int UPD_SELL=3;
        public const int UPD_EXIT=4;


        #endregion
        public int mainManu()
        {
            int menu=0;
            try { 
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine(">>>>>>>> 고객차량관리 앱 <<<<<<<<<");

                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("1. 랜덤 데이터 생성");
                    Console.WriteLine("2. 모든 데이터 삭제");
                    Console.WriteLine("3. 데이터 보기");
                    Console.WriteLine("4. 데이터 추가");
                    Console.WriteLine("5. 데이터 삭제");
                    Console.WriteLine("6. 데이터 수정");
                    Console.WriteLine("7. 앱 종료");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine();
                    Console.Write("Main 메뉴 선택 >>>");
                    menu= Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException e)
            {
                CommMenu.errMsg("mainManu()",e.Message);
                //Console.WriteLine("숫자를 입력해주세요.");
                //Console.WriteLine(e.Message);
            }
            return menu;
        }

        public int getRandSize()
        {
            int size = 0;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 램덤 데이터 갯수 설정 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");

                Console.Write("갯수 입력 >>>");
                size= Convert.ToInt32(Console.ReadLine());
            }catch(FormatException e)
                {
                    CommMenu.errMsg("getRandSize()",e.Message);
                }
            return size;
            }
            
        public string[] addCarMenu()
        {
            string[] data = new string[4];

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(">>>>>>>> 차량 데이터 추가 <<<<<<<<<");
            Console.WriteLine("--------------------------------------------");
            Console.Write("모델명: ");
            data[0] = Console.ReadLine();
            Console.Write("색상: ");
            data[1] = Console.ReadLine();
            Console.Write("제조사: ");
            data[2] = Console.ReadLine();
            Console.Write("가격: ");
            data[3]= Console.ReadLine();

            return data;
        }
        public Car addCarMenu2()
        {
            Car car=null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 차량 데이터 추가 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("모델명: ");
                string model = Console.ReadLine();
                Console.Write("색상: ");
                string color = Console.ReadLine();
                Console.Write("제조사: ");
                string company = Console.ReadLine();
                Console.Write("가격: ");
                string price= Console.ReadLine();
                car= new Car(model, color, company, price);
            }catch(FormatException e)
            {
                CommMenu.errMsg("addCarMenu2()", e.Message);
            }
            return car;
        }
        public Customer addCustMenu()
        {
            Customer data = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 고객 데이터 추가 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("이름: ");
                string name = Console.ReadLine();
                Console.Write("나이: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("전화: ");
                string tel = Console.ReadLine();
                Console.Write("주소: ");
                string address = Console.ReadLine();
                Console.Write("성별: ");
                char gender = Convert.ToChar(Console.ReadLine());
                data= new Customer(name, age, tel, address, gender);
            }
            catch(FormatException e)
            {
                CommMenu.errMsg("addCustMenu()", e.Message);
            }
            return data;
        }
        public Seller addSellerMenu()
        {
            Seller data = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 직원 데이터 추가 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("이름: ");
                string name = Console.ReadLine();
                Console.Write("전화: ");
                string tel = Console.ReadLine();
                Console.Write("직위: ");
                string level = Console.ReadLine();
                Console.Write("영업소: ");
                string office = Console.ReadLine();
                data= new Seller(name, tel, level, office);
            }catch(FormatException e)
            {
                CommMenu.errMsg("addSellerMenu()", e.Message);
            }
            return data;          
        }
         public string delCarMenu()//삭제할 차량모델 입력받기
        {
            string model = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 차량 데이터 삭제 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("삭제할 차량 모델명 입력: ");
                model = Console.ReadLine();
            }catch(FormatException e)
            {
                CommMenu.errMsg("delCarMenu()", e.Message);
            }
            return model;
        }
         public string[] updateCarMenu()//모델명 수정할 차량 입력받기
        {
            string[] model= new string[2];
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 차량 데이터 수정 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("검색할 차량 모델명 입력: ");
                model[0] = Console.ReadLine();
                Console.Write("변경할 차량 모델명 입력: ");
                model[1] = Console.ReadLine();
            }catch(FormatException e)
            {
                CommMenu.errMsg("updateCarMenu()", e.Message);
            }
            return model;
        }
          public string delCustMenu()//삭제할 차량모델 입력받기
        {
            string name = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 고객 데이터 삭제 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("삭제할 고객명 입력: ");
                name= Console.ReadLine();
            }catch(FormatException e)
            {
                CommMenu.errMsg("delCustMenu()", e.Message);
            }
            return name;
        }
         public string[] updateCustMenu()
        {
            string[] name= new string[2];
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 고객 데이터 수정 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("검색할 고객명 입력: ");
                name[0] = Console.ReadLine();
                Console.Write("변경할 고객명 입력: ");
                name[1] = Console.ReadLine();
            }catch(FormatException e)
            {
                CommMenu.errMsg("updateCustMenu()", e.Message);
            }
            return name;
        }

        public string delSellMenu()
        {
            string name = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 직원 데이터 삭제 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("삭제할 직원명 입력: ");
                name= Console.ReadLine();
            }catch(FormatException e)
            {
                CommMenu.errMsg("delSellMenu()", e.Message);
            }
            return name;
        }
        public string[] updateSellMenu()
        {
            string[] name= new string[2];
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 직원 데이터 수정 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("검색할 직원명 입력: ");
                name[0] = Console.ReadLine();
                Console.Write("변경할 직원명 입력: ");
                name[1] = Console.ReadLine();
            }catch(FormatException e)
            {
                CommMenu.errMsg(" updateSellMenu()", e.Message);
            }
            return name;
        }

        public int sudAddMenu()
        {
            int selete = 0;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 데이터 추가 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1. 차량 정보 추가");
                Console.WriteLine("2. 고객 정보 추가");
                Console.WriteLine("3. 직원 정보 추가");
                Console.WriteLine("4. 종료 ");
                selete= Convert.ToInt32(Console.ReadLine());
            }catch(FormatException e)
            {
                CommMenu.errMsg("sudAddMenu()", e.Message);
            }
            return selete;     
        }

        public int subDelMenu()
        {
            int selete = 0;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 데이터 삭제 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1. 차량 정보 삭제");
                Console.WriteLine("2. 고객 정보 삭제");
                Console.WriteLine("3. 직원 정보 삭제");
                Console.WriteLine("4. 종료 ");
                selete= Convert.ToInt32(Console.ReadLine());
            }catch(FormatException e)
            {
                CommMenu.errMsg("subDelMenu()", e.Message);
            }
            return selete;
        }

        public int subUpdateMenu()
        {
            int selete = 0;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 데이터 수정 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1. 차량 정보 수정");
                Console.WriteLine("2. 고객 정보 수정");
                Console.WriteLine("3. 직원 정보 수정");
                Console.WriteLine("4. 종료 ");
                selete= Convert.ToInt32(Console.ReadLine());
            }catch(FormatException e)
            {
                CommMenu.errMsg("subUpdateMenu()", e.Message);
            }
            return selete;
        }

    }
}

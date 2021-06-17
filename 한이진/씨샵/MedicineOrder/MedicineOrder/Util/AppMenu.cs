using MedicineOrder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineOrder.Util
{
    class AppMenu
    {
        public const int MAIN_ADD_DATA = 1;
        public const int MAIN_VEIW_DATA = 2;
        public const int MAIN_DEL_DATA = 3;
        public const int MAIN_UPDATE_DATA = 4;
        public const int MAIN_DEL_ALL = 5;
        public const int MAIN_EXIT = 6;

        public const int ADD_CUST = 1;
        public const int ADD_MEDI = 2;
        public const int ADD_STO = 3;
        public const int ADD_EXIT = 4;

        public const int DEL_CUST = 1;
        public const int DEL_MEDI = 2;
        public const int DEL_STO = 3;
        public const int DEL_EXIT = 4;

        public const int UPDATE_CUST = 1;
        public const int UPDATE_MEDI = 2;
        public const int UPDATE_STO = 3;
        public const int UPDATE_EXIT = 4;

        public int mainMenu()//약국 관리용
        {
            int menu = 0;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 상비 약품 주문 앱 V1.0 <<<<<<<<<");

                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1. 데이터 추가");
                Console.WriteLine("2. 데이터 보기");
                Console.WriteLine("3. 데이터 삭제");
                Console.WriteLine("4. 데이터 수정");
                Console.WriteLine("5. 모든 데이터 삭제");
                Console.WriteLine("6.  앱 종료");              
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
                Console.Write("Main 메뉴 선택 >>>");
                menu = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException e)
            {
                Console.WriteLine("숫자 입력하세요", e.Message);
            }
            return menu;

        }
        public Customer addCustMenu()
        {
            Customer cust = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 고객 데이터 추가 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("고객 ID: ");
                string id = Console.ReadLine();
                Console.Write("고객 이름: ");
                string name = Console.ReadLine();
                Console.Write("생년(YYYY): ");
                string age = Console.ReadLine();
                Console.Write("성별(w/m): ");
                char gender = Convert.ToChar(Console.ReadLine());
                Console.Write("증상: ");
                string symptom = Console.ReadLine();
                Console.Write("주소: ");
                string addr = Console.ReadLine();
                Console.Write("전화번호: ");
                string phone = Console.ReadLine();
                new Customer(id, name, age, gender, symptom, addr, phone);
            }
            catch(FormatException e)
            {
                Console.WriteLine("성별 입력은 'w' 또는 'm'으로 입력해주세요.", e.Message);
            }
            return cust;
        }
        public Medicine addMediMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(">>>>>>>> 약품 데이터 추가 <<<<<<<<<");
            Console.WriteLine("--------------------------------------------");
            Console.Write("제품 코드: ");
            string pid = Console.ReadLine();
            Console.Write("약품명: ");
            string name = Console.ReadLine();
            Console.Write("효과(증상): ");
            string effect = Console.ReadLine();
            Console.Write("복용법: ");
            string taking = Console.ReadLine();
            Console.Write("가격: ");
            string price = Console.ReadLine();

            return new Medicine(pid, name, effect, taking, price);
        }
        public Store addStoreMenu()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(">>>>>>>> 약국 데이터 추가 <<<<<<<<<");
            Console.WriteLine("--------------------------------------------");
            Console.Write("상호명: ");
            string name = Console.ReadLine();
            Console.Write("매니저: ");
            string mana = Console.ReadLine();
            Console.Write("전화번호: ");
            string phone = Console.ReadLine();
            Console.Write("주소: ");
            string adr = Console.ReadLine();

            return new Store(name, mana, phone, adr);

        }
        public string delCustMenu()
        {
            string id = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 고객 데이터 삭제 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("삭제할 고객 ID 입력: ");
                id = Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine("id를 입력하세요.", e.Message);
            }
            return id; 
        }

        public string delMediMenu()
        {
            string pid = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 약품 데이터 삭제 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("삭제할 약품 제품 코드 입력: ");
                pid = Console.ReadLine();

            }
            catch(FormatException e)
            {
                Console.WriteLine("제품 코드를 입력하세요.", e.Message);
            }
            return pid;
        }
        public string delStoreMenu()
        {
            string store = null;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 약국 데이터 삭제 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.Write("삭제할 약국 상호명: ");
                store = Console.ReadLine();
            }
            catch(FormatException e)
            {
                Console.WriteLine("약국 상호명을 입력하세요.", e.Message);
            }
            return store;
        }
        public string[] updateCsutMenu()
        {
            string[] id = new string[2];
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(">>>>>>>> 고객 데이터 수정 <<<<<<<<<");
            Console.WriteLine("--------------------------------------------");
            Console.Write("검색할 고객 ID 입력: ");
            id[0] = Console.ReadLine();
            Console.Write("변경할 고객  증상 입력: ");
            id[1] = Console.ReadLine();
            
            return id;
        }
        public string[] updateMediMenu()
        {
            string[] pid = new string[5];
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(">>>>>>>>>> 약품 데이터 수정 <<<<<<<<<");
            Console.WriteLine("--------------------------------------------");
            Console.Write("검색할 제품 코드 입력: ");
            pid[0] = Console.ReadLine();
            Console.Write("변경된 약품명 입력: ");
            pid[1] = Console.ReadLine();
            Console.Write("변경된  효과(증상) 입력: ");
            pid[2] = Console.ReadLine();
            Console.Write("변경된 복용법 입력: ");
            pid[3] = Console.ReadLine();
            Console.Write("변경된 가격 입력: ");
            pid[4] = Console.ReadLine();
            return pid;
        }
        public string[] updateStoMenu()
        {
            string[] sto = new string[5];
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(">>>>>>>>>> 약국 데이터 수정 <<<<<<<<<");
            Console.WriteLine("--------------------------------------------");
            Console.Write("검색할 약국 상호명 입력: ");
            sto[0] = Console.ReadLine();
            Console.Write("변경된 약국 상호명 입력: ");
            sto[1] = Console.ReadLine();
            Console.Write("변경된  매니저 입력: ");
            sto[2] = Console.ReadLine();
            Console.Write("변경된 약국 주소 입력: ");
            sto[3] = Console.ReadLine();
            Console.Write("변경된 전화번호 입력: ");
            sto[4] = Console.ReadLine();
            return sto;
        }
        public int subMenu()
        {
            int sub = 0;
            try
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine(">>>>>>>> 하위 메뉴를 선택하세요 <<<<<<<<<");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1. 고객 정보");
                Console.WriteLine("2. 약품 정보");
                Console.WriteLine("3. 약국 정보");
                Console.WriteLine("4. 종료 ");
                sub = Convert.ToInt32(Console.ReadLine());
            }catch(FormatException e)
            {
                Console.WriteLine("숫자로 입력해주세요", e.Message);
            }
            return sub;
        }
    }

}

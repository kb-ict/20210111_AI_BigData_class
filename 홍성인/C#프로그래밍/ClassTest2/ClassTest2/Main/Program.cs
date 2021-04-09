using ClassTest2.Control;
using ClassTest2.Model;
using ClassTest2.Util;
using ClassTest2.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            RandData rand = new RandData();

            // mainMenu 메소드를 호출하기 위해서 menu 객체 생성이 필요
            // Menu 클래스 안에 있는 모든 메소드 사용 가능

            // CarController carcon = new CarController(RandData rand);     <----------------------------------- 질문하기

            Menu menu = new Menu();
            CarController carCon = new CarController(rand);

            while(true)
            {
                switch(menu.mainMenu())
                {
                    case Menu.MENU_MAIN_RAND:
                        carCon.insRandData(menu.getRandSize());
                        break;
                    case Menu.MENU_MAIN_DEL_ALL:
                        carCon.removeAll();
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        carCon.carView();
                        break;
                    case Menu.MENU_MAIN_ADD:
                        carCon.addCarItem(menu.addCarMenu2());
                        break;
                    case Menu.MENU_MAIN_DEL:
                        break;
                    case Menu.MENU_MAIN_UPDATE:
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

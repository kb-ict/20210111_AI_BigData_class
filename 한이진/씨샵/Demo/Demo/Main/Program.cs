using Demo.Controll;
using Demo.Util;
using Demo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
           
            UnionControll uHandle = new UnionControll(new RandData());
            while(true)
            {
                switch(menu.mainMenu())
                {
                    case Menu.MENU_MAIN_RAND:
                        uHandle.insrtRandData(menu.getRandSize());
                        break;
                    case Menu.MENU_MAIN_DEL_ALL:
                        uHandle.CarHandle.removeAll();
                        uHandle.CustHandle.removeAll();
                        uHandle.SellHandle.removeAll();
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        uHandle.dealView();
                        break;
                    case Menu.MENU_MAIN_ADD:
                        swith{

                        }
                        break;
                    case Menu.MENU_MAIN_DEL:
                        break;
                    case Menu.MENU_MAIN_UPDATE:
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Console.WriteLine("앱을 종료합니다.");
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}

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
            //RandData rand = new RandData();

            // mainMenu 메소드를 호출하기 위해서 menu 객체 생성이 필요
            // Menu 클래스 안에 있는 모든 메소드 사용 가능

            // CarController carcon = new CarController(RandData rand);     <----------------------------------- 질문하기

            Menu menu = new Menu();
            //CarController carCon = new CarController(rand);
            //CustController custCon = new CustController(rand);
            //SellController sellCon = new SellController(rand);

            UnionController uHandler = new UnionController(new RandData());


            while(true)
            {
                switch(menu.mainMenu())
                {
                    case Menu.MENU_MAIN_RAND:
                        uHandler.CarHandle.insRandData(menu.getRandSize());
                        uHandler.CustHandle.insRandData(menu.getRandSize());
                        uHandler.SellHandle.insRandData(menu.getRandSize());
                        break;
                    case Menu.MENU_MAIN_DEL_ALL:
                        uHandler.CarHandle.removeAll();
                        uHandler.CustHandle.removeAll();
                        uHandler.SellHandle.removeAll();
                        break;
                    case Menu.MENU_MAIN_VIEW:
                        uHandler.CarHandle.carView();
                        uHandler.CustHandle.custView();
                        uHandler.SellHandle.sellView();
                        break;
                    case Menu.MENU_MAIN_ADD:
                        switch (menu.subAddMenu())
                        {
                            case Menu.MENU_SUB_ADD_CAR:
                                uHandler.CarHandle.addCarItem(menu.addCarMenu2());
                                break;
                            case Menu.MENU_SUB_ADD_CUST:
                                uHandler.CustHandle.addCustItem(menu.addCustMenu2());
                                break;
                            case Menu.MENU_SUB_ADD_SELL:
                                uHandler.SellHandle.addSellItem(menu.addSellMenu2());
                                break;
                            case Menu.MENU_SUB_ADD_EXIT:
                                break;
                        }
                        uHandler.CarHandle.addCarItem(menu.addCarMenu2());
                        uHandler.CustHandle.addCustItem(menu.addCustMenu2());
                        uHandler.SellHandle.addSellItem(menu.addSellMenu2());
                        break;
                    case Menu.MENU_MAIN_DEL:
                        uHandler.CarHandle.delCarItem(menu.delCarMenu());
                        uHandler.CustHandle.delCustItem(menu.delCustMenu());
                        uHandler.SellHandle.delSellItem(menu.delSellMenu());
                        break;
                    case Menu.MENU_MAIN_UPDATE:
                        uHandler.CarHandle.updateCarItem(menu.updateCarMenu());
                        uHandler.CustHandle.updateCustItem(menu.updateCustMenu());
                        uHandler.SellHandle.updateSellItem(menu.updateSellMenu());
                        break;
                    case Menu.MENU_MAIN_EXIT:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

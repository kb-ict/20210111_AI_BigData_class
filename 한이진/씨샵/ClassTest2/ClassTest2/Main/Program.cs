using ClassTest2.Controll;
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
            //RandData rand = new RandData(); //싱글톤 패턴:생성된 하나의 객체를 사용하는 것
            Menu open = new Menu();
            UnionControll uHandler = new UnionControll(new RandData());

            while (true)
            {
                switch (open.mainManu())
                {
                    case Menu.MENU_MAIN_RAND:
                        //Console.WriteLine("랜덤 차량 데이터 생성합니다. ");                    
                        //uHandler.CarHandle.insrtRandData(open.getRandSize());
                        //Console.WriteLine("랜덤 고객 데이터 생성합니다.");
                        //uHandler.CustHandle.insrtRandCust(open.getRandSize());
                        //Console.WriteLine("랜덤 직원 데이터 생성합니다.");
                        //uHandler.SellHandle.insertRandSeller(open.getRandSize());

                        uHandler.insrtRandData(open.getRandSize());
                        break;

                    case Menu.MENU_MAIN_DEL_ALL:
                        Console.WriteLine("모든 데이터 삭제합니다.");
                        uHandler.CarHandle.removeAll();
                        uHandler.CustHandle.removeAll();
                        uHandler.SellHandle.removeAll();
                        break;

                    case Menu.MENU_MAIN_VIEW:
                        //Console.WriteLine("차량 데이터 출력합니다.");
                        //uHandler.CarHandle.carView();
                        //Console.WriteLine("고객 데이터 출력합니다.");
                        //uHandler.CustHandle.custView();
                        //Console.WriteLine("직원 데이터 출력합니다.");
                        //uHandler.SellHandle.selView();

                        uHandler.dealViewAll();
                        break;

                    case Menu.MENU_MAIN_ADD:
                        switch(open.sudAddMenu())
                        {
                            case Menu.ADD_CAR:
                                uHandler.CarHandle.addCarItem(open.addCarMenu2());
                                break;
                            case Menu.ADD_CUST:
                                uHandler.CustHandle.addCustItem(open.addCustMenu());
                                break;
                            case Menu.ADD_SELL:
                                uHandler.SellHandle.addSellerItem(open.addSellerMenu());
                                break;
                            case Menu.ADD_EXIT:
                                break;
                        }
                        break;

                    case Menu.MENU_MAIN_DEL:
                        switch(open.subDelMenu())
                        {
                            case Menu.DEL_CAR:
                                uHandler.CarHandle.delCarItem(open.delCarMenu());//Menu의 delCarMenu를 호출하여 입력받고 반환된 값에 해당한 데이터 삭제
                                break;
                            case Menu.DEL_CUST:
                                uHandler.CustHandle.delCustItem(open.delCustMenu());
                                break;
                            case Menu.DEL_SELL:
                                uHandler.SellHandle.delsellItem(open.delSellMenu());
                                break;
                            case Menu.DEL_EXIT:
                                break;
                        }
                        break;

                    case Menu.MENU_MAIN_UPDATE:
                        switch(open.subUpdateMenu())
                        {
                            case Menu.UPD_CAR:
                                uHandler.CarHandle.updateCarItem(open.updateCarMenu());
                                break;
                            case Menu.UPD_CUST:
                                uHandler.CustHandle.updataCustItem(open.updateCustMenu());
                                break;
                            case Menu.UPD_SELL:
                                uHandler.SellHandle.updataSellItem(open.updateSellMenu());
                                break;
                            case Menu.UPD_EXIT:
                                break;
                        }
                        break;

                    case Menu.MENU_MAIN_EXIT:
                        Console.WriteLine("앱 종료됩니다.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
            
    }
 }


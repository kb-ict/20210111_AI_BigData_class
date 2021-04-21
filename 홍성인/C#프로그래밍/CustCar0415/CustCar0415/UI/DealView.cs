using CustCar0415.Common;
using CustCar0415.Controll;
using CustCar0415.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415.UI
{
    partial class DealView : MaterialForm
    {
        UnionController uHandler;
        public DealView()
        {
            InitializeComponent();
        }
        public DealView(UnionController uHandler)            // <--- 싱글톤 check !!!
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        private void initDealSmListView()
        {
            List<Deal<Car, Customer, Seller>> list = uHandler.ListUn;         // <----- 추가
            
            for (int i = 0; i < list.Count; i++)
            {
                dealSmListview.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(),
                    list[i].Car.Model,
                    list[i].Car.Price,
                    list[i].Customer.Name,
                    list[i].Seller.Name,
                    list[i].Date,list[i].Price
                }
                ));
            }
            // 색 넣기
            setRowColor(Color.White, Color.LightBlue);

            int index = dealSmListview.Items.Count - 1;
            dealSmListview.Items[index].Selected = true;
            dealSmListview.Items[index].Focused = true;
            dealSmListview.EnsureVisible(index);
            CommMenu.colorListViewHeader(ref dealSmListview,Color.Black,Color.White); // <-----추가, ref는 '포인터' 개념
        }

        private void DealView_Load(object sender, EventArgs e)
        {
            initDealSmListView();
        }

        private void dealSmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setRowColor(Color color1, Color color2)
        {
            foreach (ListViewItem item in dealSmListview.Items)
            {
                // 짝수 라인
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                // 홀수 라인
                else
                {
                    item.BackColor = color2;
                }
            }
        }
    }
}

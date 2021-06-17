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
        UnionControll uhandler;
        public DealView()
        {
            InitializeComponent();   
        }
        public DealView(UnionControll uhandler)
        {
            InitializeComponent();
            this.uhandler = uhandler;
            
        }
        private void DealView_Load(object sender, EventArgs e)
        {
            initDealListView();
        }
        private void initDealListView()
        {
            List<Deal<Car, Customer, Seller>> list = uhandler.Listun;
            
            for(int i=0; i<list.Count;i++)
            {
                dealSmListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),list[i].Car.Model,
                        list[i].Car.Price,list[i].Customer.Name,
                        list[i].Seller.Name,list[i].Date,list[i].Price
                    }));
            }
            setRowColor(Color.White, Color.LightGray);
            int index = dealSmListView.Items.Count - 1;
            dealSmListView.Items[index].Selected = true;//열 선택
            dealSmListView.Items[index].Focused = true;// 선택 열 포커스 맞춰줌 
            dealSmListView.EnsureVisible(index);
            CommMenu.ColorListViewHeader(ref dealSmListView, Color.AliceBlue, Color.AntiqueWhite);
        }
        
        private void dealSmExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void setRowColor(Color color1,Color color2)
        {
            foreach(ListViewItem item in dealSmListView.Items)
            {
                if ((item.Index % 2 == 0))
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
                    
            }
        }
        
        
    }
}

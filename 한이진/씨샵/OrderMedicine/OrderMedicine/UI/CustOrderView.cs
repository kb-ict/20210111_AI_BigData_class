using MaterialSkin.Controls;
using OrderMedicine.Controll;
using OrderMedicine.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMedicine.UI
{
    partial class CustOrderView : MaterialForm
    {
        OrderControll orderControll;
        public CustOrderView()
        {
            InitializeComponent();
        }
        public CustOrderView(OrderControll orderControll)
        {
            InitializeComponent();
            this.orderControll = orderControll;
        }
        private void orderMediListView()
        {
            List<Buying<Customer, Medicine, Store>> list = orderControll.Orderlist;
            for (int i = 0; i < list.Count; i++)
            {
                orderViewMedi.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Medicine.PId,list[i].Medicine.MediName, list[i].Medicine.Effect,list[i].Medicine.Takeing,list[i].Medicine.Price
                    }));
            }
            setRowColor(Color.AliceBlue, Color.White);
            int index = orderViewMedi.Items.Count - 1;
            orderViewMedi.Items[index].Selected = true;
            orderViewMedi.Items[index].Focused = true;
            orderViewMedi.EnsureVisible(index);

        }
        private void orderListView()
        {
            List<Buying<Customer, Medicine, Store>> list = orderControll.Orderlist;
            for(int i=0; i < list.Count; i++)
            {
                orderview.Items.Add(new ListViewItem(
                    new string[]
                    {
                        list[i].Customer.CustName,list[i].Medicine.Effect,list[i].Medicine.MediName,list[i].Medicine.Price,list[i].Store.StoName
                    }));
            }
            setRowColor(Color.White, Color.BlueViolet);
            int index = orderViewMedi.Items.Count - 1;
            orderViewMedi.Items[index].Selected = true;
            orderViewMedi.Items[index].Focused = true;
            orderViewMedi.EnsureVisible(index);

        }
        public void setRowColor(Color color1, Color color2)
        {
            foreach (ListViewItem item in orderViewMedi.Items)
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

        private void CustOrderView_Load(object sender, EventArgs e)
        {
            orderMediListView();
            orderListView();
            
        }

        private void custOrderViewExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

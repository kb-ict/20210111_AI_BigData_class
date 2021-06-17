using MaterialSkin.Controls;
using MedicineOrder.Controll;
using MedicineOrder.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineOrder.UI
{
     partial class ViewData : MaterialForm
    {
        OrderControll order;
        public ViewData()
        {
            InitializeComponent();
        }
        public ViewData(OrderControll order)
        {
            InitializeComponent();
            this.order=order;
        }

        private void dataViewClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewData_Load(object sender, EventArgs e)
        {
            initViewData();
        }
        private void initViewData()
        {
            List<Buying<Customer, Medicine, Store>> orderlist=order.Orderlist;
            for(int i=0; i < orderlist.Count; i++)
            {
                        listView1.Items.Add(new ListViewItem(
                    new string[]
                    {
                        orderlist[i].Medicine.PId,orderlist[i].Medicine.MediName,orderlist[i].Medicine.Effect,
                        orderlist[i].Medicine.Takeing,orderlist[i].Medicine.Price }));
            }
        }
    }
}

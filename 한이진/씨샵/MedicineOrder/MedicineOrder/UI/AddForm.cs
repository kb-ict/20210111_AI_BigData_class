using MaterialSkin.Controls;
using MedicineOrder.Controll;
using MedicineOrder.Util;
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
    public partial class AddForm :MaterialForm
    {
        AppMenu menu = new AppMenu();
        OrderControll orderControll = new OrderControll();
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderControll.Custcon.addItem(menu.addCustMenu());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            orderControll.Medicon.addItem(menu.addMediMenu());
        }

        private void stoAddBtn_Click(object sender, EventArgs e)
        {
            orderControll.Storecon.addItem(menu.addStoreMenu());
        }
        
    }
}

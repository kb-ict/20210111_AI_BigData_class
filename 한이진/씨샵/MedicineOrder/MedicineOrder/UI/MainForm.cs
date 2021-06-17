using MaterialSkin.Controls;
using MedicineOrder.Controll;
using MedicineOrder.UI;
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

namespace MedicineOrder
{
    public partial class MainForm : MaterialForm
    {
        OrderControll order = new OrderControll();
           
        public MainForm()
        {
            InitializeComponent();
        }

        private void addDataBtn_Click(object sender, EventArgs e)
        {
            new AddForm().ShowDialog();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            order.Medicon.viewItem();
            new ViewData(order).ShowDialog();


        }

        private void mainExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void appInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("상비약품 주문 앱 나혼자약산다 v1.0\n" + "2021년 04월 19일 by 한이진");
        }
    }
}

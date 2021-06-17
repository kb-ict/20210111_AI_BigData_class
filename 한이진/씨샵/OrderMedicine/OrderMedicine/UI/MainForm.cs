using MaterialSkin.Controls;
using OrderMedicine.Controll;
using OrderMedicine.UI;
using OrderMedicine.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMedicine
{
    public partial class MainForm : MaterialForm
    {
        AppMenu mene = new AppMenu();
        OrderControll orderControll = new OrderControll();
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("상비약품 주문 앱 나혼자약산다 v1.0\n" + "2021년 04월 19일 by 한이진");
        }

        private void custBtn_Click(object sender, EventArgs e)
        {
            new CustMain(orderControll).ShowDialog();
        }

        private void stoBtn_Click(object sender, EventArgs e)
        {
            new StoMain().ShowDialog();
        }
    }
}

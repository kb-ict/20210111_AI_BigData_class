using CustCar0415.Controll;
using CustCar0415.Util;
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

namespace CustCar0415
{
    public partial class MainWin : MaterialForm
    {
        MyMenu menu = new MyMenu();
        UnionController uHandler = new UnionController(new RandData());

        public MainWin()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객차량관리앱 v1.0\n" + "2021년4월15일 by 홍성인");
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cxFlatRoundButton1_Click(object sender, EventArgs e)
        {
            uHandler.insRandData(menu.getRandSize());
        }

        private void cxFlatRoundButton5_Click(object sender, EventArgs e)
        {
            uHandler.dealViewAll();
        }
    }
}

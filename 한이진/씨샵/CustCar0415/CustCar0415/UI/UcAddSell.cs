using CustCar0415.Controll;
using CustCar0415.Model;
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
    partial class UcAddSell : UserControl
    {
        UnionControll uHandler;
        AddData addData;
        public UcAddSell()
        {
            InitializeComponent();
        }
        public UcAddSell(UnionControll uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }
        public UcAddSell(UnionControll uHandler, AddData addData)
        {
            InitializeComponent();
            this.uHandler = uHandler;
            this.addData = addData;
        }
        private void ucAddSellOK_Click(object sender, EventArgs e)
        {
            string name = ucAddSellName.Text;
            string tel = ucAddSellPhone.Text;
            string level = ucAddSellLevel.Text;
            string office = ucAddSellOffice.Text;
            uHandler.SellHandle.addItem(new Seller(name, tel, level, office));
            MessageBox.Show("직원 정보가 등록되었습니다.");
            ucAddSellOK.Enabled = false;
            addData.setStatusInfo("직원 정보가 등록되었습니다.");


        }

        private void ucAddSellInit_Click(object sender, EventArgs e)
        {

        }
    }
}

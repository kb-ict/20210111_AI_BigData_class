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
    partial class UcAddSell : UserControl                               // 3. PUBLIC 제거
    {
        UnionController uHandler;                                       // 2.
        public UcAddSell()
        {
            InitializeComponent();
        }

        public UcAddSell(UnionController uHandler)                      // 1.
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        private void ucAddSellOK_Click(object sender, EventArgs e)      // 4.
        {
            String name = ucAddSellName.Text;                           // 6.
            string tel = ucAddSellTel.Text;
            string status = ucAddSellStatus.Text;
            string office = ucAddSellOffice.Text;

            uHandler.SellHandle.addItem(new Seller(                     // 7.     8.노트 필기
                name, tel, status, office));
            MessageBox.Show("판매자 정보가 등록되었습니다.");
            ucAddSellOK.Enabled = false;
        }

        private void ucAddSellInit_Click(object sender, EventArgs e)   // 5.
        {

        }
    }
}

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
    partial class UcAddCust : UserControl
    {
        UnionControll uHandler;
        AddData addData;
        char gender;
        public UcAddCust()
        {
            InitializeComponent();
        }
        public UcAddCust(UnionControll uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }
        public UcAddCust(UnionControll uHandler,AddData addData)
        {
            InitializeComponent();
            this.uHandler = uHandler;
            this.addData = addData;
        }
        private void ucAddCustOK_Click(object sender, EventArgs e)
        {
            string name = ucAddCustName.Text;
            string age = ucAddCustAge.Text;
            string phone = ucAddCustPhone.Text;
            string address = ucAddCustAddress.Text;
            uHandler.CustHandle.addItem(new Customer(name, Convert.ToInt32(age), phone, address, gender));
            MessageBox.Show("☆★고객 정보가 등록~☆★");
            ucAddCustOK.Enabled = false;
            addData.setStatusInfo("고객 정보가 등록되었습니다.");
        }


        private void ucAddCustInit_Click(object sender, EventArgs e)
        {

        }

        private void ucAddCustWoman_ValueChanged(object sender, bool value)
        {
            Sunny.UI.UIRadioButton rd= sender as Sunny.UI.UIRadioButton;
            if (rd.Checked == false) return;
            if(rd.Name.Equals("ucAddCustWoman"))
            {
                gender = '여';
            }
            else
            {
                gender = '남';
            }
            //MessageBox.Show(gender);
            
        }

     
    }
}

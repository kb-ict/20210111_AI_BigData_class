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
    partial class UcAddCust : UserControl
    {
        OrderControll orderControll;
        string id;
        string name;
        string age;
        char gender;
        string address;
        string phone;

        public UcAddCust()
        {
            InitializeComponent();
        }
        public UcAddCust(OrderControll orderControll)
        {
            InitializeComponent();
            this.orderControll = orderControll;
            return;
        }

        private void custAddDataOk_Click(object sender, EventArgs e)
        {
            
            
            id = custAddId.Text;
            name = custAddName.Text;
            age = custAddAge.Text;
            address = custAddAddress.Text;
            phone = custAddPhone.Text;
            orderControll.Custcon.addItem(new Customer(id, name, age, gender, address, phone));
            MessageBox.Show("고객 정보가 등록되었습니다.");
            custAddDataOk.Enabled = false;
            
            
        }
        

        private void custAddDataInit_Click(object sender, EventArgs e)
        {
            //custAddId.Text = null;
            //custAddName.Text = null;
            //custAddAge.Text = null;
            //custAddSymptom.Text = null;
            //custAddAddress.Text = null;
            //custAddPhone.Text = null;
            
            
            id = null;
            name = null;
            age = null;
            address = null;
            phone = null;
            gender = '\0';
        }

        private void custAddGenderW_ValueChanged(object sender, bool value)
        {
            Sunny.UI.UIRadioButton rd = sender as Sunny.UI.UIRadioButton;
            if (rd.Checked == false) return;
            if (rd.Name.Equals("custAddGenderW"))
            {
                gender = '여';
            }
            else
            {
                gender = '남';
            }
        }
     

       
    }
}

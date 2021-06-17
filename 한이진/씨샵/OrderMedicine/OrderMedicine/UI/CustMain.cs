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
     partial class CustMain : MaterialForm
    {
        const string UC_ADD_CUST = "UcAddCust";
        const string UC_ADD_CUSTORDER = "UcCustOrder";
        const string UC_ADD_ORDERSTORE = "UcOrderStore";
        const string UC_ADD_ORDERVIEW = "UcCustOderView";

        UcAddCust ucAddCust;
        UcCustOrder ucCustOrder;
        UcOrderStore ucOrderStore;
        OrderControll orderControll;
        public CustMain()
        {
            InitializeComponent();
            ucAddCust = new UcAddCust();
            ucCustOrder = new UcCustOrder();
            ucOrderStore = new UcOrderStore();
           
            centerLayout.Controls.Add(ucAddCust);
            centerLayout.Dock = DockStyle.Fill;
        }
        public CustMain(OrderControll orderControll)
        {
            InitializeComponent();
            this.orderControll = orderControll;
            ucAddCust = new UcAddCust(orderControll);
            ucCustOrder = new UcCustOrder(orderControll);
            ucOrderStore = new UcOrderStore(orderControll);
            
            centerLayout.Controls.Add(ucAddCust);
            centerLayout.Dock = DockStyle.Fill;
        }

        private void custAddDataBtn_Click(object sender, EventArgs e)
        {
            controllView(ucAddCust, UC_ADD_CUST);
        }

        private void orderAddData_Click(object sender, EventArgs e)
        {
            controllView(ucCustOrder, UC_ADD_CUSTORDER);
        }
        private void orderAddStore_Click(object sender, EventArgs e)
        {
            controllView(ucOrderStore, UC_ADD_ORDERSTORE);
        }
        private void orderDataView_Click(object sender, EventArgs e)
        {
            if (orderControll.Orderlist.Count > 0)
            {
                new CustOrderView(orderControll).ShowDialog();
            }
            else
            {
                MessageBox.Show("주문 내역이 존재하지 않습니다");
            }
        }
        private void controllView(UserControl uc, string view)
        {
            if (!centerLayout.Controls.ContainsKey(view))
            {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[view].BringToFront();
        }

        private void custExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void custMainQ_Click(object sender, EventArgs e)
        {
            MessageBox.Show("나혼자약산다 v1.0 고객용; 주문 정보 등록");
        }

        private void custMainOrder_Click(object sender, EventArgs e)
        {
            orderControll.Orderlist.Add(new Buying<Customer, Medicine, Store>(orderControll.Custcon.Listcust[0],
                orderControll.Medicon.ListMedi[0], orderControll.Storecon.ListSto[0], DateTime.Now.ToString("yyyy년mm월dd일")));
        }
    }
}

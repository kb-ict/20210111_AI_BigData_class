using CustCar0415.Controll;
using CustCar0415.Model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustCar0415.UI
{
    partial class AddData : MaterialForm
    {
#pragma warning disable CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다. //전처리기
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hwnd, int Msg, int wParam, int lparam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();
#pragma warning restore CS0108 // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.
        const string UC_NAME_ADD_CAR = "UcAddCar";
        const string UC_NAME_ADD_CUST = "UcAddCust";
        const string UC_NAME_ADD_SELL = "UcAddSell";

        UcAddCar ucAddCar;
        UcAddCust ucAddCust;
        UcAddSell ucAddSell;
        UnionControll uHandler;
        public AddData()
        {
            InitializeComponent();
            ucAddCar = new UcAddCar();
            ucAddCust = new UcAddCust();
            ucAddSell = new UcAddSell();
            centerLayout.Controls.Add(ucAddCar);
            centerLayout.Dock = DockStyle.Fill;
        }
        public AddData(UnionControll uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
            ucAddCar = new UcAddCar(uHandler,this); //this 자신 클래스, base 상위 클래스
            ucAddCust = new UcAddCust(uHandler,this);
            ucAddSell = new UcAddSell(uHandler,this);
            centerLayout.Controls.Add(ucAddCar);
            centerLayout.Dock = DockStyle.Fill;
            ucAddCar.addcarConfirmEvent += addCarConfirmHandler;
        }

        private void addDatatExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void carAddDataBtn_Click(object sender, EventArgs e)
        {
            controllView(ucAddCar, UC_NAME_ADD_CAR);
        }

        private void custAddDataBtn_Click(object sender, EventArgs e)
        {
            controllView(ucAddCust, UC_NAME_ADD_CUST);
        }
        private void sellAddDataBtn_Click(object sender, EventArgs e)
        {
            controllView(ucAddSell, UC_NAME_ADD_SELL);
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
        private void topLayout_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }// 마우스로 화면이동 (상단 레이아읏부분에서) 클릭하여... 이해할 필요가 없다라... 
        }
        public void setStatusInfo(string status)// 상태정보 메소드
        {
            addDataStatus.Text = status;
        }
        private void addCarConfirmHandler(object sender, EventArgs e)
        {
            addDataStatus.Text = "차량정보를 등록하였습니다.";
        }

        private void addDataDeal_Click(object sender, EventArgs e)
        {
            uHandler.Listun.Add(new Deal<Car, Customer, Seller>(uHandler.CarHandle.ListCar[0],
                uHandler.CustHandle.ListCust[0], uHandler.SellHandle.ListSell[0],
                DateTime.Now.ToString("yyyy년mm월dd일"), uHandler.CarHandle.ListCar[0].Price+"3백만원"));
        }
    }
}

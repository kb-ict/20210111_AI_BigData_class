using CustCar0415.Controll;
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
    partial class AddData : MaterialForm     // 스킨 적용 시키기
    {
#pragma warning disable CS0108                      // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.
        const int WM_NCLBUTTONDOWN = 0xA1;
#pragma warning restore CS0108                      // 멤버가 상속된 멤버를 숨깁니다. new 키워드가 없습니다.
        const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        static extern bool ReleaseCapture();


        const string UC_NAME_ADD_CAR = "UcAddCar";
        const string UC_NAME_ADD_CUST = "UcAddCust";
        const string UC_NAME_ADD_SELL = "UcAddSell";
        UcAddCar ucAddCar;
        UcAddCust ucAddCust;
        UcAddSell ucAddSell;
        UnionController uHandler;

        public AddData()
        {
            InitializeComponent();
            //  객체 생성하기
            ucAddCar = new UcAddCar();
            ucAddCust = new UcAddCust();
            ucAddSell = new UcAddSell();
            centerLayout.Controls.Add(ucAddCar);
            centerLayout.Dock = DockStyle.Fill;
        }

        public AddData(UnionController uHandler)
        {
            InitializeComponent();
            //  객체 생성하기
            ucAddCar = new UcAddCar(uHandler,this);                 // this 값 = AddData 클래스 의미
            ucAddCust = new UcAddCust(uHandler);                    // uHandler 추가하기
            ucAddSell = new UcAddSell();
            centerLayout.Controls.Add(ucAddCar);
            centerLayout.Dock = DockStyle.Fill;
            ucAddCar.addCarConfirmEvent += addCarConfirmHandler;
        }

        private void addDataExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void topLayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);           // '0' 의 의미 질문하기
            }
        }

        private void addDataCar_Click(object sender, EventArgs e)
        {
            controllView(ucAddCar, UC_NAME_ADD_CAR);
        }

        private void addDataCust_Click(object sender, EventArgs e)
        {
            controllView(ucAddCust, UC_NAME_ADD_CUST);
        }

        private void addDataSell_Click(object sender, EventArgs e)
        {
            controllView(ucAddSell, UC_NAME_ADD_SELL);
        }

        private void controllView(UserControl uc,string view)
        {
            if (!centerLayout.Controls.ContainsKey(view))
            {
                uc.Dock = DockStyle.Fill;
                centerLayout.Controls.Add(uc);
            }
            centerLayout.Controls[view].BringToFront();
        }

        public void setStatusInfo(string status)
        {
            addDataStatus.Text = status;
        }

        private void addCarConfirmHandler(object sender, EventArgs e)
        {
            addDataStatus.Text = "차량 정보를 등록하였습니다.";
        }
    }
}

using CustCar0415.Controll;
using CustCar0415.UI;
using CustCar0415.Util;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            var msMgr = MaterialSkinManager.Instance;
            msMgr.Theme = MaterialSkinManager.Themes.LIGHT;
            msMgr.ColorScheme = new ColorScheme(
                Primary.LightGreen200,
                Primary.LightBlue500,
                Primary.LightBlue500,
                Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객차량관리앱 v1.0\n" + "2021년4월15일 by 홍성인");
        }

        private void MainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void randInsert_Click(object sender, EventArgs e)
        {
            string size = myInputBox("랜덤하게 생성할 데이터 개수를 입력하세요", "랜덤 데이터 추가", "0");
            if (size.Equals(""))
                //uHandler.insRandData(1);
                return;
            else
                uHandler.insRandData(Convert.ToInt32(size));
        }
        
        private void dataView_Click(object sender, EventArgs e)
        {
            uHandler.itemView();                                // dealView -> itemView 로 변경
            new DealView(uHandler).ShowDialog();
            //DealView s = new DealView();
            //s.addSome(uHandler);
            //s.ShowDialog();
        }

        public string myInputBox(string title, string body, string prompt)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt);
        }

        public void initFont()
        {
            // 버튼 폰트 적용
            CxFlatUI.CxFlatRoundButton[] btnArr =
                {randInsert, randDel, dataView, dataInsert, dataDel, dataUpdate};
            PrivateFontCollection pFont = new PrivateFontCollection();
            pFont.AddFontFile("hangeul.ttf");
            Font font = new Font(pFont.Families[0], 16f);
            //randInsert.Font = font;

            // CxFlatUI.CxFlatRoundButton = var 와 동일
            // btnArr의 각각의 요소들을 n 으로 넘겨준다
            // randInsert, randDel, dataView, dataInsert, dataDel, dataUpdate 의 순서로 넘겨준다
            // btnArr 의 주소값을 n 으로 넘겨준다 ( = 포인터 ) 
            foreach (var n in btnArr)
            {
                n.Font = font;
            }
            mainTitle.Font = font;
        }

        // 화면이 보이기 시작하는 전 단계
        private void MainWin_Load(object sender, EventArgs e)
        {
            initFont();
        }

        private void randDel_Click(object sender, EventArgs e)
        {
            uHandler.removeAll();
        }

        private void dataInsert_Click(object sender, EventArgs e)
        {
            //new AddCar(uHandler).ShowDialog();
            new AddData(uHandler).ShowDialog();
        }
    }
}

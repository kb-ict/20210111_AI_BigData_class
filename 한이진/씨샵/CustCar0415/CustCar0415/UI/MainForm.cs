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
    public partial class MainWin : MaterialForm //자식 : 부모 => 상속관계
    {
        MyMenu menu = new MyMenu();
        UnionControll uHandler = new UnionControll(new RandData()); //싱글톤
        PrivateFontCollection pFont;
        Font font;
        MaterialSkin.Controls.MaterialRaisedButton[] btnArr;

        public MainWin()
        {
            InitializeComponent();//form 초기화
            initFont();
            var msMgr = MaterialSkinManager.Instance;
            msMgr.Theme = MaterialSkinManager.Themes.LIGHT;
            msMgr.ColorScheme = new ColorScheme(Primary.LightBlue500, Primary.LightBlue500, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);
      
        }//삭제 ctrl+z
        private void mainExit_Click(object sender, EventArgs e)//이벤드 핸들러
        {
            Application.Exit();
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("고객차량관리앱 v1.0\n" + "2021년 04월 15일 by 한이진");
        }

        private void randAddBtn_Click(object sender, EventArgs e)
        {
            string size = myInputBox("랜덤하게 생성할 데이터 개수를 입력하세요.", "랜덤 데이터 추가", "0");
            uHandler.insRandData(Convert.ToInt32(size));
        }
        
        private void randDelBtn_Click(object sender, EventArgs e)
        {
            uHandler.removeAll();
        }

        private void dataALLBtn_Click(object sender, EventArgs e)
        {
            uHandler.itemViewAll();
            new DealView(uHandler).ShowDialog(); //Show()
           
        }

       

        private void dataUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void dataDelBtn_Click(object sender, EventArgs e)
        {

        }
        public string myInputBox(string title, string body, string prompt)
        {
            string input= Microsoft.VisualBasic.Interaction.InputBox(title, body, prompt, -1, -1);
            //참조 추가 Microsoft.VisualBasic (패키지 기능 추가)
            return input;
        }
        public void initFont()
        {
            btnArr = new MaterialSkin.Controls.MaterialRaisedButton[] { randAddBtn, randDelBtn, dataAddBtn, dataALLBtn, dataDelBtn, dataUpdateBtn };
            pFont = new PrivateFontCollection();
            pFont.AddFontFile("THE_Nyuseusokbo.ttf");
            font = new Font(pFont.Families[0], 13f);

            foreach(var n in btnArr)
            {
                n.Font = font;
            }
            mainTitle.Font = font;
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            //initFont(); //생성자를 통하면 빠르게 실행 또는 Main
        }

        private void dataAddBtn_Click(object sender, EventArgs e)
        {
            new AddData(uHandler).ShowDialog();
        }
    }
}

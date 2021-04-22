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
    partial class UcAddCar : UserControl
    {
        string model;
        string company;
        string color;
        string price;
        UnionController uHandler;
        AddData ad;
        public delegate void AddCarConfirmEventHandler(object sender, EventArgs e);
        public event AddCarConfirmEventHandler addCarConfirmEvent;

        public UcAddCar()
        {
            InitializeComponent();
        }

        public UcAddCar(UnionController uHandler)                   // <--- 위에 public 제거 
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        public UcAddCar(UnionController uHandler , AddData ad)      // UcAddCar 오버로딩 
        {
            InitializeComponent();
            this.uHandler = uHandler;
            this.ad = ad;
        }

        private void ucComboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = showCarCombo(sender);
            ucInfoModel.Text = model;
            ucInfoModel.ForeColor = Color.Red;
            switch (model)
            {
                case "그란카브리오":
                    ucCxFlatPictureBox1.Image = Properties.Resources.그란측면1;
                    ucCxFlatPictureBox2.Image = Properties.Resources.그란측면1;
                    ucCxFlatPictureBox3.Image = Properties.Resources.그란정면;
                    ucCxFlatPictureBox4.Image = Properties.Resources.그란실내;
                    break;
                case "가야르도":
                    ucCxFlatPictureBox1.Image = Properties.Resources.가야르도실내1;
                    ucCxFlatPictureBox2.Image = Properties.Resources.가야르도실내2;
                    ucCxFlatPictureBox3.Image = Properties.Resources.가야르도정면;
                    ucCxFlatPictureBox4.Image = Properties.Resources.가야르도측면;
                    break;
                case "우라칸":
                    ucCxFlatPictureBox1.Image = Properties.Resources.우라칸측면3;
                    ucCxFlatPictureBox2.Image = Properties.Resources.우라칸정면;
                    ucCxFlatPictureBox3.Image = Properties.Resources.우라칸실내1;
                    ucCxFlatPictureBox4.Image = Properties.Resources.우라칸내부;
                    break;
                case "기블리":
                    break;
                case "르반떼":
                    break;
            }
        }

        private void ucComboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            company = showCarCombo(sender);
            ucInfoCompany.Text = company;             // AddCar.cs UI 하단부 제조사 
            ucInfoCompany.ForeColor = Color.Red;
        }

        private void ucComboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = showCarCombo(sender);
            ucInfoColor.Text = color;                 // AddCar.cs UI 하단부 색상
            ucInfoColor.ForeColor = Color.Red;
        }

        private void ucComboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price = showCarCombo(sender);
            ucInfoPrice.Text = price;                 // AddCar.cs UI 하단부 가격
            ucInfoPrice.ForeColor = Color.Red;
        }

        private string showCarCombo(object obj)
        {
            Sunny.UI.UIComboBox cb = obj as Sunny.UI.UIComboBox;          // 다형성
            Console.WriteLine("index: " + cb.SelectedIndex);
            string item = cb.SelectedItem.ToString();
            if (cb.SelectedIndex > -1)
            {
                Console.WriteLine("선택: " + item);
            }
            return item;
        }

        private void ucAddCarOK_Click(object sender, EventArgs e)
        {
            if (model == null)
            {
                MessageBox.Show("모델을 선택하세요.");
                ucComboModel.Select();
                return;
            }

            if (company == null)
            {
                MessageBox.Show("제조사을 선택하세요.");
                ucComboCompany.Select();
                return;
            }

            if (color == null)
            {
                MessageBox.Show("색상을 선택하세요.");
                ucComboColor.Select();
                return;
            }

            if (price == null)
            {
                MessageBox.Show("가격을 선택하세요.");
                ucComboPrice.Select();
                return;
            }
            uHandler.CarHandle.addItem(new Car(model, color, company, price));
            MessageBox.Show("구매할 차량 정보가 저장되었습니다.");
            ucAddCarOK.Enabled = false;
            //ad.setStatusInfo("차량 정보가 등록되었습니다.");
            if (addCarConfirmEvent != null)
            {
                addCarConfirmEvent(this, new EventArgs());
            }
        }

        private void ucAddCarInit_Click(object sender, EventArgs e)
        {

        }
    }
}

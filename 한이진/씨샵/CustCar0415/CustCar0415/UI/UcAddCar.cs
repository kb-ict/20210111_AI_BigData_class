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
        string campany;
        string color;
        string price;
        UnionControll uHandler;
        AddData addData;
        public delegate void AddCarConfirmEventHandler(object sender, EventArgs e);//사용자 정의 메소드
        public event AddCarConfirmEventHandler addcarConfirmEvent;
        public UcAddCar()
        {
            InitializeComponent();
        }
        public UcAddCar(UnionControll uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }
        public UcAddCar(UnionControll uHandler, AddData addData)
        {
            InitializeComponent();
            this.uHandler = uHandler;
            this.addData = addData;
        }

        private void ucComboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = showCarCombo(sender);
            ucInfoModel.Text = model;
            ucInfoModel.ForeColor = Color.Red;
            switch (model)
            {
                case "콰트로포르테":
                    ucPictureBox1.Image = Properties.Resources.ma_f;
                    ucPictureBox2.Image = Properties.Resources.ma_b;
                    ucPictureBox3.Image = Properties.Resources.ma_s;
                    ucPictureBox4.Image = Properties.Resources.ma_i;
                    break;
                case "J_500":
                    ucPictureBox1.Image = Properties.Resources.je_f;
                    ucPictureBox2.Image = Properties.Resources.je_b;
                    ucPictureBox3.Image = Properties.Resources.ma_s;
                    ucPictureBox4.Image = Properties.Resources.je_i;
                    break;
                case "제네시스":
                    ucPictureBox1.Image = Properties.Resources.ge_f;
                    ucPictureBox2.Image = Properties.Resources.ge_b;
                    ucPictureBox3.Image = Properties.Resources.ge_s;
                    ucPictureBox4.Image = Properties.Resources.ge_i;
                    break;
            }
        }

        private void ucComboCampany_SelectedIndexChanged(object sender, EventArgs e)
        {
            campany = showCarCombo(sender);
            ucInfoCanpany.Text = campany;
            ucInfoCanpany.ForeColor = Color.Red;
        }

        private void ucComboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = showCarCombo(sender);
            ucInfoColor.Text = color;
            ucInfoColor.ForeColor = Color.Red;
        }

        private void ucComboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price = showCarCombo(sender);
            ucInfoPrice.Text = price;
            ucInfoPrice.ForeColor = Color.Red;
        }
        private string showCarCombo(object obj)
        {
            Sunny.UI.UIComboBox cb = obj as Sunny.UI.UIComboBox;
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
            if (campany == null)
            {
                MessageBox.Show("제조사를 선택하세요.");
                ucComboCampany.Select();
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
            uHandler.CarHandle.addItem(new Car(model, color, campany, price));
            MessageBox.Show("☆★구매할 차량 정보가 저장!~☆★");
            ucAddCarOK.Enabled = false;
            //addData.setStatusInfo("차량 정보가 등록되었습니다.");
            if (addcarConfirmEvent != null)
            {
                addcarConfirmEvent(this, new EventArgs());
            }

        }

        private void ucAddCarInit_Click(object sender, EventArgs e)
        {

        }
    }

}

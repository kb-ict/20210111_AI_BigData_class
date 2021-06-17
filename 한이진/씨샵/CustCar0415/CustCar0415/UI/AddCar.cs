using CustCar0415.Controll;
using CustCar0415.Model;
using MaterialSkin.Controls;
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
   partial class AddCar : MaterialForm
    {
        private string model;
        private string campany;
        private string color;
        private string price;
        UnionControll uHandler;

        public AddCar()
        {
            InitializeComponent();
            
        }
        public AddCar(UnionControll uHandler) // 생성자 오버로딩 매개변수 타입, 개수가 다를떄
        {
            InitializeComponent();
            this.uHandler = uHandler; // 이미 main에서 만들어진 객체 사용 싱글톤
        }

        private void addCarOK_Click(object sender, EventArgs e)
        {
            if (model == null)
            {
                MessageBox.Show("모델을 선택하세요.");
                comboModel.Select();
                return;
            }
            if (campany == null)
            {
                MessageBox.Show("제조사를 선택하세요.");
                comboCampany.Select();
                return;
            }
            if (color == null)
            {
                MessageBox.Show("색상을 선택하세요.");
                comboColor.Select();
                return;
            }
            if (price == null)
            {
                MessageBox.Show("가격을 선택하세요.");
                comboPrice.Select();
                return;
            }
            uHandler.CarHandle.addItem(new Car(model, color, campany, price));
            MessageBox.Show("☆★구매할 차량 정보가 저장!~☆★");
            Close();
        }

        private void addCarCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            model= showCarCombo(sender);
            infoModel.Text = model;
            infoModel.ForeColor = Color.Red;
            switch (model)
            {
                case "콰트로포르테":
                    pictureBox1.Image = Properties.Resources.ma_f;
                    pictureBox2.Image = Properties.Resources.ma_b;
                    pictureBox3.Image = Properties.Resources.ma_s;
                    pictureBox4.Image = Properties.Resources.ma_i;
                    break;
                case "J_500":
                    pictureBox1.Image = Properties.Resources.je_f;
                    pictureBox2.Image = Properties.Resources.je_b;
                    pictureBox3.Image = Properties.Resources.ma_s;
                    pictureBox4.Image = Properties.Resources.je_i;
                    break;
                case "제네시스":
                    pictureBox1.Image = Properties.Resources.ge_f;
                    pictureBox2.Image = Properties.Resources.ge_b;
                    pictureBox3.Image = Properties.Resources.ge_s;
                    pictureBox4.Image = Properties.Resources.ge_i;
                    break;
            }
        }

        private void comboCampany_SelectedIndexChanged(object sender, EventArgs e)
        {
            campany=showCarCombo(sender);
            infoCanpany.Text = campany;
            infoCanpany.ForeColor = Color.Red;
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color=showCarCombo(sender);
            infoColor.Text = color;
            infoColor.ForeColor = Color.Red;
        }

        private void comboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price=showCarCombo(sender);
            infoPrice.Text = price;
            infoPrice.ForeColor = Color.Red;
        }
        private string showCarCombo(object obj)
        {
            Sunny.UI.UIComboBox cb = obj as Sunny.UI.UIComboBox;
            Console.WriteLine("index: " + cb.SelectedIndex);
            string item = cb.SelectedItem.ToString();
            if(cb.SelectedIndex>-1)
            {
                Console.WriteLine("선택: " + item);
              
            }return item;
        }

        private void infoModel_Click(object sender, EventArgs e)
        {

        }

        private void infoCanpany_Click(object sender, EventArgs e)
        {

        }

        private void infoColor_Click(object sender, EventArgs e)
        {

        }

        private void infoPrice_Click(object sender, EventArgs e)
        {

        }

        private void AddCar_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        string model;
        string company;
        string color;
        string price;
        UnionController uHandler;

        public AddCar()
        {
            InitializeComponent();
        }
        public AddCar(UnionController uHandler)
        {
            InitializeComponent();
            this.uHandler = uHandler;
        }

        private void addCarOK_Click(object sender, EventArgs e)
        {
            if (model == null)
            {
                MessageBox.Show("모델을 선택하세요.");
                comboModel.Select();                                           
                return;
            }

            if (company == null)
            {
                MessageBox.Show("제조사을 선택하세요.");
                comboCompany.Select();                                           
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
            uHandler.CarHandle.addItem(new Car(model, color, company, price));
            MessageBox.Show("구매할 차량 정보가 저장되었습니다.");
            Close();
        }

        private void addCarCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            model = showCarCombo(sender);
            infoModel.Text = model;
            infoModel.ForeColor = Color.Red;
            switch (model)
            {
                case "그란카브리오":
                    cxFlatPictureBox1.Image = Properties.Resources.그란측면1;
                    cxFlatPictureBox2.Image = Properties.Resources.그란측면1;
                    cxFlatPictureBox3.Image = Properties.Resources.그란정면;
                    cxFlatPictureBox4.Image = Properties.Resources.그란실내;
                    break;
                case "가야르도":
                    cxFlatPictureBox1.Image = Properties.Resources.가야르도실내1;
                    cxFlatPictureBox2.Image = Properties.Resources.가야르도실내2;
                    cxFlatPictureBox3.Image = Properties.Resources.가야르도정면;
                    cxFlatPictureBox4.Image = Properties.Resources.가야르도측면;
                    break;
                case "우라칸":
                    cxFlatPictureBox1.Image = Properties.Resources.우라칸측면3;
                    cxFlatPictureBox2.Image = Properties.Resources.우라칸정면;
                    cxFlatPictureBox3.Image = Properties.Resources.우라칸실내1;
                    cxFlatPictureBox4.Image = Properties.Resources.우라칸내부;
                    break;
                case "기블리":
                    break;
                case "르반떼":
                    break;
            }
        }

        private void comboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            company = showCarCombo(sender);
            infoCompany.Text = company;             // AddCar.cs UI 하단부 제조사 
            infoCompany.ForeColor = Color.Red;
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = showCarCombo(sender);
            infoColor.Text = color;                 // AddCar.cs UI 하단부 색상
            infoColor.ForeColor = Color.Red;
        }

        private void comboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price = showCarCombo(sender);
            infoPrice.Text = price;                 // AddCar.cs UI 하단부 가격
            infoPrice.ForeColor = Color.Red;
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
    }
}

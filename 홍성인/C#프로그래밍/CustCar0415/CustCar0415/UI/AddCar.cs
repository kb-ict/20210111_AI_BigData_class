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
    public partial class AddCar : MaterialForm
    {
        string model;
        string company;
        string color;
        string price;

        public AddCar()
        {
            InitializeComponent();
        }

        private void addCarOK_Click(object sender, EventArgs e)
        {

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
            infoCompany.Text = company;
            infoCompany.ForeColor = Color.Red;
        }

        private void comboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = showCarCombo(sender);
            infoColor.Text = color;
            infoColor.ForeColor = Color.Red;
        }

        private void comboPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            price = showCarCombo(sender);
            infoPrice.Text = price;
            infoPrice.ForeColor = Color.Red;
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
    }
}

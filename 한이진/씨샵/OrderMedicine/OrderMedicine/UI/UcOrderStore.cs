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
    partial class UcOrderStore : UserControl
    {
        OrderControll orderControll;
        string name;
        string manager;
        string phone;
        string address;
        public UcOrderStore()
        {
            InitializeComponent();
        }
        public UcOrderStore(OrderControll orderControll)
        {
            InitializeComponent();
            this.orderControll = orderControll;
        }
        private void comboStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = showCombo(sender);
            orderStoreName.Text = name;
            orderStoreName.ForeColor = Color.Blue;
            switch (name)
            {
                case "한사랑 약국":
                    picBox.Image = Properties.Resources.한사랑약국;
                    manager = "한건강";
                    phone = "070-3040-43030";
                    address = "대구 동구 신암동";
                    orderStoreManager.Text = manager;
                    orderStorePhone.Text = phone;
                    orderStoreAddress.Text = address;
                    break;
                case "누리 약국":
                    picBox.Image = Properties.Resources.누리약국;
                    manager = "나누리";
                    phone = "070-3440-33444";
                    address = "경북 경산시 중앙동";
                    orderStoreManager.Text = manager;
                    orderStorePhone.Text = phone;
                    orderStoreAddress.Text = address;
                    break;
                case "우리 종합 약국":
                    picBox.Image = Properties.Resources.우리_종합_약국;
                    manager = "우종국";
                    phone = "070-2340-3430";
                    address = "울산 울주군 서생면";
                    orderStoreManager.Text = manager;
                    orderStorePhone.Text = phone;
                    orderStoreAddress.Text = address;
                    break;
                case "다나아 약국":
                    picBox.Image = Properties.Resources.한사랑약국;
                    manager = "안나아";
                    phone = "070-2540-8930";
                    address = "부산 해운대구 마린시티";
                    orderStoreManager.Text = manager;
                    orderStorePhone.Text = phone;
                    orderStoreAddress.Text = address;
                    break;
            }
        }
        private string showCombo(object obj)
        {
            Sunny.UI.UIComboBox uc = obj as Sunny.UI.UIComboBox;
            string item = uc.SelectedItem.ToString();
            Console.WriteLine("index: " + uc.SelectedIndex);
            if (uc.SelectedIndex > -1)
            {
                Console.WriteLine("선택: " + uc.SelectedItem);
            }return item;
        }

        private void orderStoreOk_Click(object sender, EventArgs e)
        {
            if (name == null)
            {
                MessageBox.Show("약국을 선택해주세요.");
                comboStore.Select();
                return;
            }
            orderControll.Storecon.addItem(new Store(name, manager, phone, address));
            MessageBox.Show("약국 정보가 추가되었습니다");
            orderStoreOk.Enabled = false;
        }

        private void orderStoreInit_Click(object sender, EventArgs e)
        {
            orderStoreName.Text=null;
            orderStoreManager.Text = null;
            orderStorePhone.Text = null;
            orderStoreAddress.Text = null;
            picBox.Image = null;
        }
    }
}

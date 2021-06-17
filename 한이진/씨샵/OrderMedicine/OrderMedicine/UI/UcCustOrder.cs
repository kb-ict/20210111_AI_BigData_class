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
    partial class UcCustOrder : UserControl
    {
        string pid;
        string mediName;
        string effect;
        string taking;
        string price;
        
        OrderControll orderControll;
        public UcCustOrder()
        {
            InitializeComponent();
        }
        public UcCustOrder(OrderControll orderControll)
        {
            InitializeComponent();
            this.orderControll = orderControll;
        }
        private void comboSyptom_SelectedIndexChanged(object sender, EventArgs e)
        {
            effect = showOrderCombo(sender);
            selectEffect.Text = effect;
            selectEffect.ForeColor = Color.BlueViolet;
            switch (effect)
            {
                case "두통":
                    MessageBox.Show("카테고리 '두통'에서 약을 선택하세요.");
                    break;
                case "감기":
                    MessageBox.Show("카테고리 '감기'에서 약을 선택하세요.");
                    break;
                case "소화불량":
                    MessageBox.Show("카테고리 '소화불량'에서 약을 선택하세요.");
                    break;
                case "근육통":
                    MessageBox.Show("카테고리 '근육통'에서 약을 선택하세요.");
                    break;
                case "피부질환":
                    MessageBox.Show("카테고리 '피부질환'에서 약을 선택하세요.");
                    break;
            }
        }
        private void comboHeadache_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediName = showOrderCombo(sender);
            selectName.Text = mediName;
            selectName.ForeColor = Color.Blue;
            switch(mediName)
            {
                case "타이레놀정 500mg":
                    picBox.Image = Properties.Resources.타이레놀정_500mg;
                    pid = "199303108";
                    effect = "두통";
                    taking = "1회 1~2정씩 1일 3-4회 (4-6시간 마다)필요시 복용한다.";
                    price = "3100";
                    selectPid.Text = pid;
                    //selectEffect.Text = effect;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "타이레놀정160mg":
                    picBox.Image = Properties.Resources.타이레놀정160mg;
                    pid = "199402278";
                    effect = "두통";
                    taking = "1회 권장용량을 4-6시간마다 필요시 복용한다.";
                    price = "2500";
                    selectPid.Text = pid;
                    //selectEffect.Text = effect;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "어린이용타이레놀정 80mg":
                    picBox.Image = Properties.Resources.어린이용타이레놀정_80mg;
                    pid = "199303109";
                    effect = "두통";
                    taking = "1회 권장용량을 4-6시간마다 필요시 복용한다.";
                    price = "2100";
                    selectPid.Text = pid;
                    //selectEffect.Text = effect;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "어린이타이레놀현탁액":
                    picBox.Image = Properties.Resources.어린이타이레놀현탁액;
                    pid = "199603002";
                    effect = "두통";
                    taking = "1회 권장용량을 4-6시간마다 필요시 복용한다.";
                    price = "6750";
                    selectPid.Text = pid;
                    //selectEffect.Text = effect;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
            }
        }

        private void comboCold_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediName = showOrderCombo(sender);
            selectName.Text = mediName;
            selectName.ForeColor = Color.Blue;
            switch(mediName)
            {
                case "판콜에이내복액":
                    picBox.Image = Properties.Resources.판콜에이내복액;
                    pid = "196800036";
                    effect = "감기";
                    taking = "성인 1회 30ml 1일 3회 식후 30분에 복용한다.";
                    price = "2600";
                    selectPid.Text = pid;
                    //selectEffect.Text = effect;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "판피린티정":
                    picBox.Image = Properties.Resources.판피린티정;
                    pid = "199400202";
                    effect = "감기";
                    taking = "성인 1회 1정, 1일 3회 식후 30분에 복용";
                    price = "1800";
                    selectPid.Text = pid;
                    //selectEffect.Text = effect;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
            }
        }

        private void comboStomache_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediName = showOrderCombo(sender);
            selectName.Text = mediName;
            selectName.ForeColor = Color.Blue;
            switch(mediName)
            {
                case "베아제정":
                    picBox.Image = Properties.Resources.베아제정;
                    pid = "198700405";
                    effect = "소화불량";
                    taking = "성인 1회 1정 1일 3회 식후에 복용한다.";
                    price = "1800";
                    selectPid.Text = pid;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "닥터베아제정":
                    picBox.Image = Properties.Resources.닥터베아제정;
                    pid = "200300406";
                    effect = "소화불량";
                    taking = "성인 1회 1정을 1일 3회 식후 복용한다.";
                    price = "2000";
                    selectPid.Text = pid;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "훼스탈골드정":
                    picBox.Image = Properties.Resources.훼스탈골드정;
                    pid = "199900926";
                    effect = "소화불량";
                    taking = "성인 1회 1정, 1일 3회 식사 후 씹지 말고 복용한다.";
                    price = "2300";
                    selectPid.Text = pid;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "훼스탈플러스정":
                    picBox.Image = Properties.Resources.훼스탈플러스정;
                    pid = "199801026";
                    effect = "소화불량";
                    taking = "성인 1회 1-2정, 소아(만 8세~만15세미만) 1회 1정, 1일 3회, 식사 후 씹지 말고 복용한다";
                    price = "2100";
                    selectPid.Text = pid;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;

            }
        }

        private void comboMuscle_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediName = showOrderCombo(sender);
            selectName.Text = mediName;
            selectName.ForeColor = Color.Blue;
            switch(mediName)
            {
                case "제일쿨파프":
                    picBox.Image = Properties.Resources.제일쿨파프;
                    pid = "A04201891";
                    effect = "근육통";
                    taking = "1일 1~2회 환부(질환 부위)에 부착한다.";
                    price = "3000";
                    selectPid.Text = pid;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "신신파스아렉스":
                    picBox.Image = Properties.Resources.신신파스아렉스;
                    pid = "200501321";
                    effect = "근육통";
                    taking = "1일 1~2회 환부(질환 부위)에 부착한다.";
                    price = "3500";
                    selectPid.Text = pid;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
            }
        }

        private void comboSkin_SelectedIndexChanged(object sender, EventArgs e)
        {
            mediName = showOrderCombo(sender);
            selectName.Text = mediName;
            selectName.ForeColor = Color.Blue;
            switch (mediName)
            {
                case "후시딘히드로연고":
                    picBox.Image = Properties.Resources.후시딘히드로연고;
                    pid = "200300546";
                    effect = "피부질환";
                    taking = "1일 3회 적당량을 환부에 부드럽게 바른다.";
                    price = "4500";
                    selectPid.Text = pid;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
                case "복합마데카솔연고":
                    picBox.Image = Properties.Resources.복합마데카솔연고; ;
                    pid = "199300117";
                    effect = "피부질환";
                    taking = "1일 1～2회 적당량을 환부에 바른다.";
                    price = "4500";
                    selectPid.Text = pid;
                    selectTaking.Text = taking;
                    selectPrice.Text = price;
                    break;
            }
        }

        private void ucCustOrderOk_Click(object sender, EventArgs e)
        {
            if (effect == null)
            {
                MessageBox.Show("증상을 선택해주세요.");
                comboSyptom.Select();
                return;
            }
            if (mediName == null)
            {
                MessageBox.Show("약품을 선택해주세요.");
                comboSyptom.Select();
                return;
            }

            orderControll.Medicon.addItem(new Medicine(pid, mediName, effect, taking, price));
            MessageBox.Show("주문할 약품 정보가 저장");
            ucCustOrderOk.Enabled = false;

        }

        
        private string showOrderCombo(object obj)
        {
             System.Windows.Forms.ComboBox cb= obj as System.Windows.Forms.ComboBox;
            Console.WriteLine("index: " + cb.SelectedIndex);
            string item = cb.SelectedItem.ToString();
            if(cb.SelectedIndex>-1)
            {
                Console.WriteLine("선택: " + item);
            }return item;
        }

        private void ucCustOrderInit_Click(object sender, EventArgs e)
        {
            pid = null;
            mediName = null;
            effect = null;
            taking = null;
            price = null;

            comboSyptom.SelectedIndex = 0;
            comboHeadache.SelectedIndex = 0;
            comboCold.SelectedIndex = 0;
            comboMuscle.SelectedIndex = 0;
            comboSkin.SelectedIndex = 0;
            comboStomache.SelectedIndex = 0;
            selectEffect.Clear();
            selectName.Clear();
            selectPid.Clear();
            selectPrice.Clear();
            selectTaking.Clear();
            MessageBox.Show("입력 정보 초기화 하였습니다.");
        }
    }
}

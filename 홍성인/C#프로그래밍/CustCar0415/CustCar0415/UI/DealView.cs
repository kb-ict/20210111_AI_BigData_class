using CustCar0415.Controll;
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
    public partial class DealView : MaterialForm
    {
        UnionController temp;
        public DealView()
        {
            InitializeComponent();
        }

        private void initDealSmListView()
        {
            //string[] data = { "1", "그란카브리오", "2억5천만원", "홍성인", "전우치", "2021년4월16일", "2억3천만원" };
            //dealSmListview.Items.Add(new ListViewItem(data));
            //for (int i=0; i<50; i++)
            if (temp.listUn == null || temp.listUn.Count == 0)
                return;
            for (int i = 0; i < temp.listUn.Count; i++)
            {
                dealSmListview.Items.Add(new ListViewItem(new string[]
                {
                    (i+1).ToString(),
                    temp.listUn[i].Car.Model,
                    temp.listUn[i].Car.Price,
                    temp.listUn[i].Customer.Name,
                    temp.listUn[i].Seller.Name,
                    temp.listUn[i].Date,
                    temp.listUn[i].Price
                }
                ));

            }
            // 색 넣기
            setRowColor(Color.White, Color.LightBlue);

            int index = dealSmListview.Items.Count - 1;
            dealSmListview.Items[index].Selected = true;
            dealSmListview.Items[index].Focused = true;
            dealSmListview.EnsureVisible(index);
        }

        private void DealView_Load(object sender, EventArgs e)
        {
            initDealSmListView();
        }

        private void dealSmExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setRowColor(Color color1, Color color2)
        {
            foreach (ListViewItem item in dealSmListview.Items)
            {
                // 짝수 라인
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                // 홀수 라인
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        internal void addSome(UnionController uHandler)
        {
            temp = uHandler;
        }
    }
}

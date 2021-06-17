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

namespace OrderMedicine.UI
{
    public partial class StoMain : MaterialForm
    {
        public StoMain()
        {
            InitializeComponent();
        }

        private void stoMainExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


namespace OrderMedicine.UI
{
    partial class CustMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.custMainExit = new Sunny.UI.UISymbolButton();
            this.topLayout = new System.Windows.Forms.Panel();
            this.custMainQ = new Sunny.UI.UISymbolButton();
            this.custExit = new Sunny.UI.UISymbolButton();
            this.leftLayout = new System.Windows.Forms.Panel();
            this.orderAddStore = new Sunny.UI.UIHeaderButton();
            this.custMainOrder = new Sunny.UI.UIHeaderButton();
            this.orderDataView = new Sunny.UI.UIHeaderButton();
            this.orderAddData = new Sunny.UI.UIHeaderButton();
            this.custAddDataBtn = new Sunny.UI.UIHeaderButton();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.topLayout.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // custMainExit
            // 
            this.custMainExit.BackColor = System.Drawing.Color.Transparent;
            this.custMainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custMainExit.FillColor = System.Drawing.Color.DarkRed;
            this.custMainExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.custMainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMainExit.Location = new System.Drawing.Point(867, 29);
            this.custMainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.custMainExit.Name = "custMainExit";
            this.custMainExit.RectColor = System.Drawing.Color.Transparent;
            this.custMainExit.Size = new System.Drawing.Size(31, 31);
            this.custMainExit.Style = Sunny.UI.UIStyle.Custom;
            this.custMainExit.Symbol = 61453;
            this.custMainExit.SymbolSize = 30;
            this.custMainExit.TabIndex = 4;
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            this.topLayout.Controls.Add(this.custMainQ);
            this.topLayout.Controls.Add(this.custExit);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(910, 60);
            this.topLayout.TabIndex = 8;
            // 
            // custMainQ
            // 
            this.custMainQ.BackColor = System.Drawing.Color.Transparent;
            this.custMainQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custMainQ.FillColor = System.Drawing.Color.Orange;
            this.custMainQ.FillDisableColor = System.Drawing.Color.Transparent;
            this.custMainQ.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMainQ.Location = new System.Drawing.Point(830, 12);
            this.custMainQ.MinimumSize = new System.Drawing.Size(1, 1);
            this.custMainQ.Name = "custMainQ";
            this.custMainQ.RectColor = System.Drawing.Color.Transparent;
            this.custMainQ.Size = new System.Drawing.Size(31, 31);
            this.custMainQ.Style = Sunny.UI.UIStyle.Custom;
            this.custMainQ.Symbol = 61736;
            this.custMainQ.SymbolSize = 30;
            this.custMainQ.TabIndex = 6;
            this.custMainQ.Click += new System.EventHandler(this.custMainQ_Click);
            // 
            // custExit
            // 
            this.custExit.BackColor = System.Drawing.Color.Transparent;
            this.custExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custExit.FillColor = System.Drawing.Color.DarkRed;
            this.custExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.custExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custExit.Location = new System.Drawing.Point(867, 12);
            this.custExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.custExit.Name = "custExit";
            this.custExit.RectColor = System.Drawing.Color.Transparent;
            this.custExit.Size = new System.Drawing.Size(31, 31);
            this.custExit.Style = Sunny.UI.UIStyle.Custom;
            this.custExit.Symbol = 61453;
            this.custExit.SymbolSize = 30;
            this.custExit.TabIndex = 5;
            this.custExit.Click += new System.EventHandler(this.custExit_Click);
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.Color.Transparent;
            this.leftLayout.Controls.Add(this.orderDataView);
            this.leftLayout.Controls.Add(this.orderAddStore);
            this.leftLayout.Controls.Add(this.custMainOrder);
            this.leftLayout.Controls.Add(this.orderAddData);
            this.leftLayout.Controls.Add(this.custAddDataBtn);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 60);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(196, 535);
            this.leftLayout.TabIndex = 9;
            // 
            // orderAddStore
            // 
            this.orderAddStore.CircleColor = System.Drawing.Color.Transparent;
            this.orderAddStore.FillColor = System.Drawing.Color.SteelBlue;
            this.orderAddStore.FillHoverColor = System.Drawing.Color.LightCoral;
            this.orderAddStore.FillPressColor = System.Drawing.Color.Salmon;
            this.orderAddStore.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderAddStore.Location = new System.Drawing.Point(0, 219);
            this.orderAddStore.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderAddStore.Name = "orderAddStore";
            this.orderAddStore.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.orderAddStore.Radius = 0;
            this.orderAddStore.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.orderAddStore.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.orderAddStore.Size = new System.Drawing.Size(196, 105);
            this.orderAddStore.Style = Sunny.UI.UIStyle.Custom;
            this.orderAddStore.Symbol = 57353;
            this.orderAddStore.TabIndex = 4;
            this.orderAddStore.Text = "약국 정보 추가";
            this.orderAddStore.Click += new System.EventHandler(this.orderAddStore_Click);
            // 
            // custMainOrder
            // 
            this.custMainOrder.CircleColor = System.Drawing.Color.Transparent;
            this.custMainOrder.FillColor = System.Drawing.Color.LightSeaGreen;
            this.custMainOrder.FillHoverColor = System.Drawing.Color.IndianRed;
            this.custMainOrder.FillSelectedColor = System.Drawing.Color.IndianRed;
            this.custMainOrder.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custMainOrder.Location = new System.Drawing.Point(0, 438);
            this.custMainOrder.MinimumSize = new System.Drawing.Size(1, 1);
            this.custMainOrder.Name = "custMainOrder";
            this.custMainOrder.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.custMainOrder.Radius = 0;
            this.custMainOrder.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.custMainOrder.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.custMainOrder.Size = new System.Drawing.Size(196, 97);
            this.custMainOrder.Style = Sunny.UI.UIStyle.Custom;
            this.custMainOrder.Symbol = 61976;
            this.custMainOrder.TabIndex = 3;
            this.custMainOrder.Text = "주문 등록";
            this.custMainOrder.Click += new System.EventHandler(this.custMainOrder_Click);
            // 
            // orderDataView
            // 
            this.orderDataView.CircleColor = System.Drawing.Color.Transparent;
            this.orderDataView.FillColor = System.Drawing.Color.SteelBlue;
            this.orderDataView.FillHoverColor = System.Drawing.Color.LightCoral;
            this.orderDataView.FillPressColor = System.Drawing.Color.Salmon;
            this.orderDataView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderDataView.Location = new System.Drawing.Point(0, 327);
            this.orderDataView.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderDataView.Name = "orderDataView";
            this.orderDataView.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.orderDataView.Radius = 0;
            this.orderDataView.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.orderDataView.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.orderDataView.Size = new System.Drawing.Size(196, 105);
            this.orderDataView.Style = Sunny.UI.UIStyle.Custom;
            this.orderDataView.Symbol = 104;
            this.orderDataView.TabIndex = 2;
            this.orderDataView.Text = "주문 내역 조회";
            this.orderDataView.Click += new System.EventHandler(this.orderDataView_Click);
            // 
            // orderAddData
            // 
            this.orderAddData.CircleColor = System.Drawing.Color.Transparent;
            this.orderAddData.FillColor = System.Drawing.Color.SteelBlue;
            this.orderAddData.FillHoverColor = System.Drawing.Color.LightCoral;
            this.orderAddData.FillPressColor = System.Drawing.Color.Salmon;
            this.orderAddData.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderAddData.Location = new System.Drawing.Point(0, 111);
            this.orderAddData.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderAddData.Name = "orderAddData";
            this.orderAddData.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.orderAddData.Radius = 0;
            this.orderAddData.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.orderAddData.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.orderAddData.Size = new System.Drawing.Size(196, 105);
            this.orderAddData.Style = Sunny.UI.UIStyle.Custom;
            this.orderAddData.Symbol = 61690;
            this.orderAddData.TabIndex = 1;
            this.orderAddData.Text = "주문 약품 추가";
            this.orderAddData.Click += new System.EventHandler(this.orderAddData_Click);
            // 
            // custAddDataBtn
            // 
            this.custAddDataBtn.CircleColor = System.Drawing.Color.Transparent;
            this.custAddDataBtn.FillColor = System.Drawing.Color.SteelBlue;
            this.custAddDataBtn.FillHoverColor = System.Drawing.Color.LightCoral;
            this.custAddDataBtn.FillSelectedColor = System.Drawing.Color.Salmon;
            this.custAddDataBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddDataBtn.Location = new System.Drawing.Point(0, 3);
            this.custAddDataBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddDataBtn.Name = "custAddDataBtn";
            this.custAddDataBtn.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.custAddDataBtn.Radius = 0;
            this.custAddDataBtn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.custAddDataBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.custAddDataBtn.Size = new System.Drawing.Size(196, 105);
            this.custAddDataBtn.Style = Sunny.UI.UIStyle.Custom;
            this.custAddDataBtn.Symbol = 62142;
            this.custAddDataBtn.TabIndex = 0;
            this.custAddDataBtn.Text = "고객 정보 추가";
            this.custAddDataBtn.Click += new System.EventHandler(this.custAddDataBtn_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(196, 60);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(714, 535);
            this.centerLayout.TabIndex = 10;
            // 
            // CustMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 595);
            this.ControlBox = false;
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayout);
            this.Controls.Add(this.custMainExit);
            this.Name = "CustMain";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "customer";
            this.topLayout.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton custMainExit;
        private System.Windows.Forms.Panel topLayout;
        private System.Windows.Forms.Panel leftLayout;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UIHeaderButton custMainOrder;
        private Sunny.UI.UIHeaderButton orderDataView;
        private Sunny.UI.UIHeaderButton orderAddData;
        private Sunny.UI.UIHeaderButton custAddDataBtn;
        private Sunny.UI.UIHeaderButton orderAddStore;
        private Sunny.UI.UISymbolButton custMainQ;
        private Sunny.UI.UISymbolButton custExit;
    }
}

namespace CustCar0415.UI
{
    partial class AddData
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
            this.topLayout = new System.Windows.Forms.Panel();
            this.addDataStatus = new Sunny.UI.UISymbolLabel();
            this.addDatatExit = new Sunny.UI.UISymbolButton();
            this.leftLayout = new System.Windows.Forms.Panel();
            this.sellAddDataBtn = new Sunny.UI.UIHeaderButton();
            this.addDataDeal = new Sunny.UI.UIHeaderButton();
            this.custAddDataBtn = new Sunny.UI.UIHeaderButton();
            this.carAddDataBtn = new Sunny.UI.UIHeaderButton();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.topLayout.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLayout
            // 
            this.topLayout.BackColor = System.Drawing.Color.Transparent;
            this.topLayout.Controls.Add(this.addDataStatus);
            this.topLayout.Controls.Add(this.addDatatExit);
            this.topLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayout.Location = new System.Drawing.Point(0, 0);
            this.topLayout.Name = "topLayout";
            this.topLayout.Size = new System.Drawing.Size(989, 64);
            this.topLayout.TabIndex = 0;
            this.topLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLayout_MouseMove);
            // 
            // addDataStatus
            // 
            this.addDataStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataStatus.ForeColor = System.Drawing.Color.White;
            this.addDataStatus.Location = new System.Drawing.Point(12, 25);
            this.addDataStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataStatus.Name = "addDataStatus";
            this.addDataStatus.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.addDataStatus.Size = new System.Drawing.Size(566, 39);
            this.addDataStatus.Style = Sunny.UI.UIStyle.Custom;
            this.addDataStatus.Symbol = 122;
            this.addDataStatus.SymbolColor = System.Drawing.Color.White;
            this.addDataStatus.TabIndex = 17;
            this.addDataStatus.Text = "상태 정보";
            this.addDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addDatatExit
            // 
            this.addDatatExit.BackColor = System.Drawing.Color.Transparent;
            this.addDatatExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDatatExit.FillColor = System.Drawing.Color.DarkRed;
            this.addDatatExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDatatExit.Location = new System.Drawing.Point(943, 12);
            this.addDatatExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDatatExit.Name = "addDatatExit";
            this.addDatatExit.RectColor = System.Drawing.Color.SteelBlue;
            this.addDatatExit.Size = new System.Drawing.Size(34, 32);
            this.addDatatExit.Style = Sunny.UI.UIStyle.Custom;
            this.addDatatExit.Symbol = 61453;
            this.addDatatExit.TabIndex = 16;
            this.addDatatExit.Click += new System.EventHandler(this.addDatatExit_Click);
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.Color.Transparent;
            this.leftLayout.Controls.Add(this.sellAddDataBtn);
            this.leftLayout.Controls.Add(this.addDataDeal);
            this.leftLayout.Controls.Add(this.custAddDataBtn);
            this.leftLayout.Controls.Add(this.carAddDataBtn);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 64);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(201, 535);
            this.leftLayout.TabIndex = 1;
            // 
            // sellAddDataBtn
            // 
            this.sellAddDataBtn.CircleColor = System.Drawing.Color.Transparent;
            this.sellAddDataBtn.CircleSize = 100;
            this.sellAddDataBtn.FillColor = System.Drawing.Color.SteelBlue;
            this.sellAddDataBtn.FillHoverColor = System.Drawing.Color.IndianRed;
            this.sellAddDataBtn.FillPressColor = System.Drawing.Color.LightCoral;
            this.sellAddDataBtn.FillSelectedColor = System.Drawing.Color.LightCoral;
            this.sellAddDataBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellAddDataBtn.Location = new System.Drawing.Point(0, 276);
            this.sellAddDataBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.sellAddDataBtn.Name = "sellAddDataBtn";
            this.sellAddDataBtn.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.sellAddDataBtn.Radius = 0;
            this.sellAddDataBtn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.sellAddDataBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.sellAddDataBtn.Size = new System.Drawing.Size(201, 132);
            this.sellAddDataBtn.Style = Sunny.UI.UIStyle.Custom;
            this.sellAddDataBtn.Symbol = 62140;
            this.sellAddDataBtn.TabIndex = 3;
            this.sellAddDataBtn.Text = "판매자 정보 등록";
            this.sellAddDataBtn.Click += new System.EventHandler(this.sellAddDataBtn_Click);
            // 
            // addDataDeal
            // 
            this.addDataDeal.CircleColor = System.Drawing.Color.Transparent;
            this.addDataDeal.CircleSize = 100;
            this.addDataDeal.FillColor = System.Drawing.Color.LightSeaGreen;
            this.addDataDeal.FillHoverColor = System.Drawing.Color.IndianRed;
            this.addDataDeal.FillPressColor = System.Drawing.Color.LightCoral;
            this.addDataDeal.FillSelectedColor = System.Drawing.Color.LightCoral;
            this.addDataDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataDeal.Location = new System.Drawing.Point(0, 414);
            this.addDataDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataDeal.Name = "addDataDeal";
            this.addDataDeal.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataDeal.Radius = 0;
            this.addDataDeal.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataDeal.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataDeal.Size = new System.Drawing.Size(201, 120);
            this.addDataDeal.Style = Sunny.UI.UIStyle.Custom;
            this.addDataDeal.Symbol = 57490;
            this.addDataDeal.TabIndex = 2;
            this.addDataDeal.Text = "거래 등록";
            this.addDataDeal.Click += new System.EventHandler(this.addDataDeal_Click);
            // 
            // custAddDataBtn
            // 
            this.custAddDataBtn.CircleColor = System.Drawing.Color.Transparent;
            this.custAddDataBtn.CircleSize = 100;
            this.custAddDataBtn.FillColor = System.Drawing.Color.SteelBlue;
            this.custAddDataBtn.FillHoverColor = System.Drawing.Color.IndianRed;
            this.custAddDataBtn.FillPressColor = System.Drawing.Color.LightCoral;
            this.custAddDataBtn.FillSelectedColor = System.Drawing.Color.LightCoral;
            this.custAddDataBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custAddDataBtn.Location = new System.Drawing.Point(0, 138);
            this.custAddDataBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddDataBtn.Name = "custAddDataBtn";
            this.custAddDataBtn.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.custAddDataBtn.Radius = 0;
            this.custAddDataBtn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.custAddDataBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.custAddDataBtn.Size = new System.Drawing.Size(201, 132);
            this.custAddDataBtn.Style = Sunny.UI.UIStyle.Custom;
            this.custAddDataBtn.Symbol = 62142;
            this.custAddDataBtn.TabIndex = 1;
            this.custAddDataBtn.Text = "고객 정보 등록";
            this.custAddDataBtn.Click += new System.EventHandler(this.custAddDataBtn_Click);
            // 
            // carAddDataBtn
            // 
            this.carAddDataBtn.CircleColor = System.Drawing.Color.Transparent;
            this.carAddDataBtn.CircleSize = 100;
            this.carAddDataBtn.FillColor = System.Drawing.Color.SteelBlue;
            this.carAddDataBtn.FillHoverColor = System.Drawing.Color.IndianRed;
            this.carAddDataBtn.FillPressColor = System.Drawing.Color.LightCoral;
            this.carAddDataBtn.FillSelectedColor = System.Drawing.Color.LightCoral;
            this.carAddDataBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carAddDataBtn.Location = new System.Drawing.Point(0, 0);
            this.carAddDataBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.carAddDataBtn.Name = "carAddDataBtn";
            this.carAddDataBtn.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.carAddDataBtn.Radius = 0;
            this.carAddDataBtn.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.carAddDataBtn.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.carAddDataBtn.Size = new System.Drawing.Size(201, 132);
            this.carAddDataBtn.Style = Sunny.UI.UIStyle.Custom;
            this.carAddDataBtn.Symbol = 61881;
            this.carAddDataBtn.TabIndex = 0;
            this.carAddDataBtn.Text = "차량 정보 등록";
            this.carAddDataBtn.Click += new System.EventHandler(this.carAddDataBtn_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(201, 64);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(788, 535);
            this.centerLayout.TabIndex = 2;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 599);
            this.ControlBox = false;
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayout);
            this.Name = "AddData";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.topLayout.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLayout;
        private System.Windows.Forms.Panel leftLayout;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton addDatatExit;
        private Sunny.UI.UIHeaderButton addDataDeal;
        private Sunny.UI.UIHeaderButton custAddDataBtn;
        private Sunny.UI.UIHeaderButton carAddDataBtn;
        private Sunny.UI.UIHeaderButton sellAddDataBtn;
        private Sunny.UI.UISymbolLabel addDataStatus;
    }
}
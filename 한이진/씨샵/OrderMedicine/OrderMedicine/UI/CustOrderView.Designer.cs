
namespace OrderMedicine.UI
{
    partial class CustOrderView
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
            this.orderViewMedi = new System.Windows.Forms.ListView();
            this.colMediPid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediEffect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediTaking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderview = new System.Windows.Forms.ListView();
            this.colCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustSymtom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMedicine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMedicinePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStoreName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.custOrderViewExit = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // orderViewMedi
            // 
            this.orderViewMedi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMediPid,
            this.colMediName,
            this.colMediEffect,
            this.colMediTaking,
            this.colMediPrice});
            this.orderViewMedi.HideSelection = false;
            this.orderViewMedi.Location = new System.Drawing.Point(12, 106);
            this.orderViewMedi.Name = "orderViewMedi";
            this.orderViewMedi.Size = new System.Drawing.Size(652, 167);
            this.orderViewMedi.TabIndex = 4;
            this.orderViewMedi.UseCompatibleStateImageBehavior = false;
            this.orderViewMedi.View = System.Windows.Forms.View.Details;
            // 
            // colMediPid
            // 
            this.colMediPid.Text = "제품코드";
            this.colMediPid.Width = 77;
            // 
            // colMediName
            // 
            this.colMediName.Text = "약품명";
            this.colMediName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMediName.Width = 131;
            // 
            // colMediEffect
            // 
            this.colMediEffect.Text = "효과";
            this.colMediEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMediEffect.Width = 68;
            // 
            // colMediTaking
            // 
            this.colMediTaking.Text = "복용법";
            this.colMediTaking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMediTaking.Width = 271;
            // 
            // colMediPrice
            // 
            this.colMediPrice.Text = "가격";
            this.colMediPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMediPrice.Width = 101;
            // 
            // orderview
            // 
            this.orderview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustName,
            this.colCustSymtom,
            this.colMedicine,
            this.colMedicinePrice,
            this.colStoreName});
            this.orderview.HideSelection = false;
            this.orderview.Location = new System.Drawing.Point(12, 315);
            this.orderview.Name = "orderview";
            this.orderview.Size = new System.Drawing.Size(652, 176);
            this.orderview.TabIndex = 6;
            this.orderview.UseCompatibleStateImageBehavior = false;
            this.orderview.View = System.Windows.Forms.View.Details;
            // 
            // colCustName
            // 
            this.colCustName.Text = "고객이름";
            this.colCustName.Width = 82;
            // 
            // colCustSymtom
            // 
            this.colCustSymtom.Text = "증상";
            this.colCustSymtom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colCustSymtom.Width = 131;
            // 
            // colMedicine
            // 
            this.colMedicine.Text = "약품명";
            this.colMedicine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMedicine.Width = 186;
            // 
            // colMedicinePrice
            // 
            this.colMedicinePrice.Text = "가격";
            this.colMedicinePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMedicinePrice.Width = 119;
            // 
            // colStoreName
            // 
            this.colStoreName.Text = "약국명";
            this.colStoreName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStoreName.Width = 135;
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 67);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(180, 19);
            this.uiSymbolLabel1.Symbol = 61690;
            this.uiSymbolLabel1.TabIndex = 5;
            this.uiSymbolLabel1.Text = "주문 약품 상세보기";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(12, 279);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(145, 19);
            this.uiSymbolLabel2.Symbol = 57365;
            this.uiSymbolLabel2.TabIndex = 7;
            this.uiSymbolLabel2.Text = "주문 내역 보기";
            // 
            // custOrderViewExit
            // 
            this.custOrderViewExit.BackColor = System.Drawing.Color.Transparent;
            this.custOrderViewExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custOrderViewExit.FillColor = System.Drawing.Color.DarkRed;
            this.custOrderViewExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.custOrderViewExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custOrderViewExit.Location = new System.Drawing.Point(650, 27);
            this.custOrderViewExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.custOrderViewExit.Name = "custOrderViewExit";
            this.custOrderViewExit.RectColor = System.Drawing.Color.Transparent;
            this.custOrderViewExit.Size = new System.Drawing.Size(31, 31);
            this.custOrderViewExit.Style = Sunny.UI.UIStyle.Custom;
            this.custOrderViewExit.Symbol = 61453;
            this.custOrderViewExit.SymbolSize = 30;
            this.custOrderViewExit.TabIndex = 8;
            this.custOrderViewExit.Click += new System.EventHandler(this.custOrderViewExit_Click);
            // 
            // CustOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 514);
            this.ControlBox = false;
            this.Controls.Add(this.custOrderViewExit);
            this.Controls.Add(this.orderViewMedi);
            this.Controls.Add(this.orderview);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Name = "CustOrderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustOrderView";
            this.Load += new System.EventHandler(this.CustOrderView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView orderViewMedi;
        private System.Windows.Forms.ColumnHeader colMediPid;
        private System.Windows.Forms.ColumnHeader colMediName;
        private System.Windows.Forms.ColumnHeader colMediEffect;
        private System.Windows.Forms.ColumnHeader colMediTaking;
        private System.Windows.Forms.ColumnHeader colMediPrice;
        private System.Windows.Forms.ListView orderview;
        private System.Windows.Forms.ColumnHeader colCustName;
        private System.Windows.Forms.ColumnHeader colCustSymtom;
        private System.Windows.Forms.ColumnHeader colMedicine;
        private System.Windows.Forms.ColumnHeader colMedicinePrice;
        private System.Windows.Forms.ColumnHeader colStoreName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton custOrderViewExit;
    }
}
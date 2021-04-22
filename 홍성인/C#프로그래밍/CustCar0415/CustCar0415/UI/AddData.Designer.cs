
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
            this.topLayer = new System.Windows.Forms.Panel();
            this.addDataExit = new Sunny.UI.UISymbolButton();
            this.leftLayout = new System.Windows.Forms.Panel();
            this.addDataCancel = new Sunny.UI.UIHeaderButton();
            this.addDataSell = new Sunny.UI.UIHeaderButton();
            this.addDataCust = new Sunny.UI.UIHeaderButton();
            this.addDataCar = new Sunny.UI.UIHeaderButton();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.addDataStatus = new Sunny.UI.UISymbolLabel();
            this.topLayer.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLayer
            // 
            this.topLayer.BackColor = System.Drawing.Color.Transparent;
            this.topLayer.Controls.Add(this.addDataStatus);
            this.topLayer.Controls.Add(this.addDataExit);
            this.topLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayer.Location = new System.Drawing.Point(0, 0);
            this.topLayer.Name = "topLayer";
            this.topLayer.Size = new System.Drawing.Size(1350, 85);
            this.topLayer.TabIndex = 0;
            this.topLayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLayer_MouseMove);
            // 
            // addDataExit
            // 
            this.addDataExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDataExit.FillColor = System.Drawing.Color.Red;
            this.addDataExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataExit.Location = new System.Drawing.Point(1268, 12);
            this.addDataExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataExit.Name = "addDataExit";
            this.addDataExit.RectColor = System.Drawing.Color.Red;
            this.addDataExit.Size = new System.Drawing.Size(57, 54);
            this.addDataExit.Style = Sunny.UI.UIStyle.Custom;
            this.addDataExit.Symbol = 61453;
            this.addDataExit.SymbolSize = 40;
            this.addDataExit.TabIndex = 16;
            this.addDataExit.Click += new System.EventHandler(this.addDataExit_Click);
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.Color.Transparent;
            this.leftLayout.Controls.Add(this.addDataCancel);
            this.leftLayout.Controls.Add(this.addDataSell);
            this.leftLayout.Controls.Add(this.addDataCust);
            this.leftLayout.Controls.Add(this.addDataCar);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 85);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(218, 707);
            this.leftLayout.TabIndex = 1;
            // 
            // addDataCancel
            // 
            this.addDataCancel.CircleColor = System.Drawing.Color.Transparent;
            this.addDataCancel.CircleSize = 100;
            this.addDataCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addDataCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addDataCancel.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataCancel.Location = new System.Drawing.Point(3, 532);
            this.addDataCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataCancel.Name = "addDataCancel";
            this.addDataCancel.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataCancel.Radius = 0;
            this.addDataCancel.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataCancel.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataCancel.Size = new System.Drawing.Size(209, 172);
            this.addDataCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addDataCancel.Symbol = 61457;
            this.addDataCancel.TabIndex = 2;
            this.addDataCancel.Text = "종료";
            this.addDataCancel.Click += new System.EventHandler(this.addDataExit_Click);
            // 
            // addDataSell
            // 
            this.addDataSell.CircleColor = System.Drawing.Color.Transparent;
            this.addDataSell.CircleSize = 100;
            this.addDataSell.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addDataSell.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addDataSell.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataSell.Location = new System.Drawing.Point(3, 354);
            this.addDataSell.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataSell.Name = "addDataSell";
            this.addDataSell.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataSell.Radius = 0;
            this.addDataSell.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataSell.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataSell.Size = new System.Drawing.Size(209, 172);
            this.addDataSell.Style = Sunny.UI.UIStyle.Custom;
            this.addDataSell.Symbol = 62144;
            this.addDataSell.TabIndex = 1;
            this.addDataSell.Text = "판매자 정보 등록";
            this.addDataSell.Click += new System.EventHandler(this.addDataSell_Click);
            // 
            // addDataCust
            // 
            this.addDataCust.CircleColor = System.Drawing.Color.Transparent;
            this.addDataCust.CircleSize = 100;
            this.addDataCust.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addDataCust.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addDataCust.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataCust.Location = new System.Drawing.Point(3, 180);
            this.addDataCust.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataCust.Name = "addDataCust";
            this.addDataCust.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataCust.Radius = 0;
            this.addDataCust.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataCust.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataCust.Size = new System.Drawing.Size(209, 172);
            this.addDataCust.Style = Sunny.UI.UIStyle.Custom;
            this.addDataCust.Symbol = 61447;
            this.addDataCust.TabIndex = 1;
            this.addDataCust.Text = "고객 정보 등록";
            this.addDataCust.Click += new System.EventHandler(this.addDataCust_Click);
            // 
            // addDataCar
            // 
            this.addDataCar.CircleColor = System.Drawing.Color.Transparent;
            this.addDataCar.CircleSize = 100;
            this.addDataCar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.addDataCar.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.addDataCar.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDataCar.Location = new System.Drawing.Point(3, 6);
            this.addDataCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataCar.Name = "addDataCar";
            this.addDataCar.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataCar.Radius = 0;
            this.addDataCar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataCar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataCar.Size = new System.Drawing.Size(209, 172);
            this.addDataCar.Style = Sunny.UI.UIStyle.Custom;
            this.addDataCar.Symbol = 61881;
            this.addDataCar.TabIndex = 0;
            this.addDataCar.Text = "차량 정보 등록";
            this.addDataCar.Click += new System.EventHandler(this.addDataCar_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(218, 85);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(1132, 707);
            this.centerLayout.TabIndex = 2;
            // 
            // addDataStatus
            // 
            this.addDataStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataStatus.ForeColor = System.Drawing.Color.White;
            this.addDataStatus.Location = new System.Drawing.Point(28, -5);
            this.addDataStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataStatus.Name = "addDataStatus";
            this.addDataStatus.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.addDataStatus.Size = new System.Drawing.Size(888, 71);
            this.addDataStatus.Style = Sunny.UI.UIStyle.Custom;
            this.addDataStatus.Symbol = 61442;
            this.addDataStatus.SymbolColor = System.Drawing.Color.White;
            this.addDataStatus.TabIndex = 17;
            this.addDataStatus.Text = "상태 정보";
            this.addDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 792);
            this.ControlBox = false;
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayer);
            this.Name = "AddData";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.topLayer.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLayer;
        private System.Windows.Forms.Panel leftLayout;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton addDataExit;
        private Sunny.UI.UIHeaderButton addDataCar;
        private Sunny.UI.UIHeaderButton addDataSell;
        private Sunny.UI.UIHeaderButton addDataCust;
        private Sunny.UI.UIHeaderButton addDataCancel;
        private Sunny.UI.UISymbolLabel addDataStatus;
    }
}
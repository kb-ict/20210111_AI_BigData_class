
namespace CustCar0415.UI
{
    partial class DealView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dealSmListView = new System.Windows.Forms.ListView();
            this.dealSmCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmSeller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSmRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dealSm = new Sunny.UI.UIDataGridView();
            this.dealSmExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.dealviewLabel2 = new Sunny.UI.UISymbolLabel();
            this.viewLabel3 = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dealSm)).BeginInit();
            this.SuspendLayout();
            // 
            // dealSmListView
            // 
            this.dealSmListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dealSmCount,
            this.dealSmModel,
            this.dealSmPrice,
            this.dealSmName,
            this.dealSmSeller,
            this.dealSmDate,
            this.dealSmRP});
            this.dealSmListView.FullRowSelect = true;
            this.dealSmListView.HideSelection = false;
            this.dealSmListView.Location = new System.Drawing.Point(42, 106);
            this.dealSmListView.Name = "dealSmListView";
            this.dealSmListView.Size = new System.Drawing.Size(794, 215);
            this.dealSmListView.TabIndex = 0;
            this.dealSmListView.UseCompatibleStateImageBehavior = false;
            this.dealSmListView.View = System.Windows.Forms.View.Details;
            // 
            // dealSmCount
            // 
            this.dealSmCount.Text = "번호";
            // 
            // dealSmModel
            // 
            this.dealSmModel.Text = "Model";
            this.dealSmModel.Width = 111;
            // 
            // dealSmPrice
            // 
            this.dealSmPrice.Text = "price";
            this.dealSmPrice.Width = 98;
            // 
            // dealSmName
            // 
            this.dealSmName.Text = "CustomerName";
            this.dealSmName.Width = 113;
            // 
            // dealSmSeller
            // 
            this.dealSmSeller.Text = "Seller";
            this.dealSmSeller.Width = 99;
            // 
            // dealSmDate
            // 
            this.dealSmDate.Text = "Date";
            this.dealSmDate.Width = 170;
            // 
            // dealSmRP
            // 
            this.dealSmRP.Text = "RealPrice";
            this.dealSmRP.Width = 137;
            // 
            // dealSm
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dealSm.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dealSm.BackgroundColor = System.Drawing.Color.White;
            this.dealSm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dealSm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dealSm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealSm.EnableHeadersVisualStyles = false;
            this.dealSm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealSm.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dealSm.Location = new System.Drawing.Point(42, 355);
            this.dealSm.Name = "dealSm";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dealSm.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dealSm.RowTemplate.Height = 29;
            this.dealSm.SelectedIndex = -1;
            this.dealSm.ShowGridLine = true;
            this.dealSm.Size = new System.Drawing.Size(793, 215);
            this.dealSm.TabIndex = 1;
            // 
            // dealSmExit
            // 
            this.dealSmExit.BackColor = System.Drawing.Color.Transparent;
            this.dealSmExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealSmExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dealSmExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.dealSmExit.FillHoverColor = System.Drawing.Color.Transparent;
            this.dealSmExit.FillPressColor = System.Drawing.Color.Transparent;
            this.dealSmExit.FillSelectedColor = System.Drawing.Color.Transparent;
            this.dealSmExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealSmExit.ForeHoverColor = System.Drawing.Color.Brown;
            this.dealSmExit.IsCircle = true;
            this.dealSmExit.Location = new System.Drawing.Point(819, 45);
            this.dealSmExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.dealSmExit.Name = "dealSmExit";
            this.dealSmExit.Size = new System.Drawing.Size(56, 49);
            this.dealSmExit.Style = Sunny.UI.UIStyle.Custom;
            this.dealSmExit.Symbol = 61536;
            this.dealSmExit.SymbolSize = 35;
            this.dealSmExit.TabIndex = 2;
            this.dealSmExit.Click += new System.EventHandler(this.dealSmExit_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(270, 28);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(324, 31);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61442;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.Maroon;
            this.uiSymbolLabel1.TabIndex = 3;
            this.uiSymbolLabel1.Text = "차량 고객 관리 정보";
            // 
            // dealviewLabel2
            // 
            this.dealviewLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dealviewLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealviewLabel2.ForeColor = System.Drawing.Color.Teal;
            this.dealviewLabel2.Location = new System.Drawing.Point(42, 78);
            this.dealviewLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.dealviewLabel2.Name = "dealviewLabel2";
            this.dealviewLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.dealviewLabel2.Size = new System.Drawing.Size(150, 22);
            this.dealviewLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.dealviewLabel2.Symbol = 57483;
            this.dealviewLabel2.SymbolColor = System.Drawing.Color.Gray;
            this.dealviewLabel2.TabIndex = 4;
            this.dealviewLabel2.Text = "고객거래 정보";
            // 
            // viewLabel3
            // 
            this.viewLabel3.BackColor = System.Drawing.Color.Transparent;
            this.viewLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewLabel3.ForeColor = System.Drawing.Color.Indigo;
            this.viewLabel3.Location = new System.Drawing.Point(42, 327);
            this.viewLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.viewLabel3.Name = "viewLabel3";
            this.viewLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.viewLabel3.Size = new System.Drawing.Size(150, 22);
            this.viewLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.viewLabel3.Symbol = 61454;
            this.viewLabel3.SymbolColor = System.Drawing.Color.DimGray;
            this.viewLabel3.TabIndex = 5;
            this.viewLabel3.Text = "거래 상세 정보";
            // 
            // DealView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 598);
            this.ControlBox = false;
            this.Controls.Add(this.viewLabel3);
            this.Controls.Add(this.dealviewLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.dealSmExit);
            this.Controls.Add(this.dealSm);
            this.Controls.Add(this.dealSmListView);
            this.Name = "DealView";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.DealView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dealSm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dealSmListView;
        private Sunny.UI.UIDataGridView dealSm;
        private Sunny.UI.UISymbolButton dealSmExit;
        private System.Windows.Forms.ColumnHeader dealSmCount;
        private System.Windows.Forms.ColumnHeader dealSmModel;
        private System.Windows.Forms.ColumnHeader dealSmPrice;
        private System.Windows.Forms.ColumnHeader dealSmName;
        private System.Windows.Forms.ColumnHeader dealSmSeller;
        private System.Windows.Forms.ColumnHeader dealSmDate;
        private System.Windows.Forms.ColumnHeader dealSmRP;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolLabel dealviewLabel2;
        private Sunny.UI.UISymbolLabel viewLabel3;
    }
}
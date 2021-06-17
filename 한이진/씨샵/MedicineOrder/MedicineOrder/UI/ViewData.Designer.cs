
namespace MedicineOrder.UI
{
    partial class ViewData
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colPname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMediName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEffect = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTaking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataViewLable2 = new Sunny.UI.UISymbolLabel();
            this.dataViewClose = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPname,
            this.colMediName,
            this.colEffect,
            this.colTaking,
            this.colPrice});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(45, 130);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(991, 269);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colPname
            // 
            this.colPname.Text = "제품코드";
            this.colPname.Width = 110;
            // 
            // colMediName
            // 
            this.colMediName.Text = "약품명";
            this.colMediName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colMediName.Width = 163;
            // 
            // colEffect
            // 
            this.colEffect.Text = "효과";
            this.colEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colEffect.Width = 124;
            // 
            // colTaking
            // 
            this.colTaking.Text = "복용 방법";
            this.colTaking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTaking.Width = 315;
            // 
            // colPrice
            // 
            this.colPrice.Text = "가격";
            this.colPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPrice.Width = 150;
            // 
            // dataViewLable2
            // 
            this.dataViewLable2.BackColor = System.Drawing.Color.Transparent;
            this.dataViewLable2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dataViewLable2.ForeColor = System.Drawing.Color.DarkRed;
            this.dataViewLable2.Location = new System.Drawing.Point(45, 88);
            this.dataViewLable2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataViewLable2.MinimumSize = new System.Drawing.Size(1, 1);
            this.dataViewLable2.Name = "dataViewLable2";
            this.dataViewLable2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.dataViewLable2.Size = new System.Drawing.Size(155, 35);
            this.dataViewLable2.Style = Sunny.UI.UIStyle.Custom;
            this.dataViewLable2.Symbol = 105;
            this.dataViewLable2.SymbolColor = System.Drawing.Color.CadetBlue;
            this.dataViewLable2.TabIndex = 1;
            this.dataViewLable2.Text = "약품 정보 목록";
            // 
            // dataViewClose
            // 
            this.dataViewClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataViewClose.FillColor = System.Drawing.Color.DarkRed;
            this.dataViewClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dataViewClose.Location = new System.Drawing.Point(1033, 38);
            this.dataViewClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataViewClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.dataViewClose.Name = "dataViewClose";
            this.dataViewClose.RectColor = System.Drawing.Color.Gray;
            this.dataViewClose.Size = new System.Drawing.Size(34, 35);
            this.dataViewClose.Style = Sunny.UI.UIStyle.Custom;
            this.dataViewClose.Symbol = 61453;
            this.dataViewClose.TabIndex = 2;
            this.dataViewClose.Click += new System.EventHandler(this.dataViewClose_Click);
            // 
            // ViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 708);
            this.Controls.Add(this.dataViewClose);
            this.Controls.Add(this.dataViewLable2);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViewData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ViewData_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Sunny.UI.UISymbolLabel dataViewLable2;
        private System.Windows.Forms.ColumnHeader colPname;
        private System.Windows.Forms.ColumnHeader colMediName;
        private System.Windows.Forms.ColumnHeader colEffect;
        private System.Windows.Forms.ColumnHeader colTaking;
        private System.Windows.Forms.ColumnHeader colPrice;
        private Sunny.UI.UISymbolButton dataViewClose;
    }
}
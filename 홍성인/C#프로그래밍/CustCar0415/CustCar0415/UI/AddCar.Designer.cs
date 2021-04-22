
namespace CustCar0415.UI
{
    partial class AddCar
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
            this.comboModel = new Sunny.UI.UIComboBox();
            this.comboCompany = new Sunny.UI.UIComboBox();
            this.comboColor = new Sunny.UI.UIComboBox();
            this.comboPrice = new Sunny.UI.UIComboBox();
            this.infoModel = new Sunny.UI.UISymbolLabel();
            this.infoCompany = new Sunny.UI.UISymbolLabel();
            this.infoColor = new Sunny.UI.UISymbolLabel();
            this.infoPrice = new Sunny.UI.UISymbolLabel();
            this.addCarOK = new Sunny.UI.UISymbolButton();
            this.addCarCancel = new Sunny.UI.UISymbolButton();
            this.cxFlatPictureBox4 = new CxFlatUI.CxFlatPictureBox();
            this.cxFlatPictureBox3 = new CxFlatUI.CxFlatPictureBox();
            this.cxFlatPictureBox2 = new CxFlatUI.CxFlatPictureBox();
            this.cxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            this.addCarExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboModel
            // 
            this.comboModel.FillColor = System.Drawing.Color.White;
            this.comboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboModel.Items.AddRange(new object[] {
            "그란카브리오",
            "가야르도",
            "기블리",
            "르반떼",
            "우라칸"});
            this.comboModel.Location = new System.Drawing.Point(68, 90);
            this.comboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboModel.Name = "comboModel";
            this.comboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboModel.Size = new System.Drawing.Size(191, 29);
            this.comboModel.TabIndex = 0;
            this.comboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // comboCompany
            // 
            this.comboCompany.FillColor = System.Drawing.Color.White;
            this.comboCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboCompany.Items.AddRange(new object[] {
            "마세라티",
            "람보르기니",
            "포르쉐",
            "페라리",
            "벤틀리"});
            this.comboCompany.Location = new System.Drawing.Point(312, 90);
            this.comboCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCompany.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboCompany.Size = new System.Drawing.Size(191, 29);
            this.comboCompany.TabIndex = 1;
            this.comboCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboCompany.SelectedIndexChanged += new System.EventHandler(this.comboCompany_SelectedIndexChanged);
            // 
            // comboColor
            // 
            this.comboColor.FillColor = System.Drawing.Color.White;
            this.comboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboColor.Items.AddRange(new object[] {
            "블랙",
            "네이비",
            "화이트",
            "옐로우",
            "레드"});
            this.comboColor.Location = new System.Drawing.Point(558, 90);
            this.comboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboColor.Name = "comboColor";
            this.comboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboColor.Size = new System.Drawing.Size(191, 29);
            this.comboColor.TabIndex = 2;
            this.comboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            // 
            // comboPrice
            // 
            this.comboPrice.FillColor = System.Drawing.Color.White;
            this.comboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboPrice.Items.AddRange(new object[] {
            "1억5천만원",
            "2억원",
            "2억5천만원",
            "3억원",
            "3억5천만원"});
            this.comboPrice.Location = new System.Drawing.Point(798, 90);
            this.comboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboPrice.Name = "comboPrice";
            this.comboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboPrice.Size = new System.Drawing.Size(191, 29);
            this.comboPrice.TabIndex = 3;
            this.comboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboPrice.SelectedIndexChanged += new System.EventHandler(this.comboPrice_SelectedIndexChanged);
            // 
            // infoModel
            // 
            this.infoModel.BackColor = System.Drawing.Color.Transparent;
            this.infoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoModel.Location = new System.Drawing.Point(229, 592);
            this.infoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoModel.Name = "infoModel";
            this.infoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoModel.Size = new System.Drawing.Size(121, 34);
            this.infoModel.Symbol = 61881;
            this.infoModel.TabIndex = 8;
            this.infoModel.Text = "모델명";
            // 
            // infoCompany
            // 
            this.infoCompany.BackColor = System.Drawing.Color.Transparent;
            this.infoCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoCompany.Location = new System.Drawing.Point(388, 592);
            this.infoCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoCompany.Name = "infoCompany";
            this.infoCompany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoCompany.Size = new System.Drawing.Size(121, 34);
            this.infoCompany.Symbol = 61688;
            this.infoCompany.TabIndex = 9;
            this.infoCompany.Text = "제조사";
            // 
            // infoColor
            // 
            this.infoColor.BackColor = System.Drawing.Color.Transparent;
            this.infoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoColor.Location = new System.Drawing.Point(543, 592);
            this.infoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoColor.Name = "infoColor";
            this.infoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoColor.Size = new System.Drawing.Size(121, 34);
            this.infoColor.Symbol = 61502;
            this.infoColor.TabIndex = 10;
            this.infoColor.Text = "색상";
            // 
            // infoPrice
            // 
            this.infoPrice.BackColor = System.Drawing.Color.Transparent;
            this.infoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoPrice.Location = new System.Drawing.Point(702, 592);
            this.infoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoPrice.Name = "infoPrice";
            this.infoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoPrice.Size = new System.Drawing.Size(121, 34);
            this.infoPrice.Symbol = 61785;
            this.infoPrice.TabIndex = 11;
            this.infoPrice.Text = "가격";
            // 
            // addCarOK
            // 
            this.addCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarOK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarOK.Location = new System.Drawing.Point(395, 646);
            this.addCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarOK.Name = "addCarOK";
            this.addCarOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOK.Size = new System.Drawing.Size(114, 37);
            this.addCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.addCarOK.TabIndex = 12;
            this.addCarOK.Text = "확인";
            this.addCarOK.Click += new System.EventHandler(this.addCarOK_Click);
            // 
            // addCarCancel
            // 
            this.addCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarCancel.FillColor = System.Drawing.Color.Red;
            this.addCarCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarCancel.Location = new System.Drawing.Point(543, 646);
            this.addCarCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarCancel.Name = "addCarCancel";
            this.addCarCancel.RectColor = System.Drawing.Color.Red;
            this.addCarCancel.Size = new System.Drawing.Size(114, 37);
            this.addCarCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCarCancel.Symbol = 61453;
            this.addCarCancel.TabIndex = 13;
            this.addCarCancel.Text = "취소";
            this.addCarCancel.Click += new System.EventHandler(this.addCarCancel_Click);
            // 
            // cxFlatPictureBox4
            // 
            this.cxFlatPictureBox4.Image = global::CustCar0415.Properties.Resources.img;
            this.cxFlatPictureBox4.Location = new System.Drawing.Point(536, 357);
            this.cxFlatPictureBox4.Name = "cxFlatPictureBox4";
            this.cxFlatPictureBox4.Size = new System.Drawing.Size(391, 205);
            this.cxFlatPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox4.TabIndex = 7;
            this.cxFlatPictureBox4.TabStop = false;
            // 
            // cxFlatPictureBox3
            // 
            this.cxFlatPictureBox3.Image = global::CustCar0415.Properties.Resources.그란실내;
            this.cxFlatPictureBox3.Location = new System.Drawing.Point(131, 357);
            this.cxFlatPictureBox3.Name = "cxFlatPictureBox3";
            this.cxFlatPictureBox3.Size = new System.Drawing.Size(391, 205);
            this.cxFlatPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox3.TabIndex = 6;
            this.cxFlatPictureBox3.TabStop = false;
            // 
            // cxFlatPictureBox2
            // 
            this.cxFlatPictureBox2.Image = global::CustCar0415.Properties.Resources.그란측면1;
            this.cxFlatPictureBox2.Location = new System.Drawing.Point(536, 146);
            this.cxFlatPictureBox2.Name = "cxFlatPictureBox2";
            this.cxFlatPictureBox2.Size = new System.Drawing.Size(391, 205);
            this.cxFlatPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox2.TabIndex = 5;
            this.cxFlatPictureBox2.TabStop = false;
            // 
            // cxFlatPictureBox1
            // 
            this.cxFlatPictureBox1.Image = global::CustCar0415.Properties.Resources.그란정면;
            this.cxFlatPictureBox1.Location = new System.Drawing.Point(131, 146);
            this.cxFlatPictureBox1.Name = "cxFlatPictureBox1";
            this.cxFlatPictureBox1.Size = new System.Drawing.Size(391, 205);
            this.cxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cxFlatPictureBox1.TabIndex = 4;
            this.cxFlatPictureBox1.TabStop = false;
            // 
            // addCarExit
            // 
            this.addCarExit.BackColor = System.Drawing.Color.Transparent;
            this.addCarExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarExit.FillColor = System.Drawing.Color.Red;
            this.addCarExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarExit.IsCircle = true;
            this.addCarExit.Location = new System.Drawing.Point(1032, 32);
            this.addCarExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarExit.Name = "addCarExit";
            this.addCarExit.RectColor = System.Drawing.Color.Red;
            this.addCarExit.Size = new System.Drawing.Size(58, 54);
            this.addCarExit.Style = Sunny.UI.UIStyle.Custom;
            this.addCarExit.Symbol = 61457;
            this.addCarExit.SymbolSize = 40;
            this.addCarExit.TabIndex = 14;
            this.addCarExit.Click += new System.EventHandler(this.addCarCancel_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 711);
            this.ControlBox = false;
            this.Controls.Add(this.addCarExit);
            this.Controls.Add(this.addCarCancel);
            this.Controls.Add(this.addCarOK);
            this.Controls.Add(this.infoPrice);
            this.Controls.Add(this.infoColor);
            this.Controls.Add(this.infoCompany);
            this.Controls.Add(this.infoModel);
            this.Controls.Add(this.cxFlatPictureBox4);
            this.Controls.Add(this.cxFlatPictureBox3);
            this.Controls.Add(this.cxFlatPictureBox2);
            this.Controls.Add(this.cxFlatPictureBox1);
            this.Controls.Add(this.comboPrice);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.comboModel);
            this.Name = "AddCar";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCar";
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox comboModel;
        private Sunny.UI.UIComboBox comboCompany;
        private Sunny.UI.UIComboBox comboColor;
        private Sunny.UI.UIComboBox comboPrice;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox1;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox2;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox3;
        private CxFlatUI.CxFlatPictureBox cxFlatPictureBox4;
        private Sunny.UI.UISymbolLabel infoModel;
        private Sunny.UI.UISymbolLabel infoCompany;
        private Sunny.UI.UISymbolLabel infoColor;
        private Sunny.UI.UISymbolLabel infoPrice;
        private Sunny.UI.UISymbolButton addCarOK;
        private Sunny.UI.UISymbolButton addCarCancel;
        private Sunny.UI.UISymbolButton addCarExit;
    }
}
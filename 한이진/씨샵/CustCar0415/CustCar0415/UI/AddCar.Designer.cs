
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
            this.comboColor = new Sunny.UI.UIComboBox();
            this.comboCampany = new Sunny.UI.UIComboBox();
            this.comboPrice = new Sunny.UI.UIComboBox();
            this.infoModel = new Sunny.UI.UISymbolLabel();
            this.infoCanpany = new Sunny.UI.UISymbolLabel();
            this.infoColor = new Sunny.UI.UISymbolLabel();
            this.infoPrice = new Sunny.UI.UISymbolLabel();
            this.addCarCancel = new Sunny.UI.UISymbolButton();
            this.addCarOK = new Sunny.UI.UISymbolButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addCarExit = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboModel
            // 
            this.comboModel.FillColor = System.Drawing.Color.White;
            this.comboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboModel.Items.AddRange(new object[] {
            "J_500",
            "제네시스",
            "K8",
            "K7",
            "SM6",
            "콰트로포르테"});
            this.comboModel.Location = new System.Drawing.Point(76, 82);
            this.comboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboModel.Name = "comboModel";
            this.comboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboModel.Size = new System.Drawing.Size(167, 29);
            this.comboModel.TabIndex = 0;
            this.comboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            this.comboModel.SelectedValueChanged += new System.EventHandler(this.addCarOK_Click);
            // 
            // comboColor
            // 
            this.comboColor.FillColor = System.Drawing.Color.White;
            this.comboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboColor.Items.AddRange(new object[] {
            "빨강",
            "딥블루",
            "카키",
            "실버",
            "매트블랙"});
            this.comboColor.Location = new System.Drawing.Point(449, 82);
            this.comboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboColor.Name = "comboColor";
            this.comboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboColor.Size = new System.Drawing.Size(167, 29);
            this.comboColor.TabIndex = 1;
            this.comboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            // 
            // comboCampany
            // 
            this.comboCampany.FillColor = System.Drawing.Color.White;
            this.comboCampany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboCampany.Items.AddRange(new object[] {
            "마세라티",
            "제규어",
            "현대",
            "기아",
            "르노삼성"});
            this.comboCampany.Location = new System.Drawing.Point(267, 82);
            this.comboCampany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCampany.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboCampany.Name = "comboCampany";
            this.comboCampany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboCampany.Size = new System.Drawing.Size(167, 29);
            this.comboCampany.TabIndex = 2;
            this.comboCampany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboCampany.SelectedIndexChanged += new System.EventHandler(this.comboCampany_SelectedIndexChanged);
            // 
            // comboPrice
            // 
            this.comboPrice.FillColor = System.Drawing.Color.White;
            this.comboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboPrice.Items.AddRange(new object[] {
            "3천만원",
            "5천만원",
            "7천만원",
            "1억",
            "1억5천"});
            this.comboPrice.Location = new System.Drawing.Point(636, 82);
            this.comboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboPrice.Name = "comboPrice";
            this.comboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboPrice.Size = new System.Drawing.Size(167, 29);
            this.comboPrice.TabIndex = 3;
            this.comboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboPrice.SelectedIndexChanged += new System.EventHandler(this.comboPrice_SelectedIndexChanged);
            // 
            // infoModel
            // 
            this.infoModel.BackColor = System.Drawing.Color.Transparent;
            this.infoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoModel.Location = new System.Drawing.Point(59, 489);
            this.infoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoModel.Name = "infoModel";
            this.infoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoModel.Size = new System.Drawing.Size(179, 42);
            this.infoModel.Symbol = 61881;
            this.infoModel.TabIndex = 8;
            this.infoModel.Text = "모델명";
            this.infoModel.Click += new System.EventHandler(this.infoModel_Click);
            // 
            // infoCanpany
            // 
            this.infoCanpany.BackColor = System.Drawing.Color.Transparent;
            this.infoCanpany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoCanpany.Location = new System.Drawing.Point(250, 489);
            this.infoCanpany.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoCanpany.Name = "infoCanpany";
            this.infoCanpany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoCanpany.Size = new System.Drawing.Size(179, 42);
            this.infoCanpany.Symbol = 61613;
            this.infoCanpany.TabIndex = 9;
            this.infoCanpany.Text = "제조사";
            this.infoCanpany.Click += new System.EventHandler(this.infoCanpany_Click);
            // 
            // infoColor
            // 
            this.infoColor.BackColor = System.Drawing.Color.Transparent;
            this.infoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoColor.Location = new System.Drawing.Point(435, 489);
            this.infoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoColor.Name = "infoColor";
            this.infoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoColor.Size = new System.Drawing.Size(179, 42);
            this.infoColor.Symbol = 61948;
            this.infoColor.TabIndex = 10;
            this.infoColor.Text = "색상";
            this.infoColor.Click += new System.EventHandler(this.infoColor_Click);
            // 
            // infoPrice
            // 
            this.infoPrice.BackColor = System.Drawing.Color.Transparent;
            this.infoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoPrice.Location = new System.Drawing.Point(624, 489);
            this.infoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoPrice.Name = "infoPrice";
            this.infoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoPrice.Size = new System.Drawing.Size(179, 42);
            this.infoPrice.Symbol = 61781;
            this.infoPrice.TabIndex = 11;
            this.infoPrice.Text = "가격";
            this.infoPrice.Click += new System.EventHandler(this.infoPrice_Click);
            // 
            // addCarCancel
            // 
            this.addCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarCancel.FillColor = System.Drawing.Color.Firebrick;
            this.addCarCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarCancel.Location = new System.Drawing.Point(449, 537);
            this.addCarCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarCancel.Name = "addCarCancel";
            this.addCarCancel.RectColor = System.Drawing.Color.Firebrick;
            this.addCarCancel.RectDisableColor = System.Drawing.Color.Firebrick;
            this.addCarCancel.RectHoverColor = System.Drawing.Color.Firebrick;
            this.addCarCancel.RectPressColor = System.Drawing.Color.Firebrick;
            this.addCarCancel.RectSelectedColor = System.Drawing.Color.Firebrick;
            this.addCarCancel.Size = new System.Drawing.Size(112, 38);
            this.addCarCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCarCancel.Symbol = 61453;
            this.addCarCancel.TabIndex = 12;
            this.addCarCancel.Text = "취소";
            this.addCarCancel.Click += new System.EventHandler(this.addCarCancel_Click);
            // 
            // addCarOK
            // 
            this.addCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarOK.FillColor = System.Drawing.Color.DarkGreen;
            this.addCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarOK.Location = new System.Drawing.Point(307, 537);
            this.addCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarOK.Name = "addCarOK";
            this.addCarOK.Size = new System.Drawing.Size(112, 38);
            this.addCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.addCarOK.TabIndex = 13;
            this.addCarOK.Text = "선택";
            this.addCarOK.Click += new System.EventHandler(this.addCarOK_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::CustCar0415.Properties.Resources.ma_s;
            this.pictureBox4.Location = new System.Drawing.Point(449, 303);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(354, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::CustCar0415.Properties.Resources.ma_i;
            this.pictureBox3.Location = new System.Drawing.Point(76, 303);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(358, 164);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CustCar0415.Properties.Resources.ma_b;
            this.pictureBox2.Location = new System.Drawing.Point(449, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(354, 164);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CustCar0415.Properties.Resources.ma_f;
            this.pictureBox1.InitialImage = global::CustCar0415.Properties.Resources.ma_f;
            this.pictureBox1.Location = new System.Drawing.Point(76, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // addCarExit
            // 
            this.addCarExit.BackColor = System.Drawing.Color.Transparent;
            this.addCarExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarExit.FillColor = System.Drawing.Color.DarkRed;
            this.addCarExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarExit.Location = new System.Drawing.Point(846, 30);
            this.addCarExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarExit.Name = "addCarExit";
            this.addCarExit.RectColor = System.Drawing.Color.SteelBlue;
            this.addCarExit.Size = new System.Drawing.Size(29, 28);
            this.addCarExit.Style = Sunny.UI.UIStyle.Custom;
            this.addCarExit.Symbol = 61453;
            this.addCarExit.TabIndex = 14;
            this.addCarExit.Click += new System.EventHandler(this.addCarCancel_Click);
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 598);
            this.ControlBox = false;
            this.Controls.Add(this.addCarExit);
            this.Controls.Add(this.addCarOK);
            this.Controls.Add(this.addCarCancel);
            this.Controls.Add(this.infoPrice);
            this.Controls.Add(this.infoColor);
            this.Controls.Add(this.infoCanpany);
            this.Controls.Add(this.infoModel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboPrice);
            this.Controls.Add(this.comboCampany);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.comboModel);
            this.Name = "AddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.AddCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox comboModel;
        private Sunny.UI.UIComboBox comboColor;
        private Sunny.UI.UIComboBox comboCampany;
        private Sunny.UI.UIComboBox comboPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Sunny.UI.UISymbolLabel infoModel;
        private Sunny.UI.UISymbolLabel infoCanpany;
        private Sunny.UI.UISymbolLabel infoColor;
        private Sunny.UI.UISymbolLabel infoPrice;
        private Sunny.UI.UISymbolButton addCarCancel;
        private Sunny.UI.UISymbolButton addCarOK;
        private Sunny.UI.UISymbolButton addCarExit;
    }
}
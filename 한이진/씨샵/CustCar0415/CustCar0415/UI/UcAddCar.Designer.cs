
namespace CustCar0415.UI
{
    partial class UcAddCar
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucAddCarOK = new Sunny.UI.UISymbolButton();
            this.ucAddCarInit = new Sunny.UI.UISymbolButton();
            this.ucInfoPrice = new Sunny.UI.UISymbolLabel();
            this.ucInfoColor = new Sunny.UI.UISymbolLabel();
            this.ucInfoCanpany = new Sunny.UI.UISymbolLabel();
            this.ucInfoModel = new Sunny.UI.UISymbolLabel();
            this.ucComboPrice = new Sunny.UI.UIComboBox();
            this.ucComboCampany = new Sunny.UI.UIComboBox();
            this.ucComboColor = new Sunny.UI.UIComboBox();
            this.ucComboModel = new Sunny.UI.UIComboBox();
            this.ucPictureBox4 = new System.Windows.Forms.PictureBox();
            this.ucPictureBox3 = new System.Windows.Forms.PictureBox();
            this.ucPictureBox2 = new System.Windows.Forms.PictureBox();
            this.ucPictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucAddCarOK
            // 
            this.ucAddCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCarOK.FillColor = System.Drawing.Color.DarkGreen;
            this.ucAddCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCarOK.Location = new System.Drawing.Point(268, 482);
            this.ucAddCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCarOK.Name = "ucAddCarOK";
            this.ucAddCarOK.Size = new System.Drawing.Size(112, 38);
            this.ucAddCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCarOK.TabIndex = 28;
            this.ucAddCarOK.Text = "확인";
            this.ucAddCarOK.Click += new System.EventHandler(this.ucAddCarOK_Click);
            // 
            // ucAddCarInit
            // 
            this.ucAddCarInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCarInit.FillColor = System.Drawing.Color.Firebrick;
            this.ucAddCarInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCarInit.Location = new System.Drawing.Point(410, 482);
            this.ucAddCarInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCarInit.Name = "ucAddCarInit";
            this.ucAddCarInit.RectColor = System.Drawing.Color.Firebrick;
            this.ucAddCarInit.RectDisableColor = System.Drawing.Color.Firebrick;
            this.ucAddCarInit.RectHoverColor = System.Drawing.Color.Firebrick;
            this.ucAddCarInit.RectPressColor = System.Drawing.Color.Firebrick;
            this.ucAddCarInit.RectSelectedColor = System.Drawing.Color.Firebrick;
            this.ucAddCarInit.Size = new System.Drawing.Size(112, 38);
            this.ucAddCarInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCarInit.Symbol = 61453;
            this.ucAddCarInit.TabIndex = 27;
            this.ucAddCarInit.Text = "초기화";
            this.ucAddCarInit.Click += new System.EventHandler(this.ucAddCarInit_Click);
            // 
            // ucInfoPrice
            // 
            this.ucInfoPrice.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoPrice.Location = new System.Drawing.Point(585, 425);
            this.ucInfoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoPrice.Name = "ucInfoPrice";
            this.ucInfoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoPrice.Size = new System.Drawing.Size(179, 42);
            this.ucInfoPrice.Symbol = 61781;
            this.ucInfoPrice.TabIndex = 26;
            this.ucInfoPrice.Text = "가격";
            // 
            // ucInfoColor
            // 
            this.ucInfoColor.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoColor.Location = new System.Drawing.Point(396, 425);
            this.ucInfoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoColor.Name = "ucInfoColor";
            this.ucInfoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoColor.Size = new System.Drawing.Size(179, 42);
            this.ucInfoColor.Symbol = 61948;
            this.ucInfoColor.TabIndex = 25;
            this.ucInfoColor.Text = "색상";
            // 
            // ucInfoCanpany
            // 
            this.ucInfoCanpany.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoCanpany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoCanpany.Location = new System.Drawing.Point(211, 425);
            this.ucInfoCanpany.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoCanpany.Name = "ucInfoCanpany";
            this.ucInfoCanpany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoCanpany.Size = new System.Drawing.Size(179, 42);
            this.ucInfoCanpany.Symbol = 61613;
            this.ucInfoCanpany.TabIndex = 24;
            this.ucInfoCanpany.Text = "제조사";
            // 
            // ucInfoModel
            // 
            this.ucInfoModel.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoModel.Location = new System.Drawing.Point(20, 425);
            this.ucInfoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoModel.Name = "ucInfoModel";
            this.ucInfoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoModel.Size = new System.Drawing.Size(179, 42);
            this.ucInfoModel.Symbol = 61881;
            this.ucInfoModel.TabIndex = 23;
            this.ucInfoModel.Text = "모델명";
            // 
            // ucComboPrice
            // 
            this.ucComboPrice.FillColor = System.Drawing.Color.White;
            this.ucComboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboPrice.Items.AddRange(new object[] {
            "3천만원",
            "5천만원",
            "7천만원",
            "1억",
            "1억5천"});
            this.ucComboPrice.Location = new System.Drawing.Point(597, 18);
            this.ucComboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboPrice.Name = "ucComboPrice";
            this.ucComboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboPrice.Size = new System.Drawing.Size(167, 29);
            this.ucComboPrice.TabIndex = 18;
            this.ucComboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboPrice.SelectedIndexChanged += new System.EventHandler(this.ucComboPrice_SelectedIndexChanged);
            // 
            // ucComboCampany
            // 
            this.ucComboCampany.FillColor = System.Drawing.Color.White;
            this.ucComboCampany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboCampany.Items.AddRange(new object[] {
            "마세라티",
            "제규어",
            "현대",
            "기아",
            "르노삼성"});
            this.ucComboCampany.Location = new System.Drawing.Point(228, 18);
            this.ucComboCampany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboCampany.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboCampany.Name = "ucComboCampany";
            this.ucComboCampany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboCampany.Size = new System.Drawing.Size(167, 29);
            this.ucComboCampany.TabIndex = 17;
            this.ucComboCampany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboCampany.SelectedIndexChanged += new System.EventHandler(this.ucComboCampany_SelectedIndexChanged);
            // 
            // ucComboColor
            // 
            this.ucComboColor.FillColor = System.Drawing.Color.White;
            this.ucComboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboColor.Items.AddRange(new object[] {
            "빨강",
            "딥블루",
            "카키",
            "실버",
            "매트블랙"});
            this.ucComboColor.Location = new System.Drawing.Point(410, 18);
            this.ucComboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboColor.Name = "ucComboColor";
            this.ucComboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboColor.Size = new System.Drawing.Size(167, 29);
            this.ucComboColor.TabIndex = 16;
            this.ucComboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboColor.SelectedIndexChanged += new System.EventHandler(this.ucComboColor_SelectedIndexChanged);
            // 
            // ucComboModel
            // 
            this.ucComboModel.FillColor = System.Drawing.Color.White;
            this.ucComboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboModel.Items.AddRange(new object[] {
            "J_500",
            "제네시스",
            "K8",
            "K7",
            "SM6",
            "콰트로포르테"});
            this.ucComboModel.Location = new System.Drawing.Point(37, 18);
            this.ucComboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboModel.Name = "ucComboModel";
            this.ucComboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboModel.Size = new System.Drawing.Size(167, 29);
            this.ucComboModel.TabIndex = 15;
            this.ucComboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboModel.SelectedIndexChanged += new System.EventHandler(this.ucComboModel_SelectedIndexChanged);
            // 
            // ucPictureBox4
            // 
            this.ucPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureBox4.Image = global::CustCar0415.Properties.Resources.ma_s;
            this.ucPictureBox4.Location = new System.Drawing.Point(384, 239);
            this.ucPictureBox4.Name = "ucPictureBox4";
            this.ucPictureBox4.Size = new System.Drawing.Size(354, 164);
            this.ucPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucPictureBox4.TabIndex = 22;
            this.ucPictureBox4.TabStop = false;
            // 
            // ucPictureBox3
            // 
            this.ucPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureBox3.Image = global::CustCar0415.Properties.Resources.ma_i;
            this.ucPictureBox3.Location = new System.Drawing.Point(88, 239);
            this.ucPictureBox3.Name = "ucPictureBox3";
            this.ucPictureBox3.Size = new System.Drawing.Size(358, 164);
            this.ucPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucPictureBox3.TabIndex = 21;
            this.ucPictureBox3.TabStop = false;
            // 
            // ucPictureBox2
            // 
            this.ucPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureBox2.Image = global::CustCar0415.Properties.Resources.ma_b;
            this.ucPictureBox2.Location = new System.Drawing.Point(384, 69);
            this.ucPictureBox2.Name = "ucPictureBox2";
            this.ucPictureBox2.Size = new System.Drawing.Size(354, 164);
            this.ucPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucPictureBox2.TabIndex = 20;
            this.ucPictureBox2.TabStop = false;
            // 
            // ucPictureBox1
            // 
            this.ucPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureBox1.Image = global::CustCar0415.Properties.Resources.ma_f;
            this.ucPictureBox1.InitialImage = global::CustCar0415.Properties.Resources.ma_f;
            this.ucPictureBox1.Location = new System.Drawing.Point(69, 69);
            this.ucPictureBox1.Name = "ucPictureBox1";
            this.ucPictureBox1.Size = new System.Drawing.Size(358, 164);
            this.ucPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucPictureBox1.TabIndex = 19;
            this.ucPictureBox1.TabStop = false;
            // 
            // UcAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.ucAddCarOK);
            this.Controls.Add(this.ucAddCarInit);
            this.Controls.Add(this.ucInfoPrice);
            this.Controls.Add(this.ucInfoColor);
            this.Controls.Add(this.ucInfoCanpany);
            this.Controls.Add(this.ucInfoModel);
            this.Controls.Add(this.ucPictureBox4);
            this.Controls.Add(this.ucPictureBox3);
            this.Controls.Add(this.ucPictureBox2);
            this.Controls.Add(this.ucPictureBox1);
            this.Controls.Add(this.ucComboPrice);
            this.Controls.Add(this.ucComboCampany);
            this.Controls.Add(this.ucComboColor);
            this.Controls.Add(this.ucComboModel);
            this.Name = "UcAddCar";
            this.Size = new System.Drawing.Size(800, 548);
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton ucAddCarOK;
        private Sunny.UI.UISymbolButton ucAddCarInit;
        private Sunny.UI.UISymbolLabel ucInfoPrice;
        private Sunny.UI.UISymbolLabel ucInfoColor;
        private Sunny.UI.UISymbolLabel ucInfoCanpany;
        private Sunny.UI.UISymbolLabel ucInfoModel;
        private System.Windows.Forms.PictureBox ucPictureBox4;
        private System.Windows.Forms.PictureBox ucPictureBox3;
        private System.Windows.Forms.PictureBox ucPictureBox2;
        private System.Windows.Forms.PictureBox ucPictureBox1;
        private Sunny.UI.UIComboBox ucComboPrice;
        private Sunny.UI.UIComboBox ucComboCampany;
        private Sunny.UI.UIComboBox ucComboColor;
        private Sunny.UI.UIComboBox ucComboModel;
    }
}


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
            this.ucAddCarInit = new Sunny.UI.UISymbolButton();
            this.ucAddCarOK = new Sunny.UI.UISymbolButton();
            this.ucInfoPrice = new Sunny.UI.UISymbolLabel();
            this.ucInfoColor = new Sunny.UI.UISymbolLabel();
            this.ucInfoCompany = new Sunny.UI.UISymbolLabel();
            this.ucInfoModel = new Sunny.UI.UISymbolLabel();
            this.ucComboPrice = new Sunny.UI.UIComboBox();
            this.ucComboColor = new Sunny.UI.UIComboBox();
            this.ucComboCompany = new Sunny.UI.UIComboBox();
            this.ucComboModel = new Sunny.UI.UIComboBox();
            this.ucCxFlatPictureBox4 = new CxFlatUI.CxFlatPictureBox();
            this.ucCxFlatPictureBox3 = new CxFlatUI.CxFlatPictureBox();
            this.ucCxFlatPictureBox2 = new CxFlatUI.CxFlatPictureBox();
            this.ucCxFlatPictureBox1 = new CxFlatUI.CxFlatPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucCxFlatPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCxFlatPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCxFlatPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCxFlatPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucAddCarInit
            // 
            this.ucAddCarInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCarInit.FillColor = System.Drawing.Color.Red;
            this.ucAddCarInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCarInit.Location = new System.Drawing.Point(569, 634);
            this.ucAddCarInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCarInit.Name = "ucAddCarInit";
            this.ucAddCarInit.RectColor = System.Drawing.Color.Red;
            this.ucAddCarInit.Size = new System.Drawing.Size(114, 37);
            this.ucAddCarInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCarInit.Symbol = 61453;
            this.ucAddCarInit.TabIndex = 28;
            this.ucAddCarInit.Text = "초기화";
            this.ucAddCarInit.Click += new System.EventHandler(this.ucAddCarInit_Click);
            // 
            // ucAddCarOK
            // 
            this.ucAddCarOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCarOK.FillColor = System.Drawing.Color.Green;
            this.ucAddCarOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCarOK.Location = new System.Drawing.Point(421, 634);
            this.ucAddCarOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCarOK.Name = "ucAddCarOK";
            this.ucAddCarOK.RectColor = System.Drawing.Color.Green;
            this.ucAddCarOK.Size = new System.Drawing.Size(114, 37);
            this.ucAddCarOK.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCarOK.TabIndex = 27;
            this.ucAddCarOK.Text = "확인";
            this.ucAddCarOK.Click += new System.EventHandler(this.ucAddCarOK_Click);
            // 
            // ucInfoPrice
            // 
            this.ucInfoPrice.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoPrice.Location = new System.Drawing.Point(728, 580);
            this.ucInfoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoPrice.Name = "ucInfoPrice";
            this.ucInfoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoPrice.Size = new System.Drawing.Size(121, 34);
            this.ucInfoPrice.Symbol = 61785;
            this.ucInfoPrice.TabIndex = 26;
            this.ucInfoPrice.Text = "가격";
            // 
            // ucInfoColor
            // 
            this.ucInfoColor.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoColor.Location = new System.Drawing.Point(569, 580);
            this.ucInfoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoColor.Name = "ucInfoColor";
            this.ucInfoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoColor.Size = new System.Drawing.Size(121, 34);
            this.ucInfoColor.Symbol = 61502;
            this.ucInfoColor.TabIndex = 25;
            this.ucInfoColor.Text = "색상";
            // 
            // ucInfoCompany
            // 
            this.ucInfoCompany.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoCompany.Location = new System.Drawing.Point(414, 580);
            this.ucInfoCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoCompany.Name = "ucInfoCompany";
            this.ucInfoCompany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoCompany.Size = new System.Drawing.Size(121, 34);
            this.ucInfoCompany.Symbol = 61688;
            this.ucInfoCompany.TabIndex = 24;
            this.ucInfoCompany.Text = "제조사";
            // 
            // ucInfoModel
            // 
            this.ucInfoModel.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoModel.Location = new System.Drawing.Point(255, 580);
            this.ucInfoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoModel.Name = "ucInfoModel";
            this.ucInfoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoModel.Size = new System.Drawing.Size(121, 34);
            this.ucInfoModel.Symbol = 61881;
            this.ucInfoModel.TabIndex = 23;
            this.ucInfoModel.Text = "모델명";
            // 
            // ucComboPrice
            // 
            this.ucComboPrice.FillColor = System.Drawing.Color.White;
            this.ucComboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboPrice.Items.AddRange(new object[] {
            "1억5천만원",
            "2억원",
            "2억5천만원",
            "3억원",
            "3억5천만원"});
            this.ucComboPrice.Location = new System.Drawing.Point(824, 78);
            this.ucComboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboPrice.Name = "ucComboPrice";
            this.ucComboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboPrice.Size = new System.Drawing.Size(191, 29);
            this.ucComboPrice.TabIndex = 18;
            this.ucComboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboPrice.SelectedIndexChanged += new System.EventHandler(this.ucComboPrice_SelectedIndexChanged);
            // 
            // ucComboColor
            // 
            this.ucComboColor.FillColor = System.Drawing.Color.White;
            this.ucComboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboColor.Items.AddRange(new object[] {
            "블랙",
            "네이비",
            "화이트",
            "옐로우",
            "레드"});
            this.ucComboColor.Location = new System.Drawing.Point(584, 78);
            this.ucComboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboColor.Name = "ucComboColor";
            this.ucComboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboColor.Size = new System.Drawing.Size(191, 29);
            this.ucComboColor.TabIndex = 17;
            this.ucComboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboColor.SelectedIndexChanged += new System.EventHandler(this.ucComboColor_SelectedIndexChanged);
            // 
            // ucComboCompany
            // 
            this.ucComboCompany.FillColor = System.Drawing.Color.White;
            this.ucComboCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboCompany.Items.AddRange(new object[] {
            "마세라티",
            "람보르기니",
            "포르쉐",
            "페라리",
            "벤틀리"});
            this.ucComboCompany.Location = new System.Drawing.Point(338, 78);
            this.ucComboCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboCompany.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboCompany.Name = "ucComboCompany";
            this.ucComboCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboCompany.Size = new System.Drawing.Size(191, 29);
            this.ucComboCompany.TabIndex = 16;
            this.ucComboCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboCompany.SelectedIndexChanged += new System.EventHandler(this.ucComboCompany_SelectedIndexChanged);
            // 
            // ucComboModel
            // 
            this.ucComboModel.FillColor = System.Drawing.Color.White;
            this.ucComboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboModel.Items.AddRange(new object[] {
            "그란카브리오",
            "가야르도",
            "기블리",
            "르반떼",
            "우라칸"});
            this.ucComboModel.Location = new System.Drawing.Point(94, 78);
            this.ucComboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboModel.Name = "ucComboModel";
            this.ucComboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboModel.Size = new System.Drawing.Size(191, 29);
            this.ucComboModel.TabIndex = 15;
            this.ucComboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboModel.SelectedIndexChanged += new System.EventHandler(this.ucComboModel_SelectedIndexChanged);
            // 
            // ucCxFlatPictureBox4
            // 
            this.ucCxFlatPictureBox4.Image = global::CustCar0415.Properties.Resources.img;
            this.ucCxFlatPictureBox4.Location = new System.Drawing.Point(562, 345);
            this.ucCxFlatPictureBox4.Name = "ucCxFlatPictureBox4";
            this.ucCxFlatPictureBox4.Size = new System.Drawing.Size(391, 205);
            this.ucCxFlatPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucCxFlatPictureBox4.TabIndex = 22;
            this.ucCxFlatPictureBox4.TabStop = false;
            // 
            // ucCxFlatPictureBox3
            // 
            this.ucCxFlatPictureBox3.Image = global::CustCar0415.Properties.Resources.그란실내;
            this.ucCxFlatPictureBox3.Location = new System.Drawing.Point(157, 345);
            this.ucCxFlatPictureBox3.Name = "ucCxFlatPictureBox3";
            this.ucCxFlatPictureBox3.Size = new System.Drawing.Size(391, 205);
            this.ucCxFlatPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucCxFlatPictureBox3.TabIndex = 21;
            this.ucCxFlatPictureBox3.TabStop = false;
            // 
            // ucCxFlatPictureBox2
            // 
            this.ucCxFlatPictureBox2.Image = global::CustCar0415.Properties.Resources.그란측면1;
            this.ucCxFlatPictureBox2.Location = new System.Drawing.Point(562, 134);
            this.ucCxFlatPictureBox2.Name = "ucCxFlatPictureBox2";
            this.ucCxFlatPictureBox2.Size = new System.Drawing.Size(391, 205);
            this.ucCxFlatPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucCxFlatPictureBox2.TabIndex = 20;
            this.ucCxFlatPictureBox2.TabStop = false;
            // 
            // ucCxFlatPictureBox1
            // 
            this.ucCxFlatPictureBox1.Image = global::CustCar0415.Properties.Resources.그란정면;
            this.ucCxFlatPictureBox1.Location = new System.Drawing.Point(157, 134);
            this.ucCxFlatPictureBox1.Name = "ucCxFlatPictureBox1";
            this.ucCxFlatPictureBox1.Size = new System.Drawing.Size(391, 205);
            this.ucCxFlatPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ucCxFlatPictureBox1.TabIndex = 19;
            this.ucCxFlatPictureBox1.TabStop = false;
            // 
            // UcAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucAddCarInit);
            this.Controls.Add(this.ucAddCarOK);
            this.Controls.Add(this.ucInfoPrice);
            this.Controls.Add(this.ucInfoColor);
            this.Controls.Add(this.ucInfoCompany);
            this.Controls.Add(this.ucInfoModel);
            this.Controls.Add(this.ucCxFlatPictureBox4);
            this.Controls.Add(this.ucCxFlatPictureBox3);
            this.Controls.Add(this.ucCxFlatPictureBox2);
            this.Controls.Add(this.ucCxFlatPictureBox1);
            this.Controls.Add(this.ucComboPrice);
            this.Controls.Add(this.ucComboColor);
            this.Controls.Add(this.ucComboCompany);
            this.Controls.Add(this.ucComboModel);
            this.Name = "UcAddCar";
            this.Size = new System.Drawing.Size(1153, 679);
            ((System.ComponentModel.ISupportInitialize)(this.ucCxFlatPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCxFlatPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCxFlatPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucCxFlatPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton ucAddCarInit;
        private Sunny.UI.UISymbolButton ucAddCarOK;
        private Sunny.UI.UISymbolLabel ucInfoPrice;
        private Sunny.UI.UISymbolLabel ucInfoColor;
        private Sunny.UI.UISymbolLabel ucInfoCompany;
        private Sunny.UI.UISymbolLabel ucInfoModel;
        private CxFlatUI.CxFlatPictureBox ucCxFlatPictureBox4;
        private CxFlatUI.CxFlatPictureBox ucCxFlatPictureBox3;
        private CxFlatUI.CxFlatPictureBox ucCxFlatPictureBox2;
        private CxFlatUI.CxFlatPictureBox ucCxFlatPictureBox1;
        private Sunny.UI.UIComboBox ucComboPrice;
        private Sunny.UI.UIComboBox ucComboColor;
        private Sunny.UI.UIComboBox ucComboCompany;
        private Sunny.UI.UIComboBox ucComboModel;
    }
}

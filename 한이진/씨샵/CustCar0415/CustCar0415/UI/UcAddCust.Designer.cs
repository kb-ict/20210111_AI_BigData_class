
namespace CustCar0415.UI
{
    partial class UcAddCust
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
            this.ucAddCustMan = new Sunny.UI.UIRadioButton();
            this.ucAddCustWoman = new Sunny.UI.UIRadioButton();
            this.ucAddCustGenderLabel = new Sunny.UI.UISymbolLabel();
            this.ucAddCustOK = new Sunny.UI.UISymbolButton();
            this.ucAddCustInit = new Sunny.UI.UISymbolButton();
            this.ucAddCustAddress = new Sunny.UI.UITextBox();
            this.ucAddCustAddrLabel = new Sunny.UI.UISymbolLabel();
            this.ucAddCustPhone = new Sunny.UI.UITextBox();
            this.ucAddcustPhoneLabel = new Sunny.UI.UISymbolLabel();
            this.ucAddCustAge = new Sunny.UI.UITextBox();
            this.ucAddCustAgeLabel = new Sunny.UI.UISymbolLabel();
            this.ucAddCustName = new Sunny.UI.UITextBox();
            this.ucAddCustNameLabel = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // ucAddCustMan
            // 
            this.ucAddCustMan.BackColor = System.Drawing.Color.Transparent;
            this.ucAddCustMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustMan.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustMan.Location = new System.Drawing.Point(546, 297);
            this.ucAddCustMan.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustMan.Name = "ucAddCustMan";
            this.ucAddCustMan.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ucAddCustMan.RadioButtonColor = System.Drawing.Color.MediumPurple;
            this.ucAddCustMan.Size = new System.Drawing.Size(71, 45);
            this.ucAddCustMan.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustMan.TabIndex = 38;
            this.ucAddCustMan.Text = "남";
            this.ucAddCustMan.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.ucAddCustWoman_ValueChanged);
            // 
            // ucAddCustWoman
            // 
            this.ucAddCustWoman.BackColor = System.Drawing.Color.Transparent;
            this.ucAddCustWoman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustWoman.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustWoman.Location = new System.Drawing.Point(439, 296);
            this.ucAddCustWoman.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustWoman.Name = "ucAddCustWoman";
            this.ucAddCustWoman.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.ucAddCustWoman.RadioButtonColor = System.Drawing.Color.Salmon;
            this.ucAddCustWoman.Size = new System.Drawing.Size(80, 45);
            this.ucAddCustWoman.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustWoman.TabIndex = 37;
            this.ucAddCustWoman.Text = "여";
            this.ucAddCustWoman.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.ucAddCustWoman_ValueChanged);
            // 
            // ucAddCustGenderLabel
            // 
            this.ucAddCustGenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddCustGenderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustGenderLabel.Location = new System.Drawing.Point(232, 297);
            this.ucAddCustGenderLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustGenderLabel.Name = "ucAddCustGenderLabel";
            this.ucAddCustGenderLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddCustGenderLabel.Size = new System.Drawing.Size(189, 45);
            this.ucAddCustGenderLabel.Symbol = 116;
            this.ucAddCustGenderLabel.TabIndex = 36;
            this.ucAddCustGenderLabel.Text = "성별";
            this.ucAddCustGenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAddCustOK
            // 
            this.ucAddCustOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustOK.FillColor = System.Drawing.Color.DarkGreen;
            this.ucAddCustOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustOK.Location = new System.Drawing.Point(279, 421);
            this.ucAddCustOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustOK.Name = "ucAddCustOK";
            this.ucAddCustOK.Size = new System.Drawing.Size(112, 38);
            this.ucAddCustOK.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustOK.TabIndex = 35;
            this.ucAddCustOK.Text = "선택";
            this.ucAddCustOK.Click += new System.EventHandler(this.ucAddCustOK_Click);
            // 
            // ucAddCustInit
            // 
            this.ucAddCustInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCustInit.FillColor = System.Drawing.Color.Firebrick;
            this.ucAddCustInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustInit.Location = new System.Drawing.Point(421, 421);
            this.ucAddCustInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustInit.Name = "ucAddCustInit";
            this.ucAddCustInit.RectColor = System.Drawing.Color.Firebrick;
            this.ucAddCustInit.RectDisableColor = System.Drawing.Color.Firebrick;
            this.ucAddCustInit.RectHoverColor = System.Drawing.Color.Firebrick;
            this.ucAddCustInit.RectPressColor = System.Drawing.Color.Firebrick;
            this.ucAddCustInit.RectSelectedColor = System.Drawing.Color.Firebrick;
            this.ucAddCustInit.Size = new System.Drawing.Size(112, 38);
            this.ucAddCustInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCustInit.Symbol = 61453;
            this.ucAddCustInit.TabIndex = 34;
            this.ucAddCustInit.Text = "초기화";
            this.ucAddCustInit.Click += new System.EventHandler(this.ucAddCustInit_Click);
            // 
            // ucAddCustAddress
            // 
            this.ucAddCustAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustAddress.FillColor = System.Drawing.Color.White;
            this.ucAddCustAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustAddress.Location = new System.Drawing.Point(428, 259);
            this.ucAddCustAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustAddress.Maximum = 2147483647D;
            this.ucAddCustAddress.Minimum = -2147483648D;
            this.ucAddCustAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustAddress.Name = "ucAddCustAddress";
            this.ucAddCustAddress.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustAddress.Size = new System.Drawing.Size(189, 29);
            this.ucAddCustAddress.TabIndex = 31;
            // 
            // ucAddCustAddrLabel
            // 
            this.ucAddCustAddrLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddCustAddrLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustAddrLabel.Location = new System.Drawing.Point(232, 259);
            this.ucAddCustAddrLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustAddrLabel.Name = "ucAddCustAddrLabel";
            this.ucAddCustAddrLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddCustAddrLabel.Size = new System.Drawing.Size(189, 29);
            this.ucAddCustAddrLabel.Symbol = 57353;
            this.ucAddCustAddrLabel.TabIndex = 28;
            this.ucAddCustAddrLabel.Text = "주소";
            this.ucAddCustAddrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAddCustPhone
            // 
            this.ucAddCustPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustPhone.FillColor = System.Drawing.Color.White;
            this.ucAddCustPhone.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustPhone.Location = new System.Drawing.Point(428, 205);
            this.ucAddCustPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustPhone.Maximum = 2147483647D;
            this.ucAddCustPhone.Minimum = -2147483648D;
            this.ucAddCustPhone.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustPhone.Name = "ucAddCustPhone";
            this.ucAddCustPhone.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustPhone.Size = new System.Drawing.Size(189, 29);
            this.ucAddCustPhone.TabIndex = 32;
            // 
            // ucAddcustPhoneLabel
            // 
            this.ucAddcustPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddcustPhoneLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddcustPhoneLabel.Location = new System.Drawing.Point(232, 205);
            this.ucAddcustPhoneLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddcustPhoneLabel.Name = "ucAddcustPhoneLabel";
            this.ucAddcustPhoneLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddcustPhoneLabel.Size = new System.Drawing.Size(189, 29);
            this.ucAddcustPhoneLabel.Symbol = 57355;
            this.ucAddcustPhoneLabel.TabIndex = 29;
            this.ucAddcustPhoneLabel.Text = "전화 번호";
            this.ucAddcustPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAddCustAge
            // 
            this.ucAddCustAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustAge.FillColor = System.Drawing.Color.White;
            this.ucAddCustAge.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustAge.Location = new System.Drawing.Point(428, 153);
            this.ucAddCustAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustAge.Maximum = 2147483647D;
            this.ucAddCustAge.Minimum = -2147483648D;
            this.ucAddCustAge.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustAge.Name = "ucAddCustAge";
            this.ucAddCustAge.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustAge.Size = new System.Drawing.Size(189, 29);
            this.ucAddCustAge.TabIndex = 33;
            // 
            // ucAddCustAgeLabel
            // 
            this.ucAddCustAgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddCustAgeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustAgeLabel.Location = new System.Drawing.Point(232, 153);
            this.ucAddCustAgeLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustAgeLabel.Name = "ucAddCustAgeLabel";
            this.ucAddCustAgeLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddCustAgeLabel.Size = new System.Drawing.Size(189, 29);
            this.ucAddCustAgeLabel.Symbol = 57354;
            this.ucAddCustAgeLabel.TabIndex = 30;
            this.ucAddCustAgeLabel.Text = "고객 연령";
            this.ucAddCustAgeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAddCustName
            // 
            this.ucAddCustName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddCustName.FillColor = System.Drawing.Color.White;
            this.ucAddCustName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustName.Location = new System.Drawing.Point(428, 96);
            this.ucAddCustName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddCustName.Maximum = 2147483647D;
            this.ucAddCustName.Minimum = -2147483648D;
            this.ucAddCustName.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustName.Name = "ucAddCustName";
            this.ucAddCustName.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddCustName.Size = new System.Drawing.Size(189, 29);
            this.ucAddCustName.TabIndex = 27;
            // 
            // ucAddCustNameLabel
            // 
            this.ucAddCustNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddCustNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCustNameLabel.Location = new System.Drawing.Point(232, 96);
            this.ucAddCustNameLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCustNameLabel.Name = "ucAddCustNameLabel";
            this.ucAddCustNameLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddCustNameLabel.Size = new System.Drawing.Size(189, 29);
            this.ucAddCustNameLabel.Symbol = 62142;
            this.ucAddCustNameLabel.TabIndex = 26;
            this.ucAddCustNameLabel.TabStop = false;
            this.ucAddCustNameLabel.Text = "고객 이름";
            this.ucAddCustNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcAddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucAddCustMan);
            this.Controls.Add(this.ucAddCustWoman);
            this.Controls.Add(this.ucAddCustGenderLabel);
            this.Controls.Add(this.ucAddCustOK);
            this.Controls.Add(this.ucAddCustInit);
            this.Controls.Add(this.ucAddCustAddress);
            this.Controls.Add(this.ucAddCustAddrLabel);
            this.Controls.Add(this.ucAddCustPhone);
            this.Controls.Add(this.ucAddcustPhoneLabel);
            this.Controls.Add(this.ucAddCustAge);
            this.Controls.Add(this.ucAddCustAgeLabel);
            this.Controls.Add(this.ucAddCustName);
            this.Controls.Add(this.ucAddCustNameLabel);
            this.Name = "UcAddCust";
            this.Size = new System.Drawing.Size(800, 548);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIRadioButton ucAddCustMan;
        private Sunny.UI.UIRadioButton ucAddCustWoman;
        private Sunny.UI.UISymbolLabel ucAddCustGenderLabel;
        private Sunny.UI.UISymbolButton ucAddCustOK;
        private Sunny.UI.UISymbolButton ucAddCustInit;
        private Sunny.UI.UITextBox ucAddCustAddress;
        private Sunny.UI.UISymbolLabel ucAddCustAddrLabel;
        private Sunny.UI.UITextBox ucAddCustPhone;
        private Sunny.UI.UISymbolLabel ucAddcustPhoneLabel;
        private Sunny.UI.UITextBox ucAddCustAge;
        private Sunny.UI.UISymbolLabel ucAddCustAgeLabel;
        private Sunny.UI.UITextBox ucAddCustName;
        private Sunny.UI.UISymbolLabel ucAddCustNameLabel;
    }
}

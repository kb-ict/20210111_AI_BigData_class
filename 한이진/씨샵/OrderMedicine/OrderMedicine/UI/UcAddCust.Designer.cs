
namespace OrderMedicine.UI
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
            this.custIdLabel = new Sunny.UI.UISymbolLabel();
            this.custNameLabel = new Sunny.UI.UISymbolLabel();
            this.custAgeLabel = new Sunny.UI.UISymbolLabel();
            this.custGenderLabel = new Sunny.UI.UISymbolLabel();
            this.custAddAddressLabel = new Sunny.UI.UISymbolLabel();
            this.custAddPhoneLabel = new Sunny.UI.UISymbolLabel();
            this.custAddId = new Sunny.UI.UITextBox();
            this.custAddName = new Sunny.UI.UITextBox();
            this.custAddAge = new Sunny.UI.UITextBox();
            this.custAddAddress = new Sunny.UI.UITextBox();
            this.custAddPhone = new Sunny.UI.UITextBox();
            this.custAddDataOk = new Sunny.UI.UISymbolButton();
            this.custAddDataInit = new Sunny.UI.UISymbolButton();
            this.custAddGenderW = new Sunny.UI.UIRadioButton();
            this.custAddGenderM = new Sunny.UI.UIRadioButton();
            this.SuspendLayout();
            // 
            // custIdLabel
            // 
            this.custIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.custIdLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custIdLabel.Location = new System.Drawing.Point(142, 56);
            this.custIdLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custIdLabel.Name = "custIdLabel";
            this.custIdLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.custIdLabel.Size = new System.Drawing.Size(186, 40);
            this.custIdLabel.Symbol = 62140;
            this.custIdLabel.TabIndex = 0;
            this.custIdLabel.Text = "ID";
            // 
            // custNameLabel
            // 
            this.custNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.custNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custNameLabel.Location = new System.Drawing.Point(142, 111);
            this.custNameLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custNameLabel.Name = "custNameLabel";
            this.custNameLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.custNameLabel.Size = new System.Drawing.Size(186, 40);
            this.custNameLabel.Symbol = 62142;
            this.custNameLabel.TabIndex = 1;
            this.custNameLabel.Text = "이름";
            // 
            // custAgeLabel
            // 
            this.custAgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.custAgeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAgeLabel.Location = new System.Drawing.Point(142, 168);
            this.custAgeLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAgeLabel.Name = "custAgeLabel";
            this.custAgeLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.custAgeLabel.Size = new System.Drawing.Size(186, 40);
            this.custAgeLabel.Symbol = 57354;
            this.custAgeLabel.TabIndex = 2;
            this.custAgeLabel.Text = "나이";
            // 
            // custGenderLabel
            // 
            this.custGenderLabel.BackColor = System.Drawing.Color.Transparent;
            this.custGenderLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custGenderLabel.Location = new System.Drawing.Point(142, 225);
            this.custGenderLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custGenderLabel.Name = "custGenderLabel";
            this.custGenderLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.custGenderLabel.Size = new System.Drawing.Size(186, 40);
            this.custGenderLabel.Symbol = 61508;
            this.custGenderLabel.TabIndex = 3;
            this.custGenderLabel.Text = "성별";
            // 
            // custAddAddressLabel
            // 
            this.custAddAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.custAddAddressLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddAddressLabel.Location = new System.Drawing.Point(142, 271);
            this.custAddAddressLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddAddressLabel.Name = "custAddAddressLabel";
            this.custAddAddressLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.custAddAddressLabel.Size = new System.Drawing.Size(186, 40);
            this.custAddAddressLabel.Symbol = 57353;
            this.custAddAddressLabel.TabIndex = 5;
            this.custAddAddressLabel.Text = "주소";
            // 
            // custAddPhoneLabel
            // 
            this.custAddPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.custAddPhoneLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddPhoneLabel.Location = new System.Drawing.Point(142, 327);
            this.custAddPhoneLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddPhoneLabel.Name = "custAddPhoneLabel";
            this.custAddPhoneLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.custAddPhoneLabel.Size = new System.Drawing.Size(186, 40);
            this.custAddPhoneLabel.Symbol = 57355;
            this.custAddPhoneLabel.TabIndex = 6;
            this.custAddPhoneLabel.Text = "전화번호";
            // 
            // custAddId
            // 
            this.custAddId.BackColor = System.Drawing.Color.Transparent;
            this.custAddId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custAddId.FillColor = System.Drawing.Color.White;
            this.custAddId.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddId.Location = new System.Drawing.Point(335, 56);
            this.custAddId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddId.Maximum = 2147483647D;
            this.custAddId.Minimum = -2147483648D;
            this.custAddId.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddId.Name = "custAddId";
            this.custAddId.Padding = new System.Windows.Forms.Padding(5);
            this.custAddId.Size = new System.Drawing.Size(204, 29);
            this.custAddId.TabIndex = 7;
            // 
            // custAddName
            // 
            this.custAddName.BackColor = System.Drawing.Color.Transparent;
            this.custAddName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custAddName.FillColor = System.Drawing.Color.White;
            this.custAddName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddName.Location = new System.Drawing.Point(335, 111);
            this.custAddName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddName.Maximum = 2147483647D;
            this.custAddName.Minimum = -2147483648D;
            this.custAddName.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddName.Name = "custAddName";
            this.custAddName.Padding = new System.Windows.Forms.Padding(5);
            this.custAddName.Size = new System.Drawing.Size(204, 29);
            this.custAddName.TabIndex = 8;
            // 
            // custAddAge
            // 
            this.custAddAge.BackColor = System.Drawing.Color.Transparent;
            this.custAddAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custAddAge.FillColor = System.Drawing.Color.White;
            this.custAddAge.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddAge.Location = new System.Drawing.Point(335, 168);
            this.custAddAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddAge.Maximum = 2147483647D;
            this.custAddAge.Minimum = -2147483648D;
            this.custAddAge.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddAge.Name = "custAddAge";
            this.custAddAge.Padding = new System.Windows.Forms.Padding(5);
            this.custAddAge.Size = new System.Drawing.Size(204, 29);
            this.custAddAge.TabIndex = 8;
            // 
            // custAddAddress
            // 
            this.custAddAddress.BackColor = System.Drawing.Color.Transparent;
            this.custAddAddress.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.custAddAddress.FillColor = System.Drawing.Color.White;
            this.custAddAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddAddress.Location = new System.Drawing.Point(335, 271);
            this.custAddAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddAddress.Maximum = 2147483647D;
            this.custAddAddress.Minimum = -2147483648D;
            this.custAddAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddAddress.Name = "custAddAddress";
            this.custAddAddress.Padding = new System.Windows.Forms.Padding(5);
            this.custAddAddress.Size = new System.Drawing.Size(204, 29);
            this.custAddAddress.TabIndex = 8;
            // 
            // custAddPhone
            // 
            this.custAddPhone.BackColor = System.Drawing.Color.Transparent;
            this.custAddPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custAddPhone.FillColor = System.Drawing.Color.White;
            this.custAddPhone.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddPhone.Location = new System.Drawing.Point(335, 327);
            this.custAddPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddPhone.Maximum = 2147483647D;
            this.custAddPhone.Minimum = -2147483648D;
            this.custAddPhone.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddPhone.Name = "custAddPhone";
            this.custAddPhone.Padding = new System.Windows.Forms.Padding(5);
            this.custAddPhone.Size = new System.Drawing.Size(204, 29);
            this.custAddPhone.TabIndex = 8;
            // 
            // custAddDataOk
            // 
            this.custAddDataOk.BackColor = System.Drawing.Color.Transparent;
            this.custAddDataOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custAddDataOk.FillColor = System.Drawing.Color.SeaGreen;
            this.custAddDataOk.FillHoverColor = System.Drawing.Color.DarkGreen;
            this.custAddDataOk.FillPressColor = System.Drawing.Color.DarkGreen;
            this.custAddDataOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddDataOk.Location = new System.Drawing.Point(187, 422);
            this.custAddDataOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddDataOk.Name = "custAddDataOk";
            this.custAddDataOk.RectColor = System.Drawing.Color.Transparent;
            this.custAddDataOk.Size = new System.Drawing.Size(160, 39);
            this.custAddDataOk.Style = Sunny.UI.UIStyle.Custom;
            this.custAddDataOk.TabIndex = 9;
            this.custAddDataOk.Text = "추가";
            this.custAddDataOk.Click += new System.EventHandler(this.custAddDataOk_Click);
            // 
            // custAddDataInit
            // 
            this.custAddDataInit.BackColor = System.Drawing.Color.Transparent;
            this.custAddDataInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custAddDataInit.FillColor = System.Drawing.Color.Firebrick;
            this.custAddDataInit.FillHoverColor = System.Drawing.Color.DarkRed;
            this.custAddDataInit.FillSelectedColor = System.Drawing.Color.DarkRed;
            this.custAddDataInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddDataInit.Location = new System.Drawing.Point(366, 422);
            this.custAddDataInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddDataInit.Name = "custAddDataInit";
            this.custAddDataInit.RectColor = System.Drawing.Color.Transparent;
            this.custAddDataInit.Size = new System.Drawing.Size(160, 39);
            this.custAddDataInit.Style = Sunny.UI.UIStyle.Custom;
            this.custAddDataInit.Symbol = 61473;
            this.custAddDataInit.TabIndex = 10;
            this.custAddDataInit.Text = "초기화";
            this.custAddDataInit.Click += new System.EventHandler(this.custAddDataInit_Click);
            // 
            // custAddGenderW
            // 
            this.custAddGenderW.BackColor = System.Drawing.Color.Transparent;
            this.custAddGenderW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custAddGenderW.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddGenderW.Location = new System.Drawing.Point(335, 225);
            this.custAddGenderW.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddGenderW.Name = "custAddGenderW";
            this.custAddGenderW.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custAddGenderW.RadioButtonColor = System.Drawing.Color.LightCoral;
            this.custAddGenderW.Size = new System.Drawing.Size(78, 37);
            this.custAddGenderW.Style = Sunny.UI.UIStyle.Custom;
            this.custAddGenderW.TabIndex = 11;
            this.custAddGenderW.Text = "여";
            this.custAddGenderW.ValueChanged += new Sunny.UI.UIRadioButton.OnValueChanged(this.custAddGenderW_ValueChanged);
            // 
            // custAddGenderM
            // 
            this.custAddGenderM.BackColor = System.Drawing.Color.Transparent;
            this.custAddGenderM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custAddGenderM.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddGenderM.Location = new System.Drawing.Point(461, 225);
            this.custAddGenderM.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddGenderM.Name = "custAddGenderM";
            this.custAddGenderM.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.custAddGenderM.RadioButtonColor = System.Drawing.Color.MediumTurquoise;
            this.custAddGenderM.Size = new System.Drawing.Size(78, 37);
            this.custAddGenderM.Style = Sunny.UI.UIStyle.Custom;
            this.custAddGenderM.TabIndex = 12;
            this.custAddGenderM.Text = "남";
            // 
            // UcAddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.custAddGenderM);
            this.Controls.Add(this.custAddGenderW);
            this.Controls.Add(this.custAddDataInit);
            this.Controls.Add(this.custAddDataOk);
            this.Controls.Add(this.custAddPhone);
            this.Controls.Add(this.custAddAddress);
            this.Controls.Add(this.custAddAge);
            this.Controls.Add(this.custAddName);
            this.Controls.Add(this.custAddId);
            this.Controls.Add(this.custAddPhoneLabel);
            this.Controls.Add(this.custAddAddressLabel);
            this.Controls.Add(this.custGenderLabel);
            this.Controls.Add(this.custAgeLabel);
            this.Controls.Add(this.custNameLabel);
            this.Controls.Add(this.custIdLabel);
            this.Name = "UcAddCust";
            this.Size = new System.Drawing.Size(693, 514);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel custIdLabel;
        private Sunny.UI.UISymbolLabel custNameLabel;
        private Sunny.UI.UISymbolLabel custAgeLabel;
        private Sunny.UI.UISymbolLabel custGenderLabel;
        private Sunny.UI.UISymbolLabel custAddAddressLabel;
        private Sunny.UI.UISymbolLabel custAddPhoneLabel;
        private Sunny.UI.UITextBox custAddId;
        private Sunny.UI.UITextBox custAddName;
        private Sunny.UI.UITextBox custAddAge;
        private Sunny.UI.UITextBox custAddAddress;
        private Sunny.UI.UITextBox custAddPhone;
        private Sunny.UI.UISymbolButton custAddDataOk;
        private Sunny.UI.UISymbolButton custAddDataInit;
        private Sunny.UI.UIRadioButton custAddGenderW;
        private Sunny.UI.UIRadioButton custAddGenderM;
    }
}

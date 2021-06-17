
namespace CustCar0415.UI
{
    partial class UcAddSell
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
            this.ucAddSellOfficLabel = new Sunny.UI.UISymbolLabel();
            this.ucAddSellOK = new Sunny.UI.UISymbolButton();
            this.ucAddSellInit = new Sunny.UI.UISymbolButton();
            this.ucAddSellLevel = new Sunny.UI.UITextBox();
            this.ucAddSellLevelLabel = new Sunny.UI.UISymbolLabel();
            this.ucAddSellPhone = new Sunny.UI.UITextBox();
            this.ucAddSellPhoneLabel = new Sunny.UI.UISymbolLabel();
            this.ucAddSellName = new Sunny.UI.UITextBox();
            this.ucAddSellNameLabel = new Sunny.UI.UISymbolLabel();
            this.ucAddSellOffice = new Sunny.UI.UITextBox();
            this.SuspendLayout();
            // 
            // ucAddSellOfficLabel
            // 
            this.ucAddSellOfficLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddSellOfficLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellOfficLabel.Location = new System.Drawing.Point(222, 262);
            this.ucAddSellOfficLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellOfficLabel.Name = "ucAddSellOfficLabel";
            this.ucAddSellOfficLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddSellOfficLabel.Size = new System.Drawing.Size(189, 45);
            this.ucAddSellOfficLabel.Symbol = 116;
            this.ucAddSellOfficLabel.TabIndex = 50;
            this.ucAddSellOfficLabel.Text = "영업소";
            this.ucAddSellOfficLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAddSellOK
            // 
            this.ucAddSellOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddSellOK.FillColor = System.Drawing.Color.DarkGreen;
            this.ucAddSellOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellOK.Location = new System.Drawing.Point(271, 394);
            this.ucAddSellOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellOK.Name = "ucAddSellOK";
            this.ucAddSellOK.Size = new System.Drawing.Size(112, 38);
            this.ucAddSellOK.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddSellOK.TabIndex = 49;
            this.ucAddSellOK.Text = "선택";
            this.ucAddSellOK.Click += new System.EventHandler(this.ucAddSellOK_Click);
            // 
            // ucAddSellInit
            // 
            this.ucAddSellInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddSellInit.FillColor = System.Drawing.Color.Firebrick;
            this.ucAddSellInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellInit.Location = new System.Drawing.Point(413, 394);
            this.ucAddSellInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellInit.Name = "ucAddSellInit";
            this.ucAddSellInit.RectColor = System.Drawing.Color.Firebrick;
            this.ucAddSellInit.RectDisableColor = System.Drawing.Color.Firebrick;
            this.ucAddSellInit.RectHoverColor = System.Drawing.Color.Firebrick;
            this.ucAddSellInit.RectPressColor = System.Drawing.Color.Firebrick;
            this.ucAddSellInit.RectSelectedColor = System.Drawing.Color.Firebrick;
            this.ucAddSellInit.Size = new System.Drawing.Size(112, 38);
            this.ucAddSellInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddSellInit.Symbol = 61453;
            this.ucAddSellInit.TabIndex = 48;
            this.ucAddSellInit.Text = "초기화";
            this.ucAddSellInit.Click += new System.EventHandler(this.ucAddSellInit_Click);
            // 
            // ucAddSellLevel
            // 
            this.ucAddSellLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddSellLevel.FillColor = System.Drawing.Color.White;
            this.ucAddSellLevel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellLevel.Location = new System.Drawing.Point(418, 227);
            this.ucAddSellLevel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddSellLevel.Maximum = 2147483647D;
            this.ucAddSellLevel.Minimum = -2147483648D;
            this.ucAddSellLevel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellLevel.Name = "ucAddSellLevel";
            this.ucAddSellLevel.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddSellLevel.Size = new System.Drawing.Size(189, 29);
            this.ucAddSellLevel.TabIndex = 45;
            // 
            // ucAddSellLevelLabel
            // 
            this.ucAddSellLevelLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddSellLevelLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellLevelLabel.Location = new System.Drawing.Point(222, 227);
            this.ucAddSellLevelLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellLevelLabel.Name = "ucAddSellLevelLabel";
            this.ucAddSellLevelLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddSellLevelLabel.Size = new System.Drawing.Size(189, 29);
            this.ucAddSellLevelLabel.Symbol = 57353;
            this.ucAddSellLevelLabel.TabIndex = 42;
            this.ucAddSellLevelLabel.Text = "직급";
            this.ucAddSellLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAddSellPhone
            // 
            this.ucAddSellPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddSellPhone.FillColor = System.Drawing.Color.White;
            this.ucAddSellPhone.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellPhone.Location = new System.Drawing.Point(418, 181);
            this.ucAddSellPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddSellPhone.Maximum = 2147483647D;
            this.ucAddSellPhone.Minimum = -2147483648D;
            this.ucAddSellPhone.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellPhone.Name = "ucAddSellPhone";
            this.ucAddSellPhone.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddSellPhone.Size = new System.Drawing.Size(189, 29);
            this.ucAddSellPhone.TabIndex = 46;
            // 
            // ucAddSellPhoneLabel
            // 
            this.ucAddSellPhoneLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddSellPhoneLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellPhoneLabel.Location = new System.Drawing.Point(222, 181);
            this.ucAddSellPhoneLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellPhoneLabel.Name = "ucAddSellPhoneLabel";
            this.ucAddSellPhoneLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddSellPhoneLabel.Size = new System.Drawing.Size(189, 29);
            this.ucAddSellPhoneLabel.Symbol = 57355;
            this.ucAddSellPhoneLabel.TabIndex = 43;
            this.ucAddSellPhoneLabel.Text = "전화 번호";
            this.ucAddSellPhoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAddSellName
            // 
            this.ucAddSellName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddSellName.FillColor = System.Drawing.Color.White;
            this.ucAddSellName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellName.Location = new System.Drawing.Point(418, 135);
            this.ucAddSellName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddSellName.Maximum = 2147483647D;
            this.ucAddSellName.Minimum = -2147483648D;
            this.ucAddSellName.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellName.Name = "ucAddSellName";
            this.ucAddSellName.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddSellName.Size = new System.Drawing.Size(189, 29);
            this.ucAddSellName.TabIndex = 41;
            // 
            // ucAddSellNameLabel
            // 
            this.ucAddSellNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ucAddSellNameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellNameLabel.Location = new System.Drawing.Point(222, 135);
            this.ucAddSellNameLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellNameLabel.Name = "ucAddSellNameLabel";
            this.ucAddSellNameLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucAddSellNameLabel.Size = new System.Drawing.Size(189, 29);
            this.ucAddSellNameLabel.Symbol = 62142;
            this.ucAddSellNameLabel.TabIndex = 40;
            this.ucAddSellNameLabel.TabStop = false;
            this.ucAddSellNameLabel.Text = "직원 이름";
            this.ucAddSellNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ucAddSellOffice
            // 
            this.ucAddSellOffice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucAddSellOffice.FillColor = System.Drawing.Color.White;
            this.ucAddSellOffice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddSellOffice.Location = new System.Drawing.Point(418, 274);
            this.ucAddSellOffice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAddSellOffice.Maximum = 2147483647D;
            this.ucAddSellOffice.Minimum = -2147483648D;
            this.ucAddSellOffice.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddSellOffice.Name = "ucAddSellOffice";
            this.ucAddSellOffice.Padding = new System.Windows.Forms.Padding(5);
            this.ucAddSellOffice.Size = new System.Drawing.Size(189, 29);
            this.ucAddSellOffice.TabIndex = 46;
            // 
            // UcAddSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucAddSellOffice);
            this.Controls.Add(this.ucAddSellOfficLabel);
            this.Controls.Add(this.ucAddSellOK);
            this.Controls.Add(this.ucAddSellInit);
            this.Controls.Add(this.ucAddSellLevel);
            this.Controls.Add(this.ucAddSellLevelLabel);
            this.Controls.Add(this.ucAddSellPhone);
            this.Controls.Add(this.ucAddSellPhoneLabel);
            this.Controls.Add(this.ucAddSellName);
            this.Controls.Add(this.ucAddSellNameLabel);
            this.Name = "UcAddSell";
            this.Size = new System.Drawing.Size(800, 548);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel ucAddSellOfficLabel;
        private Sunny.UI.UISymbolButton ucAddSellOK;
        private Sunny.UI.UISymbolButton ucAddSellInit;
        private Sunny.UI.UITextBox ucAddSellLevel;
        private Sunny.UI.UISymbolLabel ucAddSellLevelLabel;
        private Sunny.UI.UITextBox ucAddSellPhone;
        private Sunny.UI.UISymbolLabel ucAddSellPhoneLabel;
        private Sunny.UI.UITextBox ucAddSellName;
        private Sunny.UI.UISymbolLabel ucAddSellNameLabel;
        private Sunny.UI.UITextBox ucAddSellOffice;
    }
}

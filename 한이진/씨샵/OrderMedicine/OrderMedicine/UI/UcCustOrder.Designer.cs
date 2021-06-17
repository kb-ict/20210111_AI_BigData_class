
namespace OrderMedicine.UI
{
    partial class UcCustOrder
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
            this.comboHeadache = new System.Windows.Forms.ComboBox();
            this.comboCold = new System.Windows.Forms.ComboBox();
            this.medicineLabel1 = new Sunny.UI.UISymbolLabel();
            this.medicinelLabel2 = new Sunny.UI.UISymbolLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.medilLabel3 = new Sunny.UI.UISymbolLabel();
            this.comboStomache = new System.Windows.Forms.ComboBox();
            this.medicineLabel4 = new Sunny.UI.UISymbolLabel();
            this.comboMuscle = new System.Windows.Forms.ComboBox();
            this.medicinelLabel5 = new Sunny.UI.UISymbolLabel();
            this.comboSkin = new System.Windows.Forms.ComboBox();
            this.ucCustOrderOk = new Sunny.UI.UISymbolButton();
            this.ucCustOrderInit = new Sunny.UI.UISymbolButton();
            this.selectPid = new System.Windows.Forms.TextBox();
            this.custOderSymptomLabel = new Sunny.UI.UISymbolLabel();
            this.comboSyptom = new System.Windows.Forms.ComboBox();
            this.selectName = new System.Windows.Forms.TextBox();
            this.selectEffect = new System.Windows.Forms.TextBox();
            this.selectTaking = new System.Windows.Forms.TextBox();
            this.selectPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboHeadache
            // 
            this.comboHeadache.BackColor = System.Drawing.Color.White;
            this.comboHeadache.FormattingEnabled = true;
            this.comboHeadache.Items.AddRange(new object[] {
            "",
            "타이레놀정 500mg",
            "타이레놀정160mg",
            "어린이용타이레놀정 80mg",
            "어린이타이레놀현탁액"});
            this.comboHeadache.Location = new System.Drawing.Point(203, 110);
            this.comboHeadache.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboHeadache.Name = "comboHeadache";
            this.comboHeadache.Size = new System.Drawing.Size(86, 20);
            this.comboHeadache.TabIndex = 0;
            this.comboHeadache.SelectedIndexChanged += new System.EventHandler(this.comboHeadache_SelectedIndexChanged);
            // 
            // comboCold
            // 
            this.comboCold.FormattingEnabled = true;
            this.comboCold.Items.AddRange(new object[] {
            "",
            "판콜에이내복액",
            "판피린티정"});
            this.comboCold.Location = new System.Drawing.Point(203, 161);
            this.comboCold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboCold.Name = "comboCold";
            this.comboCold.Size = new System.Drawing.Size(86, 20);
            this.comboCold.TabIndex = 1;
            this.comboCold.SelectedIndexChanged += new System.EventHandler(this.comboCold_SelectedIndexChanged);
            // 
            // medicineLabel1
            // 
            this.medicineLabel1.BackColor = System.Drawing.Color.Transparent;
            this.medicineLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.medicineLabel1.ForeColor = System.Drawing.Color.Black;
            this.medicineLabel1.Location = new System.Drawing.Point(111, 108);
            this.medicineLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.medicineLabel1.Name = "medicineLabel1";
            this.medicineLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.medicineLabel1.Size = new System.Drawing.Size(86, 32);
            this.medicineLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.medicineLabel1.Symbol = 62151;
            this.medicineLabel1.SymbolColor = System.Drawing.Color.Black;
            this.medicineLabel1.TabIndex = 6;
            this.medicineLabel1.Text = "두통";
            // 
            // medicinelLabel2
            // 
            this.medicinelLabel2.BackColor = System.Drawing.Color.Transparent;
            this.medicinelLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.medicinelLabel2.ForeColor = System.Drawing.Color.Black;
            this.medicinelLabel2.Location = new System.Drawing.Point(111, 149);
            this.medicinelLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.medicinelLabel2.Name = "medicinelLabel2";
            this.medicinelLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.medicinelLabel2.Size = new System.Drawing.Size(86, 32);
            this.medicinelLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.medicinelLabel2.Symbol = 62006;
            this.medicinelLabel2.SymbolColor = System.Drawing.Color.Black;
            this.medicinelLabel2.TabIndex = 7;
            this.medicinelLabel2.Text = "감기";
            // 
            // picBox
            // 
            this.picBox.Image = global::OrderMedicine.Properties.Resources.나혼자_약사유;
            this.picBox.Location = new System.Drawing.Point(93, 229);
            this.picBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(233, 182);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 8;
            this.picBox.TabStop = false;
            // 
            // medilLabel3
            // 
            this.medilLabel3.BackColor = System.Drawing.Color.Transparent;
            this.medilLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.medilLabel3.ForeColor = System.Drawing.Color.Black;
            this.medilLabel3.Location = new System.Drawing.Point(344, 98);
            this.medilLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.medilLabel3.Name = "medilLabel3";
            this.medilLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.medilLabel3.Size = new System.Drawing.Size(86, 32);
            this.medilLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.medilLabel3.Symbol = 62005;
            this.medilLabel3.SymbolColor = System.Drawing.Color.Black;
            this.medilLabel3.TabIndex = 10;
            this.medilLabel3.Text = "소화불량";
            // 
            // comboStomache
            // 
            this.comboStomache.BackColor = System.Drawing.Color.White;
            this.comboStomache.FormattingEnabled = true;
            this.comboStomache.Items.AddRange(new object[] {
            "",
            "베아제정",
            "닥터베아제정",
            "훼스탈골드정"});
            this.comboStomache.Location = new System.Drawing.Point(458, 99);
            this.comboStomache.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboStomache.Name = "comboStomache";
            this.comboStomache.Size = new System.Drawing.Size(86, 20);
            this.comboStomache.TabIndex = 9;
            this.comboStomache.SelectedIndexChanged += new System.EventHandler(this.comboStomache_SelectedIndexChanged);
            // 
            // medicineLabel4
            // 
            this.medicineLabel4.BackColor = System.Drawing.Color.Transparent;
            this.medicineLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.medicineLabel4.ForeColor = System.Drawing.Color.Black;
            this.medicineLabel4.Location = new System.Drawing.Point(352, 136);
            this.medicineLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.medicineLabel4.Name = "medicineLabel4";
            this.medicineLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.medicineLabel4.Size = new System.Drawing.Size(86, 32);
            this.medicineLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.medicineLabel4.Symbol = 62109;
            this.medicineLabel4.SymbolColor = System.Drawing.Color.Black;
            this.medicineLabel4.TabIndex = 12;
            this.medicineLabel4.Text = "근육통";
            // 
            // comboMuscle
            // 
            this.comboMuscle.BackColor = System.Drawing.Color.White;
            this.comboMuscle.FormattingEnabled = true;
            this.comboMuscle.Items.AddRange(new object[] {
            "",
            "제일쿨파프",
            "신신파스아렉스"});
            this.comboMuscle.Location = new System.Drawing.Point(458, 137);
            this.comboMuscle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboMuscle.Name = "comboMuscle";
            this.comboMuscle.Size = new System.Drawing.Size(86, 20);
            this.comboMuscle.TabIndex = 11;
            this.comboMuscle.SelectedIndexChanged += new System.EventHandler(this.comboMuscle_SelectedIndexChanged);
            // 
            // medicinelLabel5
            // 
            this.medicinelLabel5.BackColor = System.Drawing.Color.Transparent;
            this.medicinelLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.medicinelLabel5.ForeColor = System.Drawing.Color.Black;
            this.medicinelLabel5.Location = new System.Drawing.Point(344, 173);
            this.medicinelLabel5.MinimumSize = new System.Drawing.Size(1, 1);
            this.medicinelLabel5.Name = "medicinelLabel5";
            this.medicinelLabel5.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.medicinelLabel5.Size = new System.Drawing.Size(86, 32);
            this.medicinelLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.medicinelLabel5.Symbol = 62141;
            this.medicinelLabel5.SymbolColor = System.Drawing.Color.Black;
            this.medicinelLabel5.TabIndex = 14;
            this.medicinelLabel5.Text = "피부질환";
            // 
            // comboSkin
            // 
            this.comboSkin.BackColor = System.Drawing.Color.White;
            this.comboSkin.FormattingEnabled = true;
            this.comboSkin.Items.AddRange(new object[] {
            "",
            "후시딘히드로연고",
            "복합마데카솔연고"});
            this.comboSkin.Location = new System.Drawing.Point(458, 173);
            this.comboSkin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSkin.Name = "comboSkin";
            this.comboSkin.Size = new System.Drawing.Size(86, 20);
            this.comboSkin.TabIndex = 13;
            this.comboSkin.SelectedIndexChanged += new System.EventHandler(this.comboSkin_SelectedIndexChanged);
            // 
            // ucCustOrderOk
            // 
            this.ucCustOrderOk.BackColor = System.Drawing.Color.Transparent;
            this.ucCustOrderOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucCustOrderOk.FillColor = System.Drawing.Color.SeaGreen;
            this.ucCustOrderOk.FillHoverColor = System.Drawing.Color.Maroon;
            this.ucCustOrderOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCustOrderOk.Location = new System.Drawing.Point(137, 452);
            this.ucCustOrderOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucCustOrderOk.Name = "ucCustOrderOk";
            this.ucCustOrderOk.RectColor = System.Drawing.Color.Transparent;
            this.ucCustOrderOk.Size = new System.Drawing.Size(140, 35);
            this.ucCustOrderOk.Style = Sunny.UI.UIStyle.Custom;
            this.ucCustOrderOk.SymbolSize = 30;
            this.ucCustOrderOk.TabIndex = 15;
            this.ucCustOrderOk.Text = "선택";
            this.ucCustOrderOk.Click += new System.EventHandler(this.ucCustOrderOk_Click);
            // 
            // ucCustOrderInit
            // 
            this.ucCustOrderInit.BackColor = System.Drawing.Color.Transparent;
            this.ucCustOrderInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucCustOrderInit.FillColor = System.Drawing.Color.Firebrick;
            this.ucCustOrderInit.FillHoverColor = System.Drawing.Color.Maroon;
            this.ucCustOrderInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCustOrderInit.Location = new System.Drawing.Point(324, 452);
            this.ucCustOrderInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucCustOrderInit.Name = "ucCustOrderInit";
            this.ucCustOrderInit.RectColor = System.Drawing.Color.Transparent;
            this.ucCustOrderInit.Size = new System.Drawing.Size(140, 35);
            this.ucCustOrderInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucCustOrderInit.Symbol = 61473;
            this.ucCustOrderInit.SymbolSize = 30;
            this.ucCustOrderInit.TabIndex = 16;
            this.ucCustOrderInit.Text = "초기화";
            this.ucCustOrderInit.Click += new System.EventHandler(this.ucCustOrderInit_Click);
            // 
            // selectPid
            // 
            this.selectPid.Location = new System.Drawing.Point(352, 229);
            this.selectPid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectPid.Name = "selectPid";
            this.selectPid.Size = new System.Drawing.Size(215, 21);
            this.selectPid.TabIndex = 17;
            this.selectPid.Text = "제품코드";
            this.selectPid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // custOderSymptomLabel
            // 
            this.custOderSymptomLabel.BackColor = System.Drawing.Color.Transparent;
            this.custOderSymptomLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custOderSymptomLabel.ForeColor = System.Drawing.Color.Black;
            this.custOderSymptomLabel.Location = new System.Drawing.Point(203, 45);
            this.custOderSymptomLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custOderSymptomLabel.Name = "custOderSymptomLabel";
            this.custOderSymptomLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.custOderSymptomLabel.Size = new System.Drawing.Size(86, 20);
            this.custOderSymptomLabel.Style = Sunny.UI.UIStyle.Custom;
            this.custOderSymptomLabel.Symbol = 61681;
            this.custOderSymptomLabel.SymbolColor = System.Drawing.Color.Black;
            this.custOderSymptomLabel.TabIndex = 18;
            this.custOderSymptomLabel.Text = "증상";
            // 
            // comboSyptom
            // 
            this.comboSyptom.BackColor = System.Drawing.Color.White;
            this.comboSyptom.FormattingEnabled = true;
            this.comboSyptom.Items.AddRange(new object[] {
            "",
            "두통",
            "감기",
            "소화불량",
            "근육통",
            "피부질환"});
            this.comboSyptom.Location = new System.Drawing.Point(304, 45);
            this.comboSyptom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSyptom.Name = "comboSyptom";
            this.comboSyptom.Size = new System.Drawing.Size(160, 20);
            this.comboSyptom.TabIndex = 19;
            this.comboSyptom.SelectedIndexChanged += new System.EventHandler(this.comboSyptom_SelectedIndexChanged);
            // 
            // selectName
            // 
            this.selectName.Location = new System.Drawing.Point(352, 273);
            this.selectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectName.Name = "selectName";
            this.selectName.Size = new System.Drawing.Size(215, 21);
            this.selectName.TabIndex = 20;
            this.selectName.Text = "약품명";
            this.selectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectEffect
            // 
            this.selectEffect.Location = new System.Drawing.Point(352, 314);
            this.selectEffect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectEffect.Name = "selectEffect";
            this.selectEffect.Size = new System.Drawing.Size(215, 21);
            this.selectEffect.TabIndex = 21;
            this.selectEffect.Text = "효과";
            this.selectEffect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectTaking
            // 
            this.selectTaking.Location = new System.Drawing.Point(352, 353);
            this.selectTaking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectTaking.Name = "selectTaking";
            this.selectTaking.Size = new System.Drawing.Size(215, 21);
            this.selectTaking.TabIndex = 22;
            this.selectTaking.Text = "복용법";
            this.selectTaking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectPrice
            // 
            this.selectPrice.Location = new System.Drawing.Point(352, 390);
            this.selectPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectPrice.Name = "selectPrice";
            this.selectPrice.Size = new System.Drawing.Size(215, 21);
            this.selectPrice.TabIndex = 23;
            this.selectPrice.Text = "가격";
            this.selectPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UcCustOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectPrice);
            this.Controls.Add(this.selectTaking);
            this.Controls.Add(this.selectEffect);
            this.Controls.Add(this.selectName);
            this.Controls.Add(this.comboSyptom);
            this.Controls.Add(this.custOderSymptomLabel);
            this.Controls.Add(this.selectPid);
            this.Controls.Add(this.ucCustOrderInit);
            this.Controls.Add(this.ucCustOrderOk);
            this.Controls.Add(this.medicinelLabel5);
            this.Controls.Add(this.comboSkin);
            this.Controls.Add(this.medicineLabel4);
            this.Controls.Add(this.comboMuscle);
            this.Controls.Add(this.medilLabel3);
            this.Controls.Add(this.comboStomache);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.medicinelLabel2);
            this.Controls.Add(this.medicineLabel1);
            this.Controls.Add(this.comboCold);
            this.Controls.Add(this.comboHeadache);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UcCustOrder";
            this.Size = new System.Drawing.Size(693, 514);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboHeadache;
        private System.Windows.Forms.ComboBox comboCold;
        private Sunny.UI.UISymbolLabel medicineLabel1;
        private Sunny.UI.UISymbolLabel medicinelLabel2;
        private System.Windows.Forms.PictureBox picBox;
        private Sunny.UI.UISymbolLabel medilLabel3;
        private System.Windows.Forms.ComboBox comboStomache;
        private Sunny.UI.UISymbolLabel medicineLabel4;
        private System.Windows.Forms.ComboBox comboMuscle;
        private Sunny.UI.UISymbolLabel medicinelLabel5;
        private System.Windows.Forms.ComboBox comboSkin;
        private Sunny.UI.UISymbolButton ucCustOrderOk;
        private Sunny.UI.UISymbolButton ucCustOrderInit;
        private System.Windows.Forms.TextBox selectPid;
        private Sunny.UI.UISymbolLabel custOderSymptomLabel;
        private System.Windows.Forms.ComboBox comboSyptom;
        private System.Windows.Forms.TextBox selectName;
        private System.Windows.Forms.TextBox selectEffect;
        private System.Windows.Forms.TextBox selectTaking;
        private System.Windows.Forms.TextBox selectPrice;
    }
}

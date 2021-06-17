
namespace OrderMedicine.UI
{
    partial class UcOrderStore
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
            this.storeLabel = new Sunny.UI.UISymbolLabel();
            this.comboStore = new Sunny.UI.UIComboBox();
            this.orderStoreManager = new Sunny.UI.UITextBox();
            this.orderStorePhone = new Sunny.UI.UITextBox();
            this.orderStoreAddress = new Sunny.UI.UITextBox();
            this.orderStoreInit = new Sunny.UI.UISymbolButton();
            this.orderStoreOk = new Sunny.UI.UISymbolButton();
            this.orderStoreName = new Sunny.UI.UITextBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // storeLabel
            // 
            this.storeLabel.BackColor = System.Drawing.Color.Transparent;
            this.storeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.storeLabel.Location = new System.Drawing.Point(164, 87);
            this.storeLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.storeLabel.Size = new System.Drawing.Size(125, 35);
            this.storeLabel.Symbol = 57353;
            this.storeLabel.TabIndex = 0;
            this.storeLabel.Text = "약국 목록";
            // 
            // comboStore
            // 
            this.comboStore.BackColor = System.Drawing.Color.Transparent;
            this.comboStore.FillColor = System.Drawing.Color.White;
            this.comboStore.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboStore.Items.AddRange(new object[] {
            "한사랑 약국",
            "누리 약국",
            "우리 종합 약국",
            "다나아 약국"});
            this.comboStore.Location = new System.Drawing.Point(296, 93);
            this.comboStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboStore.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboStore.Name = "comboStore";
            this.comboStore.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboStore.Size = new System.Drawing.Size(225, 29);
            this.comboStore.TabIndex = 1;
            this.comboStore.Text = "약국 선택";
            this.comboStore.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboStore.SelectedIndexChanged += new System.EventHandler(this.comboStore_SelectedIndexChanged);
            // 
            // orderStoreManager
            // 
            this.orderStoreManager.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderStoreManager.FillColor = System.Drawing.Color.White;
            this.orderStoreManager.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderStoreManager.Location = new System.Drawing.Point(344, 232);
            this.orderStoreManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderStoreManager.Maximum = 2147483647D;
            this.orderStoreManager.Minimum = -2147483648D;
            this.orderStoreManager.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderStoreManager.Name = "orderStoreManager";
            this.orderStoreManager.Padding = new System.Windows.Forms.Padding(5);
            this.orderStoreManager.Size = new System.Drawing.Size(225, 29);
            this.orderStoreManager.TabIndex = 2;
            this.orderStoreManager.Text = "매니저";
            // 
            // orderStorePhone
            // 
            this.orderStorePhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderStorePhone.FillColor = System.Drawing.Color.White;
            this.orderStorePhone.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderStorePhone.Location = new System.Drawing.Point(344, 289);
            this.orderStorePhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderStorePhone.Maximum = 2147483647D;
            this.orderStorePhone.Minimum = -2147483648D;
            this.orderStorePhone.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderStorePhone.Name = "orderStorePhone";
            this.orderStorePhone.Padding = new System.Windows.Forms.Padding(5);
            this.orderStorePhone.Size = new System.Drawing.Size(225, 29);
            this.orderStorePhone.TabIndex = 3;
            this.orderStorePhone.Text = "전화번호";
            // 
            // orderStoreAddress
            // 
            this.orderStoreAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderStoreAddress.FillColor = System.Drawing.Color.White;
            this.orderStoreAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderStoreAddress.Location = new System.Drawing.Point(344, 339);
            this.orderStoreAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderStoreAddress.Maximum = 2147483647D;
            this.orderStoreAddress.Minimum = -2147483648D;
            this.orderStoreAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderStoreAddress.Name = "orderStoreAddress";
            this.orderStoreAddress.Padding = new System.Windows.Forms.Padding(5);
            this.orderStoreAddress.Size = new System.Drawing.Size(225, 29);
            this.orderStoreAddress.TabIndex = 3;
            this.orderStoreAddress.Text = "위치";
            // 
            // orderStoreInit
            // 
            this.orderStoreInit.BackColor = System.Drawing.Color.Transparent;
            this.orderStoreInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderStoreInit.FillColor = System.Drawing.Color.Firebrick;
            this.orderStoreInit.FillHoverColor = System.Drawing.Color.DarkRed;
            this.orderStoreInit.FillSelectedColor = System.Drawing.Color.DarkRed;
            this.orderStoreInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderStoreInit.Location = new System.Drawing.Point(330, 414);
            this.orderStoreInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderStoreInit.Name = "orderStoreInit";
            this.orderStoreInit.RectColor = System.Drawing.Color.Transparent;
            this.orderStoreInit.Size = new System.Drawing.Size(160, 39);
            this.orderStoreInit.Style = Sunny.UI.UIStyle.Custom;
            this.orderStoreInit.Symbol = 61473;
            this.orderStoreInit.TabIndex = 12;
            this.orderStoreInit.Text = "초기화";
            this.orderStoreInit.Click += new System.EventHandler(this.orderStoreInit_Click);
            // 
            // orderStoreOk
            // 
            this.orderStoreOk.BackColor = System.Drawing.Color.Transparent;
            this.orderStoreOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orderStoreOk.FillColor = System.Drawing.Color.SeaGreen;
            this.orderStoreOk.FillHoverColor = System.Drawing.Color.DarkGreen;
            this.orderStoreOk.FillPressColor = System.Drawing.Color.DarkGreen;
            this.orderStoreOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderStoreOk.Location = new System.Drawing.Point(151, 414);
            this.orderStoreOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderStoreOk.Name = "orderStoreOk";
            this.orderStoreOk.RectColor = System.Drawing.Color.Transparent;
            this.orderStoreOk.Size = new System.Drawing.Size(160, 39);
            this.orderStoreOk.Style = Sunny.UI.UIStyle.Custom;
            this.orderStoreOk.TabIndex = 11;
            this.orderStoreOk.Text = "추가";
            this.orderStoreOk.Click += new System.EventHandler(this.orderStoreOk_Click);
            // 
            // orderStoreName
            // 
            this.orderStoreName.BackColor = System.Drawing.Color.Transparent;
            this.orderStoreName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderStoreName.FillColor = System.Drawing.Color.White;
            this.orderStoreName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.orderStoreName.Location = new System.Drawing.Point(344, 179);
            this.orderStoreName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orderStoreName.Maximum = 2147483647D;
            this.orderStoreName.Minimum = -2147483648D;
            this.orderStoreName.MinimumSize = new System.Drawing.Size(1, 1);
            this.orderStoreName.Name = "orderStoreName";
            this.orderStoreName.Padding = new System.Windows.Forms.Padding(5);
            this.orderStoreName.Size = new System.Drawing.Size(225, 29);
            this.orderStoreName.TabIndex = 3;
            this.orderStoreName.Text = "약국명";
            // 
            // picBox
            // 
            this.picBox.Image = global::OrderMedicine.Properties.Resources.나혼자_약사유;
            this.picBox.Location = new System.Drawing.Point(103, 179);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(208, 189);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 13;
            this.picBox.TabStop = false;
            // 
            // UcOrderStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.orderStoreName);
            this.Controls.Add(this.orderStoreInit);
            this.Controls.Add(this.orderStoreOk);
            this.Controls.Add(this.orderStoreAddress);
            this.Controls.Add(this.orderStorePhone);
            this.Controls.Add(this.orderStoreManager);
            this.Controls.Add(this.comboStore);
            this.Controls.Add(this.storeLabel);
            this.Name = "UcOrderStore";
            this.Size = new System.Drawing.Size(693, 514);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel storeLabel;
        private Sunny.UI.UIComboBox comboStore;
        private Sunny.UI.UITextBox orderStoreManager;
        private Sunny.UI.UITextBox orderStorePhone;
        private Sunny.UI.UITextBox orderStoreAddress;
        private Sunny.UI.UISymbolButton orderStoreInit;
        private Sunny.UI.UISymbolButton orderStoreOk;
        private Sunny.UI.UITextBox orderStoreName;
        private System.Windows.Forms.PictureBox picBox;
    }
}

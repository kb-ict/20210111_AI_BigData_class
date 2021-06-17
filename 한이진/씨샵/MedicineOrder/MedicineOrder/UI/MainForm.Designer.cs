
namespace MedicineOrder
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewBtn = new System.Windows.Forms.Button();
            this.addDataBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.delAllBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.mainExitBtn = new Sunny.UI.UISymbolButton();
            this.appInfo = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // viewBtn
            // 
            this.viewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.viewBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.viewBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewBtn.Location = new System.Drawing.Point(613, 211);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(255, 82);
            this.viewBtn.TabIndex = 1;
            this.viewBtn.Text = "데이터 보기";
            this.viewBtn.UseVisualStyleBackColor = false;
            this.viewBtn.Click += new System.EventHandler(this.viewBtn_Click);
            // 
            // addDataBtn
            // 
            this.addDataBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addDataBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.addDataBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addDataBtn.Location = new System.Drawing.Point(613, 125);
            this.addDataBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDataBtn.Name = "addDataBtn";
            this.addDataBtn.Size = new System.Drawing.Size(255, 82);
            this.addDataBtn.TabIndex = 2;
            this.addDataBtn.Text = "데이터 추가";
            this.addDataBtn.UseVisualStyleBackColor = false;
            this.addDataBtn.Click += new System.EventHandler(this.addDataBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.delBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delBtn.Location = new System.Drawing.Point(613, 297);
            this.delBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(255, 82);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "데이터 삭제";
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // delAllBtn
            // 
            this.delAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delAllBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.delAllBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delAllBtn.Location = new System.Drawing.Point(613, 469);
            this.delAllBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delAllBtn.Name = "delAllBtn";
            this.delAllBtn.Size = new System.Drawing.Size(255, 82);
            this.delAllBtn.TabIndex = 6;
            this.delAllBtn.Text = "데이터 초기화";
            this.delAllBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.updateBtn.Location = new System.Drawing.Point(613, 383);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(255, 82);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "데이터 수정";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // mainExitBtn
            // 
            this.mainExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.mainExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExitBtn.FillColor = System.Drawing.Color.LightCoral;
            this.mainExitBtn.FillDisableColor = System.Drawing.Color.Transparent;
            this.mainExitBtn.FillHoverColor = System.Drawing.Color.Maroon;
            this.mainExitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExitBtn.IsCircle = true;
            this.mainExitBtn.Location = new System.Drawing.Point(997, 42);
            this.mainExitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainExitBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExitBtn.Name = "mainExitBtn";
            this.mainExitBtn.Size = new System.Drawing.Size(71, 71);
            this.mainExitBtn.Style = Sunny.UI.UIStyle.Custom;
            this.mainExitBtn.Symbol = 61457;
            this.mainExitBtn.SymbolSize = 40;
            this.mainExitBtn.TabIndex = 8;
            this.mainExitBtn.Click += new System.EventHandler(this.mainExitBtn_Click);
            // 
            // appInfo
            // 
            this.appInfo.BackColor = System.Drawing.Color.Transparent;
            this.appInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appInfo.FillColor = System.Drawing.Color.LightSeaGreen;
            this.appInfo.FillDisableColor = System.Drawing.Color.Transparent;
            this.appInfo.FillHoverColor = System.Drawing.Color.DarkSlateGray;
            this.appInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.appInfo.IsCircle = true;
            this.appInfo.Location = new System.Drawing.Point(912, 42);
            this.appInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.appInfo.Name = "appInfo";
            this.appInfo.Size = new System.Drawing.Size(71, 71);
            this.appInfo.Style = Sunny.UI.UIStyle.Custom;
            this.appInfo.Symbol = 61736;
            this.appInfo.SymbolSize = 40;
            this.appInfo.TabIndex = 9;
            this.appInfo.Click += new System.EventHandler(this.appInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 708);
            this.Controls.Add(this.appInfo);
            this.Controls.Add(this.mainExitBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.delAllBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addDataBtn);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "나혼자약산다 v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Button addDataBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button delAllBtn;
        private System.Windows.Forms.Button updateBtn;
        private Sunny.UI.UISymbolButton mainExitBtn;
        private Sunny.UI.UISymbolButton appInfo;
    }
}



namespace OrderMedicine
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
            this.mainPic = new System.Windows.Forms.PictureBox();
            this.custBtn = new Sunny.UI.UISymbolButton();
            this.stoBtn = new Sunny.UI.UISymbolButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.mainLabel = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPic
            // 
            this.mainPic.BackColor = System.Drawing.Color.Transparent;
            this.mainPic.Image = ((System.Drawing.Image)(resources.GetObject("mainPic.Image")));
            this.mainPic.Location = new System.Drawing.Point(405, 115);
            this.mainPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPic.Name = "mainPic";
            this.mainPic.Size = new System.Drawing.Size(218, 235);
            this.mainPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainPic.TabIndex = 0;
            this.mainPic.TabStop = false;
            // 
            // custBtn
            // 
            this.custBtn.BackColor = System.Drawing.Color.Transparent;
            this.custBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custBtn.FillColor = System.Drawing.Color.RosyBrown;
            this.custBtn.FillHoverColor = System.Drawing.Color.Maroon;
            this.custBtn.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custBtn.Location = new System.Drawing.Point(110, 354);
            this.custBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.custBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.custBtn.Name = "custBtn";
            this.custBtn.RectColor = System.Drawing.Color.Transparent;
            this.custBtn.Size = new System.Drawing.Size(259, 219);
            this.custBtn.Style = Sunny.UI.UIStyle.Custom;
            this.custBtn.Symbol = 62142;
            this.custBtn.SymbolSize = 50;
            this.custBtn.TabIndex = 1;
            this.custBtn.Text = "고객용";
            this.custBtn.Click += new System.EventHandler(this.custBtn_Click);
            // 
            // stoBtn
            // 
            this.stoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stoBtn.FillColor = System.Drawing.Color.SteelBlue;
            this.stoBtn.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoBtn.Location = new System.Drawing.Point(635, 354);
            this.stoBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stoBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.stoBtn.Name = "stoBtn";
            this.stoBtn.Size = new System.Drawing.Size(259, 219);
            this.stoBtn.Style = Sunny.UI.UIStyle.Custom;
            this.stoBtn.Symbol = 62004;
            this.stoBtn.SymbolSize = 50;
            this.stoBtn.TabIndex = 2;
            this.stoBtn.Text = "약국용";
            this.stoBtn.Click += new System.EventHandler(this.stoBtn_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.DarkRed;
            this.mainExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.Location = new System.Drawing.Point(991, 32);
            this.mainExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.Size = new System.Drawing.Size(35, 39);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61453;
            this.mainExit.SymbolSize = 30;
            this.mainExit.TabIndex = 3;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.FillColor = System.Drawing.Color.Orange;
            this.uiSymbolButton1.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(949, 32);
            this.uiSymbolButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton1.Size = new System.Drawing.Size(35, 39);
            this.uiSymbolButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton1.Symbol = 61736;
            this.uiSymbolButton1.SymbolSize = 30;
            this.uiSymbolButton1.TabIndex = 4;
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.BackColor = System.Drawing.Color.Transparent;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mainLabel.Location = new System.Drawing.Point(383, 32);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.mainLabel.Size = new System.Drawing.Size(240, 32);
            this.mainLabel.Style = Sunny.UI.UIStyle.Custom;
            this.mainLabel.Symbol = 61690;
            this.mainLabel.SymbolColor = System.Drawing.Color.Firebrick;
            this.mainLabel.TabIndex = 5;
            this.mainLabel.Text = "나혼자약산다 v1.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 744);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.uiSymbolButton1);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.stoBtn);
            this.Controls.Add(this.custBtn);
            this.Controls.Add(this.mainPic);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.mainPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPic;
        private Sunny.UI.UISymbolButton custBtn;
        private Sunny.UI.UISymbolButton stoBtn;
        private Sunny.UI.UISymbolButton mainExit;
        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolLabel mainLabel;
    }
}


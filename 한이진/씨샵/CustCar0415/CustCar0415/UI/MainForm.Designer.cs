
namespace CustCar0415
{
    partial class MainWin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.carPic = new System.Windows.Forms.PictureBox();
            this.randAddBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataUpdateBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataALLBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dataAddBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.randDelBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainExit = new Sunny.UI.UISymbolButton();
            this.dataDelBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.help = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTitle = new Sunny.UI.UISymbolLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // carPic
            // 
            this.carPic.BackColor = System.Drawing.Color.Transparent;
            this.carPic.Image = ((System.Drawing.Image)(resources.GetObject("carPic.Image")));
            this.carPic.Location = new System.Drawing.Point(30, 137);
            this.carPic.Name = "carPic";
            this.carPic.Size = new System.Drawing.Size(411, 412);
            this.carPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carPic.TabIndex = 0;
            this.carPic.TabStop = false;
            // 
            // randAddBtn
            // 
            this.randAddBtn.BackColor = System.Drawing.Color.Turquoise;
            this.randAddBtn.Depth = 0;
            this.randAddBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.randAddBtn.ForeColor = System.Drawing.Color.Maroon;
            this.randAddBtn.Location = new System.Drawing.Point(0, 63);
            this.randAddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.randAddBtn.Name = "randAddBtn";
            this.randAddBtn.Primary = true;
            this.randAddBtn.Size = new System.Drawing.Size(128, 52);
            this.randAddBtn.TabIndex = 1;
            this.randAddBtn.Text = "랜덤데이터 추가";
            this.randAddBtn.UseVisualStyleBackColor = false;
            this.randAddBtn.Click += new System.EventHandler(this.randAddBtn_Click);
            // 
            // dataUpdateBtn
            // 
            this.dataUpdateBtn.BackColor = System.Drawing.Color.Turquoise;
            this.dataUpdateBtn.Depth = 0;
            this.dataUpdateBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataUpdateBtn.ForeColor = System.Drawing.Color.Maroon;
            this.dataUpdateBtn.Location = new System.Drawing.Point(499, 63);
            this.dataUpdateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dataUpdateBtn.Name = "dataUpdateBtn";
            this.dataUpdateBtn.Primary = true;
            this.dataUpdateBtn.Size = new System.Drawing.Size(128, 52);
            this.dataUpdateBtn.TabIndex = 2;
            this.dataUpdateBtn.Text = "데이터 수정";
            this.dataUpdateBtn.UseVisualStyleBackColor = false;
            this.dataUpdateBtn.Click += new System.EventHandler(this.dataUpdateBtn_Click);
            // 
            // dataALLBtn
            // 
            this.dataALLBtn.BackColor = System.Drawing.Color.Turquoise;
            this.dataALLBtn.Depth = 0;
            this.dataALLBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataALLBtn.ForeColor = System.Drawing.Color.Maroon;
            this.dataALLBtn.Location = new System.Drawing.Point(250, 63);
            this.dataALLBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dataALLBtn.Name = "dataALLBtn";
            this.dataALLBtn.Primary = true;
            this.dataALLBtn.Size = new System.Drawing.Size(128, 52);
            this.dataALLBtn.TabIndex = 3;
            this.dataALLBtn.Text = "데이터 보기";
            this.dataALLBtn.UseVisualStyleBackColor = false;
            this.dataALLBtn.Click += new System.EventHandler(this.dataALLBtn_Click);
            // 
            // dataAddBtn
            // 
            this.dataAddBtn.BackColor = System.Drawing.Color.Turquoise;
            this.dataAddBtn.Depth = 0;
            this.dataAddBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataAddBtn.ForeColor = System.Drawing.Color.Maroon;
            this.dataAddBtn.Location = new System.Drawing.Point(374, 63);
            this.dataAddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dataAddBtn.Name = "dataAddBtn";
            this.dataAddBtn.Primary = true;
            this.dataAddBtn.Size = new System.Drawing.Size(128, 52);
            this.dataAddBtn.TabIndex = 4;
            this.dataAddBtn.Text = "데이터 추가";
            this.dataAddBtn.UseVisualStyleBackColor = false;
            this.dataAddBtn.Click += new System.EventHandler(this.dataAddBtn_Click);
            // 
            // randDelBtn
            // 
            this.randDelBtn.BackColor = System.Drawing.Color.Turquoise;
            this.randDelBtn.Depth = 0;
            this.randDelBtn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.randDelBtn.ForeColor = System.Drawing.Color.Maroon;
            this.randDelBtn.Location = new System.Drawing.Point(125, 63);
            this.randDelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.randDelBtn.Name = "randDelBtn";
            this.randDelBtn.Primary = true;
            this.randDelBtn.Size = new System.Drawing.Size(128, 52);
            this.randDelBtn.TabIndex = 5;
            this.randDelBtn.Text = "랜덤데이터 삭제";
            this.randDelBtn.UseVisualStyleBackColor = false;
            this.randDelBtn.Click += new System.EventHandler(this.randDelBtn_Click);
            // 
            // mainExit
            // 
            this.mainExit.BackColor = System.Drawing.Color.Transparent;
            this.mainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExit.FillColor = System.Drawing.Color.IndianRed;
            this.mainExit.FillHoverColor = System.Drawing.Color.SteelBlue;
            this.mainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainExit.IsCircle = true;
            this.mainExit.Location = new System.Drawing.Point(821, 63);
            this.mainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainExit.Name = "mainExit";
            this.mainExit.RectColor = System.Drawing.Color.Transparent;
            this.mainExit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainExit.Size = new System.Drawing.Size(63, 48);
            this.mainExit.Style = Sunny.UI.UIStyle.Custom;
            this.mainExit.Symbol = 61457;
            this.mainExit.SymbolSize = 40;
            this.mainExit.TabIndex = 6;
            this.mainExit.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // dataDelBtn
            // 
            this.dataDelBtn.BackColor = System.Drawing.Color.Turquoise;
            this.dataDelBtn.Depth = 0;
            this.dataDelBtn.ForeColor = System.Drawing.Color.Maroon;
            this.dataDelBtn.Location = new System.Drawing.Point(624, 63);
            this.dataDelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dataDelBtn.Name = "dataDelBtn";
            this.dataDelBtn.Primary = true;
            this.dataDelBtn.Size = new System.Drawing.Size(128, 52);
            this.dataDelBtn.TabIndex = 7;
            this.dataDelBtn.Text = "데이터 삭제";
            this.dataDelBtn.UseVisualStyleBackColor = false;
            this.dataDelBtn.Click += new System.EventHandler(this.dataDelBtn_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.help.FillColor = System.Drawing.Color.SandyBrown;
            this.help.FillHoverColor = System.Drawing.Color.SteelBlue;
            this.help.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.help.IsCircle = true;
            this.help.Location = new System.Drawing.Point(758, 63);
            this.help.MinimumSize = new System.Drawing.Size(1, 1);
            this.help.Name = "help";
            this.help.RectColor = System.Drawing.Color.Transparent;
            this.help.Size = new System.Drawing.Size(72, 48);
            this.help.Style = Sunny.UI.UIStyle.Custom;
            this.help.Symbol = 61736;
            this.help.SymbolSize = 40;
            this.help.TabIndex = 8;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // mainTitle
            // 
            this.mainTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.mainTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.mainTitle.Location = new System.Drawing.Point(12, 12);
            this.mainTitle.MinimumSize = new System.Drawing.Size(1, 1);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.mainTitle.Size = new System.Drawing.Size(189, 29);
            this.mainTitle.Style = Sunny.UI.UIStyle.Custom;
            this.mainTitle.StyleCustomMode = true;
            this.mainTitle.Symbol = 57601;
            this.mainTitle.SymbolColor = System.Drawing.Color.DarkOrange;
            this.mainTitle.TabIndex = 10;
            this.mainTitle.Text = "고객차랑관리앱 v1.1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(30, 493);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(486, 508);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(356, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // MainWin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(887, 598);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.help);
            this.Controls.Add(this.dataDelBtn);
            this.Controls.Add(this.mainExit);
            this.Controls.Add(this.randDelBtn);
            this.Controls.Add(this.dataAddBtn);
            this.Controls.Add(this.dataALLBtn);
            this.Controls.Add(this.dataUpdateBtn);
            this.Controls.Add(this.randAddBtn);
            this.Controls.Add(this.carPic);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "MainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox carPic;
        private MaterialSkin.Controls.MaterialRaisedButton randAddBtn;
        private MaterialSkin.Controls.MaterialRaisedButton dataUpdateBtn;
        private MaterialSkin.Controls.MaterialRaisedButton dataALLBtn;
        private MaterialSkin.Controls.MaterialRaisedButton dataAddBtn;
        private MaterialSkin.Controls.MaterialRaisedButton randDelBtn;
        private Sunny.UI.UISymbolButton mainExit;
        private MaterialSkin.Controls.MaterialRaisedButton dataDelBtn;
        private Sunny.UI.UISymbolButton help;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolLabel mainTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}


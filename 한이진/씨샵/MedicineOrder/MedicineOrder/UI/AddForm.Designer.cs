
namespace MedicineOrder.UI
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.custAddBtn = new System.Windows.Forms.Button();
            this.stoAddBtn = new System.Windows.Forms.Button();
            this.mediAddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(111, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // custAddBtn
            // 
            this.custAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.custAddBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.custAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.custAddBtn.Location = new System.Drawing.Point(619, 144);
            this.custAddBtn.Name = "custAddBtn";
            this.custAddBtn.Size = new System.Drawing.Size(255, 83);
            this.custAddBtn.TabIndex = 3;
            this.custAddBtn.Text = "고객 데이터 추가";
            this.custAddBtn.UseVisualStyleBackColor = false;
            this.custAddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // stoAddBtn
            // 
            this.stoAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stoAddBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.stoAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.stoAddBtn.Location = new System.Drawing.Point(619, 435);
            this.stoAddBtn.Name = "stoAddBtn";
            this.stoAddBtn.Size = new System.Drawing.Size(255, 83);
            this.stoAddBtn.TabIndex = 4;
            this.stoAddBtn.Text = "약국 데이터 추가";
            this.stoAddBtn.UseVisualStyleBackColor = false;
            this.stoAddBtn.Click += new System.EventHandler(this.stoAddBtn_Click);
            // 
            // mediAddBtn
            // 
            this.mediAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mediAddBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.mediAddBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mediAddBtn.Location = new System.Drawing.Point(619, 292);
            this.mediAddBtn.Name = "mediAddBtn";
            this.mediAddBtn.Size = new System.Drawing.Size(255, 83);
            this.mediAddBtn.TabIndex = 5;
            this.mediAddBtn.Text = "약품 데이터 추가";
            this.mediAddBtn.UseVisualStyleBackColor = false;
            this.mediAddBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 707);
            this.Controls.Add(this.mediAddBtn);
            this.Controls.Add(this.stoAddBtn);
            this.Controls.Add(this.custAddBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button custAddBtn;
        private System.Windows.Forms.Button stoAddBtn;
        private System.Windows.Forms.Button mediAddBtn;
    }
}
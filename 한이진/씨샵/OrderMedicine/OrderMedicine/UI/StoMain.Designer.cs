
namespace OrderMedicine.UI
{
    partial class StoMain
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
            this.stoMainExit = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // stoMainExit
            // 
            this.stoMainExit.BackColor = System.Drawing.Color.Transparent;
            this.stoMainExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stoMainExit.FillColor = System.Drawing.Color.DarkRed;
            this.stoMainExit.FillDisableColor = System.Drawing.Color.Transparent;
            this.stoMainExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.stoMainExit.Location = new System.Drawing.Point(867, 29);
            this.stoMainExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.stoMainExit.Name = "stoMainExit";
            this.stoMainExit.RectColor = System.Drawing.Color.Transparent;
            this.stoMainExit.Size = new System.Drawing.Size(31, 31);
            this.stoMainExit.Style = Sunny.UI.UIStyle.Custom;
            this.stoMainExit.Symbol = 61453;
            this.stoMainExit.SymbolSize = 30;
            this.stoMainExit.TabIndex = 4;
            this.stoMainExit.Click += new System.EventHandler(this.stoMainExit_Click);
            // 
            // StoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 595);
            this.Controls.Add(this.stoMainExit);
            this.Name = "StoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton stoMainExit;
    }
}

namespace ReadWriteJson0616
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.bnt_MemberWrite = new System.Windows.Forms.Button();
            this.btn_MemberRead = new System.Windows.Forms.Button();
            this.MemberView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_tel = new System.Windows.Forms.TextBox();
            this.tb_address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MemberView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bnt_MemberWrite
            // 
            this.bnt_MemberWrite.Location = new System.Drawing.Point(71, 48);
            this.bnt_MemberWrite.Name = "bnt_MemberWrite";
            this.bnt_MemberWrite.Size = new System.Drawing.Size(83, 33);
            this.bnt_MemberWrite.TabIndex = 1;
            this.bnt_MemberWrite.Text = "데이터 추가";
            this.bnt_MemberWrite.UseVisualStyleBackColor = true;
            this.bnt_MemberWrite.Click += new System.EventHandler(this.bnt_MemberWrite_Click);
            // 
            // btn_MemberRead
            // 
            this.btn_MemberRead.Location = new System.Drawing.Point(175, 48);
            this.btn_MemberRead.Name = "btn_MemberRead";
            this.btn_MemberRead.Size = new System.Drawing.Size(83, 33);
            this.btn_MemberRead.TabIndex = 2;
            this.btn_MemberRead.Text = "데이터 읽기";
            this.btn_MemberRead.UseVisualStyleBackColor = true;
            this.btn_MemberRead.Click += new System.EventHandler(this.btn_MemberRead_Click);
            // 
            // MemberView
            // 
            this.MemberView.AutoGenerateColumns = false;
            this.MemberView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pwDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.MemberView.DataSource = this.memberBindingSource;
            this.MemberView.Location = new System.Drawing.Point(71, 150);
            this.MemberView.Name = "MemberView";
            this.MemberView.RowTemplate.Height = 23;
            this.MemberView.Size = new System.Drawing.Size(649, 251);
            this.MemberView.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // pwDataGridViewTextBoxColumn
            // 
            this.pwDataGridViewTextBoxColumn.DataPropertyName = "pw";
            this.pwDataGridViewTextBoxColumn.HeaderText = "pw";
            this.pwDataGridViewTextBoxColumn.Name = "pwDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataSource = typeof(ReadWriteJson0616.Member);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(75, 102);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(131, 21);
            this.tb_id.TabIndex = 4;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(212, 102);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(131, 21);
            this.tb_name.TabIndex = 5;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(349, 102);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(131, 21);
            this.tb_pw.TabIndex = 6;
            // 
            // tb_tel
            // 
            this.tb_tel.Location = new System.Drawing.Point(486, 102);
            this.tb_tel.Name = "tb_tel";
            this.tb_tel.Size = new System.Drawing.Size(131, 21);
            this.tb_tel.TabIndex = 7;
            // 
            // tb_address
            // 
            this.tb_address.Location = new System.Drawing.Point(623, 102);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(131, 21);
            this.tb_address.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_address);
            this.Controls.Add(this.tb_tel);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.MemberView);
            this.Controls.Add(this.btn_MemberRead);
            this.Controls.Add(this.bnt_MemberWrite);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.MemberView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button bnt_MemberWrite;
        private System.Windows.Forms.Button btn_MemberRead;
        private System.Windows.Forms.DataGridView MemberView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_tel;
        private System.Windows.Forms.TextBox tb_address;
    }
}
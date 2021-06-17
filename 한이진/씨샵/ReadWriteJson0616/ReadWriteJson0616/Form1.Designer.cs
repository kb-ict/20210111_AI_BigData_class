
namespace ReadWriteJson0616
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.but_write = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.studentsView = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_hakbeon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_api = new System.Windows.Forms.Button();
            this.facilityView = new System.Windows.Forms.DataGridView();
            this.gotoForm2 = new System.Windows.Forms.Button();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allpeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakbeonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goDataview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // but_write
            // 
            this.but_write.Location = new System.Drawing.Point(41, 25);
            this.but_write.Name = "but_write";
            this.but_write.Size = new System.Drawing.Size(83, 33);
            this.but_write.TabIndex = 0;
            this.but_write.Text = "데이터 추가";
            this.but_write.UseVisualStyleBackColor = true;
            this.but_write.Click += new System.EventHandler(this.but_write_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(130, 25);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(83, 33);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "데이터 읽기";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // studentsView
            // 
            this.studentsView.AutoGenerateColumns = false;
            this.studentsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.hakbeonDataGridViewTextBoxColumn});
            this.studentsView.DataSource = this.studentBindingSource;
            this.studentsView.Location = new System.Drawing.Point(27, 142);
            this.studentsView.Name = "studentsView";
            this.studentsView.RowTemplate.Height = 23;
            this.studentsView.Size = new System.Drawing.Size(363, 211);
            this.studentsView.TabIndex = 2;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(27, 93);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(111, 21);
            this.textBox_name.TabIndex = 3;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(144, 93);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(111, 21);
            this.textBox_age.TabIndex = 4;
            // 
            // textBox_hakbeon
            // 
            this.textBox_hakbeon.Location = new System.Drawing.Point(261, 93);
            this.textBox_hakbeon.Name = "textBox_hakbeon";
            this.textBox_hakbeon.Size = new System.Drawing.Size(111, 21);
            this.textBox_hakbeon.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "학번";
            // 
            // btn_api
            // 
            this.btn_api.Location = new System.Drawing.Point(418, 30);
            this.btn_api.Name = "btn_api";
            this.btn_api.Size = new System.Drawing.Size(105, 23);
            this.btn_api.TabIndex = 9;
            this.btn_api.Text = "공공데이터 보기";
            this.btn_api.UseVisualStyleBackColor = true;
            this.btn_api.Click += new System.EventHandler(this.btn_api_Click);
            // 
            // facilityView
            // 
            this.facilityView.AutoGenerateColumns = false;
            this.facilityView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facilityView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.allpeopleDataGridViewTextBoxColumn,
            this.peopleDataGridViewTextBoxColumn});
            this.facilityView.DataSource = this.facilityBindingSource;
            this.facilityView.Location = new System.Drawing.Point(418, 78);
            this.facilityView.Name = "facilityView";
            this.facilityView.RowTemplate.Height = 23;
            this.facilityView.Size = new System.Drawing.Size(356, 211);
            this.facilityView.TabIndex = 10;
            // 
            // gotoForm2
            // 
            this.gotoForm2.Location = new System.Drawing.Point(418, 323);
            this.gotoForm2.Name = "gotoForm2";
            this.gotoForm2.Size = new System.Drawing.Size(159, 90);
            this.gotoForm2.TabIndex = 11;
            this.gotoForm2.Text = "회원관리";
            this.gotoForm2.UseVisualStyleBackColor = true;
            this.gotoForm2.Click += new System.EventHandler(this.gotoForm2_Click);
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // allpeopleDataGridViewTextBoxColumn
            // 
            this.allpeopleDataGridViewTextBoxColumn.DataPropertyName = "allpeople";
            this.allpeopleDataGridViewTextBoxColumn.HeaderText = "allpeople";
            this.allpeopleDataGridViewTextBoxColumn.Name = "allpeopleDataGridViewTextBoxColumn";
            // 
            // peopleDataGridViewTextBoxColumn
            // 
            this.peopleDataGridViewTextBoxColumn.DataPropertyName = "people";
            this.peopleDataGridViewTextBoxColumn.HeaderText = "people";
            this.peopleDataGridViewTextBoxColumn.Name = "peopleDataGridViewTextBoxColumn";
            // 
            // facilityBindingSource
            // 
            this.facilityBindingSource.DataSource = typeof(ReadWriteJson0616.Facility);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "나이";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // hakbeonDataGridViewTextBoxColumn
            // 
            this.hakbeonDataGridViewTextBoxColumn.DataPropertyName = "hakbeon";
            this.hakbeonDataGridViewTextBoxColumn.HeaderText = "학번";
            this.hakbeonDataGridViewTextBoxColumn.Name = "hakbeonDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(ReadWriteJson0616.Student);
            // 
            // goDataview
            // 
            this.goDataview.Location = new System.Drawing.Point(615, 323);
            this.goDataview.Name = "goDataview";
            this.goDataview.Size = new System.Drawing.Size(159, 90);
            this.goDataview.TabIndex = 12;
            this.goDataview.Text = "공공포털";
            this.goDataview.UseVisualStyleBackColor = true;
            this.goDataview.Click += new System.EventHandler(this.goDataview_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goDataview);
            this.Controls.Add(this.gotoForm2);
            this.Controls.Add(this.facilityView);
            this.Controls.Add(this.btn_api);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_hakbeon);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.studentsView);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.but_write);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.studentsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facilityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.DataGridView studentsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakbeonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        public System.Windows.Forms.Button but_write;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_hakbeon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_api;
        private System.Windows.Forms.DataGridView facilityView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allpeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facilityBindingSource;
        private System.Windows.Forms.Button gotoForm2;
        private System.Windows.Forms.Button goDataview;
    }
}


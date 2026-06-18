namespace QanLy
{
    partial class ucSinhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSinhVien = new System.Windows.Forms.Panel();
            this.btnTimSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaSvs = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoT = new System.Windows.Forms.Label();
            this.textHoTen = new System.Windows.Forms.TextBox();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoiSV = new System.Windows.Forms.Button();
            this.btnXoaSV = new System.Windows.Forms.Button();
            this.btnSuaSV = new System.Windows.Forms.Button();
            this.btnThemSV = new System.Windows.Forms.Button();
            this.pnlSinhVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSinhVien
            // 
            this.pnlSinhVien.Controls.Add(this.btnTimSV);
            this.pnlSinhVien.Controls.Add(this.groupBox1);
            this.pnlSinhVien.Controls.Add(this.dgvSinhVien);
            this.pnlSinhVien.Controls.Add(this.label2);
            this.pnlSinhVien.Controls.Add(this.txtTimKiem);
            this.pnlSinhVien.Controls.Add(this.btnLamMoiSV);
            this.pnlSinhVien.Controls.Add(this.btnXoaSV);
            this.pnlSinhVien.Controls.Add(this.btnSuaSV);
            this.pnlSinhVien.Controls.Add(this.btnThemSV);
            this.pnlSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSinhVien.Location = new System.Drawing.Point(0, 0);
            this.pnlSinhVien.Name = "pnlSinhVien";
            this.pnlSinhVien.Size = new System.Drawing.Size(2066, 1035);
            this.pnlSinhVien.TabIndex = 1;
            // 
            // btnTimSV
            // 
            this.btnTimSV.Location = new System.Drawing.Point(1301, 42);
            this.btnTimSV.Name = "btnTimSV";
            this.btnTimSV.Size = new System.Drawing.Size(191, 83);
            this.btnTimSV.TabIndex = 39;
            this.btnTimSV.Text = "Tìm";
            this.btnTimSV.UseVisualStyleBackColor = true;
            this.btnTimSV.Click += new System.EventHandler(this.btnTimSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.txtMaSvs);
            this.groupBox1.Controls.Add(this.cbLop);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoT);
            this.groupBox1.Controls.Add(this.textHoTen);
            this.groupBox1.Location = new System.Drawing.Point(64, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 662);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(22, 108);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(500, 44);
            this.txtMaSV.TabIndex = 29;
            this.txtMaSV.TextChanged += new System.EventHandler(this.txtMaSV_TextChanged);
            // 
            // txtMaSvs
            // 
            this.txtMaSvs.AutoSize = true;
            this.txtMaSvs.Location = new System.Drawing.Point(15, 54);
            this.txtMaSvs.Name = "txtMaSvs";
            this.txtMaSvs.Size = new System.Drawing.Size(195, 37);
            this.txtMaSvs.TabIndex = 28;
            this.txtMaSvs.Text = "Mã sinh viên";
            // 
            // cbLop
            // 
            this.cbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(22, 570);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(500, 45);
            this.cbLop.TabIndex = 27;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(22, 458);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(500, 45);
            this.cboGioiTinh.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 517);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 37);
            this.label5.TabIndex = 25;
            this.label5.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "Giới tính";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(22, 343);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(500, 44);
            this.dtpNgaySinh.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày sinh";
            // 
            // txtHoT
            // 
            this.txtHoT.AutoSize = true;
            this.txtHoT.Location = new System.Drawing.Point(15, 175);
            this.txtHoT.Name = "txtHoT";
            this.txtHoT.Size = new System.Drawing.Size(153, 37);
            this.txtHoT.TabIndex = 21;
            this.txtHoT.Text = "Họ và tên";
            // 
            // textHoTen
            // 
            this.textHoTen.Location = new System.Drawing.Point(22, 226);
            this.textHoTen.Name = "textHoTen";
            this.textHoTen.Size = new System.Drawing.Size(500, 44);
            this.textHoTen.TabIndex = 20;
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(731, 134);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 123;
            this.dgvSinhVien.RowTemplate.Height = 46;
            this.dgvSinhVien.Size = new System.Drawing.Size(1267, 836);
            this.dgvSinhVien.TabIndex = 37;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(724, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 37);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(877, 58);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(394, 44);
            this.txtTimKiem.TabIndex = 34;
            // 
            // btnLamMoiSV
            // 
            this.btnLamMoiSV.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLamMoiSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiSV.Location = new System.Drawing.Point(355, 877);
            this.btnLamMoiSV.Name = "btnLamMoiSV";
            this.btnLamMoiSV.Size = new System.Drawing.Size(231, 94);
            this.btnLamMoiSV.TabIndex = 33;
            this.btnLamMoiSV.Text = "Làm mới";
            this.btnLamMoiSV.UseVisualStyleBackColor = false;
            this.btnLamMoiSV.Click += new System.EventHandler(this.btnLamMoiSV_Click);
            // 
            // btnXoaSV
            // 
            this.btnXoaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnXoaSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSV.Location = new System.Drawing.Point(86, 877);
            this.btnXoaSV.Name = "btnXoaSV";
            this.btnXoaSV.Size = new System.Drawing.Size(231, 94);
            this.btnXoaSV.TabIndex = 32;
            this.btnXoaSV.Text = "Xoá";
            this.btnXoaSV.UseVisualStyleBackColor = false;
            this.btnXoaSV.Click += new System.EventHandler(this.btnXoaSV_Click);
            // 
            // btnSuaSV
            // 
            this.btnSuaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSuaSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaSV.Location = new System.Drawing.Point(355, 763);
            this.btnSuaSV.Name = "btnSuaSV";
            this.btnSuaSV.Size = new System.Drawing.Size(231, 94);
            this.btnSuaSV.TabIndex = 31;
            this.btnSuaSV.Text = "Sửa";
            this.btnSuaSV.UseVisualStyleBackColor = false;
            this.btnSuaSV.Click += new System.EventHandler(this.btnSuaSV_Click);
            // 
            // btnThemSV
            // 
            this.btnThemSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnThemSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSV.Location = new System.Drawing.Point(86, 763);
            this.btnThemSV.Name = "btnThemSV";
            this.btnThemSV.Size = new System.Drawing.Size(231, 94);
            this.btnThemSV.TabIndex = 30;
            this.btnThemSV.Text = "Thêm";
            this.btnThemSV.UseVisualStyleBackColor = false;
            this.btnThemSV.Click += new System.EventHandler(this.btnThemSV_Click);
            // 
            // ucSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSinhVien);
            this.Name = "ucSinhVien";
            this.Size = new System.Drawing.Size(2066, 1035);
            this.pnlSinhVien.ResumeLayout(false);
            this.pnlSinhVien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSinhVien;
        private System.Windows.Forms.Button btnTimSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label txtMaSvs;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtHoT;
        private System.Windows.Forms.TextBox textHoTen;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLamMoiSV;
        private System.Windows.Forms.Button btnXoaSV;
        private System.Windows.Forms.Button btnSuaSV;
        private System.Windows.Forms.Button btnThemSV;
    }
}

namespace QanLy
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLớpHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlSinhVien = new System.Windows.Forms.Panel();
            this.pnlLopHoc = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
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
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlSinhVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýLớpHọcToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2073, 56);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(318, 52);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            // 
            // quảnLýLớpHọcToolStripMenuItem
            // 
            this.quảnLýLớpHọcToolStripMenuItem.Name = "quảnLýLớpHọcToolStripMenuItem";
            this.quảnLýLớpHọcToolStripMenuItem.Size = new System.Drawing.Size(299, 52);
            this.quảnLýLớpHọcToolStripMenuItem.Text = "Quản lý lớp học";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(209, 52);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlSinhVien);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 56);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(2073, 1231);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlSinhVien
            // 
            this.pnlSinhVien.Controls.Add(this.button1);
            this.pnlSinhVien.Controls.Add(this.groupBox1);
            this.pnlSinhVien.Controls.Add(this.dgvSinhVien);
            this.pnlSinhVien.Controls.Add(this.label2);
            this.pnlSinhVien.Controls.Add(this.txtTimKiem);
            this.pnlSinhVien.Controls.Add(this.button4);
            this.pnlSinhVien.Controls.Add(this.button3);
            this.pnlSinhVien.Controls.Add(this.button2);
            this.pnlSinhVien.Controls.Add(this.Add);
            this.pnlSinhVien.Controls.Add(this.pnlLopHoc);
            this.pnlSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSinhVien.Location = new System.Drawing.Point(0, 0);
            this.pnlSinhVien.Name = "pnlSinhVien";
            this.pnlSinhVien.Size = new System.Drawing.Size(2073, 1231);
            this.pnlSinhVien.TabIndex = 0;
            // 
            // pnlLopHoc
            // 
            this.pnlLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLopHoc.Location = new System.Drawing.Point(0, 0);
            this.pnlLopHoc.Name = "pnlLopHoc";
            this.pnlLopHoc.Size = new System.Drawing.Size(2073, 1231);
            this.pnlLopHoc.TabIndex = 40;
            this.pnlLopHoc.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1301, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 83);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dgvSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.Gioitinh,
            this.NgaySinh,
            this.Lop});
            this.dgvSinhVien.Location = new System.Drawing.Point(731, 134);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.RowHeadersWidth = 123;
            this.dgvSinhVien.RowTemplate.Height = 46;
            this.dgvSinhVien.Size = new System.Drawing.Size(1267, 836);
            this.dgvSinhVien.TabIndex = 37;
            this.dgvSinhVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellContentClick);
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Mã SV";
            this.MaSV.MinimumWidth = 15;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 300;
            // 
            // HoTen
            // 
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.MinimumWidth = 15;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 300;
            // 
            // Gioitinh
            // 
            this.Gioitinh.HeaderText = "Giới tính";
            this.Gioitinh.MinimumWidth = 15;
            this.Gioitinh.Name = "Gioitinh";
            this.Gioitinh.Width = 300;
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 15;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 300;
            // 
            // Lop
            // 
            this.Lop.HeaderText = "Lớp";
            this.Lop.MinimumWidth = 15;
            this.Lop.Name = "Lop";
            this.Lop.Width = 300;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(355, 877);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 94);
            this.button4.TabIndex = 33;
            this.button4.Text = "Làm mới";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(86, 877);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 94);
            this.button3.TabIndex = 32;
            this.button3.Text = "Xoá";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(355, 763);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 94);
            this.button2.TabIndex = 31;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(86, 763);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(231, 94);
            this.Add.TabIndex = 30;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2073, 1287);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlSinhVien.ResumeLayout(false);
            this.pnlSinhVien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLớpHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlSinhVien;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Add;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lop;
        private System.Windows.Forms.Panel pnlLopHoc;
    }
}
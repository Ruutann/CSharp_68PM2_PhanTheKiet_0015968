using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QanLy
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void pnlLopHoc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // Khi mới mở app, cho hiện Panel Sinh viên, ẩn Lớp học
        private void frmMain_Load(object sender, EventArgs e)
        {
            pnlSinhVien.Visible = true;
            pnlLopHoc.Visible = false;
            pnlSinhVien.BringToFront(); // Đưa panel sinh viên lên trên cùng
                                        // Cấu trúc bảng Lớp học
            dtLopHoc.Columns.Add("MaID");
            dtLopHoc.Columns.Add("MaLop");
            dtLopHoc.Columns.Add("TenLop");
            dtLopHoc.Columns.Add("GhiChu");

            // Dữ liệu mẫu cho Lớp
            dtLopHoc.Rows.Add("1", "68PM1", "Lớp 68PM1", "Phòng 201");
            dtLopHoc.Rows.Add("2", "68PM2", "Lớp 68PM2", "Phòng 202");


            // Cấu trúc bảng Sinh viên
            dtSinhVien.Columns.Add("MaSV");
            dtSinhVien.Columns.Add("HoTen");
            dtSinhVien.Columns.Add("GioiTinh");
            dtSinhVien.Columns.Add("NgaySinh");
            dtSinhVien.Columns.Add("Lop");
            dgvSinhVien.DataSource = dtSinhVien;

        }

        // Bấm Menu Quản lý Sinh viên
        private void menuSV_Click(object sender, EventArgs e)
        {
            pnlSinhVien.Visible = true;
            pnlLopHoc.Visible = false;
            pnlSinhVien.BringToFront();
        }


        private void menuLop_Click(object sender, EventArgs e)
        {
            pnlLopHoc.Visible = true;
            pnlSinhVien.Visible = false;
            pnlLopHoc.BringToFront();
        }


        private void btnSwitchToSV_Click(object sender, EventArgs e)
        {
            menuSV_Click(null, null);

        }
        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlSinhVien.Visible = true;
            pnlSinhVien.BringToFront();
            // Nếu có panel lớp học thì ẩn đi
            pnlLopHoc.Visible = false;
        }
        // Khai báo bảng dữ liệu
        DataTable dtSinhVien = new DataTable();
        DataTable dtLopHoc = new DataTable();


        private void btnThemSV_Click(object sender, EventArgs e)
        {
            dtSinhVien.Rows.Add(txtMaSV.Text, cboGioiTinh.Text, dtpNgaySinh.Text);
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo");
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

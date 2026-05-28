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
        DataTable dtSinhVien = new DataTable();
        DataTable dtLopHoc = new DataTable();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Trạng thái hiển thị ban đầu khi mở ứng dụng
            pnlSinhVien.Visible = true;
            pnlLopHoc.Visible = false;
            pnlSinhVien.BringToFront();

            // Khởi tạo bảng Lớp Học và thêm dữ liệu mẫu
            dtLopHoc.Columns.Add("MaID");
            dtLopHoc.Columns.Add("MaLop");
            dtLopHoc.Columns.Add("TenLop");
            dtLopHoc.Columns.Add("GhiChu");

            dtLopHoc.Rows.Add("1", "68PM1", "Lớp 68PM1", "Phòng 201");
            dtLopHoc.Rows.Add("2", "68PM2", "Lớp 68PM2", "Phòng 202");
            dgvLopHoc.DataSource = dtLopHoc;

            // Khởi tạo cấu trúc bảng Sinh Viên
            dtSinhVien.Columns.Add("MaSV");
            dtSinhVien.Columns.Add("HoTen");
            dtSinhVien.Columns.Add("GioiTinh");
            dtSinhVien.Columns.Add("NgaySinh");
            dtSinhVien.Columns.Add("Lop");
            dgvSinhVien.DataSource = dtSinhVien;

            // Đồng bộ dữ liệu lớp học vào ô ComboBox chọn Lớp của Sinh viên
            CapNhatComboBoxLop();
        }

        // Hàm hỗ trợ nạp danh sách lớp vào ComboBox bên màn hình Sinh viên
        private void CapNhatComboBoxLop()
        {
            cbLop.Items.Clear();
            foreach (DataRow row in dtLopHoc.Rows)
            {
                cbLop.Items.Add(row["MaLop"].ToString() + " - " + row["TenLop"].ToString());
            }
            if (cbLop.Items.Count > 0) cbLop.SelectedIndex = 0;
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlSinhVien.Visible = true;
            pnlLopHoc.Visible = false;
            pnlSinhVien.BringToFront();
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlLopHoc.Visible = true;
            pnlSinhVien.Visible = false;
            pnlLopHoc.BringToFront();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();
        }

        private void btnXemDSSV_Click(object sender, EventArgs e)
        {
            quảnLýSinhViênToolStripMenuItem_Click(null, null);
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text) || string.IsNullOrEmpty(txtMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã ID và Mã Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in dtLopHoc.Rows)
            {
                if (row["MaID"].ToString() == txtMaID.Text || row["MaLop"].ToString() == txtMaLop.Text)
                {
                    MessageBox.Show("Mã ID hoặc Mã Lớp này đã tồn tại!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dtLopHoc.Rows.Add(txtMaID.Text, txtMaLop.Text, txtTenLop.Text, txtGhiChu.Text);
            MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CapNhatComboBoxLop();
            btnLamMoiLop_Click(null, null);
        }

        private void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn Mã ID lớp cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in dtLopHoc.Rows)
            {
                if (row["MaID"].ToString() == txtMaID.Text)
                {
                    row["MaLop"] = txtMaLop.Text;
                    row["TenLop"] = txtTenLop.Text;
                    row["GhiChu"] = txtGhiChu.Text;
                    MessageBox.Show("Cập nhật thông tin lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CapNhatComboBoxLop();
                    btnLamMoiLop_Click(null, null);
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy lớp học tương ứng để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn lớp cần xóa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                for (int i = dtLopHoc.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtLopHoc.Rows[i]["MaID"].ToString() == txtMaID.Text)
                    {
                        dtLopHoc.Rows.RemoveAt(i);
                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CapNhatComboBoxLop();
                        btnLamMoiLop_Click(null, null);
                        return;
                    }
                }
                MessageBox.Show("Không tìm thấy lớp học cần xóa!", "Thông báo");
            }
        }

        private void btnLamMoiLop_Click(object sender, EventArgs e)
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();
            txtMaID.Focus();
            dgvLopHoc.DataSource = dtLopHoc;
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemLop.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                dgvLopHoc.DataSource = dtLopHoc;
                return;
            }

            DataTable dtKetQua = dtLopHoc.Clone();
            foreach (DataRow row in dtLopHoc.Rows)
            {
                if (row["MaID"].ToString().ToLower().Contains(tuKhoa) ||
                    row["MaLop"].ToString().ToLower().Contains(tuKhoa) ||
                    row["TenLop"].ToString().ToLower().Contains(tuKhoa))
                {
                    dtKetQua.ImportRow(row);
                }
            }
            dgvLopHoc.DataSource = dtKetQua;
        }

        private void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];
                txtMaID.Text = row.Cells[0].Value?.ToString();
                txtMaLop.Text = row.Cells[1].Value?.ToString();
                txtTenLop.Text = row.Cells[2].Value?.ToString();
                txtGhiChu.Text = row.Cells[3].Value?.ToString();
            }
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text) || string.IsNullOrEmpty(textHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sinh viên và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in dtSinhVien.Rows)
            {
                if (row["MaSV"].ToString() == txtMaSV.Text)
                {
                    MessageBox.Show("Mã sinh viên này đã tồn tại trên hệ thống!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            dtSinhVien.Rows.Add(txtMaSV.Text, textHoTen.Text, cboGioiTinh.Text, dtpNgaySinh.Text, cbLop.Text);
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoiSV_Click(null, null);
        }

        private void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in dtSinhVien.Rows)
            {
                if (row["MaSV"].ToString() == txtMaSV.Text)
                {
                    row["HoTen"] = textHoTen.Text;
                    row["GioiTinh"] = cboGioiTinh.Text;
                    row["NgaySinh"] = dtpNgaySinh.Text;
                    row["Lop"] = cbLop.Text;
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoiSV_Click(null, null);
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy sinh viên tương ứng để sửa!", "Thông báo");
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc điền Mã sinh viên muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                for (int i = dtSinhVien.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtSinhVien.Rows[i]["MaSV"].ToString() == txtMaSV.Text)
                    {
                        dtSinhVien.Rows.RemoveAt(i);
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnLamMoiSV_Click(null, null);
                        return;
                    }
                }
            }
        }

        private void btnLamMoiSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            textHoTen.Clear();
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            if (cbLop.Items.Count > 0) cbLop.SelectedIndex = 0;
            txtMaSV.Focus();
            dgvSinhVien.DataSource = dtSinhVien;
        }


        private void btnTimSV_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                dgvSinhVien.DataSource = dtSinhVien;
                return;
            }

            DataTable dtKetQua = dtSinhVien.Clone();
            foreach (DataRow row in dtSinhVien.Rows)
            {
                if (row["MaSV"].ToString().ToLower().Contains(tuKhoa) ||
                    row["HoTen"].ToString().ToLower().Contains(tuKhoa) ||
                    row["Lop"].ToString().ToLower().Contains(tuKhoa))
                {
                    dtKetQua.ImportRow(row);
                }
            }
            dgvSinhVien.DataSource = dtKetQua;
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value?.ToString();
                textHoTen.Text = row.Cells[1].Value?.ToString();
                cboGioiTinh.Text = row.Cells[2].Value?.ToString();

                if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime ngaySinh))
                    dtpNgaySinh.Value = ngaySinh;

                cbLop.Text = row.Cells[4].Value?.ToString();
            }
        }
    }

}
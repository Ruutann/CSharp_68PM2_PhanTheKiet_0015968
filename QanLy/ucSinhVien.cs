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
    public partial class ucSinhVien : UserControl
    {
        DataTable dtSinhVien = new DataTable();

        public ucSinhVien()
        {
            InitializeComponent();
        }

        private void ucSinhVien_Load(object sender, EventArgs e)
        {
            if (dtSinhVien.Columns.Count == 0)
            {
                dtSinhVien.Columns.Add("MaSV");
                dtSinhVien.Columns.Add("HoTen");
                dtSinhVien.Columns.Add("GioiTinh");
                dtSinhVien.Columns.Add("NgaySinh");
                dtSinhVien.Columns.Add("Lop");
            }
            dgvSinhVien.DataSource = dtSinhVien;

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.SelectedIndex = 0;

            cbLop.Items.Clear();
            cbLop.Items.Add("68PM1 - Lớp 68PM1");
            cbLop.Items.Add("68PM2 - Lớp 68PM2");
            if (cbLop.Items.Count > 0) cbLop.SelectedIndex = 0;
        }

        public void btnThemSV_Click(object sender, EventArgs e)
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

        public void btnSuaSV_Click(object sender, EventArgs e)
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

        public void btnXoaSV_Click(object sender, EventArgs e)
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

        public void btnLamMoiSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            textHoTen.Clear();
            cboGioiTinh.SelectedIndex = 0;
            dtpNgaySinh.Value = DateTime.Now;
            if (cbLop.Items.Count > 0) cbLop.SelectedIndex = 0;
            txtMaSV.Focus();
            dgvSinhVien.DataSource = dtSinhVien;
        }

        public void btnTimSV_Click(object sender, EventArgs e)
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

        public void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
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
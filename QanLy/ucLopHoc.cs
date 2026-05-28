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
    public partial class ucLopHoc : UserControl
    {
        DataTable dtLopHoc = new DataTable();

        public ucLopHoc()
        {
            InitializeComponent();
        }

        private void ucLopHoc_Load(object sender, EventArgs e)
        {
            if (dtLopHoc.Columns.Count == 0)
            {
                dtLopHoc.Columns.Add("MaID");
                dtLopHoc.Columns.Add("MaLop");
                dtLopHoc.Columns.Add("TenLop");
                dtLopHoc.Columns.Add("GhiChu");

                dtLopHoc.Rows.Add("1", "68PM1", "Lớp 68PM1", "Phòng 201");
                dtLopHoc.Rows.Add("2", "68PM2", "Lớp 68PM2", "Phòng 202");
            }
            dgvLopHoc.DataSource = dtLopHoc;
        }

        public void btnThemLop_Click(object sender, EventArgs e)
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
            btnLamMoiLop_Click(null, null);
        }

        public void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaID.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa từ bảng dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    btnLamMoiLop_Click(null, null);
                    return;
                }
            }
        }

        public void btnXoaLop_Click(object sender, EventArgs e)
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
                        btnLamMoiLop_Click(null, null);
                        return;
                    }
                }
            }
        }

        public void btnLamMoiLop_Click(object sender, EventArgs e)
        {
            txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();
            txtMaID.Focus();
            dgvLopHoc.DataSource = dtLopHoc;
        }

        public void btnTimLop_Click(object sender, EventArgs e)
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

        public void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
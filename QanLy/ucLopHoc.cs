using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QanLy
{
    public partial class ucLopHoc : UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-EVUFRLE\SQLEXPRESS;Initial Catalog=QLSinhVienCSharp;Integrated Security=True";

        public ucLopHoc()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.ucLopHoc_Load);
        }

        private void ucLopHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // 1. HÀM TẢI DỮ LIỆU LỚP HỌC TỪ DATABASE (Tự động sinh cột)
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Truy vấn lấy dữ liệu và đổi tên cột trực tiếp bằng AS để code tự tạo tiêu đề cột
                    string query = "SELECT ROW_NUMBER() OVER (ORDER BY ClassId) AS [Mã ID], ClassId AS [Mã Lớp], ClassName AS [Tên Lớp Học], Note AS [Ghi Chú] FROM Classes";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Xóa sạch bộ nhớ đệm cũ của GridView trước khi nạp
                    dgvLopHoc.DataSource = null;

                    // BẬT tính năng tự động tạo cột dựa theo câu lệnh SQL
                    dgvLopHoc.AutoGenerateColumns = true;

                    // Đổ dữ liệu DataTable vào lưới hiển thị
                    dgvLopHoc.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không thể tải danh mục lớp học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. CHỨC NĂNG THÊM MỚI LỚP HỌC
        public void btnThemLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text.Trim()) || string.IsNullOrEmpty(txtTenLop.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Lớp và Tên Lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra xem mã lớp (ClassId) đã tồn tại hay chưa
                    string checkQuery = "SELECT COUNT(*) FROM Classes WHERE ClassId = @ClassId";
                    SqlCommand cmdCheck = new SqlCommand(checkQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@ClassId", txtMaLop.Text.Trim());
                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã Lớp này đã tồn tại trên hệ thống!", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Chèn dữ liệu thực tế xuống SQL Server bảng Classes
                    string insertQuery = "INSERT INTO Classes (ClassId, ClassName, Note) VALUES (@ClassId, @ClassName, @Note)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@ClassId", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@ClassName", txtTenLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@Note", txtGhiChu.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    btnLamMoiLop_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 3. CHỨC NĂNG SỬA THÔNG TIN LỚP HỌC
        public void btnSuaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã Lớp cần chỉnh sửa thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE Classes SET ClassName = @ClassName, Note = @Note WHERE ClassId = @ClassId";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@ClassId", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@ClassName", txtTenLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@Note", txtGhiChu.Text.Trim());

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Cập nhật thông tin lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        btnLamMoiLop_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lớp học có mã tương ứng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. CHỨC NĂNG XÓA LỚP HỌC
        public void btnXoaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLop.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn lớp học muốn xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Xóa lớp học này sẽ tự động xóa tất cả các sinh viên thuộc lớp. Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string deleteQuery = "DELETE FROM Classes WHERE ClassId = @ClassId";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@ClassId", txtMaLop.Text.Trim());

                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            btnLamMoiLop_Click(null, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 5. CHỨC NĂNG LÀM MỚI (XÓA TRẮNG FORM)
        public void btnLamMoiLop_Click(object sender, EventArgs e)
        {
            if (txtMaID != null) txtMaID.Clear();
            txtMaLop.Clear();
            txtTenLop.Clear();
            txtGhiChu.Clear();
            txtMaLop.Focus();
        }

        // 6. CHỨC NĂNG TÌM KIẾM LỚP HỌC
        public void btnTimLop_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemLop.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadData();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT ROW_NUMBER() OVER (ORDER BY ClassId) AS [Mã ID], ClassId AS [Mã Lớp], ClassName AS [Tên Lớp Học], Note AS [Ghi Chú] FROM Classes WHERE LOWER(ClassId) LIKE @keyword OR LOWER(ClassName) LIKE @keyword";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" + tuKhoa + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvLopHoc.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        // 7. SỰ KIỆN CLICK CHỌN DÒNG TRÊN DATAGRIEVIEW ĐẨY NGƯỢC LÊN TEXTBOX
        public void dgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];

                txtMaID.Text = row.Cells["Mã ID"].Value?.ToString();
                txtMaLop.Text = row.Cells["Mã Lớp"].Value?.ToString();
                txtTenLop.Text = row.Cells["Tên Lớp Học"].Value?.ToString();
                txtGhiChu.Text = row.Cells["Ghi Chú"].Value?.ToString();
            }
        }

        private void pnlLopHoc_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
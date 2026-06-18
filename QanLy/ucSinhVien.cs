using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace QanLy
{
    public partial class ucSinhVien : UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-EVUFRLE\SQLEXPRESS;Initial Catalog=QLSinhVienCSharp;Integrated Security=True";

        public ucSinhVien()
        {
            InitializeComponent();
            LoadData(); 

            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.SelectedIndex = 0;
        }

        private void ucSinhVien_Load(object sender, EventArgs e)
        {
            // 1. Cài đặt cứng dữ liệu cho combobox Giới tính
            cboGioiTinh.Items.Clear();
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGioiTinh.SelectedIndex = 0;

            // 2. Nạp dữ liệu danh sách Lớp học từ Database vào combobox cbLop
            LoadClassComboBox();

            // 3. Tải toàn bộ dữ liệu Sinh viên lên GridView
            LoadData();
        }

        // HÀM TỰ ĐỘNG LẤY DANH SÁCH LỚP TỪ DATABASE ĐỔ VÀO COMBOBOX
        private void LoadClassComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT ClassId, ClassName FROM Classes";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbLop.DataSource = dt;
                    cbLop.DisplayMember = "ClassId";
                    cbLop.ValueMember = "ClassId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp danh sách lớp: " + ex.Message);
            }
        }

        // 1. HÀM TẢI DỮ LIỆU SINH VIÊN LÊN GRIDVIEW
        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Lấy dữ liệu từ SQL Server (phải chuẩn tên cột trong database)
                    string query = "SELECT MSSV, FullName, Gender, DateOfBirth, ClassId FROM Students";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // 2. BẬT tự động tạo cột (Vì giao diện thiết kế đã xoá hết cột trống)
                    dgvSinhVien.AutoGenerateColumns = true;

                    // 3. Đổ dữ liệu vào bảng
                    dgvSinhVien.DataSource = dt;

                    // 4. Đổi tên tiêu đề cột hiển thị trên màn hình thành tiếng Việt
                    if (dgvSinhVien.Columns.Count >= 5)
                    {
                        dgvSinhVien.Columns["MSSV"].HeaderText = "Mã Sinh Viên";
                        dgvSinhVien.Columns["FullName"].HeaderText = "Họ và Tên";
                        dgvSinhVien.Columns["Gender"].HeaderText = "Giới Tính";
                        dgvSinhVien.Columns["DateOfBirth"].HeaderText = "Ngày Sinh";
                        dgvSinhVien.Columns["ClassId"].HeaderText = "Mã Lớp";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu lên bảng: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 2. CHỨC NĂNG THÊM MỚI
        public void btnThemSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text.Trim()) || string.IsNullOrEmpty(textHoTen.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã sinh viên và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra trùng khóa chính (MSSV)
                    string checkQuery = "SELECT COUNT(*) FROM Students WHERE MSSV = @MSSV";
                    SqlCommand cmdCheck = new SqlCommand(checkQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@MSSV", txtMaSV.Text.Trim());
                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Mã sinh viên này đã tồn tại trên hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Thực hiện chèn dữ liệu
                    string insertQuery = "INSERT INTO Students (MSSV, FullName, DateOfBirth, Gender, ClassId) VALUES (@MSSV, @FullName, @DateOfBirth, @Gender, @ClassId)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn);
                    cmd.Parameters.AddWithValue("@MSSV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@FullName", textHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpNgaySinh.Value.Date); // Chỉ lấy ngày, bỏ qua giờ giấc
                    cmd.Parameters.AddWithValue("@Gender", cboGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@ClassId", cbLop.SelectedValue?.ToString() ?? cbLop.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm mới sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData(); // Cập nhật lại hiển thị tức thì ra bảng
                    btnLamMoiSV_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        // 3. CHỨC NĂNG SỬA
        public void btnSuaSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string updateQuery = "UPDATE Students SET FullName = @FullName, DateOfBirth = @DateOfBirth, Gender = @Gender, ClassId = @ClassId WHERE MSSV = @MSSV";
                    SqlCommand cmd = new SqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@MSSV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@FullName", textHoTen.Text.Trim());
                    cmd.Parameters.AddWithValue("@DateOfBirth", dtpNgaySinh.Value.Date);
                    cmd.Parameters.AddWithValue("@Gender", cboGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@ClassId", cbLop.SelectedValue?.ToString() ?? cbLop.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData();
                    btnLamMoiSV_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // 4. CHỨC NĂNG XÓA
        public void btnXoaSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSV.Text.Trim())) return;

            DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string deleteQuery = "DELETE FROM Students WHERE MSSV = @MSSV";
                        SqlCommand cmd = new SqlCommand(deleteQuery, conn);
                        cmd.Parameters.AddWithValue("@MSSV", txtMaSV.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                        btnLamMoiSV_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        // 5. CHỨC NĂNG LÀM MỚI FORM NHẬP LIỆU
        public void btnLamMoiSV_Click(object sender, EventArgs e)
        {
            txtMaSV.Clear();
            textHoTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            if (cboGioiTinh.Items.Count > 0) cboGioiTinh.SelectedIndex = 0;
            if (cbLop.Items.Count > 0) cbLop.SelectedIndex = 0;
            txtMaSV.Focus();
        }

        // 6. SỰ KIỆN CLICK VÀO DÒNG TRÊN BẢNG ĐỂ HIỂN THỊ NGƯỢC LÊN FORM NHẬP LIỆU
        

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells[0].Value?.ToString();
                textHoTen.Text = row.Cells[1].Value?.ToString();
                cboGioiTinh.Text = row.Cells[2].Value?.ToString();

                if (DateTime.TryParse(row.Cells[3].Value?.ToString(), out DateTime ngaySinh))
                    dtpNgaySinh.Value = ngaySinh;
                else
                    dtpNgaySinh.Value = DateTime.Now;

                cbLop.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                // Lấy dữ liệu chuẩn xác theo tên cột trong câu lệnh SQL SELECT
                txtMaSV.Text = row.Cells["MSSV"].Value?.ToString();
                textHoTen.Text = row.Cells["FullName"].Value?.ToString();
                cboGioiTinh.Text = row.Cells["Gender"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime ngaySinh))
                    dtpNgaySinh.Value = ngaySinh;
                else
                    dtpNgaySinh.Value = DateTime.Now;

                cbLop.Text = row.Cells["ClassId"].Value?.ToString();
            }
        }
    }
}
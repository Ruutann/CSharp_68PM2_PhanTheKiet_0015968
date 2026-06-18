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
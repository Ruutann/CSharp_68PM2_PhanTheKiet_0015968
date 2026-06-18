using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QanLy
{
    public partial class frmDanhSachSV : Form
    {
        private string connectionString = @"Data Source=DESKTOP-EVUFRLE\SQLEXPRESS;Initial Catalog=QLSinhVienCSharp;Integrated Security=True";
        private string maLopDuocChon = "";

        public frmDanhSachSV(string classId)
        {
            InitializeComponent();
            this.maLopDuocChon = classId;
        }

        private void frmDanhSachSV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MSSV AS [Mã SV], FullName AS [Họ và Tên], DateOfBirth AS [Ngày Sinh], Gender AS [Giới Tính] " +
                                   "FROM Students WHERE ClassId = @ClassId";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@ClassId", maLopDuocChon);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSinhVien.DataSource = null;
                    dgvSinhVien.AutoGenerateColumns = true;
                    dgvSinhVien.DataSource = dt;

                    // Cho bảng tràn đều diện tích giao diện
                    dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu sinh viên: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
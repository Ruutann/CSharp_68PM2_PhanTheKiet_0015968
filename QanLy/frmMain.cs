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

        // =========================================================================
        // KHỞI CHẠY FORM: MẶC ĐỊNH HIỂN THỊ MÀN HÌNH SINH VIÊN
        // =========================================================================
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Kiểm tra tránh lỗi nếu bạn chưa kéo thả ucSV hoặc ucLH vào giao diện Design
            if (ucSV != null && ucLH != null)
            {
                ucSV.Visible = true;
                ucLH.Visible = false;
                ucSV.BringToFront();
            }
        }

        // =========================================================================
        // ĐIỀU HƯỚNG MENU: CHUYỂN QUA LẠI GIỮA CÁC USER CONTROL
        // =========================================================================

        // Khi click vào mục "Quản lý sinh viên" trên Menu
        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucSV != null && ucLH != null)
            {
                ucSV.Visible = true;
                ucLH.Visible = false;
                ucSV.BringToFront(); // Đẩy màn hình sinh viên lên trên cùng
            }
        }

        // Khi click vào mục "Quản lý lớp học" trên Menu
        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucSV != null && ucLH != null)
            {
                ucLH.Visible = true;
                ucSV.Visible = false;
                ucLH.BringToFront(); // Đẩy màn hình lớp học lên trên cùng
            }
        }

        // =========================================================================
        // CHỨC NĂNG ĐĂNG XUẤT HỆ THỐNG
        // =========================================================================
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
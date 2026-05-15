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
        private void menuQuanLySV_Click(object sender, EventArgs e)
        {
            pnlSinhVien.Visible = true;
            pnlLopHoc.Visible = false;
            pnlSinhVien.BringToFront(); // Đưa panel sinh viên lên trên cùng
        }

        private void menuQuanLyLop_Click(object sender, EventArgs e)
        {
            pnlLopHoc.Visible = true;
            pnlSinhVien.Visible = false;
            pnlLopHoc.BringToFront();
        }
    }
}

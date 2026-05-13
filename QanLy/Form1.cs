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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string correctEmail = "0015968@st.huce.edu.vn";
            string correctMSSV = "0015968";

            if (username == correctEmail && password == correctMSSV)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

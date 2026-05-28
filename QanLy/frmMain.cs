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


        private void frmMain_Load(object sender, EventArgs e)
        {

            if (ucSV != null && ucLH != null)
            {
                ucSV.Visible = true;
                ucLH.Visible = false;
                ucSV.BringToFront();
            }
        }



        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucSV != null && ucLH != null)
            {
                ucSV.Visible = true;
                ucLH.Visible = false;
                ucSV.BringToFront();
            }
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ucSV != null && ucLH != null)
            {
                ucLH.Visible = true;
                ucSV.Visible = false;
                ucLH.BringToFront();
            }
        }

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
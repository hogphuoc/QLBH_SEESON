using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THNN
{
    public partial class TrangChuKho : Form
    {
        public TrangChuKho()
        {
            InitializeComponent();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLPhieuNhap s = new QLPhieuNhap();
            s.ShowDialog();
        }

        private void quảnLýPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLPhieuXuat s = new QLPhieuXuat();
            s.ShowDialog();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSanPham s = new QLSanPham();
            s.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(" Bạn có chắc chắc muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                DangNhap s = new DangNhap();
                s.ShowDialog();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

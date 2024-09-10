using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THNN.Quanly;

namespace THNN
{
    public partial class TrangChuQL : Form
    {
        public TrangChuQL()
        {
            InitializeComponent();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhaCungCap s = new QLNhaCungCap();
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

        private void quảnLýCửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLCuaHang s = new QLCuaHang();
            s.ShowDialog();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien s = new QLNhanVien();
            s.ShowDialog();
        }

        private void quảnLýThôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSanPham s = new QLSanPham();
            s.ShowDialog();
        }

        private void quảnLýĐơnĐặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDDH s = new QLDDH();
            s.ShowDialog();
        }
    }
}

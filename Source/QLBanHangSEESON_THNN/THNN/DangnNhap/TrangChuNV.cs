using THNN.BanHang;
using THNN.DangnNhap;

namespace THNN
{
    public partial class TrangChuNV : Form
    {
        public TrangChuNV()
        {
            InitializeComponent();
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

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhachHang s = new QLKhachHang();
            s.ShowDialog();
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLHoaDon s = new QLHoaDon();
            s.ShowDialog();
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemTTSP s = new XemTTSP();
            s.ShowDialog();
        }

   
    }
}

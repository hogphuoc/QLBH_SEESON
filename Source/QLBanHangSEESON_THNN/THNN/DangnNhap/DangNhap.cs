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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            {
                if (txttendangnhap.Text == "qlseeson" && txtmatkhau.Text == "12345")
                {
                    //MessageBox.Show(" Đăng nhập dưới quyền quản lý thành công", "Thông báo");
                    this.Hide();
                    TrangChuQL s = new TrangChuQL();
                    s.ShowDialog();
                }
                else if (txttendangnhap.Text == "khoseeson" && txtmatkhau.Text == "12345")
                {
                    //MessageBox.Show(" Đăng nhập dưới quyền nhân viên kho thành công", "Thông báo");
                    this.Hide();
                    TrangChuKho s = new TrangChuKho();
                    s.ShowDialog();
                }
                else if (txttendangnhap.Text == "banhangseeson" && txtmatkhau.Text == "12345")
                {
                    //MessageBox.Show(" Đăng nhập dưới quyền nhân viên bán hàng thành công", "Thông báo");
                    this.Hide();
                    TrangChuNV s = new TrangChuNV();
                    s.ShowDialog();
                }
                else
                {
                    MessageBox.Show(" Sai tên đăng nhập hoặc mật khẩu ", "Thông báo");
                }

            }
        }
        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}

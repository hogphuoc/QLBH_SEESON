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
using System.Windows.Forms;

namespace THNN
{
    public partial class QLKhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-MA6F1L2;Initial Catalog=QLBH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        BindingSource bdsource = new BindingSource();
        DataTable table = new DataTable();
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from KHACHHANG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvkhachhang.DataSource = table;
        }
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " INSERT INTO KHACHHANG VALUES ('" + txtmkh.Text + "', N'" + txttenkh.Text + "' , N'" + cbgt.Text + "' , '" + dtpngaysinhkh.Value.ToString("yyyy/MM/dd") + "' , N'" + txtsdt.Text + "', N'" + txtemail.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                txtmkh.Focus();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM KHACHHANG WHERE MaKH = '" + txtmkh.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmkh.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmkh.Text))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng để sửa đổi.", "Thông báo");
                return;
            }

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                // using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Tạo câu lệnh SQL và sử dụng tham số hóa
                    string query = "UPDATE KHACHHANG SET HoTenKH = @HoTenKH, GioiTinhKH = @GioiTinhKH, NgaySinhKH = @NgaySinhKH, SDTKH = @SDTKH, EmailKH = @EmailKH WHERE MaKH = @MaKH";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đưa dữ liệu vào các tham số
                        command.Parameters.AddWithValue("@HoTenKH", txttenkh.Text);
                        command.Parameters.AddWithValue("@GioiTinhKH", cbgt.Text);
                        command.Parameters.AddWithValue("@NgaySinhKH", dtpngaysinhkh.Value);
                        command.Parameters.AddWithValue("@SDTKH", txtsdt.Text);
                        command.Parameters.AddWithValue("@EmailKH", txtemail.Text);
                        
                      
                        command.Parameters.AddWithValue("@MaKH", txtmkh.Text);

                        // Thực thi câu lệnh UPDATE
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra và hiển thị thông báo thành công
                        if (rowsAffected > 0)
                        {
                            loaddata();  // Cập nhật lại dữ liệu
                            txtmkh.Focus();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy khách hàng có mã " + txtmkh.Text, "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
            connection.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmkh.Clear();
            txttenkh.Clear();
            dtpngaysinhkh.Value = DateTime.Today;
            txtsdt.Clear();
            cbgt.Text = string.Empty;
            txtemail.Clear();
        }

        public void LoadGridTimKiemTen()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM KHACHHANG WHERE HoTenKH like '%" + txttenkh.Text + "%'";
            command.ExecuteNonQuery();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            //connection.Open();
            string query = "SELECT * FROM KHACHHANG WHERE SDTKH =" + txttimkiemten.Text + "";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("SDTKH", txttenkh.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvkhachhang.DataSource = dt;
            //connection.Close();
        }

        private void dgvkhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvkhachhang.CurrentRow.Index;
            txtmkh.Text = dgvkhachhang.Rows[i].Cells[0].Value.ToString();
            txttenkh.Text = dgvkhachhang.Rows[i].Cells[1].Value.ToString();
            cbgt.SelectedItem = dgvkhachhang.Rows[i].Cells[2].Value.ToString();
            dtpngaysinhkh.Value = (DateTime)dgvkhachhang.Rows[i].Cells[3].Value;
            txtsdt.Text = dgvkhachhang.Rows[i].Cells[4].Value.ToString();
            txtemail.Text = dgvkhachhang.Rows[i].Cells[5].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }
    }
}

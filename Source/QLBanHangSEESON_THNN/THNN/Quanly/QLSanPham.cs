using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THNN
{
    public partial class QLSanPham : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        string str = @"Data Source=DESKTOP-MA6F1L2;Initial Catalog=QLBH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        BindingSource bdsource = new BindingSource();
        DataTable table = new DataTable();

        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from SANPHAM";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvsp.DataSource = table;
        }
        public QLSanPham()
        {
            InitializeComponent();
        }

        private void QLSanPham_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsp.Rows[e.RowIndex];

                txtmsp.Text = row.Cells[0].Value.ToString();
                txttensp.Text = row.Cells[1].Value.ToString();
                txtdvt.Text = row.Cells[2].Value.ToString();
                txtslt.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value != null && row.Cells[4].Value.ToString() != "")
                {
                    string imagePath = row.Cells[4].Value.ToString();

                    // Kiểm tra nếu đường dẫn hợp lệ trước khi gán vào PictureBox
                    if (File.Exists(imagePath))
                    {
                        // Load hình ảnh từ đường dẫn vào PictureBox
                        pbsp.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        // Xử lý trường hợp đường dẫn không hợp lệ (có thể thông báo lỗi hoặc xử lý khác)
                        pbsp.Image = null; // hoặc làm gì đó để xử lý khi không tìm thấy ảnh
                    }
                }
                else
                {
                    // Xử lý khi không có dữ liệu hình ảnh (nếu cần)
                    pbsp.Image = null;
                }

                string maloai = row.Cells[5].Value.ToString();
                if (cbgmloaisp_sp.Items.Contains(maloai))
                {
                    cbgmloaisp_sp.SelectedItem = maloai;
                }
                else
                {
                    cbgmloaisp_sp.SelectedIndex = -1;
                }
            }
        }

        private void cbgmloaisp_sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenLoaiSP FROM LOAISANPHAM where MaLoaiSP = @MaLoaiSP";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaLoaiSP", cbgmloaisp_sp.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttenloaisp_sp.Text = dr["TenLoaiSP"].ToString();
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttenloaisp_sp.Text = "Không tìm thấy loại sản phẩm có mã này.";
            }
            connection.Close();
        }

        private void cbgmloaisp_sp_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM LOAISANPHAM";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbgmloaisp_sp.DataSource = dt;
            cbgmloaisp_sp.DisplayMember = "MaLoaiSP";
            connection.Close();
        }

        private void btnloadhinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pbsp.Image = Image.FromFile(dlgOpen.FileName);
                txthinhanh.Text = dlgOpen.FileName;
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " INSERT INTO SANPHAM VALUES ('" + txtmsp.Text + "', N'" + txttensp.Text + "' , N'" + txtdvt.Text + "' , '" + txtslt.Text + "' , N'" + txthinhanh.Text + "', N'" + cbgmloaisp_sp.Text.ToString() + "')";
            command.ExecuteNonQuery();
            loaddata();
            txtmsp.Focus();
            MessageBox.Show("Thêm thành công", "Thông báo");
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //if (connection != null)
                //{
                //    connection.Close();
                //}
            }
            connection.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtmsp.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm để sửa đổi.", "Thông báo");
                return;
            }
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                // using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Tạo câu lệnh SQL và sử dụng tham số hóa
                    string query = "UPDATE SANPHAM SET TenSP = @TenSP, DonViTinh = @DonViTinh, SLTon = @SLTon, Hinhanh = @Hinhanh, MaLoaiSP = @MaLoaiSP WHERE MaSP = @MaSP";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenSP", txttensp.Text);
                        command.Parameters.AddWithValue("@DonViTinh", txtdvt.Text);
                        command.Parameters.AddWithValue("@SLTon", txtslt.Text);
                        command.Parameters.AddWithValue("@Hinhanh", txthinhanh.Text);

                        string maLoai = cbgmloaisp_sp.Text.Length > 10 ? cbgmloaisp_sp.Text.Substring(0, 10) : cbgmloaisp_sp.Text;
                        command.Parameters.AddWithValue("@MaLoaiSP", maLoai);

                        command.Parameters.AddWithValue("@MaSP", txtmsp.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            loaddata();  // Cập nhật lại dữ liệu
                            txtmsp.Focus();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sản phẩm có mã " + txtmsp.Text, "Thông báo");
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
        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo và thiết lập câu lệnh SQL
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM SANPHAM WHERE MaSP = @MaSP";
                command.Parameters.AddWithValue("@MaSP", txtmsp.Text);

                // Thực thi câu lệnh DELETE
                int rowsAffected = command.ExecuteNonQuery();

                // Đóng kết nối sau khi hoàn thành
                connection.Close();

                // Kiểm tra và hiển thị thông báo thành công
                if (rowsAffected > 0)
                {
                    loaddata();  // Cập nhật lại dữ liệu
                    txtmsp.Focus();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm có mã " + txtmsp.Text, "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
            finally
            {
                // Đảm bảo rằng kết nối được đóng dù có lỗi xảy ra hay không
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmsp.Clear();
            txttensp.Clear();
            txtdvt.Clear();
            txtslt.Clear();
            txthinhanh.Clear();
            cbgmloaisp_sp.Text = string.Empty;
            connection.Open();
        }

        private void btntimkiemnv_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SANPHAM WHERE MaSP ='" + txttimkiemmsp.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaSP", txtmsp.Text.ToString());
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvsp.DataSource = dt;
            connection.Close();
        }
    }
}

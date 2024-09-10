using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THNN
{
    public partial class QLNhanVien : Form
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
            command.CommandText = " select * from NHANVIEN";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvnhanvien.DataSource = table;
        }
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " INSERT INTO NHANVIEN VALUES ('" + txtmnv.Text + "', N'" + txttennv.Text + "' , N'" + cbgtnv.Text + "' , '" + dtpngaysinhnv.Value.ToString("yyyy/MM/dd") + "' , N'" + txtsdtnv.Text + "', N'" + txtemailnv.Text + "',N'" + cbmbp_nv.Text.ToString() + "' ,N'" + cbmch_nv.Text.ToString() + "')";
            command.ExecuteNonQuery();
            loaddata();
            txtmnv.Focus();
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

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = " DELETE FROM NHANVIEN WHERE MaNV = '" + txtmnv.Text + "'";
            //command.ExecuteNonQuery();
            //loaddata();
            //txtmnv.Focus();
            //MessageBox.Show("Xóa thành công", "Thông báo");
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Tạo và thiết lập câu lệnh SQL
                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM NHANVIEN WHERE MaNV = @MaNV";
                command.Parameters.AddWithValue("@MaNV", txtmnv.Text);

                // Thực thi câu lệnh DELETE
                int rowsAffected = command.ExecuteNonQuery();

                // Đóng kết nối sau khi hoàn thành
                connection.Close();

                // Kiểm tra và hiển thị thông báo thành công
                if (rowsAffected > 0)
                {
                    loaddata();  // Cập nhật lại dữ liệu
                    txtmnv.Focus();
                    MessageBox.Show("Xóa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã " + txtmnv.Text, "Thông báo");
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

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHANVIEN WHERE HoTenNV like N'%" + txttimkiemtennv.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("HoTenNV", txttennv.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvnhanvien.DataSource = dt;
            connection.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmnv.Clear();
            txttennv.Clear();
            dtpngaysinhnv.Value = DateTime.Today;
            txtsdtnv.Clear();
            cbgtnv.Text = string.Empty;
            txtemailnv.Clear();
            cbmbp_nv.Text = string.Empty;
            cbmch_nv.Text = string.Empty;
            connection.Open();
        }

        private void dgvnhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int i;
            i = dgvnhanvien.CurrentRow.Index;
            txtmnv.Text = dgvnhanvien.Rows[i].Cells[0].Value.ToString();
            txttennv.Text = dgvnhanvien.Rows[i].Cells[1].Value.ToString();
            cbgtnv.SelectedItem = dgvnhanvien.Rows[i].Cells[2].Value.ToString();
            dtpngaysinhnv.Value = (DateTime)dgvnhanvien.Rows[i].Cells[3].Value;
            txtsdtnv.Text = dgvnhanvien.Rows[i].Cells[4].Value.ToString();
            txtemailnv.Text = dgvnhanvien.Rows[i].Cells[5].Value.ToString();
            cbmbp_nv.SelectedItem = dgvnhanvien.Rows[i].Cells[6].Value.ToString();
            cbmch_nv.SelectedItem = dgvnhanvien.Rows[i].Cells[7].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;*/
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvnhanvien.Rows[e.RowIndex];

                txtmnv.Text = row.Cells[0].Value.ToString(); // Mã nhân viên
                txttennv.Text = row.Cells[1].Value.ToString(); // Tên nhân viên
                cbgtnv.SelectedItem = row.Cells[2].Value.ToString(); // Giới tính nhân viên

                // Ngày sinh nhân viên
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime ngaysinh))
                {
                    dtpngaysinhnv.Value = ngaysinh;
                }

                txtsdtnv.Text = row.Cells[4].Value.ToString(); // Số điện thoại nhân viên
                txtemailnv.Text = row.Cells[5].Value.ToString(); // Email nhân viên

                // Đối với cbmbp_nv (ComboBox Mã bộ phận)
                string maBP = row.Cells[6].Value.ToString();
                if (cbmbp_nv.Items.Contains(maBP))
                {
                    cbmbp_nv.SelectedItem = maBP;
                }
                else
                {
                    cbmbp_nv.SelectedIndex = -1; // Nếu không tìm thấy, chọn mặc định
                }

                // Đối với cbmch_nv (ComboBox Mã cửa hàng)
                string maCH = row.Cells[7].Value.ToString();
                if (cbmch_nv.Items.Contains(maCH))
                {
                    cbmch_nv.SelectedItem = maCH;
                }
                else
                {
                    cbmch_nv.SelectedIndex = -1; // Nếu không tìm thấy, chọn mặc định
                }

            }
        }

        private void cbmbp_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenBP FROM BOPHAN where MaBP = @MaBP";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaBP", cbmbp_nv.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttenbp_nv.Text = dr["TenBP"].ToString(); // Gán giá trị TenCH từ SqlDataReader vào TextBox
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttenbp_nv.Text = "Không tìm thấy bộ phận có mã này.";
            }

            connection.Close();
        }

        private void cbmbp_nv_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BOPHAN";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbmbp_nv.DataSource = dt;
            cbmbp_nv.DisplayMember = "MaBP";
            connection.Close();
        }

        private void cbmch_nv_SelectedIndexChanged(object sender, EventArgs e)
        {

            string sqlQuery = "SELECT TenCH FROM CUAHANG where MaCH = @MaCH";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaCH", cbmch_nv.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttench_nv.Text = dr["TenCH"].ToString(); // Gán giá trị TenCH từ SqlDataReader vào TextBox
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttench_nv.Text = "Không tìm thấy cửa hàng có mã này.";
            }

            connection.Close();

        }

        private void cbmch_nv_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CUAHANG";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbmch_nv.DataSource = dt;
            cbmch_nv.DisplayMember = "MaCH";
            connection.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            //connection.Open();
            //command = connection.CreateCommand();
            //command.CommandText = " UPDATE NHANVIEN SET HoTenNV = N'" + txttennv.Text + "', GioiTinhNV = N'" + cbgtnv.Text + "', NgaySinhNV = '" + dtpngaysinhnv.Text.ToString() + "', SDTNV = N'" + txtsdtnv.Text + "', EmailNV =N'" + txtemailnv.Text + "', MaBP=N'" + cbmbp_nv.SelectedValue.ToString() + "', MaCH'" + cbmch_nv.SelectedValue.ToString() + "' Where MaNV = '" + txtmnv.Text + "'";
            //command.ExecuteNonQuery();
            //loaddata();
            //txtmnv.Focus();
            //MessageBox.Show("Sửa thành công", "Thông báo");

            if (string.IsNullOrEmpty(txtmnv.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để sửa đổi.", "Thông báo");
                return;
            }

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                // using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    // Tạo câu lệnh SQL và sử dụng tham số hóa
                    string query = "UPDATE NHANVIEN SET HoTenNV = @HoTenNV, GioiTinhNV = @GioiTinhNV, NgaySinhNV = @NgaySinhNV, SDTNV = @SDTNV, EmailNV = @EmailNV, MaBP = @MaBP, MaCH = @MaCH WHERE MaNV = @MaNV";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Đưa dữ liệu vào các tham số
                        command.Parameters.AddWithValue("@HoTenNV", txttennv.Text);
                        command.Parameters.AddWithValue("@GioiTinhNV", cbgtnv.Text);
                        command.Parameters.AddWithValue("@NgaySinhNV", dtpngaysinhnv.Value);
                        command.Parameters.AddWithValue("@SDTNV", txtsdtnv.Text);
                        command.Parameters.AddWithValue("@EmailNV", txtemailnv.Text);

                        // Đảm bảo rằng các giá trị được cắt bớt nếu vượt quá kích thước cho phép
                        string maBP = cbmbp_nv.Text.Length > 10 ? cbmbp_nv.Text.Substring(0, 10) : cbmbp_nv.Text;
                        string maCH = cbmch_nv.Text.Length > 10 ? cbmch_nv.Text.Substring(0, 10) : cbmch_nv.Text;

                        command.Parameters.AddWithValue("@MaBP", maBP); // Thay vì sử dụng cbmbp_nv.Text trực tiếp, kiểm tra và cắt bớt nếu cần thiết
                        command.Parameters.AddWithValue("@MaCH", maCH); // Thay vì sử dụng cbmch_nv.Text trực tiếp, kiểm tra và cắt bớt nếu cần thiết

                        command.Parameters.AddWithValue("@MaNV", txtmnv.Text);

                        // Thực thi câu lệnh UPDATE
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra và hiển thị thông báo thành công
                        if (rowsAffected > 0)
                        {
                            loaddata();  // Cập nhật lại dữ liệu
                            txtmnv.Focus();
                            MessageBox.Show("Sửa thành công", "Thông báo");
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy nhân viên có mã " + txtmnv.Text, "Thông báo");
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THNN.BanHang;

namespace THNN
{
    public partial class QLPhieuXuat : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-MA6F1L2;Initial Catalog=QLBH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        BindingSource bdsource = new BindingSource();
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        private void loaddatapx()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM PHIEUXUAT";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvpx.DataSource = table;
        }
        private void loaddatactpx()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM CTPHIEUXUAT WHERE MaPX = N'" + txtmpx.Text + "'";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgvctpx.DataSource = table2;
        }
        public QLPhieuXuat()
        {
            InitializeComponent();
        }


        private void dgvctpx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvctpx.Rows.Count)
                return;

            // Lấy chỉ số của hàng hiện tại
            int rowIndex = e.RowIndex;

            // Kiểm tra nếu ô được click không phải là ô dữ liệu (vd: header)
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvctpx.Columns.Count)
                return;

            // Lấy giá trị từ ô được click
            DataGridViewRow selectedRow = dgvctpx.Rows[rowIndex];

            // Kiểm tra nếu hàng được chọn không hợp lệ
            if (selectedRow == null || selectedRow.Cells.Count == 0)
                return;

            // Lấy giá trị từ các ô của hàng được chọn
            txtmpx_ctpx.Text = selectedRow.Cells[0].Value?.ToString(); // Sử dụng ?.ToString() để tránh lỗi nếu giá trị null
            cbmasp_ctpx.SelectedItem = selectedRow.Cells[1].Value?.ToString();
            txtslxuat.Text = selectedRow.Cells[2].Value?.ToString();
        }

        private void dgvpx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvpx.CurrentRow.Index;
            txtmpx.Text = dgvpx.Rows[i].Cells[0].Value.ToString();
            cbmch_px.SelectedItem = dgvpx.Rows[i].Cells[1].Value.ToString();
            cbmnv_px.SelectedItem = dgvpx.Rows[i].Cells[2].Value.ToString();
            dtpngayxuat.Value = (DateTime)dgvpx.Rows[i].Cells[3].Value;
            btnsua.Enabled = true;
            btnxoapx.Enabled = true;

            loaddatactpx();
        }

        private void QLPhieuXuat_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddatapx();
            loaddatactpx();
        }

        private void cbmch_px_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-MA6F1L2;Initial Catalog=QLBH;Integrated Security=True"; // Thay thế chuỗi kết nối với kết nối thực tế của bạn
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Lấy Tên cửa hàng từ bảng CUAHANG
                    string sqlQueryTenCH = "SELECT TenCH FROM CUAHANG WHERE MaCH = @MaCH";
                    SqlCommand cmdTenCH = new SqlCommand(sqlQueryTenCH, connection);
                    cmdTenCH.Parameters.AddWithValue("@MaCH", cbmch_px.Text); // Sử dụng tham số để tránh SQL Injection

                    SqlDataReader drTenCH = cmdTenCH.ExecuteReader();
                    if (drTenCH.Read())
                    {
                        txttench_px.Text = drTenCH["TenCH"].ToString();
                    }
                    else
                    {
                        txttench_px.Text = "Không tìm thấy tên cửa hàng này.";
                    }
                    drTenCH.Close(); // Đóng DataReader sau khi sử dụng

                    // Lấy danh sách MaNV từ bảng NHANVIEN cho cửa hàng được chọn
                    string sqlQueryMaNV = "SELECT NHANVIEN.MaNV FROM NHANVIEN INNER JOIN CUAHANG ON CUAHANG.MaCH = NHANVIEN.MaCH WHERE CUAHANG.MaCH = @MaCH";
                    SqlCommand cmdMaNV = new SqlCommand(sqlQueryMaNV, connection);
                    cmdMaNV.Parameters.AddWithValue("@MaCH", cbmch_px.Text); // Sử dụng tham số để tránh SQL Injection

                    SqlDataReader drMaNV = cmdMaNV.ExecuteReader();
                    cbmnv_px.Items.Clear(); // Xóa các mục cũ trong ComboBox trước khi thêm mới
                    while (drMaNV.Read())
                    {
                        cbmnv_px.Items.Add(drMaNV["MaNV"].ToString());
                    }
                    drMaNV.Close(); // Đóng DataReader sau khi sử dụng
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                connection.Close();
            }
        }

        private void cbmch_px_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CUAHANG";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbmch_px.DataSource = dt;
            cbmch_px.DisplayMember = "MaCH";
            connection.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " INSERT INTO PHIEUXUAT VALUES ('" + txtmpx.Text + "', N'" + cbmch_px.Text.ToString() + "' , N'" + cbmnv_px.Text.ToString() + "' , '" + dtpngayxuat.Value.ToString("yyyy/MM/dd") + "' )";
                command.ExecuteNonQuery();
                loaddatapx();
                txtmpx.Focus();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE PHIEUXUAT SET MaCH = @MaCH, MaNV = @MaNV, NgayXuat = @NgayXuat WHERE MaPX = @MaPX";

            command = connection.CreateCommand();
            command.CommandText = sql;

            // Định nghĩa các tham số và gán giá trị cho từng tham số
            command.Parameters.AddWithValue("@MaCH", cbmch_px.Text.ToString());
            command.Parameters.AddWithValue("@MaNV", cbmnv_px.Text.ToString());
            command.Parameters.AddWithValue("@NgayXuat", dtpngayxuat.Value);
            command.Parameters.AddWithValue("@MaPX", txtmpx.Text);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                loaddatapx();
                txtmpx.Focus();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message, "Lỗi");
            }
            connection.Close();
        }

        private void btnxoapx_Click(object sender, EventArgs e)
        {
            //connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM PHIEUXUAT WHERE MaPX = '" + txtmpx.Text + "'";
            command.ExecuteNonQuery();
            loaddatapx();
            txtmpx.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
            //connection.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddatapx();
            loaddatactpx();
            txtmpx.Clear();
            cbmnv_px.Text = string.Empty;
            cbmch_px.Text = string.Empty;
            cbmasp_ctpx.Text = string.Empty;
            dtpngayxuat.Value = DateTime.Today;
            txtmpx_ctpx.Text = string.Empty;
            txtslxuat.Clear();
            txttench_px.Clear();
            txttensp_ctpx.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemctpx_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " INSERT INTO CTPHIEUXUAT VALUES ('" + txtmpx_ctpx.Text + "', N'" + cbmasp_ctpx.Text + "', N'" + txtslxuat.Text + "')";
                command.ExecuteNonQuery();
                loaddatactpx();
                txtmpx_ctpx.Focus();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }

        private void btnupdate_ctpx_Click(object sender, EventArgs e)
        {
            try
            {
                //using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    string sql = "UPDATE CTPHIEUXUAT SET MaSP=@MaSP, SoLuongXuat = @SoLuongXuat WHERE CTPHIEUXUAT.MaPX = MaPX";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Định nghĩa và gán giá trị cho các tham số
                        command.Parameters.AddWithValue("@MaSP", cbmasp_ctpx.Text);
                        command.Parameters.AddWithValue("@SoLuongXuat", txtslxuat.Text);
                        command.Parameters.AddWithValue("@MaPN", txtmpx_ctpx.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        loaddatactpx();
                        txtmpx_ctpx.Focus();
                        MessageBox.Show("Sửa thành công", "Thông báo");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message, "Lỗi");
            }
            connection.Close();
        }

        private void btnxoactpx_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM CTPHIEUXUAT WHERE CTPHIEUXUAT.MaPX = '" + txtmpx_ctpx.Text + "'";
            command.ExecuteNonQuery();
            loaddatactpx();
            txtmpx_ctpx.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
            connection.Close();
        }

        private void cbmasp_ctpx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenSP FROM SANPHAM where MaSP = @MaSP";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaSP", cbmasp_ctpx.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttensp_ctpx.Text = dr["TenSP"].ToString(); // Gán giá trị TenCH từ SqlDataReader vào TextBox
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttensp_ctpx.Text = "Không tìm thấy sản phẩm này.";
            }

            connection.Close();
        }

        private void cbmasp_ctpx_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SANPHAM";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbmasp_ctpx.DataSource = dt;
            cbmasp_ctpx.DisplayMember = "MaSP";
            connection.Close();
        }

        private void btntimkiempx_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHIEUXUAT WHERE MaPX = @MaPX";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaPX", txttimkiemmakh.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvpx.DataSource = dt;
        }

        private void btnxuathd_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvpx.CurrentRow;
            DataGridViewRow currentRow1 = dgvctpx.CurrentRow;

            if (currentRow != null && currentRow1 != null)
            {
                // Lấy thông tin từ các cột của dòng hiện tại
                string maPX = currentRow.Cells["MaPX"].Value.ToString();
                string maCH = currentRow.Cells["MaCH"].Value.ToString();
                string maNhanVien = currentRow.Cells["MaNV"].Value.ToString();
                string maSanPham = currentRow1.Cells["MaSP"].Value.ToString();
                int slNHAP = Convert.ToInt32(currentRow1.Cells["SoLuongXuat"].Value);
                DateTime ngayXuat = Convert.ToDateTime(currentRow.Cells["NgayXuat"].Value);

                // Tạo nội dung
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\t\t\t\tTHÔNG TIN PHIẾU XUẤT");
                sb.AppendLine("\n\t\t------------------------------------------------------------------------------");
                sb.AppendLine($"\t\tMã phiếu xuất: {maPX} \t\t Mã của hàng: {maCH}");
                sb.AppendLine($"\t\tNhân viên lập phiếu xuất: {maNhanVien}");
                sb.AppendLine("\t\t------------------------------------------------------------------------------");
                sb.AppendLine($"\t\tMã sản phẩm: {maSanPham}");
                sb.AppendLine($"\t\tSố lượng xuất: {slNHAP}");

                sb.AppendLine("\t\t---------------------------------");

                sb.AppendLine($"\n\t\t\t\t\tNgày nhập: {ngayXuat.ToString("dd/MM/yyyy HH:mm:ss")}");


                // In hóa đơn
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (s, ev) =>
                {
                    Graphics g = ev.Graphics;
                    Font font = new Font("Arial", 13);

                    // Vẽ nội dung từ StringBuilder lên trang in hóa đơn
                    g.DrawString(sb.ToString(), font, Brushes.Black, new PointF(100, 100));
                };

                // Mở hộp thoại in và in hóa đơn
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pd;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu xuất và chi tiết phiếu xuất để in.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuaSLTon s = new SuaSLTon();
            s.ShowDialog();
        }
    }
}

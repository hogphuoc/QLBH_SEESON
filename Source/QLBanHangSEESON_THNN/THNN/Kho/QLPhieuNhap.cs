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

namespace THNN
{
    public partial class QLPhieuNhap : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-MA6F1L2;Initial Catalog=QLBH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        BindingSource bdsource = new BindingSource();
        DataTable table = new DataTable();
        DataTable table1 = new DataTable();
        DataTable table2 = new DataTable();
        private void loaddatapn()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM PHIEUNHAP";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvpn.DataSource = table;
        }
        private void loaddatactpn()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM CTPHIEUNHAP WHERE MaPN = N'" + txtmpn.Text + "'";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgvctpn.DataSource = table2;
        }
        private void loaddataddh()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT DONDATHANGNCC.MaDDH, DONDATHANGNCC.MaNCC, DONDATHANGNCC.MaCH, DONDATHANGNCC.NgayDH,DONDATHANGNCC.NgayDKNH,CTDONDATHANGNCC.MaSP,CTDONDATHANGNCC.SLDat FROM DONDATHANGNCC, CTDONDATHANGNCC WHERE DONDATHANGNCC.MaDDH=CTDONDATHANGNCC.MaDDH";
            adapter.SelectCommand = command;
            table1.Clear();
            adapter.Fill(table1);
            dgvxemddh.DataSource = table1;
        }
        public QLPhieuNhap()
        {
            InitializeComponent();
        }

        private void dgvpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvpn.CurrentRow.Index;
            txtmpn.Text = dgvpn.Rows[i].Cells[0].Value.ToString();
            cbmch_pn.SelectedItem = dgvpn.Rows[i].Cells[1].Value.ToString();
            cbmnv_pn.SelectedItem = dgvpn.Rows[i].Cells[2].Value.ToString();
            cbMancc_pn.SelectedItem = dgvpn.Rows[i].Cells[3].Value.ToString();
            dtpngaynhap.Value = (DateTime)dgvpn.Rows[i].Cells[4].Value;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;

            loaddatactpn();
        }

        private void dgvctpn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvctpn.Rows.Count)
                return;

            // Lấy chỉ số của hàng hiện tại
            int rowIndex = e.RowIndex;

            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvctpn.Columns.Count)
                return;

            // Lấy giá trị từ ô được click
            DataGridViewRow selectedRow = dgvctpn.Rows[rowIndex];

            // Kiểm tra nếu hàng được chọn không hợp lệ
            if (selectedRow == null || selectedRow.Cells.Count == 0)
                return;

            // Lấy giá trị từ các ô của hàng được chọn
            txtmpn_ctpn.Text = selectedRow.Cells[0].Value?.ToString(); // Sử dụng ?.ToString() để tránh lỗi nếu giá trị null
            cbmasp_ctpn.SelectedItem = selectedRow.Cells[1].Value?.ToString();
            txtslnhap.Text = selectedRow.Cells[2].Value?.ToString();
            txtdongianhap.Text = selectedRow.Cells[3].Value?.ToString();
        }

        private void QLPhieuNhap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddatapn();
            loaddatactpn();
            loaddataddh();
        }

        private void cbmch_pn_SelectedIndexChanged(object sender, EventArgs e)
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
                    cmdTenCH.Parameters.AddWithValue("@MaCH", cbmch_pn.Text); // Sử dụng tham số để tránh SQL Injection

                    SqlDataReader drTenCH = cmdTenCH.ExecuteReader();
                    if (drTenCH.Read())
                    {
                        txttench_pn.Text = drTenCH["TenCH"].ToString();
                    }
                    else
                    {
                        txttench_pn.Text = "Không tìm thấy tên cửa hàng này.";
                    }
                    drTenCH.Close(); // Đóng DataReader sau khi sử dụng

                    // Lấy danh sách MaNV từ bảng NHANVIEN cho cửa hàng được chọn
                    string sqlQueryMaNV = "SELECT NHANVIEN.MaNV FROM NHANVIEN INNER JOIN CUAHANG ON CUAHANG.MaCH = NHANVIEN.MaCH WHERE CUAHANG.MaCH = @MaCH";
                    SqlCommand cmdMaNV = new SqlCommand(sqlQueryMaNV, connection);
                    cmdMaNV.Parameters.AddWithValue("@MaCH", cbmch_pn.Text); // Sử dụng tham số để tránh SQL Injection

                    SqlDataReader drMaNV = cmdMaNV.ExecuteReader();
                    cbmnv_pn.Items.Clear(); // Xóa các mục cũ trong ComboBox trước khi thêm mới
                    while (drMaNV.Read())
                    {
                        cbmnv_pn.Items.Add(drMaNV["MaNV"].ToString());
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

        private void cbmch_pn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CUAHANG";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbmch_pn.DataSource = dt;
            cbmch_pn.DisplayMember = "MaCH";
            //connection.Close();
        }

        private void cbmasp_ctpn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenSP FROM SANPHAM where MaSP = @MaSP";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaSP", cbmasp_ctpn.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttensp_ctpn.Text = dr["TenSP"].ToString(); // Gán giá trị TenCH từ SqlDataReader vào TextBox
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttensp_ctpn.Text = "Không tìm thấy sản phẩm này.";
            }

            connection.Close();
        }

        private void cbmasp_ctpn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SANPHAM";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbmasp_ctpn.DataSource = dt;
            cbmasp_ctpn.DisplayMember = "MaSP";
            connection.Close();
        }

        private void cbMancc_pn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenNCC FROM NHACUNGCAP where MaNCC = @MaNCC";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaNCC", cbMancc_pn.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttenncc_pn.Text = dr["TenNCC"].ToString(); // Gán giá trị TenNCC từ SqlDataReader vào TextBox
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttenncc_pn.Text = "Không tìm thấy sản phẩm này.";
            }
            connection.Close();
        }

        private void cbMancc_pn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHACUNGCAP";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbMancc_pn.DataSource = dt;
            cbMancc_pn.DisplayMember = "MaNCC";
            //connection.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " INSERT INTO PHIEUNHAP VALUES ('" + txtmpn.Text + "', N'" + cbmch_pn.Text.ToString() + "' , N'" + cbmnv_pn.Text.ToString() + "' , N'" + cbMancc_pn.Text.ToString() + "' , '" + dtpngaynhap.Value.ToString("yyyy/MM/dd") + "' )";
                command.ExecuteNonQuery();
                loaddatapn();
                txtmpn.Focus();
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
            string sql = "UPDATE PHIEUNHAP SET MaCH = @MaCH, MaNV = @MaNV, MaNCC=@MaNCC, NgayNhap = @NgayNhap WHERE MaPN = @MaPN";

            command = connection.CreateCommand();
            command.CommandText = sql;

            // Định nghĩa các tham số và gán giá trị cho từng tham số
            command.Parameters.AddWithValue("@MaCH", cbmch_pn.Text.ToString());
            command.Parameters.AddWithValue("@MaNV", cbmnv_pn.Text.ToString());
            command.Parameters.AddWithValue("@MaNCC", cbMancc_pn.Text.ToString());
            command.Parameters.AddWithValue("@NgayNhap", dtpngaynhap.Value);
            command.Parameters.AddWithValue("@MaPN", txtmpn.Text);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                loaddatapn();
                txtmpn.Focus();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message, "Lỗi");
            }
            connection.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM PHIEUNHAP WHERE MaPN = '" + txtmpn.Text + "'";
            command.ExecuteNonQuery();
            loaddatapn();
            txtmpn.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddatapn();
            loaddatactpn();
            txtmpn.Clear();
            cbmnv_pn.Text = string.Empty;
            cbmch_pn.Text = string.Empty;
            cbMancc_pn.Text = string.Empty;
            cbmasp_ctpn.Text = string.Empty;
            dtpngaynhap.Value = DateTime.Today;
            txtmpn_ctpn.Text = string.Empty;
            txtslnhap.Clear();
            txtdongianhap.Clear();
            txttench_pn.Clear();
            txttenncc_pn.Clear();
            txttensp_ctpn.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthemcthd_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " INSERT INTO CTPHIEUNHAP VALUES ('" + txtmpn_ctpn.Text + "', N'" + cbmasp_ctpn.Text + "', N'" + txtslnhap.Text + "', N'" + txtdongianhap.Text + "')";
                command.ExecuteNonQuery();
                loaddatactpn();
                txtmpn_ctpn.Focus();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM CTPHIEUNHAP WHERE CTPHIEUNHAP.MaPN = '" + txtmpn_ctpn.Text + "'";
            command.ExecuteNonQuery();
            loaddatactpn();
            txtmpn_ctpn.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
            connection.Close();
        }

        private void btnupdate_ctpn_Click(object sender, EventArgs e)
        {
            try
            {
                //using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    string sql = "UPDATE CTPHIEUNHAP SET MaSP=@MaSP, SoLuongNhap = @SoLuongNhap, DonGiaNhap = @DonGiaNhap WHERE CTPHIEUNHAP.MaPN = MaPN";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Định nghĩa và gán giá trị cho các tham số
                        command.Parameters.AddWithValue("@MaSP", cbmasp_ctpn.Text);
                        command.Parameters.AddWithValue("@SoLuongNhap", txtslnhap.Text);
                        command.Parameters.AddWithValue("@DonGiaNhap", txtdongianhap.Text);
                        command.Parameters.AddWithValue("@MaPN", txtmpn_ctpn.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        loaddatactpn();
                        txtmpn_ctpn.Focus();
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

        private void btntimkiempn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM PHIEUNHAP WHERE MaPN = @MaPN";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaPN", txttimkiemmapx.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvpn.DataSource = dt;
        }

        private void btnxuathd_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgvpn.CurrentRow;
            DataGridViewRow currentRow1 = dgvctpn.CurrentRow;

            if (currentRow != null && currentRow1 != null)
            {
                // Lấy thông tin từ các cột của dòng hiện tại
                string maPN = currentRow.Cells["MaPN"].Value.ToString();
                string maNCC = currentRow.Cells["MaNCC"].Value.ToString();
                string maCH = currentRow.Cells["MaCH"].Value.ToString();
                string maNhanVien = currentRow.Cells["MaNV"].Value.ToString();
                string maSanPham = currentRow1.Cells["MaSP"].Value.ToString();
                int slNHAP = Convert.ToInt32(currentRow1.Cells["SoLuongNhap"].Value);
                decimal dongiaNHAP = Convert.ToDecimal(currentRow1.Cells["DonGiaNhap"].Value);
                DateTime ngayNhap = Convert.ToDateTime(currentRow.Cells["NgayNhap"].Value);

                // Tính thành tiền
                decimal thanhTien = slNHAP * dongiaNHAP;

                // Tạo nội dung
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\t\t\t\tTHÔNG TIN PHIẾU NHẬP");
                sb.AppendLine("\n\t\t------------------------------------------------------------------------------");
                sb.AppendLine($"\t\tMã phiếu nhập: {maPN} \t\t Mã nhà cung cấp: {maNCC}");
                sb.AppendLine($"\t\tNhân viên nhập phiếu: {maNhanVien}");
                sb.AppendLine("\t\t------------------------------------------------------------------------------");
                sb.AppendLine($"\t\tMã sản phẩm nhập: {maSanPham}");
                sb.AppendLine($"\t\tSố lượng nhập: {slNHAP}");
                sb.AppendLine($"\t\tĐơn giá nhập: {dongiaNHAP.ToString("N0")} VNĐ"); // Định dạng đơn giá
                sb.AppendLine("\t\t---------------------------------");
                sb.AppendLine($"\t\tThành tiền: {thanhTien.ToString("N0")} VNĐ"); // Định dạng thành tiền     
                sb.AppendLine($"\n\t\t\t\t\tNgày nhập: {ngayNhap.ToString("dd/MM/yyyy HH:mm:ss")}");


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
                MessageBox.Show("Vui lòng chọn một phiếu nhập và chi tiết phiếu nhập để in.");
            }
        }
    }
}

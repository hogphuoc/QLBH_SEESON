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
    public partial class QLHoaDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-MA6F1L2;Initial Catalog=QLBH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        BindingSource bdsource = new BindingSource();
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM HOADONKH";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvhoadon.DataSource = table;
        }
        private void loaddatacthd()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM CTHOADONKH WHERE MaHD = N'" + txtmhd.Text + "'";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgvCthoadon.DataSource = table2;
        }
        public QLHoaDon()
        {
            InitializeComponent();
        }

        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvhoadon.CurrentRow.Index;
            txtmhd.Text = dgvhoadon.Rows[i].Cells[0].Value.ToString();
            txtmkh_hd.Text = dgvhoadon.Rows[i].Cells[1].Value.ToString();
            txtmnv_hd.Text = dgvhoadon.Rows[i].Cells[2].Value.ToString();
            dtpngayin.Value = (DateTime)dgvhoadon.Rows[i].Cells[3].Value;
            cbpttt.SelectedItem = dgvhoadon.Rows[i].Cells[4].Value.ToString();
            cbkm.SelectedItem = dgvhoadon.Rows[i].Cells[5].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;

            loaddatacthd();
        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
            loaddatacthd();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " INSERT INTO HOADONKH VALUES ('" + txtmhd.Text + "', N'" + txtmkh_hd.Text + "' , N'" + txtmnv_hd.Text + "' , '" + dtpngayin.Value.ToString("yyyy/MM/dd") + "' , N'" + cbpttt.Text + "', N'" + cbkm.Text + "')";
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            /*command = connection.CreateCommand();
            command.CommandText = " UPDATE HOADONKH SET MaKH = N'" + txtmkh_hd.Text + "', MaNV = N'" + txtmnv_hd.Text + "', NgayIn = N'" + dtpngayin.Text.ToString() + "', PTTT = N'" + cbpttt.Text + "', ApDungKM =N'" + cbkm.Text + "' Where MaHD = '" + txtmhd.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmkh.Focus();
            MessageBox.Show("Sửa thành công", "Thông báo");*/
            string sql = "UPDATE HOADONKH SET MaKH = @MaKH, MaNV = @MaNV, NgayIn = @NgayIn, PTTT = @PTTT, ApDungKM = @ApDungKM WHERE MaHD = @MaHD";

            command = connection.CreateCommand();
            command.CommandText = sql;

            // Định nghĩa các tham số và gán giá trị cho từng tham số
            command.Parameters.AddWithValue("@MaKH", txtmkh_hd.Text);
            command.Parameters.AddWithValue("@MaNV", txtmnv_hd.Text);
            command.Parameters.AddWithValue("@NgayIn", dtpngayin.Value); // Sử dụng dtpngayin.Value thay vì dtpngayin.Text
            command.Parameters.AddWithValue("@PTTT", cbpttt.Text);
            command.Parameters.AddWithValue("@ApDungKM", cbkm.Text);
            command.Parameters.AddWithValue("@MaHD", txtmhd.Text);

            try
            {
                //connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                loaddata();
                txtmkh.Focus();
                MessageBox.Show("Sửa thành công", "Thông báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi thực hiện câu lệnh SQL: " + ex.Message, "Lỗi");
            }
            /*finally
            {
                connection.Close();
            }*/
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
            loaddatacthd();
            txtmhd.Clear();
            txtmnv_hd.Clear();
            txtmkh_hd.Clear();
            dtpngayin.Value = DateTime.Today;
            cbkm.Text = string.Empty;
            cbpttt.Text = string.Empty;
            txtmhd_cthd.Clear();
            txtdongiaban.Clear();
            txtslmua.Clear();
            txttensp_cthd.Clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM HOADONKH WHERE MaHD = '" + txtmhd.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmkh.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void dgvCthoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0 || e.RowIndex >= dgvCthoadon.Rows.Count)
                return;

            // Lấy chỉ số của hàng hiện tại
            int rowIndex = e.RowIndex;

            // Kiểm tra nếu ô được click không phải là ô dữ liệu (vd: header)
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvCthoadon.Columns.Count)
                return;

            // Lấy giá trị từ ô được click
            DataGridViewRow selectedRow = dgvCthoadon.Rows[rowIndex];

            // Kiểm tra nếu hàng được chọn không hợp lệ
            if (selectedRow == null || selectedRow.Cells.Count == 0)
                return;

            // Lấy giá trị từ các ô của hàng được chọn
            txtmhd_cthd.Text = selectedRow.Cells[0].Value?.ToString(); // Sử dụng ?.ToString() để tránh lỗi nếu giá trị null
            cbmasp_cthd.SelectedItem = selectedRow.Cells[1].Value?.ToString();
            txtslmua.Text = selectedRow.Cells[2].Value?.ToString();
            txtdongiaban.Text = selectedRow.Cells[3].Value?.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM CTHOADONKH WHERE CTHOADONKH.MaHD = '" + txtmhd_cthd.Text + "'";
            command.ExecuteNonQuery();
            loaddatacthd();
            txtmkh.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
            connection.Close();
        }

        private void cbmasp_cthd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenSP FROM SANPHAM where MaSP = @MaSP";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaSP", cbmasp_cthd.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttensp_cthd.Text = dr["TenSP"].ToString(); // Gán giá trị TenCH từ SqlDataReader vào TextBox
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttensp_cthd.Text = "Không tìm thấy sản phẩm này.";
            }

            connection.Close();
        }

        private void cbmasp_cthd_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SANPHAM";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            cbmasp_cthd.DataSource = dt;
            cbmasp_cthd.DisplayMember = "MaSP";
            connection.Close();
        }

        private void btntimkiemhd_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM HOADONKH WHERE MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("MaKH", txttimkiemmakh.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvhoadon.DataSource = dt;
        }
        private void btnupdate_cthd_Click(object sender, EventArgs e)
        {
            /*connection.Open();
            command = connection.CreateCommand();
            command.CommandText = " UPDATE CTHOADONKH SET MaSP = N'" + cbmasp_cthd.Text + "', SoLuongMua = N'" + txtslmua.Text + "',  DonGiaBan = N'" + txtdongiaban.Text + "' Where CTHOADONKH.MaHD = '" + txtmkh.Text + "'";
            command.ExecuteNonQuery();
            loaddatacthd();
            txtmkh.Focus();
            MessageBox.Show("Sửa thành công", "Thông báo");*/
            try
            {
                //using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    string sql = "UPDATE CTHOADONKH SET SoLuongMua = @SoLuongMua, DonGiaBan = @DonGiaBan WHERE CTHOADONKH.MaHD = MaHD";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        // Định nghĩa và gán giá trị cho các tham số
                        command.Parameters.AddWithValue("@MaSP", cbmasp_cthd.Text);
                        command.Parameters.AddWithValue("@SoLuongMua", txtslmua.Text);
                        command.Parameters.AddWithValue("@DonGiaBan", txtdongiaban.Text);
                        command.Parameters.AddWithValue("@MaHD", txtmkh.Text);

                        int rowsAffected = command.ExecuteNonQuery();
                        loaddatacthd();
                        txtmkh.Focus();
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

        private void btnthemcthd_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " INSERT INTO CTHOADONKH VALUES ('" + txtmhd.Text + "', N'" + cbmasp_cthd.Text + "', N'" + txtslmua.Text + "', N'" + txtdongiaban.Text + "')";
                command.ExecuteNonQuery();
                loaddatacthd();
                txtmhd.Focus();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connection.Close();
        }

        private void btnthoathd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Inhoadon()
        {
            pddHoaDon.Document = pdHoaDon;
            pddHoaDon.ShowDialog();
            
        }

        private void btnxuathd_Click(object sender, EventArgs e)
        {
            //Inhoadon();
            DataGridViewRow currentRow = dgvhoadon.CurrentRow;
            DataGridViewRow currentRow1 = dgvCthoadon.CurrentRow;

            if (currentRow != null && currentRow1!=null)
            {
                // Lấy thông tin từ các cột của dòng hiện tại
                string maHoaDon = currentRow.Cells["MaHD"].Value.ToString();
                string maKhachHang = currentRow.Cells["MaKH"].Value.ToString();
                string maNhanVien = currentRow.Cells["MaNV"].Value.ToString();
                string maSanPham = currentRow1.Cells["MaSP"].Value.ToString();
                int slmua = Convert.ToInt32(currentRow1.Cells["SoLuongMua"].Value);
                decimal dongiaban = Convert.ToDecimal(currentRow1.Cells["DonGiaBan"].Value);
                string PTTT = currentRow.Cells["PTTT"].Value.ToString();
                DateTime ngayInHoaDon = Convert.ToDateTime(currentRow.Cells["NgayIn"].Value);

                // Tính thành tiền
                decimal thanhTien = slmua * dongiaban;

                // Tạo nội dung
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("\t\t\t\tHÓA ĐƠN BÁN HÀNG");
                sb.AppendLine("\n\t\t------------------------------------------------------------------------------");
                sb.AppendLine($"\t\tMã hóa đơn: {maHoaDon} \t\t Mã khách hàng: {maKhachHang}");
                sb.AppendLine($"\t\tNhân viên lập: {maNhanVien}");
                sb.AppendLine("\t\t------------------------------------------------------------------------------");
                sb.AppendLine($"\t\tMã sản phẩm mua: {maSanPham}");
                sb.AppendLine($"\t\tPhương thức thanh toán: {PTTT}");
                sb.AppendLine($"\t\tSố lượng mua: {slmua}");
                sb.AppendLine($"\t\tĐơn giá: {dongiaban.ToString("N0")} VNĐ"); // Định dạng đơn giá
                sb.AppendLine("\t\t---------------------------------");
                sb.AppendLine($"\t\tThành tiền: {thanhTien.ToString("N0")} VNĐ"); // Định dạng thành tiền     
                sb.AppendLine($"\n\t\t\t\t\tNgày in hóa đơn: {ngayInHoaDon.ToString("dd/MM/yyyy HH:mm:ss")}");
                

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
                MessageBox.Show("Vui lòng chọn một hóa đơn và chi tiết hóa đơn để in.");
            }
        }

        private void pdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           

        }
    }
}

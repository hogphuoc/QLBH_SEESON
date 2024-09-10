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

namespace THNN.Quanly
{
    public partial class QLDDH : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-MA6F1L2;Initial Catalog=QLBH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        BindingSource bdsource = new BindingSource();
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        private void loaddatapn()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM DONDATHANGNCC";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvddh.DataSource = table;
        }
        private void loaddatactpn()
        {
            command = connection.CreateCommand();
            command.CommandText = " SELECT * FROM CTDONDATHANGNCC WHERE MaDDH = N'" + txtmddh.Text + "'";
            adapter.SelectCommand = command;
            table2.Clear();
            adapter.Fill(table2);
            dgvctddh.DataSource = table2;
        }
        public QLDDH()
        {
            InitializeComponent();
        }

        private void QLDDH_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddatapn();
            loaddatactpn();
        }

        private void cbMancc_pn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenNCC FROM NHACUNGCAP where MaNCC = @MaNCC";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaNCC", cbMancc_ddh.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttenncc_pn.Text = dr["TenNCC"].ToString(); // Gán giá trị TenNCC từ SqlDataReader vào TextBox
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttenncc_pn.Text = "Không tìm thấy tên nhà cung cấp này.";
            }
            connection.Close();
        }

        private void cbmch_pn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenCH FROM CUAHANG where MaCH = @MaCH";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaCH", cbMancc_ddh.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttenncc_pn.Text = dr["TenCH"].ToString(); // Gán giá trị TenNCC từ SqlDataReader vào TextBox
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttenncc_pn.Text = "Không tìm thấy tên cửa hàng này.";
            }
            connection.Close();
        }

        private void cbmasp_ctpn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT TenSP FROM SANPHAM where MaSP = @MaSP";
            SqlCommand objCommand = new SqlCommand(sqlQuery, connection);
            objCommand.Parameters.AddWithValue("@MaSP", cbMancc_ddh.Text); // Sử dụng Parameters để tránh lỗ hổng SQL Injection

            connection.Open();
            SqlDataReader dr = objCommand.ExecuteReader();

            if (dr.Read()) // Sử dụng if thay cho while vì chỉ cần lấy giá trị đầu tiên (nếu có)
            {
                txttenncc_pn.Text = dr["TenSP"].ToString();
            }
            else
            {
                // Xử lý khi không tìm thấy dữ liệu, ví dụ:
                txttenncc_pn.Text = "Không tìm thấy sản phẩm này.";
            }
            connection.Close();
        }

        private void dgvddh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvddh.CurrentRow.Index;
            txtmddh.Text = dgvddh.Rows[i].Cells[0].Value.ToString();
            cbMancc_ddh.SelectedItem = dgvddh.Rows[i].Cells[1].Value.ToString();
            cbmch_ddh.SelectedItem = dgvddh.Rows[i].Cells[2].Value.ToString();
            dtpngaydat.Value = (DateTime)dgvddh.Rows[i].Cells[3].Value;
            dtpngaynhan.Value = (DateTime)dgvddh.Rows[i].Cells[4].Value;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;

            loaddatactpn();
        }

        private void dgvctddh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvctddh.Rows.Count)
                return;

            // Lấy chỉ số của hàng hiện tại
            int rowIndex = e.RowIndex;

            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvctddh.Columns.Count)
                return;

            // Lấy giá trị từ ô được click
            DataGridViewRow selectedRow = dgvctddh.Rows[rowIndex];

            // Kiểm tra nếu hàng được chọn không hợp lệ
            if (selectedRow == null || selectedRow.Cells.Count == 0)
                return;

            // Lấy giá trị từ các ô của hàng được chọn
            txtmddh_ct.Text = selectedRow.Cells[0].Value?.ToString(); // Sử dụng ?.ToString() để tránh lỗi nếu giá trị null
            cbmasp_ctddh.SelectedItem = selectedRow.Cells[1].Value?.ToString();
            txtsldat.Text = selectedRow.Cells[2].Value?.ToString();
        }
    }
}

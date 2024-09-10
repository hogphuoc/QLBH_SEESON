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

namespace THNN.DangnNhap
{
    public partial class XemTTSP : Form
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
            command.CommandText = " select MaSP, TenSP, SLTon, Hinhanh from SANPHAM";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvsp.DataSource = table;
        }
        public XemTTSP()
        {
            InitializeComponent();
        }

        private void XemTTSP_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void btntimkiemnv_Click(object sender, EventArgs e)
        {
            //connection.Open();
            string query = "SELECT MaSP, TenSP, SLTon, Hinhanh FROM SANPHAM WHERE MaSP ='" + txttimkiemmsp.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            //cmd.Parameters.AddWithValue("MaSP", txtmsp.Text.ToString());
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvsp.DataSource = dt;
            connection.Close();
        }

        private void dgvsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsp.Rows[e.RowIndex];


                if (row.Cells[3].Value != null && row.Cells[3].Value.ToString() != "")
                {
                    string imagePath = row.Cells[3].Value.ToString();

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
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
            txttimkiemmsp.Clear();
            connection.Open();
        }
    }
}

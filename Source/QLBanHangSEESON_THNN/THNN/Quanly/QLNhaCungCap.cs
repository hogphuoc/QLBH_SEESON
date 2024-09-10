
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
    public partial class QLNhaCungCap : Form
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
            command.CommandText = " SELECT * FROM NHACUNGCAP";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvncc.DataSource = table;
        }
        public QLNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = " INSERT INTO NHACUNGCAP VALUES ('" + txtmncc.Text + "', N'" + txttenncc.Text + "' , '" + txtsdtncc.Text + "', N'" + txtemailncc.Text + "')";
                command.ExecuteNonQuery();
                loaddata();
                txtmncc.Focus();
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " UPDATE NHACUNGCAP SET TenNCC = N'" + txttenncc.Text + "', SDTNCC = N'" + txtsdtncc.Text + "',EmailNCC='" + txtemailncc.Text + "' Where MaNCC = '" + txtmncc.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmncc.Focus();
            MessageBox.Show("Sửa thành công", "Thông báo");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM NHACUNGCAP WHERE MaNCC = '" + txtmncc.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmncc.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmncc.Clear();
            txttenncc.Clear();
            txtsdtncc.Clear();
            txtemailncc.Clear();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM NHACUNGCAP WHERE SDTNCC ='" + txtsdtncc.Text + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("SDTNCC", txtsdtncc.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvncc.DataSource = dt;
        }

        private void dgvncc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvncc.CurrentRow.Index;
            txtmncc.Text = dgvncc.Rows[i].Cells[0].Value.ToString();
            txttenncc.Text = dgvncc.Rows[i].Cells[1].Value.ToString();
            txtsdtncc.Text = dgvncc.Rows[i].Cells[2].Value.ToString();
            txtemailncc.Text = dgvncc.Rows[i].Cells[3].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void QLNhaCungCap_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
    }
}

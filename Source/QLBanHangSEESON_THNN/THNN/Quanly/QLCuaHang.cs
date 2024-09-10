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
    public partial class QLCuaHang : Form
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
            command.CommandText = " SELECT * FROM CUAHANG";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvcuahang.DataSource = table;
        }
        public QLCuaHang()
        {
            InitializeComponent();
        }

        private void dgvcuahang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvcuahang.CurrentRow.Index;
            txtmch.Text = dgvcuahang.Rows[i].Cells[0].Value.ToString();
            txttench.Text = dgvcuahang.Rows[i].Cells[1].Value.ToString();
            txtdiachich.Text = dgvcuahang.Rows[i].Cells[2].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void QLCuaHang_Load(object sender, EventArgs e)
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
                command.CommandText = " INSERT INTO CUAHANG VALUES ('" + txtmch.Text + "', N'" + txttench.Text + "' , N'" + txtdiachich.Text + "')";
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

        private void btnload_Click(object sender, EventArgs e)
        {
            loaddata();
            txtmch.Clear();
            txttench.Clear();
            txtdiachich.Clear();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " UPDATE CUAHANG SET TenCH = N'" + txttench.Text + "', DiaChiCH = N'" + txtdiachich.Text + "' Where MaCH = '" + txtmch.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmkh.Focus();
            MessageBox.Show("Sửa thành công", "Thông báo");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM CUAHANG WHERE DiaChiCH like N'%" + txttimkiemdcch.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("DiaChiCH", txtdiachich.Text);
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvcuahang.DataSource = dt;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " DELETE FROM CUAHANG WHERE MaCH = '" + txtmch.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtmch.Focus();
            MessageBox.Show("Xóa thành công", "Thông báo");
        }
    }
}

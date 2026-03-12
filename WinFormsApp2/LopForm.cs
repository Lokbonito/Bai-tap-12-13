using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class LopForm : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Server=DESKTOP-4MSF0L8;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True");

        int classId;

        public LopForm()
        {
            InitializeComponent();
            LoadClass();
        }

        void LoadClass()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Class", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvLop.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenLop.Text == "")
            {
                MessageBox.Show("Nhập tên lớp");
                return;
            }

            conn.Open();

            string sql = "INSERT INTO Class(ClassName) VALUES(@name)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@name", txtTenLop.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadClass();

            txtTenLop.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (classId == 0)
            {
                MessageBox.Show("Chọn lớp cần sửa");
                return;
            }

            conn.Open();

            string sql = "UPDATE Class SET ClassName=@name WHERE ClassId=@id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@name", txtTenLop.Text);
            cmd.Parameters.AddWithValue("@id", classId);

            cmd.ExecuteNonQuery();

            conn.Close();

            LoadClass();

            MessageBox.Show("Sửa thành công");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (classId == 0)
            {
                MessageBox.Show("Chọn lớp cần xóa");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                conn.Open();

                string sql = "DELETE FROM Class WHERE ClassId=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", classId);

                cmd.ExecuteNonQuery();

                conn.Close();

                LoadClass();

                txtTenLop.Clear();

                MessageBox.Show("Xóa thành công");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;

            if (row >= 0)
            {
                classId = Convert.ToInt32(dgvLop.Rows[row].Cells["ClassId"].Value);

                txtTenLop.Text = dgvLop.Rows[row].Cells["ClassName"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                LoadClass();
                return;
            }

            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Class WHERE ClassName LIKE '%" + txtSearch.Text + "%'", conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvLop.DataSource = dt;
        }

        private void txtTenLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
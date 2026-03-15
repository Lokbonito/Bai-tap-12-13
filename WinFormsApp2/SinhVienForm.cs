using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class SinhVienForm : Form
    {
        SqlConnection conn = new SqlConnection(
            @"Server=DESKTOP-4MSF0L8;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True");

        int studentId = -1;

        public SinhVienForm()
        {
            InitializeComponent();

            LoadLop();
            LoadSinhVien();

            dgvSinhVien.CellClick += dgvSinhVien_CellClick;
        }

        void LoadSinhVien()
        {
            string sql = @"SELECT Student.StudentId,
                                  Student.StudentCode,
                                  Student.StudentName,
                                  Student.Gender,
                                  Student.BirthDate,
                                  Class.ClassName
                           FROM Student
                           LEFT JOIN Class
                           ON Student.ClassId = Class.ClassId";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvSinhVien.DataSource = dt;
        }

        void LoadLop()
        {
            string sql = "SELECT * FROM Class";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cboLop.DataSource = dt;
            cboLop.DisplayMember = "ClassName";
            cboLop.ValueMember = "ClassId";
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                studentId = Convert.ToInt32(row.Cells["StudentId"].Value);

                txtMaSV.Text = row.Cells["StudentCode"].Value?.ToString();
                txtTenSV.Text = row.Cells["StudentName"].Value?.ToString();

                if (row.Cells["Gender"].Value != DBNull.Value)
                {
                    string gender = row.Cells["Gender"].Value.ToString();

                    if (gender == "Nam")
                        rdoNam.Checked = true;
                    else
                        rdoNu.Checked = true;
                }

                if (row.Cells["BirthDate"].Value != DBNull.Value)
                {
                    dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                }
                else
                {
                    dtpBirthDate.Value = DateTime.Now;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();

            string checkSql = "SELECT COUNT(*) FROM Student WHERE StudentCode=@code";

            SqlCommand checkCmd = new SqlCommand(checkSql, conn);
            checkCmd.Parameters.AddWithValue("@code", txtMaSV.Text);

            int count = (int)checkCmd.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!");
                conn.Close();
                return;
            }

            string gender = rdoNam.Checked ? "Nam" : "Nữ";

            string sql = @"INSERT INTO Student(StudentCode,StudentName,Gender,BirthDate,ClassId)
                           VALUES(@code,@name,@gender,@birth,@classid)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@code", txtMaSV.Text);
            cmd.Parameters.AddWithValue("@name", txtTenSV.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@birth", dtpBirthDate.Value);
            cmd.Parameters.AddWithValue("@classid", cboLop.SelectedValue);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Thêm sinh viên thành công!");

            LoadSinhVien();
            ClearForm();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (studentId == -1)
            {
                MessageBox.Show("Hãy chọn sinh viên cần sửa");
                return;
            }

            conn.Open();

            string gender = rdoNam.Checked ? "Nam" : "Nữ";

            string sql = @"UPDATE Student
                           SET StudentCode=@code,
                               StudentName=@name,
                               Gender=@gender,
                               BirthDate=@birth,
                               ClassId=@classid
                           WHERE StudentId=@id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", studentId);
            cmd.Parameters.AddWithValue("@code", txtMaSV.Text);
            cmd.Parameters.AddWithValue("@name", txtTenSV.Text);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@birth", dtpBirthDate.Value);
            cmd.Parameters.AddWithValue("@classid", cboLop.SelectedValue);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Sửa sinh viên thành công!");

            LoadSinhVien();
            ClearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (studentId == -1)
            {
                MessageBox.Show("Hãy chọn sinh viên cần xóa");
                return;
            }

            conn.Open();

            string sql = "DELETE FROM Student WHERE StudentId=@id";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@id", studentId);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Xóa sinh viên thành công!");

            LoadSinhVien();
            ClearForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT Student.StudentId,
                                  Student.StudentCode,
                                  Student.StudentName,
                                  Student.Gender,
                                  Student.BirthDate,
                                  Class.ClassName
                           FROM Student
                           LEFT JOIN Class
                           ON Student.ClassId = Class.ClassId
                           WHERE StudentName LIKE @search
                           OR StudentCode LIKE @search";

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtSearch.Text + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvSinhVien.DataSource = dt;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ClearForm()
        {
            txtMaSV.Clear();
            txtTenSV.Clear();
            txtSearch.Clear();

            rdoNam.Checked = true;

            dtpBirthDate.Value = DateTime.Now;

            studentId = -1;
        }
    }
}
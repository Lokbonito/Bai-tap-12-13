using Microsoft.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(
@"Server=.;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True");

            string query = "SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p";

            SqlCommand stmt = new SqlCommand(query, conn);

            stmt.Parameters.AddWithValue("@u", txtUsername.Text);
            stmt.Parameters.AddWithValue("@p", txtPassword.Text);

            conn.Open();

            int result = (int)stmt.ExecuteScalar();

            if (result > 0)
            {
                MessageBox.Show("Đăng nhập thành công");

                MainForm f = new MainForm();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }

            conn.Close();
        }
    }
}

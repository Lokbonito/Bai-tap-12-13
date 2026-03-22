using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            panelMain.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SinhVienForm());
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LopForm());
        }
    }
}
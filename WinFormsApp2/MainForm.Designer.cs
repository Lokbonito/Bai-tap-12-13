namespace WinFormsApp2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button btnSinhVien;
        private Button btnLop;
        private Panel panelMain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnSinhVien = new Button();
            btnLop = new Button();
            panelMain = new Panel();

            SuspendLayout();
            btnSinhVien.Location = new Point(50, 20);
            btnSinhVien.Size = new Size(120, 30);
            btnSinhVien.Text = "Sinh viên";
            btnSinhVien.Click += btnSinhVien_Click;

            btnLop.Location = new Point(200, 20);
            btnLop.Size = new Size(120, 30);
            btnLop.Text = "Lớp";
            btnLop.Click += btnLop_Click;

            panelMain.Location = new Point(20, 70);
            panelMain.Size = new Size(760, 360);
            panelMain.BorderStyle = BorderStyle.FixedSingle;

            ClientSize = new Size(800, 450);
            Controls.Add(btnSinhVien);
            Controls.Add(btnLop);
            Controls.Add(panelMain);
            Text = "MainForm";

            ResumeLayout(false);
        }
    }
}
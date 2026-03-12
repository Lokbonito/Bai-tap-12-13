namespace WinFormsApp2
{
    partial class SinhVienForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaSV = new TextBox();
            txtTenSV = new TextBox();
            txtSearch = new TextBox();
            cboLop = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnCancel = new Button();
            btnSearch = new Button();
            dgvSinhVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã SV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên Sinh Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 112);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 3;
            label4.Text = "Lớp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 243);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 4;
            label5.Text = "Tìm kiếm";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(109, 44);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(201, 23);
            txtMaSV.TabIndex = 5;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(109, 73);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(201, 23);
            txtTenSV.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(109, 240);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(201, 23);
            txtSearch.TabIndex = 8;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(109, 112);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(201, 23);
            cboLop.TabIndex = 9;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(109, 141);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(235, 141);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(109, 194);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(235, 194);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Quay lại";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(109, 283);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(336, 44);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.Size = new Size(452, 394);
            dgvSinhVien.TabIndex = 15;
            // 
            // SinhVienForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSinhVien);
            Controls.Add(btnSearch);
            Controls.Add(btnCancel);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboLop);
            Controls.Add(txtSearch);
            Controls.Add(txtTenSV);
            Controls.Add(txtMaSV);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SinhVienForm";
            Text = "SinhVienForm";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaSV;
        private TextBox txtTenSV;
        private TextBox txtSearch;
        private ComboBox cboLop;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnCancel;
        private Button btnSearch;
        private DataGridView dgvSinhVien;
    }
}
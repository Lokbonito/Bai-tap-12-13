namespace WinFormsApp2
{
    partial class LopForm
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
            txtTenLop = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnCancel = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvLop = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLop).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý lớp";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 64);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên lớp";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 276);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Tìm kiếm";
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(78, 64);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(203, 23);
            txtTenLop.TabIndex = 3;
            txtTenLop.TextChanged += txtTenLop_TextChanged;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(78, 141);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button1_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(206, 141);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 23);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += button2_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(78, 183);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 23);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += button3_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(206, 183);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Quay lại";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button4_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(78, 276);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(203, 23);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(78, 340);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvLop
            // 
            dgvLop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLop.Location = new Point(362, 64);
            dgvLop.Name = "dgvLop";
            dgvLop.Size = new Size(426, 374);
            dgvLop.TabIndex = 10;
            dgvLop.CellContentClick += dgvLop_CellContentClick;
            // 
            // LopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvLop);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnCancel);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTenLop);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LopForm";
            Text = "LopForm";
            ((System.ComponentModel.ISupportInitialize)dgvLop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTenLop;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnCancel;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvLop;
    }
}
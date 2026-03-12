namespace WinFormsApp2
{
    partial class MainForm
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
            btnQLSV = new Button();
            btnQLL = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 20);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản lý sinh viên";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnQLSV
            // 
            btnQLSV.Location = new Point(197, 189);
            btnQLSV.Name = "btnQLSV";
            btnQLSV.Size = new Size(141, 23);
            btnQLSV.TabIndex = 1;
            btnQLSV.Text = "Quản lý sinh viên";
            btnQLSV.UseVisualStyleBackColor = true;
            btnQLSV.Click += btnQLSV_Click;
            // 
            // btnQLL
            // 
            btnQLL.Location = new Point(432, 189);
            btnQLL.Name = "btnQLL";
            btnQLL.Size = new Size(141, 23);
            btnQLL.TabIndex = 2;
            btnQLL.Text = "Quản lý lớp";
            btnQLL.UseVisualStyleBackColor = true;
            btnQLL.Click += btnQLL_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQLL);
            Controls.Add(btnQLSV);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnQLSV;
        private Button btnQLL;
    }
}
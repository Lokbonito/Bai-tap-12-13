using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            SinhVienForm f = new SinhVienForm();
            f.Show();
        }

        private void btnQLL_Click(object sender, EventArgs e)
        {
            LopForm f = new LopForm();
            f.Show();
        }
    }
}

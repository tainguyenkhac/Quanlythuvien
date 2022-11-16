using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            lbUsername.Text = $"Xin Chào {Settings.UserName}";
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyDocGia();
            this.Hide();
            f.Show();
        }

        private void btnQuanLyMuonTra_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyMuonTraSach();
            this.Hide();
            f.Show();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {

        }

        private void btnQuanLyTacGia_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyTacGia();
            this.Hide();
            f.Show();
        }

        private void btnQuanLyLoaiSach_Click(object sender, EventArgs e)
        {
            Form f = new QuanLyLoaiSach();
            this.Hide();
            f.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                Settings.UserName = "";
                Settings.LoggedIn = true;
                this.Hide();
                Form f = new LoginGUI();
                f.Show();
            }
        }
    }
}

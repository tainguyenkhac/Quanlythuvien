using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK) Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string name, pass;
            var conf = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            name = conf["User:Name"];
            pass = conf["User:Password"];
            if (txtTaiKhoan.Text == name && txtMatKhau.Text == pass)
            {
                Settings.UserName = name;
                Settings.LoggedIn = true;
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                Form f = new Main();
                f.Show();
            }
            else MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
        }
    }
}

using QuanLyThuVien.Models;
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
    public partial class QuanLyTacGia : Form
    {
        int? maTacGia;
        quanlythuvienContext context;
        public QuanLyTacGia()
        {
            InitializeComponent();
            context = new quanlythuvienContext();
            bindGrid();
            dataGridViewTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dataGridViewTacGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewTacGia.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridViewTacGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridViewTacGia.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
        }

        private void bindGrid()
        {
            dataGridViewTacGia.Columns.Clear();
            dataGridViewTacGia.DataSource = context.TacGia.ToList<TacGium>();
            //dataGridViewTacGia.Columns[""].Visible = false;
            dataGridViewTacGia.Columns["MaTacGia"].Visible = false;
            dataGridViewTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dataGridViewTacGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewTacGia.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridViewTacGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridViewTacGia.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
        }

        private void bindGridByName(string s)
        {
            dataGridViewTacGia.Columns.Clear();
            dataGridViewTacGia.DataSource = context.TacGia.Where(t => t.TenTacGia.Contains(s)).ToList<TacGium>();
            dataGridViewTacGia.Columns["MaTacGia"].Visible = false;
            dataGridViewTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dataGridViewTacGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewTacGia.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridViewTacGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridViewTacGia.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
        }
        private void bindGridByPhone(string s)
        {
            dataGridViewTacGia.Columns.Clear();
            dataGridViewTacGia.DataSource = context.TacGia.Where(t => t.SoDienThoai.Contains(s)).ToList<TacGium>();
            dataGridViewTacGia.Columns["MaTacGia"].Visible = false;
            dataGridViewTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dataGridViewTacGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewTacGia.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridViewTacGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridViewTacGia.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
        }
        private void bindGridByEmail(string s)
        {
            dataGridViewTacGia.Columns.Clear();
            dataGridViewTacGia.DataSource = context.TacGia.Where(t => t.Email.Equals(s)).ToList<TacGium>();
            dataGridViewTacGia.Columns["MaTacGia"].Visible = false;
            dataGridViewTacGia.Columns["TenTacGia"].HeaderText = "Tên Tác Giả";
            dataGridViewTacGia.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewTacGia.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridViewTacGia.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridViewTacGia.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btTimKiemTacGia_Click(object sender, EventArgs e)
        {
            string timkiem = txtTimKiemTacGia.Text;
            if(timkiem.Equals("") || timkiem == null)
            {
                bindGrid();
                return;
            }
            else
            {
                if (rbtEmail.Checked)
                {
                    bindGridByEmail(timkiem);
                    return;
                }
                else if (rbtSoDienThoai.Checked)
                {
                    bindGridByPhone(timkiem);
                    return;
                }
                else
                {
                    bindGridByName(timkiem);
                    return;
                }
            }
        }
        private void dataGridViewTacGia_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maTacGia = (int)dataGridViewTacGia.Rows[e.RowIndex].Cells["MaTacGia"].Value;
            string tenTacGia = (string)dataGridViewTacGia.Rows[e.RowIndex].Cells["TenTacGia"].Value;
            txtTenTacGia.Text = tenTacGia;
            DateTime ngaySinh = (DateTime)dataGridViewTacGia.Rows[e.RowIndex].Cells["NgaySinh"].Value;
            dtNgaySinh.Value = ngaySinh;
            bool gioiTinh = (bool)dataGridViewTacGia.Rows[e.RowIndex].Cells["GioiTinh"].Value;
            if (gioiTinh)
            {
                rbtNam.Checked = true;
            }
            else
            {
                rbtNu.Checked = true;
            }
            string diaChi = (string)dataGridViewTacGia.Rows[e.RowIndex].Cells["DiaChi"].Value;
            txtDiaChi.Text = diaChi;
            string soDienThoai = (string)dataGridViewTacGia.Rows[e.RowIndex].Cells["SoDienThoai"].Value;
            txtSoDienThoai.Text = soDienThoai;
            string email = (string)dataGridViewTacGia.Rows[e.RowIndex].Cells["Email"].Value;
            txtEmail.Text = email;
        }

        private void btThemTacGia_Click(object sender, EventArgs e)
        {
            string tenTacGia = txtTenTacGia.Text;
            bool gioiTinh = true;
            if(rbtNu.Checked == true)
            {
                gioiTinh = false;
            }
            DateTime ngaySinh = dtNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string email = txtEmail.Text;
            List<TacGium> list = context.TacGia.ToList<TacGium>();
            foreach (TacGium tg in list)
            {
                if (soDienThoai.Equals(tg.SoDienThoai))
                {
                    MessageBox.Show("Không thể trùng số điện thoại. Thêm tác giả thất bạt");
                    return;
                }
            }
            if (tenTacGia == null)
            {
                MessageBox.Show("Thêm tác giả thất bại.");
                return;
            }
            else
            {
                TacGium tacGium = new TacGium();
                tacGium.TenTacGia = tenTacGia;
                tacGium.GioiTinh = gioiTinh;
                tacGium.NgaySinh = ngaySinh;
                tacGium.DiaChi = diaChi;
                tacGium.SoDienThoai = soDienThoai;
                tacGium.Email = email;
                context.Add(tacGium);
                context.SaveChanges();
                bindGrid();
            }
        }

        private void btSuaTacGia_Click(object sender, EventArgs e)
        {
            TacGium tacGium = context.TacGia.Find((int)maTacGia);
            string tenTacGia = txtTenTacGia.Text;
            bool gioiTinh = true;
            if (rbtNu.Checked == true)
            {
                gioiTinh = false;
            }
            DateTime ngaySinh = dtNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string email = txtEmail.Text;
            List<TacGium> list = context.TacGia.Where(tg => tg.MaTacGia != maTacGia).ToList<TacGium>();
            foreach (TacGium tg in list)
            {
                if (soDienThoai.Equals(tg.SoDienThoai))
                {
                    MessageBox.Show("Không thể trùng số điện thoại. Sửa tác giả thất bạt");
                    return;
                }
            }
            if (tenTacGia == null)
            {
                MessageBox.Show("Sửa tác giả thất bại.");
                return;
            }
            else
            {
                MessageBox.Show("Đã sửa tác giả " + tacGium.TenTacGia);
                tacGium.TenTacGia = tenTacGia;
                tacGium.GioiTinh = gioiTinh;
                tacGium.NgaySinh = ngaySinh;
                tacGium.DiaChi = diaChi;
                tacGium.SoDienThoai = soDienThoai;
                tacGium.Email = email;
                context.TacGia.Update(tacGium);
                context.SaveChanges();
                bindGrid();
            }
        }

        private void btXoaTacGia_Click(object sender, EventArgs e)
        {
            TacGium tacGium = context.TacGia.Find((int)maTacGia);
            List<Sach> sachCuaTacGia = context.Saches.Where(s => s.MaTacGia == maTacGia).ToList<Sach>();
            List<MuonTraSachChiTiet> muonTraSachChiTiet = new List<MuonTraSachChiTiet>();
            foreach (Sach s in sachCuaTacGia)
            {
                List<MuonTraSachChiTiet> muonTraSachChiTietCuaTungSach = context.MuonTraSachChiTiets.Where(m => m.MaSach == s.MaSach).ToList<MuonTraSachChiTiet>();
                foreach (MuonTraSachChiTiet mtsct in muonTraSachChiTietCuaTungSach)
                {
                    muonTraSachChiTiet.Add(mtsct);
                }
            }
            List<MuonTraSach> muonTraSach = new List<MuonTraSach>();
            foreach (MuonTraSachChiTiet m in muonTraSachChiTiet)
            {
                List<MuonTraSach> muonTraSachCuaTungMuonTraSachChiTiet = context.MuonTraSaches.Where(mt => mt.MaMuonTraSach == m.MaMuonTraSach).ToList<MuonTraSach>();
                foreach (MuonTraSach mts in muonTraSachCuaTungMuonTraSachChiTiet)
                {
                    muonTraSach.Add(mts);
                }
            }
            DialogResult h = MessageBox.Show("Bạn có chắc chắn muốn xóa tác giả " + tacGium.TenTacGia + " ra khỏi thư viện không? Nếu xóa thì các dữ liệu liên quan đến tác giả này sẽ biến mất", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                foreach (MuonTraSach mts in muonTraSach)
                {
                    context.MuonTraSaches.Remove(mts);
                }
                foreach (MuonTraSachChiTiet mtsct in muonTraSachChiTiet)
                {
                    context.MuonTraSachChiTiets.Remove(mtsct);
                }
                foreach (Sach s in sachCuaTacGia)
                {
                    context.Saches.Remove(s);
                }
                MessageBox.Show("Xóa tác giả thành công!");
                context.TacGia.Remove(tacGium);
                context.SaveChanges();
                bindGrid();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.Hide();
                Form f = new Main();
                f.Show();
            }
        }
    }
}

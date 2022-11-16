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
    public partial class QuanLyLoaiSach : Form
    {
        int? maLoaiSach;
        quanlythuvienContext context;
        public QuanLyLoaiSach()
        {
            InitializeComponent();
            context = new quanlythuvienContext();
            bindGrid();
            dataGridViewLoaiSach.Columns["TenLoaiSach"].HeaderText = "Loại Sách";
        }

        private void bindGrid()
        {
            dataGridViewLoaiSach.Columns.Clear();
            dataGridViewLoaiSach.DataSource = context.LoaiSaches.ToList<LoaiSach>();
            //dataGridViewLoaiSach.Columns["LoaiSaches"].Visible = false;
            dataGridViewLoaiSach.Columns["MaLoaiSach"].Visible = false;
        }
        private void bindGridByName(string loaiSach)
        {
            dataGridViewLoaiSach.Columns.Clear();
            dataGridViewLoaiSach.DataSource = context.LoaiSaches.Where(l => l.TenLoaiSach.Contains(loaiSach)).ToList<LoaiSach>();
            dataGridViewLoaiSach.Columns["MaLoaiSach"].Visible = false;
        }

        private void dataGridViewLoaiSach_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maLoaiSach = (int)dataGridViewLoaiSach.Rows[e.RowIndex].Cells["MaLoaiSach"].Value;
            string loaiSach = (string)dataGridViewLoaiSach.Rows[e.RowIndex].Cells["TenLoaiSach"].Value;
            txtTenLoaiSach.Text = loaiSach;
        }

        private void btTimKiemLoaiSach_Click(object sender, EventArgs e)
        {
            string loaisach = txtTimKiemLoaiSach.Text;
            if(loaisach.Equals("") || loaisach == null)
            {
                bindGrid();
                return;
            }
            else
            {
                bindGridByName(loaisach);
            }
        }

        private void btThemLoaiSach_Click(object sender, EventArgs e)
        {
            string tenLoaiSach = txtTenLoaiSach.Text;
            List<LoaiSach> s = context.LoaiSaches.ToList<LoaiSach>();
            foreach (LoaiSach l in s)
            {
                if (tenLoaiSach.Equals(l.TenLoaiSach))
                {
                    MessageBox.Show("Xin lỗi không thêm loại sách được. Vì đã tồn tại tên loại sách này");
                    return;
                }
            }
                if (tenLoaiSach.Equals("") || tenLoaiSach == null)
            {
                MessageBox.Show("Thêm loại sách thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Thêm loại sách "+tenLoaiSach+" thành công vào trong thư viện.");
                LoaiSach loaisach = new LoaiSach();
                        loaisach.TenLoaiSach = tenLoaiSach;
                        context.Add(loaisach);
                        context.SaveChanges();
                        bindGrid();
                }

            
        }

        private void btSuaLoaiSach_Click(object sender, EventArgs e)
        {
            LoaiSach loaiSach = context.LoaiSaches.Find((int)maLoaiSach);
            string tenLoaiSach = txtTenLoaiSach.Text;
            List<LoaiSach> s = context.LoaiSaches.ToList<LoaiSach>();
            foreach (LoaiSach l in s)
            {
                if (tenLoaiSach.Equals(l.TenLoaiSach))
                {
                    MessageBox.Show("Xin lỗi không sửa được loại sách này. Vì đã có loại sách này trong thư viện");
                    return;
                }
            }
            if (tenLoaiSach.Equals("") || tenLoaiSach == null)
            {
                MessageBox.Show("Sửa loại sách thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Đã sửa "+loaiSach.TenLoaiSach+" thành "+tenLoaiSach);
                loaiSach.TenLoaiSach = tenLoaiSach;
                context.LoaiSaches.Update(loaiSach);
                context.SaveChanges();
                bindGrid();
            }
        }

        private void btXoaLoaiSach_Click(object sender, EventArgs e)
        {
            LoaiSach loaiSach = context.LoaiSaches.Find((int)maLoaiSach);
            List<Sach> sachCuaLoaiSach = context.Saches.Where(s => s.MaLoaiSach == maLoaiSach).ToList<Sach>();
            List<MuonTraSachChiTiet> muonTraSachChiTiet = new List<MuonTraSachChiTiet>();
            foreach(Sach s in sachCuaLoaiSach)
            {
                List<MuonTraSachChiTiet> muonTraSachChiTietCuaTungSach = context.MuonTraSachChiTiets.Where(m => m.MaSach == s.MaSach).ToList<MuonTraSachChiTiet>();
                foreach(MuonTraSachChiTiet mtsct in muonTraSachChiTietCuaTungSach)
                {
                    muonTraSachChiTiet.Add(mtsct);
                }
            }
            List<MuonTraSach> muonTraSach = new List<MuonTraSach>();
            foreach(MuonTraSachChiTiet m in muonTraSachChiTiet)
            {
                List<MuonTraSach> muonTraSachCuaTungMuonTraSachChiTiet = context.MuonTraSaches.Where(mt => mt.MaMuonTraSach == m.MaMuonTraSach).ToList<MuonTraSach>();
                foreach(MuonTraSach mts in muonTraSachCuaTungMuonTraSachChiTiet)
                {
                    muonTraSach.Add(mts);
                }
            }
            DialogResult h = MessageBox.Show("Bạn có chắc chắn muốn xóa " + loaiSach.TenLoaiSach + " ra khỏi thư viện không? Nếu xóa thì các dữ liệu liên quan đến loại sách này sẽ biến mất", "Error", MessageBoxButtons.OKCancel);
            if(h == DialogResult.OK)
            {
                foreach(MuonTraSach mts in muonTraSach)
                {
                    context.MuonTraSaches.Remove(mts);
                }
                foreach(MuonTraSachChiTiet mtsct in muonTraSachChiTiet)
                {
                    context.MuonTraSachChiTiets.Remove(mtsct);
                }
                foreach(Sach s in sachCuaLoaiSach)
                {
                    context.Saches.Remove(s);
                }
                context.LoaiSaches.Remove(loaiSach);
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

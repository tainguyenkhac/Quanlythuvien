using Microsoft.EntityFrameworkCore;
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
    public partial class QuanLyMuonTraSach : Form
    {
        int maMuonTraSach = 0;
        quanlythuvienContext context;
        public QuanLyMuonTraSach()
        {
            InitializeComponent();
            context = new quanlythuvienContext();
            bindGrid();
        }

        void bindGrid()
        {

            var se= (from d in context.DocGia
                           join m in context.MuonTraSaches on d.MaDocGia equals m.MaDocGia
                           select new {m.MaMuonTraSach, d.HoTen, d.NgaySinh, d.GioiTinh, d.DiaChi, d.SoDienThoai, m.NgayMuon, m.TrangThai, m.Note }).ToList();
            
            dataGridView1.DataSource = se;
            dataGridView1.Columns["MaMuonTraSach"].Visible = false;
            dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            dataGridView1.Columns["TrangThai"].HeaderText = "Trạng Thái Trả Hết Sách";
            dataGridView1.Columns["Note"].HeaderText = "Ghi Chú";
        }

        void bindGridByName(string hoTen)
        {
            var se = (from d in context.DocGia
                      join m in context.MuonTraSaches on d.MaDocGia equals m.MaDocGia
                      where d.HoTen == hoTen
                      select new {m.MaMuonTraSach, d.HoTen, d.NgaySinh, d.GioiTinh, d.DiaChi, d.SoDienThoai, m.NgayMuon, m.TrangThai, m.Note }).ToList();

            dataGridView1.DataSource = se;
            dataGridView1.Columns["MaMuonTraSach"].Visible = false;
            dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            dataGridView1.Columns["TrangThai"].HeaderText = "Trạng Thái Trả Hết Sách";
            dataGridView1.Columns["Note"].HeaderText = "Ghi Chú";
        }
        void bindGridByBook(string hoTen)
        {
            dataGridView1.Columns.Clear();

            var se = (from d in context.DocGia
                      join m in context.MuonTraSaches on d.MaDocGia equals m.MaDocGia
                      where m.TrangThai == false
                      where d.HoTen.Contains(hoTen)
                      select new {m.MaMuonTraSach, d.HoTen, d.NgaySinh, d.GioiTinh, d.DiaChi, d.SoDienThoai, m.NgayMuon, m.TrangThai, m.Note }).ToList();

            dataGridView1.DataSource = se;
            dataGridView1.Columns["MaMuonTraSach"].Visible = false;
            dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            dataGridView1.Columns["TrangThai"].HeaderText = "Trạng Thái Trả Hết Sách";
            dataGridView1.Columns["Note"].HeaderText = "Ghi Chú";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.Hide();
                Form f = new Main();
                f.Show();
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string noiDungTimKiem = textBox1.Text;
            if (noiDungTimKiem == "" && radioButton1.Checked == false)
            {
                bindGrid();
                return;
            }

            if (radioButton1.Checked)
            {
                bindGridByBook(noiDungTimKiem);
            }
            else
            {
                bindGridByName(noiDungTimKiem);
            }
        }


        public class thongtin
        {
            static public string ten;
            static public int maMuonTraSach; 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            thongtin.ten = textBox1.Text;
            Form f = new XemChiTietMuonSach(maMuonTraSach);
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new ThemMuonSach();
            this.Hide();
            f.Show();
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            this.maMuonTraSach = (int)dataGridView1.Rows[e.RowIndex].Cells["MaMuonTraSach"].Value;

        }
    }
}

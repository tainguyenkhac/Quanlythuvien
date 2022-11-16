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
    public partial class ThemMuonSach : Form
    {
        public ThemMuonSach()
        {
            InitializeComponent();
        }
        quanlythuvienContext context = new quanlythuvienContext();
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.Hide();
                Form f = new QuanLyMuonTraSach();
                f.Show();
            }
        }

        private void ThemMuonSach_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {

            comboBox1.DataSource = context.DocGia.ToList();
            comboBox1.DisplayMember = "HoTen";
            comboBox1.ValueMember = "MaDocGia";

            checkedListBox1.DataSource = context.Saches.ToList();
            checkedListBox1.DisplayMember = "TenSach";
            checkedListBox1.ValueMember = "MaSach";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Thông tin người dùng không hợp lệ");
                return;
            }    
            if(checkedListBox1.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Thông tin sách không hợp lệ");
                return;
            }

            MuonTraSach muonTraSach = new MuonTraSach();
            int maDocGia = (int)comboBox1.SelectedValue;
            bool trangThai = false;
            string note = textBox1.Text;
            muonTraSach.MaDocGia = maDocGia;
            muonTraSach.NgayMuon = DateTime.Now.Date;
            muonTraSach.TrangThai = trangThai;
            muonTraSach.Note = note;
            context.MuonTraSaches.Add(muonTraSach);
            context.SaveChanges();
            foreach (Sach s in checkedListBox1.CheckedItems) 
            {           
                MuonTraSachChiTiet muonTraSachChiTiet = new MuonTraSachChiTiet();
                int maMuonTraSach = muonTraSach.MaMuonTraSach;
                int maSach = (int)s.MaSach;
                DateTime ngayHenTra = dateTimePicker1.Value;
                DateTime? ngayTra = null;

                muonTraSachChiTiet.MaMuonTraSach = maMuonTraSach;
                muonTraSachChiTiet.MaSach = maSach;
                muonTraSachChiTiet.NgayHenTra = ngayHenTra;
                muonTraSachChiTiet.NgayTra = ngayTra;

                context.MuonTraSachChiTiets.Add(muonTraSachChiTiet);
                context.SaveChanges();

            }
            
            MessageBox.Show("Thêm thành công");
        }
    }
}

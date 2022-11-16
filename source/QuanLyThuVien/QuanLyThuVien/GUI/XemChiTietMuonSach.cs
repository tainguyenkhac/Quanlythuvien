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
    public partial class XemChiTietMuonSach : Form
    {
        quanlythuvienContext context;
        int maMuonTraSach;
        public XemChiTietMuonSach(int maMuonTraSach)
        {
            InitializeComponent();
            this.maMuonTraSach = maMuonTraSach;
            context = new quanlythuvienContext();
            bindGrid();
        }


        void bindGrid()
        {
            dataGridView1.Columns.Clear();
            //dataGridView1.DataSource = context.MuonTraSachChiTiets.ToList<MuonTraSachChiTiet>();
            //dataGridView1.Columns["MaMuonTraSach"].Visible = false;
            //dataGridView1.Columns["MaMuonTraSachChiTiet"].Visible = false;
            var se = (from l in context.DocGia
                      join s in context.MuonTraSaches on l.MaDocGia equals s.MaDocGia
                      join m in context.MuonTraSachChiTiets on s.MaMuonTraSach equals m.MaMuonTraSach
                      join k in context.Saches on m.MaSach equals k.MaSach
                      where s.MaMuonTraSach == maMuonTraSach 
            
                      select new {k.MaSach, k.TenSach, k.TrangThai,s.MaMuonTraSach, s.NgayMuon ,m.NgayHenTra, m.NgayTra }).ToList();

            dataGridView1.DataSource = se;
            DataGridViewButtonColumn btnTraSach = new DataGridViewButtonColumn
            {
                Name = "TraSach",
                Text = "TraSach",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Insert(dataGridView1.Columns.Count, btnTraSach);
            dataGridView1.Columns["MaSach"].Visible = false;
            dataGridView1.Columns["TenSach"].HeaderText = "Tên Sách";
            dataGridView1.Columns["TrangThai"].Visible = false;
            dataGridView1.Columns["MaMuonTraSach"].Visible = false;
            dataGridView1.Columns["NgayMuon"].HeaderText = "Ngày Mượn";
            dataGridView1.Columns["NgayHenTra"].HeaderText = "Ngày Hẹn Trả";
            dataGridView1.Columns["NgayTra"].HeaderText = "Ngày Trả";
            dataGridView1.Columns["TraSach"].HeaderText = "Thao Tác";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.Hide();
                Form f = new QuanLyMuonTraSach();
                f.Show();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void XemChiTietMuonSach_Load(object sender, EventArgs e)
        {
            label4.Text = QuanLyMuonTraSach.thongtin.ten;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns["TraSach"].Index)
            {
                int maSach = (int) dataGridView1.Rows[e.RowIndex].Cells["MaSach"].Value;
                int maMuonTraSach = (int)dataGridView1.Rows[e.RowIndex].Cells["MaMuonTraSach"].Value;
                Sach sach = context.Saches.Find(maSach);
                MuonTraSach muonTraSach = context.MuonTraSaches.Find(maMuonTraSach);
                sach.TrangThai = false;
                context.Saches.Update(sach);
                List<MuonTraSachChiTiet> listMuonTraSachChiTiet = context.MuonTraSachChiTiets.Where(m => m.MaMuonTraSach == maMuonTraSach).ToList();
                for (int i = 0; i < listMuonTraSachChiTiet.Count; i++)
                {
                    if (listMuonTraSachChiTiet[i].MaSach == maSach)
                    {
                        MuonTraSachChiTiet muonTraSachChiTiet = context.MuonTraSachChiTiets.Find(listMuonTraSachChiTiet[i].MaMuonTraSachChiTiet);
                        muonTraSachChiTiet.NgayTra = DateTime.Now.Date;
                        context.MuonTraSachChiTiets.Update(muonTraSachChiTiet);

                    }
                }
                
                muonTraSach.TrangThai = true;
                for (int i = 0; i < listMuonTraSachChiTiet.Count; i++)
                {
                    if (listMuonTraSachChiTiet[i].NgayTra == null)
                    {
                        muonTraSach.TrangThai = false;
                        break;
                    }
                }
                context.MuonTraSaches.Update(muonTraSach);
                context.SaveChanges();
                MessageBox.Show($"Trả sách {sach.TenSach} thành công!");
                bindGrid();
            }
        }
    }
}

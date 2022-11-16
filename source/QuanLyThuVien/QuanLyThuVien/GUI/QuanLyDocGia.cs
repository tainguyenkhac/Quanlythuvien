using QuanLyThuVien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.GUI
{
    public partial class QuanLyDocGia : Form
    {
        int? maDocGia;
        bool filterByName = false;
        bool filterByPhone = true;
        quanlythuvienContext context;
        public QuanLyDocGia()
        {
            InitializeComponent();
            context = new quanlythuvienContext();
            bindGrid();
            dataGridView1.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính (Nam)";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
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
        void bindGrid()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = context.DocGia.ToList<DocGium>();
            dataGridView1.Columns["MuonTraSaches"].Visible = false;
            dataGridView1.Columns["MaDocGia"].Visible = false;
        }
        void bindGridByName(string hoTen)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = context.DocGia.Where(d => d.HoTen == hoTen).ToList<DocGium>();
            dataGridView1.Columns["MuonTraSaches"].Visible = false;
            dataGridView1.Columns["MaDocGia"].Visible = false;
        }
        void bindGridByPhone(string soDienThoai)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = context.DocGia.Where(d => d.SoDienThoai.Contains(soDienThoai)).ToList<DocGium>();
            dataGridView1.Columns["MuonTraSaches"].Visible = false;
            dataGridView1.Columns["MaDocGia"].Visible = false;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            maDocGia = (int)dataGridView1.Rows[e.RowIndex].Cells["MaDocGia"].Value;
            string hoTen = (string)dataGridView1.Rows[e.RowIndex].Cells["HoTen"].Value;
            txtHoTen.Text = hoTen;
            bool gioiTinh = (bool)dataGridView1.Rows[e.RowIndex].Cells["GioiTinh"].Value;
            if (gioiTinh)
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            DateTime ngaySinh = (DateTime)dataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].Value;
            dtpNgaySinh.Value = ngaySinh.Date;
            string diaChi = (string)dataGridView1.Rows[e.RowIndex].Cells["DiaChi"].Value;
            txtDiaChi.Text = diaChi;
            string soDienThoai = (string)dataGridView1.Rows[e.RowIndex].Cells["SoDienThoai"].Value;
            txtSoDienThoai.Text = soDienThoai;
            string email = (string)dataGridView1.Rows[e.RowIndex].Cells["Email"].Value;
            txtEmail.Text = email;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (errorDiaChi.GetError(this.txtDiaChi) != "" || 
                errorHoTen.GetError(this.txtHoTen) != "" || 
                errorNgaySinh.GetError(this.dtpNgaySinh) != "" || 
                errorSoDienThoai.GetError(this.txtSoDienThoai) != "" || 
                errorEmail.GetError(this.txtEmail) != "")
            {
                MessageBox.Show("Thông tin độc giả không hợp lệ");
                return;
            }
            DocGium docGia = new DocGium();
            string hoTen = txtHoTen.Text;
            bool gioiTinh = true;
            if (rbtnNu.Checked)
            {
                gioiTinh = false;
            }
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string email = txtEmail.Text;
            docGia.HoTen = hoTen;
            docGia.GioiTinh = gioiTinh;
            docGia.NgaySinh = ngaySinh;
            docGia.DiaChi = diaChi;
            docGia.SoDienThoai = soDienThoai;
            docGia.Email = email;
            context.DocGia.Add(docGia);
            context.SaveChanges();
            bindGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (errorDiaChi.GetError(this.txtDiaChi) != "" ||
            errorHoTen.GetError(this.txtHoTen) != "" ||
            errorNgaySinh.GetError(this.dtpNgaySinh) != "" ||
            errorSoDienThoai.GetError(this.txtSoDienThoai) != "" ||
            errorEmail.GetError(this.txtEmail) != "")
            {
                MessageBox.Show("Thông tin độc giả không hợp lệ");
                return;
            }
            DocGium docGia = context.DocGia.Find((int)maDocGia);
            string hoTen = txtHoTen.Text;
            bool gioiTinh = true;
            if (rbtnNu.Checked)
            {
                gioiTinh = false;
            }
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string email = txtEmail.Text;
            docGia.HoTen = hoTen;
            docGia.GioiTinh = gioiTinh;
            docGia.NgaySinh = ngaySinh;
            docGia.DiaChi = diaChi;
            docGia.SoDienThoai = soDienThoai;
            docGia.Email = email;
            context.DocGia.Update(docGia);
            context.SaveChanges();
            bindGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DocGium docGia = context.DocGia.Find((int)maDocGia);
            context.DocGia.Remove(docGia);
            context.SaveChanges();
            bindGrid();
        }

        private void btnThucHienTim_Click(object sender, EventArgs e)
        {
            string noiDungTimKiem = txtNoiDungTimKiem.Text;
            if (noiDungTimKiem == "")
            {
                bindGrid();
                return;
            }

            if (rbtnSoDienThoai.Checked)
            {
                bindGridByPhone(noiDungTimKiem);
            } else
            {
                bindGridByName(noiDungTimKiem);
            }
        }

        private void txtHoTen_Leave(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "")
            {
                errorHoTen.Clear();
            } else
            {
                errorHoTen.SetError(this.txtHoTen, "Tên không được để trống!");
            }
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text != "")
            {
                errorDiaChi.Clear();
            }
            else
            {
                errorDiaChi.SetError(this.txtDiaChi, "Địa chỉ không được để trống!");
            }
        }

        private void txtSoDienThoai_Leave(object sender, EventArgs e)
        {
            if (txtSoDienThoai.Text != "")
            {
                errorSoDienThoai.Clear();
            }
            else
            {
                errorSoDienThoai.SetError(this.txtSoDienThoai, "Số điện thoại không được để trống!");
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {

                string pattern = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$$";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    errorEmail.Clear();
                } else
                {
                    errorEmail.SetError(this.txtEmail, "Email không hợp lệ!");
                }
            }
        }

        private void dtpNgaySinh_Leave(object sender, EventArgs e)
        {
            if (dtpNgaySinh.Value <= DateTime.Now.Date)
            {
                errorNgaySinh.Clear();
            } else
            {
                errorNgaySinh.SetError(this.dtpNgaySinh, "Ngày sinh không được lớn hơn hiện tại!");
            }
        }
    }
}

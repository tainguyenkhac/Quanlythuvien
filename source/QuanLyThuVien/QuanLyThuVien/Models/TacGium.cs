using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyThuVien.Models
{
    public partial class TacGium
    {
        public TacGium()
        {
            Saches = new HashSet<Sach>();
        }

        public int MaTacGia { get; set; }
        public string TenTacGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}

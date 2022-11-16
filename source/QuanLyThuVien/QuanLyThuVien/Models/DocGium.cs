using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyThuVien.Models
{
    public partial class DocGium
    {
        public DocGium()
        {
            MuonTraSaches = new HashSet<MuonTraSach>();
        }

        public int MaDocGia { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }

        public virtual ICollection<MuonTraSach> MuonTraSaches { get; set; }
    }
}

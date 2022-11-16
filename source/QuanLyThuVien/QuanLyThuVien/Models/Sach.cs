using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyThuVien.Models
{
    public partial class Sach
    {
        public Sach()
        {
            MuonTraSachChiTiets = new HashSet<MuonTraSachChiTiet>();
        }

        public int MaSach { get; set; }
        public int MaLoaiSach { get; set; }
        public int MaTacGia { get; set; }
        public string TenSach { get; set; }
        public bool TrangThai { get; set; }

        public virtual LoaiSach MaLoaiSachNavigation { get; set; }
        public virtual TacGium MaTacGiaNavigation { get; set; }
        public virtual ICollection<MuonTraSachChiTiet> MuonTraSachChiTiets { get; set; }
    }
}

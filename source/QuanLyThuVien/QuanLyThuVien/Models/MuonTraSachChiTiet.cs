using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyThuVien.Models
{
    public partial class MuonTraSachChiTiet
    {
        public int MaMuonTraSachChiTiet { get; set; }
        public int MaMuonTraSach { get; set; }
        public int MaSach { get; set; }
        public DateTime NgayHenTra { get; set; }
        public DateTime? NgayTra { get; set; }

        public virtual MuonTraSach MaMuonTraSachNavigation { get; set; }
        public virtual Sach MaSachNavigation { get; set; }
    }
}

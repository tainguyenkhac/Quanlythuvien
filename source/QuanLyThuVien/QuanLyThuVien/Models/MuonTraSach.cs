using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyThuVien.Models
{
    public partial class MuonTraSach
    {
        public MuonTraSach()
        {
            MuonTraSachChiTiets = new HashSet<MuonTraSachChiTiet>();
        }

        public int MaMuonTraSach { get; set; }
        public int MaDocGia { get; set; }
        public DateTime NgayMuon { get; set; }
        public string Note { get; set; }
        public bool TrangThai { get; set; }

        public virtual DocGium MaDocGiaNavigation { get; set; }
        public virtual ICollection<MuonTraSachChiTiet> MuonTraSachChiTiets { get; set; }
    }
}

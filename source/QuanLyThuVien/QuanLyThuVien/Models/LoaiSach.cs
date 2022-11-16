using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyThuVien.Models
{
    public partial class LoaiSach
    {
        public LoaiSach()
        {
            Saches = new HashSet<Sach>();
        }

        public int MaLoaiSach { get; set; }
        public string TenLoaiSach { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
    }
}

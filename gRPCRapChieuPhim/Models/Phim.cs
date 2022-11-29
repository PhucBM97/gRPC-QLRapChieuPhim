using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace gRPCRapChieuPhim.Models
{
    public partial class Phim
    {
        public Phim()
        {
            LichChieus = new HashSet<LichChieu>();
        }

        public int Id { get; set; }
        public string TenPhim { get; set; }
        public string TenGoc { get; set; }
        public int ThoiLuong { get; set; }
        public string DaoDien { get; set; }
        public string DienVien { get; set; }
        public DateTime? NgayKhoiChieu { get; set; }
        public string NoiDung { get; set; }
        public string NuocSanXuat { get; set; }
        public string NhaSanXuat { get; set; }
        public string Poster { get; set; }
        public string DanhSachTheLoaiId { get; set; }
        public string NgonNgu { get; set; }
        public int? XepHangPhimId { get; set; }
        public string Trailer { get; set; }

        [NotMapped]
        public virtual TheLoaiPhim TheLoaiPhim { get; set; }
        public virtual XepHangPhim XepHangPhim { get; set; }
        public virtual ICollection<LichChieu> LichChieus { get; set; }
    }
}

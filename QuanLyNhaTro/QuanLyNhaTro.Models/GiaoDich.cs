using System;

namespace QuanLyNhaTro.Models
{
    public class GiaoDich
    {
        public int MaGiaoDich { get; set; }
        public DateTime ThoiGian { get; set; }
        public string LoaiGiaoDich { get; set; }
        public string HangMuc { get; set; }
        public decimal SoTien { get; set; }
        public string TrangThai { get; set; }
        public int? MaPhieuThu { get; set; }
        public int? MaPhieuChi { get; set; }

        // Navigation Properties
        public virtual PhieuThu PhieuThu { get; set; }
        public virtual PhieuChi PhieuChi { get; set; }
    }
}

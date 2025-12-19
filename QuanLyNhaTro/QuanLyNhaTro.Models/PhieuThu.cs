using System;

namespace QuanLyNhaTro.Models
{
    public class PhieuThu
    {
        public int MaPhieuThu { get; set; }
        public int MaHD { get; set; }
        public decimal SoTien { get; set; }
        public DateTime NgayThu { get; set; }
        public string HinhThuc { get; set; }
        public string GhiChu { get; set; }

        // Navigation Property
        public virtual HoaDon HoaDon { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace QuanLyNhaTro.Models
{
    public class HoaDon
    {
        public int MaHD { get; set; }
        public int MaHopDong { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime HanThanhToan { get; set; }
        public double SoDienCu { get; set; }
        public double SoDienMoi { get; set; }
        public double SoNuocCu { get; set; }
        public double SoNuocMoi { get; set; }
        public decimal TongTien { get; set; }
        public decimal DaThanhToan { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }

        // Navigation Property
        public virtual HopDong HopDong { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<PhieuThu> PhieuThus { get; set; }

        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            PhieuThus = new HashSet<PhieuThu>();
        }
    }
}

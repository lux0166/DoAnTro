using System;

namespace QuanLyNhaTro.Models
{
    public class HoaDonDetailViewModel
    {
        public int MaHD { get; set; }
        public string TenPhong { get; set; }
        public string TenKhachThue { get; set; }
        public string MaHD_Thang { get; set; } // e.g., #HD-2310-01
        public string TrangThai { get; set; }

        // Utility Info
        public double SoDienCu { get; set; }
        public double SoDienMoi { get; set; }
        public decimal DonGiaDien { get; set; }
        public decimal ThanhTienDien { get; set; }

        public double SoNuocCu { get; set; }
        public double SoNuocMoi { get; set; }
        public decimal DonGiaNuoc { get; set; }
        public decimal ThanhTienNuoc { get; set; }

        // Invoice Summary
        public decimal TienPhong { get; set; }
        public decimal TienDienNuoc { get; set; }
        public decimal TienDichVuKhac { get; set; }
        public decimal TongCong { get; set; }
    }
}

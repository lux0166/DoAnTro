using System;

namespace QuanLyNhaTro.Models
{
    public class HoaDonViewModel
    {
        public int MaHD { get; set; }
        public string TenPhong { get; set; }
        public string TenKhachThue { get; set; }
        public decimal TongTienDienNuoc { get; set; }
        public decimal TongTien { get; set; }
        public DateTime HanThanhToan { get; set; }
        public string TrangThai { get; set; }
    }
}

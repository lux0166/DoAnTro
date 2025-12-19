using System;

namespace QuanLyNhaTro.Models
{
    public class HopDong
    {
        public int ID { get; set; }
        public string MaHopDong { get; set; }
        public int IDPhong { get; set; }
        public int IDKhachThue { get; set; }
        public decimal GiaThue { get; set; }
        public decimal TienCoc { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TrangThai { get; set; } // e.g., "Hiệu lực", "Sắp hết hạn", "Đã thanh lý"
    }
}

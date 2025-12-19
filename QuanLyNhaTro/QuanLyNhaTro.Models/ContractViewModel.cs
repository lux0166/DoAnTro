using System;

namespace QuanLyNhaTro.Models
{
    /// <summary>
    /// Represents a flattened view of a contract for display purposes,
    /// combining information from HopDong, Phong, and KhachThue.
    /// </summary>
    public class ContractViewModel
    {
        public int ID { get; set; } // HopDong ID
        public string MaHopDong { get; set; }
        public string TenPhong { get; set; }
        public string TenKhachThue { get; set; }
        public string SoDienThoai { get; set; }
        public decimal GiaThue { get; set; }
        public decimal TienCoc { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
    }
}

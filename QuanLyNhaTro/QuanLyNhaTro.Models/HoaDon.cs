using System;

namespace QuanLyNhaTro.Models
{
    public class HoaDon
    {
        public int ID { get; set; }
        public string MaHoaDon { get; set; }
        public int IDHopDong { get; set; }
        public DateTime NgayLap { get; set; }
        public DateTime HanThanhToan { get; set; }
        public decimal TongTien { get; set; }
        public decimal DaThanhToan { get; set; }
        public decimal ConNo { get; set; }
        public string TrangThai { get; set; } // e.g., "Chưa thanh toán", "Đã thanh toán", "Quá hạn"
        public string GhiChu { get; set; }
    }
}

using System;

namespace QuanLyNhaTro.Models
{
    public class KhachThue
    {
        public int ID { get; set; }
        public string HoTen { get; set; }
        public string CMND_CCCD { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string QueQuan { get; set; }
        public string TrangThai { get; set; } // e.g., "Đang thuê", "Đã trả phòng"
    }
}

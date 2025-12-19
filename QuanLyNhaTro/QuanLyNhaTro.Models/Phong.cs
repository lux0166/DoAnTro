namespace QuanLyNhaTro.Models
{
    public class Phong
    {
        public int ID { get; set; }
        public string TenPhong { get; set; }
        public int IDKhuNha { get; set; }
        public int IDLoaiPhong { get; set; }
        public double DienTich { get; set; }
        public decimal GiaThue { get; set; }
        public string TrangThai { get; set; } // e.g., "Trống", "Đang thuê", "Bảo trì"
        public string MoTa { get; set; }
    }
}

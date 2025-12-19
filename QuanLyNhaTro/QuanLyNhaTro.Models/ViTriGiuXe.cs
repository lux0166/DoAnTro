namespace QuanLyNhaTro.Models
{
    public class ViTriGiuXe
    {
        public int ID { get; set; }
        public string TenViTri { get; set; } // e.g., "A-01", "B-02"
        public string KhuVuc { get; set; }
        public string TrangThai { get; set; } // e.g., "Còn trống", "Đang sử dụng"
    }
}

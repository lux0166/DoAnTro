namespace QuanLyNhaTro.Models
{
    public class NguoiDung
    {
        public int ID { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; } // Should be hashed
        public string HoTen { get; set; }
        public string Quyen { get; set; } // e.g., "Admin", "QuanLy"
        public bool TrangThai { get; set; } // true: Active, false: Inactive
    }
}

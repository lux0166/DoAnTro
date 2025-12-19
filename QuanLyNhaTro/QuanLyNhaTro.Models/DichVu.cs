namespace QuanLyNhaTro.Models
{
    public class DichVu
    {
        public int ID { get; set; }
        public string TenDichVu { get; set; }
        public decimal DonGia { get; set; }
        public string DonViTinh { get; set; } // e.g., "kWh", "m3", "Tháng", "Người"
        public string LoaiTinhPhi { get; set; } // e.g., "Theo chỉ số", "Theo phòng", "Theo người"
        public bool TrangThai { get; set; } // true: Active, false: Inactive
    }
}

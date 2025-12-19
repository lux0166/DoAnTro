namespace QuanLyNhaTro.Models
{
    public class ChiTietHoaDon
    {
        public int ID { get; set; }
        public int IDHoaDon { get; set; }
        public int IDDichVu { get; set; }
        public int? SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }
    }
}

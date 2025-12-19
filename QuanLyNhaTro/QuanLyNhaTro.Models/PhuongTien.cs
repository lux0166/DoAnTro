using System;

namespace QuanLyNhaTro.Models
{
    public class PhuongTien
    {
        public int ID { get; set; }
        public string BienSo { get; set; }
        public int IDLoaiXe { get; set; }
        public int IDKhachThue { get; set; }
        public int? IDViTriGiuXe { get; set; }
        public string HieuXe { get; set; }
        public string MauXe { get; set; }
        public DateTime? NgayGui { get; set; }
    }
}

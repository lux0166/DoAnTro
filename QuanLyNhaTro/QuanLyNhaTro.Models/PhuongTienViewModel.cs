using System;

namespace QuanLyNhaTro.Models
{
    public class PhuongTienViewModel
    {
        public string ViTri { get; set; }
        public string BienSo { get; set; }
        public string LoaiXe { get; set; }
        public string HieuXe { get; set; }
        public string ChuXe { get; set; }
        public string Phong { get; set; }
        public DateTime NgayGui { get; set; }
        public string TrangThaiPhi { get; set; }
        public bool IsTrong { get; set; } // To identify if the spot is empty
    }
}

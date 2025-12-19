using QuanLyNhaTro.Core;
using QuanLyNhaTro.Data;
using QuanLyNhaTro.Models;
using System;
using System.Linq;

namespace QuanLyNhaTro.Presenters
{
    public class QuanLyHoaDonPresenter
    {
        private readonly IQuanLyHoaDonView _view;
        private readonly HoaDonRepository _hoaDonRepository;
        private readonly PhongRepository _phongRepository;
        private readonly KhachThueRepository _khachThueRepository;
        private readonly DichVuRepository _dichVuRepository;

        public QuanLyHoaDonPresenter(IQuanLyHoaDonView view, string connectionString)
        {
            _view = view;
            _hoaDonRepository = new HoaDonRepository(connectionString);
            _phongRepository = new PhongRepository(connectionString);
            _khachThueRepository = new KhachThueRepository(connectionString);
            _dichVuRepository = new DichVuRepository(connectionString);

            // Subscribe to view events
            _view.LoadHoaDons += OnLoadHoaDons;
            _view.SelectHoaDon += OnSelectHoaDon;
        }

        private void OnLoadHoaDons(object sender, EventArgs e)
        {
            try
            {
                var hoaDons = _hoaDonRepository.GetAll();

                var viewModel = hoaDons.Select(hd =>
                {
                    var hopDong = hd.HopDong; // HopDong is eager loaded
                    var phong = hopDong?.Phong;
                    var khachThue = hopDong?.KhachThue;

                    return new HoaDonViewModel
                    {
                        MaHD = hd.MaHD,
                        TenPhong = phong?.TenPhong ?? "N/A",
                        TenKhachThue = khachThue?.HoTen ?? "N/A",
                        TongTien = hd.TongTien,
                        HanThanhToan = hd.HanThanhToan,
                        TrangThai = hd.TrangThai
                    };
                }).ToList();

                _view.HoaDons = viewModel;
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Lỗi khi tải danh sách hóa đơn: {ex.Message}", "Lỗi", MessageType.Error);
            }
        }

        private void OnSelectHoaDon(object sender, EventArgs e)
        {
             try
            {
                int selectedId = _view.SelectedHoaDonId;
                if (selectedId <= 0) return;

                var hoaDon = _hoaDonRepository.GetById(selectedId);
                if (hoaDon == null)
                {
                    _view.ShowMessage("Không tìm thấy hóa đơn.", "Thông báo", MessageType.Warning);
                    return;
                }

                var hopDong = hoaDon.HopDong;
                var phong = hopDong?.Phong;
                var khachThue = hopDong?.KhachThue;

                // Fetch service prices
                var dien = _dichVuRepository.GetByName("Điện");
                var nuoc = _dichVuRepository.GetByName("Nước");

                decimal thanhTienDien = (decimal)(hoaDon.SoDienMoi - hoaDon.SoDienCu) * (dien?.DonGia ?? 0);
                decimal thanhTienNuoc = (decimal)(hoaDon.SoNuocMoi - hoaDon.SoNuocCu) * (nuoc?.DonGia ?? 0);

                var detailViewModel = new HoaDonDetailViewModel
                {
                    MaHD = hoaDon.MaHD,
                    TenPhong = phong?.TenPhong,
                    TenKhachThue = khachThue?.HoTen,
                    MaHD_Thang = $"#HD-{hoaDon.NgayLap.ToString("yyMM")}-{hoaDon.MaHD}",
                    TrangThai = hoaDon.TrangThai,

                    SoDienCu = hoaDon.SoDienCu,
                    SoDienMoi = hoaDon.SoDienMoi,
                    DonGiaDien = dien?.DonGia ?? 0,
                    ThanhTienDien = thanhTienDien,

                    SoNuocCu = hoaDon.SoNuocCu,
                    SoNuocMoi = hoaDon.SoNuocMoi,
                    DonGiaNuoc = nuoc?.DonGia ?? 0,
                    ThanhTienNuoc = thanhTienNuoc,

                    TienPhong = hopDong?.TienCoc ?? 0, // Placeholder, should be rent price
                    TienDienNuoc = thanhTienDien + thanhTienNuoc,
                    TienDichVuKhac = hoaDon.TongTien - (hopDong?.TienCoc ?? 0) - thanhTienDien - thanhTienNuoc, // Placeholder logic
                    TongCong = hoaDon.TongTien
                };

                _view.SelectedHoaDonDetail = detailViewModel;
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Lỗi khi tải chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageType.Error);
            }
        }
    }
}

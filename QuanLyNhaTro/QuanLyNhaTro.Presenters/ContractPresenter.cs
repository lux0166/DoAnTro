using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Data;
using System.Linq;

namespace QuanLyNhaTro.Presenters
{
    public class ContractPresenter
    {
        private readonly IContractView _view;
        private readonly HopDongRepository _hopDongRepository;
        private readonly KhuNhaRepository _khuNhaRepository;

        public ContractPresenter(IContractView view)
        {
            _view = view;
            _hopDongRepository = new HopDongRepository();
            _khuNhaRepository = new KhuNhaRepository();

            _view.FilterChanged += OnFilterChanged;
        }

        public void LoadInitialData()
        {
            _view.SetBuildingDataSource(_khuNhaRepository.GetAll());
            OnFilterChanged(this, System.EventArgs.Empty);
        }

        private void OnFilterChanged(object sender, System.EventArgs e)
        {
            var allContracts = _hopDongRepository.GetAllAsViewModel();
            var searchText = _view.GetSearchText()?.ToLower() ?? "";

            // In-memory filtering
            var filteredList = allContracts
                .Where(c => string.IsNullOrWhiteSpace(searchText) ||
                            c.TenKhachThue.ToLower().Contains(searchText) ||
                            c.TenPhong.ToLower().Contains(searchText) ||
                            c.MaHopDong.ToLower().Contains(searchText))
                // Note: Building filter requires a more complex query if done in SQL
                // For now, we assume building info could be part of the view model if needed
                .Where(c => _view.GetStatusFilter() == null || _view.GetStatusFilter() == "Tất cả trạng thái" || c.TrangThai == _view.GetStatusFilter())
                .Where(c => !_view.GetStartDateFilter().HasValue || c.NgayBatDau >= _view.GetStartDateFilter().Value)
                .Where(c => !_view.GetEndDateFilter().HasValue || c.NgayKetThuc <= _view.GetEndDateFilter().Value)
                .ToList();

            _view.SetContractDataSource(filteredList);
        }
    }
}

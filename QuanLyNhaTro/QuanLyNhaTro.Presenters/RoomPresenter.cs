using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Data;
using System.Linq;

namespace QuanLyNhaTro.Presenters
{
    public class RoomPresenter
    {
        private readonly IRoomView _view;
        private readonly PhongRepository _phongRepository;
        private readonly KhuNhaRepository _khuNhaRepository;
        private readonly LoaiPhongRepository _loaiPhongRepository;

        public RoomPresenter(IRoomView view)
        {
            _view = view;
            _phongRepository = new PhongRepository();
            _khuNhaRepository = new KhuNhaRepository();
            _loaiPhongRepository = new LoaiPhongRepository();

            // Subscribe to view events
            _view.SearchAndFilter += OnSearchAndFilter;
        }

        public void LoadInitialData()
        {
            // Load data for filters
            _view.SetBuildingDataSource(_khuNhaRepository.GetAll());
            _view.SetRoomTypeDataSource(_loaiPhongRepository.GetAll());

            // Load initial list of rooms
            OnSearchAndFilter(this, System.EventArgs.Empty);
        }

        private void OnSearchAndFilter(object sender, System.EventArgs e)
        {
            // Get all rooms
            var allRooms = _phongRepository.GetAll();

            // Apply filters (this is a simple in-memory filter, could be moved to SQL for performance)
            var filteredRooms = allRooms
                .Where(r => string.IsNullOrWhiteSpace(_view.GetSearchText()) || r.TenPhong.Contains(_view.GetSearchText()))
                .Where(r => _view.GetBuildingFilter() == null || (int)_view.GetBuildingFilter() == 0 || r.IDKhuNha == (int)_view.GetBuildingFilter())
                .Where(r => _view.GetRoomTypeFilter() == null || (int)_view.GetRoomTypeFilter() == 0 || r.IDLoaiPhong == (int)_view.GetRoomTypeFilter())
                .Where(r => _view.GetStatusFilter() == null || _view.GetStatusFilter().ToString() == "Tất cả" || r.TrangThai == _view.GetStatusFilter().ToString())
                .ToList();

            // Update the view
            _view.SetRoomDataSource(filteredRooms);
        }
    }
}

using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Data;
using System.Linq;

namespace QuanLyNhaTro.Presenters
{
    public class TenantPresenter
    {
        private readonly ITenantView _view;
        private readonly KhachThueRepository _tenantRepository;

        public TenantPresenter(ITenantView view)
        {
            _view = view;
            _tenantRepository = new KhachThueRepository();

            // Subscribe to view events
            _view.Search += OnSearch;
        }

        public void LoadInitialData()
        {
            // Load initial list of tenants
            OnSearch(this, System.EventArgs.Empty);
        }

        private void OnSearch(object sender, System.EventArgs e)
        {
            // Get all tenants
            var allTenants = _tenantRepository.GetAll();

            // Apply search filter (in-memory)
            var searchText = _view.GetSearchText();
            var filteredTenants = allTenants
                .Where(t => string.IsNullOrWhiteSpace(searchText) ||
                            t.HoTen.Contains(searchText) ||
                            t.SoDienThoai.Contains(searchText) ||
                            t.CMND_CCCD.Contains(searchText))
                .ToList();

            // Update the view
            _view.SetTenantDataSource(filteredTenants);
        }
    }
}

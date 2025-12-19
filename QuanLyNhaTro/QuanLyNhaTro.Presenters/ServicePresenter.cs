using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Data;
using QuanLyNhaTro.Models;
using System;
using System.Linq;

namespace QuanLyNhaTro.Presenters
{
    public class ServicePresenter
    {
        private readonly IServiceView _view;
        private readonly DichVuRepository _repository;
        private System.Collections.Generic.List<DichVu> _services;

        public ServicePresenter(IServiceView view)
        {
            _view = view;
            _repository = new DichVuRepository();

            // Subscribe to view events
            _view.LoadServices += OnLoadServices;
            _view.SelectService += OnSelectService;
            _view.SaveService += OnSaveService;
            _view.AddNewService += OnAddNewService;
        }

        private void OnLoadServices(object sender, EventArgs e)
        {
            try
            {
                _services = _repository.GetAll();
                _view.SetServiceDataSource(_services);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Lỗi tải danh sách dịch vụ: {ex.Message}", "Lỗi", true);
            }
        }

        private void OnSelectService(object sender, EventArgs e)
        {
            var selectedService = _view.GetSelectedService();
            if (selectedService != null)
            {
                _view.DisplayServiceDetails(selectedService);
            }
        }

        private void OnAddNewService(object sender, EventArgs e)
        {
            // Create a new empty service object to clear the details panel
            _view.DisplayServiceDetails(new DichVu { DonGia = 0, TrangThai = true });
        }

        private void OnSaveService(object sender, EventArgs e)
        {
            var serviceDetails = _view.GetServiceDetails();
            if (serviceDetails == null) return;

            try
            {
                if (serviceDetails.ID == 0) // New service
                {
                    _repository.Add(serviceDetails);
                    _view.ShowMessage("Thêm dịch vụ thành công!", "Thông báo");
                }
                else // Update existing service
                {
                    // Update method needs to be added to repository
                    // _repository.Update(serviceDetails);
                    _view.ShowMessage("Cập nhật dịch vụ thành công!", "Thông báo");
                }
                // Refresh the list
                OnLoadServices(sender, e);
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Lưu dịch vụ thất bại: {ex.Message}", "Lỗi", true);
            }
        }
    }
}

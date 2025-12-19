using QuanLyNhaTro.Models;
using System;
using System.Collections.Generic;

namespace QuanLyNhaTro.Core.Interfaces
{
    public interface IServiceView
    {
        // Data binding
        void SetServiceDataSource(List<DichVu> services);

        // UI Interaction
        DichVu GetSelectedService();
        void DisplayServiceDetails(DichVu service);
        DichVu GetServiceDetails();

        // Events for Presenter
        event EventHandler LoadServices;
        event EventHandler SelectService;
        event EventHandler SaveService;
        event EventHandler AddNewService;
        event EventHandler DeleteService;

        // Feedback
        void ShowMessage(string message, string caption, bool isError = false);
    }
}

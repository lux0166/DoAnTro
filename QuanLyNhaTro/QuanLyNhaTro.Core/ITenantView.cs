using QuanLyNhaTro.Models;
using System.Collections.Generic;

namespace QuanLyNhaTro.Core.Interfaces
{
    public interface ITenantView
    {
        // Data binding
        void SetTenantDataSource(List<KhachThue> tenants);

        // UI Interaction
        int? GetSelectedTenantId();
        string GetSearchText();

        // Events for Presenter
        event System.EventHandler Search;
        event System.EventHandler AddNewTenant;
        event System.EventHandler EditTenant;
        event System.EventHandler DeleteTenant;
    }
}

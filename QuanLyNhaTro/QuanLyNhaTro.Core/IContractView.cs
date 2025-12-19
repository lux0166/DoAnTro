using QuanLyNhaTro.Models;
using System;
using System.Collections.Generic;

namespace QuanLyNhaTro.Core.Interfaces
{
    public interface IContractView
    {
        // Data binding
        void SetContractDataSource(List<ContractViewModel> contracts);
        void SetBuildingDataSource(List<KhuNha> buildings);

        // UI Interaction for filtering
        string GetSearchText();
        object GetBuildingFilter();
        string GetStatusFilter();
        DateTime? GetStartDateFilter();
        DateTime? GetEndDateFilter();

        // Events for Presenter
        event EventHandler FilterChanged;
        event EventHandler AddNewContract;
        event EventHandler EditContract;
        event EventHandler DeleteContract;
    }
}

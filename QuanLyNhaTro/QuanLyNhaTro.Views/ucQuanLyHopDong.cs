using DevExpress.XtraEditors;
using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Models;
using QuanLyNhaTro.Presenters;
using System;
using System.Collections.Generic;

namespace QuanLyNhaTro.Views
{
    public partial class ucQuanLyHopDong : XtraUserControl, IContractView
    {
        private readonly ContractPresenter _presenter;

        public ucQuanLyHopDong()
        {
            InitializeComponent();
            _presenter = new ContractPresenter(this);
            this.Load += (sender, e) => _presenter.LoadInitialData();

            // Attach event handlers
            txtSearch.KeyDown += (s, e) => {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    FilterChanged?.Invoke(this, EventArgs.Empty);
                }
            };
            lueBuilding.EditValueChanged += (s, e) => FilterChanged?.Invoke(this, EventArgs.Empty);
            cboStatus.SelectedIndexChanged += (s, e) => FilterChanged?.Invoke(this, EventArgs.Empty);
            dateStart.EditValueChanged += (s, e) => FilterChanged?.Invoke(this, EventArgs.Empty);
            dateEnd.EditValueChanged += (s, e) => FilterChanged?.Invoke(this, EventArgs.Empty);

            btnAdd.Click += (s, e) => AddNewContract?.Invoke(this, EventArgs.Empty);
            btnEdit.Click += (s, e) => EditContract?.Invoke(this, EventArgs.Empty);
            btnDelete.Click += (s, e) => DeleteContract?.Invoke(this, EventArgs.Empty);
        }

        #region IContractView Implementation
        public event EventHandler FilterChanged;
        public event EventHandler AddNewContract;
        public event EventHandler EditContract;
        public event EventHandler DeleteContract;

        public void SetContractDataSource(List<ContractViewModel> contracts)
        {
            gridContracts.DataSource = contracts;
            gridContracts.RefreshDataSource();
            gridViewContracts.BestFitColumns();
        }

        public void SetBuildingDataSource(List<KhuNha> buildings)
        {
            lueBuilding.Properties.DataSource = buildings;
            lueBuilding.Properties.DisplayMember = "TenKhuNha";
            lueBuilding.Properties.ValueMember = "ID";
        }

        public string GetSearchText() => txtSearch.Text;
        public object GetBuildingFilter() => lueBuilding.EditValue;
        public string GetStatusFilter() => cboStatus.SelectedItem?.ToString();
        public DateTime? GetStartDateFilter() => dateStart.DateTime == DateTime.MinValue ? (DateTime?)null : dateStart.DateTime;
        public DateTime? GetEndDateFilter() => dateEnd.DateTime == DateTime.MinValue ? (DateTime?)null : dateEnd.DateTime;
        #endregion
    }
}

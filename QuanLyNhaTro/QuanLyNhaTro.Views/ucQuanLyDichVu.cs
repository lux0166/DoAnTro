using DevExpress.XtraEditors;
using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Models;
using QuanLyNhaTro.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNhaTro.Views
{
    public partial class ucQuanLyDichVu : XtraUserControl, IServiceView
    {
        private readonly ServicePresenter _presenter;

        public ucQuanLyDichVu()
        {
            InitializeComponent();
            _presenter = new ServicePresenter(this);

            this.Load += (sender, e) => LoadServices?.Invoke(this, EventArgs.Empty);
            gridViewServices.FocusedRowChanged += (s, e) => SelectService?.Invoke(this, EventArgs.Empty);
            btnSave.Click += (s, e) => SaveService?.Invoke(this, EventArgs.Empty);
            btnAdd.Click += (s, e) => AddNewService?.Invoke(this, EventArgs.Empty);
        }

        #region IServiceView Implementation
        public event EventHandler LoadServices;
        public event EventHandler SelectService;
        public event EventHandler SaveService;
        public event EventHandler AddNewService;
        public event EventHandler DeleteService;

        public void SetServiceDataSource(List<DichVu> services)
        {
            gridServices.DataSource = services;
            gridServices.RefreshDataSource();
        }

        public DichVu GetSelectedService()
        {
            return gridViewServices.GetFocusedRow() as DichVu;
        }

        public void DisplayServiceDetails(DichVu service)
        {
            if (service != null)
            {
                txtTenDichVu.Text = service.TenDichVu;
                calcDonGia.Value = service.DonGia;
                cboDonViTinh.SelectedItem = service.DonViTinh;
                cboLoaiTinhPhi.SelectedItem = service.LoaiTinhPhi;
                toggleTrangThai.IsOn = service.TrangThai;
                // Store ID in a tag for saving
                dataLayoutControl1.Tag = service.ID;
            }
        }

        public DichVu GetServiceDetails()
        {
            return new DichVu
            {
                ID = (dataLayoutControl1.Tag as int?) ?? 0,
                TenDichVu = txtTenDichVu.Text,
                DonGia = calcDonGia.Value,
                DonViTinh = cboDonViTinh.SelectedItem?.ToString(),
                LoaiTinhPhi = cboLoaiTinhPhi.SelectedItem?.ToString(),
                TrangThai = toggleTrangThai.IsOn
            };
        }

        public void ShowMessage(string message, string caption, bool isError = false)
        {
            MessageBoxIcon icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            XtraMessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }
        #endregion
    }
}

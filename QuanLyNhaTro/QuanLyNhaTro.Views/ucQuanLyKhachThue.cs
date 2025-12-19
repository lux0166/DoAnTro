using DevExpress.XtraEditors;
using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Models;
using QuanLyNhaTro.Presenters;
using System;
using System.Collections.Generic;

namespace QuanLyNhaTro.Views
{
    public partial class ucQuanLyKhachThue : XtraUserControl, ITenantView
    {
        private readonly TenantPresenter _presenter;

        public ucQuanLyKhachThue()
        {
            InitializeComponent();
            _presenter = new TenantPresenter(this);

            this.Load += (sender, e) => _presenter.LoadInitialData();
            this.txtSearch.KeyDown += (sender, e) => {
                if (e.KeyCode == System.Windows.Forms.Keys.Enter)
                {
                    Search?.Invoke(this, EventArgs.Empty);
                }
            };
            this.btnAdd.Click += (sender, e) => AddNewTenant?.Invoke(this, EventArgs.Empty);
            this.btnEdit.Click += (sender, e) => EditTenant?.Invoke(this, EventArgs.Empty);
            this.btnDelete.Click += (sender, e) => DeleteTenant?.Invoke(this, EventArgs.Empty);
        }

        #region ITenantView Implementation
        public event EventHandler Search;
        public event EventHandler AddNewTenant;
        public event EventHandler EditTenant;
        public event EventHandler DeleteTenant;

        public void SetTenantDataSource(List<KhachThue> tenants)
        {
            gridTenants.DataSource = tenants;
            gridTenants.RefreshDataSource();
            // Customize columns
            gridViewTenants.Columns["HoTen"].Caption = "Họ và tên";
            gridViewTenants.Columns["CMND_CCCD"].Caption = "CMND/CCCD";
            gridViewTenants.Columns["SoDienThoai"].Caption = "Số điện thoại";
            gridViewTenants.Columns["NgaySinh"].Caption = "Ngày sinh";
            gridViewTenants.Columns["GioiTinh"].Caption = "Giới tính";
            gridViewTenants.Columns["QueQuan"].Caption = "Quê quán";
            gridViewTenants.Columns["TrangThai"].Caption = "Trạng thái";
            gridViewTenants.Columns["ID"].Visible = false;
            gridViewTenants.BestFitColumns();
        }

        public int? GetSelectedTenantId()
        {
            var selectedRow = gridViewTenants.GetFocusedRow();
            if (selectedRow is KhachThue tenant)
            {
                return tenant.ID;
            }
            return null;
        }

        public string GetSearchText() => txtSearch.Text;
        #endregion
    }
}

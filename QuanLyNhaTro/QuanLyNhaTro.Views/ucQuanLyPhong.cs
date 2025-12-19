using DevExpress.XtraEditors;
using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Models;
using QuanLyNhaTro.Presenters;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNhaTro.Views
{
    public partial class ucQuanLyPhong : XtraUserControl, IRoomView
    {
        private readonly RoomPresenter _presenter;

        public ucQuanLyPhong()
        {
            InitializeComponent();
            _presenter = new RoomPresenter(this);

            this.Load += (sender, e) => _presenter.LoadInitialData();
            this.btnSearch.Click += (sender, e) => SearchAndFilter?.Invoke(this, EventArgs.Empty);
            this.btnAdd.Click += (sender, e) => AddNewRoom?.Invoke(this, EventArgs.Empty);
            this.btnEdit.Click += (sender, e) => EditRoom?.Invoke(this, EventArgs.Empty);
            this.btnDelete.Click += (sender, e) => DeleteRoom?.Invoke(this, EventArgs.Empty);
        }

        #region IRoomView Implementation
        public event EventHandler SearchAndFilter;
        public event EventHandler AddNewRoom;
        public event EventHandler EditRoom;
        public event EventHandler DeleteRoom;

        public void SetRoomDataSource(List<Phong> rooms)
        {
            gridRooms.DataSource = rooms;
            gridRooms.RefreshDataSource();
        }

        public void SetBuildingDataSource(List<KhuNha> buildings)
        {
            lueBuilding.Properties.DataSource = buildings;
            lueBuilding.Properties.DisplayMember = "TenKhuNha";
            lueBuilding.Properties.ValueMember = "ID";
        }

        public void SetRoomTypeDataSource(List<LoaiPhong> roomTypes)
        {
            lueRoomType.Properties.DataSource = roomTypes;
            lueRoomType.Properties.DisplayMember = "TenLoaiPhong";
            lueRoomType.Properties.ValueMember = "ID";
        }

        public int? GetSelectedRoomId()
        {
            var selectedRow = gridViewRooms.GetFocusedRow();
            if (selectedRow is Phong phong)
            {
                return phong.ID;
            }
            return null;
        }

        public string GetSearchText() => txtSearch.Text;
        public object GetBuildingFilter() => lueBuilding.EditValue;
        public object GetRoomTypeFilter() => lueRoomType.EditValue;
        public object GetStatusFilter() => cboStatus.SelectedItem;
        #endregion
    }
}

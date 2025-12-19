using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaTro.Models;
using QuanLyNhaTro.Core;
using QuanLyNhaTro.Presenters;
using DevExpress.XtraEditors;
using System.Configuration;

namespace QuanLyNhaTro.Views
{
    public partial class ucQuanLyHoaDon : UserControl, IQuanLyHoaDonView
    {
        private QuanLyHoaDonPresenter _presenter;

        public ucQuanLyHoaDon()
        {
            InitializeComponent();
            _presenter = new QuanLyHoaDonPresenter(this, ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadHoaDons?.Invoke(this, EventArgs.Empty);
            gridViewHoaDon.FocusedRowChanged += (s, ev) => SelectHoaDon?.Invoke(this, EventArgs.Empty);
        }

        // Interface Implementation
        public IList<HoaDonViewModel> HoaDons
        {
            get => gridControlHoaDon.DataSource as IList<HoaDonViewModel>;
            set => gridControlHoaDon.DataSource = value;
        }

        private HoaDonDetailViewModel _selectedHoaDonDetail;
        public HoaDonDetailViewModel SelectedHoaDonDetail
        {
            get => _selectedHoaDonDetail;
            set
            {
                _selectedHoaDonDetail = value;
                UpdateDetailView();
            }
        }

        public int SelectedHoaDonId
        {
            get
            {
                if (gridViewHoaDon.GetFocusedRow() is HoaDonViewModel selected)
                {
                    return selected.MaHD;
                }
                return 0;
            }
        }


        public event EventHandler LoadHoaDons;
        public event EventHandler SelectHoaDon;
        public event EventHandler GhiNhanThanhToan;

        public void ShowMessage(string message, string title, MessageType type)
        {
            MessageBoxIcon icon = MessageBoxIcon.Information;
            switch (type)
            {
                case MessageType.Error:
                    icon = MessageBoxIcon.Error;
                    break;
                case MessageType.Warning:
                    icon = MessageBoxIcon.Warning;
                    break;
                case MessageType.Success:
                    icon = MessageBoxIcon.Information; // Or a custom success icon
                    break;
            }
            XtraMessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private void UpdateDetailView()
        {
            if (_selectedHoaDonDetail == null)
            {
                // Clear all fields
                lblTenPhongKhachThue.Text = "Chọn hóa đơn để xem";
                lblMaHDThang.Text = "";
                //... clear other controls ...
                return;
            }

            lblTenPhongKhachThue.Text = $"{_selectedHoaDonDetail.TenPhong} - {_selectedHoaDonDetail.TenKhachThue}";
            lblMaHDThang.Text = _selectedHoaDonDetail.MaHD_Thang;
            lblTrangThaiHD.Text = _selectedHoaDonDetail.TrangThai;

            // Utilities
            txtSoDienCu.Text = _selectedHoaDonDetail.SoDienCu.ToString();
            txtSoDienMoi.Text = _selectedHoaDonDetail.SoDienMoi.ToString();
            lblThanhTienDien.Text = _selectedHoaDonDetail.ThanhTienDien.ToString("N0") + "đ";
            txtSoNuocCu.Text = _selectedHoaDonDetail.SoNuocCu.ToString();
            txtSoNuocMoi.Text = _selectedHoaDonDetail.SoNuocMoi.ToString();
            lblThanhTienNuoc.Text = _selectedHoaDonDetail.ThanhTienNuoc.ToString("N0") + "đ";

            // Summary
            lblTienPhong.Text = _selectedHoaDonDetail.TienPhong.ToString("N0") + "đ";
            lblTienDienNuoc.Text = _selectedHoaDonDetail.TienDienNuoc.ToString("N0") + "đ";
            lblTienDichVuKhac.Text = _selectedHoaDonDetail.TienDichVuKhac.ToString("N0") + "đ";
            lblTongCong.Text = _selectedHoaDonDetail.TongCong.ToString("N0") + "đ";

            // Payment
            txtSoTienThucThu.Text = _selectedHoaDonDetail.TongCong.ToString("N0");

        }
    }
}

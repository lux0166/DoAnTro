using DevExpress.XtraEditors;
using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Presenters;
using System.Collections.Generic;
using DevExpress.XtraCharts;
using System.Windows.Forms;

namespace QuanLyNhaTro.Views
{
    public partial class ucDashboard : XtraUserControl, IDashboardView
    {
        private readonly DashboardPresenter _presenter;

        public ucDashboard()
        {
            InitializeComponent();
            _presenter = new DashboardPresenter(this);
            // Use a try-catch block to handle potential design-time errors
            try
            {
                this.Load += (sender, e) => _presenter.LoadDashboardData();
            }
            catch { }
        }

        // IDashboardView Implementation
        public void SetKpiTotalRooms(string count) => lblKpiTotalRoomsValue.Text = count;
        public void SetKpiOccupiedRooms(string count) => lblKpiOccupiedRoomsValue.Text = count;
        public void SetKpiEmptyRooms(string count) => lblKpiEmptyRoomsValue.Text = count;
        public void SetKpiMonthlyRevenue(string amount) => lblKpiMonthlyRevenueValue.Text = amount;

        public void DisplayRevenueChart(List<RevenueChartPoint> data)
        {
            Series series = new Series("Doanh thu", ViewType.Bar);
            series.DataSource = data;
            series.ArgumentDataMember = "Month";
            series.ValueDataMembers.AddRange(new string[] { "Revenue" });

            chartRevenue.Series.Clear();
            chartRevenue.Series.Add(series);

            // Customization
            XYDiagram diagram = (XYDiagram)chartRevenue.Diagram;
            if (diagram != null)
            {
                diagram.AxisY.Label.TextPattern = "{V:N0} đ";
            }
        }

        public void DisplayRecentActivities(List<RecentActivityItem> data)
        {
            gridRecentActivity.DataSource = data;

            // Customization
            gridViewRecentActivity.Columns["TenantName"].Caption = "Khách thuê";
            gridViewRecentActivity.Columns["RoomName"].Caption = "Phòng";
            gridViewRecentActivity.Columns["Status"].Caption = "Trạng thái";
            gridViewRecentActivity.Columns["Amount"].Caption = "Số tiền";
            gridViewRecentActivity.Columns["Amount"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridViewRecentActivity.Columns["Amount"].DisplayFormat.FormatString = "N0";
            gridViewRecentActivity.BestFitColumns();
        }

        public void ShowMessage(string message, string caption, bool isError = false)
        {
            MessageBoxIcon icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Information;
            XtraMessageBox.Show(message, caption, MessageBoxButtons.OK, icon);
        }
    }
}

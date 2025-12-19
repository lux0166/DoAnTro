using QuanLyNhaTro.Core.Interfaces;
using QuanLyNhaTro.Data;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace QuanLyNhaTro.Presenters
{
    public class DashboardPresenter
    {
        private readonly IDashboardView _view;
        private readonly PhongRepository _phongRepository;
        private readonly HoaDonRepository _hoaDonRepository;

        public DashboardPresenter(IDashboardView view)
        {
            _view = view;
            _phongRepository = new PhongRepository();
            _hoaDonRepository = new HoaDonRepository();
        }

        public void LoadDashboardData()
        {
            try
            {
                // Load KPIs
                LoadKpis();

                // Load Chart Data (Placeholder for now)
                LoadRevenueChart();

                // Load Recent Activities (Placeholder for now)
                LoadRecentActivities();
            }
            catch (Exception ex)
            {
                _view.ShowMessage($"Đã xảy ra lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", isError: true);
            }
        }

        private void LoadKpis()
        {
            // Get data from repositories
            int totalRooms = _phongRepository.CountAll();
            int occupiedRooms = _phongRepository.CountByStatus("Đang thuê");
            int emptyRooms = _phongRepository.CountByStatus("Trống");
            decimal monthlyRevenue = _hoaDonRepository.GetMonthlyRevenue(DateTime.Now.Month, DateTime.Now.Year);

            // Update the view
            _view.SetKpiTotalRooms(totalRooms.ToString());
            _view.SetKpiOccupiedRooms(occupiedRooms.ToString());
            _view.SetKpiEmptyRooms(emptyRooms.ToString());
            _view.SetKpiMonthlyRevenue(monthlyRevenue.ToString("N0", new CultureInfo("vi-VN")) + "đ");
        }

        private void LoadRevenueChart()
        {
            // In a real implementation, you would loop through the last 6 months
            // and call the repository to get data for each month.
            var chartData = new List<RevenueChartPoint>
            {
                new RevenueChartPoint { Month = "T8", Revenue = 24000000 },
                new RevenueChartPoint { Month = "T9", Revenue = 32000000 },
                new RevenueChartPoint { Month = "T10", Revenue = 28000000 },
                new RevenueChartPoint { Month = "T11", Revenue = 45000000 },
                new RevenueChartPoint { Month = "T12", Revenue = 38000000 },
                new RevenueChartPoint { Month = "T1", Revenue = 56000000 }
            };
            _view.DisplayRevenueChart(chartData);
        }

        private void LoadRecentActivities()
        {
            // This would typically fetch recent transactions or contract changes from the database.
            var activityData = new List<RecentActivityItem>
            {
                new RecentActivityItem { TenantName = "Nguyễn Văn A", RoomName = "P.101", Status = "Đã thanh toán", Amount = 3500000 },
                new RecentActivityItem { TenantName = "Trần Thị B", RoomName = "P.205", Status = "Chưa thanh toán", Amount = 4200000 },
                new RecentActivityItem { TenantName = "Lê Văn C", RoomName = "P.302", Status = "Sắp hết hạn", Amount = 3800000 }
            };
            _view.DisplayRecentActivities(activityData);
        }
    }
}

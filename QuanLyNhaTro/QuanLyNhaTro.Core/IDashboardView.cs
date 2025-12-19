using System.Collections.Generic;

namespace QuanLyNhaTro.Core.Interfaces
{
    // A simple class to hold data for the chart
    public class RevenueChartPoint
    {
        public string Month { get; set; }
        public decimal Revenue { get; set; }
    }

    // A simple class for recent activity items
    public class RecentActivityItem
    {
        public string TenantName { get; set; }
        public string RoomName { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
    }

    public interface IDashboardView
    {
        // KPI Setters
        void SetKpiTotalRooms(string count);
        void SetKpiOccupiedRooms(string count);
        void SetKpiEmptyRooms(string count);
        void SetKpiMonthlyRevenue(string amount);

        // Chart and Grid Data Binders
        void DisplayRevenueChart(List<RevenueChartPoint> data);
        void DisplayRecentActivities(List<RecentActivityItem> data);

        // General purpose message display
        void ShowMessage(string message, string caption, bool isError = false);
    }
}

using QuanLyNhaTro.Models;
using System;
using System.Collections.Generic;

namespace QuanLyNhaTro.Core
{
    public interface IQuanLyHoaDonView
    {
        // Properties to bind data
        IList<HoaDonViewModel> HoaDons { get; set; }
        HoaDonDetailViewModel SelectedHoaDonDetail { get; set; }
        int SelectedHoaDonId { get; }

        // Events triggered by the View
        event EventHandler LoadHoaDons;
        event EventHandler SelectHoaDon;
        event EventHandler GhiNhanThanhToan;

        // Methods to show messages
        void ShowMessage(string message, string title, MessageType type);
    }

    public enum MessageType
    {
        Success,
        Error,
        Info,
        Warning
    }
}

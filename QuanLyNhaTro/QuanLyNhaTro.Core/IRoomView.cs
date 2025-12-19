using QuanLyNhaTro.Models;
using System.Collections.Generic;

namespace QuanLyNhaTro.Core.Interfaces
{
    public interface IRoomView
    {
        // Data binding
        void SetRoomDataSource(List<Phong> rooms);
        void SetBuildingDataSource(List<KhuNha> buildings);
        void SetRoomTypeDataSource(List<LoaiPhong> roomTypes);

        // UI Interaction
        int? GetSelectedRoomId();
        string GetSearchText();
        object GetBuildingFilter();
        object GetRoomTypeFilter();
        object GetStatusFilter();

        // Events for Presenter
        event System.EventHandler SearchAndFilter;
        event System.EventHandler AddNewRoom;
        event System.EventHandler EditRoom;
        event System.EventHandler DeleteRoom;
    }
}

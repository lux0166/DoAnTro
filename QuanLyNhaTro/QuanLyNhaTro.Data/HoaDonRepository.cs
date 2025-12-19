using QuanLyNhaTro.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class HoaDonRepository
    {
        public List<HoaDon> GetAll()
        {
            List<HoaDon> invoices = new List<HoaDon>();
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ID, MaHoaDon, IDHopDong, NgayLap, HanThanhToan, TongTien, DaThanhToan, ConNo, TrangThai, GhiChu FROM HoaDon";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        invoices.Add(new HoaDon
                        {
                            ID = (int)reader["ID"],
                            MaHoaDon = reader["MaHoaDon"].ToString(),
                            IDHopDong = (int)reader["IDHopDong"],
                            NgayLap = (DateTime)reader["NgayLap"],
                            HanThanhToan = (DateTime)reader["HanThanhToan"],
                            TongTien = (decimal)reader["TongTien"],
                            DaThanhToan = (decimal)reader["DaThanhToan"],
                            ConNo = (decimal)reader["ConNo"],
                            TrangThai = reader["TrangThai"].ToString(),
                            GhiChu = reader["GhiChu"].ToString()
                        });
                    }
                }
            }
            return invoices;
        }

        public void Add(HoaDon hoaDon)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO HoaDon (IDHopDong, NgayLap, HanThanhToan, TongTien, DaThanhToan, TrangThai, GhiChu) VALUES (@IDHopDong, @NgayLap, @HanThanhToan, @TongTien, @DaThanhToan, @TrangThai, @GhiChu)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDHopDong", hoaDon.IDHopDong);
                command.Parameters.AddWithValue("@NgayLap", hoaDon.NgayLap);
                command.Parameters.AddWithValue("@HanThanhToan", hoaDon.HanThanhToan);
                command.Parameters.AddWithValue("@TongTien", hoaDon.TongTien);
                command.Parameters.AddWithValue("@DaThanhToan", hoaDon.DaThanhToan);
                command.Parameters.AddWithValue("@TrangThai", hoaDon.TrangThai);
                command.Parameters.AddWithValue("@GhiChu", (object)hoaDon.GhiChu ?? DBNull.Value);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Additional methods like Update, Delete, GetById can be added here.
    }
}

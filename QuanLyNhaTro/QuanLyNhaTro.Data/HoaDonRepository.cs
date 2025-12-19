using QuanLyNhaTro.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class HoaDonRepository
    {
        private readonly string _connectionString;

        public HoaDonRepository()
        {
            _connectionString = DatabaseConnection.GetConnectionString();
        }

        public HoaDonRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<HoaDon> GetAll()
        {
            List<HoaDon> invoices = new List<HoaDon>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT
                        hd.MaHD, hd.NgayLap, hd.HanThanhToan, hd.TongTien, hd.TrangThai, hd.SoDienCu, hd.SoDienMoi, hd.SoNuocCu, hd.SoNuocMoi,
                        h.ID AS HopDongID, h.MaHopDong, h.TienCoc, h.IDPhong, h.IDKhachThue,
                        p.ID AS PhongID, p.TenPhong,
                        k.ID AS KhachThueID, k.HoTen
                    FROM HoaDon hd
                    LEFT JOIN HopDong h ON hd.MaHopDong = h.ID
                    LEFT JOIN Phong p ON h.IDPhong = p.ID
                    LEFT JOIN KhachThue k ON h.IDKhachThue = k.ID";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        invoices.Add(MapReaderToHoaDon(reader, true));
                    }
                }
            }
            return invoices;
        }

        public HoaDon GetById(int maHD)
        {
            HoaDon hoaDon = null;
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT
                        hd.MaHD, hd.NgayLap, hd.HanThanhToan, hd.TongTien, hd.TrangThai, hd.SoDienCu, hd.SoDienMoi, hd.SoNuocCu, hd.SoNuocMoi,
                        h.ID AS HopDongID, h.MaHopDong, h.TienCoc, h.IDPhong, h.IDKhachThue,
                        p.ID AS PhongID, p.TenPhong,
                        k.ID AS KhachThueID, k.HoTen
                    FROM HoaDon hd
                    LEFT JOIN HopDong h ON hd.MaHopDong = h.ID
                    LEFT JOIN Phong p ON h.IDPhong = p.ID
                    LEFT JOIN KhachThue k ON h.IDKhachThue = k.ID
                    WHERE hd.MaHD = @MaHD";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHD", maHD);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hoaDon = MapReaderToHoaDon(reader, true);
                    }
                }
            }
            return hoaDon;
        }


        public void Add(HoaDon hoaDon)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO HoaDon (MaHopDong, NgayLap, HanThanhToan, TongTien, DaThanhToan, TrangThai, GhiChu) VALUES (@MaHopDong, @NgayLap, @HanThanhToan, @TongTien, @DaThanhToan, @TrangThai, @GhiChu)";
                SqlCommand command = new SqlCommand(query, connection);
                // MaHopDong in HoaDon table is FK to HopDong.ID
                command.Parameters.AddWithValue("@MaHopDong", hoaDon.MaHopDong);
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

        public decimal GetMonthlyRevenue(int month, int year)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT SUM(DaThanhToan) FROM HoaDon WHERE MONTH(NgayLap) = @Month AND YEAR(NgayLap) = @Year";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Month", month);
                command.Parameters.AddWithValue("@Year", year);
                connection.Open();
                object result = command.ExecuteScalar();
                return (result == DBNull.Value) ? 0 : (decimal)result;
            }
        }

        private HoaDon MapReaderToHoaDon(SqlDataReader reader, bool includeRelated = false)
        {
            var hoaDon = new HoaDon
            {
                MaHD = (int)reader["MaHD"],
                MaHopDong = (int)reader["HopDongID"], // Load the FK ID
                NgayLap = (DateTime)reader["NgayLap"],
                HanThanhToan = (DateTime)reader["HanThanhToan"],
                TongTien = (decimal)reader["TongTien"],
                TrangThai = reader["TrangThai"].ToString(),
                SoDienCu = Convert.ToDouble(reader["SoDienCu"]),
                SoDienMoi = Convert.ToDouble(reader["SoDienMoi"]),
                SoNuocCu = Convert.ToDouble(reader["SoNuocCu"]),
                SoNuocMoi = Convert.ToDouble(reader["SoNuocMoi"]),
            };

            if (includeRelated)
            {
                hoaDon.HopDong = new HopDong
                {
                    ID = (int)reader["HopDongID"],
                    MaHopDong = reader["MaHopDong"].ToString(),
                    TienCoc = (decimal)reader["TienCoc"],
                    IDPhong = (int)reader["IDPhong"],
                    IDKhachThue = (int)reader["IDKhachThue"],
                    Phong = new Phong
                    {
                        ID = (int)reader["PhongID"],
                        TenPhong = reader["TenPhong"].ToString(),
                    },
                    KhachThue = new KhachThue
                    {
                        ID = (int)reader["KhachThueID"],
                        HoTen = reader["HoTen"].ToString(),
                    }
                };
            }
            return hoaDon;
        }
    }
}

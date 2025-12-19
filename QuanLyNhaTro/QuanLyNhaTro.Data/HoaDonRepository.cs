using QuanLyNhaTro.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class HoaDonRepository
    {
        private readonly string _connectionString;
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
                        h.MaHopDong, h.TienCoc,
                        p.MaPhong, p.TenPhong,
                        k.MaKhachThue, k.HoTen
                    FROM HoaDon hd
                    LEFT JOIN HopDong h ON hd.MaHopDong = h.MaHopDong
                    LEFT JOIN Phong p ON h.MaPhong = p.MaPhong
                    LEFT JOIN KhachThue k ON h.MaKhachThue = k.MaKhachThue";
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
                        hd.*,
                        h.*,
                        p.*,
                        k.*
                    FROM HoaDon hd
                    LEFT JOIN HopDong h ON hd.MaHopDong = h.MaHopDong
                    LEFT JOIN Phong p ON h.MaPhong = p.MaPhong
                    LEFT JOIN KhachThue k ON h.MaKhachThue = k.MaKhachThue
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
                command.Parameters.AddWithValue("@MaHopDong", hoaDon.HopDong.MaHopDong);
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
                    MaHopDong = (int)reader["MaHopDong"],
                    TienCoc = (decimal)reader["TienCoc"],
                    Phong = new Phong
                    {
                        MaPhong = (int)reader["MaPhong"],
                        TenPhong = reader["TenPhong"].ToString(),
                    },
                    KhachThue = new KhachThue
                    {
                        MaKhachThue = (int)reader["MaKhachThue"],
                        HoTen = reader["HoTen"].ToString(),
                    }
                };
            }
            return hoaDon;
        }
    }
}

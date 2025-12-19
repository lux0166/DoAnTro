using QuanLyNhaTro.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class HopDongRepository
    {
        public List<HopDong> GetAll()
        {
            List<HopDong> contracts = new List<HopDong>();
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ID, MaHopDong, IDPhong, IDKhachThue, GiaThue, TienCoc, NgayBatDau, NgayKetThuc, TrangThai FROM HopDong";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contracts.Add(new HopDong
                        {
                            ID = (int)reader["ID"],
                            MaHopDong = reader["MaHopDong"].ToString(),
                            IDPhong = (int)reader["IDPhong"],
                            IDKhachThue = (int)reader["IDKhachThue"],
                            GiaThue = (decimal)reader["GiaThue"],
                            TienCoc = (decimal)reader["TienCoc"],
                            NgayBatDau = (DateTime)reader["NgayBatDau"],
                            NgayKetThuc = (DateTime)reader["NgayKetThuc"],
                            TrangThai = reader["TrangThai"].ToString()
                        });
                    }
                }
            }
            return contracts;
        }

        public void Add(HopDong hopDong)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO HopDong (IDPhong, IDKhachThue, GiaThue, TienCoc, NgayBatDau, NgayKetThuc, TrangThai) VALUES (@IDPhong, @IDKhachThue, @GiaThue, @TienCoc, @NgayBatDau, @NgayKetThuc, @TrangThai)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDPhong", hopDong.IDPhong);
                command.Parameters.AddWithValue("@IDKhachThue", hopDong.IDKhachThue);
                command.Parameters.AddWithValue("@GiaThue", hopDong.GiaThue);
                command.Parameters.AddWithValue("@TienCoc", hopDong.TienCoc);
                command.Parameters.AddWithValue("@NgayBatDau", hopDong.NgayBatDau);
                command.Parameters.AddWithValue("@NgayKetThuc", hopDong.NgayKetThuc);
                command.Parameters.AddWithValue("@TrangThai", hopDong.TrangThai);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Additional methods like Update, Delete, GetById can be added here.
        public List<ContractViewModel> GetAllAsViewModel()
        {
            List<ContractViewModel> contracts = new List<ContractViewModel>();
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT
                        hd.ID,
                        hd.MaHopDong,
                        p.TenPhong,
                        kt.HoTen AS TenKhachThue,
                        kt.SoDienThoai,
                        hd.GiaThue,
                        hd.TienCoc,
                        hd.NgayBatDau,
                        hd.NgayKetThuc,
                        hd.TrangThai
                    FROM HopDong hd
                    JOIN Phong p ON hd.IDPhong = p.ID
                    JOIN KhachThue kt ON hd.IDKhachThue = kt.ID";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        contracts.Add(new ContractViewModel
                        {
                            ID = (int)reader["ID"],
                            MaHopDong = reader["MaHopDong"].ToString(),
                            TenPhong = reader["TenPhong"].ToString(),
                            TenKhachThue = reader["TenKhachThue"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            GiaThue = (decimal)reader["GiaThue"],
                            TienCoc = (decimal)reader["TienCoc"],
                            NgayBatDau = (DateTime)reader["NgayBatDau"],
                            NgayKetThuc = (DateTime)reader["NgayKetThuc"],
                            TrangThai = reader["TrangThai"].ToString()
                        });
                    }
                }
            }
            return contracts;
        }
    }
}

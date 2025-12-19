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
    }
}

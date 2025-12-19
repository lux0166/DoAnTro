using QuanLyNhaTro.Models;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class KhachThueRepository
    {
        private string _connectionString;

        public KhachThueRepository()
        {
            _connectionString = DatabaseConnection.GetConnectionString();
        }

        public KhachThueRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<KhachThue> GetAll()
        {
            List<KhachThue> tenants = new List<KhachThue>();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT ID, HoTen, CMND_CCCD, SoDienThoai, NgaySinh, GioiTinh, QueQuan, TrangThai FROM KhachThue";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tenants.Add(new KhachThue
                        {
                            ID = (int)reader["ID"],
                            HoTen = reader["HoTen"].ToString(),
                            CMND_CCCD = reader["CMND_CCCD"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            NgaySinh = reader["NgaySinh"] as DateTime?,
                            GioiTinh = reader["GioiTinh"].ToString(),
                            QueQuan = reader["QueQuan"].ToString(),
                            TrangThai = reader["TrangThai"].ToString()
                        });
                    }
                }
            }
            return tenants;
        }

        public void Add(KhachThue khachThue)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO KhachThue (HoTen, CMND_CCCD, SoDienThoai, NgaySinh, GioiTinh, QueQuan, TrangThai) VALUES (@HoTen, @CMND_CCCD, @SoDienThoai, @NgaySinh, @GioiTinh, @QueQuan, @TrangThai)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTen", khachThue.HoTen);
                command.Parameters.AddWithValue("@CMND_CCCD", khachThue.CMND_CCCD);
                command.Parameters.AddWithValue("@SoDienThoai", khachThue.SoDienThoai);
                command.Parameters.AddWithValue("@NgaySinh", (object)khachThue.NgaySinh ?? DBNull.Value);
                command.Parameters.AddWithValue("@GioiTinh", khachThue.GioiTinh);
                command.Parameters.AddWithValue("@QueQuan", khachThue.QueQuan);
                command.Parameters.AddWithValue("@TrangThai", khachThue.TrangThai);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Additional methods like Update, Delete, GetById can be added here.
    }
}

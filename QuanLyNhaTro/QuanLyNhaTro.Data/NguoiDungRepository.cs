using QuanLyNhaTro.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class NguoiDungRepository
    {
        public NguoiDung GetByUsername(string username)
        {
            NguoiDung user = null;
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ID, TenDangNhap, MatKhau, HoTen, Quyen, TrangThai FROM NguoiDung WHERE TenDangNhap = @TenDangNhap";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenDangNhap", username);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new NguoiDung
                        {
                            ID = (int)reader["ID"],
                            TenDangNhap = reader["TenDangNhap"].ToString(),
                            MatKhau = reader["MatKhau"].ToString(),
                            HoTen = reader["HoTen"].ToString(),
                            Quyen = reader["Quyen"].ToString(),
                            TrangThai = (bool)reader["TrangThai"]
                        };
                    }
                }
            }
            return user;
        }

        public void Add(NguoiDung user)
        {
            // Hash the password before saving
            user.MatKhau = BCrypt.Net.BCrypt.HashPassword(user.MatKhau);

            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO NguoiDung (TenDangNhap, MatKhau, HoTen, Quyen, TrangThai) VALUES (@TenDangNhap, @MatKhau, @HoTen, @Quyen, @TrangThai)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenDangNhap", user.TenDangNhap);
                command.Parameters.AddWithValue("@MatKhau", user.MatKhau);
                command.Parameters.AddWithValue("@HoTen", user.HoTen);
                command.Parameters.AddWithValue("@Quyen", user.Quyen);
                command.Parameters.AddWithValue("@TrangThai", user.TrangThai);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Additional methods like Update, Delete, GetAll can be added here.
    }
}

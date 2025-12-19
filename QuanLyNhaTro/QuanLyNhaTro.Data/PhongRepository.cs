using QuanLyNhaTro.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class PhongRepository
    {
        public List<Phong> GetAll()
        {
            List<Phong> rooms = new List<Phong>();
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ID, TenPhong, IDKhuNha, IDLoaiPhong, DienTich, GiaThue, TrangThai, MoTa FROM Phong";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new Phong
                        {
                            ID = (int)reader["ID"],
                            TenPhong = reader["TenPhong"].ToString(),
                            IDKhuNha = (int)reader["IDKhuNha"],
                            IDLoaiPhong = (int)reader["IDLoaiPhong"],
                            DienTich = (double)reader["DienTich"],
                            GiaThue = (decimal)reader["GiaThue"],
                            TrangThai = reader["TrangThai"].ToString(),
                            MoTa = reader["MoTa"].ToString()
                        });
                    }
                }
            }
            return rooms;
        }

        public void Add(Phong phong)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Phong (TenPhong, IDKhuNha, IDLoaiPhong, DienTich, GiaThue, TrangThai, MoTa) VALUES (@TenPhong, @IDKhuNha, @IDLoaiPhong, @DienTich, @GiaThue, @TrangThai, @MoTa)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenPhong", phong.TenPhong);
                command.Parameters.AddWithValue("@IDKhuNha", phong.IDKhuNha);
                command.Parameters.AddWithValue("@IDLoaiPhong", phong.IDLoaiPhong);
                command.Parameters.AddWithValue("@DienTich", phong.DienTich);
                command.Parameters.AddWithValue("@GiaThue", phong.GiaThue);
                command.Parameters.AddWithValue("@TrangThai", phong.TrangThai);
                command.Parameters.AddWithValue("@MoTa", phong.MoTa);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Update(Phong phong)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE Phong SET TenPhong = @TenPhong, IDKhuNha = @IDKhuNha, IDLoaiPhong = @IDLoaiPhong, DienTich = @DienTich, GiaThue = @GiaThue, TrangThai = @TrangThai, MoTa = @MoTa WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", phong.ID);
                command.Parameters.AddWithValue("@TenPhong", phong.TenPhong);
                command.Parameters.AddWithValue("@IDKhuNha", phong.IDKhuNha);
                command.Parameters.AddWithValue("@IDLoaiPhong", phong.IDLoaiPhong);
                command.Parameters.AddWithValue("@DienTich", phong.DienTich);
                command.Parameters.AddWithValue("@GiaThue", phong.GiaThue);
                command.Parameters.AddWithValue("@TrangThai", phong.TrangThai);
                command.Parameters.AddWithValue("@MoTa", phong.MoTa);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Additional methods like GetById, Delete can be added here.
    }
}

using QuanLyNhaTro.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class DichVuRepository
    {
        public List<DichVu> GetAll()
        {
            List<DichVu> services = new List<DichVu>();
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ID, TenDichVu, DonGia, DonViTinh, LoaiTinhPhi, TrangThai FROM DichVu";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        services.Add(new DichVu
                        {
                            ID = (int)reader["ID"],
                            TenDichVu = reader["TenDichVu"].ToString(),
                            DonGia = (decimal)reader["DonGia"],
                            DonViTinh = reader["DonViTinh"].ToString(),
                            LoaiTinhPhi = reader["LoaiTinhPhi"].ToString(),
                            TrangThai = (bool)reader["TrangThai"]
                        });
                    }
                }
            }
            return services;
        }

        public void Add(DichVu dichVu)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO DichVu (TenDichVu, DonGia, DonViTinh, LoaiTinhPhi, TrangThai) VALUES (@TenDichVu, @DonGia, @DonViTinh, @LoaiTinhPhi, @TrangThai)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenDichVu", dichVu.TenDichVu);
                command.Parameters.AddWithValue("@DonGia", dichVu.DonGia);
                command.Parameters.AddWithValue("@DonViTinh", dichVu.DonViTinh);
                command.Parameters.AddWithValue("@LoaiTinhPhi", dichVu.LoaiTinhPhi);
                command.Parameters.AddWithValue("@TrangThai", dichVu.TrangThai);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Additional methods like Update, Delete, GetById can be added here.
        public void Update(DichVu dichVu)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "UPDATE DichVu SET TenDichVu = @TenDichVu, DonGia = @DonGia, DonViTinh = @DonViTinh, LoaiTinhPhi = @LoaiTinhPhi, TrangThai = @TrangThai WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", dichVu.ID);
                command.Parameters.AddWithValue("@TenDichVu", dichVu.TenDichVu);
                command.Parameters.AddWithValue("@DonGia", dichVu.DonGia);
                command.Parameters.AddWithValue("@DonViTinh", dichVu.DonViTinh);
                command.Parameters.AddWithValue("@LoaiTinhPhi", dichVu.LoaiTinhPhi);
                command.Parameters.AddWithValue("@TrangThai", dichVu.TrangThai);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}

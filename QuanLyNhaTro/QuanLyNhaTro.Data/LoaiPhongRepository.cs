using QuanLyNhaTro.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class LoaiPhongRepository
    {
        public List<LoaiPhong> GetAll()
        {
            List<LoaiPhong> loaiPhongs = new List<LoaiPhong>();
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ID, TenLoaiPhong FROM LoaiPhong";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        loaiPhongs.Add(new LoaiPhong
                        {
                            ID = (int)reader["ID"],
                            TenLoaiPhong = reader["TenLoaiPhong"].ToString()
                        });
                    }
                }
            }
            return loaiPhongs;
        }
    }
}

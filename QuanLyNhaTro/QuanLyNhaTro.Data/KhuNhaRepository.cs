using QuanLyNhaTro.Models;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace QuanLyNhaTro.Data
{
    public class KhuNhaRepository
    {
        public List<KhuNha> GetAll()
        {
            List<KhuNha> khuNhas = new List<KhuNha>();
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                string query = "SELECT ID, TenKhuNha, DiaChi FROM KhuNha";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        khuNhas.Add(new KhuNha
                        {
                            ID = (int)reader["ID"],
                            TenKhuNha = reader["TenKhuNha"].ToString(),
                            DiaChi = reader["DiaChi"].ToString()
                        });
                    }
                }
            }
            return khuNhas;
        }
    }
}

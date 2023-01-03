using Microsoft.Data.SqlClient;
namespace sqlTest2
{
    class Program
    {

        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=MayvueTestDB;User Id=sa;Password=Periphery3;TrustServerCertificate=true";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using(SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT * from MotionPictures";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        string name = reader["Name"].ToString();
                        string description = reader["Description"].ToString();
                        Console.WriteLine("Name: " + name + ", Description: " + description);
                    }
                }
            }
        }
    }
}

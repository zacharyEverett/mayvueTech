using System;
using MayvueTech.Models;
using Microsoft.Data.SqlClient;
namespace MayvueTech.Services
{
	public class DB
	{
		public List<Movie> getListOfAllMovies()
		{
			List<Movie> movieList = new List<Movie>();
            string connectionString = "Server=localhost;Database=MayvueTestDB;User Id=sa;Password=Periphery3;TrustServerCertificate=true";

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				conn.Open();
				using(SqlCommand cmd = new SqlCommand())
				{
					cmd.Connection = conn;
					cmd.CommandText = "SELECT * from MotionPictures;";

					SqlDataReader reader = cmd.ExecuteReader();
					while(reader.Read())
					{
						Movie movie = new Movie();
						movie.Title = reader["Name"].ToString();
						movie.Description = reader["Description"].ToString();
						movie.ReleaseYear = reader["ReleaseYear"].ToString(); ;
						movieList.Add(movie);
                    }

				}
			}
			return movieList;
        }
    }
}


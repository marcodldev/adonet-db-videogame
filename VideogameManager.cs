using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using adonet_db_videogame;


namespace adonet_db_videogame
{
  
        public class VideogameManager
        {
            private readonly SqlConnection connection;


            public VideogameManager(SqlConnection connection)
            {
                this.connection = connection;
            }

        public void InserisciVideogame(Videogame videogame)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=videogames_db;Integrated Security=True";

            string query = "INSERT INTO videogames (name,overview,release_date,created_at,updated_at,software_house_id) VALUES" +
                    " (@name,@overview,@release_date,@created_at,@updated_at,@software_house_id)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@name", videogame.Name));
                cmd.Parameters.Add(new SqlParameter("@overview", videogame.Overview));
                cmd.Parameters.Add(new SqlParameter("@release_date", videogame.ReleaseDate));
                cmd.Parameters.Add(new SqlParameter("@created_at", videogame.CreatedAt));
                cmd.Parameters.Add(new SqlParameter("@updated_at", videogame.UpdatedAt));
                cmd.Parameters.Add(new SqlParameter("@software_house_id", videogame.SoftwareHouseId));

                connection.Open();
                int affectedRows = cmd.ExecuteNonQuery();
            }
        }



        public void RicercaVideogamePerId(int id)
            {
                Console.WriteLine(id);
            }

            public void RicercaVideogiochiPerNome()
            {

            }

            public void CancellaVideogame()
            {

            }
    }
    

}

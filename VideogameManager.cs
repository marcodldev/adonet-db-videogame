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
          
            }

            public void RicercaVideogamePerId(int id)
            {
               
            }

            public void RicercaVideogiochiPerNome()
            {

            }

            public void CancellaVideogame()
            {

            }
    }
    

}

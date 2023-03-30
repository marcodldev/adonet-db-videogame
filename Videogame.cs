using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adonet_db_videogame
{
    public class Videogame
    {

        public Videogame(string name, string overview, DateTime releaseDate, DateTime createdAt, DateTime updatedAt, int softwareHouseId)
        {
           
            Name = name;
            Overview = overview;
            ReleaseDate = releaseDate;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            SoftwareHouseId = softwareHouseId;
        }

             int Id { get; }
             string Name { get; set; }
             string Overview { get; set; }
             DateTime ReleaseDate { get; set; }
             DateTime CreatedAt { get; set; }
             DateTime UpdatedAt { get; set; }
             int SoftwareHouseId { get; set; }
        

    }
}

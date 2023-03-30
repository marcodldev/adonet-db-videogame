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

     

        public int Id { get; set; }
       public  string Name { get; set; }
        public string Overview { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int SoftwareHouseId { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\n " +
                $"Name: {Name}\n " +
                $"Overview: {Overview}\n " +
                $"Release Date: {ReleaseDate}\n " +
                $"Created At: {CreatedAt}\n " +
                $"Updated At: {UpdatedAt}\n " +
                $"Software House ID: {SoftwareHouseId}\n";
        }
    }
}

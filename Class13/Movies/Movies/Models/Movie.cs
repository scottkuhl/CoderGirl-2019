using System.Collections.Generic;

namespace Movies.Models
{
    public class Movie
    {
        public ICollection<Cast> Cast { get; set; }
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
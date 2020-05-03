using System;
using System.Collections.Generic;

namespace Movies.Models
{
    public class Actor
    {
        public DateTime BirthDate { get; set; }
        public ICollection<Cast> Cast { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
    }
}
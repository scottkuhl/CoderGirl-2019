namespace Movies.Models
{
    public class Cast
    {
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
        public Movie Movie { get; set; }
        public int MovieId { get; set; }
        public string Role { get; set; }
    }
}
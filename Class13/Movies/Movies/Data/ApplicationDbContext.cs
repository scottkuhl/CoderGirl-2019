using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movies.Models;

namespace Movies.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cast> MovieActors { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cast>().HasKey(x => new { x.ActorId, x.MovieId });

            builder.Entity<Cast>().HasOne(x => x.Actor).WithMany(x => x.Cast).HasForeignKey(x => x.ActorId);
            builder.Entity<Cast>().HasOne(x => x.Movie).WithMany(x => x.Cast).HasForeignKey(x => x.MovieId);
        }
    }
}
using CheeseMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CheeseMVC.Data
{
    public class CheeseDbContext : DbContext
    {
        public CheeseDbContext(DbContextOptions<CheeseDbContext> options)
            : base(options)
        { }

        public DbSet<CheeseCategory> Categories { get; set; }
        public DbSet<Cheese> Cheeses { get; set; }
    }
}
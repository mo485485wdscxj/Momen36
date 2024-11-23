using Microsoft.EntityFrameworkCore;
using Moamen_0522036.Models;
using System.Data;

namespace Moamen_0522036
{
    public class AppDbContext : DbContext
    {
        public DbSet<MoviesModel> movies { get; set; }
        public DbSet<CategoryMode> categories { get; set; }
        public DbSet<NationalityModel> nationalities { get; set; }
        public DbSet<DirectorModel> directors { get; set; }

       // prameteraize Constractor
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DirectorModel>()
                .HasOne(x=>x.Nationality)
                .WithOne(x=>x.Director)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}

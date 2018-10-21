using Microsoft.EntityFrameworkCore;
using Repository.DbModels;

namespace Repository.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //TODO set relationships between tables
            modelBuilder.Entity<User>().HasData(new User {
                Id = 1,
                Username = "ADMIN",
                Name = "Administrator"
            });

            base.OnModelCreating(modelBuilder);            
        }
    }
}
using ASPServer.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace ASPServer.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(new[]{
                new User { Id = 1, Username = "Admin" },
                new User { Id = 2, Username = "Bobr" }
            });
        }

        public DbSet<User> Users;
        public DbSet<Message> Messages;

    }
}

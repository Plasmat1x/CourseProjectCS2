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

            modelBuilder.Entity<User>().HasData(new User[] {
                new User {Id = 1, Username = "Admin"},
                new User {Id = 2, Username = "Bobr"},
                new User {Id = 3, Username = "Test"}
            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }
    }
}

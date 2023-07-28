using ASPServer.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace ASPServer.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users;
        public DbSet<Message> Messages;

    }
}

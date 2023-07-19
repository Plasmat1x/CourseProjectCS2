using Microsoft.EntityFrameworkCore;

namespace ServerApp.Models
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //DbSets
        #region
        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        #endregion
    }
}

using Microsoft.EntityFrameworkCore;

namespace ServerApp.Models
{
    internal class AppDbContext : DbContext
    {
        string constr;

        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        //DbSets
        #region
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        #endregion
    }
}

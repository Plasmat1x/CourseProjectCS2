using System.Data.Entity;

namespace ServerApp.Models
{
    internal class AppDbContext : DbContext
    {
        static public string constr { get; set; }

        public AppDbContext() : base(Program.appSettings.connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }

        //DbSets
        #region
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        #endregion
    }
}

using ASP.WEB.API.Context.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.WEB.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserChat>().HasKey(x => new { x.UserId, x.ChatId });
            modelBuilder.Entity<UserChat>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserChats)
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<UserChat>()
                .HasOne(uc => uc.Chat)
                .WithMany(c => c.UserChats)
                .HasForeignKey(uc => uc.ChatId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Contact>().HasKey(x => new { x.OwnerId, x.UserId });
            modelBuilder.Entity<Contact>()
                .HasOne(c => c.Owner)
                .WithMany(u => u.Contacts)
                .HasForeignKey(c => c.OwnerId)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Contact>()
                .HasOne(c => c.User)
                .WithMany(u => u.Contacts)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<User>().HasData(new[]
            {
                new User {Id = 1, Name = "Admin"},
                new User {Id = 2, Name = "Bobr" },
                new User {Id = 3, Name = "Test" },
                new User {Id = 4, Name = "Usver"},
            });

            modelBuilder.Entity<Chat>().HasData(new[]
            {
                new Chat {Id = 1, Name = "oto", OwnerId = 1},
                new Chat {Id = 2, Name = "ptp", OwnerId = 2},
            });

            modelBuilder.Entity<UserChat>().HasData(new[]
            {
                new UserChat {ChatId = 1 , UserId = 1},
                new UserChat {ChatId = 1 , UserId = 2},
                new UserChat {ChatId = 1 , UserId = 3},
                new UserChat {ChatId = 1 , UserId = 4},

                new UserChat {ChatId = 2 , UserId = 1},
                new UserChat {ChatId = 2 , UserId = 2},
            });

            modelBuilder.Entity<Contact>().HasData(new[]
            {
                new Contact {}
            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}

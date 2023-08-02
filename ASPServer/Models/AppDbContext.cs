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
                new User {Id = 1, Name = "Admin", CreatedAt = DateTime.Now},
                new User {Id = 2, Name = "Bobr", CreatedAt = DateTime.Now},
                new User {Id = 3, Name = "Test", CreatedAt = DateTime.Now},
                new User {Id = 4, Name = "Usver", CreatedAt = DateTime.Now}
            });

            modelBuilder.Entity<Contact>().HasKey(x => new { x.OwnerId, x.UserId });
            modelBuilder.Entity<Contact>()
                .HasOne(x => x.Owner)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.OwnerId);
            modelBuilder.Entity<Contact>()
                .HasOne(x => x.User)
                .WithMany(x => x.Contacts)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<Contact>().HasData(new Contact[] {
                new Contact  { CreatedDate = DateTime.Now, Name = "Bobr", UserId = 2, OwnerId = 1},
                new Contact  { CreatedDate = DateTime.Now, Name = "Admin", UserId = 1, OwnerId = 2},
                new Contact  { CreatedDate = DateTime.Now, Name = "Test", UserId = 3, OwnerId = 1}
            });

            modelBuilder.Entity<Chat>()
                .HasMany(x => x.Messages)
                .WithOne(x => x.Chat)
                .HasForeignKey(x => x.ChatId);
            modelBuilder.Entity<Chat>().HasData(new Chat[] {
                new Chat {Id = 1, Name = "Bobr", CreatedAt = DateTime.Now, OwnerId = 1},
                new Chat {Id = 2, Name = "Admin", CreatedAt = DateTime.Now, OwnerId = 1},
                new Chat {Id = 3, Name = "Test", CreatedAt = DateTime.Now, OwnerId = 1}
            });

            modelBuilder.Entity<UserChat>().HasKey(x => new { x.UserId, x.ChatId });
            modelBuilder.Entity<UserChat>()
                .HasOne(x => x.User)
                .WithMany(x => x.Chats)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<UserChat>()
                .HasOne(x => x.Chat)
                .WithMany(x => x.UserChats)
                .HasForeignKey(x => x.ChatId);
            modelBuilder.Entity<UserChat>().HasData(new UserChat[] {
                new UserChat{UserId = 1, ChatId = 1, AddedTime = DateTime.Now},
                new UserChat{UserId = 1, ChatId = 3, AddedTime = DateTime.Now},
                new UserChat{UserId = 2, ChatId = 2, AddedTime = DateTime.Now},
            });

            modelBuilder.Entity<Message>().HasData(new Message[]{
                new Message { Id = 1, FromUserId = 1, ChatId = 1, Content = "Hello Bobr", CreatedAt = DateTime.Now}
            });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
    }
}

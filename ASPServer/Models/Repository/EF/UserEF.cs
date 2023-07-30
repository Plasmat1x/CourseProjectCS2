using ASPServer.Domain;
using ASPServer.Models.Entity;
using ASPServer.Models.Repository.Abstract;

namespace ASPServer.Models.Repository.EF
{
    public class UserEF : IUserRepo
    {
        AppDbContext context;

        public UserEF(AppDbContext context)
        {
            this.context = context;
        }

        public void AddUser(string username)
        {
            if (!context.Users.Contains(new User { Username = username }))
            {
                context.Users.Add(new User { Username = username });
                context.SaveChanges();
            }
        }

        public void DeleteUser(int id)
        {
            context.Users.Remove(new User { Id = id });
            context.SaveChanges();
        }

        public User? GetUser(string username)
        {
            return context.Users.FirstOrDefault(x => x.Username == username);
        }
    }
}

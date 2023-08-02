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

        }

        public void DeleteUser(int id)
        {
            context.Users.Remove(new User { Id = id });
            context.SaveChanges();
        }

        public User? GetUser(string username)
        {
            return null;
        }
    }
}

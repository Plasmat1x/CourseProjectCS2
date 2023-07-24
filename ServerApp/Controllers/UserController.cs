using ServerApp.Interfaces;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    internal class UserController : IController<User>
    {
        AppDbContext Context;

        public UserController(AppDbContext context)
        {
            Context = context;
        }

        public void CREATE(User entity)
        {
            Context.Users.Add(entity);
            Context.SaveChanges();
        }

        public void DELETE(int Id)
        {
            Context.Users.Remove(new User { Id = Id });
            Context.SaveChanges();
        }

        public User SELECT(int Id)
        {
            return Context.Users.FirstOrDefault(x => x.Id == Id);
        }

        public void UPDATE(User entity)
        {
            Context.Users.Update(entity);
            Context.SaveChanges();
        }
    }
}

using ASPServer.Domain.Entities;
using ASPServer.Domain.Repositories.Abstract;

namespace ASPServer.Domain.Repositories.EnitityFramework
{
    public class EFUserRepository : IUserRepository
    {
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> getUsers()
        {
            throw new NotImplementedException();
        }

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

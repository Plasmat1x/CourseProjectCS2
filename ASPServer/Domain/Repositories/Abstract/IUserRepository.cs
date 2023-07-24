using ASPServer.Domain.Entities;

namespace ASPServer.Domain.Repositories.Abstract
{
    public interface IUserRepository
    {
        IQueryable<User> getUsers();
        User GetUser(int id);
        void SaveUser(User user);
        void DeleteUser(int id);
    }
}

using ASPServer.Models.Entity;

namespace ASPServer.Models.Repository.Abstract
{
    public interface IUserRepo
    {
        public User? GetUser(string username);
        public void DeleteUser(int id);
        public void AddUser(string username);
    }
}

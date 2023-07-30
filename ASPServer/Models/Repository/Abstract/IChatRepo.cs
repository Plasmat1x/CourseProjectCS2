using ASPServer.Models.Entity;

namespace ASPServer.Models.Repository.Abstract
{
    public interface IChatRepo
    {
        public IQueryable<Chat>? GetChats(string username);
        public Chat? GetChat(int id);
        public void AddChat(Chat chat);
        public void RemoveChat(int id);
    }
}

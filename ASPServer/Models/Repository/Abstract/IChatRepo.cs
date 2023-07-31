using ASPServer.Models.Entity;

namespace ASPServer.Models.Repository.Abstract
{
    public interface IChatRepo
    {
        public IQueryable<Chat>? GetChats(User requester);
        public Chat? GetChat(int id);
        public void AddChat(User requester, Chat chat);
        public void RemoveChat(int id);
        public void AddUserToChat(int chatid, User user);
    }
}

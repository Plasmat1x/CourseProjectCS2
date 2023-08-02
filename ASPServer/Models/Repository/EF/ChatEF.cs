using ASPServer.Domain;
using ASPServer.Models.Entity;
using ASPServer.Models.Repository.Abstract;

namespace ASPServer.Models.Repository.EF
{
    public class ChatEF : IChatRepo
    {
        AppDbContext context;

        public ChatEF(AppDbContext context)
        {
            this.context = context;
        }

        public void AddChat(User requester, Chat chat)
        {
            context.SaveChanges();
        }

        public void AddUserToChat(int chatid, User user)
        {
            context.SaveChanges();
        }

        public Chat? GetChat(int id)
        {
            return context.Chats.FirstOrDefault(c => c.Id == id);
        }

        public IQueryable<Chat>? GetChats(User requester)
        {
            return null;
        }

        public void RemoveChat(int id)
        {
            context.SaveChanges();
        }
    }
}

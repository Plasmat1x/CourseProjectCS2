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

        public void AddChat(Chat chat)
        {
            context.Chats.Add(chat);
            context.SaveChanges();
        }

        public Chat? GetChat(int id)
        {
            return context.Chats.FirstOrDefault(c => c.Id == id);
        }

        public IQueryable<Chat>? GetChats(string username)
        {
            return context.Chats.Where(x => x.Users.Contains(new User { Username = username }));
        }

        public void RemoveChat(int id)
        {
            context.Chats.Remove(new Chat { Id = id });
            context.SaveChanges();
        }
    }
}

using ASPServer.Domain;
using ASPServer.Models.Entity;
using ASPServer.Models.Repository.Abstract;

namespace ASPServer.Models.Repository.EF
{
    public class MessageEF : IMessageRepo
    {
        AppDbContext context;

        public MessageEF(AppDbContext context)
        {
            this.context = context;
        }

        public void AddMessage(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
        }

        public void DeleteMessage(int id)
        {
            context.Messages.Remove(new Message { Id = id });
            context.SaveChanges();
        }

        public Message? GetMessage(int id)
        {
            return context.Messages.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Message>? GetMessages(int chatid)
        {
            return context.Messages.Where(x => x.Chat.Id == chatid);
        }
    }
}

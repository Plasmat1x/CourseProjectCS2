using ServerApp.Interfaces;
using ServerApp.Models;

namespace ServerApp.Controllers
{
    internal class MessageController : IController<Message>
    {

        AppDbContext Context;

        public MessageController(AppDbContext context)
        {
            Context = context;
        }

        public void CREATE(Message entity)
        {
            Context.Messages.Add(entity);
            Context.SaveChanges();
        }

        public void DELETE(int Id)
        {
            Context.Messages.Remove(new Message { Id = Id });
            Context.SaveChanges();
        }

        public Message SELECT(int Id)
        {
            return Context.Messages.FirstOrDefault(x => x.Id == Id);
        }

        public void UPDATE(Message entity)
        {
            Context.Messages.Update(entity);
            Context.SaveChanges();
        }
    }
}

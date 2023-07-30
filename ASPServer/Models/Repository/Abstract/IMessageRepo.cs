using ASPServer.Models.Entity;

namespace ASPServer.Models.Repository.Abstract
{
    public interface IMessageRepo
    {
        public IQueryable<Message>? GetMessages(int chatid);
        public Message? GetMessage(int id);
        public void AddMessage(Message message);
        public void DeleteMessage(int id);
    }
}

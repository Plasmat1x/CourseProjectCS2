using ASPServer.Domain.Entities;

namespace ASPServer.Domain.Repositories.Abstract
{
    public interface IMessageRepository
    {
        IQueryable<Message> GetAll();
        Message getMessage(int id);
        void CreateMessage(Message message);
        void UpdateMessage(Message message);
        void DeleteMessage(int id);

    }
}

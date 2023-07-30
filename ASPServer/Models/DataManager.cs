using ASPServer.Models.Repository.Abstract;

namespace ASPServer.Models
{
    public class DataManager
    {
        public IChatRepo ChatRepo { get; set; }
        public IMessageRepo MessageRepo { get; set; }
        public IUserRepo UserRepo { get; set; }
        public DataManager(IUserRepo userRepo, IChatRepo chatRepo, IMessageRepo messageRepo)
        {
            ChatRepo = chatRepo;
            MessageRepo = messageRepo;
            UserRepo = userRepo;
        }
    }
}

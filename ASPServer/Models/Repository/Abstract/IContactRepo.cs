using ASPServer.Models.Entity;

namespace ASPServer.Models.Repository.Abstract
{
    public interface IContactRepo
    {
        public ICollection<Contact> GetContacts(User user);
        public void AddContact(User user);
        public void RemoveContact(User user);
        public void UpdateContact(User user);
    }
}

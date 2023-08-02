using ASPServer.Models.Entity;
using ASPServer.Models.Repository.Abstract;

namespace ASPServer.Models.Repository.EF
{
    public class ContacEF : IContactRepo
    {
        public void AddContact(User user)
        {
            throw new NotImplementedException();
        }

        public ICollection<Contact> GetContacts(User user)
        {
            throw new NotImplementedException();
        }

        public void RemoveContact(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateContact(User user)
        {
            throw new NotImplementedException();
        }
    }
}

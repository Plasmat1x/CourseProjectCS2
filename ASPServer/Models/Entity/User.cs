namespace ASPServer.Models.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<UserChat> Chats { get; set; }

    }
}

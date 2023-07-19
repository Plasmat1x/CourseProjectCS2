namespace ServerApp.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Contacts { get; set; }
        public ICollection<Chat> Chats { get; set; }
    }
}

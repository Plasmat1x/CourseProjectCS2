namespace ServerApp.Models
{
    internal class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Message> messages { get; set; }
    }
}

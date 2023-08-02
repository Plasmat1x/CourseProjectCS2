namespace ASPServer.Models.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int FromUserId { get; set; }
        public int ChatId { get; set; }

        public User FromUser { get; set; }
        public Chat Chat { get; set; }
    }
}

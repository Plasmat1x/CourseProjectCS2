namespace ASPServer.Models.Entity
{
    public class Chat
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<Message>? Messages { get; set; }
        public virtual ICollection<User>? Users { get; set; }

    }
}

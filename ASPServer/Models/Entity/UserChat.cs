namespace ASPServer.Models.Entity
{
    public class UserChat
    {
        public int UserId { get; set; }
        public int ChatId { get; set; }
        public DateTime AddedTime { get; set; }

        public User User { get; set; }
        public Chat Chat { get; set; }
    }
}

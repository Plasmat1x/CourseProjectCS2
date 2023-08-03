namespace ASP.WEB.API.Context.Entities
{
    public class Message
    {
        public int SenderId { get; set; }
        public int ChatId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Chat Chat { get; set; }
        public User Sender { get; set; }
    }
}

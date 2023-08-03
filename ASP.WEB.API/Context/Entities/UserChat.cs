namespace ASP.WEB.API.Context.Entities
{
    public class UserChat
    {
        public int UserId { get; set; }
        public int ChatId { get; set; }
        public DateTime AddedTime { get; set; } = DateTime.Now;

        public User User { get; set; }
        public Chat Chat { get; set; }
    }
}

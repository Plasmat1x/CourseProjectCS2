namespace ASPServer.Models.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created_at { get; set; }

        public virtual User? To_user { get; set; }
        public virtual User? From_user { get; set; }
        public virtual Chat? Chat { get; set; }
    }
}

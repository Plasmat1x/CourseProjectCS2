namespace ASPServer.Models.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public int To_id { get; set; }
        public int From_id { get; set; }
        public string Content { get; set; }
        public DateTime Created_at { get; set; }

        public User To_user { get; set; }
        public User From_user { get; set; }
    }
}

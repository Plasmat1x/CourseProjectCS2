namespace ASPServer.Models.Entity
{
    public class Contact
    {
        public int OwnerId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public User Owner { get; set; }
        public User User { get; set; }
    }
}

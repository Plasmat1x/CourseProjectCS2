namespace ASPServer.Models.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public virtual ICollection<User> Contacts { get; set; }
    }
}

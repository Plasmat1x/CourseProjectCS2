namespace ASP.WEB.API.Context.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public ICollection<UserChat> UserChats { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}

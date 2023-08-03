using System;

namespace WpfTest.Models.Data
{
    public class Contact
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int OwnerId { get; set; }
        public int UserId { get; set; }

        public User Owner { get; set; }
        public User User { get; set; }
    }
}

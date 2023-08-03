using System;
using System.Collections.Generic;

namespace WpfTest.Data
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public ICollection<Message>? Messages { get; set; }
        public ICollection<UserChat>? UserChats { get; set; }

        public int OwnerId { get; set; }
        public User? Owner { get; set; }
    }
}

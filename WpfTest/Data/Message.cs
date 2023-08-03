using System;

namespace WpfTest.Data
{
    public class Message
    {
        public int SenderId { get; set; }
        public int ChatId { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Chat Chat { get; set; }
        public User Sender { get; set; }

        public override string ToString()
        {
            return $"[{CreatedAt}] From {Sender.Name}: {Text}";
        }
    }
}

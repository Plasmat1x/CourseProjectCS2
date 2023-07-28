using System;

namespace WpfTest.Models.Data
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

        public override string ToString()
        {
            return $"[{Created_at}] From {From_id}: {Content}";
        }
    }
}

namespace ServerApp.Models
{
    internal class Message
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Chat { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}

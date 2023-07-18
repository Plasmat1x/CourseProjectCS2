namespace ServerApp.Models
{
    [Serializable]
    internal class Message
    {
        public string Id { get; set; }
        public string Sender { get; set; }
        public string Chat { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}

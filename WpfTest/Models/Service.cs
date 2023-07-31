using System.Net.Http;

namespace WpfTest.Models
{
    static class Service
    {
        static public string Host { get; } = "https://localhost:7141";
        static public HttpClient Client { get; } = new HttpClient();
    }
}

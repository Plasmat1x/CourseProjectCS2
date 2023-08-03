using System.Collections;
using System.Net.Http;
using WpfTest.Models.Data;

namespace WpfTest.Models
{
    static class Service
    {
        //static public string Host { get; } = "https://localhost:7141";
        static public string Host { get; } = "http://localhost:5039";
        //static public string Host { get; } = "http://localhost:5000";
        static public HttpClient Client { get; } = new HttpClient();
        static public User User { get; set; } = null;
        static public ICollection chats { get; set; } = null;
    }
}

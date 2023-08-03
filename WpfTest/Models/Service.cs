using System.Collections;
using System.Net.Http;
using WpfTest.Models.Data;

namespace WpfTest.Models
{
    static class Service
    {
        //static public string Host { get; } = "https://localhost:7141";
        public static string Host { get; } = "http://localhost:5039";
        //static public string Host { get; } = "http://localhost:5000";
        public static HttpClient Client { get; } = new HttpClient();
        public static User User { get; set; } = null;
        public static ICollection chats { get; set; } = null;
    }
}

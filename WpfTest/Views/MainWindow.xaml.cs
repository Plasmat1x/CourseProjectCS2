using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using WpfTest.Models.Data;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string host = "https://localhost:7141";
        List<Message> msgs;
        apiclass apic;

        public MainWindow()
        {
            InitializeComponent();
            apic = new apiclass(host);
        }
    }

    public class apiclass
    {
        string host;

        HttpClient client;

        public apiclass(string host)
        {
            this.host = host;
            this.client = new HttpClient();
        }

        public async Task<List<Message>> GetMessages()
        {
            var response = await client.GetAsync($"{host}/api/messages");

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                if (!string.IsNullOrEmpty(json))
                {
                    List<Message> msgs = JsonSerializer.Deserialize<List<Message>>(json);
                    return msgs;
                }
            }
            return new List<Message>();
        }

        public async Task SendMessage(Message msg)
        {
            var msgj = JsonSerializer.Serialize(msg);
            var content = new StringContent(msgj, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{host}/api/messages", content);
        }
    }
}

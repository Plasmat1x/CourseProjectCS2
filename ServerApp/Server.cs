using ServerApp.Models;
using System.Net;
using System.Net.Sockets;

namespace ServerApp
{
    internal class Server
    {
        string? addr;
        int port;

        CancellationToken token;

        private Socket Listener;
        private List<Client> clients = new List<Client>();

        AppDbContext appDbContext;

        public Server(CancellationToken token)
        {
            this.addr = Program.appSettings.ipaddress;
            this.port = Program.appSettings.port;
            this.token = token;

            appDbContext = new AppDbContext();

            appDbContext.Users.Add(new User { Name = "Admin" });
            appDbContext.SaveChanges();
        }

        public void RemoveConnection(string id)
        {
            Client client = clients.FirstOrDefault(x => x.Id == id);

            if (client != null)
            {
                clients.Remove(client);
            }

            client?.Close();
        }

        public async Task ListenAsync()
        {
            try
            {
                Listener = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                Listener.Bind(new IPEndPoint(IPAddress.Parse(addr), port));
                Listener.Listen();

                while (!token.IsCancellationRequested)
                {
                    await ProcessAsync(Listener.Accept());
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine($"{e.ToString()}\n{e.Message}");
            }
            finally
            {
                Disconnect();
            }
        }

        private async Task ProcessAsync(Socket client)
        {
            //TODO: process clients

            Client clientobject = new Client(client, this);
            clients.Add(clientobject);

            Task.Run(clientobject.ProcessAsync);
        }

        private void Disconnect()
        {
            foreach (var c in clients)
            {
                c.Close();
            }

            Listener.Close();
        }
    }
}

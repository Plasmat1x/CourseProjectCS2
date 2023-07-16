using ServerApp.Service;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ServerApp
{
    internal class Application
    {
        AppSettings config;

        Socket Listener;

        CancellationTokenSource cancellationTokenSource;
        CancellationToken token;

        public Application(AppSettings config)
        {
            this.config = config;
            cancellationTokenSource = new CancellationTokenSource();
            token = cancellationTokenSource.Token;
        }

        public void Run()
        {
            //Begin Test
            Console.WriteLine("Configuration: {0}", TestConfiguratuin().ToString());

            //end Test

            Task t = Task.Run(ListenAsync, token);

            while (!token.IsCancellationRequested)
            {
                Console.Write("> ");
                string c = Console.ReadLine();

                if (c == "shutdown")
                {
                    Shutdown();
                }
            }

        }

        private bool TestConfiguratuin()
        {
            if (config.ipaddress != null &&
                config.ipaddress.Length > 0 &&
                config.port > 0 &&
                config.connectionString != null &&
                config.connectionString.Length > 0)
            {
                Console.WriteLine(ConfigMessage());
                return true;
            }
            return false;
        }

        private string ConfigMessage()
        {
            string res = string.Empty;

            res += $"Ip address: {config.ipaddress}\n" +
                   $"Port: {config.port}\n" +
                   $"Conntection string: {config.connectionString}";

            return res;
        }

        private void ExitMsg()
        {
            Console.WriteLine("\n\n=========Press any key to close=========");
            Console.ReadKey();
        }

        private async Task ListenAsync()
        {
            try
            {
                Listener = new Socket(IPAddress.Any.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                Listener.Bind(new IPEndPoint(IPAddress.Parse(config.ipaddress), config.port));
                Listener.Listen();

                Console.WriteLine("start listen thread");
                while (!token.IsCancellationRequested)
                {
                    Socket client = Listener.Accept();
                    await ProcessAsync(client);
                }
                Console.WriteLine("end listen thread");
            }
            catch (SocketException e)
            {
                Console.WriteLine($"{e.ToString()}\n{e.Message}");
            }

        }

        private async Task ProcessAsync(Socket client)
        {
            //TODO: process clients

            Recive(client);


            string response = "";

            response += $"{client.RemoteEndPoint.ToString()}";

            //SendData(client, Encoding.UTF8.GetBytes(response));

            client.Send(Encoding.UTF8.GetBytes("Server close connection"));
            client.Close();
        }

        private void SendData(Socket client, byte[] data)
        {
            client.Send(data);
        }

        private void Recive(Socket client)
        {
            byte[] data = new byte[1024];
            int count = client.Receive(data);

            Console.WriteLine($"[{DateTime.Now}] {client.RemoteEndPoint.ToString()}: {Encoding.UTF8.GetString(data, 0, count)}");

        }

        private void CloseConnection(Socket client)
        {
            client.Shutdown(SocketShutdown.Both);
            client.Close();
        }


        private void Shutdown()
        {
            cancellationTokenSource.Cancel();
            ExitMsg();
        }
    }
}

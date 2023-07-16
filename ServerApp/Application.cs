﻿using ServerApp.Service;
using System.Net;
using System.Net.Sockets;

namespace ServerApp
{
    internal class Application
    {
        AppSettings config;

        Socket Listener;

        CancellationTokenSource cancellationTokenSource;
        CancellationToken token;

        List<Client> clients = new List<Client>();

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

        private void Disconnect()
        {
            foreach (var c in clients)
            {
                c.Close();
            }

            Listener.Close();
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
    }
}

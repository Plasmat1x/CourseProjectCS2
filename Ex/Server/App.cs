using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class App
    {
        TcpListener tcpListener = new TcpListener(IPAddress.Any, 11000);
        List<Client> clients = new List<Client>();
        
        protected internal void RemoveConnection(string id)
        {
            Client? client = clients.FirstOrDefault(x => x.Id  == id);
            if(client != null)
            {
                clients.Remove(client);
            }
            client?.Close();
        }

        protected internal async Task ListenAsync()
        {
            try
            {
                tcpListener.Start();
                Console.WriteLine("ServerRunning. Waiting connection");

                while (true)
                {
                    TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();

                    Client client = new Client(tcpClient, this);
                    clients.Add(client);
                    Task.Run(client.ProcessAsync); 
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Disconnect();
            }
        }

        protected internal async Task BroadcastMessageAsync(string msg, string id)
        {
            foreach(var client in clients)
            {
                if(client.Id != id)
                {
                    await client.Writer.WriteAsync(msg);
                    await client.Writer.FlushAsync();
                }
            }
        }
        
        protected internal void Disconnect()
        {
            foreach(var client in clients)
            {
                client.Close();
            }
            tcpListener.Stop();
        }
    }
}

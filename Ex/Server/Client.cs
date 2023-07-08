using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Client
    {
        public string Id { get;} = Guid.NewGuid().ToString();

        public StreamWriter Writer { get; }
        public StreamReader Reader { get; }

        TcpClient client;
        App server;

        public Client(TcpClient c, App a)
        {
            client = c;
            server = a;

            var stream = client.GetStream();
            Reader = new StreamReader(stream);
            Writer = new StreamWriter(stream);
        }

        public void Close()
        {
            Writer.Close();
            Reader.Close();
            client.Close();
        }

        public async Task ProcessAsync()
        {
            try
            {
                string? userName = await Reader.ReadLineAsync();
                string? message = $"[{DateTime.Now}] {userName} Enter chat";
                await server.BroadcastMessageAsync(message, Id);
                Console.WriteLine(message);

                while(true)
                {
                    try
                    {
                        message = await Reader.ReadLineAsync();
                        if (message == null) continue;
                        message = $"[{DateTime.Now}] {userName} {message}";
                        Console.WriteLine(message);
                        await server.BroadcastMessageAsync(message, Id);
                    }
                    catch
                    {
                        message = $"[{DateTime.Now}] {userName} Leave chat";
                        Console.WriteLine(message);
                        await server.BroadcastMessageAsync(message, Id);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                server.RemoveConnection(Id);
            }
            

        }
    }
}

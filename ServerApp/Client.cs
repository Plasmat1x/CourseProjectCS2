using System.Net.Sockets;
using System.Text;

//https://metanit.com/sharp/net/4.4.php

namespace ServerApp
{
    internal class Client
    {
        protected internal string Id { get; } = Guid.NewGuid().ToString();
        protected internal byte[] Reader { get; }

        Socket reciver;
        Application app;

        public Client(Socket reciver, Application app)
        {
            this.reciver = reciver;
            this.app = app;
            this.Reader = new byte[1024];
        }

        public async Task ProcessAsync()
        {
            try
            {
                while (true)
                {
                    try
                    {
                        int size = await reciver.ReceiveAsync(Reader);

                        string msg = $"[{DateTime.Now}] {reciver?.RemoteEndPoint?.ToString()}:{size}: {Encoding.UTF8.GetString(Reader, 0, size)}";

                        Console.WriteLine(msg);

                        byte[] writer = new byte[1024];
                        writer = Encoding.UTF8.GetBytes(msg);

                        await reciver.SendAsync(writer);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                }
                //TODO: Process recived data
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                app.RemoveConnection(this.Id);
            }
        }

        protected internal void Close()
        {
            reciver.Close();
        }
    }
}

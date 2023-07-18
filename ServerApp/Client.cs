using ServerApp.Models;
using ServerApp.Service;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

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
                        /*
                        int size = await reciver.ReceiveAsync(Reader);

                        string msg = $"[{DateTime.Now}] {reciver.RemoteEndPoint.ToString()}:{size}: {Encoding.UTF8.GetString(Reader, 0, size)}";
                        Console.WriteLine(msg);

                        byte[] writer = new byte[1024];
                        writer = Encoding.UTF8.GetBytes(msg);

                        await reciver.SendAsync(writer);
                        */


                        //TODO: ReciveMethod -> Get data deserialize at data.name select action -> on action db process
                        int size = await reciver.ReceiveAsync(Reader);
                        Data o = Deserialize(Reader, size);

                        Message msg = JsonSerializer.Deserialize<Message>(o.Value.ToString());

                        Console.WriteLine($"[{msg.Date.ToString()}] from {msg.Sender} to {msg.Chat}: {msg.Text}");

                        //TODO: SendMethod -> prepare data and on update send data to clients;


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

        public void Close()
        {
            reciver.Close();
        }

        private byte[] Serialize(Data o)
        {
            return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(o));
        }
        private Data Deserialize(byte[] arr, int count)
        {
            Data data;
            data = JsonSerializer.Deserialize<Data>(Encoding.UTF8.GetString(arr, 0, count));

            return data;
        }
    }
}

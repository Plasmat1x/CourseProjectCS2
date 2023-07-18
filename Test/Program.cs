using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ket to start");
            Console.ReadKey();

            App app = new App();
            app.Run();
        }
    }

    public class App
    {
        string serverAddr = "192.168.1.113";
        int serverPort = 11000;

        bool isRun = false;

        Socket sender;

        public App()
        {
            IPAddress addr = IPAddress.Any;
            IPEndPoint ep = new IPEndPoint(addr, serverPort);
            sender = new Socket(addr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Run()
        {
            isRun = true;

            sender.Connect(serverAddr, serverPort);

            while (isRun)
            {
                try
                {
                    string? msg = Console.ReadLine();
                    if (msg != null)
                    {
                        //sender.Send(Encoding.UTF8.GetBytes(msg));

                        SendMessage(msg);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

        void Print(string message)
        {
            if (OperatingSystem.IsWindows())
            {
                var position = Console.GetCursorPosition();
                int left = position.Left;
                int top = position.Top;
                Console.MoveBufferArea(0, top, left, 1, 0, top + 1);
                Console.SetCursorPosition(0, top);
                Console.WriteLine(message);
                Console.SetCursorPosition(left, top + 1);
            }
            else Console.WriteLine(message);
        }
        private byte[] Serialize(Data o)
        {
            return Encoding.UTF8.GetBytes(JsonSerializer.Serialize(o));
        }
        private Data Deserialize(byte[] arr, int count)
        {
            Data? data;
            data = JsonSerializer.Deserialize<Data>(Encoding.UTF8.GetString(arr, 0, count));

            return data;
        }

        private void SendMessage(string message)
        {
            Message msg = new Message();
            msg.Id = Guid.NewGuid().ToString();
            msg.Text = message;
            msg.Sender = Process.GetCurrentProcess().ProcessName + "::" + sender.RemoteEndPoint.ToString();
            msg.Chat = "Server";
            msg.Date = DateTime.Now;

            Data data = new Data();
            data.Name = "Message";
            data.Value = (object)msg;

            sender.Send(Serialize(data));
        }

        private void ReciveMessage()
        {
            byte[] data = new byte[1024];
            int count = sender.Receive(data);

            Data o = Deserialize(data, count);

            if (o == null)
            {
                return;
            }

            Message msg = o.Value as Message;

            Console.WriteLine(o.Name);
            Console.WriteLine(msg.Text);
        }
    }



    [Serializable]
    internal class Message
    {
        public string Id { get; set; }
        public string Sender { get; set; }
        public string Chat { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }

    [Serializable]
    internal class Data
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
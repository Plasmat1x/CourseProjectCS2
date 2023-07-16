using System.Net;
using System.Net.Sockets;
using System.Text;

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

                        sender.Send(Encoding.UTF8.GetBytes(msg));
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
    }
}
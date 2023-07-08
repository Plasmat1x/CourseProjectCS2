namespace Server
{
    class Programm
    {
        static void Main(string[] args)
        {
            App app = new App();

            Task.Run(app.ListenAsync);
            string command = "";
            do
            {
                Console.WriteLine("Enter command:");
                command = Console.ReadLine();
            }
            while (command != "shutdown");
        }
    }
}
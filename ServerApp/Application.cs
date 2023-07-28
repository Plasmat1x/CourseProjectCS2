using ServerApp.Service;

namespace ServerApp
{
    internal class Application
    {
        private AppSettings config;
        private CancellationTokenSource cancellationTokenSource;
        private Server server;
        private CancellationToken token;

        public Application(AppSettings config)
        {
            this.config = config;
            cancellationTokenSource = new CancellationTokenSource();
            token = cancellationTokenSource.Token;

            server = new Server(token);
        }

        public void Run()
        {
            Task t = Task.Run(server.ListenAsync, token);

            Thread.Sleep(500);
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

        private void Shutdown()
        {
            cancellationTokenSource.Cancel();
        }
    }
}

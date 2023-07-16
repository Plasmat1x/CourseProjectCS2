using Microsoft.Extensions.Configuration;
using ServerApp.Service;

namespace ServerApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Appsettings.json", false, false)
                .AddCommandLine(args)
                .AddEnvironmentVariables()
                .Build();

            var config = configBuilder.GetSection("Application");

            AppSettings appSettings = new AppSettings();
            appSettings.ipaddress = config.GetValue<string>("ipaddress");
            appSettings.connectionString = config.GetValue<string>("connectionString");
            appSettings.port = config.GetValue<int>("port");

            Application app = new Application(appSettings);

            app.Run();
        }
    }
}
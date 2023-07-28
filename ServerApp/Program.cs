using Microsoft.Extensions.Configuration;
using ServerApp.Service;

namespace ServerApp
{

    class Program
    {
        static public AppSettings appSettings { get; set; }

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

            appSettings = new AppSettings();
            appSettings.ipaddress = config.GetValue<string>("ipaddress");
            appSettings.connectionString = config.GetValue<string>("connectionString");
            appSettings.port = config.GetValue<int>("port");

            Application app = new Application(appSettings);

            app.Run();
        }
    }
}
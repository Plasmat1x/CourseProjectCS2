using Microsoft.Extensions.Configuration;
using ServerApp.Service;

namespace ServerApp
{
    class Program
    {
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
            appSettings.inport = config.GetValue<int>("inport");
            appSettings.outport = config.GetValue<int>("outport");

            Application app = new Application(appSettings);

            app.Run();
        }
    }
}
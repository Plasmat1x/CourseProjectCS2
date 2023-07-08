using Microsoft.Extensions.Configuration;
using Server.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Application
    {
        AppSettings config;

        public Application(AppSettings config) 
        { 
            this.config = config;
        }

        public void Run()
        {

            Console.WriteLine("Configuration: {0}", TestConfiguratuin().ToString());


            ExitMsg();
        }

        private bool TestConfiguratuin()
        {
            if(config.ipaddress != null && config.ipaddress.Length > 0 && config.port > 0 && config.connectionString != null && config.connectionString.Length > 0)
                return true;

            return false;
        }

        private void ExitMsg()
        {
            Console.WriteLine("\n\n=========Press any key to close=========");
            Console.ReadKey();
        }
    }
}

﻿using Microsoft.Extensions.Configuration;
using ServerApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    internal class Application
    {
        AppSettings config;
        IPEndPoint ep;

        public Application(AppSettings config) 
        { 
            this.config = config;
        }

        public void Run()
        {
            //Begin Test
            Console.WriteLine("Configuration: {0}", TestConfiguratuin().ToString());

            //end Test

            ExitMsg();
        }

        private bool TestConfiguratuin()
        {
            if(config.ipaddress != null && 
                config.ipaddress.Length > 0 && 
                config.inport > 0 && 
                config.outport > 0 && 
                config.connectionString != null && 
                config.connectionString.Length > 0)
                return true;

            return false;
        }

        private void ExitMsg()
        {
            Console.WriteLine("\n\n=========Press any key to close=========");
            Console.ReadKey();
        }

        private async Task ListenAsync()
        {
            try
            {
                
            }
        }
    }
}
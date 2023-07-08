using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server.Server
{
    internal class Server
    {
        IPAddress ipAddr { get; set; }
        int port {get; set;}

        public Server(string addr, int port)
        {
            this.ipAddr = IPAddress.Parse(addr);
            this.port = port;
        }
    }
}

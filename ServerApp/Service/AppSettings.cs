using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp.Service
{
    public class AppSettings
    {
        public string ipaddress { get; set; }
        public int port { get; set; }
        public string connectionString { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.ModelControler.Models
{
    internal class Chat
    {
        public string Id { get; set; }

        public List<User> Users { get; set; }

    }
}

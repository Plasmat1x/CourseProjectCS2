using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
    public class Chat
    {
       public string Name { get; set; }
       public ICollection<string> Users { get; set; }
       public ICollection<string> Messages { get; set; }
    }
}

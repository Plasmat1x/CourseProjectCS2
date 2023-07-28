using System.Collections.Generic;

namespace WpfTest.Models.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<User> Contacts { get; set; }
    }
}

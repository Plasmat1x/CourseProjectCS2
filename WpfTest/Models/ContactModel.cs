using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.Linq;
using WpfTest.Data;

namespace WpfTest.Models
{

    internal class ContactModel : BindableBase
    {
        private readonly ObservableCollection<User> contacts = new ObservableCollection<User>();
        public readonly ReadOnlyObservableCollection<User> ro_contacts;

        public ContactModel()
        {
            ro_contacts = new ReadOnlyObservableCollection<User>(contacts);
        }

        public void AddUser(string uname)
        {
            contacts.Add(new User { Name = uname });
            RaisePropertyChanged("contacts.Count");
        }

        public void RemoveUser(string username)
        {
            contacts.Remove(contacts.FirstOrDefault(x => x.Name == username));
            RaisePropertyChanged("contacts.Count");
        }
    }
}

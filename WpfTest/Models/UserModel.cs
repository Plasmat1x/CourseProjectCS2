using Prism.Mvvm;
using System.Collections.ObjectModel;
using WpfTest.Models.Data;

namespace WpfTest.Models
{

    internal class UserModel : BindableBase
    {
        private readonly ObservableCollection<User> contacts = new ObservableCollection<User>();
        public readonly ReadOnlyObservableCollection<User> ro_contacts;

        public UserModel()
        {
            ro_contacts = new ReadOnlyObservableCollection<User>(contacts);
        }

        public void AddUser(User user)
        {
            contacts.Add(user);
            RaisePropertyChanged("contacts.Count");
        }

        public void RemoveUser(int id)
        {
            contacts.Remove(new User { Id = id });
            RaisePropertyChanged("contacts.Count");
        }
    }
}

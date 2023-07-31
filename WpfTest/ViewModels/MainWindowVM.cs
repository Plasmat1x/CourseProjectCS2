using Prism.Mvvm;
using System.Collections.ObjectModel;
using WpfTest.Models;
using WpfTest.Models.Data;

namespace WpfTest.ViewModels
{
    public class MainWindowVM : BindableBase
    {
        readonly MessageModel message_model = new MessageModel();
        readonly ContactModel contact_model = new ContactModel();
        readonly AccountModel account_model = new AccountModel();

        public string uname { get; set; }
        public User selUser { get; set; }
        public Message selmsg { get; set; }

        public MainWindowVM()
        {
            message_model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            contact_model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            account_model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
        }

        public ReadOnlyObservableCollection<Message> messages => message_model.ro_messages;
        public ReadOnlyObservableCollection<User> contacts => contact_model.ro_contacts;

        public User CurrentUser => account_model.user;
    }
}

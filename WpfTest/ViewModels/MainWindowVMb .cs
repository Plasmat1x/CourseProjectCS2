using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using WpfTest.Models;
using WpfTest.Models.Data;

namespace WpfTest.ViewModels
{
    public class MainWindowVMb : BindableBase
    {
        User current;
        readonly MessageModel message_model = new MessageModel();
        readonly ContactModel contact_model = new ContactModel();

        public string uname { get; set; }
        public User currentUser { get; set; }
        public User selUser { get; set; }
        public Message selmsg { get; set; }

        string host = "https://localhost:7141";

        HttpClient client = new HttpClient();

        public MainWindowVMb()
        {
            message_model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            contact_model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };

            AddMessageCommand = new DelegateCommand<string>(str =>
            {

                if (!string.IsNullOrEmpty(str))
                {
                    Message msg = new Message
                    {
                        Content = str,
                        Created_at = DateTime.Now,
                        From_user = currentUser,
                        To_user = selUser
                    };

                    message_model.AddMessage(msg);
                }
            });

            RemoveUserCommand = new DelegateCommand<string>(username =>
            {
                if (string.IsNullOrEmpty(username)) contact_model.RemoveUser(username);
            });
        }


        public DelegateCommand<string> AddMessageCommand { get; }

        public DelegateCommand<string> AddUserCommand { get; }
        public DelegateCommand<string> RemoveUserCommand { get; }

        public ReadOnlyObservableCollection<Message> messages => message_model.ro_messages;
        public ReadOnlyObservableCollection<User> contacts => contact_model.ro_contacts;
    }
}

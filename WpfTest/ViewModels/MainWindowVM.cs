using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using WpfTest.Models;
using WpfTest.Models.Data;
using WpfTest.Views;

namespace WpfTest.ViewModels
{
    public class MainWindowVM : BindableBase
    {
        User current;
        readonly MessageModel message_model = new MessageModel();
        readonly ContactModel contact_model = new ContactModel();

        public string uname { get; set; }
        public User currentUser { get; set; }
        public User selUser { get; set; }
        public Message selmsg { get; set; }

        string host = "https://localhost:"

        public MainWindowVM()
        {
            Login login = new(this);
            if (login.ShowDialog() == true)
            {
                if (!string.IsNullOrEmpty(uname))
                {
                    currentUser = new User { Name = uname };
                }
            }

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

            RemoveMessageCommand = new DelegateCommand<int?>(id =>
            {
                if (id.HasValue) message_model.RemoveMessage(id.Value);
            });


            AddUserCommand = new DelegateCommand<string>(str =>
            {
                Login add = new Login(this);
                if (add.ShowDialog() == true)
                {
                    if (!string.IsNullOrEmpty(uname))
                    {
                        contact_model.AddUser(uname);
                    }
                }
            });

            RemoveUserCommand = new DelegateCommand<string>(username =>
            {
                if (string.IsNullOrEmpty(username)) contact_model.RemoveUser(username);
            });

            showmsg = new DelegateCommand<string>(msg =>
            {
                if (selmsg != null)
                {
                    MessageBox.Show($"{selmsg.Id}\n{selmsg.Content}\n{selmsg.Created_at}\n{selmsg.From_user?.Name}\n{selmsg.To_user?.Name}");
                }
            });
        }


        public DelegateCommand<string> AddMessageCommand { get; }
        public DelegateCommand<int?> RemoveMessageCommand { get; }

        public DelegateCommand<string> AddUserCommand { get; }
        public DelegateCommand<string> RemoveUserCommand { get; }

        public DelegateCommand<string> showmsg { get; }

        public ReadOnlyObservableCollection<Message> messages => message_model.ro_messages;
        public ReadOnlyObservableCollection<User> contacts => contact_model.ro_contacts;
    }
}

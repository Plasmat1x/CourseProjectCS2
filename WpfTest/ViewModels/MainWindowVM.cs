using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using WpfTest.Models;
using WpfTest.Models.Data;
using WpfTest.Views;

namespace WpfTest.ViewModels
{
    public class MainWindowVM : BindableBase
    {
        User current;
        readonly MessageModel message_model = new MessageModel();
        readonly UserModel user_model = new UserModel();

        public string uname { get; set; }
        public string currentUser { get; set; }

        public MainWindowVM()
        {
            Login login = new(this);
            if (login.ShowDialog() == true)
            {
                if (!string.IsNullOrEmpty(uname))
                {
                    currentUser = uname;
                }
            }

            message_model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };
            user_model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };

            AddMessageCommand = new DelegateCommand<string>(str =>
            {

                if (!string.IsNullOrEmpty(str))
                {
                    Message msg = new Message
                    {
                        From_id = 1,
                        To_id = 2,
                        Content = str,
                        Created_at = DateTime.Now,
                        From_user = new User { Name = currentUser },
                        To_user = null
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
                        user_model.AddUser(new User { Name = uname });
                    }
                }
            });

            RemoveUserCommand = new DelegateCommand<int?>(id =>
            {
                if (id.HasValue) user_model.RemoveUser(id.Value);
            });
        }


        public DelegateCommand<string> AddMessageCommand { get; }
        public DelegateCommand<int?> RemoveMessageCommand { get; }

        public DelegateCommand<string> AddUserCommand { get; }
        public DelegateCommand<int?> RemoveUserCommand { get; }

        public ReadOnlyObservableCollection<Message> messages => message_model.ro_messages;
        public ReadOnlyObservableCollection<User> contacts => user_model.ro_contacts;
    }
}

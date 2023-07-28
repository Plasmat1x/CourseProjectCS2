using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using WpfTest.Models;
using WpfTest.Models.Data;

namespace WpfTest.ViewModels
{
    internal class MainWindowVM : BindableBase
    {
        readonly MessageModel _model = new MessageModel();

        public MainWindowVM()
        {
            _model.PropertyChanged += (s, e) => { RaisePropertyChanged(e.PropertyName); };

            AddCommand = new DelegateCommand<string>(str =>
            {

                if (!string.IsNullOrEmpty(str))
                {
                    Message msg = new Message
                    {
                        Id = _model.ro_messages.Count + 1,
                        From_id = 1,
                        To_id = 2,
                        Content = str,
                        Created_at = DateTime.Now,
                        From_user = null,
                        To_user = null
                    };

                    _model.AddMessage(msg);
                }
            });

            RemoveCommand = new DelegateCommand<int?>(id =>
            {
                if (id.HasValue) _model.RemoveMessage(id.Value);
            });
        }


        public DelegateCommand<string> AddCommand { get; }
        public DelegateCommand<int?> RemoveCommand { get; }

        public ReadOnlyObservableCollection<Message> messages => _model.ro_messages;
    }
}

using Prism.Mvvm;
using System.Collections.ObjectModel;
using WpfTest.Data;

namespace WpfTest.Models
{
    internal class MessageModel : BindableBase
    {
        private readonly ObservableCollection<Message> messages = new ObservableCollection<Message>();
        public readonly ReadOnlyObservableCollection<Message> ro_messages;
        public MessageModel()
        {
            ro_messages = new ReadOnlyObservableCollection<Message>(messages);
        }

        public void AddMessage(Message message)
        {
            messages.Add(message);
            RaisePropertyChanged("messages.Count");
        }
    }
}

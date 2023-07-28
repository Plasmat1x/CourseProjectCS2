using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using WpfTest.Models.Data;

namespace WpfTest.Models
{
    internal class MessageModel : BindableBase
    {
        private readonly ObservableCollection<Message> messages = new ObservableCollection<Message>();
        public readonly ReadOnlyObservableCollection<Message> ro_messages;
        public MessageModel()
        {
            int[] arr = new int[32];

            MessageBox.Show(arr.GetLength(0).ToString());


            for (int i = 0; i < 10; i++)
            {
                ro_messages = new ReadOnlyObservableCollection<Message>(messages);

                if (i % 2 == 0)
                {
                    messages.Add(new Message
                    {
                        Id = i,
                        From_id = 1,
                        To_id = 2,
                        Content = "Ok",
                        Created_at = DateTime.Now,
                        From_user = null,
                        To_user = null
                    });
                }
                else
                {
                    messages.Add(new Message
                    {
                        Id = i,
                        From_id = 2,
                        To_id = 1,
                        Content = "kO",
                        Created_at = DateTime.Now,
                        From_user = null,
                        To_user = null
                    });
                }
            }
        }

        public void AddMessage(Message message)
        {
            messages.Add(message);
            RaisePropertyChanged("messages.Count");
        }

        public void RemoveMessage(int id)
        {
            messages.Remove(new Message { Id = id });
            RaisePropertyChanged("messages.Count");
        }
    }
}

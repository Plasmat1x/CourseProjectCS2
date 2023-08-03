using System.Collections.Generic;
using System.Net.Http.Json;
using System.Windows;
using WpfTest.Data;
using WpfTest.Models;
using WpfTest.Views;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ICollection<Chat> Chats { get; set; }
        public ICollection<Message> Messages { get; set; }

        public Chat SelectedChat { get; set; }
        public User CurrentUser { get; set; }
        public Message SelectedMessage { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            LoginWindow lw = new LoginWindow();
            if (lw.ShowDialog() == true)
            {
                CurrentUser = Service.User;
                Chats = Service.Client.GetFromJsonAsync<ICollection<Chat>>($"{Service.Host}/api/User/Chats?userid={Service.User.Id}").Result;
                ChatsLB.ItemsSource = Chats;
            }
        }
        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            SelectedChat = ChatsLB.SelectedItem as Chat;
            if (SelectedChat != null)
            {
                Messages = Service.Client.GetFromJsonAsync<ICollection<Message>>($"{Service.Host}/api/User/Messages?chatid={SelectedChat.Id}").Result;
                MessagesLB.ItemsSource = Messages;
            }
        }
    }
}

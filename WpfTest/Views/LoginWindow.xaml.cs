using System;
using System.Net.Http.Json;
using System.Windows;
using WpfTest.Data;
using WpfTest.Models;

namespace WpfTest.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public User User => Service.User;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Service.User = Service.Client.GetFromJsonAsync<User>($"{Service.Host}/api/User/User?Name={Username.Text}").Result;

                if (Service.User != null)
                {
                    this.DialogResult = true;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Service.User = null;
                MessageBox.Show("Server is offline\n" + ex.Message);
            }
        }
    }
}

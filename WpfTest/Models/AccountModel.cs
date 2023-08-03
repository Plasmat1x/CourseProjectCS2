using Prism.Mvvm;
using System;
using System.Text.Json;
using System.Windows;
using WpfTest.Models.Data;

namespace WpfTest.Models
{
    class AccountModel : BindableBase
    {
        public User user { get; private set; } = Service.User;

        public AccountModel()
        {

        }

        public void Login(string username)
        {
            var response = Service.Client.GetAsync($"{Service.Host}/api/User/User?Name={username}");
            try
            {
                response.Wait();
                if (response.Result.IsSuccessStatusCode)
                {
                    var json = response.Result.Content.ReadAsStringAsync();
                    json.Wait();

                    MessageBox.Show(json.Result.ToString());
                    if (string.IsNullOrEmpty(json.Result))
                    {
                        Service.User = JsonSerializer.Deserialize<User>(json.Result);
                        RaisePropertyChanged(user.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server is unavailable");
            }
        }

        public void Logout()
        {
            Service.User = null;
            RaisePropertyChanged(user.Name);
        }
    }
}

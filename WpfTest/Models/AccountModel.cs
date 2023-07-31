using Prism.Mvvm;
using System;
using System.Text.Json;
using System.Windows;
using WpfTest.Models.Data;

namespace WpfTest.Models
{
    internal class AccountModel : BindableBase
    {
        public User user { get; private set; }

        public AccountModel()
        {

        }

        public void Login(string username)
        {
            var response = Service.Client.GetAsync($"{Service.Host}/user?uname={username}");
            try
            {
                response.Wait();
                if (response.Result.IsSuccessStatusCode)
                {
                    var json = response.Result.Content.ReadAsStringAsync();
                    json.Wait();
                    if (string.IsNullOrEmpty(json.Result))
                    {
                        user = JsonSerializer.Deserialize<User>(json.Result);
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
            RaisePropertyChanged(user.Name);
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows;
using WpfTest.Models;
using WpfTest.Models.Data;

namespace WpfTest.ViewModels
{
    internal class LoginVM : BindableBase
    {
        public LoginVM()
        {
            Login = new DelegateCommand<string>(async msg =>
            {
                try
                {
                    var response = await Service.Client.GetAsync($"{Service.Host}/api/User/User?Name={msg}");
                    var json = await response.Content.ReadAsStringAsync();

                    Service.User = JsonSerializer.Deserialize<User>(json);

                    string res = "Not logged in";
                    try
                    {
                        res = $"{Service.User.Id} {Service.User.Name}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        MessageBox.Show(res);
                    }

                }
                catch (HttpRequestException hx)
                {
                    MessageBox.Show("Server is offline\n" + hx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            });

        }

        public DelegateCommand<string> Login { get; }
    }
}

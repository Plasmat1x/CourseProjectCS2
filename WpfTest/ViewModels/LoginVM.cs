using Prism.Commands;
using Prism.Mvvm;
using System.Text.Json;
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
                var response = await Service.Client.GetAsync($"{Service.Host}/api/User/User?Name={msg}");
                var json = await response.Content.ReadAsStringAsync();

                Service.User = JsonSerializer.Deserialize<User>(json);
            });

        }

        public DelegateCommand<string> Login { get; }
    }
}

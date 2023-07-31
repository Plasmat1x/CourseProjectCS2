using Prism.Commands;
using Prism.Mvvm;
using WpfTest.Models;
using WpfTest.Models.Data;

namespace WpfTest.ViewModels
{
    internal class LoginVM : BindableBase
    {
        public AccountModel AccountModel { get; private set; } = new AccountModel();

        public LoginVM()
        {
            Login = new DelegateCommand<string>(AccountModel.Login);
        }

        public DelegateCommand<string> Login { get; }

        public User user => AccountModel.user;
    }
}

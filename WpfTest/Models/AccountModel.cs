using Prism.Mvvm;
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
            RaisePropertyChanged(user.Name);
        }

        public void Logout()
        {
            RaisePropertyChanged(user.Name);
        }
    }
}

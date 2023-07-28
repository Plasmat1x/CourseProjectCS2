using System.Windows;
using WpfTest.ViewModels;

namespace WpfTest.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public MainWindowVM vm;

        public Login(MainWindowVM vm)
        {
            InitializeComponent();

            this.vm = vm;
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            vm.uname = Username.Text;
            this.DialogResult = true;
        }
    }
}

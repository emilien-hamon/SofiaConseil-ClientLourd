using System.Windows;

namespace SofiaConseil.Wpf
{
    public partial class LoginWindow : Window
    {
        private const string CorrectUsername = "admin";
        private const string CorrectPassword = "Not24get";

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            if (username == CorrectUsername && password == CorrectPassword)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                ErrorMessageTextBlock.Text = "Identifiant faux, réessayez";
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ModelsBookShop
{
    /// <summary>
    /// Логика взаимодействия для SignInWindow.xaml
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();

            db.Roles.Add(new Role { Id = 1, Name = "Director" });
            db.Roles.Add(new Role { Id = 2, Name = "Employer" });
        }

        private void RegisterClicked(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registerWindow = new RegistrationWindow();
            registerWindow.Show();
            Close();
        }

        private void SignInClicked(object sender, RoutedEventArgs e)
        {

            var login = LoginTb.Text;
            var password = PasswordTb.Password;

            ApplicationContext db = new ApplicationContext();

            var user = db.Buyers.SingleOrDefault(x => x.Login == login && x.Password == password);
            if (user == null)
            {
                MessageBox.Show("Ошибка", "Пользователь или пароль неверны", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }



            MainWindow menuWindow = new MainWindow();
            App.Current.MainWindow = menuWindow;
            menuWindow.Show();
            this.Close();
        }
    }
}

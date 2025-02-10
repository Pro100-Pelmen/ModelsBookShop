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
using Microsoft.EntityFrameworkCore;

namespace ModelsBookShop
{

    public partial class AddEmployerWindow : Window
    {
        public AddEmployerWindow()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();

        }

        private void BackClicked(object sender, RoutedEventArgs e)
        {
            SignInWindow signInWindow = new SignInWindow();
            signInWindow.Show();
            Close();
        }

        private void RegistrationUserCliked(object sender, RoutedEventArgs e)
        {
            var lastName = LastnameTb.Text;
            var firstName = FirstnameTb.Text;
            var patronycName = PatronymicTb.Text;
            var phone = PhoneTb.Text;
            var login = LoginTb.Text;
            var password = PasswordTb.Text;

            var isLastNameEmpty = string.IsNullOrWhiteSpace(lastName);

            if (isLastNameEmpty)
            {
                MessageBox.Show("Ошибка", "Фамимлия где?", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var isFirstNameEmpty = string.IsNullOrWhiteSpace(firstName);

            if (isFirstNameEmpty)
            {
                MessageBox.Show("Ошибка", "Имя где?", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var isPatronycNameEmpty = string.IsNullOrWhiteSpace(patronycName);

            if (isPatronycNameEmpty)
            {
                MessageBox.Show("Ошибка", "Отчесво где?", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var isPhoneEmpty = string.IsNullOrWhiteSpace(phone);

            if (isPhoneEmpty)
            {
                MessageBox.Show("Ошибка", "Телефон напиши, нам тебе как звонить?", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var isLoginEmpty = string.IsNullOrWhiteSpace(login);

            if (isLoginEmpty)
            {
                MessageBox.Show("Ошибка", "Логин то напиши!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            var isPasswordEmpty = string.IsNullOrWhiteSpace(password);

            if (isPasswordEmpty)
            {
                MessageBox.Show("Ошибка", "Пиши пароль, мы остальным его не покажем!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            ApplicationContext db = new ApplicationContext();

            var isLoginExist = db.Buyers.Any(x => x.Login == login);

            if (isLoginExist)
            {
                MessageBox.Show("Ошибка", "У нас такой уже есть, двоих не вытерпим!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            db.Buyers.Add(new Buyer(lastName, firstName, patronycName, phone, login, password));
            db.SaveChanges();

            SignInWindow signInWindow = new SignInWindow();
            signInWindow.Show();
            Close();
        }
    }
}

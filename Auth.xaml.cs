using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
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

namespace Библиотека
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Auth()
        {
            InitializeComponent();
            DataContext = this;
        }
        string login, password;
        public string Login { get => login; set { login = value; OnPropertyChanged(nameof(Login)); } }
        public string Password { get => password; set { password = value; OnPropertyChanged(nameof(Password)); } }
        private void CancelButton(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void AuthButton(object sender, RoutedEventArgs e)
        {
            if (Data.Users.Any(u => u.Login == Login && u.Password == Password))
            {
                Data.CurrentUser = Data.Users.Where(u => u.Login == Login).FirstOrDefault();
                MessageBox.Show($"Вы вошли как {Data.CurrentUser.Name}");
                new BooksWindow().Show();
                this.Close();
            }
            else MessageBox.Show($"Неверный логин или пароль.");
        }
    }
}

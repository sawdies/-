using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Библиотека
{
    /// <summary>
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Reg()
        {
            InitializeComponent();
            DataContext = this;
        }
        string login, password, name, phone;

        public string Login { get => login; set { login = value; OnPropertyChanged(nameof(Login)); } }
        public string Password { get => password; set { password = value; OnPropertyChanged(nameof(Password)); } }
        public string FIO { get => name; set { name = value; OnPropertyChanged(nameof(FIO)); } }
        public string Phone { get => phone; set { phone = value; OnPropertyChanged(nameof(Phone)); } }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void RegButton(object sender, RoutedEventArgs e)
        {
            if (Data.Users.Any(u => u.Login == Login))
            {
                MessageBox.Show("Пользователь с таким именем уже существует;");
            }
            else
            {
                User newU = new User(Login, Password, FIO, Phone);
                Data.Users.Add(newU);
                Data.CurrentUser = newU;
                MessageBox.Show($"Вы вошли как {Data.CurrentUser.Name}");
                new BooksWindow().Show();
                this.Close();
            }
        }
    }
}

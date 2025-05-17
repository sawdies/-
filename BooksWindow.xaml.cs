using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для BooksWindow.xaml
    /// </summary>
    public partial class BooksWindow : Window
    {
        public BooksWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public ObservableCollection<Book> Books => Data.CurrentUser.Books;

        public string UserName => Data.CurrentUser.Name;

        private void Exit(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void Take(object sender, RoutedEventArgs e)
        {
            new BookSelector().Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Data.CurrentUser.Books[CUB.SelectedIndex].Take();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new NewBook().Show();
        }
    }
}

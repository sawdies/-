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

namespace Библиотека
{
    /// <summary>
    /// Логика взаимодействия для BookSelector.xaml
    /// </summary>
    public partial class BookSelector : Window
    {
        public BookSelector()
        {
            InitializeComponent();
            DataContext = this;
        }
        public List<Book> GetFreeBooks { get; set; } = Data.Books.Where(b => b.Available == Available.yes).ToList();

        private void ListBox_Selected(object sender, RoutedEventArgs e)
        {
            ListBox listBox = sender as ListBox;

            Data.CurrentUser.Books.Add(GetFreeBooks[listBox.SelectedIndex]);
            this.Close();
        }

        private void ListBox_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Data.CurrentUser.Books.Add(GetFreeBooks[List.SelectedIndex]);
            GetFreeBooks[List.SelectedIndex].Take(Data.CurrentUser);
            this.Close();
        }
    }
}

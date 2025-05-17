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
    /// Логика взаимодействия для NewBook.xaml
    /// </summary>
    public partial class NewBook : Window
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public NewBook()
        {
            InitializeComponent();
            DataContext = this;
        }
        string title;
        string genre;
        string description;
        DateTime date;

        public string Titlee
        {
            get { return title; }
            set { title = value; OnPropertyChanged(nameof(Titlee)); }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; OnPropertyChanged(nameof(Genre)); }
        }
        public string Description
        {
            get { return description; }
            set { description = value; OnPropertyChanged(nameof(Description)); }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged(nameof(Date)); }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Book newBook = new Book(Titlee, Genre, Description, Date);
            Data.Books.Add(newBook);
            Close();
            MessageBox.Show($"Добавлена книга. \n\n" +
                $"Название: {newBook.Title}\n" +
                $"Жанр: {newBook.Genre}\n" +
                $"Описание: {newBook.Description}\n" +
                $"Дата: {newBook.Date}");
        }
    }
}

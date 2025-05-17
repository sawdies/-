using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class Book : NotifyPropertyChangedRealization
    {
        private static int count = 0;
        public Book(string title, string genre, string description, DateTime date)
        {
            this.title = title;
            this.genre = genre;
            this.description = description;
            this.date = date;
        }
        public void Take(User user = null)
        {
            if (user is null)
            {
                this.user = null;
                available = Available.yes;
                Data.CurrentUser.Books.Remove(this);
            }
            else
            {
                this.user = user;
                available = Available.issued;
                user.Books.Add(this);
            }
        }
        public override string ToString()
        {
            return $"{title}, {genre}, {date}, свободна: {available}";
        }
        int art = ++count;
        Available available = Available.yes;
        string title;
        string genre;
        string description;
        DateTime date;
        User user;
        public int Art
        {
            get { return art; }
            set { art = value; OnPropertyChanged(nameof(Art)); }
        }
        public string Title
        {
            get { return title; }
            set { title = value; OnPropertyChanged(nameof(Title)); }
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
        public Available Available
        {
            get { return available; }
            set { available = value; OnPropertyChanged(nameof(Available)); }
        }
    }
}

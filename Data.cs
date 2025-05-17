using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Библиотека
{
    class Data : DbContext
    {
        public static DbSet<User> UsersDB { get; set; }
        public static DbSet<Book> BooksDB { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = LibraryBase.db");
        }
        public static User CurrentUser { get; set; }
        public static ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();
        public static ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>()
        {
            new Book("12e32r3","12e32r3","112e3", DateTime.Today),
            new Book("erageag3","1eargae", "ergeg", DateTime.Today),
            new Book("1eargaeg3","1aergeag3","12eeeargr3", DateTime.Today),
            new Book("1aergr3","1g32r3","12e32r3", DateTime.Today),
            new Book("12eaerggeag2r3","12eg2r3","1gyhrq233", DateTime.Today),
            new Book("12eaergaegr3","aerg32r3","thwr23r3", DateTime.Today)
        };

    }
}

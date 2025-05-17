using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека
{
    public class User : NotifyPropertyChangedRealization
    {
        public User(string login, string password, string name, string phone)
        {
            this.login = login;
            this.password = password;
            this.name = name;
            this.phone = phone;
        }
        DateTime regDate = DateTime.Now;
        string login;
        string password;
        string name;
        string phone;

        public ObservableCollection<Book> Books { get; set; } = new ObservableCollection<Book>();

        public string Login
        {
            get { return login; }
            set { login = value; OnPropertyChanged(nameof(Login)); }
        }
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(nameof(Password)); }
        }
        public DateTime RegDate
        {
            get { return regDate; }
            set { regDate = value; OnPropertyChanged(nameof(RegDate)); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; OnPropertyChanged(nameof(Phone)); }
        }
    }
}

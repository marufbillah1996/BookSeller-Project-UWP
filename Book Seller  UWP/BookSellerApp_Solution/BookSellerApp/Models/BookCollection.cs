using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellerApp.Models
{
    public class BookCollection
    {
        ObservableCollection<Book> books;
        public BookCollection()
        {
            this.books = new ObservableCollection<Book>()
            {
                new Book{ Id=1, Name="AloHaan", Price=220.00M, ReleaseDate=new DateTime(2002, 05, 09),Writter="Ronin",Image="Assets/AloHan.jpg"},
                new Book{ Id=2, Name="Bacchader Rabindranath", Price=150.00M, ReleaseDate=new DateTime(2010, 01, 08),Writter="Dr.Shamayl", Image="Assets/Bacchader.jpg"},
                new Book{ Id=3, Name="Lalu", Price=180.00M, ReleaseDate=new DateTime(1998, 10, 12),Writter="Sharathchandra",Image="Assets/Lalu.jpg"},
                new Book{ Id=4, Name="Opekkha", Price=89000.00M, ReleaseDate=new DateTime(2019, 10, 12),Writter="Humaun Ahamed",Image="Assets/Opekkha.jpg"},
                new Book{ Id=5, Name="Shikar", Price=65000.00M, ReleaseDate=new DateTime(2020, 10, 12), Writter="Sangraah",Image="Assets/Shikar.jpg"},
                new Book{ Id=6, Name="Tin Purush", Price=65000.00M, ReleaseDate=new DateTime(2020, 10, 12),Writter="Shomresh Boshu",Image="Assets/TinPurush.jpg"}
            };
        }
        public ObservableCollection<Book> Get()
        {
            return this.books;
        }
        public Book Get(int id)
        {
            return this.books.First(x => x.Id == id);
        }
    }
}

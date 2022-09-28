using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSellerApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Decimal Price { get; set; }
        public string Writter { get; set; }
        public string Image { get; set; }
        public string ReleasedOn { get => this.ReleaseDate.ToString("MMM yyyy"); }
    }

}

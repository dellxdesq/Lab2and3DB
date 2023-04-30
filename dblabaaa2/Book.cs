using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dblabaaa2
{
    public class Book
    {
        public Book(string? name, string? author, int? yearPublished, uint? bookCase, uint? bookShelf)
        {
            Name = name;
            Author = author;
            YearPublished = yearPublished;
            BookCase = bookCase;
            BookShelf = bookShelf;
        }

        public Book(List<string> data)
        {
            Name = data[0];
            Author = data[1];
            YearPublished = int.Parse(data[2]);
            BookCase = uint.Parse(data[3]);
            BookShelf = uint.Parse(data[4]);
        }

        public override string ToString()
        {
            return Name + " " + Author + " " + YearPublished + " " + BookCase + " " + BookShelf;
        }

        public string? Name { get; set; }
        public string? Author { get; set; }
        public int? YearPublished { get; set; }
        public uint? BookCase { get; set; }
        public uint? BookShelf { get; set; }

    }
}

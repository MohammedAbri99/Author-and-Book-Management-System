using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author_and_Book_Management_System
{
    internal class Book
    {
        string title;
        int publicationYear;
        string genre;

        public Book(string title,int pubYear, string gnre)
        {
            this.title = title;
            this.publicationYear = pubYear;
            this.genre = gnre;
        }
        public void displayBookInfo()
        {
            Console.WriteLine($"Book Information:_\n" +
                $"Title: {this.title}\n" +
                $"Publication Year: {this.publicationYear}\n" +
                $"Genre: {this.genre}");
        }
    }
}

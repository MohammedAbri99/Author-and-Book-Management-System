using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author_and_Book_Management_System
{
    internal class Author
    {
        string authorName;
        int birthYear;
        string nationality;
        List<Book> books = new List<Book> { };
        public string AuthorName
        {
            get { return authorName; }
        }

        public Author(string autName, int byear, string nationality)
        {
            this.authorName = autName;
            this.birthYear = byear;
            this.nationality = nationality;
        }

        public void diplayAuthorInfo()
        {
            Console.WriteLine($"Auther Name: {this.authorName}\n" +
                $"Birth Year: {this.birthYear}\n" +
                $"Nationality: {this.nationality}\n");
        }

        public void addBook(Book book)
        {
            this.books.Add(book);
        }

        public void displayBooks()
        {
            foreach (Book book in this.books)
            {
                book.displayBookInfo();
                Console.WriteLine();
            }
        }


    }
}

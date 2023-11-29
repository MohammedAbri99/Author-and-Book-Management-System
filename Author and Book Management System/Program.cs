namespace Author_and_Book_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Author and Book Management System!");
            Author auther1 = new Author("J.K. Rowling", 1965, "British");

            Book book1 = new Book("Harry Potter and the Philosopher's Stone",1997, "Fantasy");
            Book book2 = new Book("Harry Potter and the Chamber of Secrets", 1998, "Fantasy");
            Book book3 = new Book("Harry Potter and the Prisoner of Azkaban", 1999, "Fantasy");

            auther1.addBook(book1);
            auther1.addBook(book2);
            auther1.addBook(book3);
            Console.WriteLine();
            Console.WriteLine("Author Information:_");
            auther1.diplayAuthorInfo();
            auther1.displayBooks();
        }
    }
}
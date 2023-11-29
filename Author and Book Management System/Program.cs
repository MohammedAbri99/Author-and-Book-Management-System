namespace Author_and_Book_Management_System
{
    internal class Program
    {
        static void Main(string[] arge)
        {

            string authorName;
            do
            {
                authorName= "J.K. Rowling";             //change the string with console.readline() to validate uest input.
            } while (authorName.Any(char.IsDigit));

            int BD;
            do
            {
                BD = 1995;                              //change the string with console.readline() to validate uest input.
            } while (int.TryParse("1965",out BD) && (BD<=0 || BD>2023));

            string nationality;
            do
            {
                nationality = "British";                //change the string with console.readline() to validate uest input.
            } while (nationality.Any(char.IsDigit));

            Console.WriteLine("Welcome to the Author and Book Management System!\n");
            Author Rowling = new Author(authorName, BD, nationality);

            Rowling.diplayAuthorInfo();
            Console.WriteLine($"Adding Books for {Rowling.AuthorName}: ");



            Book book1 = new Book("Harry Potter and the Philosopher's Stone", 1997, "Fantasy");
            Book book2 = new Book("Harry Potter and the Chamber of Secrets", 1998, "Fantasy");
            Book book3 = new Book("Harry Potter and the Prisoner of Azkaban", 1999, "Fantasy");

            Rowling.addBook(book1);
            Rowling.addBook(book2);
            Rowling.addBook(book3);
            Console.WriteLine();
            Console.WriteLine("Author Information:_");


            Rowling.displayBooks();
        }
    }
}
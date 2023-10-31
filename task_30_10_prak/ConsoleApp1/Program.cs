
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Product[] books = new Book[0];
            Product book = new Book();
            library.AddBook(book);
            book.Name = "Test";
            book.Price = 15;
            ((Book)book).AuthorName = "King";
            ((Book)book).PageCount = 250;
            book.ShowInfo();
            Product book1 = new Book();
            book1.Name = "Rusif";
            book1.Price = 1;
            library.AddBook(book1);
            book1.ShowInfo();
            library.GetBookById(2);
        }

    }
}

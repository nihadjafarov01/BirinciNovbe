namespace ConsoleApp1;

internal class Library
{
    public Product[] books= new Book[0];
    //Book books = new Book[0];
    public void AddBook(Product book)
    {
        Array.Resize(ref books, books.Length+1);
        books[books.Length-1] = book;
    }
    public void GetBookById(uint id) 
    {
        foreach (var item in books)
        {
            if(item.Id == id)
            {
                Console.WriteLine(item.Name);
            }
        }
    }

}

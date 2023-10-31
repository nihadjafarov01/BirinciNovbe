using System.Threading.Channels;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp1;

internal class Book : Product
{
    //Product book = new Book("kitab", 10, "Steven", 200);
    //public Product[] books = new Book[0];

    public string AuthorName { get; set; }
    public uint PageCount { get; set; }
    public override void Sell()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"Name: {Name}\nId: {Id}";
    }

    public override void ShowInfo()
    {
        Console.WriteLine(this);
    }
}

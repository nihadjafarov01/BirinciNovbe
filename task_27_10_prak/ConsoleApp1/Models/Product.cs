namespace ConsoleApp1.Models;

internal class Product
{
    public int Count { get; set; }
    public int Price{ get; set; }

    public Product(int count, int price)
    {
        Count = count;
        Price = price;
    }
}

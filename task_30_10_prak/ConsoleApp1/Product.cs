namespace ConsoleApp1;

internal abstract class Product
{
    public static uint id = 0;
    public uint Id { get; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Count { get; set; }
    public string TotalInCome { get; set; }
    public abstract void Sell();
    public abstract void ShowInfo();
    public Product()
    {
        id++;
        Id = id;
    }
}

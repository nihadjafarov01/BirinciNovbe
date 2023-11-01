namespace Core.Models;

public class BasketItem
{
    public Book Book { get; set; }
    public int Count { get; set; }
    public byte DiscountPercent { get; set; }
}

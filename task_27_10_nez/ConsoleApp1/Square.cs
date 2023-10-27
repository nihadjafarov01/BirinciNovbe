namespace ConsoleApp1;

internal class Square:Figure
{
    public int side;
    public int Side
    {
        get => Side;
        set
        {
            if (value > 0)
            {
                side = value;
            }
            else
            {
                Console.WriteLine("Side menfi ola bilmez");
                side = Side;
            }
        } 
    }

    public Square(int side)
    {
        this.side = side;
    }

    public override void CalcArea()
    {
        Console.WriteLine($"Area: {Side*4}");
    }
}

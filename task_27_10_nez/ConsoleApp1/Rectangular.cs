namespace ConsoleApp1;

internal class Rectangular : Figure
{
    int _width;
    int _length;

    public int Width 
    { 
        get => _width;
        set
        {
            if (value >= 0) 
            {
                _width = value;
            }
        }
    }

    public int Length
    {
        get => _length;
        set
        {
            if (value >= 0)
            {
                _length = value;
            }
        }
    }

    public Rectangular(int width, int length)
    {
        Width = width;
        Length = length;
    }

    public override void CalcArea()
    {
        Console.WriteLine($"Area: {Width*Length}");
    }
}

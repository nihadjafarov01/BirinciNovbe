using System.Xml.Linq;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Square a = new Square(1);
        Rectangular b = new Rectangular(2, 3);

        byte option;
        Console.WriteLine("1. Square\n2. Restangular\n0. Quit");
        do
        {
            option = Convert.ToByte(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Write("Side: ");
                    a.Side = Convert.ToInt32(Console.ReadLine());
                    a.CalcArea();
                    break;
                case 2:
                    Console.Write("Width: ");
                    b.Width = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Length: ");
                    b.Length = Convert.ToInt32(Console.ReadLine());
                    b.CalcArea();
                    break;
            }
        }
        while (option != 0);
    }
}

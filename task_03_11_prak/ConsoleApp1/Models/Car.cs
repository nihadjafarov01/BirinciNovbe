namespace ConsoleApp1.Models;

internal class Car : Vehicle
{
    public int CarProperty { get; set; }
    public override void Drive()
    {
        Console.WriteLine("Car drive");
    }
    public static bool operator <(Car car1, Car car2)
    {
        return car1.Price < car2.Price;
    }
    public static bool operator >(Car car1, Car car2)
    {
        return car1.Price > car2.Price;
    }
    public static bool operator <=(Car car1, Car car2)
    {
        return car1.Price <= car2.Price;
    }
    public static bool operator >=(Car car1, Car car2)
    {
        return car1.Price >= car2.Price;
    }
    public static bool operator ==(Car car1, Car car2)
    {
        return car1.Price == car2.Price;
    }
    public static bool operator !=(Car car1, Car car2)
    {
        return car1.Price != car2.Price;
    }
}

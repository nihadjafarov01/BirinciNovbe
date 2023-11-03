namespace ConsoleApp1.Models;

internal class Bus : Vehicle
{
    public int BusProperty { get; set; }
    public override void Drive()
    {
        Console.WriteLine("Bus drive");
    }

}

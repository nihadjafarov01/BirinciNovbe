namespace ConsoleApp1.Models;

internal abstract class Bird:Animal
{
    public virtual void Fly()
    {
        Console.WriteLine("Flyyyyy!!!!");
    }
}

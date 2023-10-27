using ConsoleApp1.Models;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        //Animal ani = new Animal();
        Dolphin dolphin = new Dolphin();
        Owl owl = new Owl();

        dolphin.Swim();
        owl.Fly();
    }
}

using ConsoleApp1.Models;
using System.Text.RegularExpressions;

namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Models.Group qrup1 = new(100, "MIT");
  

        Models.Group qrup2 = new Group()
        {
            StudentCount = 150,
            Faculty = "Memarliq",
        };

        char option;
        Console.WriteLine("1 - Yeni telebe yarat\n2 - Yeni qrup yarat\n3 - Yeni ders yarat\n4 - Yeni netice yarat");
        do
        {
            option = Convert.ToChar(Console.ReadLine());
        }
        while (option != 'q') ;
    }
}

using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pro1 = new Product(3, 800);
            Notebook note1 = new Notebook(pro1.Count,pro1.Price,"asus");
            note1.Model = "a";
            Console.WriteLine(note1.Model);
        }
    }
}

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Isa";
            Console.WriteLine(name.Contains('a'));
            Console.WriteLine(name.CustomContains('a'));
        }
    }
}

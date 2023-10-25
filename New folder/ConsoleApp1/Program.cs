using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintFullName("Nihad");
            PrintFullName("Nihad", "Jafarov");
            PrintFullName("Nihad", 20);
        }

        static void PrintFullName(string name)
        {
            Console.WriteLine("User name is " + name);
        }

        static void PrintFullName(string name, string username)
        {
            Console.WriteLine("User fullname is " + name + " " + username);
        }

        static void PrintFullName(string name, int age)
        {
            Console.WriteLine("User fullname is " + name + " " + age);
        }

    }
}   

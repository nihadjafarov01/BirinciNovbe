using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                _name = "Nihad",
                Surname = "Jafarov",
                Age = 16,
                Birthday = "16.02.2003",
                PhoneNumber = "+994567"
            };
            Console.WriteLine(person1.phoneNumber);

        }
    }
}

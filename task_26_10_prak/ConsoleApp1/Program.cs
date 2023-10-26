using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Nihad", "Jafarov", 20)
            {
                Name = "Nihad",
                Surname = "Jafarov",
                Age = 20,
            };
            // Console.WriteLine($"{student1.ToString()}");
            // Console.WriteLine($"{student1.Name} {student1.Surname} {student1.Age}");

            //(string, string, byte) person = ("Nihad","Jafarov",20);
            //var person1 = Tuple.Create("Nihad","Jafarov",20);
            //Console.WriteLine(person);
            //Console.WriteLine(person1);
            //GetEmployee();
            GetEmploye a = new GetEmploye();
            Console.WriteLine(a.GetEmployee()); 


        }

        
    }
}

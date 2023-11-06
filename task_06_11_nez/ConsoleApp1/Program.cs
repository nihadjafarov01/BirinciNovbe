using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        //delegate Person (string name);

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "Nihad", Surname = "Jafarov", Age = 20 });
            people.Add(new Person { Name = "Nigar", Surname = "Abbasova",Age = 50 });
            var name = people.FindAll(x => x.Name.Length == 4);
            var surname = people.FindAll(x => x.Surname.EndsWith("ov") || x.Surname.EndsWith("ova"));
            var age = people.FindAll(x => x.Age > 18);
            foreach (var item in age)
            {
                Console.WriteLine(item.Age);
            }
        }
    }
}

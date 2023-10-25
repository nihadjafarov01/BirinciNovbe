namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Nihad", "Jafarov");
            Student student2 = new Student("Vuqar", "Samedov");
            Student[] array = new Student[] { student1, student2 };
            foreach (Student s in array)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
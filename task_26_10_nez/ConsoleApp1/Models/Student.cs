namespace ConsoleApp1.Models;

public class Student
{
    public string Name { get ; set ; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public Group Group { get; set; }
    public Result[] Result { get; set; }

    Student telebe1 = new Student()
    {
        Name = "Nihad",
        Surname = "Jafarov",
        Age = 20,
    };
}

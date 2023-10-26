namespace ConsoleApp1.Models;

public record Group
{
    public int StudentCount { get; set; }
    public string Faculty { get; set; }

    Group qrup1 = new Group()
    {
        StudentCount = 100,
        Faculty = "MIT",
    };

    Group qrup2 = new Group()
    {
        StudentCount = 150,
        Faculty = "Memarliq",
    };
}

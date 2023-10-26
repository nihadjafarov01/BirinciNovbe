namespace ConsoleApp1.Models;

public record Student(string Name,string Surname, byte Age)
{
    public string Name { get; init; }
    public string Surname { get; init; }
    public byte Age { get; init; }
}

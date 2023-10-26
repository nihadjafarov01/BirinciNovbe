namespace ConsoleApp1.Models;

internal class GetEmploye
{
    public Tuple<string, string, int> GetEmployee()
    {
        var Employee = Tuple.Create("Nihad", "Jafarov", 20);
        return Employee;
    }
}

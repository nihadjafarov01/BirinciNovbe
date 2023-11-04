namespace ConsoleApp1.Models
{
    internal class Employee: Person
    {
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public Gender Gender { get; set; }
        public override string ToString()
        {
            return $"Id --> {Id}, {Name} {Surname} {Age} {Gender} {Position} {Salary}";
        }
    }
}

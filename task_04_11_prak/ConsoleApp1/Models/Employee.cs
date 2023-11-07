using System;

namespace ConsoleApp1.Models
{
    public class Employee: Person
    {
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public Gender Gender { get; set; }
        public DateTime CreatedAt = new DateTime(2008, 5, 1, 8, 30, 52);
        public DateTime CurrentTime = new DateTime(2008, 5, 1, 8, 30, 52);
        public override string ToString()
        {
            return $"Id --> {Id}, {Name} {Surname} {Age} {Gender} {Position} {Salary}";
        }
    }
}

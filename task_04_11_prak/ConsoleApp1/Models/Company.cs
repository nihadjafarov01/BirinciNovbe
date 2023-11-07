using ConsoleApp1.Exceptions;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    internal class Company
    {
        public string Name { get; set; }
        List<Employee> employees = new List<Employee>();

    }
}

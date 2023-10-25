using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    class Developer : Employee
    {
        public string[] KnownLanguages;

        public void WriteCode()
        {
            
        }

        public Developer(string name, string surname, byte age, byte experience, decimal salary) : base(experience, salary)
        {
            Experience = experience;
            Salary = salary;
        }
    }
}

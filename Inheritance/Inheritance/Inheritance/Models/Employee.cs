using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.Models
{
    class Employee : Person
    {
        public byte Experience;
        public decimal Salary;

        public Employee(string name , string surname, byte age, byte experience, decimal salary) : base( name , surname,  age)
        {
            Experience = experience;
            Salary = salary;
        }

    }
}

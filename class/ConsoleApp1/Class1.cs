using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    public class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Age;
        public bool HasScholarship;

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Person
    {


        private string _name;
        private string _surname;
        private byte _age;
        private string _birthday;
        private string _phoneNumber;

        public string phoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.Length > 12 && value.Substring(0,4) == "+994")
                {
                    _phoneNumber = value;
                }
                else
                {
                    Console.WriteLine("nomre sehvdir"); 
                }
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 2)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("sehvdir");
                }
            }
        }

        public string surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }

        public byte age
        {
            get
            {
                if (_age < 16)
                {
                    Console.WriteLine("balacadir");
                    return _age;
                }
                else
                {
                    return _age;
                }
            }
            set
            {
                _age = value;
            }
        }
    }
}

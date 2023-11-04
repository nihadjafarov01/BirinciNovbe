namespace ConsoleApp1.Models
{
    internal class Person
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public virtual string Fullname() 
        { 
            return Name + " " + Surname;
        }

        public Person()
        {
            Id = _id;
            _id++;
        }
    }
}

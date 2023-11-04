namespace ConsoleApp1.Exceptions
{
    internal class EmployeeNotFound : Exception
    {
        public EmployeeNotFound()
        {
            
        }
        public EmployeeNotFound(string m) : base(m) { }
    }
}
